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
            Kontrola.narrastiakErakutsi(dataGridView1);
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


            Kontrola.editatuNarrastiak(id, zutabea, balioBerria);
            Kontrola.narrastiakErakutsi(dataGridView1);

            MessageBox.Show("Datua zuzen editatu da");
        }
    }
}
