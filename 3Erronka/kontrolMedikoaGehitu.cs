using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace _3Erronka
{
    public partial class kontrolMedikoaGehitu : Form
    {
        public kontrolMedikoaGehitu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Kontrola.gehituKontrolMedikoa(textBox1, textBox3, textBox4, textBox5, textBox6, textBox7);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            interfazeKontrolMedikoa ikm = new interfazeKontrolMedikoa();
            ikm.Show();
            this.Close();
        }
    }
}
