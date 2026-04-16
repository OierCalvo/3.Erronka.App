using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace _3Erronka
{
    public partial class hegaztiaGehitu : Form
    {
        public hegaztiaGehitu()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            interfazeHegaztiak ih = new interfazeHegaztiak();
            ih.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Kontrola.gehituHegaztiak(textBox1,textBox2,textBox3);
        }
    }
}
