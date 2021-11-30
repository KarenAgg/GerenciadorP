
namespace TaskManager1._0
{
    partial class FrmLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.uSERNAMELabel = new System.Windows.Forms.Label();
            this.sENHALabel = new System.Windows.Forms.Label();
            this.projectManager_dbDataSet = new TaskManager1._0.ProjectManager_dbDataSet();
            this.tB_USUARIOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tB_USUARIOTableAdapter = new TaskManager1._0.ProjectManager_dbDataSetTableAdapters.TB_USUARIOTableAdapter();
            this.tableAdapterManager = new TaskManager1._0.ProjectManager_dbDataSetTableAdapters.TableAdapterManager();
            this.txtUsuarioLog = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.btnLogar = new System.Windows.Forms.Button();
            this.btnCancelarLog = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.projectManager_dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tB_USUARIOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // uSERNAMELabel
            // 
            this.uSERNAMELabel.AutoSize = true;
            this.uSERNAMELabel.Location = new System.Drawing.Point(241, 147);
            this.uSERNAMELabel.Name = "uSERNAMELabel";
            this.uSERNAMELabel.Size = new System.Drawing.Size(56, 13);
            this.uSERNAMELabel.TabIndex = 1;
            this.uSERNAMELabel.Text = "USUÁRIO";
            // 
            // sENHALabel
            // 
            this.sENHALabel.AutoSize = true;
            this.sENHALabel.Location = new System.Drawing.Point(250, 175);
            this.sENHALabel.Name = "sENHALabel";
            this.sENHALabel.Size = new System.Drawing.Size(47, 13);
            this.sENHALabel.TabIndex = 3;
            this.sENHALabel.Text = "SENHA:";
            // 
            // projectManager_dbDataSet
            // 
            this.projectManager_dbDataSet.DataSetName = "ProjectManager_dbDataSet";
            this.projectManager_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tB_USUARIOBindingSource
            // 
            this.tB_USUARIOBindingSource.DataMember = "TB_USUARIO";
            this.tB_USUARIOBindingSource.DataSource = this.projectManager_dbDataSet;
            // 
            // tB_USUARIOTableAdapter
            // 
            this.tB_USUARIOTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.PROJETO_TAREFATableAdapter = null;
            this.tableAdapterManager.TB_PROJETOTableAdapter = null;
            this.tableAdapterManager.TB_TAREFATableAdapter = null;
            this.tableAdapterManager.TB_USUARIOTableAdapter = this.tB_USUARIOTableAdapter;
            this.tableAdapterManager.UpdateOrder = TaskManager1._0.ProjectManager_dbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // txtUsuarioLog
            // 
            this.txtUsuarioLog.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tB_USUARIOBindingSource, "USERNAME", true));
            this.txtUsuarioLog.Location = new System.Drawing.Point(303, 144);
            this.txtUsuarioLog.Name = "txtUsuarioLog";
            this.txtUsuarioLog.Size = new System.Drawing.Size(189, 20);
            this.txtUsuarioLog.TabIndex = 2;
            // 
            // txtSenha
            // 
            this.txtSenha.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tB_USUARIOBindingSource, "SENHA", true));
            this.txtSenha.Location = new System.Drawing.Point(303, 172);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(189, 20);
            this.txtSenha.TabIndex = 4;
            // 
            // btnLogar
            // 
            this.btnLogar.Location = new System.Drawing.Point(308, 213);
            this.btnLogar.Name = "btnLogar";
            this.btnLogar.Size = new System.Drawing.Size(75, 23);
            this.btnLogar.TabIndex = 5;
            this.btnLogar.Text = "Entrar";
            this.btnLogar.UseVisualStyleBackColor = true;
            this.btnLogar.Click += new System.EventHandler(this.btnLogar_Click);
            // 
            // btnCancelarLog
            // 
            this.btnCancelarLog.Location = new System.Drawing.Point(417, 213);
            this.btnCancelarLog.Name = "btnCancelarLog";
            this.btnCancelarLog.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarLog.TabIndex = 6;
            this.btnCancelarLog.Text = "Cancelar";
            this.btnCancelarLog.UseVisualStyleBackColor = true;
            this.btnCancelarLog.Click += new System.EventHandler(this.btnCancelarLog_Click);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancelarLog);
            this.Controls.Add(this.btnLogar);
            this.Controls.Add(this.sENHALabel);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.uSERNAMELabel);
            this.Controls.Add(this.txtUsuarioLog);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TaskManager";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.projectManager_dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tB_USUARIOBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ProjectManager_dbDataSet projectManager_dbDataSet;
        private System.Windows.Forms.BindingSource tB_USUARIOBindingSource;
        private ProjectManager_dbDataSetTableAdapters.TB_USUARIOTableAdapter tB_USUARIOTableAdapter;
        private ProjectManager_dbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox txtUsuarioLog;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Button btnLogar;
        private System.Windows.Forms.Button btnCancelarLog;
        private System.Windows.Forms.Label uSERNAMELabel;
        private System.Windows.Forms.Label sENHALabel;
    }
}