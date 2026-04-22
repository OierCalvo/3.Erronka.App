using MySql.Data.MySqlClient;
using System;

public class Anfibioa : Animalia
{
    private int id_anfibio;
    private Animalia animalia;
    private string azal_mota;
    private Boolean metamorfosia;


    public Anfibioa(int id, Habitat habitat, string izena, string espeziea, string sexua, DateTime jaiotza_data, string deskribapena,int id_anfibio,Animalia animalia,string azal_mota,Boolean metamorfosia) : base(id, habitat, izena, espeziea, sexua, jaiotza_data, deskribapena)
    {
        this.id_anfibio = id_anfibio;
        this.animalia = animalia;
        this.azal_mota = azal_mota;
        this.metamorfosia = metamorfosia;
    }

    public Anfibioa()
    {

    }


    public int getIdAnfibio()
    {
        return id_anfibio;
    }

    public Animalia getAnimalia()
    {
        return animalia;
    }

    public string getAzalMota()
    {
        return azal_mota;
    }
    
    public Boolean getMetamorfosia()
    {
        return metamorfosia;
    }

    public override string ToString()
    {
        return id_anfibio.ToString();
    }

    public List<Anfibioa> GetAnfibioak()
    {
        List<Anfibioa> anfibioZerrenda = new List<Anfibioa>();

        try
        {
            MySqlConnection con = Konexioa.konexioa();

            string sql = "SELECT * FROM anfibioaktablatikkonstruktorera";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            con.Open();

            MySqlDataReader rs = cmd.ExecuteReader();

            while (rs.Read())
            {
                Habitat h = new Habitat(rs.GetInt32("id_habitat"));
                Animalia an = new Animalia(rs.GetInt32("id_animali"));

                Anfibioa a = new Anfibioa(
                    rs.GetInt32("animali_id"),
                    h,
                    rs.GetString("izena"),
                    rs.GetString("espeziea"),
                    rs.GetString("sexua"),
                    rs.GetDateTime("jaiotza_data"),
                    rs.GetString("deskribapena"),
                    rs.GetInt32("anfibio_id"),
                    an,
                    rs.GetString("azal_mota"),
                    rs.GetBoolean("metamorfosia")
                );

                anfibioZerrenda.Add(a);
            }

            rs.Close();
            con.Close();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }

        return anfibioZerrenda;
    }
}
