namespace lab6
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
            btnFetchBooks = new Button();
            listBoxBooks = new ListBox();
            txtAuthorName = new TextBox();
            txtBookTitle = new TextBox();
            btnAddBook = new Button();
            btnSearch = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            txtBookID = new TextBox();
            txtSearch = new TextBox();
            progressBar = new ProgressBar();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            listBoxSearchResults = new ListBox();
            SuspendLayout();
            // 
            // btnFetchBooks
            // 
            btnFetchBooks.Location = new Point(40, 90);
            btnFetchBooks.Name = "btnFetchBooks";
            btnFetchBooks.Size = new Size(75, 23);
            btnFetchBooks.TabIndex = 0;
            btnFetchBooks.Text = "Fetch";
            btnFetchBooks.UseVisualStyleBackColor = true;
            btnFetchBooks.Click += btnFetchBooks_Click;
            // 
            // listBoxBooks
            // 
            listBoxBooks.FormattingEnabled = true;
            listBoxBooks.ItemHeight = 15;
            listBoxBooks.Location = new Point(41, 119);
            listBoxBooks.Name = "listBoxBooks";
            listBoxBooks.Size = new Size(295, 184);
            listBoxBooks.TabIndex = 1;
            listBoxBooks.SelectedIndexChanged += listBoxBooks_SelectedIndexChanged;
            // 
            // txtAuthorName
            // 
            txtAuthorName.Location = new Point(470, 139);
            txtAuthorName.Name = "txtAuthorName";
            txtAuthorName.Size = new Size(100, 23);
            txtAuthorName.TabIndex = 2;
            // 
            // txtBookTitle
            // 
            txtBookTitle.Location = new Point(470, 181);
            txtBookTitle.Name = "txtBookTitle";
            txtBookTitle.Size = new Size(100, 23);
            txtBookTitle.TabIndex = 3;
            // 
            // btnAddBook
            // 
            btnAddBook.Location = new Point(470, 224);
            btnAddBook.Name = "btnAddBook";
            btnAddBook.Size = new Size(75, 23);
            btnAddBook.TabIndex = 4;
            btnAddBook.Text = "Add";
            btnAddBook.UseVisualStyleBackColor = true;
            btnAddBook.Click += btnAddBook_ClickAsync;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(40, 318);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 5;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_ClickAsync;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(495, 305);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_ClickAsync;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(414, 305);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 7;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_ClickAsync;
            // 
            // txtBookID
            // 
            txtBookID.Location = new Point(470, 264);
            txtBookID.Name = "txtBookID";
            txtBookID.Size = new Size(100, 23);
            txtBookID.TabIndex = 8;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(121, 318);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(100, 23);
            txtSearch.TabIndex = 9;
            // 
            // progressBar
            // 
            progressBar.Location = new Point(13, 402);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(572, 23);
            progressBar.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(446, 267);
            label5.Name = "label5";
            label5.Size = new Size(18, 15);
            label5.TabIndex = 16;
            label5.Text = "ID";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sylfaen", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(363, 90);
            label4.Name = "label4";
            label4.Size = new Size(157, 25);
            label4.TabIndex = 15;
            label4.Text = "Book Information";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ControlLight;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(13, 9);
            label3.Name = "label3";
            label3.Size = new Size(323, 32);
            label3.TabIndex = 14;
            label3.Text = "Library Momentary System";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(434, 189);
            label2.Name = "label2";
            label2.Size = new Size(30, 15);
            label2.TabIndex = 13;
            label2.Text = "Title";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(420, 139);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 12;
            label1.Text = "Author";
            // 
            // listBoxSearchResults
            // 
            listBoxSearchResults.FormattingEnabled = true;
            listBoxSearchResults.ItemHeight = 15;
            listBoxSearchResults.Location = new Point(41, 347);
            listBoxSearchResults.Name = "listBoxSearchResults";
            listBoxSearchResults.Size = new Size(305, 49);
            listBoxSearchResults.TabIndex = 18;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(604, 441);
            Controls.Add(listBoxSearchResults);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(progressBar);
            Controls.Add(txtSearch);
            Controls.Add(txtBookID);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnSearch);
            Controls.Add(btnAddBook);
            Controls.Add(txtBookTitle);
            Controls.Add(txtAuthorName);
            Controls.Add(listBoxBooks);
            Controls.Add(btnFetchBooks);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnFetchBooks;
        private ListBox listBoxBooks;
        private TextBox txtAuthorName;
        private TextBox txtBookTitle;
        private Button btnAddBook;
        private Button btnSearch;
        private Button btnDelete;
        private Button btnUpdate;
        private TextBox txtBookID;
        private TextBox txtSearch;
        private ProgressBar progressBar;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ListBox listBoxSearchResults;
    }
}
