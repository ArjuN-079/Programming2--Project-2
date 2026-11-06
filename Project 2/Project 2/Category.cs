using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_2
{
    public partial class Category : Form
    {
        public string CategoryName { get; set; } = "";
        public Category(List<string> usedCategories)
        {
            InitializeComponent();
            btnArt.Enabled = !usedCategories.Contains("Art");
            btnComputers.Enabled = !usedCategories.Contains("Science: Computers");
            btnGeneralKnowledge.Enabled = !usedCategories.Contains("General Knowledge");
            btnHistory.Enabled = !usedCategories.Contains("History");
            btnMusic.Enabled = !usedCategories.Contains("Entertainment: Music");
            btnSport.Enabled = !usedCategories.Contains("Sports");
        }

        // button of category ART
        private void btnArt_Click(object sender, EventArgs e)
        {
            CategoryName = "Art";
            Close();
        }
        // button of category COMPUTER
        private void btnComputers_Click(object sender, EventArgs e)
        {
            CategoryName = "Science: Computers";
            Close();
        }
        // button of category GENERAL KNOWLEDGE
        private void btnGeneralKnowledge_Click(object sender, EventArgs e)
        {
            CategoryName = "General Knowledge";
            Close();
        }

        // button of category HISTORY
        private void btnHistory_Click(object sender, EventArgs e)
        {
            CategoryName = "History";
            Close();
        }

        // button of category MUSIC
        private void btnMusic_Click(object sender, EventArgs e)
        {
            CategoryName = "Entertainment: Music";
            Close();
        }

        // button of category SPORT
        private void btnSport_Click(object sender, EventArgs e)
        {
            CategoryName = "Sports";
            Close();
        }
    }
}
