namespace MovieMeta
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            Title = new DataGridViewTextBoxColumn();
            ReleaseYear = new DataGridViewTextBoxColumn();
            Length = new DataGridViewTextBoxColumn();
            Rating = new DataGridViewTextBoxColumn();
            Searchbutton1 = new Button();
            SearchBox = new TextBox();
            Generatebutton1 = new Button();
            FilterRatingButton1 = new Button();
            FilterOutbutton1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Title, ReleaseYear, Length, Rating });
            dataGridView1.Location = new Point(2, 1);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(445, 657);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Title
            // 
            Title.HeaderText = "Title";
            Title.Name = "Title";
            // 
            // ReleaseYear
            // 
            ReleaseYear.HeaderText = "Release Year";
            ReleaseYear.Name = "ReleaseYear";
            // 
            // Length
            // 
            Length.HeaderText = "Length";
            Length.Name = "Length";
            // 
            // Rating
            // 
            Rating.HeaderText = "Rating";
            Rating.Name = "Rating";
            // 
            // Searchbutton1
            // 
            Searchbutton1.Location = new Point(755, 12);
            Searchbutton1.Name = "Searchbutton1";
            Searchbutton1.Size = new Size(75, 23);
            Searchbutton1.TabIndex = 1;
            Searchbutton1.Text = "Search";
            Searchbutton1.UseVisualStyleBackColor = true;
            Searchbutton1.Click += Searchbutton1_Click;
            // 
            // SearchBox
            // 
            SearchBox.Location = new Point(583, 12);
            SearchBox.Name = "SearchBox";
            SearchBox.Size = new Size(166, 23);
            SearchBox.TabIndex = 2;
            SearchBox.TextChanged += this.SearchBox;
            // 
            // Generatebutton1
            // 
            Generatebutton1.Location = new Point(583, 74);
            Generatebutton1.Name = "Generatebutton1";
            Generatebutton1.Size = new Size(166, 35);
            Generatebutton1.TabIndex = 3;
            Generatebutton1.Text = "Generate Data";
            Generatebutton1.UseVisualStyleBackColor = true;
            Generatebutton1.Click += GenerateData;
            // 
            // FilterRatingButton1
            // 
            FilterRatingButton1.Location = new Point(583, 157);
            FilterRatingButton1.Name = "FilterRatingButton1";
            FilterRatingButton1.Size = new Size(166, 36);
            FilterRatingButton1.TabIndex = 4;
            FilterRatingButton1.Text = "Filter Rating";
            FilterRatingButton1.UseVisualStyleBackColor = true;
            FilterRatingButton1.Click += FilterRatingButton_Click;
            // 
            // FilterOutbutton1
            // 
            FilterOutbutton1.Location = new Point(583, 226);
            FilterOutbutton1.Name = "FilterOutbutton1";
            FilterOutbutton1.Size = new Size(166, 35);
            FilterOutbutton1.TabIndex = 5;
            FilterOutbutton1.Text = "Filter Out Ratings";
            FilterOutbutton1.UseVisualStyleBackColor = true;
            FilterOutbutton1.Click += FilterOutbutton1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(842, 745);
            Controls.Add(FilterOutbutton1);
            Controls.Add(FilterRatingButton1);
            Controls.Add(Generatebutton1);
            Controls.Add(SearchBox);
            Controls.Add(Searchbutton1);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Title;
        private DataGridViewTextBoxColumn ReleaseYear;
        private DataGridViewTextBoxColumn Length;
        private DataGridViewTextBoxColumn Rating;
        private Button Searchbutton1;
        private Button Generatebutton1;
        private Button FilterRatingButton1;
        private Button FilterOutbutton1;
        private TextBox SearchBox;
        private TextBox SearchBox;
        private TextBox SearchBox;
        private TextBox SearchBox;
    }
}
