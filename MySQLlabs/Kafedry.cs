using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MySQLlabs
{
    public partial class Kafedry : Form
    {
        private MySqlConnection connection;

        public Kafedry()
        {
            InitializeComponent();
            connection = new MySqlConnection("server=localhost;user id=root;persistsecurityinfo=True;database=konferentsiyi");
        }

        private void Kafedry_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'konferentsiyiDataSet.kafedry' table. You can move, or remove it, as needed.
            this.kafedryTableAdapter.Fill(this.konferentsiyiDataSet.kafedry);
        }

        private void executeSql(string query)
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand(query, connection);

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                this.kafedryTableAdapter.Fill(this.konferentsiyiDataSet.kafedry);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            if (this.nazvaKavedryBox.Text == "")
            {
                MessageBox.Show(
                    "Введіть назву кафедри",
                    "Попередження",
                    MessageBoxButtons.OK);
            }
            else
            {
                var nazva = this.nazvaKavedryBox.Text;
                var roztashuvannya = this.roztashuvannyaBox.Text;

                executeSql("INSERT INTO kafedry (nazva_kafedry, roztashuvannya) " +
                    "VALUES('" + nazva + "','" + roztashuvannya + "')");

            }
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            var selectedRows = this.kafedryGridView.SelectedRows;
            DataGridViewRow selectedRow = null;
            if (selectedRows.Count > 0)
            {
                selectedRow = selectedRows[0];
            }
            int idKafedry = Int32.Parse(selectedRow.Cells[0].Value.ToString());
            string nazvaKavedry = nazvaKavedryBox.Text;
            string roztashuvannya = roztashuvannyaBox.Text;

            string query = "UPDATE kafedry SET nazva_kafedry='" + nazvaKavedry + "'," +
                "roztashuvannya='" + roztashuvannya + "' WHERE id_kafedry=" + idKafedry.ToString();
            executeSql(query);
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            var selectedRows = this.kafedryGridView.SelectedRows;
            var idKafedry = selectedRows[0].Cells[0].Value;
            executeSql("DELETE FROM kafedry WHERE id_kafedry=" + idKafedry);
        }

        private void kafedryGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var selectedRows = this.kafedryGridView.SelectedRows;
            DataGridViewRow selectedRow = null;
            if (selectedRows.Count > 0)
            {
                selectedRow = selectedRows[0];
            }

            this.idKafedryBox.Text = selectedRow.Cells[0].Value.ToString();
            this.nazvaKavedryBox.Text = selectedRow.Cells[1].Value.ToString();
            this.roztashuvannyaBox.Text = selectedRow.Cells[2].Value.ToString();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.idKafedryBox.Text = "";
            this.nazvaKavedryBox.Text = "";
            this.roztashuvannyaBox.Text = "";
        }
    }
}
