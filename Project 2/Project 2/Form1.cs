using System.Net;
namespace Project_2
{
    public partial class Form1 : Form
    {
        private List<Player> players;
        private List<Caller> callers;
        private QuestionBank questionBank;
        private Random random = new Random();
        private string correctAnswer;

        private int currentLevel = 0;
        private List<Question> currentSet = new List<Question>();
        private int setIndex = 0;
        private List<string> usedCategories = new List<string>();
        private Question? currentQuestion;

        public Form1()
        {
            InitializeComponent();
            questionBank = new(DataHandlers.ReadFromFile("SavedData/all-questions.json"));
            StartNewSet();
        }
        private string GetDifficulty()
        {
            if (currentLevel < 5)
            {
                return "easy";
            }
            else if (currentLevel < 10)
            {
                return "medium";
            }
            else
            {
                return "hard";
            }
        }

        private void StartNewSet()
        {
            Category categoryForm = new Category(usedCategories);
            categoryForm.ShowDialog();

            string chosen = categoryForm.CategoryName;
            usedCategories.Add(chosen);

            currentSet = questionBank.GetCategory(chosen, GetDifficulty()).OrderBy(x => random.Next()).Take(5).ToList();
            setIndex = 0;
            ShowQuestion();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button6.Enabled = false;
        }



        private void button10_Click(object sender, EventArgs e)
        {

        }

        private readonly int[] moneyTree =
        {
            //Money Tree Prize Levels ---------

            100,
            200,
            300,
            500,
            1000,
            2000,
            4000,
            8000,
            16000,
            32000,
            64000,
            125000,
            250000,
            500000,
            1000000
                
            //--------------------------------------(copy from instruction)
        };
        private void ShowQuestion()
        {
            currentQuestion = currentSet[setIndex];
            button1.BackColor = SystemColors.Control;
            button1.Enabled = true;
            button2.BackColor = SystemColors.Control;
            button2.Enabled = true;
            button3.BackColor = SystemColors.Control;
            button3.Enabled = true;
            button4.BackColor = SystemColors.Control;
            button4.Enabled = true;
            label1.Text = currentQuestion.Quest;
            correctAnswer = currentQuestion.Correct;
            List<string> answers = new List<string>();

            answers.Add(currentQuestion.Correct);
            answers.AddRange(currentQuestion.Incorrect);

            answers = answers.OrderBy(x => random.Next()).ToList();
            button1.Text = answers[0];
            button2.Text = answers[1];
            button3.Text = answers[2];
            button4.Text = answers[3];
            button5.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ShowQuestion();
        }

        private void AnswerButton_Click(object sender, EventArgs e)
        {
            Button clicked = (Button)sender;

            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;

            if (clicked.Text == correctAnswer)
            {
                clicked.BackColor = Color.LightGreen;
                currentLevel++;
                setIndex++;
                label7.Text = $"correctAnswer. ${moneyTree[currentLevel]}";

                if (currentLevel == 15)
                {
                    MessageBox.Show("You won $1,000,000!");
                }
                else if (currentLevel == 5 || currentLevel == 10)
                {
                    StartNewSet();
                }
                else
                {
                    button5.Enabled = true;
                }
            }
            else
            {
                clicked.BackColor = Color.IndianRed;

                if (button1.Text == correctAnswer) button1.BackColor = Color.LightGreen;
                if (button2.Text == correctAnswer) button2.BackColor = Color.LightGreen;
                if (button3.Text == correctAnswer) button3.BackColor = Color.LightGreen;
                if (button4.Text == correctAnswer) button4.BackColor = Color.LightGreen;
                label6.Text = $"Incorrect Answer.The correct answer was: {correctAnswer}";
                //  label7.Text = $"correctAnswer.{correctAnswer}";



            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
