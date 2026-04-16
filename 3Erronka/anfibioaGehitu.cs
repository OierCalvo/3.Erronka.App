using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace _3Erronka
{
    public partial class anfibioaGehitu : Form
    {
        public anfibioaGehitu()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            interfazeAnfibioa ia = new interfazeAnfibioa();
            ia.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Kontrola.gehituAnfibioa(textBox1, textBox2, textBox3);
        }
    }
}
