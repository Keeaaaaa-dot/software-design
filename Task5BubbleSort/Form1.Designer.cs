namespace Task5BubbleSort
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
            btnBubbleSort = new Button();
            txtInput = new TextBox();
            btnClear = new Button();
            SortResult = new ListBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnBubbleSort
            // 
            btnBubbleSort.Location = new Point(38, 194);
            btnBubbleSort.Name = "btnBubbleSort";
            btnBubbleSort.Size = new Size(107, 48);
            btnBubbleSort.TabIndex = 0;
            btnBubbleSort.Text = "SORT";
            btnBubbleSort.UseVisualStyleBackColor = true;
            btnBubbleSort.Click += btnBubbleSort_Click;
            // 
            // txtInput
            // 
            txtInput.Location = new Point(79, 144);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(159, 23);
            txtInput.TabIndex = 2;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(165, 194);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(107, 48);
            btnClear.TabIndex = 3;
            btnClear.Text = "CLEAR";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // SortResult
            // 
            SortResult.Anchor = AnchorStyles.None;
            SortResult.FormattingEnabled = true;
            SortResult.ItemHeight = 15;
            SortResult.Location = new Point(314, 72);
            SortResult.Name = "SortResult";
            SortResult.Size = new Size(298, 199);
            SortResult.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Silent Night", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(73, 87);
            label1.Name = "label1";
            label1.Size = new Size(171, 38);
            label1.TabIndex = 6;
            label1.Text = "Enter Your Numbers";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Banner", 24F, FontStyle.Bold);
            label2.Location = new Point(187, 7);
            label2.Name = "label2";
            label2.Size = new Size(269, 47);
            label2.TabIndex = 7;
            label2.Text = "BUBBLE SORTING ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(669, 329);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(SortResult);
            Controls.Add(btnClear);
            Controls.Add(txtInput);
            Controls.Add(btnBubbleSort);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBubbleSort;
        private TextBox txtInput;
        private Button btnClear;
        private ListBox SortResult;
        private Label label1;
        private Label label2;
    }
}
