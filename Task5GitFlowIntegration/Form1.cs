namespace Task5GitFlowIntegration
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            try
            {

                string input = txtInput.Text;


                string[] stringArray = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                List<int> numbers = stringArray.Select(int.Parse).ToList();


                numbers.Sort(new DescendingComparer());


                listSorted.Items.Clear();
                listSorted.Items.Add("These are the sorted results:");

                foreach (int number in numbers)
                {
                    listSorted.Items.Add("\t" + number);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please enter valid integers separated by spaces.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
                txtInput.Clear();
                listSorted.Items.Clear();
        }
    }
    public class DescendingComparer : IComparer<int>
    {
        public int Compare(int x, int y)
        {
            return y.CompareTo(x); 
        }
    }

}
    
