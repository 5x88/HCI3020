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

        public MainScreen()
        {
            InitializeComponent();


            MovieList movies = new MovieList();
            movies = Program.readFile();
            // Program.watchList.movielist.Add();
            int totalMovies = Program.movies.movielist.Count;


            string[] titles = new string[Program.movies.movielist.Count];
            for (int i = 0; i < totalMovies; i++)
            {
                titles[i] = Program.movies.movielist[i].title;
            }

            //MessageBox.Show(watchList.);
            //this.watchListView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            foreach(var x in Program.movies.movielist)
            {
                ListViewItem item = new ListViewItem(new String[]
                {
                    x.title,
                    x.year.ToString(),
                    x.genre[0]
                });
                watchListView.Items.Add(item);
            }
            //watchListView.Rows.Add(totalMovies);
            int rowNumber = 1;

            //Program.writeFile();
            

            //MessageBox.Show(movies.movielist[0].actor[0]);


        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void searchButtonGo_Click(object sender, EventArgs e)
        {
            string myText = "Text to analyze for words, bar, foo";
            List<string> words = new List<string> { "foo", "bar", "xyz" };
            var result = words.Where(i => myText.Contains(i)).ToList();

            string[] search = searchBoxEntry.Text.Split(' ');
             
            foreach(var x in Program.movies.movielist)
            {
                
                //x.title 
            }


        }

        private void movieListBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void changeToAdvanced_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Advanced Search
        }
    }
}
