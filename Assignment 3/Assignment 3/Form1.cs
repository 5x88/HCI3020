using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Assignment_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
        private void addFromWindow()
        {
            Movie newMovie;
            ArrayList genre = new ArrayList();
            ArrayList actors = new ArrayList();

            actors.Add(textBox3.Text);
            actors.Add(textBox4.Text);
            actors.Add(textBox5.Text);
            actors.Add(textBox6.Text);
            actors.Add(textBox7.Text);

            genre.Add(textBox11.Text);

            newMovie = new Movie(textBox1.Text,);



    }
}
