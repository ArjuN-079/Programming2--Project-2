using System.Net;
using System.Security;
namespace Project_2
{
    public partial class Form1 : Form
    {
        private List<Player> players = new List<Player>();
        private List<Caller> callers = new List<Caller>();
        private QuestionBank questionBank;
        private Random random = new Random();
        private string correctAnswer = "";
        private Player? currentPlayer;
        private Caller? currentCaller;

        private int currentLevel = 0;
        private List<Question> currentSet = new List<Question>();
        private int setIndex = 0;
        private List<string> usedCategories = new List<string>();
        private Question? currentQuestion;
        private FiftyFifty fiftyFifty = new FiftyFifty();
        private ChangeQuestion changeQuestion = new ChangeQuestion();
        private AskTheAudience askTheAudience = new AskTheAudience();
        private PhoneAFriend phoneAFriend = null!;



        public Form1()
        {
            InitializeComponent();
            questionBank = new(DataHandlers.ReadFromFile("SavedData/all-questions.json"));
            players.Add(new Player(34, new List<string> { "Chess", "Hiking" }, "Alex", "Teacher"));
            players.Add(new Player(28, new List<string> { "Guitar" }, "Mia", "Nurse"));

            callers.Add(new Caller("Sam", "Librarian",
                new List<string> { "History", "Art" },
                new List<string> { "Sports" }));
            callers.Add(new Caller("Priya", "Engineer",
                new List<string> { "Science: Computers" },
                new List<string> { "Entertainment: Music" }));

            currentPlayer = players[random.Next(players.Count)];
            currentCaller = callers[random.Next(callers.Count)];
            phoneAFriend = new PhoneAFriend(currentCaller);  

            label2.Text = $"Player: {currentPlayer.Name}, {currentPlayer.Age} ({currentPlayer.Job})";
            label5.Text = $"Phone a Friend: {currentCaller.Name} ({currentCaller.Job})";
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

        private int GetBankAmount()
        {
            if (currentLevel < 10)
            {
                return 32000;
            }

            else if (currentLevel < 5)
            {
                return 1000;
            }
            else
            {
                return 0;
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
            // button6.Enabled = false;
            GameOver gameOver = new GameOver(moneyTree[currentLevel - 1]);
            gameOver.ShowDialog();
        }



        private void button10_Click(object sender, EventArgs e)
        {
            string category = changeQuestion.Use(currentQuestion!, currentLevel + 1);
            List<Question> options = questionBank.GetCategory(category, GetDifficulty()).Where(q => !currentSet.Contains(q)).ToList();

            currentSet[setIndex] = options[random.Next(options.Count)];
            ShowQuestion();

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
            button5.Enabled = false; // answer  button / incorrect answers
            button6.Enabled = currentLevel > 0; // walk out  money
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
                label6.Text = $"correctAnswer. ${moneyTree[currentLevel]}";// money tree  level show in label correct answer
                label3.Text = $"Level {currentLevel + 1} / 15";

                //level changing 1+++/15

                if (currentLevel == 15)
                {
                    //MessageBox.Show("You won $1,000,000!"); // final output of game
                    GameOver gameOver = new GameOver(1000000);
                    gameOver.ShowDialog();
                }
                else if (currentLevel == 5 || currentLevel == 10) // level up the game setup to auto change like 1-5 easy,next medium and hard.
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

                GameOver gameOver = new GameOver(GetBankAmount());
                gameOver.ShowDialog();

            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            string keep = fiftyFifty.Use(currentQuestion!, currentLevel + 1);

            if (button1.Text != correctAnswer && button1.Text != keep) button1.Enabled = false;
            if (button2.Text != correctAnswer && button2.Text != keep) button2.Enabled = false;
            if (button3.Text != correctAnswer && button3.Text != keep) button3.Enabled = false;
            if (button4.Text != correctAnswer && button4.Text != keep) button4.Enabled = false;

            button7.Enabled = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show(askTheAudience.Use(currentQuestion!, currentLevel + 1), "Ask the Audience");
            button8.Enabled = false;
            //button8.Enabled = askTheAudience.IsAvailable(currentLevel + 1);
        }
    }
}
