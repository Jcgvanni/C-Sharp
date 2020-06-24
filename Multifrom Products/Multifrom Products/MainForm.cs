using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multifrom_Products
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void productBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.productDBDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'productDBDataSet.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.productDBDataSet.Product);

        }

        private void showDetailsButton_Click(object sender, EventArgs e)
        {
            //create an instance of the detailsform
            DetailsForm details = new DetailsForm();

            //display the form
            details.ShowDialog();

            //update database
            this.productTableAdapter.Fill(this.productDBDataSet.Product);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //close form
            this.Close();
        }
    }
}
