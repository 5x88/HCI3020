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
    public partial class AddWindow : Form
    {
        MainScreen mainscreen;

        public AddWindow()
        {
            InitializeComponent();
        }
        

        public AddWindow(MainScreen _mainscreen)
        {
            mainscreen = _mainscreen;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addFromWindow();
            mainscreen.Visible = true;
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mainscreen.Visible = true;
            Close();
        }


        private void addFromWindow()
        {
            Movie newMovie;
            
            String[] actors = new String[5];
            String[] genre = textBox12.Text.Split(' ');

            actors[0] = (textBox3.Text);
            actors[1] = (textBox4.Text);
            actors[2] = (textBox5.Text);
            actors[3] = (textBox6.Text);
            actors[4] = (textBox7.Text);


           newMovie = new Movie(textBox1.Text, textBox10.Text, textBox8.Text, textBox11.Text, int.Parse(textBox2.Text),
                int.Parse(textBox9.Text), genre, actors);
            Program.movies.movielist.Add(newMovie);
            Program.writeFile();
        }

    }
}