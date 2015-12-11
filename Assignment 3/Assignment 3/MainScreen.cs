using System;
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
        MovieList activeList;
        public MainScreen()
        {
            InitializeComponent();
            populateMovieList(Program.watchlist);
            activeList = Program.watchlist;
            this.SetStyle(ControlStyles.StandardDoubleClick, true);
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
                label1.Text = "Search Results";
                watchListView.Items.Clear();
                populateMovieList(results);
                backToWatchList.Enabled = true;
                activeList = results;
            }


        }

        private void movieListBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void changeToAdvanced_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            AdvancedSearch advS = new AdvancedSearch(this);
            advS.Show();
        }

        public void populateMovieList(MovieList list)
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
                activeList = list;
            }
        }

        private void backToWatchList_Click(object sender, EventArgs e)
        {
            searchBoxEntry.Text = "";
            watchListView.Items.Clear();
            label1.Text = "Watch List";
            populateMovieList(Program.watchlist);
            backToWatchList.Enabled = false;
            activeList = Program.watchlist;
        }

        private void watchListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        private void watchListView_onDoubleClick(object sender, EventArgs e)
        {
            MovieScreen selectedMovie = new MovieScreen(activeList.movielist[watchListView.SelectedIndices[0]]);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddWindow addNew = new AddWindow();
            addNew.Show();

            
        }
    }
}
