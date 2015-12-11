namespace Assignment_3
{
    partial class MovieScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.title = new System.Windows.Forms.Label();
            this.year = new System.Windows.Forms.Label();
            this.length = new System.Windows.Forms.Label();
            this.DirectedBy = new System.Windows.Forms.Label();
            this.directorname = new System.Windows.Forms.Label();
            this.rating = new System.Windows.Forms.Label();
            this.outoften = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.actor1 = new System.Windows.Forms.Label();
            this.actor2 = new System.Windows.Forms.Label();
            this.actor3 = new System.Windows.Forms.Label();
            this.actor4 = new System.Windows.Forms.Label();
            this.actor5 = new System.Windows.Forms.Label();
            this.Genres = new System.Windows.Forms.Label();
            this.genre5 = new System.Windows.Forms.Label();
            this.genre4 = new System.Windows.Forms.Label();
            this.genre3 = new System.Windows.Forms.Label();
            this.genre2 = new System.Windows.Forms.Label();
            this.genre1 = new System.Windows.Forms.Label();
            this.leaveReview = new System.Windows.Forms.Button();
            this.reviewBox = new System.Windows.Forms.ListBox();
            this.userreviews = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(12, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(45, 24);
            this.title.TabIndex = 0;
            this.title.Text = "Title";
            // 
            // year
            // 
            this.year.AutoSize = true;
            this.year.Location = new System.Drawing.Point(16, 37);
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(27, 13);
            this.year.TabIndex = 1;
            this.year.Text = "year";
            // 
            // length
            // 
            this.length.AutoSize = true;
            this.length.Location = new System.Drawing.Point(16, 54);
            this.length.Name = "length";
            this.length.Size = new System.Drawing.Size(36, 13);
            this.length.TabIndex = 2;
            this.length.Text = "length";
            // 
            // DirectedBy
            // 
            this.DirectedBy.AutoSize = true;
            this.DirectedBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DirectedBy.Location = new System.Drawing.Point(12, 85);
            this.DirectedBy.Name = "DirectedBy";
            this.DirectedBy.Size = new System.Drawing.Size(50, 15);
            this.DirectedBy.TabIndex = 3;
            this.DirectedBy.Text = "Director";
            // 
            // directorname
            // 
            this.directorname.AutoSize = true;
            this.directorname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.directorname.Location = new System.Drawing.Point(12, 100);
            this.directorname.Name = "directorname";
            this.directorname.Size = new System.Drawing.Size(80, 15);
            this.directorname.TabIndex = 4;
            this.directorname.Text = "directorname";
            // 
            // rating
            // 
            this.rating.AutoSize = true;
            this.rating.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rating.Location = new System.Drawing.Point(286, 388);
            this.rating.Name = "rating";
            this.rating.Size = new System.Drawing.Size(30, 24);
            this.rating.TabIndex = 5;
            this.rating.Text = "10";
            this.rating.Click += new System.EventHandler(this.rating_Click);
            // 
            // outoften
            // 
            this.outoften.AutoSize = true;
            this.outoften.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outoften.Location = new System.Drawing.Point(311, 388);
            this.outoften.Name = "outoften";
            this.outoften.Size = new System.Drawing.Size(40, 24);
            this.outoften.TabIndex = 6;
            this.outoften.Text = "/ 10";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Actors";
            // 
            // actor1
            // 
            this.actor1.AutoSize = true;
            this.actor1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actor1.Location = new System.Drawing.Point(11, 150);
            this.actor1.Name = "actor1";
            this.actor1.Size = new System.Drawing.Size(41, 15);
            this.actor1.TabIndex = 8;
            this.actor1.Text = "actor1";
            // 
            // actor2
            // 
            this.actor2.AutoSize = true;
            this.actor2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actor2.Location = new System.Drawing.Point(11, 165);
            this.actor2.Name = "actor2";
            this.actor2.Size = new System.Drawing.Size(41, 15);
            this.actor2.TabIndex = 9;
            this.actor2.Text = "actor2";
            // 
            // actor3
            // 
            this.actor3.AutoSize = true;
            this.actor3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actor3.Location = new System.Drawing.Point(11, 180);
            this.actor3.Name = "actor3";
            this.actor3.Size = new System.Drawing.Size(41, 15);
            this.actor3.TabIndex = 10;
            this.actor3.Text = "actor3";
            // 
            // actor4
            // 
            this.actor4.AutoSize = true;
            this.actor4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actor4.Location = new System.Drawing.Point(11, 195);
            this.actor4.Name = "actor4";
            this.actor4.Size = new System.Drawing.Size(41, 15);
            this.actor4.TabIndex = 11;
            this.actor4.Text = "actor4";
            // 
            // actor5
            // 
            this.actor5.AutoSize = true;
            this.actor5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actor5.Location = new System.Drawing.Point(11, 210);
            this.actor5.Name = "actor5";
            this.actor5.Size = new System.Drawing.Size(41, 15);
            this.actor5.TabIndex = 12;
            this.actor5.Text = "actor5";
            // 
            // Genres
            // 
            this.Genres.AutoSize = true;
            this.Genres.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Genres.Location = new System.Drawing.Point(13, 265);
            this.Genres.Name = "Genres";
            this.Genres.Size = new System.Drawing.Size(47, 15);
            this.Genres.TabIndex = 13;
            this.Genres.Text = "Genres";
            // 
            // genre5
            // 
            this.genre5.AutoSize = true;
            this.genre5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genre5.Location = new System.Drawing.Point(13, 342);
            this.genre5.Name = "genre5";
            this.genre5.Size = new System.Drawing.Size(41, 15);
            this.genre5.TabIndex = 18;
            this.genre5.Text = "Genre";
            // 
            // genre4
            // 
            this.genre4.AutoSize = true;
            this.genre4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genre4.Location = new System.Drawing.Point(13, 327);
            this.genre4.Name = "genre4";
            this.genre4.Size = new System.Drawing.Size(41, 15);
            this.genre4.TabIndex = 17;
            this.genre4.Text = "Genre";
            // 
            // genre3
            // 
            this.genre3.AutoSize = true;
            this.genre3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genre3.Location = new System.Drawing.Point(13, 312);
            this.genre3.Name = "genre3";
            this.genre3.Size = new System.Drawing.Size(41, 15);
            this.genre3.TabIndex = 16;
            this.genre3.Text = "Genre";
            // 
            // genre2
            // 
            this.genre2.AutoSize = true;
            this.genre2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genre2.Location = new System.Drawing.Point(13, 297);
            this.genre2.Name = "genre2";
            this.genre2.Size = new System.Drawing.Size(41, 15);
            this.genre2.TabIndex = 15;
            this.genre2.Text = "Genre";
            // 
            // genre1
            // 
            this.genre1.AutoSize = true;
            this.genre1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genre1.Location = new System.Drawing.Point(13, 282);
            this.genre1.Name = "genre1";
            this.genre1.Size = new System.Drawing.Size(41, 15);
            this.genre1.TabIndex = 14;
            this.genre1.Text = "Genre";
            // 
            // leaveReview
            // 
            this.leaveReview.Location = new System.Drawing.Point(19, 388);
            this.leaveReview.Name = "leaveReview";
            this.leaveReview.Size = new System.Drawing.Size(94, 23);
            this.leaveReview.TabIndex = 19;
            this.leaveReview.Text = "Leave a Review";
            this.leaveReview.UseVisualStyleBackColor = true;
            this.leaveReview.Click += new System.EventHandler(this.leaveReview_Click);
            // 
            // reviewBox
            // 
            this.reviewBox.FormattingEnabled = true;
            this.reviewBox.Location = new System.Drawing.Point(357, 37);
            this.reviewBox.Name = "reviewBox";
            this.reviewBox.Size = new System.Drawing.Size(368, 368);
            this.reviewBox.TabIndex = 21;
            // 
            // userreviews
            // 
            this.userreviews.AutoSize = true;
            this.userreviews.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userreviews.Location = new System.Drawing.Point(490, 9);
            this.userreviews.Name = "userreviews";
            this.userreviews.Size = new System.Drawing.Size(125, 24);
            this.userreviews.TabIndex = 22;
            this.userreviews.Text = "User Reviews";
            // 
            // MovieScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 421);
            this.Controls.Add(this.userreviews);
            this.Controls.Add(this.reviewBox);
            this.Controls.Add(this.leaveReview);
            this.Controls.Add(this.genre5);
            this.Controls.Add(this.genre4);
            this.Controls.Add(this.genre3);
            this.Controls.Add(this.genre2);
            this.Controls.Add(this.genre1);
            this.Controls.Add(this.Genres);
            this.Controls.Add(this.actor5);
            this.Controls.Add(this.actor4);
            this.Controls.Add(this.actor3);
            this.Controls.Add(this.actor2);
            this.Controls.Add(this.actor1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.outoften);
            this.Controls.Add(this.rating);
            this.Controls.Add(this.directorname);
            this.Controls.Add(this.DirectedBy);
            this.Controls.Add(this.length);
            this.Controls.Add(this.year);
            this.Controls.Add(this.title);
            this.Name = "MovieScreen";
            this.Text = "MovieScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label year;
        private System.Windows.Forms.Label length;
        private System.Windows.Forms.Label DirectedBy;
        private System.Windows.Forms.Label directorname;
        private System.Windows.Forms.Label rating;
        private System.Windows.Forms.Label outoften;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label actor1;
        private System.Windows.Forms.Label actor2;
        private System.Windows.Forms.Label actor3;
        private System.Windows.Forms.Label actor4;
        private System.Windows.Forms.Label actor5;
        private System.Windows.Forms.Label Genres;
        private System.Windows.Forms.Label genre5;
        private System.Windows.Forms.Label genre4;
        private System.Windows.Forms.Label genre3;
        private System.Windows.Forms.Label genre2;
        private System.Windows.Forms.Label genre1;
        private System.Windows.Forms.Button leaveReview;
        private System.Windows.Forms.Label userreviews;
        public System.Windows.Forms.ListBox reviewBox;
    }
}