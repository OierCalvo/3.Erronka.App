using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace _3Erronka
{
    public partial class langileaGehitu : Form
    {
        public langileaGehitu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Kontrola.gehituLangilea(textBox1, textBox2, textBox3, textBox4, textBox5, textBox6);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            interfazeLangilea il = new interfazeLangilea();
            il.Show();
            this.Close();
        }
    }
}
