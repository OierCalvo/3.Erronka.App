using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

public class Langilea
{
	private int id;
	private string izena;
    private string abizena;
	private string telefonoa;
	private string posta_elektronikoa;
	private string pasahitza;
	private string rola;


	public Langilea(int id,string izena,string abizena,string telefonoa,string posta_elektronikoa,string pasahitza,string rola)
	{
		this.id = id;
		this.izena = izena;
		this.abizena = abizena;
		this.telefonoa = telefonoa;
		this.posta_elektronikoa = posta_elektronikoa;
		this.pasahitza = pasahitza;
		this.rola = rola;
	}

	public Langilea(int id)
	{
		this.id = id;
	}

	public Langilea()
	{

	}

	public int getId()
	{
		return id; 
	}

	public string getIzena()
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

	public string getRola()
	{
		return rola;
	}
    
	public override string ToString()
    {
        return id.ToString();
    }

    public List<Langilea> GetLangileak()
    {
        List<Langilea> langileZerrenda = new List<Langilea>();

        try
        {
            MySqlConnection con = Konexioa.konexioa();

			string sql = "SELECT * FROM langileak";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            con.Open();

            MySqlDataReader rs = cmd.ExecuteReader();

            while (rs.Read())
            {

                Langilea l = new Langilea(
                    rs.GetInt32("id"),
                    rs.GetString("izena"),
                    rs.GetString("abizena"),
					rs.GetString("telefonoa"),
                    rs.GetString("posta_elektronikoa"),
                    rs.GetString("pasahitza"),
                    rs.GetString("rola")
                );

                langileZerrenda.Add(l);
            }

            rs.Close();
            con.Close();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }

        return langileZerrenda;
    }

}
