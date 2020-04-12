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
    public partial class MistsyaProzhyvannya : Form
    {
        public MistsyaProzhyvannya()
        {
            InitializeComponent();
        }

        private void MistsyaProzhyvannya_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'konferentsiyiDataSet.mistsya_prozhyvannya' table. You can move, or remove it, as needed.
            this.mistsya_prozhyvannyaTableAdapter.Fill(this.konferentsiyiDataSet.mistsya_prozhyvannya);

        }
    }
}
