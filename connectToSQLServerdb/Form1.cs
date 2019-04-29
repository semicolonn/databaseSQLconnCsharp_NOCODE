using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace connectToSQLServerdb
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void stAppTableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.stAppTableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.stAppdbDataSet1);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'stAppdbDataSet1.stAppTable' table. You can move, or remove it, as needed.
            this.stAppTableTableAdapter.Fill(this.stAppdbDataSet1.stAppTable);

        }

     
    }
}
