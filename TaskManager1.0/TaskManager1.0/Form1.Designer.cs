
namespace TaskManager1._0
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.PanelTopo = new System.Windows.Forms.Panel();
            this.btnMin = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.PanelLateral = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblandamento = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PanelSelecao = new System.Windows.Forms.Panel();
            this.btnInicio = new System.Windows.Forms.Button();
            this.btnProjeto = new System.Windows.Forms.Button();
            this.btnTarefa = new System.Windows.Forms.Button();
            this.btnFuncionario = new System.Windows.Forms.Button();
            this.PanelCentral = new System.Windows.Forms.Panel();
            this.projectManager_dbDataSet = new TaskManager1._0.ProjectManager_dbDataSet();
            this.view_ProjetoTarefaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.view_ProjetoTarefaTableAdapter = new TaskManager1._0.ProjectManager_dbDataSetTableAdapters.View_ProjetoTarefaTableAdapter();
            this.tableAdapterManager = new TaskManager1._0.ProjectManager_dbDataSetTableAdapters.TableAdapterManager();
            this.view_DetalhesProjetoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.view_DetalhesProjetoTableAdapter = new TaskManager1._0.ProjectManager_dbDataSetTableAdapters.View_DetalhesProjetoTableAdapter();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.PanelTopo.SuspendLayout();
            this.PanelLateral.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projectManager_dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_ProjetoTarefaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_DetalhesProjetoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelTopo
            // 
            this.PanelTopo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.PanelTopo.Controls.Add(this.btnMin);
            this.PanelTopo.Controls.Add(this.btnSair);
            this.PanelTopo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTopo.Location = new System.Drawing.Point(0, 0);
            this.PanelTopo.Name = "PanelTopo";
            this.PanelTopo.Size = new System.Drawing.Size(1600, 111);
            this.PanelTopo.TabIndex = 0;
            // 
            // btnMin
            // 
            this.btnMin.BackgroundImage = global::TaskManager1._0.Properties.Resources.Minimize;
            this.btnMin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMin.FlatAppearance.BorderSize = 0;
            this.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMin.Location = new System.Drawing.Point(1521, 3);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(35, 35);
            this.btnMin.TabIndex = 1;
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackgroundImage = global::TaskManager1._0.Properties.Resources.Close_removebg_preview;
            this.btnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Location = new System.Drawing.Point(1562, 3);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(35, 35);
            this.btnSair.TabIndex = 0;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // PanelLateral
            // 
            this.PanelLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.PanelLateral.Controls.Add(this.groupBox1);
            this.PanelLateral.Controls.Add(this.PanelSelecao);
            this.PanelLateral.Controls.Add(this.btnInicio);
            this.PanelLateral.Controls.Add(this.btnProjeto);
            this.PanelLateral.Controls.Add(this.btnTarefa);
            this.PanelLateral.Controls.Add(this.btnFuncionario);
            this.PanelLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelLateral.Location = new System.Drawing.Point(0, 111);
            this.PanelLateral.Name = "PanelLateral";
            this.PanelLateral.Size = new System.Drawing.Size(282, 720);
            this.PanelLateral.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Silver;
            this.groupBox1.Controls.Add(this.lblandamento);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(30, 371);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(224, 107);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Projetos";
            // 
            // lblandamento
            // 
            this.lblandamento.AutoSize = true;
            this.lblandamento.Location = new System.Drawing.Point(190, 33);
            this.lblandamento.Name = "lblandamento";
            this.lblandamento.Size = new System.Drawing.Size(22, 24);
            this.lblandamento.TabIndex = 1;
            this.lblandamento.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Em andamento:";
            // 
            // PanelSelecao
            // 
            this.PanelSelecao.BackColor = System.Drawing.Color.Purple;
            this.PanelSelecao.Location = new System.Drawing.Point(3, 78);
            this.PanelSelecao.Name = "PanelSelecao";
            this.PanelSelecao.Size = new System.Drawing.Size(23, 63);
            this.PanelSelecao.TabIndex = 0;
            // 
            // btnInicio
            // 
            this.btnInicio.Location = new System.Drawing.Point(30, 78);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(224, 63);
            this.btnInicio.TabIndex = 3;
            this.btnInicio.Text = "Início";
            this.btnInicio.UseVisualStyleBackColor = true;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // btnProjeto
            // 
            this.btnProjeto.Location = new System.Drawing.Point(30, 285);
            this.btnProjeto.Name = "btnProjeto";
            this.btnProjeto.Size = new System.Drawing.Size(224, 63);
            this.btnProjeto.TabIndex = 2;
            this.btnProjeto.Text = "Projeto";
            this.btnProjeto.UseVisualStyleBackColor = true;
            this.btnProjeto.Click += new System.EventHandler(this.btnProjeto_Click);
            // 
            // btnTarefa
            // 
            this.btnTarefa.Location = new System.Drawing.Point(30, 216);
            this.btnTarefa.Name = "btnTarefa";
            this.btnTarefa.Size = new System.Drawing.Size(224, 63);
            this.btnTarefa.TabIndex = 1;
            this.btnTarefa.Text = "Tarefa";
            this.btnTarefa.UseVisualStyleBackColor = true;
            this.btnTarefa.Click += new System.EventHandler(this.btnTarefa_Click);
            // 
            // btnFuncionario
            // 
            this.btnFuncionario.Location = new System.Drawing.Point(30, 147);
            this.btnFuncionario.Name = "btnFuncionario";
            this.btnFuncionario.Size = new System.Drawing.Size(224, 63);
            this.btnFuncionario.TabIndex = 0;
            this.btnFuncionario.Text = "Funcionário";
            this.btnFuncionario.UseVisualStyleBackColor = true;
            this.btnFuncionario.Click += new System.EventHandler(this.btnFuncionario_Click);
            // 
            // PanelCentral
            // 
            this.PanelCentral.BackColor = System.Drawing.Color.Silver;
            this.PanelCentral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelCentral.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PanelCentral.Location = new System.Drawing.Point(282, 111);
            this.PanelCentral.Name = "PanelCentral";
            this.PanelCentral.Size = new System.Drawing.Size(1318, 720);
            this.PanelCentral.TabIndex = 2;
            // 
            // projectManager_dbDataSet
            // 
            this.projectManager_dbDataSet.DataSetName = "ProjectManager_dbDataSet";
            this.projectManager_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // view_ProjetoTarefaBindingSource
            // 
            this.view_ProjetoTarefaBindingSource.DataMember = "View_ProjetoTarefa";
            this.view_ProjetoTarefaBindingSource.DataSource = this.projectManager_dbDataSet;
            // 
            // view_ProjetoTarefaTableAdapter
            // 
            this.view_ProjetoTarefaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.PROJETO_TAREFATableAdapter = null;
            this.tableAdapterManager.TB_PROJETOTableAdapter = null;
            this.tableAdapterManager.TB_TAREFATableAdapter = null;
            this.tableAdapterManager.TB_USUARIOTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = TaskManager1._0.ProjectManager_dbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // view_DetalhesProjetoBindingSource
            // 
            this.view_DetalhesProjetoBindingSource.DataMember = "View_DetalhesProjeto";
            this.view_DetalhesProjetoBindingSource.DataSource = this.projectManager_dbDataSet;
            // 
            // view_DetalhesProjetoTableAdapter
            // 
            this.view_DetalhesProjetoTableAdapter.ClearBeforeFill = true;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 831);
            this.Controls.Add(this.PanelCentral);
            this.Controls.Add(this.PanelLateral);
            this.Controls.Add(this.PanelTopo);
            this.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.PanelTopo.ResumeLayout(false);
            this.PanelLateral.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projectManager_dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_ProjetoTarefaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_DetalhesProjetoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelTopo;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Panel PanelLateral;
        private System.Windows.Forms.Button btnProjeto;
        private System.Windows.Forms.Button btnTarefa;
        private System.Windows.Forms.Button btnFuncionario;
        private System.Windows.Forms.Panel PanelCentral;
        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.Panel PanelSelecao;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblandamento;
        private System.Windows.Forms.Label label1;
        private ProjectManager_dbDataSet projectManager_dbDataSet;
        private System.Windows.Forms.BindingSource view_ProjetoTarefaBindingSource;
        private ProjectManager_dbDataSetTableAdapters.View_ProjetoTarefaTableAdapter view_ProjetoTarefaTableAdapter;
        private ProjectManager_dbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource view_DetalhesProjetoBindingSource;
        private ProjectManager_dbDataSetTableAdapters.View_DetalhesProjetoTableAdapter view_DetalhesProjetoTableAdapter;
        private System.Windows.Forms.Timer timer1;
    }
}

