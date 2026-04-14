using MySql.Data.MySqlClient;
using System;

public class Bezeroa
{
    private int id;
    private string izena;
    private string abizena;
    private string telefonoa;
    private string posta_elektronikoa;
    private string pasahitza;
    private string nan;


    public Bezeroa(int id,string izena,string abizena,string telefonoa,string posta_elektronikoa,string pasahitza,string nan)
    {
        this.id = id;
        this.izena = izena;
        this.abizena = abizena;
        this.telefonoa = telefonoa;
        this.posta_elektronikoa = posta_elektronikoa;
        this.pasahitza = pasahitza;
        this.nan = nan;
    }

    public Bezeroa(int id)
    {
        this.id = id; 
    }

    public int getId() 
    { 
        return id; 
    }

    public string getZena()
    {
        return izena;
    }

    public string getAbizena()
    {
        return abizena;
    }

    public string getTelefonoa()
    {
        return telefonoa;
    }

    public string getPostaElektronikoa()
    {
        return posta_elektronikoa;
    }

    public string getPasahitza()
    {
        return pasahitza;
    }

    public string getNan()
    {
        return nan;
    }

    public List<Bezeroa> GetBezeroak()
    {
        List<Bezeroa> bezeroZerrenda = new List<Bezeroa>();

        try
        {
            MySqlConnection con = Konexioa.konexioa();

            string sql = "SELECT * FROM bezeroak";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            con.Open();

            MySqlDataReader rs = cmd.ExecuteReader();

            while (rs.Read())
            {

                Bezeroa b = new Bezeroa(
                    rs.GetInt32("id"),
                    rs.GetString("izena"),
                    rs.GetString("abizena"),
                    rs.GetString("telefonoa"),
                    rs.GetString("posta_eletronikoa"),
                    rs.GetString("pasahitza"),
                    rs.GetString("nan")
                );

                bezeroZerrenda.Add(b);
            }

            rs.Close();
            con.Close();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }

        return bezeroZerrenda;
    }
}
