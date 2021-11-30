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
    public partial class frmCadTarefa : Form
    {
        public frmCadTarefa()
        {
            InitializeComponent();
        }

        private void tB_TAREFABindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.tB_TAREFABindingSource.EndEdit();
                tB_TAREFATableAdapter.Update(projectManager_dbDataSet.TB_TAREFA);
                groupBox2.Enabled = false;
                MessageBox.Show("Registro Salvo");
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro, verifique os valores informados");

            }

        }

        private void frmCadTarefa_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'projectManager_dbDataSet.TB_TAREFA'. Você pode movê-la ou removê-la conforme necessário.
            this.tB_TAREFATableAdapter.Fill(this.projectManager_dbDataSet.TB_TAREFA);

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            tB_TAREFABindingSource.AddNew();
            groupBox2.Enabled = true;
        }

        private void btnCancelarT_Click(object sender, EventArgs e)
        {
            tB_TAREFABindingSource.CancelEdit();
            groupBox2.Enabled = false;
        }

        private void btnEditarT_Click(object sender, EventArgs e)
        {
            groupBox2.Enabled = true;
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Confirme exclusão do registro", "TaskManager", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    tB_TAREFABindingSource.RemoveCurrent();
                    tB_TAREFATableAdapter.Update(projectManager_dbDataSet.TB_TAREFA);
                }
            }
            catch (Exception)
            {
                tB_TAREFATableAdapter.Fill(projectManager_dbDataSet.TB_TAREFA);
                MessageBox.Show("Registro não pode ser excluido");
            }
        }
    }
}
