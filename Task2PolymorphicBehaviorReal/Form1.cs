namespace Task2PolymorphicBehaviorReal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnShowInfo_Click(object sender, EventArgs e)
        {

            Book[] books =
                new Book[]
                {
                    new Magazine { Title = "Tech Weekly", Author = "John Doe", IssueNumber = 45 },
                    new Magazine { Title = "Death of the Fake Viper", Author = "Anna Karpos", IssueNumber = 33 },
                    new Ebook { Title = "Programming Guide", Author = "Jane Smith", FormatType="PDF" },
                    new Book { Title="Classic Novel", Author="Charles Dickens"},
                    new Ebook { Title = "One of a Kind", Author = "Jana Dorotheos", FormatType="PDF" },
                    new Book { Title="The Stranger in the House", Author= "Rehoboam Lidia" }
                };


            ProcessAndDisplayBooks(books);
        }
        private void ProcessAndDisplayBooks(Book[] books)
        {
            listBoxBooks.Items.Clear();

            foreach (var book in books)
            {
                string infoMessage = book.GetInfo();
                Console.WriteLine(infoMessage);
                listBoxBooks.Items.Add(infoMessage);
            }
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
        public int IssueNumber { get; set; }

        public override string GetInfo()
        {
            return $"{Title} - Issue {IssueNumber} - by: ({Author}) ";
        }
    }


  
        public class Ebook : Book
        {
        public string FormatType { get; set; }

    
        public override string GetInfo()
        {
            return $"{Title} ({FormatType}) by: ({Author})";
        }
    }
}
