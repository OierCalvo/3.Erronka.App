using System;

public class Anfibioa : Animalia
{
    private int id_anfibio;
    private Animalia animalia;
    private string azal_mota;
    private Boolean metamorfosia;


    public Anfibioa(int id, Habitat habitat, string izena, string espeziea, string sexua, DateTime jaiotza_data, string deskribapena,int id_anfibio,Animalia animalia,string azal_mota,Boolean metamorfosia) : base(id, habitat, izena, espeziea, sexua, jaiotza_data, deskribapena)
    {
        this.id_anfibio = id_anfibio;
        this.animalia = animalia;
        this.azal_mota = azal_mota;
        this.metamorfosia = metamorfosia;
    }

    public int getIdAnfibio()
    {
        return id_anfibio;
    }

    public Animalia getAnimalia()
    {
        return animalia;
    }

    public string getAzalMota()
    {
        return azal_mota;
    }
    
    public Boolean getMetamorfosia()
    {
        return metamorfosia;
    }

    public override string ToString()
    {
        return id_anfibio.ToString();
    }
}
