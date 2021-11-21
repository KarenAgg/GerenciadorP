using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelaLogin
{
    public class EquipeDAO
    {
        public int gravar(Equipe obj)
        {
            Banco bb;
            int qtde;
            try
            {
                bb = new Banco();
                bb.comando.CommandText = "Insert into TB_EQUIPES(COD_EQUIPE,FUNCIONARIO,N_EQUIPE) values (@c,@f,@n)"; //atribui o sql ao comando text
                bb.comando.Parameters.Add("@c", SqlDbType.Int, 0).Value = obj.codRegistro;
                bb.comando.Parameters.Add("@f", SqlDbType.NVarChar, 40).Value = obj.funcionario;
                bb.comando.Parameters.Add("@n", SqlDbType.Int, 0).Value = obj.numEquipe;
                bb.comando.Prepare(); //junta os campos com o sql
                qtde = bb.comando.ExecuteNonQuery(); //executa insert, update e delete
                Banco.conexao.Close();
                return (qtde);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao gravar: " + ex.Message);
            }
        }

        public int gravarGetCodigo(Equipe obj)
        {
            Banco bb;
            int codigo;
            try
            {
                bb = new Banco();
                bb.comando.CommandText = "Insert into TB_EQUIPES(TITULO_PROJ,DESCRICAO,PRAZO) values (@t,@d,@p)"; //atribui o sql ao comando text
                bb.comando.Parameters.Add("@c", SqlDbType.Int, 0).Value = obj.codRegistro;
                bb.comando.Parameters.Add("@f", SqlDbType.NVarChar, 40).Value = obj.funcionario;
                bb.comando.Parameters.Add("@n", SqlDbType.Int, 0).Value = obj.numEquipe;
                bb.comando.Prepare(); //junta os campos com o sql
                                      //qtde = bb.comando.ExecuteNonQuery(); //executa insert, update e delete
                codigo = (int)bb.comando.ExecuteScalar();
                obj.setCodRegistro(codigo);
                Banco.conexao.Close();
                return (codigo);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao gravar: " + ex.Message);
            }
        }

        public int alterar(Equipe obj)
        {
            Banco bb;
            int qtde;
            try
            {
                bb = new Banco();

                bb.comando.CommandText = "Update TB_EQUIPES set FUNCIONARIO=@f, N_EQUIPE=@n where codigo=@c"; //atribui o sql ao comando text
                bb.comando.Parameters.Add("@c", SqlDbType.Int, 0).Value = obj.codRegistro;
                bb.comando.Parameters.Add("@f", SqlDbType.NVarChar, 40).Value = obj.funcionario;
                bb.comando.Parameters.Add("@n", SqlDbType.Int, 0).Value = obj.numEquipe;
                bb.comando.Prepare(); //junta os campos com o sql
                qtde = bb.comando.ExecuteNonQuery(); //executa insert, update e delete
                Banco.conexao.Close();
                return (qtde);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao alterar: " + ex.Message);
            }
        }

        public int remover(Equipe obj)
        {
            Banco bb;
            int qtde;
            try
            {
                bb = new Banco();
                bb.comando.CommandText = "Delete from TB_EQUIPES where codigo=@c"; //atribui o sql ao comando text
                bb.comando.Parameters.Add("@c", SqlDbType.Int, 0).Value = obj.codRegistro;
                bb.comando.Prepare(); //junta os campos com o sql
                qtde = bb.comando.ExecuteNonQuery(); //executa insert, update e delete
                Banco.conexao.Close();
                return (qtde);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao remover: " + ex.Message);
            }
        }

        public DataTable listar()
        {
            Banco bb;
            try
            {
                bb = new Banco();
                bb.comando.CommandText = "Select COD_EQUIPE, FUNCIONARIO, N_EQUIPE from TB_EQUIPES order by 1";
                bb.dreader = bb.comando.ExecuteReader(); //executa o sql e retorna uma tabela
                bb.tabela = new DataTable();
                bb.tabela.Load(bb.dreader); // carrega a tabela formato postgres
                Banco.conexao.Close();
                return (bb.tabela);

            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao listar: " + ex.Message);
            }
        }

        public DataTable listarPorNum_Equipe(int numEquipe)
        {
            Banco bb;
            try
            {
                bb = new Banco();
                bb.comando.CommandText = "Select COD_EQUIPE, FUNCIONARIO from TB_EQUIPES where N_EQUIPE = @n order by 1";
                bb.comando.Parameters.Add("@n", SqlDbType.Int, 0).Value = numEquipe;
                bb.dreader = bb.comando.ExecuteReader(); //executa o sql e retorna uma tabela
                bb.tabela = new DataTable();
                bb.tabela.Load(bb.dreader); // carrega a tabela formato postgres
                Banco.conexao.Close();
                return (bb.tabela);

            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao listar: " + ex.Message);
            }
        }
    }
}
