using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelaLogin
{
    public class CargoDAO
    {
        public Cargo listaCargo(string c)
        {
            Cargo obj = null;
            Banco bb;
            try
            {
                bb = new Banco();
                bb.comando.CommandText = "Select COD_CARGO,CARGO from TB_FUNC where CARGO = @c";
                bb.comando.Parameters.Add("@c", SqlDbType.VarChar, 20).Value = c;
                bb.dreader = bb.comando.ExecuteReader(); //executa o sql e retorna uma tabela
                if (bb.dreader.Read())
                {
                    obj = new Cargo();
                    obj.setCodCargo(bb.dreader[0].ToString());
                    obj.setCargo(bb.dreader[1].ToString());
                }
                Banco.conexao.Close();
                return (obj);

            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao listar Cargos correspondente: " + ex.Message);
            }
        }
    }
}
