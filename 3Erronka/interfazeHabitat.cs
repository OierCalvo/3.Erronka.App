using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace _3Erronka
{
    public partial class interfazeHabitat : Form
    {
        public interfazeHabitat()
        {
            InitializeComponent();
        }

        private void interfazeAnimaliak_Load(object sender, EventArgs e)
        {
            Kontrola.habitatakErakutsi(dataGridView1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            interfazeAdmin ia = new interfazeAdmin();
            ia.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["id"].Value);

                Kontrola.ezabatuHabitata(id);

                MessageBox.Show("Habitata ezabatuta!");

                Kontrola.habitatakErakutsi(dataGridView1);
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


            Kontrola.editatuHabitata(id, zutabea, balioBerria);
            Kontrola.habitatakErakutsi(dataGridView1);

            MessageBox.Show("Datua zuzen editatu da");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            habitatGehitu hg = new habitatGehitu();
            hg.Show();
            this.Close();
        }
    }
}
