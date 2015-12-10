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
            this.searchPromptText = new System.Windows.Forms.Label();
            this.searchBoxEntry = new System.Windows.Forms.TextBox();
            this.changeToAdvanced = new System.Windows.Forms.LinkLabel();
            this.searchButtonGo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
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
            // changeToAdvanced
            // 
            this.changeToAdvanced.AutoSize = true;
            this.changeToAdvanced.Location = new System.Drawing.Point(18, 46);
            this.changeToAdvanced.Name = "changeToAdvanced";
            this.changeToAdvanced.Size = new System.Drawing.Size(56, 13);
            this.changeToAdvanced.TabIndex = 2;
            this.changeToAdvanced.TabStop = true;
            this.changeToAdvanced.Text = "Advanced";
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
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 448);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchButtonGo);
            this.Controls.Add(this.changeToAdvanced);
            this.Controls.Add(this.searchBoxEntry);
            this.Controls.Add(this.searchPromptText);
            this.Name = "MainScreen";
            this.Text = "MainScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label searchPromptText;
        private System.Windows.Forms.TextBox searchBoxEntry;
        private System.Windows.Forms.LinkLabel changeToAdvanced;
        private System.Windows.Forms.Button searchButtonGo;
        private System.Windows.Forms.Label label1;
    }
}