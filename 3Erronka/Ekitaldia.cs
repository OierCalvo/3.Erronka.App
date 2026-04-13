using System;

public class Ekitaldia
{
	private int id;
	private string ekitaldi_izena;
    private DateTime data;
	private string deskribapena;
	private Langilea langilea;


	public Ekitaldia(int id,string ekitaldi_izena,DateTime data,string deskribapena,Langilea langilea)
	{
		this.id = id;
		this.ekitaldi_izena = ekitaldi_izena;
		this.data = data;
		this.deskribapena = deskribapena;
		this.langilea = langilea;
	}

	public int getId()
	{
		return id; 
	}

	public string getEkitaldiIzena()
	{
		return ekitaldi_izena;
	}

	public DateTime getData()
	{
		return data;
	}

	public string getDeskribapena()
	{
		return deskribapena;
	}

	public Langilea getLangilea()
	{
		return langilea;
	}
}
