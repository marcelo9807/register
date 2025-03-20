using MySql.Data.MySqlClient;

namespace register.DataBaseRegister;

public class DbRegister
{
    string MyConnection = "server=localhost;user=root;database=register;password=98071011M@r;";
    MySqlConnection Conn;

    public void OpenConn()
    {
        Conn = new MySqlConnection(MyConnection);
        try
        {

            Conn.Open();
            Console.WriteLine("Connection made successfully");
        }
        catch (Exception error)
        {
            Console.WriteLine($"Failed{error.Message}");
        } 
    }
    public void CloseConn()
    {
        try
        {
            Conn.Close();
            Console.WriteLine("Connection is closed successfull");
        }
        catch (Exception error)
        {
            Console.WriteLine(error.Message);
        }
    }
}
