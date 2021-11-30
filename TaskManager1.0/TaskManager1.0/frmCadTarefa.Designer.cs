
namespace TaskManager1._0
{
    partial class frmCadTarefa
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
            System.Windows.Forms.Label iD_TAREFALabel;
            System.Windows.Forms.Label nOME_TAREFALabel;
            System.Windows.Forms.Label dESCRICAO_TAREFALabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadTarefa));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.iD_TAREFALabel1 = new System.Windows.Forms.Label();
            this.tB_TAREFABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectManager_dbDataSet = new TaskManager1._0.ProjectManager_dbDataSet();
            this.nOME_TAREFATextBox = new System.Windows.Forms.TextBox();
            this.dESCRICAO_TAREFATextBox = new System.Windows.Forms.TextBox();
            this.tB_TAREFATableAdapter = new TaskManager1._0.ProjectManager_dbDataSetTableAdapters.TB_TAREFATableAdapter();
            this.tableAdapterManager = new TaskManager1._0.ProjectManager_dbDataSetTableAdapters.TableAdapterManager();
            this.tB_TAREFABindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.tB_TAREFABindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.btnCancelarT = new System.Windows.Forms.ToolStripButton();
            this.btnEditarT = new System.Windows.Forms.ToolStripButton();
            iD_TAREFALabel = new System.Windows.Forms.Label();
            nOME_TAREFALabel = new System.Windows.Forms.Label();
            dESCRICAO_TAREFALabel = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tB_TAREFABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectManager_dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tB_TAREFABindingNavigator)).BeginInit();
            this.tB_TAREFABindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // iD_TAREFALabel
            // 
            iD_TAREFALabel.AutoSize = true;
            iD_TAREFALabel.Location = new System.Drawing.Point(44, 92);
            iD_TAREFALabel.Name = "iD_TAREFALabel";
            iD_TAREFALabel.Size = new System.Drawing.Size(114, 24);
            iD_TAREFALabel.TabIndex = 0;
            iD_TAREFALabel.Text = "ID TAREFA:";
            // 
            // nOME_TAREFALabel
            // 
            nOME_TAREFALabel.AutoSize = true;
            nOME_TAREFALabel.Location = new System.Drawing.Point(44, 122);
            nOME_TAREFALabel.Name = "nOME_TAREFALabel";
            nOME_TAREFALabel.Size = new System.Drawing.Size(157, 24);
            nOME_TAREFALabel.TabIndex = 2;
            nOME_TAREFALabel.Text = "NOME TAREFA:";
            // 
            // dESCRICAO_TAREFALabel
            // 
            dESCRICAO_TAREFALabel.AutoSize = true;
            dESCRICAO_TAREFALabel.Location = new System.Drawing.Point(44, 161);
            dESCRICAO_TAREFALabel.Name = "dESCRICAO_TAREFALabel";
            dESCRICAO_TAREFALabel.Size = new System.Drawing.Size(215, 24);
            dESCRICAO_TAREFALabel.TabIndex = 4;
            dESCRICAO_TAREFALabel.Text = "DESCRICAO TAREFA:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(iD_TAREFALabel);
            this.groupBox2.Controls.Add(this.iD_TAREFALabel1);
            this.groupBox2.Controls.Add(nOME_TAREFALabel);
            this.groupBox2.Controls.Add(this.nOME_TAREFATextBox);
            this.groupBox2.Controls.Add(dESCRICAO_TAREFALabel);
            this.groupBox2.Controls.Add(this.dESCRICAO_TAREFATextBox);
            this.groupBox2.Enabled = false;
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(53, 63);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1148, 617);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dados da Tarefa";
            // 
            // iD_TAREFALabel1
            // 
            this.iD_TAREFALabel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.iD_TAREFALabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tB_TAREFABindingSource, "ID_TAREFA", true));
            this.iD_TAREFALabel1.Location = new System.Drawing.Point(265, 92);
            this.iD_TAREFALabel1.Name = "iD_TAREFALabel1";
            this.iD_TAREFALabel1.Size = new System.Drawing.Size(100, 23);
            this.iD_TAREFALabel1.TabIndex = 1;
            this.iD_TAREFALabel1.Text = "label1";
            // 
            // tB_TAREFABindingSource
            // 
            this.tB_TAREFABindingSource.DataMember = "TB_TAREFA";
            this.tB_TAREFABindingSource.DataSource = this.projectManager_dbDataSet;
            // 
            // projectManager_dbDataSet
            // 
            this.projectManager_dbDataSet.DataSetName = "ProjectManager_dbDataSet";
            this.projectManager_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nOME_TAREFATextBox
            // 
            this.nOME_TAREFATextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tB_TAREFABindingSource, "NOME_TAREFA", true));
            this.nOME_TAREFATextBox.Location = new System.Drawing.Point(265, 122);
            this.nOME_TAREFATextBox.Name = "nOME_TAREFATextBox";
            this.nOME_TAREFATextBox.Size = new System.Drawing.Size(412, 33);
            this.nOME_TAREFATextBox.TabIndex = 3;
            // 
            // dESCRICAO_TAREFATextBox
            // 
            this.dESCRICAO_TAREFATextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tB_TAREFABindingSource, "DESCRICAO_TAREFA", true));
            this.dESCRICAO_TAREFATextBox.Location = new System.Drawing.Point(265, 158);
            this.dESCRICAO_TAREFATextBox.MaxLength = 50;
            this.dESCRICAO_TAREFATextBox.Multiline = true;
            this.dESCRICAO_TAREFATextBox.Name = "dESCRICAO_TAREFATextBox";
            this.dESCRICAO_TAREFATextBox.Size = new System.Drawing.Size(412, 116);
            this.dESCRICAO_TAREFATextBox.TabIndex = 5;
            // 
            // tB_TAREFATableAdapter
            // 
            this.tB_TAREFATableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.PROJETO_TAREFATableAdapter = null;
            this.tableAdapterManager.TB_PROJETOTableAdapter = null;
            this.tableAdapterManager.TB_TAREFATableAdapter = this.tB_TAREFATableAdapter;
            this.tableAdapterManager.TB_USUARIOTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = TaskManager1._0.ProjectManager_dbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tB_TAREFABindingNavigator
            // 
            this.tB_TAREFABindingNavigator.AddNewItem = null;
            this.tB_TAREFABindingNavigator.BindingSource = this.tB_TAREFABindingSource;
            this.tB_TAREFABindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tB_TAREFABindingNavigator.DeleteItem = null;
            this.tB_TAREFABindingNavigator.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.tB_TAREFABindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.tB_TAREFABindingNavigatorSaveItem,
            this.btnCancelarT,
            this.btnEditarT});
            this.tB_TAREFABindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tB_TAREFABindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tB_TAREFABindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tB_TAREFABindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tB_TAREFABindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tB_TAREFABindingNavigator.Name = "tB_TAREFABindingNavigator";
            this.tB_TAREFABindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tB_TAREFABindingNavigator.Size = new System.Drawing.Size(1318, 39);
            this.tB_TAREFABindingNavigator.TabIndex = 1;
            this.tB_TAREFABindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 36);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 39);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posição";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posição atual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 39);
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(36, 36);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primeiro";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(36, 36);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(36, 36);
            this.bindingNavigatorMoveNextItem.Text = "Mover próximo";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(36, 36);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(36, 36);
            this.bindingNavigatorAddNewItem.Text = "Adicionar novo";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = global::TaskManager1._0.Properties.Resources.Trash_removebg_preview;
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(36, 36);
            this.bindingNavigatorDeleteItem.Text = "Excluir";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // tB_TAREFABindingNavigatorSaveItem
            // 
            this.tB_TAREFABindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tB_TAREFABindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tB_TAREFABindingNavigatorSaveItem.Image")));
            this.tB_TAREFABindingNavigatorSaveItem.Name = "tB_TAREFABindingNavigatorSaveItem";
            this.tB_TAREFABindingNavigatorSaveItem.Size = new System.Drawing.Size(36, 36);
            this.tB_TAREFABindingNavigatorSaveItem.Text = "Salvar Dados";
            this.tB_TAREFABindingNavigatorSaveItem.Click += new System.EventHandler(this.tB_TAREFABindingNavigatorSaveItem_Click);
            // 
            // btnCancelarT
            // 
            this.btnCancelarT.Image = global::TaskManager1._0.Properties.Resources.cancel;
            this.btnCancelarT.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancelarT.Name = "btnCancelarT";
            this.btnCancelarT.Size = new System.Drawing.Size(89, 36);
            this.btnCancelarT.Text = "Cancelar";
            this.btnCancelarT.Click += new System.EventHandler(this.btnCancelarT_Click);
            // 
            // btnEditarT
            // 
            this.btnEditarT.Image = global::TaskManager1._0.Properties.Resources.edit;
            this.btnEditarT.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditarT.Name = "btnEditarT";
            this.btnEditarT.Size = new System.Drawing.Size(73, 36);
            this.btnEditarT.Text = "Editar";
            this.btnEditarT.Click += new System.EventHandler(this.btnEditarT_Click);
            // 
            // frmCadTarefa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1318, 720);
            this.Controls.Add(this.tB_TAREFABindingNavigator);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCadTarefa";
            this.Text = "frmCadTarefa";
            this.Load += new System.EventHandler(this.frmCadTarefa_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tB_TAREFABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectManager_dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tB_TAREFABindingNavigator)).EndInit();
            this.tB_TAREFABindingNavigator.ResumeLayout(false);
            this.tB_TAREFABindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private ProjectManager_dbDataSet projectManager_dbDataSet;
        private System.Windows.Forms.BindingSource tB_TAREFABindingSource;
        private ProjectManager_dbDataSetTableAdapters.TB_TAREFATableAdapter tB_TAREFATableAdapter;
        private ProjectManager_dbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tB_TAREFABindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton tB_TAREFABindingNavigatorSaveItem;
        private System.Windows.Forms.Label iD_TAREFALabel1;
        private System.Windows.Forms.TextBox nOME_TAREFATextBox;
        private System.Windows.Forms.TextBox dESCRICAO_TAREFATextBox;
        private System.Windows.Forms.ToolStripButton btnCancelarT;
        private System.Windows.Forms.ToolStripButton btnEditarT;
    }
}