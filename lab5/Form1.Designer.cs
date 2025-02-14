namespace lab5
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
            txtAuthorName = new TextBox();
            txtBookTitle = new TextBox();
            listBoxBooks = new ListBox();
            btnAddBook = new Button();
            btnShowBook = new Button();
            label1 = new Label();
            label2 = new Label();
            btnUpdateBook = new Button();
            txtBookID = new TextBox();
            label3 = new Label();
            btnDeleteBook = new Button();
            btnSearchBooksByAuthor = new Button();
            txtSearchAuthor = new TextBox();
            SuspendLayout();
            // 
            // txtAuthorName
            // 
            txtAuthorName.Location = new Point(158, 100);
            txtAuthorName.Name = "txtAuthorName";
            txtAuthorName.Size = new Size(177, 23);
            txtAuthorName.TabIndex = 0;
            // 
            // txtBookTitle
            // 
            txtBookTitle.Location = new Point(158, 147);
            txtBookTitle.Name = "txtBookTitle";
            txtBookTitle.Size = new Size(177, 23);
            txtBookTitle.TabIndex = 1;
            // 
            // listBoxBooks
            // 
            listBoxBooks.FormattingEnabled = true;
            listBoxBooks.ItemHeight = 15;
            listBoxBooks.Location = new Point(389, 100);
            listBoxBooks.Name = "listBoxBooks";
            listBoxBooks.Size = new Size(330, 244);
            listBoxBooks.TabIndex = 2;
            // 
            // btnAddBook
            // 
            btnAddBook.Location = new Point(201, 186);
            btnAddBook.Name = "btnAddBook";
            btnAddBook.Size = new Size(75, 23);
            btnAddBook.TabIndex = 3;
            btnAddBook.Text = "Add";
            btnAddBook.UseVisualStyleBackColor = true;
            btnAddBook.Click += btnAddBook_Click;
            // 
            // btnShowBook
            // 
            btnShowBook.Location = new Point(389, 360);
            btnShowBook.Name = "btnShowBook";
            btnShowBook.Size = new Size(75, 23);
            btnShowBook.TabIndex = 4;
            btnShowBook.Text = "Show";
            btnShowBook.UseVisualStyleBackColor = true;
            btnShowBook.Click += btnShowBook_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(70, 100);
            label1.Name = "label1";
            label1.Size = new Size(82, 15);
            label1.TabIndex = 5;
            label1.Text = "Author Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(89, 150);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 6;
            label2.Text = "Book Title:";
            // 
            // btnUpdateBook
            // 
            btnUpdateBook.Location = new Point(470, 360);
            btnUpdateBook.Name = "btnUpdateBook";
            btnUpdateBook.Size = new Size(75, 23);
            btnUpdateBook.TabIndex = 7;
            btnUpdateBook.Text = "Update";
            btnUpdateBook.UseVisualStyleBackColor = true;
            btnUpdateBook.Click += btnUpdateBook_Click_1;
            // 
            // txtBookID
            // 
            txtBookID.Location = new Point(158, 247);
            txtBookID.Name = "txtBookID";
            txtBookID.Size = new Size(177, 23);
            txtBookID.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(89, 247);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 9;
            label3.Text = "Book ID:";
            // 
            // btnDeleteBook
            // 
            btnDeleteBook.Location = new Point(201, 292);
            btnDeleteBook.Name = "btnDeleteBook";
            btnDeleteBook.Size = new Size(75, 23);
            btnDeleteBook.TabIndex = 10;
            btnDeleteBook.Text = "Delete";
            btnDeleteBook.UseVisualStyleBackColor = true;
            btnDeleteBook.Click += btnDeleteBook_Click;
            // 
            // btnSearchBooksByAuthor
            // 
            btnSearchBooksByAuthor.Location = new Point(389, 59);
            btnSearchBooksByAuthor.Name = "btnSearchBooksByAuthor";
            btnSearchBooksByAuthor.Size = new Size(75, 23);
            btnSearchBooksByAuthor.TabIndex = 11;
            btnSearchBooksByAuthor.Text = "Search";
            btnSearchBooksByAuthor.UseVisualStyleBackColor = true;
            btnSearchBooksByAuthor.Click += btnSearchBooksByAuthor_Click;
            // 
            // txtSearchAuthor
            // 
            txtSearchAuthor.Location = new Point(470, 59);
            txtSearchAuthor.Name = "txtSearchAuthor";
            txtSearchAuthor.Size = new Size(100, 23);
            txtSearchAuthor.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtSearchAuthor);
            Controls.Add(btnSearchBooksByAuthor);
            Controls.Add(btnDeleteBook);
            Controls.Add(label3);
            Controls.Add(txtBookID);
            Controls.Add(btnUpdateBook);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnShowBook);
            Controls.Add(btnAddBook);
            Controls.Add(listBoxBooks);
            Controls.Add(txtBookTitle);
            Controls.Add(txtAuthorName);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtAuthorName;
        private TextBox txtBookTitle;
        private ListBox listBoxBooks;
        private Button btnAddBook;
        private Button btnShowBook;
        private Label label1;
        private Label label2;
        private Button btnUpdateBook;
        private TextBox txtBookID;
        private Label label3;
        private Button btnDeleteBook;
        private Button btnSearchBooksByAuthor;
        private TextBox txtSearchAuthor;
    }
}
