using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelaLogin
{
    public class Usuario
    {
        public string nome { get; private set; }
        public string email { get; private set; }
        public string senha { get; private set; }
        public string telefone { get; private set; }
        public int cargo { get; private set; }
        public int permissao { get; private set; }

        public void setNome(string n)
        {
            this.nome = n;
        }

        public void setEmail(string email)
        {
            this.email = email;
        }

        public void setSenha(string senha)
        {
            this.senha = senha;
        }

        public void setTelefone(string t)
        {
            this.telefone = t;
        }

        public void setCargo(int c)
        {
            this.cargo = c;
        }

        public void setCargo(string c)
        {
            try
            {
                this.cargo = Convert.ToInt32(c);
            }
            catch (Exception ex)
            {
                throw new Exception("Cargo inválida:" + ex.Message);
            }
        }

        public void setPermissao(int p)
        {
            this.permissao = p;
        }

        public void setPermissao(string p)
        {
            try
            {
                this.permissao = Convert.ToInt32(p);
            }
            catch (Exception ex)
            {
                throw new Exception("Permissão inválida:" + ex.Message);
            }
        }
    }
}
