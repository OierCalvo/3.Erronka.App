using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace _3Erronka
{
    public partial class interfazeHegaztiak : Form
    {
        public interfazeHegaztiak()
        {
            InitializeComponent();
        }

        private void interfazeAnimaliak_Load(object sender, EventArgs e)
        {
            Kontrola.hegaztiakErakutsi(dataGridView1);

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
                button4.Visible = true;
            }
            else if (l.getRola().Equals("zaintzailea_nagusia"))
            {
                button2.Visible = true;
                button3.Visible = false;
                button4.Visible = true;
            }
            else if (l.getRola().Equals("kordinatzailea"))
            {
                button2.Visible = true;
                button3.Visible = false;
                button4.Visible = true;
            }
            else if (l.getRola().Equals("albaitaria"))
            {
                button2.Visible = true;
                button3.Visible = false;
                button4.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            interfazeAnimalia ia = new interfazeAnimalia();
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


            Kontrola.editatuHegaztiak(id, zutabea, balioBerria);
            Kontrola.hegaztiakErakutsi(dataGridView1);

            MessageBox.Show("Datua zuzen editatu da");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["id"].Value);

                Kontrola.ezabatuHegaztia(id);

                MessageBox.Show("Hegaztia ezabatuta!");

                Kontrola.hegaztiakErakutsi(dataGridView1);
            }
            else
            {
                MessageBox.Show("Aukeratu lerro bat");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            hegaztiaGehitu hg = new hegaztiaGehitu();
            hg.Show();
            this.Close();
        }
    }
}
