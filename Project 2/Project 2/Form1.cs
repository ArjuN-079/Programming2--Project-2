namespace Project_2
{
    public partial class Form1 : Form
    {
        private static List<Player> players;
        private static List<Caller> callers;
        private static List<Question> questions;
        private static List<QuestionBank>questionBanks;
        public Form1()
        {
            InitializeComponent();
            DataHandlers.ReadFromFile("SavedData/all-questions.json", players, callers);
           // DataHandlers.ReadFromFile("SavedData/all-questions.json", questions, questionBanks);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            label1.Text = "Which shape has three sides?";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
