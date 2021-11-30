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
    public partial class frmCadFuncionario : Form
    {
        public frmCadFuncionario()
        {
            InitializeComponent();
        }

        private void tB_USUARIOBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {

            try
            {
                this.Validate();
                this.tB_USUARIOBindingSource.EndEdit();
                tB_USUARIOTableAdapter.Update(projectManager_dbDataSet.TB_USUARIO);
                groupBox1.Enabled = false;
                MessageBox.Show("Registro Salvo");
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro, verifique os valores informados");
               
            }

            

        }

        private void frmCadFuncionario_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'projectManager_dbDataSet.TB_USUARIO'. Você pode movê-la ou removê-la conforme necessário.
            this.tB_USUARIOTableAdapter.Fill(this.projectManager_dbDataSet.TB_USUARIO);

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            tB_USUARIOBindingSource.AddNew();
            groupBox1.Enabled = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            tB_USUARIOBindingSource.CancelEdit();
            groupBox1.Enabled = false;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Confirme exclusão do registro", "TaskManager", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    tB_USUARIOBindingSource.RemoveCurrent();
                    tB_USUARIOTableAdapter.Update(projectManager_dbDataSet.TB_USUARIO);
                }
            }
            catch (Exception)
            {
                tB_USUARIOTableAdapter.Fill(projectManager_dbDataSet.TB_USUARIO);
                MessageBox.Show("Registro não pode ser excluido");
            }
            
           
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            VariaveisGlobais.CodigoTroca = 0;
            frmLocalizarFuncionario loca = new frmLocalizarFuncionario();
            loca.ShowDialog();
            if (VariaveisGlobais.CodigoTroca >0)
            {
                tB_USUARIOBindingSource.Position = tB_USUARIOBindingSource.Find("ID_USUARIO", VariaveisGlobais.CodigoTroca);
            }
        }
    }
}
