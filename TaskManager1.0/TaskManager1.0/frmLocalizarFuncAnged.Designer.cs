
namespace TaskManager1._0
{
    partial class frmLocalizarFuncAnged
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancelarLocal = new System.Windows.Forms.Button();
            this.txtNomeLocal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.projectManager_dbDataSet = new TaskManager1._0.ProjectManager_dbDataSet();
            this.tB_USUARIOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tB_USUARIOTableAdapter = new TaskManager1._0.ProjectManager_dbDataSetTableAdapters.TB_USUARIOTableAdapter();
            this.tableAdapterManager = new TaskManager1._0.ProjectManager_dbDataSetTableAdapters.TableAdapterManager();
            this.tB_USUARIODataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.projectManager_dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tB_USUARIOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tB_USUARIODataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 334);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(365, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "*Dê dois cliques sobre o registro desejado";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-59, -36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nome do funcionário";
            // 
            // btnCancelarLocal
            // 
            this.btnCancelarLocal.Location = new System.Drawing.Point(638, 327);
            this.btnCancelarLocal.Name = "btnCancelarLocal";
            this.btnCancelarLocal.Size = new System.Drawing.Size(107, 39);
            this.btnCancelarLocal.TabIndex = 7;
            this.btnCancelarLocal.Text = "Cancelar";
            this.btnCancelarLocal.UseVisualStyleBackColor = true;
            this.btnCancelarLocal.Click += new System.EventHandler(this.btnCancelarLocal_Click);
            // 
            // txtNomeLocal
            // 
            this.txtNomeLocal.Location = new System.Drawing.Point(12, 45);
            this.txtNomeLocal.Name = "txtNomeLocal";
            this.txtNomeLocal.Size = new System.Drawing.Size(599, 29);
            this.txtNomeLocal.TabIndex = 6;
            this.txtNomeLocal.TextChanged += new System.EventHandler(this.txtNomeLocal_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "Nome do funcionário";
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
            // tB_USUARIODataGridView
            // 
            this.tB_USUARIODataGridView.AllowUserToAddRows = false;
            this.tB_USUARIODataGridView.AllowUserToDeleteRows = false;
            this.tB_USUARIODataGridView.AutoGenerateColumns = false;
            this.tB_USUARIODataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tB_USUARIODataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.tB_USUARIODataGridView.DataSource = this.tB_USUARIOBindingSource;
            this.tB_USUARIODataGridView.Location = new System.Drawing.Point(12, 80);
            this.tB_USUARIODataGridView.Name = "tB_USUARIODataGridView";
            this.tB_USUARIODataGridView.ReadOnly = true;
            this.tB_USUARIODataGridView.Size = new System.Drawing.Size(645, 220);
            this.tB_USUARIODataGridView.TabIndex = 11;
            this.tB_USUARIODataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tB_USUARIODataGridView_CellDoubleClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_USUARIO";
            this.dataGridViewTextBoxColumn1.HeaderText = "Código";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 96;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NOME_USUARIO";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "EMAIL";
            this.dataGridViewTextBoxColumn3.HeaderText = "EMAIL";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Visible = false;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "TELEFONE";
            this.dataGridViewTextBoxColumn4.HeaderText = "TELEFONE";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Visible = false;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "USERNAME";
            this.dataGridViewTextBoxColumn5.HeaderText = "USERNAME";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Visible = false;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "SENHA";
            this.dataGridViewTextBoxColumn6.HeaderText = "SENHA";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Visible = false;
            // 
            // frmLocalizarFuncAnged
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 410);
            this.ControlBox = false;
            this.Controls.Add(this.tB_USUARIODataGridView);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancelarLocal);
            this.Controls.Add(this.txtNomeLocal);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "frmLocalizarFuncAnged";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Localizar Funcionario";
            this.Load += new System.EventHandler(this.frmLocalizarFuncAnged_Load);
            ((System.ComponentModel.ISupportInitialize)(this.projectManager_dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tB_USUARIOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tB_USUARIODataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancelarLocal;
        private System.Windows.Forms.TextBox txtNomeLocal;
        private System.Windows.Forms.Label label3;
        private ProjectManager_dbDataSet projectManager_dbDataSet;
        private System.Windows.Forms.BindingSource tB_USUARIOBindingSource;
        private ProjectManager_dbDataSetTableAdapters.TB_USUARIOTableAdapter tB_USUARIOTableAdapter;
        private ProjectManager_dbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView tB_USUARIODataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}