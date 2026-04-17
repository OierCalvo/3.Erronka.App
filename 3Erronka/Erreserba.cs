using MySql.Data.MySqlClient;
using System;

public class Erreserba
{
    private int id;
    private Bezeroa bezeroa;
    private Ekitaldia ekitaldia;
    private DateTime data;
    private int plaza_kopurua;


    public Erreserba(int id,Bezeroa bezeroa,Ekitaldia ekitaldia,DateTime data,int plaza_kopurua)
    {
        this.id = id;
        this.bezeroa = bezeroa;
        this.ekitaldia = ekitaldia;
        this.data = data;
        this.plaza_kopurua = plaza_kopurua;
    }

    public Erreserba() 
    { 
    
    }

    public int getId() 
    { 
        return id; 
    }

    public Bezeroa getBezeroa()
    {
        return bezeroa;
    }

    public Ekitaldia getEkitaldia()
    {
        return ekitaldia;
    }

    public DateTime getData()
    {
        return data;
    }

    public int getPlazaKopurua()
    {
        return plaza_kopurua;
    }

    public List<Erreserba> GetErreserbak()
    {
        List<Erreserba> erreserbaZerrenda = new List<Erreserba>();

        try
        {
            MySqlConnection con = Konexioa.konexioa();

            string sql = "SELECT * FROM erreserbak";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            con.Open();

            MySqlDataReader rs = cmd.ExecuteReader();

            while (rs.Read())
            {
                Bezeroa b = new Bezeroa(rs.GetInt32("id_bezeroa"));
                Ekitaldia e = new Ekitaldia(rs.GetInt32("id_ekitaldia"));

                Erreserba er = new Erreserba(
                    rs.GetInt32("id"),
                    b,
                    e,
                    rs.GetDateTime("data"),
                    rs.GetInt32("plaza_kopurua")
                    
                );

                erreserbaZerrenda.Add(er);
            }

            rs.Close();
            con.Close();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }

        return erreserbaZerrenda;
    }
}
