using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace _3Erronka
{
    public partial class ekitaldiaGehitu : Form
    {
        public ekitaldiaGehitu()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            interfazeEkitaldia ie = new interfazeEkitaldia();
            ie.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Kontrola.gehituEkitaldia(textBox1, textBox2, textBox3);
        }
    }
}
