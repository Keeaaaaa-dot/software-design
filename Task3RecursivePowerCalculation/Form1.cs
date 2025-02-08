namespace Task3RecursivePowerCalculation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
             try
            {
                int baseNumber = Convert.ToInt32(txtBase.Text);
                int exponent = Convert.ToInt32(txtExponent.Text);

                if (exponent < 0)
                {
                    MessageBox.Show("Please enter a non-negative integer for the exponent.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                long result = CalculatePower(baseNumber, exponent);
                
               
                MessageBox.Show($"{baseNumber}^{exponent} = {result}", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid input.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
        }
        private long CalculatePower(int @base, int exponent)
        {
            if (exponent == 0) return 1; 

           
            return @base * CalculatePower(@base, exponent - 1);
        }
    }
}
