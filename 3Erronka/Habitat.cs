using MySql.Data.MySqlClient;
using System;

public class Habitat
{
    private int id;
    private string izena;
    private string mota;
    private int temperatura;
    private double azalera;
    private string deskribapena;


    public Habitat(int id,string izena,string mota,int temperatura,double azalera,string deskribapena)
    {
        this.id = id;
        this.izena = izena;
        this.mota = mota;
        this.temperatura = temperatura;
        this.azalera = azalera;
        this.deskribapena = deskribapena;
    }

    public Habitat(int id)
    {
        this.id = id; 
    }

    public int getId()
    {
        return id; 
    }

    public string getIzena()
    {
        return izena;
    }

    public string getMota()
    {
        return mota;
    }

    public int getTemperatura()
    {
        return temperatura;
    }

    public double getAzalera()
    {
        return azalera;
    }

    public string getDeskribapena()
    {
        return deskribapena;
    }

    public override string ToString()
    {
        return id.ToString();
    }

    public List<Habitat> GetHabitatak()
    {
        List<Habitat> habitatZerrenda = new List<Habitat>();

        try
        {
            MySqlConnection con = Konexioa.konexioa();

            string sql = "SELECT * FROM habitatak";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            con.Open();

            MySqlDataReader rs = cmd.ExecuteReader();

            while (rs.Read())
            {

                Habitat h = new Habitat(
                    rs.GetInt32("id"),
                    rs.GetString("izena"),
                    rs.GetString("mota"),
                    rs.GetInt32("temperatura"),
                    rs.GetDouble("azalera"),
                    rs.GetString("deskribapena")
                );

                habitatZerrenda.Add(h);
            }

            rs.Close();
            con.Close();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }

        return habitatZerrenda;
    }


}
