using _3Erronka;
using MySql.Data.MySqlClient;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;

public class Kontrola
{
    public static Langilea login()
    {
        Langilea l = new Langilea();
        List<Langilea> langileZerrenda = l.GetLangileak();

        foreach (Langilea ln in langileZerrenda)
        {
            if (ln.getPostaElektronikoa().Equals(interfazeLogin.textBox1.Text) && ln.getPasahitza().Equals(interfazeLogin.textBox2.Text))
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
        dgv.Columns.Add("adina", "Adina");

        
        foreach (Bezeroa b in zerrenda)
        {
            dgv.Rows.Add(
                b.getId(),
                b.getIzena(),
                b.getAbizena(),
                b.getTelefonoa(),
                b.getPostaElektronikoa(),
                b.getPasahitza(),
                b.getAdina()
            );
        }
    }

    public static void gehituBezeroa(TextBox tx1, TextBox tx2,TextBox tx3, TextBox tx4, TextBox tx5, TextBox tx6)
    {
        MySqlConnection con = Konexioa.konexioa();
        string sql = "INSERT INTO bezeroak (izena, abizena, telefonoa, posta_elektronikoa, pasahitza, adina) VALUES (@izena, @abizena, @telefonoa, @postaElektronikoa, @pasahitza, @adina)";

        using (MySqlCommand cmd = new MySqlCommand(sql, con))
        {
            cmd.Parameters.AddWithValue("@izena", tx1.Text);
            cmd.Parameters.AddWithValue("@abizena", tx2.Text);
            cmd.Parameters.AddWithValue("@telefonoa", tx3.Text);
            cmd.Parameters.AddWithValue("@postaElektronikoa", tx4.Text);
            cmd.Parameters.AddWithValue("@pasahitza", tx5.Text);
            cmd.Parameters.AddWithValue("@adina", tx6.Text);

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
        string sql = $"UP bezeroak SET {zutabea} = @valor WHERE id = @id";

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


    public static void gehituAnimalia(TextBox tx1, TextBox tx2, TextBox tx3, TextBox tx4, TextBox tx5, TextBox tx6)
    {
        MySqlConnection con = Konexioa.konexioa();
        string sql = "INSERT INTO animaliak (id_habitata, izena, espeziea, sexua, jaiotza_data, deskribapena) VALUES (@id_habitata, @izena, @espeziea, @sexua, @jaiotza_data, @deskribapena)";

        using (MySqlCommand cmd = new MySqlCommand(sql, con))
        {
            cmd.Parameters.AddWithValue("@id_habitata", tx1.Text);
            cmd.Parameters.AddWithValue("@izena", tx2.Text);
            cmd.Parameters.AddWithValue("@espeziea", tx3.Text);
            cmd.Parameters.AddWithValue("@sexua", tx4.Text);
            cmd.Parameters.AddWithValue("@jaiotza_data", tx5.Text);
            cmd.Parameters.AddWithValue("@deskribapena", tx6.Text);

            con.Open();
            int filas = cmd.ExecuteNonQuery();
            con.Close();

            if (filas > 0)
                MessageBox.Show("Animalia gehitu da");
            else
                MessageBox.Show("Ezin izan da gehitu");
        }

    }

    public static void ezabatuAnimalia(int id)
    {
        try
        {
            MySqlConnection con = Konexioa.konexioa();
            string sql = "DELETE FROM animaliak WHERE id = @id";

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

    public static void editatuAnimalia(int id, string zutabea, string balioa)
    {
        MySqlConnection con = Konexioa.konexioa();
        string sql = $"UPDATE animaliak SET {zutabea} = @valor WHERE id = @id";

        using (MySqlCommand cmd = new MySqlCommand(sql, con))
        {
            cmd.Parameters.AddWithValue("@valor", balioa);
            cmd.Parameters.AddWithValue("@id", id);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }

    public static void animaliakErakutsi(DataGridView dgv)
    {
        Animalia a = new Animalia();
        var zerrenda = a.GetAnimaliak();


        dgv.Columns.Clear();
        dgv.Rows.Clear();


        dgv.Columns.Add("id", "ID");
        dgv.Columns.Add("id_habitata", "Id habitata");
        dgv.Columns.Add("izena", "Izena");
        dgv.Columns.Add("espeziea", "Espeziea");
        dgv.Columns.Add("sexua", "Sexua");
        dgv.Columns.Add("jaiotza_data", "Jaiotza Data");
        dgv.Columns.Add("deskribapena", "Deskribapena");



        foreach (Animalia b in zerrenda)
        {
            dgv.Rows.Add(
                b.getId(),
                b.getHabitat(),
                b.getIzena(),
                b.getEspeziea(),
                b.getSexua(),
                b.getJaiotzaData(),
                b.getDeskribapena()
            );
        }
    }

    public static void gehituHabitata(TextBox tx1, TextBox tx2, TextBox tx3, TextBox tx4, TextBox tx5)
    {
        MySqlConnection con = Konexioa.konexioa();
        string sql = "INSERT INTO habitatak (izena, mota, temperatura, azalera, deskribapena) VALUES (@izena, @mota, @temperatura, @azalera, @deskribapena)";

        using (MySqlCommand cmd = new MySqlCommand(sql, con))
        {
            cmd.Parameters.AddWithValue("@izena", tx1.Text);
            cmd.Parameters.AddWithValue("@mota", tx2.Text);
            cmd.Parameters.AddWithValue("@temperatura", tx3.Text);
            cmd.Parameters.AddWithValue("@azalera", tx4.Text);
            cmd.Parameters.AddWithValue("@deskribapena", tx5.Text);

            con.Open();
            int filas = cmd.ExecuteNonQuery();
            con.Close();

            if (filas > 0)
                MessageBox.Show("Habitata gehitu da");
            else
                MessageBox.Show("Ezin izan da gehitu");
        }

    }

    public static void ezabatuHabitata(int id)
    {
        try
        {
            MySqlConnection con = Konexioa.konexioa();
            string sql = "DELETE FROM habitatak WHERE id = @id";

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

    public static void editatuHabitata(int id, string zutabea, string balioa)
    {
        MySqlConnection con = Konexioa.konexioa();
        string sql = $"UPDATE habitatak SET {zutabea} = @valor WHERE id = @id";

        using (MySqlCommand cmd = new MySqlCommand(sql, con))
        {
            cmd.Parameters.AddWithValue("@valor", balioa);
            cmd.Parameters.AddWithValue("@id", id);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }

    public static void habitatakErakutsi(DataGridView dgv)
    {
        Habitat a = new Habitat();
        var zerrenda = a.GetHabitatak();


        dgv.Columns.Clear();
        dgv.Rows.Clear();


        dgv.Columns.Add("id", "ID");
        dgv.Columns.Add("izena", "Izena");
        dgv.Columns.Add("mota", "Mota");
        dgv.Columns.Add("temperatura", "Temperatura");
        dgv.Columns.Add("azalera", "Azalera");
        dgv.Columns.Add("deskribapena", "Deskribapena");



        foreach (Habitat b in zerrenda)
        {
            dgv.Rows.Add(
                b.getId(),
                b.getIzena(),
                b.getMota(),
                b.getTemperatura(),
                b.getAzalera(),
                b.getDeskribapena()
            );
        }
    }

    public static void gehituEkitaldia(TextBox tx1, TextBox tx2, TextBox tx3)
    {
        MySqlConnection con = Konexioa.konexioa();
        string sql = "INSERT INTO ekitaldiak (ekitaldi_izena, ordua, deskribapena, id_langilea) VALUES (@izena, @ordua, @deskribapena, @id)";

        using (MySqlCommand cmd = new MySqlCommand(sql, con))
        {
            Langilea l = login();
            cmd.Parameters.AddWithValue("@izena", tx1.Text);
            cmd.Parameters.AddWithValue("@ordua", tx2.Text);
            cmd.Parameters.AddWithValue("@deskribapena", tx3.Text);
            cmd.Parameters.AddWithValue("@id", l.getId());

            con.Open();
            int filas = cmd.ExecuteNonQuery();
            con.Close();

            if (filas > 0)
                MessageBox.Show("Ekitaldia gehitu da");
            else
                MessageBox.Show("Ezin izan da gehitu");
        }

    }

    public static void ezabatuEkitaldia(int id)
    {
        try
        {
            MySqlConnection con = Konexioa.konexioa();
            string sql = "DELETE FROM ekitaldiak WHERE id = @id";

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

    public static void editatuEkitaldia(int id, string zutabea, string balioa)
    {
        MySqlConnection con = Konexioa.konexioa();
        string sql = $"UPDATE ekitaldiak SET {zutabea} = @valor WHERE id = @id";

        using (MySqlCommand cmd = new MySqlCommand(sql, con))
        {
            cmd.Parameters.AddWithValue("@valor", balioa);
            cmd.Parameters.AddWithValue("@id", id);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }

    public static void ekitaldiakErakutsi(DataGridView dgv)
    {
        Ekitaldia a = new Ekitaldia();
        var zerrenda = a.GetEkitaldiak();


        dgv.Columns.Clear();
        dgv.Rows.Clear();


        dgv.Columns.Add("id", "ID");
        dgv.Columns.Add("ekitaldi_izena", "Izena");
        dgv.Columns.Add("ordua", "Ordua");
        dgv.Columns.Add("deskribapena", "Deskribapena");
        dgv.Columns.Add("id_langilea", "Id_langilea");



        foreach (Ekitaldia b in zerrenda)
        {
            dgv.Rows.Add(
                b.getId(),
                b.getEkitaldiIzena(),
                b.getOrdua(),
                b.getDeskribapena(),
                b.getLangilea()
            );
        }
    }

    public static void gehituUgaztunak(TextBox tx1, TextBox tx2, TextBox tx3)
    {
        MySqlConnection con = Konexioa.konexioa();
        string sql = "INSERT INTO ugaztunak (id_animalia, ile_mota, ugalketa_mota) VALUES (@id, @ile, @ugalketa)";

        using (MySqlCommand cmd = new MySqlCommand(sql, con))
        {
            cmd.Parameters.AddWithValue("@id", tx1.Text);
            cmd.Parameters.AddWithValue("@ile", tx2.Text);
            cmd.Parameters.AddWithValue("@ugalketa", tx3.Text);

            con.Open();
            int filas = cmd.ExecuteNonQuery();
            con.Close();

            if (filas > 0)
                MessageBox.Show("Ugaztuna gehitu da");
            else
                MessageBox.Show("Ezin izan da gehitu");
        }

    }

    public static void ezabatuUgaztuna(int id)
    {
        try
        {
            MySqlConnection con = Konexioa.konexioa();
            string sql = "DELETE FROM ugaztunak WHERE id = @id";

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

    public static void editatuUgaztunak(int id, string zutabea, string balioa)
    {
        MySqlConnection con = Konexioa.konexioa();
        string sql = $"UPDATE ugaztunak SET {zutabea} = @valor WHERE id = @id";

        using (MySqlCommand cmd = new MySqlCommand(sql, con))
        {
            cmd.Parameters.AddWithValue("@valor", balioa);
            cmd.Parameters.AddWithValue("@id", id);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }

    public static void ugaztunakErakutsi(DataGridView dgv)
    {
        Ugaztuna a = new Ugaztuna();
        var zerrenda = a.GetUgaztunak();


        dgv.Columns.Clear();
        dgv.Rows.Clear();


        dgv.Columns.Add("id", "ID");
        dgv.Columns.Add("id_animalia", "Id_animalia");
        dgv.Columns.Add("ile_mota", "Ile mota");
        dgv.Columns.Add("ugalketa_mota", "Ugalketa mota");



        foreach (Ugaztuna b in zerrenda)
        {
            dgv.Rows.Add(
                b.getId(),
                b.getAnimalia(),
                b.getIleMota(),
                b.getUgalketaMota()
            );
        }
    }

    public static void gehituNarrastiak(TextBox tx1, TextBox tx2, TextBox tx3)
    {
        MySqlConnection con = Konexioa.konexioa();
        string sql = "INSERT INTO narrastiak (id_animalia, toxikoa, arrautz_kop) VALUES (@id, @toxiko, @arrautz)";

        using (MySqlCommand cmd = new MySqlCommand(sql, con))
        {
            cmd.Parameters.AddWithValue("@id", tx1.Text);
            cmd.Parameters.AddWithValue("@toxiko", tx2.Text);
            cmd.Parameters.AddWithValue("@arrautz", tx3.Text);

            con.Open();
            int filas = cmd.ExecuteNonQuery();
            con.Close();

            if (filas > 0)
                MessageBox.Show("Narrastia gehitu da");
            else
                MessageBox.Show("Ezin izan da gehitu");
        }

    }

    public static void ezabatuNarrastia(int id)
    {
        try
        {
            MySqlConnection con = Konexioa.konexioa();
            string sql = "DELETE FROM narrastiak WHERE id = @id";

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

    public static void editatuNarrastiak(int id, string zutabea, string balioa)
    {
        MySqlConnection con = Konexioa.konexioa();

        string sql = $"UPDATE narrastiak SET {zutabea} = @valor WHERE id = @id";

        using (MySqlCommand cmd = new MySqlCommand(sql, con))
        {
            cmd.Parameters.AddWithValue("@valor", balioa);
            cmd.Parameters.AddWithValue("@id", id);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }

    public static void narrastiakErakutsi(DataGridView dgv)
    {
        Narrastia a = new Narrastia();
        var zerrenda = a.GetNarrastiak();


        dgv.Columns.Clear();
        dgv.Rows.Clear();


        dgv.Columns.Add("id", "ID");
        dgv.Columns.Add("id_animalia", "Id_animalia");
        dgv.Columns.Add("toxikoa", "Toxikoa");
        dgv.Columns.Add("arrautz_kop", "Arrautz kopurua");



        foreach (Narrastia b in zerrenda)
        {
            dgv.Rows.Add(
                b.getIdNarrasti(),
                b.getAnimalia(),
                b.getToxikoa(),
                b.getArraultzKopurua()
            );
        }
    }

    public static void gehituHegaztiak(TextBox tx1, TextBox tx2, TextBox tx3)
    {
        MySqlConnection con = Konexioa.konexioa();
        string sql = "INSERT INTO hegaztiak (id_animaliak, hegal_zabalera, hegalduna) VALUES (@id, @hegal, @hegaldun)";

        using (MySqlCommand cmd = new MySqlCommand(sql, con))
        {
            cmd.Parameters.AddWithValue("@id", tx1.Text);
            cmd.Parameters.AddWithValue("@hegal", tx2.Text);
            cmd.Parameters.AddWithValue("@hegaldun", tx3.Text);

            con.Open();
            int filas = cmd.ExecuteNonQuery();
            con.Close();

            if (filas > 0)
                MessageBox.Show("Hegaztia gehitu da");
            else
                MessageBox.Show("Ezin izan da gehitu");
        }

    }

    public static void ezabatuHegaztia(int id)
    {
        try
        {
            MySqlConnection con = Konexioa.konexioa();
            string sql = "DELETE FROM hegaztiak WHERE id = @id";

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

    public static void editatuHegaztiak(int id, string zutabea, string balioa)
    {
        MySqlConnection con = Konexioa.konexioa();

        string sql = $"UPDATE hegaztiak SET {zutabea} = @valor WHERE id = @id";

        using (MySqlCommand cmd = new MySqlCommand(sql, con))
        {
            cmd.Parameters.AddWithValue("@valor", balioa);
            cmd.Parameters.AddWithValue("@id", id);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }

    public static void hegaztiakErakutsi(DataGridView dgv)
    {
        Hegaztia a = new Hegaztia();
        var zerrenda = a.GetHegaztiak();


        dgv.Columns.Clear();
        dgv.Rows.Clear();


        dgv.Columns.Add("id", "ID");
        dgv.Columns.Add("id_animaliak", "Id_animalia");
        dgv.Columns.Add("hegal_zabalera", "Hegal zabalera");
        dgv.Columns.Add("hegalduna", "Hegalduna");



        foreach (Hegaztia b in zerrenda)
        {
            dgv.Rows.Add(
                b.getIdHegazti(),
                b.getAnimalia(),
                b.getHegalZabalera(),
                b.getHegalduna()
            );
        }
    }

    public static void gehituAnfibioa(TextBox tx1, TextBox tx2, TextBox tx3)
    {
        MySqlConnection con = Konexioa.konexioa();
        string sql = "INSERT INTO anfibioak (id_animalia, azal_mota, metamorfosia) VALUES (@id, @azal, @metamorfosi)";

        using (MySqlCommand cmd = new MySqlCommand(sql, con))
        {
            cmd.Parameters.AddWithValue("@id", tx1.Text);
            cmd.Parameters.AddWithValue("@azal", tx2.Text);
            cmd.Parameters.AddWithValue("@metamorfosi", tx3.Text);

            con.Open();
            int filas = cmd.ExecuteNonQuery();
            con.Close();

            if (filas > 0)
                MessageBox.Show("Anfibioa gehitu da");
            else
                MessageBox.Show("Ezin izan da gehitu");
        }

    }

    public static void ezabatuAnfibioa(int id)
    {
        try
        {
            MySqlConnection con = Konexioa.konexioa();
            string sql = "DELETE FROM anfibioak WHERE id = @id";

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

    public static void editatuAnfibioa(int id, string zutabea, string balioa)
    {
        MySqlConnection con = Konexioa.konexioa();

        string sql = $"UPDATE anfibioak SET {zutabea} = @valor WHERE id = @id";

        using (MySqlCommand cmd = new MySqlCommand(sql, con))
        {
            cmd.Parameters.AddWithValue("@valor", balioa);
            cmd.Parameters.AddWithValue("@id", id);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }

    public static void anfibioakErakutsi(DataGridView dgv)
    {
        Anfibioa a = new Anfibioa();
        var zerrenda = a.GetAnfibioak();


        dgv.Columns.Clear();
        dgv.Rows.Clear();


        dgv.Columns.Add("id", "ID");
        dgv.Columns.Add("id_animalia", "Id_animalia");
        dgv.Columns.Add("azal_mota", "Azal mota");
        dgv.Columns.Add("metamorfosia", "Metamorfosia");



        foreach (Anfibioa b in zerrenda)
        {
            dgv.Rows.Add(
                b.getIdAnfibio(),
                b.getAnimalia(),
                b.getAzalMota(),
                b.getMetamorfosia()
            );
        }
    }

    public static void gehituKontrolMedikoa(TextBox tx1, TextBox tx3, TextBox tx4, TextBox tx5, TextBox tx6, TextBox tx7)
    {
        MySqlConnection con = Konexioa.konexioa();
        string sql = "INSERT INTO kontrol_medikoak (id_animalia, id_langilea, data, diagnostikoa, tratamendua, oharra, sendatzeko_epea) VALUES (@id_animali, @id_langile, @data, @diagnostikoa, @tratamendua, @oharra, @sendatzeko_epea)";

        using (MySqlCommand cmd = new MySqlCommand(sql, con))
        {
            Langilea l = login();
            cmd.Parameters.AddWithValue("@id_animali", tx1.Text);
            cmd.Parameters.AddWithValue("@id_langile", l.getId());
            cmd.Parameters.AddWithValue("@data", tx3.Text);
            cmd.Parameters.AddWithValue("@diagnostikoa", tx4.Text);
            cmd.Parameters.AddWithValue("@tratamendua", tx5.Text);
            cmd.Parameters.AddWithValue("@oharra", tx6.Text);
            cmd.Parameters.AddWithValue("@sendatzeko_epea", tx7.Text);

            con.Open();
            int filas = cmd.ExecuteNonQuery();
            con.Close();

            if (filas > 0)
                MessageBox.Show("Kontrol medikoa gehitu da");
            else
                MessageBox.Show("Ezin izan da gehitu");
        }

    }

    public static void ezabatuKontrolMedikoa(int id)
    {
        try
        {
            MySqlConnection con = Konexioa.konexioa();
            string sql = "DELETE FROM kontrol_medikoak WHERE id = @id";

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

    public static void editatuKontrolMedikoa(int id, string zutabea, string balioa)
    {
        MySqlConnection con = Konexioa.konexioa();

        string sql = $"UPDATE kontrol_medikoak SET {zutabea} = @valor WHERE id = @id";

        using (MySqlCommand cmd = new MySqlCommand(sql, con))
        {
            cmd.Parameters.AddWithValue("@valor", balioa);
            cmd.Parameters.AddWithValue("@id", id);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }

    public static void kontrolMedikoakErakutsi(DataGridView dgv)
    {
        KontrolMedikoa a = new KontrolMedikoa();
        var zerrenda = a.GetKontrolMedikoak();


        dgv.Columns.Clear();
        dgv.Rows.Clear();


        dgv.Columns.Add("id", "ID");
        dgv.Columns.Add("id_animalia", "Id animalia");
        dgv.Columns.Add("id_langilea", "Id langilea");
        dgv.Columns.Add("data", "Data");
        dgv.Columns.Add("diagnostikoa", "Diagnostikoa");
        dgv.Columns.Add("tratamendua", "Tratamendua");
        dgv.Columns.Add("oharra", "Oharra");
        dgv.Columns.Add("sendatzeko_epea", "Sendatzeko epea");



        foreach (KontrolMedikoa b in zerrenda)
        {
            dgv.Rows.Add(
                b.getId(),
                b.getAnimalia(),
                b.getLangilea(),
                b.getData(),
                b.getDiagnostikoa(),
                b.getTratamendua(),
                b.getOharra(),
                b.getSendatzekoEpea()
            );
        }
    }

    public static void gehituErreserba(TextBox tx1,TextBox tx2, TextBox tx3, TextBox tx4, TextBox tx5)
    {
        MySqlConnection con = Konexioa.konexioa();
        string sql = "INSERT INTO erreserbak (id_bezeroa, id_ekitaldia, data, plaza_kopurua, prezioa) VALUES (@id_bezero, @id_ekitaldi, @data, @plazak, @prezioa)";

        using (MySqlCommand cmd = new MySqlCommand(sql, con))
        {
            Langilea l = login();
            cmd.Parameters.AddWithValue("@id_bezero", tx1.Text);
            cmd.Parameters.AddWithValue("@id_ekitaldi", tx2.Text);
            cmd.Parameters.AddWithValue("@data", tx3.Text);
            cmd.Parameters.AddWithValue("@plazak", tx4.Text);
            cmd.Parameters.AddWithValue("@prezioa", tx5.Text);

            con.Open();
            int filas = cmd.ExecuteNonQuery();
            con.Close();

            if (filas > 0)
                MessageBox.Show("Erreserba gehitu da");
            else
                MessageBox.Show("Ezin izan da gehitu");
        }

    }

    public static void ezabatuErreserba(int id)
    {
        try
        {
            MySqlConnection con = Konexioa.konexioa();
            string sql = "DELETE FROM erreserbak WHERE id = @id";

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

    public static void editatuErreserba(int id, string zutabea, string balioa)
    {
        MySqlConnection con = Konexioa.konexioa();

        string sql = $"UPDATE erreserbak SET {zutabea} = @valor WHERE id = @id";

        using (MySqlCommand cmd = new MySqlCommand(sql, con))
        {
            cmd.Parameters.AddWithValue("@valor", balioa);
            cmd.Parameters.AddWithValue("@id", id);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }

    public static void erreserbakErakutsi(DataGridView dgv)
    {
        Erreserba a = new Erreserba();
        var zerrenda = a.GetErreserbak();


        dgv.Columns.Clear();
        dgv.Rows.Clear();


        dgv.Columns.Add("id", "ID");
        dgv.Columns.Add("id_bezeroa", "Id bezeroa");
        dgv.Columns.Add("id_ekitaldia", "Id ekitaldia");
        dgv.Columns.Add("data", "Data");
        dgv.Columns.Add("plaza_kopurua", "Plaza kopurua");
        dgv.Columns.Add("prezioa", "Prezioa");



        foreach (Erreserba b in zerrenda)
        {
            dgv.Rows.Add(
                b.getId(),
                b.getBezeroa(),
                b.getEkitaldia(),
                b.getData(),
                b.getPlazaKopurua(),
                b.getPrezioa()
            );
        }
    }

    public static void sarrerakErakutsi(DataGridView dgv)
    {
        Sarrera a = new Sarrera();
        var zerrenda = a.GetSarrerak();


        dgv.Columns.Clear();
        dgv.Rows.Clear();


        dgv.Columns.Add("id", "ID");
        dgv.Columns.Add("idErreserba", "Id erreserba");
        dgv.Columns.Add("data", "Data");
        dgv.Columns.Add("plaza_kopurua", "Plaza kopurua");
        dgv.Columns.Add("id_ekitaldia", "Id ekitaldia");
        dgv.Columns.Add("id_bezeroa", "Id bezeroa");
        dgv.Columns.Add("prezioa", "prezioa");




        foreach (Sarrera b in zerrenda)
        {
            
            dgv.Rows.Add(
                b.getId(),
                b.getErreserba(),
                b.getData(),
                b.getPlaza(),
                b.GetEkitaldia(),
                b.GetBezeroa(),
                b.getPrezioa()

            );
        }
    }

    public void GenerarPDF(int id, string erreserba, string data, string plaza, string ekitaldia, string bezeroa, string prezioa)
    {
        string path = $"sarrera_{id}.pdf";

        PdfWriter writer = new PdfWriter(path);
        PdfDocument pdf = new PdfDocument(writer);
        Document doc = new Document(pdf);

        doc.Add(new Paragraph("SARRERA / TICKET").SetFontSize(18));
        doc.Add(new Paragraph("ID: " + id));
        doc.Add(new Paragraph("Erreserba: " + erreserba));
        doc.Add(new Paragraph("Data: " + data));
        doc.Add(new Paragraph("Plaza kopurua: " + plaza));
        doc.Add(new Paragraph("Ekitaldia: " + ekitaldia));
        doc.Add(new Paragraph("Bezeroa: " + bezeroa));
        doc.Add(new Paragraph("Prezioa: " + prezioa + " €"));

        doc.Close();

        MessageBox.Show("PDF creado: " + path);
    }
}