using _3Erronka;
using MySql.Data.MySqlClient;

public class Kontrola
{
    public static Langilea login(TextBox tx1, TextBox tx2)
    {
        Langilea l = new Langilea();
        List<Langilea> langileZerrenda = l.GetLangileak();

        foreach (Langilea ln in langileZerrenda)
        {
            if (ln.getPostaElektronikoa() == interfazeLogin.textBox1.Text && ln.getPasahitza() == interfazeLogin.textBox2.Text)
            {
                return ln;
            }
        }

        return null;
    }

    public static void bezeroakErakutsi(DataGridView dgv)
    {
        Bezeroa a = new Bezeroa();
        var lista = a.GetBezeroak();

        
        dgv.Columns.Clear();
        dgv.Rows.Clear();

        
        dgv.Columns.Add("id", "ID");
        dgv.Columns.Add("izena", "Izena");
        dgv.Columns.Add("abizena", "Abizena");
        dgv.Columns.Add("telefonoa", "Telefonoa");
        dgv.Columns.Add("posta", "Posta Elektronikoa");
        dgv.Columns.Add("nan", "NAN");

        
        foreach (Bezeroa b in lista)
        {
            dgv.Rows.Add(
                b.getId(),
                b.getIzena(),
                b.getAbizena(),
                b.getTelefonoa(),
                b.getPostaElektronikoa(),
                b.getNan()
            );
        }
    }

    public static void gehituBezeroa(TextBox tx1, TextBox tx2,TextBox tx3, TextBox tx4, TextBox tx5, TextBox tx6)
    {
        MySqlConnection con = Konexioa.konexioa();
        string sql = "INSERT INTO bezeroak (izena, abizena, telefonoa, posta_elektronikoa, pasahitza, nan) VALUES (@izena, @abizena, @telefonoa, @postaElektronikoa, @pasahitza, @nan)";

        using (MySqlCommand cmd = new MySqlCommand(sql, con))
        {
            cmd.Parameters.AddWithValue("@izena", tx1.Text);
            cmd.Parameters.AddWithValue("@abizena", tx2.Text);
            cmd.Parameters.AddWithValue("@telefonoa", tx3.Text);
            cmd.Parameters.AddWithValue("@postaElektronikoa", tx4.Text);
            cmd.Parameters.AddWithValue("@pasahitza", tx5.Text);
            cmd.Parameters.AddWithValue("@nan", tx6.Text);

            con.Open();
            int filas = cmd.ExecuteNonQuery();
            con.Close();

            if (filas > 0)
                MessageBox.Show("Bezeroa gehitu da");
            else
                MessageBox.Show("Ezin izan da gehitu");
        }

    }

    public static void ezabatuBezeroa(int id)
    {
        try
        {
            MySqlConnection con = Konexioa.konexioa();
            string sql = "DELETE FROM bezeroak WHERE id = @id";

            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@id", id);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        catch (Exception e)
        {
            MessageBox.Show("Errorea ezabatzean: " + e.Message);
        }
    }

    public static void editatuBezeroa(int id, string zutabea, string balioa)
    {
        MySqlConnection con = Konexioa.konexioa();
        string sql = $"UPDATE bezeroak SET {zutabea} = @valor WHERE id = @id";

        using (MySqlCommand cmd = new MySqlCommand(sql, con))
        {
            cmd.Parameters.AddWithValue("@valor", balioa);
            cmd.Parameters.AddWithValue("@id", id);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }

}