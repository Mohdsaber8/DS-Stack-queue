using excersie1;

namespace TaskA
{
    public partial class Form1 : Form
    {
        private IntStack myStack = new IntStack();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(AddTextbox.Text, out int value))
            {
                myStack.Push(value);
                AddTextbox.Clear(); // Clear the input TextBox
            }
            else
            {
                MessageBox.Show("Please enter a valid integer.");
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TotalTxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void TopTxtbox_TextChanged(object sender, EventArgs e)
        {
        }

        private void AddTxtbox_TextChanged(object sender, EventArgs e)
        {
        }

        private void TotalTxtbox_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void AddTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (!myStack.IsEmpty())
            {
                int poppedValue = myStack.Pop();
                MessageBox.Show($"Removed integer value: {poppedValue}");
            }
            else
            {
                MessageBox.Show("Stack is empty. Cannot remove elements.");
            }
        }

        private void PeekButton_Click(object sender, EventArgs e)
        {
            if (!myStack.IsEmpty())
            {
                int peekedValue = myStack.Peek();
                MessageBox.Show($"The top integer in the stack is: {peekedValue}");
            }
            else
            {
                MessageBox.Show("Stack is empty. Cannot show the top of the elements ");
            }
        }

        private void TotalButton_Click(object sender, EventArgs e)
        {
            int entryCount = myStack.Count();
            MessageBox.Show($"Number of entries in the stack: {entryCount}");
        }

        private void SortButton_Click(object sender, EventArgs e)
        {
            if (!myStack.IsEmpty())
            {
                int[] elementsArray = new int[myStack.Count()];
                int index = 0;

                // Pop elements from the original stack and store them in the array
                while (!myStack.IsEmpty())
                {
                    int element = myStack.Pop();
                    elementsArray[index] = element;
                    index++;
                }

                Array.Sort(elementsArray);

                // Push the sorted elements back onto the original stack
                for (int i = elementsArray.Length - 1; i >= 0; i--)
                {
                    myStack.Push(elementsArray[i]);
                }

                // Display the sorted elements in a message box
                string sortedElements = string.Join(", ", elementsArray);
                MessageBox.Show("Sorted stack elements: " + sortedElements);
            }
            else
            {
                MessageBox.Show("Stack is empty. Nothing to sort.");
            }
        }
    }
}