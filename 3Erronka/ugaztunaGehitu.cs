using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace _3Erronka
{
    public partial class ugaztunaGehitu : Form
    {
        public ugaztunaGehitu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Kontrola.gehituUgaztunak(textBox1, textBox2, textBox3);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            interfazeUgaztuna iu = new interfazeUgaztuna();
            iu.Show();
            this.Close();
        }
    }
}
