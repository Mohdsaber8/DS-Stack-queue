namespace TaskC
{
    public partial class BookListFrm : Form
    {
        private LinkListGen<Book> bookList = new LinkListGen<Book>();
        public BookListFrm()
        {
            InitializeComponent();
            
        }
        private void DisplayBooks()
        {
            DisplayBox.Items.Clear(); // Assuming DisplayBox is a ListBox control.
            string bookDetails = bookList.DisplayList();
            string[] bookLines = bookDetails.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var line in bookLines)
            {
                DisplayBox.Items.Add(line);
            }
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            string title = TitleBox.Text;
            string author = AuthorBox.Text;
            string isbn = IsbnBox.Text;
            Book newBook = new Book(title, author, isbn);

            bookList.AppendItem(newBook);
            DisplayBooks();
        }

        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            string isbn = IsbnBox.Text;
            Book bookToRemove = new Book("", "", isbn);
            bookList.RemoveItem(bookToRemove);
            DisplayBooks();
        }

        private void DisplayBtn_Click(object sender, EventArgs e)
        {
            DisplayBooks();
        }

        private void SortBtn_Click(object sender, EventArgs e)
        {
            bookList.Sort();
            DisplayBooks();
        }

        private void IsbnBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void DisplayBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TitleBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void AuthorBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
