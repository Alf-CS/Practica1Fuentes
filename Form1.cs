namespace Practica1Fuentes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnNegrita_Click(object sender, EventArgs e)
        {
            label1.Font = new Font(label1.Font, label1.Font.Style | FontStyle.Bold);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnCursiva_Click(object sender, EventArgs e)
        {
            label1.Font = new Font(label1.Font, label1.Font.Style | FontStyle.Italic);
        }

        private void BtnSubrayada_Click(object sender, EventArgs e)
        {
            label1.Font = new Font(label1.Font, label1.Font.Style | FontStyle.Underline);
        }
    }
}