
namespace TaskManager1._0
{
    partial class frmCadFuncionario
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
            System.Windows.Forms.Label iD_USUARIOLabel;
            System.Windows.Forms.Label nOME_USUARIOLabel;
            System.Windows.Forms.Label eMAILLabel;
            System.Windows.Forms.Label tELEFONELabel;
            System.Windows.Forms.Label uSERNAMELabel;
            System.Windows.Forms.Label sENHALabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadFuncionario));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.iD_USUARIOLabel1 = new System.Windows.Forms.Label();
            this.tB_USUARIOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectManager_dbDataSet = new TaskManager1._0.ProjectManager_dbDataSet();
            this.nOME_USUARIOTextBox = new System.Windows.Forms.TextBox();
            this.eMAILTextBox = new System.Windows.Forms.TextBox();
            this.tELEFONEMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.uSERNAMETextBox = new System.Windows.Forms.TextBox();
            this.sENHATextBox = new System.Windows.Forms.TextBox();
            this.tB_USUARIOTableAdapter = new TaskManager1._0.ProjectManager_dbDataSetTableAdapters.TB_USUARIOTableAdapter();
            this.tableAdapterManager = new TaskManager1._0.ProjectManager_dbDataSetTableAdapters.TableAdapterManager();
            this.tB_USUARIOBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.tB_USUARIOBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.btnCancelar = new System.Windows.Forms.ToolStripButton();
            this.btnEditar = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            iD_USUARIOLabel = new System.Windows.Forms.Label();
            nOME_USUARIOLabel = new System.Windows.Forms.Label();
            eMAILLabel = new System.Windows.Forms.Label();
            tELEFONELabel = new System.Windows.Forms.Label();
            uSERNAMELabel = new System.Windows.Forms.Label();
            sENHALabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tB_USUARIOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectManager_dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tB_USUARIOBindingNavigator)).BeginInit();
            this.tB_USUARIOBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // iD_USUARIOLabel
            // 
            iD_USUARIOLabel.AutoSize = true;
            iD_USUARIOLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            iD_USUARIOLabel.Location = new System.Drawing.Point(40, 98);
            iD_USUARIOLabel.Name = "iD_USUARIOLabel";
            iD_USUARIOLabel.Size = new System.Drawing.Size(131, 26);
            iD_USUARIOLabel.TabIndex = 0;
            iD_USUARIOLabel.Text = "ID USUARIO:";
            // 
            // nOME_USUARIOLabel
            // 
            nOME_USUARIOLabel.AutoSize = true;
            nOME_USUARIOLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            nOME_USUARIOLabel.Location = new System.Drawing.Point(40, 128);
            nOME_USUARIOLabel.Name = "nOME_USUARIOLabel";
            nOME_USUARIOLabel.Size = new System.Drawing.Size(174, 26);
            nOME_USUARIOLabel.TabIndex = 2;
            nOME_USUARIOLabel.Text = "NOME USUARIO:";
            // 
            // eMAILLabel
            // 
            eMAILLabel.AutoSize = true;
            eMAILLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            eMAILLabel.Location = new System.Drawing.Point(40, 167);
            eMAILLabel.Name = "eMAILLabel";
            eMAILLabel.Size = new System.Drawing.Size(77, 26);
            eMAILLabel.TabIndex = 4;
            eMAILLabel.Text = "EMAIL:";
            // 
            // tELEFONELabel
            // 
            tELEFONELabel.AutoSize = true;
            tELEFONELabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            tELEFONELabel.Location = new System.Drawing.Point(40, 206);
            tELEFONELabel.Name = "tELEFONELabel";
            tELEFONELabel.Size = new System.Drawing.Size(112, 26);
            tELEFONELabel.TabIndex = 6;
            tELEFONELabel.Text = "TELEFONE:";
            // 
            // uSERNAMELabel
            // 
            uSERNAMELabel.AutoSize = true;
            uSERNAMELabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            uSERNAMELabel.Location = new System.Drawing.Point(40, 245);
            uSERNAMELabel.Name = "uSERNAMELabel";
            uSERNAMELabel.Size = new System.Drawing.Size(125, 26);
            uSERNAMELabel.TabIndex = 8;
            uSERNAMELabel.Text = "USERNAME:";
            // 
            // sENHALabel
            // 
            sENHALabel.AutoSize = true;
            sENHALabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            sENHALabel.Location = new System.Drawing.Point(40, 284);
            sENHALabel.Name = "sENHALabel";
            sENHALabel.Size = new System.Drawing.Size(83, 26);
            sENHALabel.TabIndex = 10;
            sENHALabel.Text = "SENHA:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(iD_USUARIOLabel);
            this.groupBox1.Controls.Add(this.iD_USUARIOLabel1);
            this.groupBox1.Controls.Add(nOME_USUARIOLabel);
            this.groupBox1.Controls.Add(this.nOME_USUARIOTextBox);
            this.groupBox1.Controls.Add(eMAILLabel);
            this.groupBox1.Controls.Add(this.eMAILTextBox);
            this.groupBox1.Controls.Add(tELEFONELabel);
            this.groupBox1.Controls.Add(this.tELEFONEMaskedTextBox);
            this.groupBox1.Controls.Add(uSERNAMELabel);
            this.groupBox1.Controls.Add(this.uSERNAMETextBox);
            this.groupBox1.Controls.Add(sENHALabel);
            this.groupBox1.Controls.Add(this.sENHATextBox);
            this.groupBox1.Enabled = false;
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(45, 94);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1223, 591);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados do Funcionário";
            // 
            // iD_USUARIOLabel1
            // 
            this.iD_USUARIOLabel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.iD_USUARIOLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tB_USUARIOBindingSource, "ID_USUARIO", true));
            this.iD_USUARIOLabel1.Location = new System.Drawing.Point(218, 98);
            this.iD_USUARIOLabel1.Name = "iD_USUARIOLabel1";
            this.iD_USUARIOLabel1.Size = new System.Drawing.Size(100, 23);
            this.iD_USUARIOLabel1.TabIndex = 1;
            this.iD_USUARIOLabel1.Text = "label1";
            // 
            // tB_USUARIOBindingSource
            // 
            this.tB_USUARIOBindingSource.DataMember = "TB_USUARIO";
            this.tB_USUARIOBindingSource.DataSource = this.projectManager_dbDataSet;
            // 
            // projectManager_dbDataSet
            // 
            this.projectManager_dbDataSet.DataSetName = "ProjectManager_dbDataSet";
            this.projectManager_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nOME_USUARIOTextBox
            // 
            this.nOME_USUARIOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tB_USUARIOBindingSource, "NOME_USUARIO", true));
            this.nOME_USUARIOTextBox.Location = new System.Drawing.Point(218, 125);
            this.nOME_USUARIOTextBox.Name = "nOME_USUARIOTextBox";
            this.nOME_USUARIOTextBox.Size = new System.Drawing.Size(426, 33);
            this.nOME_USUARIOTextBox.TabIndex = 3;
            // 
            // eMAILTextBox
            // 
            this.eMAILTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tB_USUARIOBindingSource, "EMAIL", true));
            this.eMAILTextBox.Location = new System.Drawing.Point(218, 164);
            this.eMAILTextBox.Name = "eMAILTextBox";
            this.eMAILTextBox.Size = new System.Drawing.Size(426, 33);
            this.eMAILTextBox.TabIndex = 5;
            // 
            // tELEFONEMaskedTextBox
            // 
            this.tELEFONEMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tB_USUARIOBindingSource, "TELEFONE", true));
            this.tELEFONEMaskedTextBox.Location = new System.Drawing.Point(218, 203);
            this.tELEFONEMaskedTextBox.Mask = "(99) 99999-9999";
            this.tELEFONEMaskedTextBox.Name = "tELEFONEMaskedTextBox";
            this.tELEFONEMaskedTextBox.Size = new System.Drawing.Size(156, 33);
            this.tELEFONEMaskedTextBox.TabIndex = 7;
            // 
            // uSERNAMETextBox
            // 
            this.uSERNAMETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tB_USUARIOBindingSource, "USERNAME", true));
            this.uSERNAMETextBox.Location = new System.Drawing.Point(218, 242);
            this.uSERNAMETextBox.Name = "uSERNAMETextBox";
            this.uSERNAMETextBox.Size = new System.Drawing.Size(100, 33);
            this.uSERNAMETextBox.TabIndex = 9;
            // 
            // sENHATextBox
            // 
            this.sENHATextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tB_USUARIOBindingSource, "SENHA", true));
            this.sENHATextBox.Location = new System.Drawing.Point(218, 281);
            this.sENHATextBox.Name = "sENHATextBox";
            this.sENHATextBox.Size = new System.Drawing.Size(100, 33);
            this.sENHATextBox.TabIndex = 11;
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
            // tB_USUARIOBindingNavigator
            // 
            this.tB_USUARIOBindingNavigator.AddNewItem = null;
            this.tB_USUARIOBindingNavigator.BindingSource = this.tB_USUARIOBindingSource;
            this.tB_USUARIOBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tB_USUARIOBindingNavigator.DeleteItem = null;
            this.tB_USUARIOBindingNavigator.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.tB_USUARIOBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.tB_USUARIOBindingNavigatorSaveItem,
            this.btnCancelar,
            this.btnEditar,
            this.toolStripButton1});
            this.tB_USUARIOBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tB_USUARIOBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tB_USUARIOBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tB_USUARIOBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tB_USUARIOBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tB_USUARIOBindingNavigator.Name = "tB_USUARIOBindingNavigator";
            this.tB_USUARIOBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tB_USUARIOBindingNavigator.Size = new System.Drawing.Size(1318, 39);
            this.tB_USUARIOBindingNavigator.TabIndex = 1;
            this.tB_USUARIOBindingNavigator.Text = "bindingNavigator1";
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
            // tB_USUARIOBindingNavigatorSaveItem
            // 
            this.tB_USUARIOBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tB_USUARIOBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tB_USUARIOBindingNavigatorSaveItem.Image")));
            this.tB_USUARIOBindingNavigatorSaveItem.Name = "tB_USUARIOBindingNavigatorSaveItem";
            this.tB_USUARIOBindingNavigatorSaveItem.Size = new System.Drawing.Size(36, 36);
            this.tB_USUARIOBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.tB_USUARIOBindingNavigatorSaveItem.Click += new System.EventHandler(this.tB_USUARIOBindingNavigatorSaveItem_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = global::TaskManager1._0.Properties.Resources.cancel;
            this.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(89, 36);
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Image = global::TaskManager1._0.Properties.Resources.edit;
            this.btnEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(73, 36);
            this.btnEditar.Text = "Editar";
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(89, 36);
            this.toolStripButton1.Text = "Localizar";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // frmCadFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1318, 720);
            this.Controls.Add(this.tB_USUARIOBindingNavigator);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCadFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCadFuncionario";
            this.Load += new System.EventHandler(this.frmCadFuncionario_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tB_USUARIOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectManager_dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tB_USUARIOBindingNavigator)).EndInit();
            this.tB_USUARIOBindingNavigator.ResumeLayout(false);
            this.tB_USUARIOBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private ProjectManager_dbDataSet projectManager_dbDataSet;
        private System.Windows.Forms.BindingSource tB_USUARIOBindingSource;
        private ProjectManager_dbDataSetTableAdapters.TB_USUARIOTableAdapter tB_USUARIOTableAdapter;
        private ProjectManager_dbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tB_USUARIOBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton tB_USUARIOBindingNavigatorSaveItem;
        private System.Windows.Forms.Label iD_USUARIOLabel1;
        private System.Windows.Forms.TextBox nOME_USUARIOTextBox;
        private System.Windows.Forms.TextBox eMAILTextBox;
        private System.Windows.Forms.MaskedTextBox tELEFONEMaskedTextBox;
        private System.Windows.Forms.TextBox uSERNAMETextBox;
        private System.Windows.Forms.TextBox sENHATextBox;
        private System.Windows.Forms.ToolStripButton btnCancelar;
        private System.Windows.Forms.ToolStripButton btnEditar;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}