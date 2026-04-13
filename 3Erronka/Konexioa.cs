using MySql.Data.MySqlClient;

public class Konexioa
{
    static void Main()
    {
        string conexion = "server=localhost;database=zoologikoa;user=root;password=1MG32025;";

        MySqlConnection conn = new MySqlConnection(conexion);

        try
        {
            conn.Open();
            Console.WriteLine("Conectado a la base de datos");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
        finally
        {
            conn.Close();
        }
    }
}