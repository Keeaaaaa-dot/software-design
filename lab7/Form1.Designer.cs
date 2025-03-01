namespace lab7
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
            lblPageNumber = new Label();
            btnNextPage = new Button();
            btnPreviousPage = new Button();
            listBoxBooks = new ListBox();
            btnExportBooks = new Button();
            btnImportBooks = new Button();
            btnSearch = new Button();
            txtSearch = new TextBox();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // lblPageNumber
            // 
            lblPageNumber.AutoSize = true;
            lblPageNumber.Location = new Point(276, 414);
            lblPageNumber.Name = "lblPageNumber";
            lblPageNumber.Size = new Size(42, 15);
            lblPageNumber.TabIndex = 0;
            lblPageNumber.Text = "Page 1";
            // 
            // btnNextPage
            // 
            btnNextPage.Location = new Point(324, 411);
            btnNextPage.Name = "btnNextPage";
            btnNextPage.Size = new Size(32, 23);
            btnNextPage.TabIndex = 1;
            btnNextPage.Text = ">";
            btnNextPage.UseVisualStyleBackColor = true;
            btnNextPage.Click += btnNextPage_ClickAsync;
            // 
            // btnPreviousPage
            // 
            btnPreviousPage.Location = new Point(242, 410);
            btnPreviousPage.Name = "btnPreviousPage";
            btnPreviousPage.Size = new Size(28, 23);
            btnPreviousPage.TabIndex = 2;
            btnPreviousPage.Text = "<";
            btnPreviousPage.UseVisualStyleBackColor = true;
            btnPreviousPage.Click += btnPreviousPage_ClickAsync;
            // 
            // listBoxBooks
            // 
            listBoxBooks.FormattingEnabled = true;
            listBoxBooks.ItemHeight = 15;
            listBoxBooks.Location = new Point(37, 157);
            listBoxBooks.Name = "listBoxBooks";
            listBoxBooks.Size = new Size(324, 244);
            listBoxBooks.TabIndex = 3;
            // 
            // btnExportBooks
            // 
            btnExportBooks.Location = new Point(37, 410);
            btnExportBooks.Name = "btnExportBooks";
            btnExportBooks.Size = new Size(75, 23);
            btnExportBooks.TabIndex = 4;
            btnExportBooks.Text = "Export";
            btnExportBooks.UseVisualStyleBackColor = true;
            btnExportBooks.Click += btnExportBooks_ClickAsync;
            // 
            // btnImportBooks
            // 
            btnImportBooks.Location = new Point(118, 410);
            btnImportBooks.Name = "btnImportBooks";
            btnImportBooks.Size = new Size(75, 23);
            btnImportBooks.TabIndex = 5;
            btnImportBooks.Text = "Import";
            btnImportBooks.UseVisualStyleBackColor = true;
            btnImportBooks.Click += btnImportBooks_ClickAsync;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(37, 128);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 6;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_ClickAsync;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(118, 129);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(100, 23);
            txtSearch.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ControlLight;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(33, 27);
            label3.Name = "label3";
            label3.Size = new Size(323, 32);
            label3.TabIndex = 15;
            label3.Text = "Library Momentary System";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sylfaen", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(118, 72);
            label4.Name = "label4";
            label4.Size = new Size(144, 25);
            label4.TabIndex = 16;
            label4.Text = "Implementation";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(389, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtSearch);
            Controls.Add(btnSearch);
            Controls.Add(btnImportBooks);
            Controls.Add(btnExportBooks);
            Controls.Add(listBoxBooks);
            Controls.Add(btnPreviousPage);
            Controls.Add(btnNextPage);
            Controls.Add(lblPageNumber);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPageNumber;
        private Button btnNextPage;
        private Button btnPreviousPage;
        private ListBox listBoxBooks;
        private Button btnExportBooks;
        private Button btnImportBooks;
        private Button btnSearch;
        private TextBox txtSearch;
        private Label label3;
        private Label label4;
    }
}
