using _3Erronka;

public class Kontrola
{
    public static Langilea login()
    {
        Langilea l = new Langilea();
        List<Langilea> langileZerrenda = l.GetLangileak();

        foreach (Langilea ln in langileZerrenda)
        {
            if (ln.getPostaElektronikoa() == Form1.textBox1.Text && ln.getPasahitza() == Form1.textBox2.Text)
            {
                return ln;
            }
        }

        return null;
    }
}