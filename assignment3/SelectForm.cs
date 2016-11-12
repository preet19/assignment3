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
    public partial class SelectForm : Form
    {
        public SelectForm()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void MovieListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string text = MovieListBox.GetItemText(MovieListBox.SelectedItem);

            if (text == "Cedar Rapids")
            {
                MoviePictureBox.Image = Properties.Resources.rapids;
                TitleTextBox.Text = text;
                CategoryTextBox.Text = "Comedy";
                CostTextBox.Text = "$1.99";
            }
            else if (text == "Company Men")
            {
                MoviePictureBox.Image = Properties.Resources.CompanyMen;
                TitleTextBox.Text = text;
                CategoryTextBox.Text = "Drama";
                CostTextBox.Text = "$1.99";
            }
            else if (text == "Death Race 2")
            {
                MoviePictureBox.Image = Properties.Resources.race2;
                TitleTextBox.Text = text;
                CategoryTextBox.Text = "Action";
                CostTextBox.Text = "$2.99";
            }
            else if (text == "Footloose")
            {
                MoviePictureBox.Image = Properties.Resources.footloose;
                TitleTextBox.Text = text;
                CategoryTextBox.Text = "New Release";
                CostTextBox.Text = "$4.99";
            }
            else if (text == "Gnomeo and Juliet")
            {
                MoviePictureBox.Image = Properties.Resources.juliet;
                TitleTextBox.Text = text;
                CategoryTextBox.Text = "Comedy";
                CostTextBox.Text = "$1.99";
            }
            
            else if (text == "i am Number Four")
            {
                MoviePictureBox.Image = Properties.Resources.four;
            }
            else if (text == "Just Go With it")
            {
                MoviePictureBox.Image = Properties.Resources.withit;
            }
            else if (text == "No Strings Attached")
            {
                MoviePictureBox.Image = Properties.Resources.attached;
            }
            else if (text == "Real Steel")
            {
                MoviePictureBox.Image = Properties.Resources.steel;
            }
            else if (text == "Sanctum")
            {
                MoviePictureBox.Image = Properties.Resources.Sanctum;
            }
            else if (text == "Season of the witch")
            {
                MoviePictureBox.Image = Properties.Resources.witch;
            }
            else if (text == "The Dilemma")
            {
                MoviePictureBox.Image = Properties.Resources.Dilemma;
            }
            else if (text == "The Eagle")
            {
                MoviePictureBox.Image = Properties.Resources.eagle;
            }
            else if (text == "The Green Hornet")
            {
                MoviePictureBox.Image = Properties.Resources.hornet;
            }
            else if (text == "The Mechanic")
            {
                MoviePictureBox.Image = Properties.Resources.Mechanic;
            }
            else if (text == "The Other Woman")
            {
                MoviePictureBox.Image = Properties.Resources.woman;
            }
            else if (text == "The Rite")
            {
                MoviePictureBox.Image = Properties.Resources.rite;
            }
            else if (text == "The Roommate")
            {
                MoviePictureBox.Image = Properties.Resources.roommate;
            }
            else if (text == "The Way Back")
            {
                MoviePictureBox.Image = Properties.Resources.back;
            }
            else if (text == "Waiting For Forever")
            {
                MoviePictureBox.Image = Properties.Resources.forever;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OrderForm order = new OrderForm();
            this.Hide();
            order.Show();
        }

       
    }
}
