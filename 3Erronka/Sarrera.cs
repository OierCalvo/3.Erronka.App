using MySql.Data.MySqlClient;
using System;

public class Sarrera
{
    private int id;
    private Erreserba erreserba;
    private DateTime data;
    private int plaza;
    private Ekitaldia ekitaldia;
    private Bezeroa bezeroa;
    private decimal prezioa;


    public Sarrera(int id, Erreserba erreserba, DateTime data, int plaza, Ekitaldia ekitaldia, Bezeroa bezeroa, decimal prezioa )
    {
        this.id = id;
        this.erreserba = erreserba;
        this.data = data;
        this.plaza = plaza;
        this.ekitaldia = ekitaldia;
        this.bezeroa = bezeroa;
        this.prezioa = prezioa;
    }

    public Sarrera()
    {

    }

    public int getId()
    {
        return id;
    }

    public Erreserba getErreserba()
    {
        return erreserba;
    }

    public DateTime getData()
    {
        return data;
    }

    public int getPlaza()
    {
        return plaza;
    }

    public Ekitaldia GetEkitaldia()
    {
        return ekitaldia;
    }

    public Bezeroa GetBezeroa()
    {
        return bezeroa;
    }


    public decimal getPrezioa()
    {
        return prezioa;
    }

    public List<Sarrera> GetSarrerak()
    {
        List<Sarrera> sarreraZerrenda = new List<Sarrera>();

        try
        {
            MySqlConnection con = Konexioa.konexioa();

            string sql = "SELECT s.id AS sarrera_id,s.id_erreserba AS erreserba_id,s.data AS data,e.plaza_kopurua AS plaza_kopurua,e.id_ekitaldia AS ekitaldia_id,e.id_bezeroa AS bezeroa_id,e.prezioa AS prezioa FROM sarrerak s INNER JOIN erreserbak e ON s.id_erreserba = e.id";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            con.Open();

            MySqlDataReader rs = cmd.ExecuteReader();

            while (rs.Read())
            {
                Erreserba e = new Erreserba(rs.GetInt32("erreserba_id"));
                Ekitaldia ek = new Ekitaldia(rs.GetInt32("ekitaldia_id"));
                Bezeroa b = new Bezeroa(rs.GetInt32("bezeroa_id"));

                Sarrera he = new Sarrera(
                    rs.GetInt32("sarrera_id"),
                    e,
                    rs.GetDateTime("data"),
                    rs.GetInt32("plaza_kopurua"),
                    ek,
                    b,
                    rs.GetDecimal("prezioa")
                );

                sarreraZerrenda.Add(he);
            }

            rs.Close();
            con.Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.ToString());
        }

        return sarreraZerrenda;
    }

}
