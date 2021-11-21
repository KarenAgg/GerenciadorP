using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelaLogin
{
    public class Projeto
    {
        public int codProjeto { get; private set; }
        public string titulo_Proj { get; private set; }
        public string descricao { get; private set; }
        public DateTime prazo { get; private set; }

        public void setCodProjeto(int c)
        {
            this.codProjeto = c;
        }
        public void setCodProjeto(string c)
        {
            try
            {
                this.codProjeto = int.Parse(c);
            }
            catch (Exception ex)
            {

                throw new Exception("Código do Projeto inválido: "+ex.Message);
            }
        }

        public void setTitulo_Proj(string tp)
        {
            this.titulo_Proj = tp;
        }

        public void setDescricao(string d)
        {
            this.descricao = d;
        }

        public void setPrazo(DateTime p)
        {
            this.prazo = p;
        }

        public void setPrazo(string p)
        {
            try
            {
                this.prazo = DateTime.Parse(p);
            }
            catch (Exception ex)
            {

                throw new Exception("Prazo inválido: " + ex.Message);
            }
        }
    }
}
