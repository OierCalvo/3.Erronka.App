using System;

public class Rola
{
    private int id;
    private string mota;


    public Rola(int id,string mota)
    {
        this.id = id;
        this.mota = mota;
    }


    public int getId()
    {
        return id; 
    }

    public string getMota()
    {
        return mota;
    }

    public override string ToString()
    {
        return id.ToString();
    }
}
