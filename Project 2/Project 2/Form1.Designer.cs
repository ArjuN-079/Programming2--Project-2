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
            button1 = new Button();
            panel1 = new Panel();
            label1 = new Label();
            listBox1 = new ListBox();
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
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(40, 210);
            button1.Name = "button1";
            button1.Size = new Size(276, 55);
            button1.TabIndex = 0;
            button1.Text = "Hexagon";
            button1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Location = new Point(40, 83);
            panel1.Name = "panel1";
            panel1.Size = new Size(769, 100);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(253, 32);
            label1.Name = "label1";
            label1.Size = new Size(213, 20);
            label1.TabIndex = 0;
            label1.Text = "Which shape has three sides?";
            label1.Click += label1_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Items.AddRange(new object[] { "$1,000,000 ", "$500,000 ", "$250,000 ", "$125,000 ", "$64,000 ", "$32,000 – Bank level ", "$16,000 ", "$8,000 ", "$4,000 ", "$2,000 ", "$1,000 – Bank level ", "$500 ", "$300 ", "$200 ", "$100 " });
            listBox1.Location = new Point(832, 59);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(249, 589);
            listBox1.TabIndex = 2;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // button2
            // 
            button2.Location = new Point(421, 210);
            button2.Name = "button2";
            button2.Size = new Size(270, 55);
            button2.TabIndex = 3;
            button2.Text = "Square";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(40, 314);
            button3.Name = "button3";
            button3.Size = new Size(276, 55);
            button3.TabIndex = 4;
            button3.Text = "Triangle";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(421, 314);
            button4.Name = "button4";
            button4.Size = new Size(270, 48);
            button4.TabIndex = 5;
            button4.Text = "Pentagon";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(64, 469);
            button5.Name = "button5";
            button5.Size = new Size(117, 37);
            button5.TabIndex = 6;
            button5.Text = "continue";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(224, 469);
            button6.Name = "button6";
            button6.Size = new Size(113, 37);
            button6.TabIndex = 7;
            button6.Text = "Walk Away";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(64, 539);
            button7.Name = "button7";
            button7.Size = new Size(117, 33);
            button7.TabIndex = 8;
            button7.Text = "50:50";
            button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Location = new Point(224, 539);
            button8.Name = "button8";
            button8.Size = new Size(118, 33);
            button8.TabIndex = 9;
            button8.Text = "Ask the Audience";
            button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            button9.Location = new Point(382, 539);
            button9.Name = "button9";
            button9.Size = new Size(111, 33);
            button9.TabIndex = 10;
            button9.Text = "Phone a Friend";
            button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            button10.Location = new Point(549, 539);
            button10.Name = "button10";
            button10.Size = new Size(107, 33);
            button10.TabIndex = 11;
            button10.Text = "Change Question";
            button10.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 9);
            label2.Name = "label2";
            label2.Size = new Size(211, 15);
            label2.TabIndex = 12;
            label2.Text = "Player: Alex, 34 (Teacher), enjoys Chess";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 33);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 13;
            label3.Text = "Level 1/15";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(269, 48);
            label4.Name = "label4";
            label4.Size = new Size(108, 17);
            label4.TabIndex = 14;
            label4.Text = "Playing for $100";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(549, 9);
            label5.Name = "label5";
            label5.Size = new Size(169, 15);
            label5.TabIndex = 15;
            label5.Text = "Phone a Friend: Sam(Librarian)";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1093, 651);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(listBox1);
            Controls.Add(panel1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
    }
}
