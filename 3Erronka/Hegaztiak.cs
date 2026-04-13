using System;

public class Hegaztia : Animalia
{
    private int id_hegazti;
    private Animalia animalia;
    private double hegal_zabalera;
    private Boolean hegalduna;


    public Hegaztia(int id, Habitat habitat, string izena, string espeziea, string sexua, DateTime jaiotza_data, string deskribapena, int id_hegazti, Animalia animalia, double hegal_zabalera, Boolean hegalduna) : base(id, habitat, izena, espeziea, sexua, jaiotza_data, deskribapena)
    {
        this.id_hegazti = id_hegazti;
        this.animalia = animalia;
        this.hegal_zabalera = hegal_zabalera;
        this.hegalduna = hegalduna;
    }

    public int getIdHegazti()
    {
        return id_hegazti;
    }

    public Animalia getAnimalia() 
    {
        return animalia; 
    }

    public double getHegalZabalera()
    {
        return hegal_zabalera;
    }

    public Boolean getHegalduna()
    {
        return hegalduna;
    }

}
