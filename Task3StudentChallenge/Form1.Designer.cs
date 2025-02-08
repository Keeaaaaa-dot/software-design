namespace Task3StudentChallenge
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
            label2 = new Label();
            listBoxBooks = new ListBox();
            btnShowInfo = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Banner", 24F, FontStyle.Bold);
            label2.Location = new Point(129, 19);
            label2.Name = "label2";
            label2.Size = new Size(384, 47);
            label2.TabIndex = 12;
            label2.Text = "ARRAY TESTING GROUNDS";
            // 
            // listBoxBooks
            // 
            listBoxBooks.FormattingEnabled = true;
            listBoxBooks.ItemHeight = 15;
            listBoxBooks.Location = new Point(245, 98);
            listBoxBooks.Name = "listBoxBooks";
            listBoxBooks.Size = new Size(389, 274);
            listBoxBooks.TabIndex = 11;
            // 
            // btnShowInfo
            // 
            btnShowInfo.Location = new Point(27, 98);
            btnShowInfo.Name = "btnShowInfo";
            btnShowInfo.Size = new Size(186, 23);
            btnShowInfo.TabIndex = 10;
            btnShowInfo.Text = "CLICK LE BUTTON";
            btnShowInfo.UseVisualStyleBackColor = true;
            btnShowInfo.Click += btnShowInfo_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(369, 66);
            label1.Name = "label1";
            label1.Size = new Size(144, 15);
            label1.TabIndex = 13;
            label1.Text = "Now with AudioBooks :>";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(694, 450);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(listBoxBooks);
            Controls.Add(btnShowInfo);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private ListBox listBoxBooks;
        private Button btnShowInfo;
        private Label label1;
    }
}
