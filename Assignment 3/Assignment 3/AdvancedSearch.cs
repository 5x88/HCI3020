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
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MovieList results = searchMovies();
            ChartScreen chart = new ChartScreen(results);
            parent.watchListView.Items.Clear();
            parent.populateMovieList(results);
            parent.Visible = true;
            parent.label1.Text = "Search Results";
            chart.Show();
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private MovieList searchMovies()
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

            int minYear;
            int MaxYear;

            if (comboBox1.SelectedItem == null && comboBox2.SelectedItem == null)
            {
                minYear = 1900;
                MaxYear = 2015;
            }
            
            
                if (comboBox1.SelectedItem == null)
                {
                    minYear = 1900;
                }
                else
                {
                    minYear = Int32.Parse(comboBox1.Text);
                }

                if (comboBox2.SelectedItem == null)
                {
                    MaxYear = 2015;
                }
                else
                {
                    MaxYear = Int32.Parse(comboBox2.Text);
                }
            

            foreach (var x in results2.movielist)
            {
                if (minYear <= x.year && MaxYear >= x.year)
                {
                    results1.movielist.Add(x);
                }
            }
            return results1;
        }
    }
}

