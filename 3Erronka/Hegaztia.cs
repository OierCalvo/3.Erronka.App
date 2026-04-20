using MySql.Data.MySqlClient;
using System;

public class Hegaztia : Animalia
{
    private int id_hegazti;
    private Animalia animalia;
    private double hegal_zabalera;
    private Boolean hegalduna;


    public Hegaztia(int id, Habitat habitat, string izena, string espeziea, string sexua, DateTime jaiotza_data, string deskribapena, int id_hegazti, Animalia animalia, double hegal_zabalera, Boolean hegalduna) : base(id, habitat, izena, espeziea, sexua, jaiotza_data, deskribapena)
    {
        this.id_hegazti = id_hegazti;
        this.animalia = animalia;
        this.hegal_zabalera = hegal_zabalera;
        this.hegalduna = hegalduna;
    }

    public Hegaztia()
    {

    }

    public int getIdHegazti()
    {
        return id_hegazti;
    }

    public Animalia getAnimalia() 
    {
        return animalia; 
    }

    public double getHegalZabalera()
    {
        return hegal_zabalera;
    }

    public Boolean getHegalduna()
    {
        return hegalduna;
    }

    public List<Hegaztia> GetHegaztiak()
    {
        List<Hegaztia> hegaztiZerrenda = new List<Hegaztia>();

        try
        {
            MySqlConnection con = Konexioa.konexioa();

            string sql = "SELECT * FROM hegaztiakTablatikKonstruktorera";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            con.Open();

            MySqlDataReader rs = cmd.ExecuteReader();

            while (rs.Read())
            {
                Habitat h = new Habitat(rs.GetInt32("id_habitat"));
                Animalia an = new Animalia(rs.GetInt32("id_animali"));

                Hegaztia he = new Hegaztia(
                    rs.GetInt32("animali_id"),
                    h,
                    rs.GetString("izena"),
                    rs.GetString("espeziea"),
                    rs.GetString("sexua"),
                    rs.GetDateTime("jaiotza_data"),
                    rs.GetString("deskribapena"),
                    rs.GetInt32("hegazti_id"),
                    an,
                    rs.GetDouble("hegal_zabalera"),
                    rs.GetBoolean("hegalduna")
                );

                hegaztiZerrenda.Add(he);
            }

            rs.Close();
            con.Close();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }

        return hegaztiZerrenda;
    }

}
