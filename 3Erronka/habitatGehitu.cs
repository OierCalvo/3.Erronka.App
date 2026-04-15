using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace _3Erronka
{
    public partial class habitatGehitu : Form
    {
        public habitatGehitu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Kontrola.gehituHabitata(textBox1, textBox2, textBox3, textBox4, textBox5);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            interfazeHabitat ih = new interfazeHabitat();
            ih.Show();
            this.Close();
        }
    }
}
