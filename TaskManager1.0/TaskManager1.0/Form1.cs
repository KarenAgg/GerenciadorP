using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskManager1._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
           if (MessageBox.Show("Deseja mesmo sair?","TaskManager",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            { 
                Application.Exit();
            }
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnFuncionario_Click(object sender, EventArgs e)
        {
            frmCadFuncionario funcionario = new frmCadFuncionario();
            funcionario.TopLevel = false;
            funcionario.Dock = DockStyle.Fill;
            PanelCentral.Controls.Clear();
            PanelCentral.Controls.Add(funcionario);
            funcionario.Show();

            PanelSelecao.Top = btnFuncionario.Top;
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            PanelCentral.Controls.Clear();

            PanelSelecao.Top = btnInicio.Top;
        }

        private void btnTarefa_Click(object sender, EventArgs e)
        {
            frmCadTarefa tarefa = new frmCadTarefa();
            tarefa.TopLevel = false;
            tarefa.Dock = DockStyle.Fill;
            PanelCentral.Controls.Clear();
            PanelCentral.Controls.Add(tarefa);
            tarefa.Show();

            PanelSelecao.Top = btnTarefa.Top;
        }

        private void btnProjeto_Click(object sender, EventArgs e)
        {
            frmCadProjeto projeto = new frmCadProjeto();
            projeto.TopLevel = false;
            projeto.Dock = DockStyle.Fill;
            PanelCentral.Controls.Clear();
            PanelCentral.Controls.Add(projeto);
            projeto.Show();

            PanelSelecao.Top = btnProjeto.Top;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'projectManager_dbDataSet.View_DetalhesProjeto'. Você pode movê-la ou removê-la conforme necessário.
           // this.view_DetalhesProjetoTableAdapter.Fill(this.projectManager_dbDataSet.View_DetalhesProjeto);
            // TODO: esta linha de código carrega dados na tabela 'projectManager_dbDataSet.View_ProjetoTarefa'. Você pode movê-la ou removê-la conforme necessário.
            //this.view_ProjetoTarefaTableAdapter.Fill(this.projectManager_dbDataSet.View_ProjetoTarefa);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
