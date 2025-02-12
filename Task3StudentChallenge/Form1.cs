
using Task3StudentChallenge.Class;

namespace Task3StudentChallenge
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnShowInfo_Click(object sender, EventArgs e)
        {// ARRAY BOOKS
            Book[] books =
                new Book[]
                {
                new Magazine { Title = "Tech Weekly", Author = "John Doe", IssueNumber = 45 },
                new Magazine { Title = "Death of the Fake Viper", Author = "Anna Karpos", IssueNumber = 33 },
                new Ebook { Title = "Programming Guide", Author = "Jane Smith", FormatType="PDF" },
                new Book { Title="Classic Novel", Author="Charles Dickens"},
                new Ebook { Title = "One of a Kind", Author = "Jana Dorotheos", FormatType="PDF" },
                new Book { Title="The Stranger in the House", Author= "Rehoboam Lidia" },
               
                
                
                
                // New AudioBook/TextBook instances
                new Textbook { Title="Mathematics Fundamentals I & II ", Author= "James T.", Subject= "Algebra" },
                new Textbook.AudioBook{Title= "The Great Gatsby",Author="F.Scott Fitzgerald", Duration= 12, Narrator="Juliet Stevenson"}
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
       
      
    }

