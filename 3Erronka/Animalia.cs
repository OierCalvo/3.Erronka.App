using MySql.Data.MySqlClient;
using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

public class Animalia
{
    private int id;
    private Habitat habitat;
    private string izena;
    private string espeziea;
    private string sexua;
    private DateTime jaiotza_data;
    private string deskribapena;


    public Animalia(int id,Habitat habitat,string izena,string espeziea,string sexua,DateTime jaiotza_data,string deskribapena)
    {
        this.id = id;
        this.habitat = habitat;
        this.izena = izena;
        this.espeziea = espeziea;
        this.sexua = sexua;
        this.jaiotza_data = jaiotza_data;
        this.deskribapena = deskribapena;
    }

    public Animalia(int id)
    {
        this.id = id; 
    }

    public int getId()
    {
        return id;
    }

    public Habitat getHabitat()
    {
        return habitat;
    }

    public string getZena()
    {
        return izena;
    }

    public string getEspeziea()
    {
        return espeziea;
    }

    public string getSexua()
    {
        return sexua;
    }

    public DateTime getJaiotzaData()
    {
        return jaiotza_data;
    }

    public string getDeskribapena()
    {
        return deskribapena;
    }

    public override string ToString()
    {
        return id.ToString();
    }

    public List<Animalia> GetAnimaliak()
    {
        List<Animalia> animaliZerrenda = new List<Animalia>();

        try
        {
            MySqlConnection con = Konexioa.konexioa();

            string sql = "SELECT * FROM animaliak";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            con.Open();

            MySqlDataReader rs = cmd.ExecuteReader();

            while (rs.Read())
            {
                Habitat h = new Habitat(rs.GetInt32("id_habitata"));

                Animalia a = new Animalia(
                    rs.GetInt32("id"),
                    h,
                    rs.GetString("izena"),
                    rs.GetString("espeziea"),
                    rs.GetString("sexua"),
                    rs.GetDateTime("jaiotza_data"),
                    rs.GetString("deskribapena")
                );

                animaliZerrenda.Add(a);
            }

            rs.Close();
            con.Close();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }

        return animaliZerrenda;
    }
}
