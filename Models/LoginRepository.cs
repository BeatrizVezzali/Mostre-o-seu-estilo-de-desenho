using MySqlConnector;
namespace PI_MVC.Models
{
    public class LoginRepository
    {
        private const string DadosConexao = "DataBase = mostreoseuestilodedesenho; Data Source = localhost; user id = root;";

         public Login validarLogin(Login L)
        {
            MySqlConnection Conexao = new MySqlConnection(DadosConexao);

            Conexao.Open();

            string Query = "SELECT * FROM login WHERE  Nome = @Nome AND Senha = @Senha";

            MySqlCommand Comando = new MySqlCommand(Query,Conexao);


            Comando.Parameters.AddWithValue("@Nome", L.Nome);

            Comando.Parameters.AddWithValue("@Senha", L.Senha);

            MySqlDataReader Reader = Comando.ExecuteReader();

            Login l = new Login();

            while (Reader.Read())
               {  
                l.iDUsuario = Reader.GetInt32("iDUsuário");

                if (!Reader.IsDBNull(Reader.GetOrdinal("Nome")))
                {
                    l.Nome = Reader.GetString("Nome");
                }

                if (!Reader.IsDBNull(Reader.GetOrdinal("Senha")))
                {
                   l.Senha = Reader.GetString("Senha");
                }                                                   
            }

            Conexao.Close();
           
           return L;
        }
    
    }
}
            
    
