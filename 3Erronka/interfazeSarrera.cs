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

            Langilea l = Kontrola.login();
            if (l.getRola().Equals("admina"))
            {
         
                button4.Visible = true;
            }
            else if (l.getRola().Equals("zaintzaile_arrunta"))
            {
               
                button4.Visible = false;
            }
            else if (l.getRola().Equals("zaintzailea_nagusia"))
            {
               
                button4.Visible = true;
            }
            else if (l.getRola().Equals("kordinatzailea"))
            {
               
                button4.Visible = true;
            }
            else if (l.getRola().Equals("albaitaria"))
            {
                
                button4.Visible = false;
            }
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

            int idBezeroa = Convert.ToInt32(row.Cells["id_bezeroa"].Value);
            int idEkitaldia = Convert.ToInt32(row.Cells["id_ekitaldia"].Value);

            Bezeroa bezero = new Bezeroa(idBezeroa);
            Ekitaldia ekitaldi = new Ekitaldia(idEkitaldia);

            int id = Convert.ToInt32(row.Cells["ID"].Value);
            string erreserba = row.Cells["idErreserba"].Value.ToString();
            string data = row.Cells["data"].Value.ToString();
            string plaza = row.Cells["plaza_kopurua"].Value.ToString();
            string ekitaldia = row.Cells["id_ekitaldia"].Value.ToString();
            string bezeroa = row.Cells["id_bezeroa"].Value.ToString();
            string prezioa = row.Cells["prezioa"].Value.ToString();

            Kontrola.GenerarPDF(id,data, plaza, ekitaldi, bezero, prezioa);
        }
    }
}
