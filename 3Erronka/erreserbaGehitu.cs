using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace _3Erronka
{
    public partial class erreserbaGehitu : Form
    {
        public erreserbaGehitu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Kontrola.gehituErreserba(textBox1, textBox2, textBox3, textBox4);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            interfazeErreserba ie = new interfazeErreserba();
            ie.Show();
            this.Close();
        }
    }
}
