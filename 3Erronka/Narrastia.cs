using MySql.Data.MySqlClient;
using System;

public class Narrastia : Animalia
{
    private int id_narrasti;
    private Animalia animalia;
    private int arraultz_kopurua;
    private Boolean toxikoa;


    public Narrastia(int id, Habitat habitat, string izena, string espeziea, string sexua, DateTime jaiotza_data, string deskribapena, int id_narrasti, Animalia animalia, int arraultz_kopurua, Boolean toxikoa) : base(id, habitat, izena, espeziea, sexua, jaiotza_data, deskribapena)
    {
        this.id_narrasti = id_narrasti;
        this.animalia = animalia;
        this.arraultz_kopurua = arraultz_kopurua;
        this.toxikoa = toxikoa;
    }

    public Narrastia()
    {

    }

    public int getIdNarrasti()
    {
        return id_narrasti;
    }

    public Animalia getAnimalia()
    {
        return animalia; 
    }

    public int getArraultzKopurua()
    {
        return arraultz_kopurua;
    }

    public Boolean getToxikoa()
    {
        return toxikoa; 
    }

    public List<Narrastia> GetNarrastiak()
    {
        List<Narrastia> narrastiZerrenda = new List<Narrastia>();

        try
        {
            MySqlConnection con = Konexioa.konexioa();

            string sql = "SELECT * FROM narrastiakTablatikKonstruktorera";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            con.Open();

            MySqlDataReader rs = cmd.ExecuteReader();

            while (rs.Read())
            {
                Habitat h = new Habitat(rs.GetInt32("id_habitat"));
                Animalia an = new Animalia(rs.GetInt32("id_animali"));

                Narrastia n = new Narrastia(
                    rs.GetInt32("animali_id"),
                    h,
                    rs.GetString("izena"),
                    rs.GetString("espeziea"),
                    rs.GetString("sexua"),
                    rs.GetDateTime("jaiotza_data"),
                    rs.GetString("deskribapena"),
                    rs.GetInt32("narrasti_id"),
                    an,
                    rs.GetInt32("arrautz_kop"),
                    rs.GetBoolean("toxikoa")
                );

                narrastiZerrenda.Add(n);
            }

            rs.Close();
            con.Close();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }

        return narrastiZerrenda;
    }
}
