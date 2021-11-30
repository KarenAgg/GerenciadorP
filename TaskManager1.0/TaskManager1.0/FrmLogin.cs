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
    public partial class FrmLogin : Form
    {
        public bool logado = false;
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void tB_USUARIOBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tB_USUARIOBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.projectManager_dbDataSet);

        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'projectManager_dbDataSet.TB_USUARIO'. Você pode movê-la ou removê-la conforme necessário.
            this.tB_USUARIOTableAdapter.Fill(this.projectManager_dbDataSet.TB_USUARIO);

        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            this.logado = true;
            this.Dispose();
        }

        private void btnCancelarLog_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
