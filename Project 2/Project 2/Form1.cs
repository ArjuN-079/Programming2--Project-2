using Project_2.SavedData;

namespace Project_2
{
    public partial class Form1 : Form
    {
        private static List<Player> players;
        private static List<Caller> callers;
        private static List<Question> questions;
        private static QuestionBank questionBank;
        private int num = 0;
        private Category chooseCategory = new Category();
        public Form1()
        {
            InitializeComponent();
            questionBank = new(DataHandlers.ReadFromFile("SavedData/all-questions.json"));

            // DataHandlers.ReadFromFile("SavedData/all-questions.json", questions, questionBanks);

            chooseCategory.ShowDialog();
            string current = chooseCategory.CategoryName;
            LoadQuestions(current);

        }
        private void LoadQuestions(string category)
        {
            questions = questionBank.GetCategory(category, "easy");

        }



        private void button6_Click(object sender, EventArgs e)
        {
            button6.Enabled = false;
        }






        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
            // loading the questions by order.........
        {
            num++;
            button1.Text = questions[num].Correct;
            label1.Text = questions[num].Quest;
            button2.Text = questions[num].Incorrect[0];
            button3.Text = questions[num].Incorrect[1];
            button4.Text = questions[num].Incorrect[2];
            //LoadQuestions("Sports");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == questions[num].Correct)
            {
                button1.ForeColor = Color.Green;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.Text == questions[num].Correct)
           
            {
                button3.ForeColor = Color.Green;
            }
            else
            {
                button3.ForeColor = Color.Red;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Text == questions[num].Correct)
            {
                button2.ForeColor = Color.Green;
            }
            else
            {
                button2.ForeColor = Color.Red;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button4.Text == questions[num].Correct)
            {
                button4.ForeColor = Color.Green;
            }
            else
            {
                button4.ForeColor = Color.Red;
            }
        }
    }
}
