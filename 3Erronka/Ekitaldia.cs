using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Cms;
using System;

public class Ekitaldia
{
	private int id;
	private string ekitaldi_izena;
    private TimeSpan ordua;
	private string deskribapena;
	private Langilea langilea;


	public Ekitaldia(int id,string ekitaldi_izena,TimeSpan ordua,string deskribapena,Langilea langilea)
	{
		this.id = id;
		this.ekitaldi_izena = ekitaldi_izena;
		this.ordua = ordua;
		this.deskribapena = deskribapena;
		this.langilea = langilea;
	}

    public Ekitaldia(int id) 
    {
        this.id = id;
        this.ekitaldi_izena = Kontrola.GetEkitaldiIzenaFromDb(id);
    }

    public Ekitaldia()
    {

    }

	public int getId()
	{
		return id; 
	}

	public string getEkitaldiIzena()
	{
		return ekitaldi_izena;
	}

	public TimeSpan getOrdua()
	{
		return ordua;
	}

	public string getDeskribapena()
	{
		return deskribapena;
	}

	public Langilea getLangilea()
	{
		return langilea;
	}

    public override string ToString()
    {
        return id.ToString();
    }

    public List<Ekitaldia> GetEkitaldiak()
    {
        List<Ekitaldia> ekitaldiZerrenda = new List<Ekitaldia>();

        try
        {
            MySqlConnection con = Konexioa.konexioa();

            string sql = "SELECT * FROM ekitaldiak";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            con.Open();

            MySqlDataReader rs = cmd.ExecuteReader();

            while (rs.Read())
            {
                Langilea l = new Langilea(rs.GetInt32("id_langilea"));

                Ekitaldia b = new Ekitaldia(
                    rs.GetInt32("id"),
                    rs.GetString("ekitaldi_izena"),
                    rs.GetTimeSpan("ordua"),
                    rs.GetString("deskribapena"),
                    l
                );

                ekitaldiZerrenda.Add(b);
            }

            rs.Close();
            con.Close();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }

        return ekitaldiZerrenda;
    }
}
