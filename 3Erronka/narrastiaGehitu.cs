using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace _3Erronka
{
    public partial class narrastiaGehitu : Form
    {
        public narrastiaGehitu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Kontrola.gehituNarrastiak(textBox1, textBox2, textBox3);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            interfazeNarrastia i = new interfazeNarrastia();
            i.Show();
            this.Close();
        }
    }
}
