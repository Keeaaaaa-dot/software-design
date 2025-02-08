using System.Net;
using System.Windows.Forms.VisualStyles;

namespace lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShowInfo_Click(object sender, EventArgs e)
        {
            Book myBook = new Magazine
            {
                Title = "Tech Weekly",
                Author = "John Doe", IssueNumber = 45

            };
            MessageBox.Show(myBook.GetInfo());

        }
    }
    public class Book
	{ 
		public string Title { get; set; }
		public string Author { get; set; }

		public virtual string GetInfo() 
		{ 
			return $"{Title} by {Author}";
		}
	
	}


	public class Magazine : Book 
	{
		public int IssueNumber {  get; set; }

        public override string GetInfo()
        {
            return $"{Title} - Issue {IssueNumber} - {Author} ";

		}




    }








}
