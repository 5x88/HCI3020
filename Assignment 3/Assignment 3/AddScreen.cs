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
            
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }


        public void addFromWindow()
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

        public void editEntry(Movie movie)
        {

            string genre ="";

            for(int i = 0; i<movie.genre.Length; i++)
            {
                genre += " " + movie.genre[i];
            }

            

            textBox1.Text = movie.title;
            textBox2.Text = "" + movie.year;
            textBox3.Text = movie.actor[0];
            textBox4.Text = movie.actor[1];
            textBox5.Text = movie.actor[2];
            textBox6.Text = movie.actor[3];
            textBox7.Text = movie.actor[4];

            textBox8.Text = movie.certification;
            textBox9.Text = "" + movie.rating;
            textBox10.Text = movie.length;
            textBox11.Text = movie.director;
            textBox12.Text = genre;

            Program.movies.movielist.Remove(movie);


        }



    }
}