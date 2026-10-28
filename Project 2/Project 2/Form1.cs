namespace Project_2
{
    public partial class Form1 : Form
    {
        private static List<Player> players;
        private static List<Caller> callers;
        private static List<Question> questions;
        private static QuestionBank questionBank;
        private int num = 0;
        public Form1()
        {
            InitializeComponent();
            questionBank = new(DataHandlers.ReadFromFile("SavedData/all-questions.json"));
            
            // DataHandlers.ReadFromFile("SavedData/all-questions.json", questions, questionBanks);
            LoadQuestions("Art");
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
        {
            label1.Text = questions[num].Quest;
            button1.Text = questions[num].Correct;
            button2.Text = questions[num].Incorrect[0];
            button3.Text = questions[num].Incorrect[1];
            button4.Text = questions[num].Incorrect[2];
            num++;
            LoadQuestions("Sports");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
