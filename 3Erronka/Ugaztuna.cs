using System;

public class Ugaztuna : Animalia
{
    private int id_ugaztun;
    private Animalia animalia;
    private string ile_mota;
    private string ugalketa_mota;


    public Ugaztuna(int id, Habitat habitat, string izena, string espeziea, string sexua, DateTime jaiotza_data, string deskribapena, int id_ugaztun, Animalia animalia, string ile_mota, string ugalketa_mota) : base(id, habitat, izena, espeziea, sexua, jaiotza_data, deskribapena)
    {
        this.id_ugaztun = id_ugaztun;
        this.animalia = animalia;
        this.ile_mota = ile_mota;
        this.ugalketa_mota = ugalketa_mota;
    }

    public int getIdUgaztun()
    {
        return id_ugaztun;
    }

    public Animalia getAnimalia() {
        return animalia; 
    }

    public string getIleMota()
    {
        return ile_mota;
    }

    public string getUgalketaMota()
    {
        return ugalketa_mota;
    }

}
