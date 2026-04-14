using MySql.Data.MySqlClient;
using System;

public class Ugaztuna : Animalia
{
    private int id_ugaztun;
    private Animalia animalia;
    private string ile_mota;
    private string ugalketa_mota;


    public Ugaztuna(int id, Habitat habitat, string izena, string espeziea, string sexua, DateTime jaiotza_data, string deskribapena, int id_ugaztun, Animalia animalia, string ile_mota, string ugalketa_mota) : base(id, habitat, izena, espeziea, sexua, jaiotza_data, deskribapena)
    {
        this.id_ugaztun = id_ugaztun;
        this.animalia = animalia;
        this.ile_mota = ile_mota;
        this.ugalketa_mota = ugalketa_mota;
    }

    public int getIdUgaztun()
    {
        return id_ugaztun;
    }

    public Animalia getAnimalia() {
        return animalia; 
    }

    public string getIleMota()
    {
        return ile_mota;
    }

    public string getUgalketaMota()
    {
        return ugalketa_mota;
    }

    public List<Ugaztuna> GetUgaztunak()
    {
        List<Ugaztuna> ugaztunZerrenda = new List<Ugaztuna>();

        try
        {
            MySqlConnection con = Konexioa.konexioa();

            string sql = "SELECT an.id as animali_id, an.id_habitata as id_habitat, an.izena, an.espeziea, an.sexua, an.jaiotza_data, an.deskribapena, u.id as ugaztun_id, u.id_animalia as id_animali, u.ile_mota, u.ugalketa_mota FROM animaliak an INNER JOIN ugaztunak u ON an.id = u.id_animalia";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            con.Open();

            MySqlDataReader rs = cmd.ExecuteReader();

            while (rs.Read())
            {
                Habitat h = new Habitat(rs.GetInt32("id_habitat"));
                Animalia an = new Animalia(rs.GetInt32("id_animali"));

                Ugaztuna u = new Ugaztuna(
                    rs.GetInt32("animali_id"),
                    h,
                    rs.GetString("izena"),
                    rs.GetString("espeziea"),
                    rs.GetString("sexua"),
                    rs.GetDateTime("jaiotza_data"),
                    rs.GetString("deskribapena"),
                    rs.GetInt32("ugaztun_id"),
                    an,
                    rs.GetString("ile_mota"),
                    rs.GetString("ugalketa_mota")
                );

                ugaztunZerrenda.Add(u);
            }

            rs.Close();
            con.Close();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }

        return ugaztunZerrenda;
    }

}
