namespace Project_2.SavedData
{
    partial class Category
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(62, 23);
            label1.Name = "label1";
            label1.Size = new Size(180, 17);
            label1.TabIndex = 0;
            label1.Text = "Choose Your  easy Category";
            // 
            // button1
            // 
            button1.Location = new Point(62, 57);
            button1.Name = "button1";
            button1.Size = new Size(188, 36);
            button1.TabIndex = 1;
            button1.Text = "ART";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(62, 99);
            button2.Name = "button2";
            button2.Size = new Size(188, 39);
            button2.TabIndex = 2;
            button2.Text = "COMPUTERS";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(62, 144);
            button3.Name = "button3";
            button3.Size = new Size(188, 40);
            button3.TabIndex = 3;
            button3.Text = "GENERAL KNOWLEDGE";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(62, 190);
            button4.Name = "button4";
            button4.Size = new Size(188, 39);
            button4.TabIndex = 4;
            button4.Text = "HISTORY";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(62, 235);
            button5.Name = "button5";
            button5.Size = new Size(188, 44);
            button5.TabIndex = 5;
            button5.Text = "MUSIC";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(62, 285);
            button6.Name = "button6";
            button6.Size = new Size(188, 38);
            button6.TabIndex = 6;
            button6.Text = "SPORT";
            button6.UseVisualStyleBackColor = true;
           // button6.Click += this.button6_Click;
            // 
            // Category
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Category";
            Text = "Category";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
    }
}