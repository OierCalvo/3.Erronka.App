using System;

public class Narrastia : Animalia
{
    private int id_narrasti;
    private Animalia animalia;
    private int arraultz_kopurua;
    private Boolean toxikoa;


    public Narrastia(int id, Habitat habitat, string izena, string espeziea, string sexua, DateTime jaiotza_data, string deskribapena, int id_narrasti, Animalia animalia, int arraultz_kopurua, Boolean toxikoa) : base(id, habitat, izena, espeziea, sexua, jaiotza_data, deskribapena)
    {
        this.id_narrasti = id_narrasti;
        this.animalia = animalia;
        this.arraultz_kopurua = arraultz_kopurua;
        this.toxikoa = toxikoa;
    }

    public int getIdNarrasti()
    {
        return id_narrasti;
    }

    public Animalia getAnimalia()
    {
        return animalia; 
    }

    public int getArraultzKopurua()
    {
        return arraultz_kopurua;
    }

    public Boolean getToxikoa()
    {
        return toxikoa; 
    }
}
