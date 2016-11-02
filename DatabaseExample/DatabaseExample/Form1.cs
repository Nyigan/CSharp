using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseExample
{
    public partial class frmDatabase : Form
    {
        public frmDatabase()
        {
            InitializeComponent();
        }

        private void tblExampleBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tblExampleBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseExampleDataSet1);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseExampleDataSet1.tblExample' table. You can move, or remove it, as needed.
            this.tblExampleTableAdapter.Fill(this.databaseExampleDataSet1.tblExample);

        }
    }
}
