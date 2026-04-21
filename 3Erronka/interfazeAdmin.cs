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

        private void Form1_Load(object sender, EventArgs e)
        {
            Langilea l = Kontrola.login();
            if (l.getRola().Equals("admina"))
            {
                label1.Visible = true;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                button1.Visible = true;
                button2.Visible = true;
                button3.Visible = true;
                button4.Visible = true;
                button5.Visible = true;
                button6.Visible = true;
                button7.Visible = true;
            }
            else if (l.getRola().Equals("zaintzaile_arrunta"))
            {
                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = true;
                label5.Visible = false;
                button1.Visible = true;
                button2.Visible = false;
                button3.Visible = true;
                button4.Visible = false;
                button5.Visible = true;
                button6.Visible = true;
                button7.Visible = false;
            }
            else if (l.getRola().Equals("zaintzailea_nagusia"))
            {
                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = true;
                label5.Visible = true;
                button1.Visible = true;
                button2.Visible = false;
                button3.Visible = true;
                button4.Visible = false;
                button5.Visible = true;
                button6.Visible = true;
                button7.Visible = false;
            }
            else if (l.getRola().Equals("kordinatzailea"))
            {
                label1.Visible = false;
                label2.Visible = true;
                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                button1.Visible = true;
                button2.Visible = true;
                button3.Visible = true;
                button4.Visible = true;
                button5.Visible = true;
                button6.Visible = true;
                button7.Visible = true;
            }
            else if (l.getRola().Equals("albaitaria"))
            {
                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = true;
                label4.Visible = false;
                label5.Visible = false;
                button1.Visible = true;
                button2.Visible = false;
                button3.Visible = true;
                button4.Visible = false;
                button5.Visible = true;
                button6.Visible = true;
                button7.Visible = false;
            }
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

        private void button3_Click(object sender, EventArgs e)
        {
            interfazeEkitaldia ie = new interfazeEkitaldia();
            ie.Show();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            interfazeKontrolMedikoa ikm = new interfazeKontrolMedikoa();
            ikm.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            interfazeErreserba ie = new interfazeErreserba();
            ie.Show();
            this.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            interfazeLogin il = new interfazeLogin();
            il.Show();
            this.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            interfazeSarrera ib = new interfazeSarrera();
            ib.Show();
            this.Close();
        }
    }
}