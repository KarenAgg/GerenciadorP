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
    public partial class frmCadProjeto : Form
    {
        public frmCadProjeto()
        {
            InitializeComponent();
        }

        private void tB_PROJETOBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.tB_PROJETOBindingSource.EndEdit();
                tB_PROJETOTableAdapter.Update(projectManager_dbDataSet.TB_PROJETO);
                groupBox3.Enabled = false;
                MessageBox.Show("Registro Salvo");
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro, verifique os valores informados");

            }
        }

        private void frmCadProjeto_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'projectManager_dbDataSet.TB_TAREFA'. Você pode movê-la ou removê-la conforme necessário.
            this.tB_TAREFATableAdapter.Fill(this.projectManager_dbDataSet.TB_TAREFA);
            // TODO: esta linha de código carrega dados na tabela 'projectManager_dbDataSet.View_ProjetoTarefa2'. Você pode movê-la ou removê-la conforme necessário.
            this.view_ProjetoTarefa2TableAdapter.Fill(this.projectManager_dbDataSet.View_ProjetoTarefa2);
            // TODO: esta linha de código carrega dados na tabela 'projectManager_dbDataSet.PROJETO_TAREFA'. Você pode movê-la ou removê-la conforme necessário.
            this.pROJETO_TAREFATableAdapter.Fill(this.projectManager_dbDataSet.PROJETO_TAREFA);
            // TODO: esta linha de código carrega dados na tabela 'projectManager_dbDataSet.TB_USUARIO'. Você pode movê-la ou removê-la conforme necessário.
            this.tB_USUARIOTableAdapter.Fill(this.projectManager_dbDataSet.TB_USUARIO);
            // TODO: esta linha de código carrega dados na tabela 'projectManager_dbDataSet.TB_PROJETO'. Você pode movê-la ou removê-la conforme necessário.
            this.tB_PROJETOTableAdapter.Fill(this.projectManager_dbDataSet.TB_PROJETO);

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            tB_PROJETOBindingSource.AddNew();
            sITUACAOComboBox.Text = "Em Andamento";
            pRAZOMaskedTextBox.Text = DateTime.Now.ToShortDateString();
            hORARIOMaskedTextBox.Text = DateTime.Now.ToShortTimeString();
            groupBox3.Enabled = true;
        }

        private void btnCancelarP_Click(object sender, EventArgs e)
        {
            tB_PROJETOBindingSource.CancelEdit();
            groupBox3.Enabled = false;
        }

        private void btnEditarP_Click(object sender, EventArgs e)
        {
            groupBox3.Enabled = true;
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Confirme exclusão do registro", "TaskManager", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    tB_PROJETOBindingSource.RemoveCurrent();
                    tB_PROJETOTableAdapter.Update(projectManager_dbDataSet.TB_PROJETO);
                }
            }
            catch (Exception)
            {
                tB_PROJETOTableAdapter.Fill(projectManager_dbDataSet.TB_PROJETO);
                MessageBox.Show("Registro não pode ser excluido");
            }
        }

        private void txtCodTaref_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtCodTaref.Text != "")
            {
                tBTAREFABindingSource.Filter = "ID_TAREFA = " + txtCodTaref.Text;
                if (tBTAREFABindingSource.Count ==1)
                {
                    DataRowView TarefaEncontrada = (DataRowView)tBTAREFABindingSource.Current;
                    txtTarefa.Text = TarefaEncontrada["NOME_TAREFA"].ToString();
                }
                else
                {
                    frmCadTarefa serv = new frmCadTarefa();
                    serv.ShowDialog();
                }
            }
        }

        private void btnAddTaref_Click(object sender, EventArgs e)
        {
            try
            {
                pROJETO_TAREFATableAdapter.InserirTarefa(int.Parse(iD_PROJETOTextBox.Text), int.Parse(txtCodTaref.Text));
                txtCodTaref.Clear();
                txtTarefa.Clear();
                Atualiza_Grid();
            }
            catch (Exception)
            {

                MessageBox.Show("Tente novamente");
            }
        }

        private void Atualiza_Grid()
        {
            try
            {
                if (iD_PROJETOTextBox.Text !="")
                {
                    view_ProjetoTarefa2TableAdapter.Fill(projectManager_dbDataSet.View_ProjetoTarefa2);
                    view_ProjetoTarefa2BindingSource.Filter = "ID_PROJETO2 =" + iD_PROJETOTextBox.Text;
                }
            }
            catch (Exception)
            {

                
            }
        }

        private void iD_PROJETOTextBox_TextChanged(object sender, EventArgs e)
        {
            Atualiza_Grid();
        }

        private void view_ProjetoTarefa2DataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int codigo = 0;
                codigo = int.Parse(view_ProjetoTarefa2DataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
                pROJETO_TAREFATableAdapter.RemoverTarefa(codigo);
            }
            catch (Exception)
            {

                
            }

            Atualiza_Grid();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Após CONCLUIDO, o projeto não poderá ser alterado","TaskManager",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes )
            {
                sITUACAOComboBox.Text = "Concluido";
                tB_PROJETOTableAdapter.Update(projectManager_dbDataSet.TB_PROJETO);
                MessageBox.Show("Projeto Finalizado com sucesso", "TaskManager", MessageBoxButtons.OK, MessageBoxIcon.Information);
             
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }
    }
}
