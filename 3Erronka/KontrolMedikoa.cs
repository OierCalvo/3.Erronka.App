using MySql.Data.MySqlClient;
using System;

public class KontrolMedikoa
{
    private int id;
    private Animalia animalia;
    private Langilea langilea;
    private DateTime data;
    private string diagnostikoa;
    private string tratamendua;
    private string oharra;
    private DateTime sendatzeko_epea;


    public KontrolMedikoa(int id,Animalia animalia,Langilea langilea,DateTime data,string diagnostikoa,string tratamendua,string oharra,DateTime sendatzeko_epea)
    {
        this.id = id;
        this.animalia = animalia;
        this.langilea = langilea;
        this.data = data;
        this.diagnostikoa = diagnostikoa;
        this.tratamendua = tratamendua;
        this.oharra = oharra;
        this.sendatzeko_epea = sendatzeko_epea;
    }

    public KontrolMedikoa() 
    { 
    
    }

    public int getId()
    {
        return id; 
    }

    public Animalia getAnimalia()
    {
        return animalia; 
    }

    public Langilea getLangilea()
    {
        return langilea;
    }

    public DateTime getData()
    {
        return data;
    }

    public string getDiagnostikoa()
    {
        return diagnostikoa;
    }

    public string getTratamendua()
    {
        return tratamendua;
    }

    public string getOharra()
    {
        return oharra;
    }

    public DateTime getSendatzekoEpea()
    {
        return sendatzeko_epea;
    }

    public List<KontrolMedikoa> GetKontrolMedikoak()
    {
        List<KontrolMedikoa> kontrolMedikoZerrenda = new List<KontrolMedikoa>();

        try
        {
            MySqlConnection con = Konexioa.konexioa();

            string sql = "SELECT * FROM kontrol_medikoak";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            con.Open();

            MySqlDataReader rs = cmd.ExecuteReader();

            while (rs.Read())
            {
                Langilea l = new Langilea(rs.GetInt32("id_langilea"));
                Animalia an = new Animalia(rs.GetInt32("id_animalia"));

                KontrolMedikoa he = new KontrolMedikoa(
                    rs.GetInt32("id"),
                    an,
                    l,
                    rs.GetDateTime("data"),
                    rs.GetString("diagnostikoa"),
                    rs.GetString("tratamendua"),
                    rs.GetString("oharra"),
                    rs.GetDateTime("sendatzeko_epea")
                );

                kontrolMedikoZerrenda.Add(he);
            }

            rs.Close();
            con.Close();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }

        return kontrolMedikoZerrenda;
    }

}
