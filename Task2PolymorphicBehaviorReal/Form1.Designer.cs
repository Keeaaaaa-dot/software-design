namespace Task2PolymorphicBehaviorReal
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
            btnShowInfo = new Button();
            listBoxBooks = new ListBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnShowInfo
            // 
            btnShowInfo.Location = new Point(26, 112);
            btnShowInfo.Name = "btnShowInfo";
            btnShowInfo.Size = new Size(186, 23);
            btnShowInfo.TabIndex = 0;
            btnShowInfo.Text = "CLICK LE BUTTON";
            btnShowInfo.UseVisualStyleBackColor = true;
            btnShowInfo.Click += btnShowInfo_Click;
            // 
            // listBoxBooks
            // 
            listBoxBooks.FormattingEnabled = true;
            listBoxBooks.ItemHeight = 15;
            listBoxBooks.Location = new Point(244, 112);
            listBoxBooks.Name = "listBoxBooks";
            listBoxBooks.Size = new Size(389, 274);
            listBoxBooks.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Banner", 24F, FontStyle.Bold);
            label2.Location = new Point(128, 33);
            label2.Name = "label2";
            label2.Size = new Size(384, 47);
            label2.TabIndex = 9;
            label2.Text = "ARRAY TESTING GROUNDS";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(664, 450);
            Controls.Add(label2);
            Controls.Add(listBoxBooks);
            Controls.Add(btnShowInfo);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnShowInfo;
        private ListBox listBoxBooks;
        private Label label2;
    }
}
