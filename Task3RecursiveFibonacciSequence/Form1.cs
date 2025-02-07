namespace Task3RecursiveFibonacciSequence
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    int n = Convert.ToInt32(txtInput.Text);
                    if (n < 0)
                    {
                        MessageBox.Show("Please enter a non-negative integer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    int result = CalculateFibonacci(n);
                    
                    MessageBox.Show($"The {n}th Fibonacci number is: {result}", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception)
                {
                    MessageBox.Show("Invalid input.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private int CalculateFibonacci(int n)
        {
            if (n <= 1) return n; 
            return CalculateFibonacci(n - 1) + CalculateFibonacci(n - 2);
        }
    }

}
