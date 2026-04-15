using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace _3Erronka
{
    public partial class interfazeAdmin : Form
    {
        public interfazeAdmin()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            interfazeAnimalia ia = new interfazeAnimalia();
            ia.Show();
            this.Close();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            interfazeBezeroak ib = new interfazeBezeroak();
            ib.Show();
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            interfazeLangilea il = new interfazeLangilea();
            il.Show();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            interfazeHabitat ih = new interfazeHabitat();
            ih.Show();
            this.Close();
        }
    }
}
