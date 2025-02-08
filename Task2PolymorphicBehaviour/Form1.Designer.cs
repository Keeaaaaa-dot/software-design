namespace Task2PolymorphicBehaviour
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            tbMagazineTitle = new TextBox();
            tbBookTitle = new TextBox();
            tbMagazineIssue = new TextBox();
            btnAddMagazine = new Button();
            btnAddBook = new Button();
            lbBookDetail = new ListBox();
            tbEbookTitle = new TextBox();
            tbEbookFormat = new TextBox();
            btnAddEbook = new Button();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 91);
            label1.Name = "label1";
            label1.Size = new Size(34, 15);
            label1.TabIndex = 0;
            label1.Text = "Book";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 223);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 1;
            label2.Text = "Magazine";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 331);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 2;
            label3.Text = "Ebooks";
            // 
            // label4
            // 
            label4.AllowDrop = true;
            label4.AutoSize = true;
            label4.Font = new Font("Trebuchet MS", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 9);
            label4.Name = "label4";
            label4.Size = new Size(246, 46);
            label4.TabIndex = 3;
            label4.Text = "MINI LIBRARY";
            // 
            // tbMagazineTitle
            // 
            tbMagazineTitle.Location = new Point(143, 262);
            tbMagazineTitle.Name = "tbMagazineTitle";
            tbMagazineTitle.Size = new Size(100, 23);
            tbMagazineTitle.TabIndex = 4;
            // 
            // tbBookTitle
            // 
            tbBookTitle.Location = new Point(107, 122);
            tbBookTitle.Name = "tbBookTitle";
            tbBookTitle.Size = new Size(160, 23);
            tbBookTitle.TabIndex = 5;
            // 
            // tbMagazineIssue
            // 
            tbMagazineIssue.Location = new Point(143, 294);
            tbMagazineIssue.Name = "tbMagazineIssue";
            tbMagazineIssue.Size = new Size(100, 23);
            tbMagazineIssue.TabIndex = 6;
            // 
            // btnAddMagazine
            // 
            btnAddMagazine.Location = new Point(326, 257);
            btnAddMagazine.Name = "btnAddMagazine";
            btnAddMagazine.Size = new Size(112, 23);
            btnAddMagazine.TabIndex = 7;
            btnAddMagazine.Text = "Add Magazine";
            btnAddMagazine.UseVisualStyleBackColor = true;
            btnAddMagazine.Click += btnAddMagazine_Click;
            // 
            // btnAddBook
            // 
            btnAddBook.Location = new Point(326, 121);
            btnAddBook.Name = "btnAddBook";
            btnAddBook.Size = new Size(75, 23);
            btnAddBook.TabIndex = 8;
            btnAddBook.Text = "Add Book";
            btnAddBook.UseVisualStyleBackColor = true;
            btnAddBook.Click += btnAddBook_Click;
            // 
            // lbBookDetail
            // 
            lbBookDetail.FormattingEnabled = true;
            lbBookDetail.ItemHeight = 15;
            lbBookDetail.Location = new Point(474, 100);
            lbBookDetail.Name = "lbBookDetail";
            lbBookDetail.Size = new Size(304, 289);
            lbBookDetail.TabIndex = 9;
            // 
            // tbEbookTitle
            // 
            tbEbookTitle.Location = new Point(143, 366);
            tbEbookTitle.Name = "tbEbookTitle";
            tbEbookTitle.Size = new Size(100, 23);
            tbEbookTitle.TabIndex = 10;
            // 
            // tbEbookFormat
            // 
            tbEbookFormat.Location = new Point(143, 395);
            tbEbookFormat.Name = "tbEbookFormat";
            tbEbookFormat.Size = new Size(100, 23);
            tbEbookFormat.TabIndex = 11;
            // 
            // btnAddEbook
            // 
            btnAddEbook.Location = new Point(326, 365);
            btnAddEbook.Name = "btnAddEbook";
            btnAddEbook.Size = new Size(75, 23);
            btnAddEbook.TabIndex = 12;
            btnAddEbook.Text = "Add Ebook";
            btnAddEbook.UseVisualStyleBackColor = true;
            btnAddEbook.Click += btnAddEbook_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(43, 261);
            label5.Name = "label5";
            label5.Size = new Size(33, 15);
            label5.TabIndex = 13;
            label5.Text = "Title:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(43, 294);
            label6.Name = "label6";
            label6.Size = new Size(83, 15);
            label6.TabIndex = 14;
            label6.Text = "Issue Number:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(btnAddEbook);
            Controls.Add(tbEbookFormat);
            Controls.Add(tbEbookTitle);
            Controls.Add(lbBookDetail);
            Controls.Add(btnAddBook);
            Controls.Add(btnAddMagazine);
            Controls.Add(tbMagazineIssue);
            Controls.Add(tbBookTitle);
            Controls.Add(tbMagazineTitle);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox tbMagazineTitle;
        private TextBox tbBookTitle;
        private TextBox tbMagazineIssue;
        private Button btnAddMagazine;
        private Button btnAddBook;
        private ListBox lbBookDetail;
        private TextBox tbEbookTitle;
        private TextBox tbEbookFormat;
        private Button btnAddEbook;
        private Label label5;
        private Label label6;
    }
}
