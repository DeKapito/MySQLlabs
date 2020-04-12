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
    public partial class LabWindow : Form
    {
        public LabWindow()
        {
            InitializeComponent();
        }

        private void exitMainMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LabWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result = MessageBox.Show(
                "Ви впевнені, що хочете завершити роботу?",
                "Завершити роботу",
                MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
                e.Cancel = false;
            else
                e.Cancel = true;
        }

        private void kafedryMainMenuItem_Click(object sender, EventArgs e)
        {
            Kafedry kafedryForm = new Kafedry();
            kafedryForm.ShowDialog();
        }

        private void mistsyaProzhyvannyaMenuItem_Click(object sender, EventArgs e)
        {
            MistsyaProzhyvannya prozhyvannyaForm = new MistsyaProzhyvannya();
            prozhyvannyaForm.ShowDialog();
        }
    }
}
