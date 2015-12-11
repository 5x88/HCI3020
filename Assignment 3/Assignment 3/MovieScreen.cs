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
    public partial class MovieScreen : Form
    {
        public MovieScreen(Movie selected)
        {
            InitializeComponent();
            this.title.Text = selected.title;
            this.year.Text = selected.year.ToString();
            this.length.Text = selected.length;
            this.directorname.Text = selected.director;

            if (selected.actor[0] != null) {
                this.actor1.Text = selected.actor[0]; 
            } else {
                this.actor1.Text = "";
            }
            if (selected.actor[1] != null) {
                this.actor2.Text = selected.actor[1];
            } else {
                this.actor2.Text = "";
            }

            if (selected.actor[2] != null) {
                this.actor3.Text = selected.actor[2];
            } else {
                this.actor3.Text = "";
            }

            if (selected.actor[3] != null) {
                this.actor4.Text = selected.actor[3];
            } else {
                this.actor4.Text = "";
            }
            if (selected.actor[4] != null) {
                this.actor5.Text = selected.actor[4];
            } else {
                this.actor5.Text = "";
            }

            if (selected.genre.Length >= 1 && selected.genre[0] != null) {
                this.genre1.Text = selected.genre[0];
            } else {
                this.genre1.Text = "";
            }
            if (selected.genre.Length >= 2 && selected.genre[1] != null) {
                this.genre2.Text = selected.genre[1];
            } else {
                this.genre2.Text = "";
            }
            if (selected.genre.Length >= 3 && selected.genre[2] != null) {
                this.genre3.Text = selected.genre[2];
            } else {
                this.genre3.Text = "";
            }
            if (selected.genre.Length >= 4 && selected.genre[3] != null) {
                this.genre4.Text = selected.genre[3];
            } else {
                this.genre4.Text = "";
            }
            if (selected.genre.Length >= 5 && selected.genre[4] != null) {
                this.genre5.Text = selected.genre[4];
            } else {
                this.genre5.Text = "";
            }



            this.Show();

        }

        private void rating_Click(object sender, EventArgs e)
        {

        }
    }
}
