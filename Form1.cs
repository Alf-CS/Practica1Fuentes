namespace Practica1Fuentes
{
    public partial class PruebaFuentes : Form
    {
        public PruebaFuentes()
        {
            InitializeComponent();
        }

        private void BtnNegrita_Click(object sender, EventArgs e)
        {
            ChangeFontStyle(FontStyle.Bold);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnCursiva_Click(object sender, EventArgs e)
        {
            ChangeFontStyle(FontStyle.Italic);
        }
      
        private void BtnSubrayada_Click(object sender, EventArgs e)
        {
            ChangeFontStyle(FontStyle.Underline);
        }

        public void ChangeFontStyle( FontStyle style)
        {
            textBox.Font = new Font(textBox.Font, style);
        }
    }
}