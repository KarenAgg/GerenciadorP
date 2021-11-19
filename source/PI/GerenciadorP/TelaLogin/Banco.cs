using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelaLogin
{
    //Aqui abre e fecha a conexão com o Banco
    public class Banco
    {
        //responsável pela conexão com banco de dados
        public static SqlConnection conexao;

        //envia sql para o banco
        public SqlCommand comando;

        //tabela no formato postgres
        public SqlDataReader dreader;

        //tabela no formato c#
        public DataTable tabela;

        public Banco()
        {
            try
            {
                if ((conexao == null) || (conexao.State != ConnectionState.Open))
                {
                    conexao = new SqlConnection("Data Source=" + "DESKTOP-JTIQ6F4\\SQL_PI" + ";Initial Catalog = "+"Gerenciador_P"+"; User ID = "+"sa"+"; Password = "+"projeto"+"");
                    conexao.Open();
                }
                comando = new SqlCommand();
                comando.Connection = conexao;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro de conexão: " + ex.Message);
            }
        }
    }
}
