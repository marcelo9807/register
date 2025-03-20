using System.Net.Mail;
using System.Xml;
using MySql.Data.MySqlClient;
using register.DataBaseRegister;

namespace register.CRUD;




public class CRUD
{
    string MyConnection = "server=localhost;user=root;database=register;password=98071011M@r;";

    public void insert(string nome, long telefone, string email, string Cep, string senha)
    {
        MySqlConnection conn = new MySqlConnection(MyConnection);
        try
        {
            conn.Open();

            string query = "INSERT INTO Register(nome,telefone,email,cep,senha) VALUES (@nome,@telefone," +
                "@email,@cep,@senha)";
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@nome", nome);
                cmd.Parameters.AddWithValue("@telefone", telefone);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@cep", Cep);
                cmd.Parameters.AddWithValue("@senha", senha);
                cmd.ExecuteNonQuery();
                Console.WriteLine("Add successfull");



            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error{ex.Message}");
        }
        finally
        {
            conn.Close();
            Console.WriteLine("Conn closed");
        }
    }
    public void Select()
    {
        MySqlConnection conn = new MySqlConnection(MyConnection);
        try
        {
            conn.Open();
            string query = "SELECT * FROM register;";

            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine($"ID:{reader["ID"]},Nome : {reader["Nome"]}, Telefone {reader["telefone"]}," +
                    $" email {reader["email"]}, cep {reader["cep"]}, senha: {reader["senha"]}");
            }
        }
        finally { conn.Close(); }
    }
    public void update(int id, string nome)
    {
        MySqlConnection conn = new MySqlConnection(MyConnection);
        try
        {
            conn.Open();
            string query = "UPDATE register SET Nome = @nome WHERE id = @id; ";
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@Nome", nome);
                cmd.ExecuteNonQuery();
            }
        }
        finally { conn.Close(); }
    }
    public void Delete(int id)
    {
        MySqlConnection conn = new MySqlConnection(MyConnection);
        try
        {
            conn.Open();
            string query = "Delete From register where id = @ID;";

            using(MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@ID", id);
                cmd.ExecuteNonQuery();
                Console.WriteLine("Delete is successfull");
            }
        }
        finally { conn.Close(); }

    }

}
