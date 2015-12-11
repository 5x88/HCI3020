namespace Assignment_3
{
    partial class MainScreen
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
            this.components = new System.ComponentModel.Container();
            this.searchPromptText = new System.Windows.Forms.Label();
            this.searchBoxEntry = new System.Windows.Forms.TextBox();
            this.searchButtonGo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.watchListView = new System.Windows.Forms.ListView();
            this.title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.year = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.genre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.changeToAdvanced = new System.Windows.Forms.LinkLabel();
            this.movieListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.movieListBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // searchPromptText
            // 
            this.searchPromptText.AutoSize = true;
            this.searchPromptText.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchPromptText.Location = new System.Drawing.Point(13, 13);
            this.searchPromptText.Name = "searchPromptText";
            this.searchPromptText.Size = new System.Drawing.Size(89, 29);
            this.searchPromptText.TabIndex = 0;
            this.searchPromptText.Text = "Search";
            // 
            // searchBoxEntry
            // 
            this.searchBoxEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBoxEntry.Location = new System.Drawing.Point(108, 7);
            this.searchBoxEntry.Name = "searchBoxEntry";
            this.searchBoxEntry.Size = new System.Drawing.Size(311, 35);
            this.searchBoxEntry.TabIndex = 1;
            // 
            // searchButtonGo
            // 
            this.searchButtonGo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButtonGo.Location = new System.Drawing.Point(280, 49);
            this.searchButtonGo.Name = "searchButtonGo";
            this.searchButtonGo.Size = new System.Drawing.Size(138, 23);
            this.searchButtonGo.TabIndex = 3;
            this.searchButtonGo.Text = "Find My Movie";
            this.searchButtonGo.UseVisualStyleBackColor = true;
            this.searchButtonGo.Click += new System.EventHandler(this.searchButtonGo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Watch List";
            // 
            // watchListView
            // 
            this.watchListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.title,
            this.year,
            this.genre});
            this.watchListView.Location = new System.Drawing.Point(21, 131);
            this.watchListView.Name = "watchListView";
            this.watchListView.Size = new System.Drawing.Size(397, 305);
            this.watchListView.TabIndex = 10;
            this.watchListView.UseCompatibleStateImageBehavior = false;
            this.watchListView.View = System.Windows.Forms.View.Details;
            // 
            // title
            // 
            this.title.Text = "Title";
            this.title.Width = 196;
            // 
            // year
            // 
            this.year.Text = "Year";
            this.year.Width = 85;
            // 
            // genre
            // 
            this.genre.Text = "Genre";
            this.genre.Width = 110;
            // 
            // changeToAdvanced
            // 
            this.changeToAdvanced.AutoSize = true;
            this.changeToAdvanced.Location = new System.Drawing.Point(18, 46);
            this.changeToAdvanced.Name = "changeToAdvanced";
            this.changeToAdvanced.Size = new System.Drawing.Size(56, 13);
            this.changeToAdvanced.TabIndex = 2;
            this.changeToAdvanced.TabStop = true;
            this.changeToAdvanced.Text = "Advanced";
            this.changeToAdvanced.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.changeToAdvanced_LinkClicked);
            // 
            // movieListBindingSource
            // 
            this.movieListBindingSource.DataSource = typeof(Assignment_3.MovieList);
            this.movieListBindingSource.CurrentChanged += new System.EventHandler(this.movieListBindingSource_CurrentChanged);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 448);
            this.Controls.Add(this.watchListView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchButtonGo);
            this.Controls.Add(this.changeToAdvanced);
            this.Controls.Add(this.searchBoxEntry);
            this.Controls.Add(this.searchPromptText);
            this.Name = "MainScreen";
            this.Text = "MainScreen";
            ((System.ComponentModel.ISupportInitialize)(this.movieListBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label searchPromptText;
        private System.Windows.Forms.TextBox searchBoxEntry;
        private System.Windows.Forms.Button searchButtonGo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource movieListBindingSource;
        private System.Windows.Forms.ListView watchListView;
        private System.Windows.Forms.ColumnHeader title;
        private System.Windows.Forms.ColumnHeader year;
        private System.Windows.Forms.ColumnHeader genre;
        private System.Windows.Forms.LinkLabel changeToAdvanced;
    }
}