using Lab6;
using Microsoft.EntityFrameworkCore;

namespace lab6
{
    public partial class Form1 : Form
    {
        private readonly BookstoreContext _context;
        public Form1()
        {
            InitializeComponent();
            _context = context;
        }
        public async Task<List<string>> GetBooksAsync()
        {
            try
            {
                return await _context.Books.Include(b => b.Author)
                    .Select(b => $"{b.Title} by {b.Author.Name}")
                    .ToListAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error fetching books: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<string>(); // Return empty list on error
            }
        }

        private void btnFetchBooks_Click(object sender, EventArgs e)
        {
            btnFetchBooks.Enabled = false; // Disable button while loading
            try
            {
                var books = await GetBooksAsync();
                listBoxBooks.DataSource = books;
            }
            finally
            {
                btnFetchBooks.Enabled = true; // Re-enable button after fetching
            }
        }

        private void listBoxBooks_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
