using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * 	App name = Movie Bonanza
    Author's name = Dilpreet Singh
    Student	ID = 200306382
    App	Creation Date = 11/11/2016
    App description = This program IS use to select and stream movies
 */

namespace assignment3
{
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cancelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cancel_Click(sender, e);
        }

        private void streamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            streamButton_Click(sender, e);
        }

        private void streamButton_Click(object sender, EventArgs e)
        {
            StreamForm stream = new StreamForm();
            this.Hide();
            stream.Show();
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintPreviewDialog print = new PrintPreviewDialog();
            print.Show();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 	programmer’s	name,	the	
            //version of  the program and a   website and contact number
            String programmerName = "programmer name= Dilpreet,program version =1.0, website= dot.com,contact= 123456789";
          
            
            MessageBox.Show(programmerName);

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (buyMovieCheckBox.Checked)
            {
                additionalLabel.Show();
                additionalTextBox.Show();
                additionalTextBox.Text = "$10.00";
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            SelectForm selection = new SelectForm();
            this.Hide();
            selection.Show();
        }
    }
}
