namespace Project_2
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
            ListBox listBox1;
            button1 = new Button();
            panel1 = new Panel();
            label1 = new Label();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            listBox1 = new ListBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            listBox1.FormattingEnabled = true;
            listBox1.ImeMode = ImeMode.Disable;
            listBox1.ItemHeight = 17;
            listBox1.Items.AddRange(new object[] { "  15.   $1,000,000 ", "  14.   $500,000 ", "  13.   $250,000 ", "  12.   $125,000 ", "  11.   $64,000 ", "  10.   $32,000 – (safe)", "  9.   $16,000 ", "  8.   $8,000 ", "  7.   $4,000 ", "  6.   $2,000 ", "  5.   $1,000 – (safe)", "  4.   $500 ", "  3.   $300 ", "  2.   $200 ", "  1.   $100 " });
            listBox1.Location = new Point(951, 67);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(284, 650);
            listBox1.TabIndex = 2;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            button1.Location = new Point(46, 238);
            button1.Name = "button1";
            button1.Size = new Size(315, 62);
            button1.TabIndex = 0;
            button1.Text = "Hexagon";
            button1.UseVisualStyleBackColor = true;
            button1.Click += AnswerButton_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Location = new Point(46, 94);
            panel1.Name = "panel1";
            panel1.Size = new Size(879, 113);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(879, 113);
            label1.TabIndex = 0;
            label1.Text = "Which shape has three sides?";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            button2.Location = new Point(481, 238);
            button2.Name = "button2";
            button2.Size = new Size(309, 62);
            button2.TabIndex = 3;
            button2.Text = "Square";
            button2.UseVisualStyleBackColor = true;
            button2.Click += AnswerButton_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            button3.Location = new Point(46, 356);
            button3.Name = "button3";
            button3.Size = new Size(315, 62);
            button3.TabIndex = 4;
            button3.Text = "Triangle";
            button3.UseVisualStyleBackColor = true;
            button3.Click += AnswerButton_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            button4.Location = new Point(481, 356);
            button4.Name = "button4";
            button4.Size = new Size(309, 54);
            button4.TabIndex = 5;
            button4.Text = "Pentagon";
            button4.UseVisualStyleBackColor = true;
            button4.Click += AnswerButton_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.Location = new Point(73, 511);
            button5.Name = "button5";
            button5.Size = new Size(134, 42);
            button5.TabIndex = 6;
            button5.Text = "Continue";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.Location = new Point(256, 511);
            button6.Name = "button6";
            button6.Size = new Size(129, 42);
            button6.TabIndex = 7;
            button6.Text = "Walk Away";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button7.Location = new Point(73, 594);
            button7.Name = "button7";
            button7.Size = new Size(134, 37);
            button7.TabIndex = 8;
            button7.Text = "50:50";
            button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold);
            button8.Location = new Point(271, 594);
            button8.Name = "button8";
            button8.Size = new Size(135, 37);
            button8.TabIndex = 9;
            button8.Text = "Ask the Audience";
            button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            button9.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold);
            button9.Location = new Point(452, 594);
            button9.Name = "button9";
            button9.Size = new Size(127, 37);
            button9.TabIndex = 10;
            button9.Text = "Phone a Friend";
            button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            button10.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button10.Location = new Point(627, 594);
            button10.Name = "button10";
            button10.Size = new Size(122, 37);
            button10.TabIndex = 11;
            button10.Text = "Change Question";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(46, 10);
            label2.Name = "label2";
            label2.Size = new Size(252, 17);
            label2.TabIndex = 12;
            label2.Text = "Player: Alex, 34 (Teacher), enjoys Chess";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(46, 37);
            label3.Name = "label3";
            label3.Size = new Size(71, 17);
            label3.TabIndex = 13;
            label3.Text = "Level 1/15";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(307, 54);
            label4.Name = "label4";
            label4.Size = new Size(113, 17);
            label4.TabIndex = 14;
            label4.Text = "Playing for: $100";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(627, 10);
            label5.Name = "label5";
            label5.Size = new Size(200, 17);
            label5.TabIndex = 15;
            label5.Text = "Phone a Friend: Sam(Librarian)";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(73, 457);
            label6.Name = "label6";
            label6.Size = new Size(0, 17);
            label6.TabIndex = 16;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(46, 488);
            label7.Name = "label7";
            label7.Size = new Size(0, 17);
            label7.TabIndex = 17;
            label7.Click += label7_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(963, 37);
            label8.Name = "label8";
            label8.Size = new Size(80, 17);
            label8.TabIndex = 18;
            label8.Text = "Money Tree";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1249, 738);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(button8);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(listBox1);
            Controls.Add(panel1);
            Controls.Add(button1);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Panel panel1;
        private Label label1;
        private ListBox listBox1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
    }
}
