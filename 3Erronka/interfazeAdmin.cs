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
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            interfazeBezeroak ib = new interfazeBezeroak();
            ib.Show();
            this.Hide();
        }
    }
}
