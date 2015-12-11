using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_3 {
    public partial class LeaveReview : Form {
        MovieScreen parent;

        public LeaveReview(MovieScreen _parent) {
            InitializeComponent();
            parent = _parent;
        }

        private void submitButton_Click(object sender, EventArgs e) {
            if(parent.selectedMovie.reviews == null) {
                parent.selectedMovie.reviews = new List<String>();
            }
            parent.selectedMovie.reviews.Add(reviewBox.Text);
            this.Close();
        }
    }
}
