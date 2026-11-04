using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_2.SavedData
{
    public partial class Category : Form
    {
        public string CategoryName { get; set; }
        public Category()
        {
            InitializeComponent();
        }

        // button of category ART
        private void button1_Click(object sender, EventArgs e)
        {
            CategoryName = "Art";
            button1.Visible = false;
            Close();
        }

        private void Category_Load(object sender, EventArgs e)
        {

        }
        // button of category COMPUTER
        private void button2_Click(object sender, EventArgs e)
        {
            CategoryName = "Science: Computers";
            button2.Visible = false;
            Close();
        }
        // button of category GENERAL KNOWLEDGE
        private void button3_Click(object sender, EventArgs e)
        {
            CategoryName = "general knowledge";
            button1.Visible = false;
            Close();
        }

        // button of category HISTORY
        private void button4_Click(object sender, EventArgs e)
        {
            CategoryName = "history";
            button1.Visible = false;
            Close();
        }

        // button of category MUSIC
        private void button5_Click(object sender, EventArgs e)
        {
            CategoryName = "music";
            button1.Visible = false;
            Close();
        }

        // button of category SPORT
        private void button6_Click(object sender, EventArgs e)
        {
            CategoryName = "sport";
            button1.Visible = false;
            Close();
        }
    }
}
