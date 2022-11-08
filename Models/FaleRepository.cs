using MySqlConnector;
namespace PI_MVC.Models
{
    public class FaleRepository
    {
       private const string DadosConexao = "DataBase = mostreoseuestilodedesenho; Data Source = localhost; user id = root;";

       public void Inserir(Fale F)
        { 
            MySqlConnection Conexao = new MySqlConnection(DadosConexao);

            Conexao.Open();

            string Query = "INSERT INTO fale_conosco (Nome,Email,Mensagem) VALUES (@Nome , @Email , @Mensagem)";

            MySqlCommand Comando = new MySqlCommand(Query,Conexao);

            Comando.Parameters.AddWithValue("@Nome" , F.Nome);

            Comando.Parameters.AddWithValue("@Email" , F.Email);

            Comando.Parameters.AddWithValue("@Mensagem" , F.Mensagem);

            Comando.ExecuteNonQuery();

            Conexao.Close();
        }
         
    }
}