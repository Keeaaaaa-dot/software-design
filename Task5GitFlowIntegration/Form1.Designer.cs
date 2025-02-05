namespace Task5GitFlowIntegration
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
            btnSort = new Button();
            txtInput = new TextBox();
            listSorted = new ListBox();
            btnClear = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnSort
            // 
            btnSort.Location = new Point(348, 145);
            btnSort.Name = "btnSort";
            btnSort.Size = new Size(110, 40);
            btnSort.TabIndex = 0;
            btnSort.Text = "SORT";
            btnSort.UseVisualStyleBackColor = true;
            btnSort.Click += btnSort_Click;
            // 
            // txtInput
            // 
            txtInput.Location = new Point(49, 134);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(265, 23);
            txtInput.TabIndex = 1;
            // 
            // listSorted
            // 
            listSorted.FormattingEnabled = true;
            listSorted.ItemHeight = 15;
            listSorted.Location = new Point(49, 175);
            listSorted.Name = "listSorted";
            listSorted.Size = new Size(265, 139);
            listSorted.TabIndex = 2;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(348, 197);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(110, 46);
            btnClear.TabIndex = 3;
            btnClear.Text = "CLEAR";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Silent Night", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(94, 83);
            label1.Name = "label1";
            label1.Size = new Size(171, 38);
            label1.TabIndex = 7;
            label1.Text = "Enter Your Numbers";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Banner", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(68, 9);
            label2.Name = "label2";
            label2.Size = new Size(351, 47);
            label2.TabIndex = 8;
            label2.Text = "GITFLOW INTEGRATION";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(496, 365);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnClear);
            Controls.Add(listSorted);
            Controls.Add(txtInput);
            Controls.Add(btnSort);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSort;
        private TextBox txtInput;
        private ListBox listSorted;
        private Button btnClear;
        private Label label1;
        private Label label2;
    }
}
