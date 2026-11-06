namespace Project_2
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
            btnArt = new Button();
            btnComputers = new Button();
            btnGeneralKnowledge = new Button();
            btnHistory = new Button();
            btnMusic = new Button();
            btnSport = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.InactiveCaptionText;
            label1.Location = new Point(62, 23);
            label1.Name = "label1";
            label1.Size = new Size(203, 20);
            label1.TabIndex = 0;
            label1.Text = "Choose Your  easy Category";
            // 
            // btnArt
            // 
            btnArt.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnArt.Location = new Point(62, 57);
            btnArt.Name = "btnArt";
            btnArt.Size = new Size(188, 36);
            btnArt.TabIndex = 1;
            btnArt.Text = "ART";
            btnArt.UseVisualStyleBackColor = true;
            btnArt.Click += btnArt_Click;
            // 
            // btnComputers
            // 
            btnComputers.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnComputers.Location = new Point(62, 99);
            btnComputers.Name = "btnComputers";
            btnComputers.Size = new Size(188, 39);
            btnComputers.TabIndex = 2;
            btnComputers.Text = "COMPUTERS";
            btnComputers.UseVisualStyleBackColor = true;
            btnComputers.Click += btnComputers_Click;
            // 
            // btnGeneralKnowledge
            // 
            btnGeneralKnowledge.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnGeneralKnowledge.Location = new Point(62, 144);
            btnGeneralKnowledge.Name = "btnGeneralKnowledge";
            btnGeneralKnowledge.Size = new Size(188, 40);
            btnGeneralKnowledge.TabIndex = 3;
            btnGeneralKnowledge.Text = "GENERAL KNOWLEDGE";
            btnGeneralKnowledge.UseVisualStyleBackColor = true;
            btnGeneralKnowledge.Click += btnGeneralKnowledge_Click;
            // 
            // btnHistory
            // 
            btnHistory.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnHistory.Location = new Point(62, 190);
            btnHistory.Name = "btnHistory";
            btnHistory.Size = new Size(188, 39);
            btnHistory.TabIndex = 4;
            btnHistory.Text = "HISTORY";
            btnHistory.UseVisualStyleBackColor = true;
            btnHistory.Click += btnHistory_Click;
            // 
            // btnMusic
            // 
            btnMusic.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnMusic.Location = new Point(62, 235);
            btnMusic.Name = "btnMusic";
            btnMusic.Size = new Size(188, 44);
            btnMusic.TabIndex = 5;
            btnMusic.Text = "MUSIC";
            btnMusic.UseVisualStyleBackColor = true;
            btnMusic.Click += btnMusic_Click;
            // 
            // btnSport
            // 
            btnSport.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSport.Location = new Point(62, 285);
            btnSport.Name = "btnSport";
            btnSport.Size = new Size(188, 38);
            btnSport.TabIndex = 6;
            btnSport.Text = "SPORT";
            btnSport.UseVisualStyleBackColor = true;
            btnSport.Click += btnSport_Click;
            // 
            // Category
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(308, 382);
            Controls.Add(btnSport);
            Controls.Add(btnMusic);
            Controls.Add(btnHistory);
            Controls.Add(btnGeneralKnowledge);
            Controls.Add(btnComputers);
            Controls.Add(btnArt);
            Controls.Add(label1);
            Name = "Category";
            Text = "Category";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnArt;
        private Button btnComputers;
        private Button btnGeneralKnowledge;
        private Button btnHistory;
        private Button btnMusic;
        private Button btnSport;
    }
}