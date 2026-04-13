using System;

public class Langilea
{
	private int id;
	private string izena;
    private string abizena;
	private string telefonoa;
	private string posta_elektronikoa;
	private string pasahitza;
	private Rola rola;


	public Langilea(int id,string izena,string abizena,string telefonoa,string posta_elektronikoa,string pasahitza,Rola rola)
	{
		this.id = id;
		this.izena = izena;
		this.abizena = abizena;
		this.telefonoa = telefonoa;
		this.posta_elektronikoa = posta_elektronikoa;
		this.pasahitza = pasahitza;
		this.rola = rola;
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

	public Rola getRola()
	{
		return rola;
	}

}
