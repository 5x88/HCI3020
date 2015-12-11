﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq;

namespace Assignment_3
{
    public partial class MainScreen : Form 
    {

        public MainScreen()
        {
            InitializeComponent();
            populateMovieList(Program.movies);
        }

        private void searchButtonGo_Click(object sender, EventArgs e)
        {
            //Variables to compare
            MovieList results = new MovieList();
            string[] search = searchBoxEntry.Text.Split(' ');

            //Run through the list of movies, collecting the results
            foreach (var x in Program.movies.movielist){   
                //If search has any strings in it that title also has in it, return true
                if (search.Where(i => x.title.Contains(i)).Any()) {
                    results.movielist.Add(x);
                }
            }

            //If empty, return no results, otherwise print them in message boxs, fix this later
            if (!results.movielist.Any())
            {
                MessageBox.Show("No results!");

            } else {
                watchListView.Items.Clear();
                populateMovieList(results);
            }

        }

        private void movieListBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void changeToAdvanced_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Visible = false;
            AddWindow add = new AddWindow(this);
            add.Show();
        }

        private void populateMovieList(MovieList list)
        {
            foreach (var x in list.movielist)
            {
                ListViewItem item = new ListViewItem(new String[]
                {
                    x.title,
                    x.year.ToString(),
                    x.genre[0]
                });
                watchListView.Items.Add(item);
            }
        }
    }
}
