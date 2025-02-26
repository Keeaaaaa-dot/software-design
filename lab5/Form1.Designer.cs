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
            btnAddBook = new Button();
            listBoxBooks = new ListBox();
            btnShowBooks = new Button();
            txtBookID = new TextBox();
            btnUpdateBook = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtSearchAuthor = new TextBox();
            txtDeleteBook = new TextBox();
            btnSearchByAuthor = new Button();
            btnDeleteID = new Button();
            SuspendLayout();
            // 
            // txtAuthorName
            // 
            txtAuthorName.Location = new Point(163, 162);
            txtAuthorName.Name = "txtAuthorName";
            txtAuthorName.Size = new Size(100, 23);
            txtAuthorName.TabIndex = 0;
            // 
            // txtBookTitle
            // 
            txtBookTitle.Location = new Point(163, 209);
            txtBookTitle.Name = "txtBookTitle";
            txtBookTitle.Size = new Size(100, 23);
            txtBookTitle.TabIndex = 1;
            // 
            // btnAddBook
            // 
            btnAddBook.Location = new Point(126, 299);
            btnAddBook.Name = "btnAddBook";
            btnAddBook.Size = new Size(75, 23);
            btnAddBook.TabIndex = 2;
            btnAddBook.Text = "add";
            btnAddBook.UseVisualStyleBackColor = true;
            btnAddBook.Click += btnAddBook_Click;
            // 
            // listBoxBooks
            // 
            listBoxBooks.FormattingEnabled = true;
            listBoxBooks.ItemHeight = 15;
            listBoxBooks.Location = new Point(368, 132);
            listBoxBooks.Name = "listBoxBooks";
            listBoxBooks.Size = new Size(324, 229);
            listBoxBooks.TabIndex = 3;
            // 
            // btnShowBooks
            // 
            btnShowBooks.Location = new Point(368, 370);
            btnShowBooks.Name = "btnShowBooks";
            btnShowBooks.Size = new Size(75, 23);
            btnShowBooks.TabIndex = 4;
            btnShowBooks.Text = "show";
            btnShowBooks.UseVisualStyleBackColor = true;
            btnShowBooks.Click += btnShowBooks_Click;
            // 
            // txtBookID
            // 
            txtBookID.Location = new Point(163, 259);
            txtBookID.Name = "txtBookID";
            txtBookID.Size = new Size(100, 23);
            txtBookID.TabIndex = 5;
            // 
            // btnUpdateBook
            // 
            btnUpdateBook.Location = new Point(207, 299);
            btnUpdateBook.Name = "btnUpdateBook";
            btnUpdateBook.Size = new Size(75, 23);
            btnUpdateBook.TabIndex = 6;
            btnUpdateBook.Text = "update";
            btnUpdateBook.UseVisualStyleBackColor = true;
            btnUpdateBook.Click += btnUpdateBook_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(100, 165);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 7;
            label1.Text = "Author";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(114, 212);
            label2.Name = "label2";
            label2.Size = new Size(30, 15);
            label2.TabIndex = 8;
            label2.Text = "Title";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 9);
            label3.Name = "label3";
            label3.Size = new Size(323, 32);
            label3.TabIndex = 9;
            label3.Text = "Library Momentary System";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sylfaen", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(30, 91);
            label4.Name = "label4";
            label4.Size = new Size(157, 25);
            label4.TabIndex = 10;
            label4.Text = "Book Information";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(126, 262);
            label5.Name = "label5";
            label5.Size = new Size(18, 15);
            label5.TabIndex = 11;
            label5.Text = "ID";
            // 
            // txtSearchAuthor
            // 
            txtSearchAuthor.Location = new Point(592, 370);
            txtSearchAuthor.Name = "txtSearchAuthor";
            txtSearchAuthor.Size = new Size(100, 23);
            txtSearchAuthor.TabIndex = 12;
            // 
            // txtDeleteBook
            // 
            txtDeleteBook.Location = new Point(592, 404);
            txtDeleteBook.Name = "txtDeleteBook";
            txtDeleteBook.Size = new Size(100, 23);
            txtDeleteBook.TabIndex = 13;
            // 
            // btnSearchByAuthor
            // 
            btnSearchByAuthor.Location = new Point(477, 369);
            btnSearchByAuthor.Name = "btnSearchByAuthor";
            btnSearchByAuthor.Size = new Size(100, 23);
            btnSearchByAuthor.TabIndex = 14;
            btnSearchByAuthor.Text = "Search Author";
            btnSearchByAuthor.UseVisualStyleBackColor = true;
            btnSearchByAuthor.Click += btnSearchByAuthor_Click;
            // 
            // btnDeleteID
            // 
            btnDeleteID.Location = new Point(477, 403);
            btnDeleteID.Name = "btnDeleteID";
            btnDeleteID.Size = new Size(100, 23);
            btnDeleteID.TabIndex = 15;
            btnDeleteID.Text = "Delete (ID)";
            btnDeleteID.UseVisualStyleBackColor = true;
            btnDeleteID.Click += btnDeleteID_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(733, 450);
            Controls.Add(btnDeleteID);
            Controls.Add(btnSearchByAuthor);
            Controls.Add(txtDeleteBook);
            Controls.Add(txtSearchAuthor);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnUpdateBook);
            Controls.Add(txtBookID);
            Controls.Add(btnShowBooks);
            Controls.Add(listBoxBooks);
            Controls.Add(btnAddBook);
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
        private Button btnAddBook;
        private ListBox listBoxBooks;
        private Button btnShowBooks;
        private TextBox txtBookID;
        private Button btnUpdateBook;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtSearchAuthor;
        private TextBox txtDeleteBook;
        private Button btnSearchByAuthor;
        private Button btnDeleteID;
    }
}
