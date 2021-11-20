using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelaLogin
{
    public class UsuarioDAO
    {
        public int gravar(Usuario obj)
        {
            Banco bb;
            int qtde;
            try
            {
                bb = new Banco();
                bb.comando.CommandText = "Insert into TB_USUARIO(NOME,EMAIL,SENHA,TELEFONE,FUNC,PERMISSAO) values (@n,@e,@s,@t,@f,@p)"; //atribui o sql ao comando text
                bb.comando.Parameters.Add("@n", SqlDbType.NVarChar, 40).Value = obj.nome;
                bb.comando.Parameters.Add("@e", SqlDbType.NVarChar, 40).Value = obj.email;
                bb.comando.Parameters.Add("@s", SqlDbType.NVarChar, 40).Value = obj.senha;
                bb.comando.Parameters.Add("@t", SqlDbType.NVarChar, 20).Value = obj.telefone;
                bb.comando.Parameters.Add("@f", SqlDbType.Int, 10).Value = obj.cargo;
                bb.comando.Parameters.Add("@p", SqlDbType.Int, 10).Value = obj.permissao;
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
        public Usuario buscarLoginUsuario(string email, string senha)
        {
            Banco bb;
            Usuario obj = null;
            try
            {
                bb = new Banco();
                bb.comando.CommandText = "Select nome from TB_USUARIO where email like @e and senha like @s";
                bb.comando.Parameters.Add("@e", SqlDbType.VarChar, 40).Value = "%" + email.Trim() + "%";
                bb.comando.Parameters.Add("@s", SqlDbType.VarChar, 20).Value = senha.Trim();
                bb.comando.Prepare();
                bb.dreader = bb.comando.ExecuteReader();

                if (bb.dreader.Read())
                {
                    obj = new Usuario();
                    obj.setNome(bb.dreader[0].ToString());
                }
                Banco.conexao.Close();
                return (obj);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro na busca por parte do nome: " + ex.Message);
            }
        }

        /*
        public int gravarGetCodigo(Usuario obj)
        {
            Banco bb;
            int codigo;
            try
            {
                bb = new Banco();
                bb.comando.CommandText = "Insert into Usuario(nome,idade) values (@n,@i) returning codigo"; //atribui o sql ao comando text
                bb.comando.Parameters.Add("@n", SqlDbType.VarChar).Value = obj.nome;
                bb.comando.Parameters.Add("@i", SqlDbType.Int).Value = obj.idade;
                bb.comando.Prepare(); //junta os campos com o sql
                                      //qtde = bb.comando.ExecuteNonQuery(); //executa insert, update e delete
                codigo = (int)bb.comando.ExecuteScalar();
                obj.setCodigo(codigo);
                Banco.conexao.Close();
                return (codigo);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao gravar: " + ex.Message);
            }
        }

        public int alterar(Usuario obj)
        {
            Banco bb;
            int qtde;
            try
            {
                bb = new Banco();
                bb.comando.CommandText = "Update Usuario set nome=@n, idade=@i where codigo=@c"; //atribui o sql ao comando text
                bb.comando.Parameters.Add("@n", SqlDbType.VarChar).Value = obj.nome;
                bb.comando.Parameters.Add("@i", SqlDbType.Int).Value = obj.idade;
                bb.comando.Parameters.Add("@c", SqlDbType.Int).Value = obj.codigo;
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

        public int remover(Usuario obj)
        {
            Banco bb;
            int qtde;
            try
            {
                bb = new Banco();
                bb.comando.CommandText = "Delete from Usuario where codigo=@c"; //atribui o sql ao comando text
                bb.comando.Parameters.Add("@c", SqlDbType.Int).Value = obj.codigo;
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
                bb.comando.CommandText = "Select codigo,nome,idade from Usuario order by 1";
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
        //devolve o objeto com dados, quando encontrado no banco. ou null quando não encontrado no banco
        public Usuario preencher(int cod)
        {
            Banco bb;
            Usuario obj = null;
            try
            {
                bb = new Banco();
                bb.comando.CommandText = "Select codigo,nome,idade " + "from Usuario where codigo = @c";
                bb.comando.Parameters.Add("@c", SqlDbType.Int).Value = cod;
                bb.comando.Prepare();
                bb.dreader = bb.comando.ExecuteReader();
                if (bb.dreader.Read()) //verifica a existência do próximo registro
                {
                    obj = new Usuario();
                    obj.setCodigo((int)bb.dreader[0]);
                    obj.setNome(bb.dreader[1].ToString());
                    obj.setIdade((int)bb.dreader[2]);
                }
                Banco.conexao.Close();
                return (obj);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao preencher: " + ex.Message);
            }
        }

        */
    }
}
