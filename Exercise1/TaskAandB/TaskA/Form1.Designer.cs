namespace TaskA
{
    partial class Form1
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
            AddButton = new Button();
            RemoveButton = new Button();
            PeekButton = new Button();
            label3 = new Label();
            TotalButton = new Button();
            label4 = new Label();
            label5 = new Label();
            AddTextbox = new TextBox();
            SortButton = new Button();
            SuspendLayout();
            // 
            // AddButton
            // 
            AddButton.Location = new Point(259, 190);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(75, 23);
            AddButton.TabIndex = 0;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += button1_Click;
            // 
            // RemoveButton
            // 
            RemoveButton.Location = new Point(435, 190);
            RemoveButton.Name = "RemoveButton";
            RemoveButton.Size = new Size(75, 23);
            RemoveButton.TabIndex = 2;
            RemoveButton.Text = "Remove";
            RemoveButton.UseVisualStyleBackColor = true;
            RemoveButton.Click += RemoveButton_Click;
            // 
            // PeekButton
            // 
            PeekButton.Location = new Point(435, 264);
            PeekButton.Name = "PeekButton";
            PeekButton.Size = new Size(75, 23);
            PeekButton.TabIndex = 4;
            PeekButton.Text = "View top";
            PeekButton.UseVisualStyleBackColor = true;
            PeekButton.Click += PeekButton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(417, 326);
            label3.Name = "label3";
            label3.Size = new Size(109, 30);
            label3.TabIndex = 5;
            label3.Text = "Press to view \r\nthe top of the stack\r\n";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TotalButton
            // 
            TotalButton.Location = new Point(259, 264);
            TotalButton.Name = "TotalButton";
            TotalButton.Size = new Size(75, 23);
            TotalButton.TabIndex = 6;
            TotalButton.Text = "View total";
            TotalButton.UseVisualStyleBackColor = true;
            TotalButton.Click += TotalButton_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(227, 326);
            label4.Name = "label4";
            label4.Size = new Size(143, 30);
            label4.TabIndex = 7;
            label4.Text = "Press to view the number \r\nof entries in the stack";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(317, 72);
            label5.Name = "label5";
            label5.Size = new Size(150, 60);
            label5.TabIndex = 12;
            label5.Text = "Enter or remove an integer \r\nyou would like\r\n to the stack \r\n\r\n";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // AddTextbox
            // 
            AddTextbox.Location = new Point(329, 135);
            AddTextbox.Name = "AddTextbox";
            AddTextbox.Size = new Size(118, 23);
            AddTextbox.TabIndex = 13;
            AddTextbox.TextChanged += AddTextbox_TextChanged;
            // 
            // SortButton
            // 
            SortButton.Location = new Point(346, 228);
            SortButton.Name = "SortButton";
            SortButton.Size = new Size(78, 22);
            SortButton.TabIndex = 14;
            SortButton.Text = "Sort";
            SortButton.UseVisualStyleBackColor = true;
            SortButton.Click += SortButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(SortButton);
            Controls.Add(AddTextbox);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(TotalButton);
            Controls.Add(label3);
            Controls.Add(PeekButton);
            Controls.Add(RemoveButton);
            Controls.Add(AddButton);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button AddButton;
        private Label label1;
        private Button RemoveButton;
        private Button PeekButton;
        private Label label3;
        private Button TotalButton;
        private Label label4;
        private TextBox AddTextbox;
        private Label label5;
        private Button SortButton;
    }
}