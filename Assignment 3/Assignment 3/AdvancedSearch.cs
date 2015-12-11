using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_3
{
    public partial class AdvancedSearch : Form
    {
        MainScreen parent;
        public AdvancedSearch(MainScreen sender)
        {
            parent = sender;
            sender.Hide();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {

            searchMovies();

            parent.Visible = true;
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void searchMovies()
        {
            MovieList results1 = new MovieList();
            MovieList results2 = new MovieList();
            Boolean added = false;

            string[] search = textBox1.Text.Split(' ');

            foreach (var x in Program.movies.movielist)
            {
                //If search has any strings in it that title also has in it, return true
                if (search.Where(i => x.title.Contains(i)).Any())
                {
                    results1.movielist.Add(x);
                }

            }

            search = textBox2.Text.Split(' ');

            foreach (var x in results1.movielist)
            {
                //If search has any strings in it that director also has in it, return true
                if (search.Where(i => x.director.Contains(i)).Any())
                {
                    results2.movielist.Add(x);
                }
            }

             results1.movielist.Clear();


            search = textBox3.Text.Split(' ');

            foreach (var x in results2.movielist)
            {
                added = false;

                for (int y = 0; y < x.genre.Length; y++)
                {
                    if (search.Where(i => x.genre[y].Contains(i)).Any() && added == false)
                    {
                        results1.movielist.Add(x);
                        added = true;
                    }
                }

            }

             results2.movielist.Clear();

            search = textBox4.Text.Split(' ');

            foreach (var x in results1.movielist)
            {

                added = false;

                for (int y = 0; y < x.actor.Length; y++)
                {
                    if (search.Where(i => x.actor[y].Contains(i)).Any() && added == false)
                    {
                        results2.movielist.Add(x);
                        added = true;
                    }
                }

            }

            results1.movielist.Clear();

                foreach (var x in results2.movielist)
                {

                if(int.Parse(comboBox1.Text)>)

                }

            }
    }
}

