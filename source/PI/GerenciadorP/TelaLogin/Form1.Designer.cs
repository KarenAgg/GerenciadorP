
namespace TelaLogin
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
            Guna.UI.Animation.Animation animation6 = new Guna.UI.Animation.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.p1 = new Guna.UI.WinForms.GunaPanel();
            this.lbnome2 = new Guna.UI.WinForms.GunaLabel();
            this.btswitch = new Guna.UI.WinForms.GunaSwitch();
            this.lbnome3 = new Guna.UI.WinForms.GunaLabel();
            this.lbnome1 = new Guna.UI.WinForms.GunaLabel();
            this.pcadastro = new Guna.UI.WinForms.GunaPanel();
            this.lbsenhacad = new Guna.UI.WinForms.GunaLabel();
            this.controlb = new Guna.UI.WinForms.GunaControlBox();
            this.lbtermos = new Guna.UI.WinForms.GunaCheckBox();
            this.lbconta = new Guna.UI.WinForms.GunaLabel();
            this.lblentrar = new Guna.UI.WinForms.GunaLinkLabel();
            this.btcadastro = new Guna.UI.WinForms.GunaButton();
            this.txtsenhacad = new Guna.UI.WinForms.GunaLineTextBox();
            this.txtcargo = new Guna.UI.WinForms.GunaLineTextBox();
            this.txtemailcad = new Guna.UI.WinForms.GunaLineTextBox();
            this.plogin = new Guna.UI.WinForms.GunaPanel();
            this.lbsenha = new Guna.UI.WinForms.GunaLabel();
            this.cbsenha = new Guna.UI.WinForms.GunaCheckBox();
            this.lbcad = new Guna.UI.WinForms.GunaLabel();
            this.lblsenha = new Guna.UI.WinForms.GunaLinkLabel();
            this.lblcadastro = new Guna.UI.WinForms.GunaLinkLabel();
            this.btentrar = new Guna.UI.WinForms.GunaButton();
            this.txtsenha = new Guna.UI.WinForms.GunaLineTextBox();
            this.txtemail = new Guna.UI.WinForms.GunaLineTextBox();
            this.animaw = new Guna.UI.WinForms.GunaAnimateWindow(this.components);
            this.animacad = new Guna.UI.WinForms.GunaTransition(this.components);
            this.txtnome = new Guna.UI.WinForms.GunaLineTextBox();
            this.txtrecup = new Guna.UI.WinForms.GunaLineTextBox();
            this.p1.SuspendLayout();
            this.pcadastro.SuspendLayout();
            this.plogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // p1
            // 
            this.p1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.p1.BackColor = System.Drawing.Color.White;
            this.p1.Controls.Add(this.lbnome2);
            this.p1.Controls.Add(this.btswitch);
            this.p1.Controls.Add(this.lbnome3);
            this.p1.Controls.Add(this.lbnome1);
            this.animacad.SetDecoration(this.p1, Guna.UI.Animation.DecorationType.None);
            this.p1.Location = new System.Drawing.Point(74, 45);
            this.p1.Name = "p1";
            this.p1.Size = new System.Drawing.Size(266, 488);
            this.p1.TabIndex = 2;
            // 
            // lbnome2
            // 
            this.lbnome2.AutoSize = true;
            this.animacad.SetDecoration(this.lbnome2, Guna.UI.Animation.DecorationType.None);
            this.lbnome2.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.lbnome2.ForeColor = System.Drawing.Color.DarkGray;
            this.lbnome2.Location = new System.Drawing.Point(114, 181);
            this.lbnome2.Name = "lbnome2";
            this.lbnome2.Size = new System.Drawing.Size(92, 32);
            this.lbnome2.TabIndex = 5;
            this.lbnome2.Text = "NOME ";
            // 
            // btswitch
            // 
            this.btswitch.BaseColor = System.Drawing.SystemColors.Control;
            this.btswitch.CheckedOffColor = System.Drawing.Color.DarkGray;
            this.btswitch.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.animacad.SetDecoration(this.btswitch, Guna.UI.Animation.DecorationType.None);
            this.btswitch.FillColor = System.Drawing.Color.White;
            this.btswitch.Location = new System.Drawing.Point(3, 3);
            this.btswitch.Name = "btswitch";
            this.btswitch.Size = new System.Drawing.Size(28, 20);
            this.btswitch.TabIndex = 7;
            this.btswitch.CheckedChanged += new System.EventHandler(this.btswitch_CheckedChanged);
            // 
            // lbnome3
            // 
            this.lbnome3.AutoSize = true;
            this.animacad.SetDecoration(this.lbnome3, Guna.UI.Animation.DecorationType.None);
            this.lbnome3.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lbnome3.ForeColor = System.Drawing.Color.DarkGray;
            this.lbnome3.Location = new System.Drawing.Point(118, 208);
            this.lbnome3.Name = "lbnome3";
            this.lbnome3.Size = new System.Drawing.Size(133, 20);
            this.lbnome3.TabIndex = 4;
            this.lbnome3.Text = "Nome do software";
            // 
            // lbnome1
            // 
            this.lbnome1.AutoSize = true;
            this.animacad.SetDecoration(this.lbnome1, Guna.UI.Animation.DecorationType.None);
            this.lbnome1.Font = new System.Drawing.Font("Segoe UI", 40F, System.Drawing.FontStyle.Bold);
            this.lbnome1.ForeColor = System.Drawing.Color.Gray;
            this.lbnome1.Location = new System.Drawing.Point(19, 166);
            this.lbnome1.Name = "lbnome1";
            this.lbnome1.Size = new System.Drawing.Size(195, 72);
            this.lbnome1.TabIndex = 3;
            this.lbnome1.Text = "NOME";
            // 
            // pcadastro
            // 
            this.pcadastro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pcadastro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.pcadastro.Controls.Add(this.lbsenhacad);
            this.pcadastro.Controls.Add(this.controlb);
            this.pcadastro.Controls.Add(this.lbtermos);
            this.pcadastro.Controls.Add(this.lbconta);
            this.pcadastro.Controls.Add(this.lblentrar);
            this.pcadastro.Controls.Add(this.btcadastro);
            this.pcadastro.Controls.Add(this.txtsenhacad);
            this.pcadastro.Controls.Add(this.txtcargo);
            this.pcadastro.Controls.Add(this.txtrecup);
            this.pcadastro.Controls.Add(this.txtnome);
            this.pcadastro.Controls.Add(this.txtemailcad);
            this.animacad.SetDecoration(this.pcadastro, Guna.UI.Animation.DecorationType.None);
            this.pcadastro.Location = new System.Drawing.Point(339, 45);
            this.pcadastro.Name = "pcadastro";
            this.pcadastro.Size = new System.Drawing.Size(388, 488);
            this.pcadastro.TabIndex = 6;
            this.pcadastro.TabStop = true;
            this.pcadastro.UseWaitCursor = true;
            this.pcadastro.Visible = false;
            // 
            // lbsenhacad
            // 
            this.lbsenhacad.AutoSize = true;
            this.animacad.SetDecoration(this.lbsenhacad, Guna.UI.Animation.DecorationType.None);
            this.lbsenhacad.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbsenhacad.ForeColor = System.Drawing.Color.Gray;
            this.lbsenhacad.Location = new System.Drawing.Point(55, 299);
            this.lbsenhacad.Name = "lbsenhacad";
            this.lbsenhacad.Size = new System.Drawing.Size(39, 15);
            this.lbsenhacad.TabIndex = 8;
            this.lbsenhacad.Text = "Senha";
            this.lbsenhacad.UseWaitCursor = true;
            // 
            // controlb
            // 
            this.controlb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.controlb.AnimationHoverSpeed = 0.07F;
            this.controlb.AnimationSpeed = 0.03F;
            this.animacad.SetDecoration(this.controlb, Guna.UI.Animation.DecorationType.None);
            this.controlb.IconColor = System.Drawing.Color.Silver;
            this.controlb.IconSize = 15F;
            this.controlb.Location = new System.Drawing.Point(360, 3);
            this.controlb.Name = "controlb";
            this.controlb.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.controlb.OnHoverIconColor = System.Drawing.Color.White;
            this.controlb.OnPressedColor = System.Drawing.Color.Black;
            this.controlb.Size = new System.Drawing.Size(25, 18);
            this.controlb.TabIndex = 7;
            this.controlb.UseWaitCursor = true;
            // 
            // lbtermos
            // 
            this.lbtermos.BaseColor = System.Drawing.Color.White;
            this.lbtermos.CheckedOffColor = System.Drawing.Color.Gray;
            this.lbtermos.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.animacad.SetDecoration(this.lbtermos, Guna.UI.Animation.DecorationType.None);
            this.lbtermos.FillColor = System.Drawing.Color.White;
            this.lbtermos.ForeColor = System.Drawing.Color.Gray;
            this.lbtermos.Location = new System.Drawing.Point(56, 341);
            this.lbtermos.Name = "lbtermos";
            this.lbtermos.Size = new System.Drawing.Size(211, 20);
            this.lbtermos.TabIndex = 6;
            this.lbtermos.Text = "Li e concordo com os termos de uso";
            this.lbtermos.UseWaitCursor = true;
            // 
            // lbconta
            // 
            this.lbconta.AutoSize = true;
            this.animacad.SetDecoration(this.lbconta, Guna.UI.Animation.DecorationType.None);
            this.lbconta.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbconta.ForeColor = System.Drawing.Color.Gray;
            this.lbconta.Location = new System.Drawing.Point(109, 450);
            this.lbconta.Name = "lbconta";
            this.lbconta.Size = new System.Drawing.Size(119, 15);
            this.lbconta.TabIndex = 4;
            this.lbconta.Text = "Já possui uma conta?";
            this.lbconta.UseWaitCursor = true;
            // 
            // lblentrar
            // 
            this.lblentrar.ActiveLinkColor = System.Drawing.Color.RoyalBlue;
            this.lblentrar.AutoSize = true;
            this.animacad.SetDecoration(this.lblentrar, Guna.UI.Animation.DecorationType.None);
            this.lblentrar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblentrar.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(85)))), ((int)(((byte)(238)))));
            this.lblentrar.Location = new System.Drawing.Point(234, 450);
            this.lblentrar.Name = "lblentrar";
            this.lblentrar.Size = new System.Drawing.Size(38, 15);
            this.lblentrar.TabIndex = 3;
            this.lblentrar.TabStop = true;
            this.lblentrar.Text = "Entrar";
            this.lblentrar.UseWaitCursor = true;
            this.lblentrar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblentrar_LinkClicked);
            // 
            // btcadastro
            // 
            this.btcadastro.AnimationHoverSpeed = 0.07F;
            this.btcadastro.AnimationSpeed = 0.03F;
            this.btcadastro.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(85)))), ((int)(((byte)(238)))));
            this.btcadastro.BorderColor = System.Drawing.Color.Black;
            this.animacad.SetDecoration(this.btcadastro, Guna.UI.Animation.DecorationType.None);
            this.btcadastro.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btcadastro.FocusedColor = System.Drawing.Color.Empty;
            this.btcadastro.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btcadastro.ForeColor = System.Drawing.Color.White;
            this.btcadastro.Image = null;
            this.btcadastro.ImageSize = new System.Drawing.Size(20, 20);
            this.btcadastro.Location = new System.Drawing.Point(56, 390);
            this.btcadastro.Name = "btcadastro";
            this.btcadastro.OnHoverBaseColor = System.Drawing.Color.Silver;
            this.btcadastro.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btcadastro.OnHoverForeColor = System.Drawing.Color.White;
            this.btcadastro.OnHoverImage = null;
            this.btcadastro.OnPressedColor = System.Drawing.Color.Black;
            this.btcadastro.Size = new System.Drawing.Size(290, 42);
            this.btcadastro.TabIndex = 2;
            this.btcadastro.Text = "Cadastrar";
            this.btcadastro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btcadastro.UseWaitCursor = true;
            // 
            // txtsenhacad
            // 
            this.txtsenhacad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.txtsenhacad.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.animacad.SetDecoration(this.txtsenhacad, Guna.UI.Animation.DecorationType.None);
            this.txtsenhacad.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(85)))), ((int)(((byte)(238)))));
            this.txtsenhacad.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtsenhacad.ForeColor = System.Drawing.Color.Gray;
            this.txtsenhacad.LineColor = System.Drawing.Color.DarkGray;
            this.txtsenhacad.Location = new System.Drawing.Point(56, 291);
            this.txtsenhacad.Name = "txtsenhacad";
            this.txtsenhacad.PasswordChar = '●';
            this.txtsenhacad.SelectedText = "";
            this.txtsenhacad.Size = new System.Drawing.Size(290, 32);
            this.txtsenhacad.TabIndex = 1;
            this.txtsenhacad.UseSystemPasswordChar = true;
            this.txtsenhacad.UseWaitCursor = true;
            this.txtsenhacad.Enter += new System.EventHandler(this.txtsenhacad_Enter);
            this.txtsenhacad.Leave += new System.EventHandler(this.txtsenhacad_Leave);
            // 
            // txtcargo
            // 
            this.txtcargo.AccessibleName = "";
            this.txtcargo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.txtcargo.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.animacad.SetDecoration(this.txtcargo, Guna.UI.Animation.DecorationType.None);
            this.txtcargo.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(85)))), ((int)(((byte)(238)))));
            this.txtcargo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtcargo.ForeColor = System.Drawing.Color.Gray;
            this.txtcargo.LineColor = System.Drawing.Color.DarkGray;
            this.txtcargo.Location = new System.Drawing.Point(56, 159);
            this.txtcargo.Name = "txtcargo";
            this.txtcargo.PasswordChar = '\0';
            this.txtcargo.SelectedText = "";
            this.txtcargo.Size = new System.Drawing.Size(290, 32);
            this.txtcargo.TabIndex = 1;
            this.txtcargo.Tag = "";
            this.txtcargo.Text = "Cargo";
            this.txtcargo.UseWaitCursor = true;
            this.txtcargo.Enter += new System.EventHandler(this.txtcargo_Enter);
            this.txtcargo.Leave += new System.EventHandler(this.txtcargo_Leave);
            // 
            // txtemailcad
            // 
            this.txtemailcad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.txtemailcad.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.animacad.SetDecoration(this.txtemailcad, Guna.UI.Animation.DecorationType.None);
            this.txtemailcad.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(85)))), ((int)(((byte)(238)))));
            this.txtemailcad.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtemailcad.ForeColor = System.Drawing.Color.Gray;
            this.txtemailcad.LineColor = System.Drawing.Color.DarkGray;
            this.txtemailcad.Location = new System.Drawing.Point(56, 92);
            this.txtemailcad.Name = "txtemailcad";
            this.txtemailcad.PasswordChar = '\0';
            this.txtemailcad.SelectedText = "";
            this.txtemailcad.Size = new System.Drawing.Size(290, 32);
            this.txtemailcad.TabIndex = 1;
            this.txtemailcad.Text = "E-mail";
            this.txtemailcad.UseWaitCursor = true;
            this.txtemailcad.Enter += new System.EventHandler(this.txtemailcad_Enter);
            this.txtemailcad.Leave += new System.EventHandler(this.txtemailcad_Leave);
            // 
            // plogin
            // 
            this.plogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.plogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.plogin.Controls.Add(this.lbsenha);
            this.plogin.Controls.Add(this.cbsenha);
            this.plogin.Controls.Add(this.lbcad);
            this.plogin.Controls.Add(this.lblsenha);
            this.plogin.Controls.Add(this.lblcadastro);
            this.plogin.Controls.Add(this.btentrar);
            this.plogin.Controls.Add(this.txtsenha);
            this.plogin.Controls.Add(this.txtemail);
            this.animacad.SetDecoration(this.plogin, Guna.UI.Animation.DecorationType.None);
            this.plogin.Location = new System.Drawing.Point(339, 45);
            this.plogin.Name = "plogin";
            this.plogin.Size = new System.Drawing.Size(388, 488);
            this.plogin.TabIndex = 3;
            this.plogin.TabStop = true;
            this.plogin.UseWaitCursor = true;
            // 
            // lbsenha
            // 
            this.lbsenha.AutoSize = true;
            this.animacad.SetDecoration(this.lbsenha, Guna.UI.Animation.DecorationType.None);
            this.lbsenha.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbsenha.ForeColor = System.Drawing.Color.Gray;
            this.lbsenha.Location = new System.Drawing.Point(58, 165);
            this.lbsenha.Name = "lbsenha";
            this.lbsenha.Size = new System.Drawing.Size(39, 15);
            this.lbsenha.TabIndex = 7;
            this.lbsenha.Text = "Senha";
            this.lbsenha.UseWaitCursor = true;
            // 
            // cbsenha
            // 
            this.cbsenha.BaseColor = System.Drawing.Color.White;
            this.cbsenha.CheckedOffColor = System.Drawing.Color.Gray;
            this.cbsenha.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.animacad.SetDecoration(this.cbsenha, Guna.UI.Animation.DecorationType.None);
            this.cbsenha.FillColor = System.Drawing.Color.White;
            this.cbsenha.ForeColor = System.Drawing.Color.Gray;
            this.cbsenha.Location = new System.Drawing.Point(56, 206);
            this.cbsenha.Name = "cbsenha";
            this.cbsenha.Size = new System.Drawing.Size(102, 20);
            this.cbsenha.TabIndex = 6;
            this.cbsenha.Text = "Mostrar senha";
            this.cbsenha.UseWaitCursor = true;
            this.cbsenha.CheckedChanged += new System.EventHandler(this.cbsenha_CheckedChanged);
            // 
            // lbcad
            // 
            this.lbcad.AutoSize = true;
            this.animacad.SetDecoration(this.lbcad, Guna.UI.Animation.DecorationType.None);
            this.lbcad.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbcad.ForeColor = System.Drawing.Color.Gray;
            this.lbcad.Location = new System.Drawing.Point(112, 404);
            this.lbcad.Name = "lbcad";
            this.lbcad.Size = new System.Drawing.Size(118, 15);
            this.lbcad.TabIndex = 4;
            this.lbcad.Text = "Não tem uma conta?";
            this.lbcad.UseWaitCursor = true;
            // 
            // lblsenha
            // 
            this.lblsenha.ActiveLinkColor = System.Drawing.Color.RoyalBlue;
            this.lblsenha.AutoEllipsis = true;
            this.lblsenha.AutoSize = true;
            this.animacad.SetDecoration(this.lblsenha, Guna.UI.Animation.DecorationType.None);
            this.lblsenha.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblsenha.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(85)))), ((int)(((byte)(238)))));
            this.lblsenha.Location = new System.Drawing.Point(258, 211);
            this.lblsenha.Name = "lblsenha";
            this.lblsenha.Size = new System.Drawing.Size(88, 15);
            this.lblsenha.TabIndex = 3;
            this.lblsenha.TabStop = true;
            this.lblsenha.Text = "Redefinir senha";
            this.lblsenha.UseWaitCursor = true;
            // 
            // lblcadastro
            // 
            this.lblcadastro.ActiveLinkColor = System.Drawing.Color.RoyalBlue;
            this.lblcadastro.AutoSize = true;
            this.animacad.SetDecoration(this.lblcadastro, Guna.UI.Animation.DecorationType.None);
            this.lblcadastro.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblcadastro.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(85)))), ((int)(((byte)(238)))));
            this.lblcadastro.Location = new System.Drawing.Point(227, 404);
            this.lblcadastro.Name = "lblcadastro";
            this.lblcadastro.Size = new System.Drawing.Size(69, 15);
            this.lblcadastro.TabIndex = 3;
            this.lblcadastro.TabStop = true;
            this.lblcadastro.Text = "Cadastre-se";
            this.lblcadastro.UseWaitCursor = true;
            this.lblcadastro.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblcadastro_LinkClicked);
            // 
            // btentrar
            // 
            this.btentrar.AnimationHoverSpeed = 0.07F;
            this.btentrar.AnimationSpeed = 0.03F;
            this.btentrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(85)))), ((int)(((byte)(238)))));
            this.btentrar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(85)))), ((int)(((byte)(238)))));
            this.btentrar.BorderColor = System.Drawing.Color.Black;
            this.animacad.SetDecoration(this.btentrar, Guna.UI.Animation.DecorationType.None);
            this.btentrar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btentrar.FocusedColor = System.Drawing.Color.Empty;
            this.btentrar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btentrar.ForeColor = System.Drawing.Color.White;
            this.btentrar.Image = null;
            this.btentrar.ImageSize = new System.Drawing.Size(20, 20);
            this.btentrar.Location = new System.Drawing.Point(56, 288);
            this.btentrar.Name = "btentrar";
            this.btentrar.OnHoverBaseColor = System.Drawing.Color.Silver;
            this.btentrar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btentrar.OnHoverForeColor = System.Drawing.Color.White;
            this.btentrar.OnHoverImage = null;
            this.btentrar.OnPressedColor = System.Drawing.Color.Black;
            this.btentrar.Size = new System.Drawing.Size(290, 42);
            this.btentrar.TabIndex = 2;
            this.btentrar.Text = "Entrar";
            this.btentrar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btentrar.UseWaitCursor = true;
            this.btentrar.Click += new System.EventHandler(this.btentrar_Click);
            // 
            // txtsenha
            // 
            this.txtsenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.txtsenha.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.animacad.SetDecoration(this.txtsenha, Guna.UI.Animation.DecorationType.None);
            this.txtsenha.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(85)))), ((int)(((byte)(238)))));
            this.txtsenha.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtsenha.ForeColor = System.Drawing.Color.Gray;
            this.txtsenha.LineColor = System.Drawing.Color.Silver;
            this.txtsenha.Location = new System.Drawing.Point(56, 156);
            this.txtsenha.Name = "txtsenha";
            this.txtsenha.PasswordChar = '\0';
            this.txtsenha.SelectedText = "";
            this.txtsenha.Size = new System.Drawing.Size(290, 32);
            this.txtsenha.TabIndex = 1;
            this.txtsenha.UseWaitCursor = true;
            this.txtsenha.Enter += new System.EventHandler(this.txtsenha_Enter);
            this.txtsenha.Leave += new System.EventHandler(this.txtsenha_Leave);
            // 
            // txtemail
            // 
            this.txtemail.AccessibleName = "";
            this.txtemail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.txtemail.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.animacad.SetDecoration(this.txtemail, Guna.UI.Animation.DecorationType.None);
            this.txtemail.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(85)))), ((int)(((byte)(238)))));
            this.txtemail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtemail.ForeColor = System.Drawing.Color.Gray;
            this.txtemail.LineColor = System.Drawing.Color.Silver;
            this.txtemail.Location = new System.Drawing.Point(56, 89);
            this.txtemail.Name = "txtemail";
            this.txtemail.PasswordChar = '\0';
            this.txtemail.SelectedText = "";
            this.txtemail.Size = new System.Drawing.Size(290, 32);
            this.txtemail.TabIndex = 1;
            this.txtemail.Tag = "";
            this.txtemail.Text = "E-mail";
            this.txtemail.UseWaitCursor = true;
            this.txtemail.Enter += new System.EventHandler(this.txtemail_Enter);
            this.txtemail.Leave += new System.EventHandler(this.txtemail_Leave);
            // 
            // animaw
            // 
            this.animaw.AnimationType = Guna.UI.WinForms.GunaAnimateWindow.AnimateWindowType.AW_CENTER;
            this.animaw.Interval = 100;
            this.animaw.TargetControl = this;
            // 
            // animacad
            // 
            this.animacad.AnimationType = Guna.UI.Animation.AnimationType.Scale;
            this.animacad.Cursor = null;
            animation6.AnimateOnlyDifferences = true;
            animation6.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation6.BlindCoeff")));
            animation6.LeafCoeff = 0F;
            animation6.MaxTime = 1F;
            animation6.MinTime = 0F;
            animation6.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation6.MosaicCoeff")));
            animation6.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation6.MosaicShift")));
            animation6.MosaicSize = 0;
            animation6.Padding = new System.Windows.Forms.Padding(0);
            animation6.RotateCoeff = 0F;
            animation6.RotateLimit = 0F;
            animation6.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation6.ScaleCoeff")));
            animation6.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation6.SlideCoeff")));
            animation6.TimeCoeff = 0F;
            animation6.TransparencyCoeff = 0F;
            this.animacad.DefaultAnimation = animation6;
            // 
            // txtnome
            // 
            this.txtnome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.txtnome.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.animacad.SetDecoration(this.txtnome, Guna.UI.Animation.DecorationType.None);
            this.txtnome.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(85)))), ((int)(((byte)(238)))));
            this.txtnome.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtnome.ForeColor = System.Drawing.Color.Gray;
            this.txtnome.LineColor = System.Drawing.Color.DarkGray;
            this.txtnome.Location = new System.Drawing.Point(56, 32);
            this.txtnome.Name = "txtnome";
            this.txtnome.PasswordChar = '\0';
            this.txtnome.SelectedText = "";
            this.txtnome.Size = new System.Drawing.Size(290, 32);
            this.txtnome.TabIndex = 1;
            this.txtnome.Text = "Nome completo";
            this.txtnome.UseWaitCursor = true;
            this.txtnome.Enter += new System.EventHandler(this.txtnome_Enter);
            this.txtnome.Leave += new System.EventHandler(this.txtnome_Leave);
            // 
            // txtrecup
            // 
            this.txtrecup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.txtrecup.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.animacad.SetDecoration(this.txtrecup, Guna.UI.Animation.DecorationType.None);
            this.txtrecup.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(85)))), ((int)(((byte)(238)))));
            this.txtrecup.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtrecup.ForeColor = System.Drawing.Color.Gray;
            this.txtrecup.LineColor = System.Drawing.Color.DarkGray;
            this.txtrecup.Location = new System.Drawing.Point(56, 230);
            this.txtrecup.Name = "txtrecup";
            this.txtrecup.PasswordChar = '\0';
            this.txtrecup.SelectedText = "";
            this.txtrecup.Size = new System.Drawing.Size(290, 32);
            this.txtrecup.TabIndex = 1;
            this.txtrecup.Text = "Telefone para recuperação de senha";
            this.txtrecup.UseWaitCursor = true;
            this.txtrecup.Enter += new System.EventHandler(this.txtrecup_Enter);
            this.txtrecup.Leave += new System.EventHandler(this.txtrecup_Leave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(800, 579);
            this.Controls.Add(this.pcadastro);
            this.Controls.Add(this.plogin);
            this.Controls.Add(this.p1);
            this.animacad.SetDecoration(this, Guna.UI.Animation.DecorationType.None);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Enter += new System.EventHandler(this.txtrecup_Enter);
            this.p1.ResumeLayout(false);
            this.p1.PerformLayout();
            this.pcadastro.ResumeLayout(false);
            this.pcadastro.PerformLayout();
            this.plogin.ResumeLayout(false);
            this.plogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Guna.UI.WinForms.GunaPanel p1;
        internal Guna.UI.WinForms.GunaLabel lbnome2;
        internal Guna.UI.WinForms.GunaLabel lbnome3;
        internal Guna.UI.WinForms.GunaLabel lbnome1;
        internal Guna.UI.WinForms.GunaPanel plogin;
        private Guna.UI.WinForms.GunaLineTextBox txtemail;
        private Guna.UI.WinForms.GunaCheckBox cbsenha;
        private Guna.UI.WinForms.GunaLabel lbcad;
        private Guna.UI.WinForms.GunaLinkLabel lblsenha;
        private Guna.UI.WinForms.GunaLinkLabel lblcadastro;
        private Guna.UI.WinForms.GunaButton btentrar;
        private Guna.UI.WinForms.GunaLineTextBox txtsenha;
        private Guna.UI.WinForms.GunaLabel lbconta;
        private Guna.UI.WinForms.GunaLinkLabel lblentrar;
        private Guna.UI.WinForms.GunaButton btcadastro;
        private Guna.UI.WinForms.GunaLineTextBox txtemailcad;
        internal Guna.UI.WinForms.GunaPanel pcadastro;
        private Guna.UI.WinForms.GunaLineTextBox txtsenhacad;
        private Guna.UI.WinForms.GunaLineTextBox txtcargo;
        private Guna.UI.WinForms.GunaCheckBox lbtermos;
        private Guna.UI.WinForms.GunaTransition animacad;
        private Guna.UI.WinForms.GunaControlBox controlb;
        private Guna.UI.WinForms.GunaAnimateWindow animaw;
        private Guna.UI.WinForms.GunaSwitch btswitch;
        private Guna.UI.WinForms.GunaLabel lbsenha;
        private Guna.UI.WinForms.GunaLabel lbsenhacad;
        private Guna.UI.WinForms.GunaLineTextBox txtrecup;
        private Guna.UI.WinForms.GunaLineTextBox txtnome;
    }
}

