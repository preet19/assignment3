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
    public partial class StreamForm : Form
    {
        public StreamForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            System.Environment.Exit(1);
        }
    }
}
