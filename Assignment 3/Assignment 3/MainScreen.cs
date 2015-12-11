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
    public partial class MainScreen : Form 
    {
        private AddWindow add2;

        public MainScreen()
        {
            InitializeComponent();


            MovieList movies = new MovieList();
            /*
            String[] genre = new String[2];
            String[] actor = new String[5];
            genre[0] = "Drama";
            genre[1] = "Comedy";
            actor[0] = "Samuel L Jackson";
            actor[1] = "Bruce Willis";
            actor[2] = "John Travolta";
            Movie temp = new Movie("Pulp Fiction", "Two Hours", "R", "QT", 1994, 10, genre, actor);
            movies.movielist.Add(temp);
            movies.movielist.Add(temp);
            */
            movies = Program.readFile();
            Program.writeFile(movies);

            add2 = new AddWindow();
            add2.Show();
            

            MessageBox.Show(movies.movielist[0].actor[0]);


        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }
    }
}
