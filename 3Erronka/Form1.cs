namespace _3Erronka
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Langilea l = Kontrola.login();

            if (l != null)
            {
                MessageBox.Show("Login correcto", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else if(l == null)
            {
                MessageBox.Show("Login incorrecto", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
