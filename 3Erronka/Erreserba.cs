using System;

public class Erreserba
{
    private int id;
    private Bezeroa bezeroa;
    private Ekitaldia ekitaldia;
    private DateTime data;
    private int plaza_kopurua;


    public Erreserba(int id,Bezeroa bezeroa,Ekitaldia ekitaldia,DateTime data,int plaza_kopurua)
    {
        this.id = id;
        this.bezeroa = bezeroa;
        this.ekitaldia = ekitaldia;
        this.data = data;
        this.plaza_kopurua = plaza_kopurua;
    }

    public int getId() 
    { 
        return id; 
    }

    public Bezeroa getBezeroa()
    {
        return bezeroa;
    }

    public Ekitaldia getEkitaldia()
    {
        return ekitaldia;
    }

    public DateTime getData()
    {
        return data;
    }

    public int getPlazaKopurua()
    {
        return plaza_kopurua;
    }
}
