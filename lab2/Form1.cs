namespace lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int RecursiveSum(int[] numbers, int n)
        {
            if (n == 0) return numbers[0];
            return numbers[n] + RecursiveSum(numbers, n - 1);

        }

        public int RecursiveFactorial(int n)
        {
            if (n == 0) return 1;
            return n * RecursiveFactorial(n - 1);

        }

        private void btnCalculateSum_Click(object sender, EventArgs e)
        {
            int[] number = txtArrayInput.Text.Split(',').Select(int.Parse).ToArray();
            int result = RecursiveSum(number, number.Length - 1);
            lblSumResult.Text = $"Sum: {result}";

        }

        private void btnCalculateFactorial_Click(object sender, EventArgs e)
        {
            int number = int.Parse(txtInput.Text);
            int result = RecursiveFactorial(number);
            lblResult.Text = $"Factorial: {result}";

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void RESULTS_Click(object sender, EventArgs e)
        {

        }

        private void lblResult_Click(object sender, EventArgs e)
        {

        }
    }
}
