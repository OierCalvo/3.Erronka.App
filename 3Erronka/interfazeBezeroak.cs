using Org.BouncyCastle.Crmf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace _3Erronka
{
    public partial class interfazeBezeroak : Form
    {
        public interfazeBezeroak()
        {
            InitializeComponent();
        }
        private void interfazeAnimaliak_Load(object sender, EventArgs e)
        {
            Kontrola.bezeroakErakutsi(dataGridView1);

            Langilea l = Kontrola.login();
            if (l.getRola().Equals("admina"))
            {
                button2.Visible = true;
                button3.Visible = true;
                button4.Visible = true;
            }
            else if (l.getRola().Equals("zaintzaile_arrunta"))
            {
                button2.Visible = false;
                button3.Visible = false;
                button4.Visible = false;
            }
            else if (l.getRola().Equals("zaintzailea_nagusia"))
            {
                button2.Visible = false;
                button3.Visible = false;
                button4.Visible = false;
            }
            else if (l.getRola().Equals("kordinatzailea"))
            {
                button2.Visible = true;
                button3.Visible = false;
                button4.Visible = true;
            }
            else if (l.getRola().Equals("albaitaria"))
            {
                button2.Visible = false;
                button3.Visible = false;
                button4.Visible = false;
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["id"].Value);

                Kontrola.ezabatuBezeroa(id);

                MessageBox.Show("Bezeroa ezabatuta!");

                Kontrola.bezeroakErakutsi(dataGridView1);
            }
            else
            {
                MessageBox.Show("Aukeratu lerro bat");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bezeroaGehitu bg = new bezeroaGehitu();
            bg.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            interfazeAdmin ia = new interfazeAdmin();
            ia.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridView1.CurrentCell.RowIndex;
            int colIndex = dataGridView1.CurrentCell.ColumnIndex;

            int id = Convert.ToInt32(dataGridView1.Rows[rowIndex].Cells["id"].Value);
            string zutabea = dataGridView1.Columns[colIndex].Name;
            string balioBerria = dataGridView1.Rows[rowIndex].Cells[colIndex].Value.ToString();

            
            Kontrola.editatuBezeroa(id, zutabea, balioBerria);
            Kontrola.bezeroakErakutsi(dataGridView1);

            MessageBox.Show("Datua zuzen editatu da");
        }
    }
}
