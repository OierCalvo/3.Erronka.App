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
    
   
}
