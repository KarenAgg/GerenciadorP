using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelaLogin
{
    public class Cargo
    {
        public int codCargo { get; private set; }
        public string cargo { get; private set; }

        public void setCodCargo(int cc)
        {
            this.codCargo = cc;
        }

        public void setCodCargo(string cc)
        {
            try
            {
                this.codCargo = int.Parse(cc);
            }
            catch (Exception ex)
            {

                throw new Exception("Código do Cargo Inválido: " + ex.Message);
            }
        }

        public void setCargo(string c)
        {
            this.cargo = c;
        }
    }
}
