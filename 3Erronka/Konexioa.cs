using MySql.Data.MySqlClient;

public class Konexioa
{
    public static MySqlConnection konexioa()
    {
        string conexion = "server=localhost;database=zoologikoa;user=root;password=1MG32025;";
        return new MySqlConnection(conexion);
    }
}