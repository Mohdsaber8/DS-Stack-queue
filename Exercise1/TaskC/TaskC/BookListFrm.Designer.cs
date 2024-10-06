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
            DisplayBtn = new Button();
            SortBtn = new Button();
            DisplayBox = new ListBox();
            SuspendLayout();
            // 
            // TitleBox
            // 
            TitleBox.BackColor = SystemColors.Window;
            TitleBox.Location = new Point(105, 103);
            TitleBox.Name = "TitleBox";
            TitleBox.Size = new Size(100, 23);
            TitleBox.TabIndex = 0;
            TitleBox.TextChanged += TitleBox_TextChanged;
            // 
            // AuthorBox
            // 
            AuthorBox.Location = new Point(105, 165);
            AuthorBox.Name = "AuthorBox";
            AuthorBox.Size = new Size(100, 23);
            AuthorBox.TabIndex = 1;
            AuthorBox.TextChanged += AuthorBox_TextChanged;
            // 
            // IsbnBox
            // 
            IsbnBox.Location = new Point(105, 230);
            IsbnBox.Name = "IsbnBox";
            IsbnBox.Size = new Size(100, 23);
            IsbnBox.TabIndex = 2;
            IsbnBox.TextChanged += IsbnBox_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(23, 103);
            label1.Name = "label1";
            label1.Size = new Size(34, 19);
            label1.TabIndex = 3;
            label1.Text = "Title";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(23, 173);
            label2.Name = "label2";
            label2.Size = new Size(52, 19);
            label2.TabIndex = 4;
            label2.Text = "Author";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(23, 238);
            label3.Name = "label3";
            label3.Size = new Size(38, 19);
            label3.TabIndex = 5;
            label3.Text = "ISBN";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(41, 43);
            label4.Name = "label4";
            label4.Size = new Size(134, 21);
            label4.TabIndex = 6;
            label4.Text = "Enter book details";
            // 
            // AddBtn
            // 
            AddBtn.Location = new Point(448, 220);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(90, 33);
            AddBtn.TabIndex = 7;
            AddBtn.Text = "Add book";
            AddBtn.UseVisualStyleBackColor = true;
            AddBtn.Click += AddBtn_Click;
            // 
            // RemoveBtn
            // 
            RemoveBtn.Location = new Point(544, 220);
            RemoveBtn.Name = "RemoveBtn";
            RemoveBtn.Size = new Size(89, 33);
            RemoveBtn.TabIndex = 8;
            RemoveBtn.Text = "Remove book";
            RemoveBtn.UseVisualStyleBackColor = true;
            RemoveBtn.Click += RemoveBtn_Click;
            // 
            // DisplayBtn
            // 
            DisplayBtn.Location = new Point(639, 220);
            DisplayBtn.Name = "DisplayBtn";
            DisplayBtn.Size = new Size(96, 33);
            DisplayBtn.TabIndex = 9;
            DisplayBtn.Text = "Display books";
            DisplayBtn.UseVisualStyleBackColor = true;
            DisplayBtn.Click += DisplayBtn_Click;
            // 
            // SortBtn
            // 
            SortBtn.Location = new Point(741, 220);
            SortBtn.Name = "SortBtn";
            SortBtn.Size = new Size(88, 33);
            SortBtn.TabIndex = 10;
            SortBtn.Text = "Sort books";
            SortBtn.UseVisualStyleBackColor = true;
            SortBtn.Click += SortBtn_Click;
            // 
            // DisplayBox
            // 
            DisplayBox.FormattingEnabled = true;
            DisplayBox.ItemHeight = 15;
            DisplayBox.Location = new Point(472, 78);
            DisplayBox.Name = "DisplayBox";
            DisplayBox.Size = new Size(336, 94);
            DisplayBox.TabIndex = 11;
            DisplayBox.SelectedIndexChanged += DisplayBox_SelectedIndexChanged;
            // 
            // BookListFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(872, 450);
            Controls.Add(DisplayBox);
            Controls.Add(SortBtn);
            Controls.Add(DisplayBtn);
            Controls.Add(RemoveBtn);
            Controls.Add(AddBtn);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(IsbnBox);
            Controls.Add(AuthorBox);
            Controls.Add(TitleBox);
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
        private Button DisplayBtn;
        private Button SortBtn;
        private ListBox DisplayBox;
    }
}