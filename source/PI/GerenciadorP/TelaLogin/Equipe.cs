using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelaLogin
{
    public class Equipe
    {
        public int codRegistro { get; private set; }
        public string funcionario { get; private set; }
        public int numEquipe { get; private set; }

        public void setCodRegistro(int cr)
        {
            this.codRegistro = cr;
        }

        public void setCodRegistro(string cr)
        {
            try
            {
                this.codRegistro = int.Parse(cr);
            }
            catch (Exception ex)
            {

                throw new Exception("Código de Registro inválido: " + ex.Message);
            }
        }

        public void setFuncionario(string f)
        {
            this.funcionario = f;
        }

        public void setNumRegistro(int nr)
        {
            this.numEquipe = nr;
        }

        public void setNumRegistro(string nr)
        {
            try
            {
                this.numEquipe = int.Parse(nr);
            }
            catch (Exception ex)
            {

                throw new Exception("Número da Equipe inválido: " + ex.Message);
            }
        }

    }
}
