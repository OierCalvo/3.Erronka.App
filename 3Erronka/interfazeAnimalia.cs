using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace _3Erronka
{
    public partial class interfazeAnimalia : Form
    {
        public interfazeAnimalia()
        {
            InitializeComponent();
        }

        private void interfazeAnimaliak_Load(object sender, EventArgs e)
        {
            Kontrola.animaliakErakutsi(dataGridView1);

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

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["id"].Value);

                Kontrola.ezabatuAnimalia(id);

                MessageBox.Show("Animalia ezabatuta!");

                Kontrola.animaliakErakutsi(dataGridView1);
            }
            else
            {
                MessageBox.Show("Aukeratu lerro bat");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridView1.CurrentCell.RowIndex;
            int colIndex = dataGridView1.CurrentCell.ColumnIndex;

            int id = Convert.ToInt32(dataGridView1.Rows[rowIndex].Cells["id"].Value);
            string zutabea = dataGridView1.Columns[colIndex].Name;
            string balioBerria = dataGridView1.Rows[rowIndex].Cells[colIndex].Value.ToString();


            Kontrola.editatuAnimalia(id, zutabea, balioBerria);
            Kontrola.animaliakErakutsi(dataGridView1);

            MessageBox.Show("Datua zuzen editatu da");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            animaliaGehitu ag = new animaliaGehitu();
            ag.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            interfazeAdmin ia = new interfazeAdmin();
            ia.Show();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            interfazeUgaztuna iu = new interfazeUgaztuna();
            iu.Show();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            interfazeNarrastia i = new interfazeNarrastia();
            i.Show();
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            interfazeHegaztiak ih = new interfazeHegaztiak();
            ih.Show();
            this.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            interfazeAnfibioa ia = new interfazeAnfibioa();
            ia.Show();
            this.Close();
        }
    }
}
