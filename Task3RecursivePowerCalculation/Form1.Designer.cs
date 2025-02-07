namespace Task3RecursivePowerCalculation
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
            txtBase = new TextBox();
            txtExponent = new TextBox();
            btnCalculate = new Button();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // txtBase
            // 
            txtBase.Location = new Point(132, 186);
            txtBase.Name = "txtBase";
            txtBase.Size = new Size(100, 23);
            txtBase.TabIndex = 0;
            txtBase.TextAlign = HorizontalAlignment.Center;
            // 
            // txtExponent
            // 
            txtExponent.Location = new Point(236, 144);
            txtExponent.Name = "txtExponent";
            txtExponent.Size = new Size(106, 23);
            txtExponent.TabIndex = 1;
            txtExponent.TextAlign = HorizontalAlignment.Center;
            // 
            // btnCalculate
            // 
            btnCalculate.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalculate.Location = new Point(183, 253);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(107, 23);
            btnCalculate.TabIndex = 2;
            btnCalculate.Text = "CALCULATE";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Banner", 24F, FontStyle.Bold);
            label2.Location = new Point(88, 25);
            label2.Name = "label2";
            label2.Size = new Size(311, 47);
            label2.TabIndex = 9;
            label2.Text = "POWER CALCULATOR";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Silent Night", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(244, 98);
            label1.Name = "label1";
            label1.Size = new Size(87, 38);
            label1.TabIndex = 10;
            label1.Text = "Exponent";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Silent Night", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(155, 145);
            label3.Name = "label3";
            label3.Size = new Size(55, 38);
            label3.TabIndex = 11;
            label3.Text = "Base";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(483, 318);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(btnCalculate);
            Controls.Add(txtExponent);
            Controls.Add(txtBase);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBase;
        private TextBox txtExponent;
        private Button btnCalculate;
        private Label label2;
        private Label label1;
        private Label label3;
    }
}
