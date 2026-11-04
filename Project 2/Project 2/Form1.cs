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
        private int winnings = 0;
        private bool answered = false;
        private Random random = new Random();
        private string CorrectAnswer;
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
           // questions = questionBank.GetCategory(category, "easy");
            questions = new List<Question>();
            
            questions.AddRange(questionBank.GetCategory(category, "easy"));
            questions.AddRange(questionBank.GetCategory(category, "medium"));
            questions.AddRange(questionBank.GetCategory(category, "hard"));

        }



        private void button6_Click(object sender, EventArgs e)
        {
            button6.Enabled = false;
        }



        private void button10_Click(object sender, EventArgs e)
        {

        }



        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == CorrectAnswer)
            {
                button1.BackColor = Color.LightGreen;
            }
            else
            {
                button1.ForeColor = Color.Black;
                button1.BackColor = Color.IndianRed;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Text == CorrectAnswer)
            {
                button2.ForeColor = Color.Green;
            }
            else
            {
                button2.ForeColor = Color.Black;
                button2.BackColor = Color.IndianRed;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.Text == CorrectAnswer)
           
            {
                button3.ForeColor = Color.White;
            }
            else
            {
                button3.ForeColor = Color.Black;
                button3.BackColor = Color.IndianRed;
            }
        }


        private void button4_Click(object sender, EventArgs e)
        {
            if (button4.Text == CorrectAnswer)
            {
                button4.ForeColor = Color.Green;
            }
            else
            {
                button4.ForeColor = Color.Black;
                button4.BackColor = Color.IndianRed;
            }
        }

        private readonly string[] moneyTree =
        {
            //Money Tree Prize Levels ---------

            "$100",
            "$200",
            "$300",
            "$500",
            "$1000  – Bank level",
            "$2000",
            "$4000",
            "$8000",
            "$16,000",
            "$32,000  – Bank level", 
            "$64,000",
            "$125,000",
            "$250,000",
            "$500,000",
            "$1,000,000",
                
            //----------------------------------------
        };

        private void button5_Click(object sender, EventArgs e)
            // loading the questions by order.........
        {
            if(num >= questions.Count)
            {
                MessageBox.Show("");
                return;
            }
            Question currentQuestion = questions[num];
            label1.Text = currentQuestion.Quest;
            CorrectAnswer = currentQuestion.Correct;
            List<string> answers = new List<string>();

            answers.Add(currentQuestion.Correct);
            answers.AddRange(currentQuestion.Incorrect);

            answers = answers.OrderBy(x=> random.Next()).ToList();
            button1.Text = answers[0];
            button2.Text = answers[1];
            button3.Text = answers[2];
            button4.Text = answers[3];
            
            num++;

            //button1.Text = questions[num].Correct;
            //label1.Text = questions[num].Quest;
            //button2.Text = questions[num].Incorrect[0];
            //button3.Text = questions[num].Incorrect[1];
            //button4.Text = questions[num].Incorrect[2];
            //LoadQuestions("Sports");
        }
    }
}
