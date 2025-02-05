namespace Task5BubbleSort
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBubbleSort_Click(object sender, EventArgs e)
        {
            try
            {

                string input = txtInput.Text;
                string[] stringArray = input.Split(',');
                int[] numbers = Array.ConvertAll(stringArray, int.Parse);

                BubbleSort(numbers);

                SortResult.Items.Clear();
                SortResult.Items.Add("These are the Bubble-sorted results:");
                foreach (int number in numbers)
                {
                    SortResult.Items.Add("\t" + number);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please enter valid integers separated by commas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void BubbleSort(int[] arr)
        {
            int temp;
            for (int p = 0; p < arr.Length - 1; p++)
            {
                for (int i = 0; i < arr.Length - 1 - p; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {

                        temp = arr[i];
                        arr[i] = arr[i + 1];
                        arr[i + 1] = temp;
                    }
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtInput.Clear();
            SortResult.Items.Clear();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }


}
