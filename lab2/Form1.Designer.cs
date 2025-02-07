namespace lab2
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
            txtArrayInput = new TextBox();
            btnCalculateSum = new Button();
            lblSumResult = new Label();
            btnCalculateFactorial = new Button();
            lblResult = new Label();
            txtInput = new TextBox();
            LblSum = new Label();
            label1 = new Label();
            lblFactorial = new Label();
            RESULTS = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // txtArrayInput
            // 
            txtArrayInput.Location = new Point(55, 157);
            txtArrayInput.Name = "txtArrayInput";
            txtArrayInput.Size = new Size(244, 23);
            txtArrayInput.TabIndex = 0;
            // 
            // btnCalculateSum
            // 
            btnCalculateSum.Location = new Point(375, 157);
            btnCalculateSum.Name = "btnCalculateSum";
            btnCalculateSum.Size = new Size(108, 23);
            btnCalculateSum.TabIndex = 1;
            btnCalculateSum.Text = "CALCULATE";
            btnCalculateSum.UseVisualStyleBackColor = true;
            btnCalculateSum.Click += btnCalculateSum_Click;
            // 
            // lblSumResult
            // 
            lblSumResult.AutoSize = true;
            lblSumResult.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSumResult.Location = new Point(575, 157);
            lblSumResult.Name = "lblSumResult";
            lblSumResult.Size = new Size(21, 32);
            lblSumResult.TabIndex = 2;
            lblSumResult.Text = " ";
            // 
            // btnCalculateFactorial
            // 
            btnCalculateFactorial.Location = new Point(375, 335);
            btnCalculateFactorial.Name = "btnCalculateFactorial";
            btnCalculateFactorial.Size = new Size(108, 23);
            btnCalculateFactorial.TabIndex = 3;
            btnCalculateFactorial.Text = "CALCULATE";
            btnCalculateFactorial.UseVisualStyleBackColor = true;
            btnCalculateFactorial.Click += btnCalculateFactorial_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResult.Location = new Point(575, 327);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(21, 32);
            lblResult.TabIndex = 4;
            lblResult.Text = " ";
            lblResult.Click += lblResult_Click;
            // 
            // txtInput
            // 
            txtInput.Location = new Point(55, 336);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(244, 23);
            txtInput.TabIndex = 5;
            // 
            // LblSum
            // 
            LblSum.AutoSize = true;
            LblSum.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblSum.Location = new Point(24, 65);
            LblSum.Name = "LblSum";
            LblSum.Size = new Size(82, 40);
            LblSum.TabIndex = 6;
            LblSum.Text = "SUM";
            LblSum.Click += label1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(31, 114);
            label1.Name = "label1";
            label1.Size = new Size(211, 17);
            label1.TabIndex = 10;
            label1.Text = "Note: It should be seperated by \",\"";
            // 
            // lblFactorial
            // 
            lblFactorial.AutoSize = true;
            lblFactorial.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFactorial.Location = new Point(24, 256);
            lblFactorial.Name = "lblFactorial";
            lblFactorial.Size = new Size(141, 32);
            lblFactorial.TabIndex = 11;
            lblFactorial.Text = "FACTORIAL";
            // 
            // RESULTS
            // 
            RESULTS.AutoSize = true;
            RESULTS.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RESULTS.Location = new Point(575, 42);
            RESULTS.Name = "RESULTS";
            RESULTS.Size = new Size(134, 40);
            RESULTS.TabIndex = 12;
            RESULTS.Text = "RESULTS";
            RESULTS.Click += RESULTS_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(28, 299);
            label2.Name = "label2";
            label2.Size = new Size(276, 17);
            label2.TabIndex = 13;
            label2.Text = "Note: Only ONE INTEGER would be calculated";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(RESULTS);
            Controls.Add(lblFactorial);
            Controls.Add(label1);
            Controls.Add(LblSum);
            Controls.Add(txtInput);
            Controls.Add(lblResult);
            Controls.Add(btnCalculateFactorial);
            Controls.Add(lblSumResult);
            Controls.Add(btnCalculateSum);
            Controls.Add(txtArrayInput);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtArrayInput;
        private Button btnCalculateSum;
        private Label lblSumResult;
        private Button btnCalculateFactorial;
        private Label lblResult;
        private TextBox txtInput;
        private Label LblSum;
        private Label label1;
        private Label lblFactorial;
        private Label RESULTS;
        private Label label2;
    }
}
