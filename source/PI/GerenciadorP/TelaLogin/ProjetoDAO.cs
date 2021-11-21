using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelaLogin
{
    public class ProjetoDAO
    {
        public int gravar(Projeto obj)
        {
            Banco bb;
            int qtde;
            try
            {
                bb = new Banco();
                bb.comando.CommandText = "Insert into TB_PROJETOS(TITULO_PROJ,DESCRICAO,PRAZO) values (@t,@d,@p)"; //atribui o sql ao comando text
                bb.comando.Parameters.Add("@n", SqlDbType.NVarChar, 40).Value = obj.titulo_Proj;
                bb.comando.Parameters.Add("@e", SqlDbType.NVarChar, 40).Value = obj.descricao;
                bb.comando.Parameters.Add("@s", SqlDbType.DateTime, 0).Value = obj.prazo;
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

        public int gravarGetCodigo(Projeto obj)
        {
            Banco bb;
            int codigo;
            try
            {
                bb = new Banco();
                bb.comando.CommandText = "Insert into TB_PROJETOS(TITULO_PROJ,DESCRICAO,PRAZO) values (@t,@d,@p)"; //atribui o sql ao comando text
                bb.comando.Parameters.Add("@n", SqlDbType.NVarChar, 40).Value = obj.titulo_Proj;
                bb.comando.Parameters.Add("@e", SqlDbType.NVarChar, 40).Value = obj.descricao;
                bb.comando.Parameters.Add("@s", SqlDbType.DateTime, 0).Value = obj.prazo;
                bb.comando.Prepare(); //junta os campos com o sql
                                      //qtde = bb.comando.ExecuteNonQuery(); //executa insert, update e delete
                codigo = (int)bb.comando.ExecuteScalar();
                obj.setCodProjeto(codigo);
                Banco.conexao.Close();
                return (codigo);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao gravar: " + ex.Message);
            }
        }

        public int alterar(Projeto obj)
        {
            Banco bb;
            int qtde;
            try
            {
                bb = new Banco();
                
                bb.comando.CommandText = "Update TB_PROJETOS set TITULO_PROJ=@n, DESCRICAO=@i, PRAZO=@P where codigo=@c"; //atribui o sql ao comando text
                bb.comando.Parameters.Add("@c", SqlDbType.Int, 0).Value = obj.codProjeto;
                bb.comando.Parameters.Add("@t", SqlDbType.NVarChar, 40).Value = obj.titulo_Proj;
                bb.comando.Parameters.Add("@d", SqlDbType.NVarChar, 40).Value = obj.descricao;
                bb.comando.Parameters.Add("@p", SqlDbType.DateTime, 0).Value = obj.prazo;
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

        public int remover(Projeto obj)
        {
            Banco bb;
            int qtde;
            try
            {
                bb = new Banco();
                bb.comando.CommandText = "Delete from TB_PROJETOS where codigo=@c"; //atribui o sql ao comando text
                bb.comando.Parameters.Add("@c", SqlDbType.Int).Value = obj.codProjeto;
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
                bb.comando.CommandText = "Select COD_PROJETO, TITULO_PROJ, DESCRICAO, PRAZO from TB_PROJETOs order by 1";
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
