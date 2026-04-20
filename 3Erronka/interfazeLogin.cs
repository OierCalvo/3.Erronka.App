namespace _3Erronka
{
    public partial class interfazeLogin : Form
    {
        public interfazeLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Langilea l = Kontrola.login();
            if (l == null)
            {
                MessageBox.Show("Erabiltzailea edo pasahitza ez dira zuzenak");
                return;
            }else if (l.getRola().Equals("admina"))
            {
                MessageBox.Show("Admina zara", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                interfazeAdmin ia = new interfazeAdmin();
                ia.Show();
                this.Hide();
            }
            else if(l.getRola().Equals("kordinatzailea"))
            {
                MessageBox.Show("Kordinatzailea zara", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                interfazeAdmin ia = new interfazeAdmin();
                ia.Show();
                this.Hide();
            }
            else if (l.getRola().Equals("albaitaria"))
            {
                MessageBox.Show("Albaitaria zara", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                interfazeAdmin ia = new interfazeAdmin();
                ia.Show();
                this.Hide();
            }
            else if (l.getRola().Equals("zaintzaile_arrunta"))
            {
                MessageBox.Show("Zaintzaile arrunta zara", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                interfazeAdmin ia = new interfazeAdmin();
                ia.Show();
                this.Hide();
            }
            else if (l.getRola().Equals("zaintzailea_nagusia"))
            {
                MessageBox.Show("Zaintzaile nagusia zara", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                interfazeAdmin ia = new interfazeAdmin();
                ia.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Erabiltzailea edo pasahitza ez dira zuzenak", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                interfazeAdmin ia = new interfazeAdmin();
                ia.Show();
                this.Hide();
            }
        }
    }
}
