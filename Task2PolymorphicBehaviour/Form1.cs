namespace Task2PolymorphicBehaviour;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void btnAddBook_Click(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(tbBookTitle.Text))
        {
            var book = new Book(tbBookTitle.Text);
            string detailString = $"{book.GetType().Name}:\n{book.GetDetails()}\n\n";
            lbBookDetail.Items.Add(detailString);

            tbBookTitle.Clear();
        }
        else
        {
            MessageBox.Show("Please enter the book title.");
        }
    }

    private void btnAddMagazine_Click(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(tbMagazineIssue.Text) && !string.IsNullOrEmpty(tbMagazineTitle.Text))
        {

            int issueNumber;

            if (int.TryParse(tbMagazineIssue.Text, out issueNumber))
            {
                var magazine = new Magazine(tbMagazineTitle.Text, issueNumber);
                string detailString = $"{magazine.GetType().Name}:\n{magazine.GetDetails()}\n\n";
                lbBookDetail.Items.Add(detailString);

                tbMagazineIssue.Clear();
                tbMagazineTitle.Clear();
            }
            else
            {
                MessageBox.Show("Invalid issue number.");
            }
        }
        else
        {
            MessageBox.Show("Please enter both the magazine title and issue number.");
        }
    }

    private void btnAddEbook_Click(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(tbEbookFormat.Text) && !string.IsNullOrEmpty(tbEbookTitle.Text))
        {

            var ebook = new Ebook(tbEbookTitle.Text, tbEbookFormat.Text);
            string detailString = $"{ebook.GetType().Name}:\n{ebook.GetDetails()}\n\n";
            lbBookDetail.Items.Add(detailString);

            tbEbookFormat.Clear();
            tbEbookTitle.Clear();
        }
        else
        {
            MessageBox.Show("Please enter both the ebook title and format.");
        }
    }

    public abstract class Book
    {
        public string Title { get; set; }

        protected Book(string title)
        {
            Title = title;
        }
  
        public virtual string GetDetails()
        {
            return $"Title: {Title}";
        }
    }

 
    public class Magazine : Book
    {
        public int IssueNumber { get; set; }

        public Magazine(string title, int issueNumber) : base(title)
        {
            IssueNumber = issueNumber;
        }

     
        public override string GetDetails()
        {
            return $"Title: {base.Title}, Issue Number: {IssueNumber}\nThis is a magazine.\nMagazine-specific behavior executed.";
        }
    }

    public class Ebook : Book
    {
        public string Format { get; set; }  

        public Ebook(string title, string format) : base(title)
        {
            Format = format;
        }

        public override string GetDetails()
        {

            return $"This is an ebook.\nThe book's name is '{base.Title}'\nThe file type of this eBook is '{Format}'.\ndownloading eBook... ";
        }

    }
}