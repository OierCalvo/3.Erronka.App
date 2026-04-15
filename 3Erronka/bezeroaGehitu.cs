using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace _3Erronka
{
    public partial class bezeroaGehitu : Form
    {
        public bezeroaGehitu()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            interfazeBezeroak ib = new interfazeBezeroak();
            ib.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Kontrola.gehituBezeroa(textBox1,textBox2,textBox3,textBox4,textBox5,textBox6);
        }
    }
}
