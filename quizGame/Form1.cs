namespace quizGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            this.Hide(); //ocultar este Form1
            formPergunta1 frmPergunta1 = new formPergunta1();
            frmPergunta1.Show();
        }
    }
}