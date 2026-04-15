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
            if (ln.getPostaElektronikoa().Equals(tx1.Text) && ln.getPasahitza().Equals( tx2.Text))
            {
                return ln;
            }
        }

        return null;
    }


    public static void bezeroakErakutsi(DataGridView dgv)
    {
        Bezeroa a = new Bezeroa();
        var zerrenda = a.GetBezeroak();

        
        dgv.Columns.Clear();
        dgv.Rows.Clear();

        
        dgv.Columns.Add("id", "ID");
        dgv.Columns.Add("izena", "Izena");
        dgv.Columns.Add("abizena", "Abizena");
        dgv.Columns.Add("telefonoa", "Telefonoa");
        dgv.Columns.Add("posta_elektronikoa", "Posta Elektronikoa");
        dgv.Columns.Add("pasahitza", "Pasahitza");
        dgv.Columns.Add("nan", "NAN");

        
        foreach (Bezeroa b in zerrenda)
        {
            dgv.Rows.Add(
                b.getId(),
                b.getIzena(),
                b.getAbizena(),
                b.getTelefonoa(),
                b.getPostaElektronikoa(),
                b.getPasahitza(),
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

    public static void langileakErakutsi(DataGridView dgv)
    {
        Langilea a = new Langilea();    
        var zerrenda = a.GetLangileak();


        dgv.Columns.Clear();
        dgv.Rows.Clear();


        dgv.Columns.Add("id", "ID");
        dgv.Columns.Add("izena", "Izena");
        dgv.Columns.Add("abizena", "Abizena");
        dgv.Columns.Add("telefonoa", "Telefonoa");
        dgv.Columns.Add("posta_elektronikoa", "Posta Elektronikoa");
        dgv.Columns.Add("pasahitza", "Pasahitza");
        dgv.Columns.Add("rola", "Rola");



        foreach (Langilea b in zerrenda)
        {
            dgv.Rows.Add(
                b.getId(),
                b.getIzena(),
                b.getAbizena(),
                b.getTelefonoa(),
                b.getPostaElektronikoa(),
                b.getPasahitza(),
                b.getRola()
            );
        }
    }

    public static void gehituLangilea(TextBox tx1, TextBox tx2, TextBox tx3, TextBox tx4, TextBox tx5, TextBox tx6)
    {
        MySqlConnection con = Konexioa.konexioa();
        string sql = "INSERT INTO langileak (izena, abizena, telefonoa, posta_elektronikoa, pasahitza, rola) VALUES (@izena, @abizena, @telefonoa, @postaElektronikoa, @pasahitza, @rola)";

        using (MySqlCommand cmd = new MySqlCommand(sql, con))
        {
            cmd.Parameters.AddWithValue("@izena", tx1.Text);
            cmd.Parameters.AddWithValue("@abizena", tx2.Text);
            cmd.Parameters.AddWithValue("@telefonoa", tx3.Text);
            cmd.Parameters.AddWithValue("@postaElektronikoa", tx4.Text);
            cmd.Parameters.AddWithValue("@pasahitza", tx5.Text);
            cmd.Parameters.AddWithValue("@rola", tx6.Text);

            con.Open();
            int filas = cmd.ExecuteNonQuery();
            con.Close();

            if (filas > 0)
                MessageBox.Show("Langilea gehitu da");
            else
                MessageBox.Show("Ezin izan da gehitu");
        }

    }

    public static void ezabatuLangilea(int id)
    {
        try
        {
            MySqlConnection con = Konexioa.konexioa();
            string sql = "DELETE FROM langileak WHERE id = @id";

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

    public static void editatuLangilea(int id, string zutabea, string balioa)
    {
        MySqlConnection con = Konexioa.konexioa();
        string sql = $"UPDATE langileak SET {zutabea} = @valor WHERE id = @id";

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