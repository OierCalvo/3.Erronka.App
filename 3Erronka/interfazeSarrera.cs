using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace _3Erronka
{
    public partial class interfazeSarrera : Form
    {
        public interfazeSarrera()
        {
            InitializeComponent();
        }

        private void interfazeAnimaliak_Load(object sender, EventArgs e)
        {
            Kontrola.sarrerakErakutsi(dataGridView1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            interfazeAdmin ia = new interfazeAdmin();
            ia.Show();
            this.Close();
        }

        


        private void button4_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Selecciona una fila");
                return;
            }

            DataGridViewRow row = dataGridView1.CurrentRow;

            int id = Convert.ToInt32(row.Cells["id"].Value);
            string erreserba = row.Cells["idErreserba"].Value.ToString();
            string data = row.Cells["data"].Value.ToString();
            string plaza = row.Cells["plaza_kopurua"].Value.ToString();
            string ekitaldia = row.Cells["id_ekitaldia"].Value.ToString();
            string bezeroa = row.Cells["id_bezeroa"].Value.ToString();
            string prezioa = row.Cells["prezioa"].Value.ToString();

            GenerarPDF(id, erreserba, data, plaza, ekitaldia, bezeroa, prezioa);
        }
    }
}
