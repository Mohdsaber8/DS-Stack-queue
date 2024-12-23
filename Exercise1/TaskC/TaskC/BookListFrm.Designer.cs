namespace TaskC
{
    partial class BookListFrm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TitleBox = new TextBox();
            AuthorBox = new TextBox();
            IsbnBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            AddBtn = new Button();
            RemoveBtn = new Button();
            SortBtn = new Button();
            DisplayBox = new ListBox();
            UndoBtn = new Button();
            SuspendLayout();
            // 
            // TitleBox
            // 
            TitleBox.BackColor = SystemColors.Window;
            TitleBox.Location = new Point(150, 172);
            TitleBox.Margin = new Padding(4, 5, 4, 5);
            TitleBox.Name = "TitleBox";
            TitleBox.Size = new Size(141, 31);
            TitleBox.TabIndex = 0;
            TitleBox.TextChanged += TitleBox_TextChanged;
            // 
            // AuthorBox
            // 
            AuthorBox.Location = new Point(150, 275);
            AuthorBox.Margin = new Padding(4, 5, 4, 5);
            AuthorBox.Name = "AuthorBox";
            AuthorBox.Size = new Size(141, 31);
            AuthorBox.TabIndex = 1;
            AuthorBox.TextChanged += AuthorBox_TextChanged;
            // 
            // IsbnBox
            // 
            IsbnBox.Location = new Point(150, 383);
            IsbnBox.Margin = new Padding(4, 5, 4, 5);
            IsbnBox.Name = "IsbnBox";
            IsbnBox.Size = new Size(141, 31);
            IsbnBox.TabIndex = 2;
            IsbnBox.TextChanged += IsbnBox_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(33, 172);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(49, 28);
            label1.TabIndex = 3;
            label1.Text = "Title";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(33, 288);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(73, 28);
            label2.TabIndex = 4;
            label2.Text = "Author";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(33, 397);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(54, 28);
            label3.TabIndex = 5;
            label3.Text = "ISBN";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(59, 72);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(206, 32);
            label4.TabIndex = 6;
            label4.Text = "Enter book details";
            // 
            // AddBtn
            // 
            AddBtn.Location = new Point(640, 367);
            AddBtn.Margin = new Padding(4, 5, 4, 5);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(129, 55);
            AddBtn.TabIndex = 7;
            AddBtn.Text = "Add book";
            AddBtn.UseVisualStyleBackColor = true;
            AddBtn.Click += AddBtn_Click;
            // 
            // RemoveBtn
            // 
            RemoveBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            RemoveBtn.Location = new Point(777, 367);
            RemoveBtn.Margin = new Padding(4, 5, 4, 5);
            RemoveBtn.Name = "RemoveBtn";
            RemoveBtn.Size = new Size(127, 55);
            RemoveBtn.TabIndex = 8;
            RemoveBtn.Text = "Remove";
            RemoveBtn.UseVisualStyleBackColor = true;
            RemoveBtn.Click += RemoveBtn_Click;
            // 
            // SortBtn
            // 
            SortBtn.Location = new Point(1047, 367);
            SortBtn.Margin = new Padding(4, 5, 4, 5);
            SortBtn.Name = "SortBtn";
            SortBtn.Size = new Size(126, 55);
            SortBtn.TabIndex = 10;
            SortBtn.Text = "Sort books";
            SortBtn.UseVisualStyleBackColor = true;
            SortBtn.Click += SortBtn_Click;
            // 
            // DisplayBox
            // 
            DisplayBox.FormattingEnabled = true;
            DisplayBox.ItemHeight = 25;
            DisplayBox.Location = new Point(674, 130);
            DisplayBox.Margin = new Padding(4, 5, 4, 5);
            DisplayBox.Name = "DisplayBox";
            DisplayBox.Size = new Size(478, 154);
            DisplayBox.TabIndex = 11;
            DisplayBox.SelectedIndexChanged += DisplayBox_SelectedIndexChanged;
            // 
            // UndoBtn
            // 
            UndoBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            UndoBtn.Location = new Point(912, 367);
            UndoBtn.Margin = new Padding(4, 5, 4, 5);
            UndoBtn.Name = "UndoBtn";
            UndoBtn.Size = new Size(127, 55);
            UndoBtn.TabIndex = 12;
            UndoBtn.Text = "Undo";
            UndoBtn.UseVisualStyleBackColor = true;
            UndoBtn.Click += UndoBtn_Click;
            // 
            // BookListFrm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1246, 750);
            Controls.Add(UndoBtn);
            Controls.Add(DisplayBox);
            Controls.Add(SortBtn);
            Controls.Add(RemoveBtn);
            Controls.Add(AddBtn);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(IsbnBox);
            Controls.Add(AuthorBox);
            Controls.Add(TitleBox);
            Margin = new Padding(4, 5, 4, 5);
            Name = "BookListFrm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TitleBox;
        private TextBox AuthorBox;
        private TextBox IsbnBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button AddBtn;
        private Button RemoveBtn;
        private Button SortBtn;
        private ListBox DisplayBox;
        private Button UndoBtn;
    }
}