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
            questions = questionBank.GetCategory("Art", "easy");
            // DataHandlers.ReadFromFile("SavedData/all-questions.json", questions, questionBanks);
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
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
