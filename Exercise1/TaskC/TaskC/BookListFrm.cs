namespace TaskC
{
    public partial class BookListFrm : Form
    {
        private Stack<Book> undoStack = new Stack<Book>();
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
            // Get the input from the fields
            string title = TitleBox.Text.Trim();
            string author = AuthorBox.Text.Trim();
            string isbn = IsbnBox.Text.Trim();

            // Check if any of the fields are empty
            if (string.IsNullOrEmpty(title) || string.IsNullOrEmpty(author) || string.IsNullOrEmpty(isbn))
            {
                // Show a message box to inform the user
                MessageBox.Show("Please fill in all fields (Title, Author, and ISBN) before adding a book.", "Missing Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Exit the method without adding the book
            }

            // Validate the ISBN format (10 or 13 digits)
            if (!System.Text.RegularExpressions.Regex.IsMatch(isbn, @"^\d{10}(\d{3})?$"))
            {
                // Show a message box to inform the user about invalid ISBN
                MessageBox.Show("The ISBN must be a valid 10-digit or 13-digit number.", "Invalid ISBN", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Exit the method without adding the book
            }

            // Create a new book and add it to the list
            Book newBook = new Book(title, author, isbn);
            bookList.AppendItem(newBook);

            // Display the updated list
            DisplayBooks();

            // Optionally clear the input fields after adding the book
            TitleBox.Text = "";
            AuthorBox.Text = "";
            IsbnBox.Text = "";

            // Optionally show a success message
            MessageBox.Show("Book added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            // Ensure an item is selected in the DisplayBox
            if (DisplayBox.SelectedItem == null)
            {
                MessageBox.Show("Please select a book to remove from the list.", "No Book Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Get the selected item's text
            string selectedBook = DisplayBox.SelectedItem.ToString();

            // Parse the ISBN from the selected book
            string[] parts = selectedBook.Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
            if (parts.Length >= 1)
            {
                string isbnPart = parts[0]; // "ISBN: <isbn>"
                string isbn = isbnPart.Replace("ISBN: ", "").Trim();

                // Create the book object to remove
                Book bookToRemove = new Book("", "", isbn);

                // Check if the book is present in the linked list before removing
                if (bookList.IsPresentItem(bookToRemove))
                {
                    // Push the book to the undo stack
                    undoStack.Push(bookToRemove);

                    // Remove the book from the linked list
                    bookList.RemoveItem(bookToRemove);

                    // Update the DisplayBox
                    DisplayBooks();

                    // Show success message
                    MessageBox.Show("Book removed successfully! You can undo this action.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("The selected book is not found in the list.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Unable to parse the selected book details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void UndoBtn_Click(object sender, EventArgs e)
        {
            // Check if the undo stack has any books
            if (undoStack.Count > 0)
            {
                // Pop the last removed book from the stack
                Book bookToRestore = undoStack.Pop();

                // Append the book back to the linked list
                bookList.AppendItem(bookToRestore);

                // Update the DisplayBox
                DisplayBooks();

                // Show success message
                MessageBox.Show("Undo successful! The last removed book has been restored.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No actions to undo.", "Undo Not Available", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
