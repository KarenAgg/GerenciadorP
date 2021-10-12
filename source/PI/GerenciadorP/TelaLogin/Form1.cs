using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelaLogin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


        }

        // painel login

        private void txtemail_Enter(object sender, EventArgs e) // O placeholder some quando clicamos no textbox, para que o usuário possa escrever 
        {
            if (txtemail.Text == "E-mail")
            {
                txtemail.Text = "";

            }
        }

        private void txtemail_Leave(object sender, EventArgs e) // O placeholder retorna quando clicamos fora do textbox 
        {
            if (txtemail.Text == "")
            {
                txtemail.Text = "E-mail";


            }
        }

        private void txtsenha_Enter(object sender, EventArgs e) // O placeholder some quando clicamos no textbox, para que o usuário possa escrever 
        {
            if (lbsenha.Text == "Senha")
            {
                lbsenha.Text = "";
               txtsenha.UseSystemPasswordChar = true;
            }
        }

        private void txtsenha_Leave(object sender, EventArgs e) // O placeholder retorna quando clicamos fora do textbox 
        {
            if (txtsenha.Text == "")
            {
                lbsenha.Text = "Senha";
            }
        }

        // painel cadastro

        private void txtnome_Enter(object sender, EventArgs e) // O placeholder some quando clicamos no textbox, para que o usuário possa escrever 
        {
            if (txtnome.Text == "Nome completo")
            {
                txtnome.Text = "";

            }
        }

        private void txtnome_Leave(object sender, EventArgs e) // O placeholder retorna quando clicamos fora do textbox 
        {
            if (txtnome.Text == "")
            {
                txtnome.Text = "Nome completo";


            }
        }

        private void txtemailcad_Enter(object sender, EventArgs e) // O placeholder some quando clicamos no textbox, para que o usuário possa escrever 
        {
            if (txtemailcad.Text == "E-mail")
            {
                txtemailcad.Text = "";

            }
        }

        private void txtemailcad_Leave(object sender, EventArgs e) // O placeholder retorna quando clicamos fora do textbox 
        {
            if (txtemailcad.Text == "")
            {
                txtemailcad.Text = "E-mail";

            }
        }

        private void txtcargo_Enter(object sender, EventArgs e) // O placeholder some quando clicamos no textbox, para que o usuário possa escrever 
        {
            if (txtcargo.Text == "Cargo")
            {
                txtcargo.Text = "";

            }
        }

        private void txtcargo_Leave(object sender, EventArgs e) // O placeholder retorna quando clicamos fora do textbox 
        {
            if (txtcargo.Text == "")
            {
                txtcargo.Text = "Cargo";
            }
        }

        private void txtrecup_Enter(object sender, EventArgs e) // O placeholder some quando clicamos no textbox, para que o usuário possa escrever 
        {
            if (txtrecup.Text == "Telefone para recuperação de senha")
            {
                txtrecup.Text = "";

            }
        }

        private void txtrecup_Leave(object sender, EventArgs e) // O placeholder retorna quando clicamos fora do textbox 
        {
            if (txtrecup.Text == "")
            {
                txtrecup.Text = "Telefone para recuperação de senha";
            }
        }


        private void txtsenhacad_Enter(object sender, EventArgs e) // O placeholder some quando clicamos no textbox, para que o usuário possa escrever 
        {
            if (lbsenhacad.Text == "Senha")
            {
                lbsenhacad.Text = "";


            }
        }

        private void txtsenhacad_Leave(object sender, EventArgs e) // O placeholder retorna quando clicamos fora do textbox 
        {
           if(txtsenhacad.Text == "")
            {
                lbsenhacad.Text = "Senha";
            }
        }

        // Visibilidade dos painéis

        private void btentrar_Click(object sender, EventArgs e) // Esconde o Painel de cadastro e mantém o e Login visível (botão entrar).
        {
            pcadastro.Visible = false;
            animacad.HideSync(pcadastro);
        }

        private void lblcadastro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) // Esconde o Painel de Login e mantém o de Cadastro visível (link cadastre-se).
        {
            pcadastro.Visible = true;
            animacad.HideSync(plogin);
        }

        private void lblentrar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) // Esconde o Painel de cadastro e mantém o e Login visível ( link entrar).
        {
            pcadastro.Visible = false;
            animacad.HideSync(pcadastro);
            plogin.Visible = true;

        }

        // Modo dark e light

        private void btswitch_CheckedChanged(object sender, EventArgs e) // Botão que ativa e desativa os modos dark e light (sim! eu só coloquei isso porque é legal :D)
        {
            if (btswitch.Checked == true) //quando o switch está selecionado entra em modo dark
            {
                p1.BackColor = Color.FromArgb(32, 29, 30);
                plogin.BackColor = Color.FromArgb(37, 34, 35);
                pcadastro.BackColor = Color.FromArgb(37, 34, 35);

                btentrar.BaseColor = Color.FromArgb(156, 119, 249);

                lblcadastro.LinkColor = Color.FromArgb(156, 119, 249);

                btcadastro.BaseColor = Color.FromArgb(156, 119, 249);

                lblentrar.LinkColor = Color.FromArgb(156, 119, 249);

                lblsenha.LinkColor = Color.FromArgb(156, 119, 249);

                txtemail.BackColor = Color.FromArgb(37, 34, 35);txtemail.ForeColor = Color.Silver; txtemail.LineColor = Color.Silver; txtemail.FocusedLineColor = Color.FromArgb(156, 119, 249);

                txtsenha.BackColor = Color.FromArgb(37, 34, 35);txtsenha.ForeColor = Color.Silver;txtsenha.LineColor = Color.Silver; txtsenha.FocusedLineColor = Color.FromArgb(156, 119, 249);

                txtnome.BackColor = Color.FromArgb(37, 34, 35); txtnome.ForeColor = Color.Silver; txtnome.LineColor = Color.Silver; txtnome.FocusedLineColor = Color.FromArgb(156, 119, 249);

                txtemailcad.BackColor = Color.FromArgb(37, 34, 35); txtemailcad.ForeColor = Color.Silver; txtemailcad.LineColor = Color.Silver; txtemailcad.FocusedLineColor = Color.FromArgb(156, 119, 249);

                txtcargo.BackColor = Color.FromArgb(37, 34, 35); txtcargo.ForeColor = Color.Silver; txtcargo.LineColor = Color.Silver; txtcargo.FocusedLineColor = Color.FromArgb(156, 119, 249);

                txtrecup.BackColor = Color.FromArgb(37, 34, 35); txtrecup.ForeColor = Color.Silver; txtrecup.LineColor = Color.Silver; txtrecup.FocusedLineColor = Color.FromArgb(156, 119, 249);

                txtsenhacad.BackColor = Color.FromArgb(37, 34, 35); txtsenhacad.ForeColor = Color.Silver; txtsenhacad.LineColor = Color.Silver; txtsenhacad.FocusedLineColor = Color.FromArgb(156, 119, 249);

            }
            else // quando o switch não está selecionado permanece em modo ligth
            { 
                p1.BackColor = Color.White;
                plogin.BackColor = Color.FromArgb(250, 250, 250);
                pcadastro.BackColor = Color.FromArgb(250, 250, 250);

                btentrar.BaseColor = Color.FromArgb(142, 85, 238);

                lblcadastro.LinkColor = Color.FromArgb(142, 85, 238);

                btcadastro.BaseColor = Color.FromArgb(142, 85, 238);

                lblentrar.LinkColor = Color.FromArgb(142, 85, 238);

                lblsenha.LinkColor = Color.FromArgb(142, 85, 238);

                txtemail.BackColor = Color.FromArgb(250, 250, 250); txtemail.ForeColor = Color.Gray; txtemail.LineColor = Color.DarkGray; txtemail.FocusedLineColor = Color.FromArgb(142, 85, 238);

                txtsenha.BackColor= Color.FromArgb(250, 250, 250); txtsenha.ForeColor = Color.Gray; txtsenha.LineColor = Color.DarkGray; txtsenha.FocusedLineColor = Color.FromArgb(142, 85, 238);

                txtnome.BackColor = Color.FromArgb(250, 250, 250); txtnome.ForeColor = Color.Gray; txtnome.LineColor = Color.DarkGray; txtnome.FocusedLineColor = Color.FromArgb(142, 85, 238);

                txtemailcad.BackColor = Color.FromArgb(250, 250, 250); txtemailcad.ForeColor = Color.Gray; txtemailcad.LineColor = Color.DarkGray; txtemailcad.FocusedLineColor = Color.FromArgb(142, 85, 238);

                txtcargo.BackColor = Color.FromArgb(250, 250, 250); txtcargo.ForeColor = Color.Gray; txtcargo.LineColor = Color.DarkGray; txtcargo.FocusedLineColor = Color.FromArgb(142, 85, 238);

                txtrecup.BackColor = Color.FromArgb(250, 250, 250); txtrecup.ForeColor = Color.Gray; txtrecup.LineColor = Color.DarkGray; txtrecup.FocusedLineColor = Color.FromArgb(142, 85, 238);

                txtsenhacad.BackColor = Color.FromArgb(250, 250, 250); txtsenhacad.ForeColor = Color.Gray; txtsenhacad.LineColor = Color.DarkGray; txtsenhacad.FocusedLineColor = Color.FromArgb(142, 85, 238);


            }
        }

        private void cbsenha_CheckedChanged(object sender, EventArgs e)
        {
            if(cbsenha.Checked == false)
            {
                txtsenha.UseSystemPasswordChar = true;
            }
            else
            {
                txtsenha.UseSystemPasswordChar = false;
            }
            
        }
    }
}

