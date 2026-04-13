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
}
