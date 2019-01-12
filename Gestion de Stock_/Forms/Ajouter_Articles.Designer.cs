namespace Gestion_de_Stock_.Forms
{
    partial class Ajouter_Articles
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
            AnimatorNS.Animation animation1 = new AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ajouter_Articles));
            AnimatorNS.Animation animation2 = new AnimatorNS.Animation();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlExit = new System.Windows.Forms.Panel();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtRef = new System.Windows.Forms.TextBox();
            this.txtTVA = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtQte = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPrixVente = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtdesc = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMarge = new System.Windows.Forms.TextBox();
            this.txtPrixAchat = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ComboFamille = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.animator1 = new AnimatorNS.Animator(this.components);
            this.animator2 = new AnimatorNS.Animator(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pnlLogo.SuspendLayout();
            this.pnlExit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.pnlContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLogo
            // 
            this.pnlLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(236)))));
            this.pnlLogo.Controls.Add(this.lblDate);
            this.pnlLogo.Controls.Add(this.lblTime);
            this.pnlLogo.Controls.Add(this.label1);
            this.animator2.SetDecoration(this.pnlLogo, AnimatorNS.DecorationType.None);
            this.animator1.SetDecoration(this.pnlLogo, AnimatorNS.DecorationType.None);
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogo.Location = new System.Drawing.Point(0, 20);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(791, 107);
            this.pnlLogo.TabIndex = 5;
            // 
            // lblDate
            // 
            this.lblDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDate.AutoSize = true;
            this.animator1.SetDecoration(this.lblDate, AnimatorNS.DecorationType.None);
            this.animator2.SetDecoration(this.lblDate, AnimatorNS.DecorationType.None);
            this.lblDate.Font = new System.Drawing.Font("Lane - Upper", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(50)))), ((int)(((byte)(74)))));
            this.lblDate.Location = new System.Drawing.Point(661, 64);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(133, 29);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "Fiver House";
            // 
            // lblTime
            // 
            this.lblTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTime.AutoSize = true;
            this.animator1.SetDecoration(this.lblTime, AnimatorNS.DecorationType.None);
            this.animator2.SetDecoration(this.lblTime, AnimatorNS.DecorationType.None);
            this.lblTime.Font = new System.Drawing.Font("Lane - Upper", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(50)))), ((int)(((byte)(74)))));
            this.lblTime.Location = new System.Drawing.Point(591, 7);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(0, 57);
            this.lblTime.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.animator1.SetDecoration(this.label1, AnimatorNS.DecorationType.None);
            this.animator2.SetDecoration(this.label1, AnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Lane - Upper", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(50)))), ((int)(((byte)(74)))));
            this.label1.Location = new System.Drawing.Point(3, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 57);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fiver House";
            // 
            // pnlExit
            // 
            this.pnlExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.pnlExit.Controls.Add(this.bunifuImageButton2);
            this.pnlExit.Controls.Add(this.bunifuImageButton1);
            this.animator2.SetDecoration(this.pnlExit, AnimatorNS.DecorationType.None);
            this.animator1.SetDecoration(this.pnlExit, AnimatorNS.DecorationType.None);
            this.pnlExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlExit.Location = new System.Drawing.Point(791, 20);
            this.pnlExit.Name = "pnlExit";
            this.pnlExit.Size = new System.Drawing.Size(41, 471);
            this.pnlExit.TabIndex = 4;
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.BackColor = System.Drawing.Color.Transparent;
            this.animator2.SetDecoration(this.bunifuImageButton2, AnimatorNS.DecorationType.None);
            this.animator1.SetDecoration(this.bunifuImageButton2, AnimatorNS.DecorationType.None);
            this.bunifuImageButton2.Image = global::Gestion_de_Stock_.Properties.Resources.Minus_96px;
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(-4, 53);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(48, 48);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bunifuImageButton2.TabIndex = 1;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 10;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.animator2.SetDecoration(this.bunifuImageButton1, AnimatorNS.DecorationType.None);
            this.animator1.SetDecoration(this.bunifuImageButton1, AnimatorNS.DecorationType.None);
            this.bunifuImageButton1.Image = global::Gestion_de_Stock_.Properties.Resources.Back_Arrow_96px;
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(-3, 7);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(46, 46);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 0;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.animator2.SetDecoration(this.pnlHeader, AnimatorNS.DecorationType.None);
            this.animator1.SetDecoration(this.pnlHeader, AnimatorNS.DecorationType.None);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(832, 20);
            this.pnlHeader.TabIndex = 3;
            // 
            // pnlContainer
            // 
            this.pnlContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlContainer.Controls.Add(this.bunifuFlatButton2);
            this.pnlContainer.Controls.Add(this.bunifuFlatButton1);
            this.pnlContainer.Controls.Add(this.txtRef);
            this.pnlContainer.Controls.Add(this.txtTVA);
            this.pnlContainer.Controls.Add(this.label9);
            this.pnlContainer.Controls.Add(this.txtQte);
            this.pnlContainer.Controls.Add(this.label8);
            this.pnlContainer.Controls.Add(this.txtPrixVente);
            this.pnlContainer.Controls.Add(this.label7);
            this.pnlContainer.Controls.Add(this.txtdesc);
            this.pnlContainer.Controls.Add(this.label6);
            this.pnlContainer.Controls.Add(this.txtMarge);
            this.pnlContainer.Controls.Add(this.txtPrixAchat);
            this.pnlContainer.Controls.Add(this.label5);
            this.pnlContainer.Controls.Add(this.label2);
            this.pnlContainer.Controls.Add(this.ComboFamille);
            this.pnlContainer.Controls.Add(this.label4);
            this.pnlContainer.Controls.Add(this.label3);
            this.animator2.SetDecoration(this.pnlContainer, AnimatorNS.DecorationType.None);
            this.animator1.SetDecoration(this.pnlContainer, AnimatorNS.DecorationType.None);
            this.pnlContainer.Location = new System.Drawing.Point(0, 127);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(791, 364);
            this.pnlContainer.TabIndex = 6;
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(81)))), ((int)(((byte)(69)))));
            this.bunifuFlatButton2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuFlatButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(81)))), ((int)(((byte)(69)))));
            this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton2.BorderRadius = 0;
            this.bunifuFlatButton2.ButtonText = "   Effacer les Champs";
            this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator2.SetDecoration(this.bunifuFlatButton2, AnimatorNS.DecorationType.None);
            this.animator1.SetDecoration(this.bunifuFlatButton2, AnimatorNS.DecorationType.None);
            this.bunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.Iconimage = global::Gestion_de_Stock_.Properties.Resources.icons8_Clear_Symbol_96px_1;
            this.bunifuFlatButton2.Iconimage_right = null;
            this.bunifuFlatButton2.Iconimage_right_Selected = null;
            this.bunifuFlatButton2.Iconimage_Selected = null;
            this.bunifuFlatButton2.IconMarginLeft = 0;
            this.bunifuFlatButton2.IconMarginRight = 0;
            this.bunifuFlatButton2.IconRightVisible = true;
            this.bunifuFlatButton2.IconRightZoom = 0D;
            this.bunifuFlatButton2.IconVisible = true;
            this.bunifuFlatButton2.IconZoom = 90D;
            this.bunifuFlatButton2.IsTab = false;
            this.bunifuFlatButton2.Location = new System.Drawing.Point(572, 298);
            this.bunifuFlatButton2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(81)))), ((int)(((byte)(69)))));
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(139)))), ((int)(((byte)(131)))));
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(184, 44);
            this.bunifuFlatButton2.TabIndex = 34;
            this.bunifuFlatButton2.Text = "   Effacer les Champs";
            this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton2.Click += new System.EventHandler(this.bunifuFlatButton2_Click);
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "    Ajouter";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator2.SetDecoration(this.bunifuFlatButton1, AnimatorNS.DecorationType.None);
            this.animator1.SetDecoration(this.bunifuFlatButton1, AnimatorNS.DecorationType.None);
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = global::Gestion_de_Stock_.Properties.Resources.icons8_Plus_96px;
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(399, 298);
            this.bunifuFlatButton1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(141, 44);
            this.bunifuFlatButton1.TabIndex = 35;
            this.bunifuFlatButton1.Text = "    Ajouter";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click_1);
            // 
            // txtRef
            // 
            this.txtRef.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.animator1.SetDecoration(this.txtRef, AnimatorNS.DecorationType.None);
            this.animator2.SetDecoration(this.txtRef, AnimatorNS.DecorationType.None);
            this.txtRef.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtRef.Location = new System.Drawing.Point(191, 31);
            this.txtRef.MaxLength = 300;
            this.txtRef.Name = "txtRef";
            this.txtRef.Size = new System.Drawing.Size(166, 23);
            this.txtRef.TabIndex = 33;
            // 
            // txtTVA
            // 
            this.txtTVA.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.animator1.SetDecoration(this.txtTVA, AnimatorNS.DecorationType.None);
            this.animator2.SetDecoration(this.txtTVA, AnimatorNS.DecorationType.None);
            this.txtTVA.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtTVA.Location = new System.Drawing.Point(191, 254);
            this.txtTVA.MaxLength = 3;
            this.txtTVA.Name = "txtTVA";
            this.txtTVA.Size = new System.Drawing.Size(166, 23);
            this.txtTVA.TabIndex = 33;
            this.txtTVA.TextChanged += new System.EventHandler(this.txtTVA_TextChanged);
            this.txtTVA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrixAchat_KeyPress);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.animator1.SetDecoration(this.label9, AnimatorNS.DecorationType.None);
            this.animator2.SetDecoration(this.label9, AnimatorNS.DecorationType.None);
            this.label9.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(89, 201);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 20);
            this.label9.TabIndex = 31;
            this.label9.Text = "Marge";
            // 
            // txtQte
            // 
            this.txtQte.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.animator1.SetDecoration(this.txtQte, AnimatorNS.DecorationType.None);
            this.animator2.SetDecoration(this.txtQte, AnimatorNS.DecorationType.None);
            this.txtQte.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtQte.Location = new System.Drawing.Point(560, 178);
            this.txtQte.Name = "txtQte";
            this.txtQte.Size = new System.Drawing.Size(166, 23);
            this.txtQte.TabIndex = 32;
            this.txtQte.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrixAchat_KeyPress);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.animator1.SetDecoration(this.label8, AnimatorNS.DecorationType.None);
            this.animator2.SetDecoration(this.label8, AnimatorNS.DecorationType.None);
            this.label8.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(89, 257);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 20);
            this.label8.TabIndex = 31;
            this.label8.Text = "Taux TVA";
            // 
            // txtPrixVente
            // 
            this.txtPrixVente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.animator1.SetDecoration(this.txtPrixVente, AnimatorNS.DecorationType.None);
            this.animator2.SetDecoration(this.txtPrixVente, AnimatorNS.DecorationType.None);
            this.txtPrixVente.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtPrixVente.Location = new System.Drawing.Point(191, 149);
            this.txtPrixVente.Name = "txtPrixVente";
            this.txtPrixVente.Size = new System.Drawing.Size(166, 23);
            this.txtPrixVente.TabIndex = 29;
            this.txtPrixVente.Text = "0";
            this.txtPrixVente.TextChanged += new System.EventHandler(this.txtPrixVente_TextChanged);
            this.txtPrixVente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrixAchat_KeyPress);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.animator1.SetDecoration(this.label7, AnimatorNS.DecorationType.None);
            this.animator2.SetDecoration(this.label7, AnimatorNS.DecorationType.None);
            this.label7.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(470, 180);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 20);
            this.label7.TabIndex = 27;
            this.label7.Text = "Quantité";
            // 
            // txtdesc
            // 
            this.txtdesc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.animator1.SetDecoration(this.txtdesc, AnimatorNS.DecorationType.None);
            this.animator2.SetDecoration(this.txtdesc, AnimatorNS.DecorationType.None);
            this.txtdesc.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtdesc.Location = new System.Drawing.Point(560, 86);
            this.txtdesc.Multiline = true;
            this.txtdesc.Name = "txtdesc";
            this.txtdesc.Size = new System.Drawing.Size(166, 62);
            this.txtdesc.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.animator1.SetDecoration(this.label6, AnimatorNS.DecorationType.None);
            this.animator2.SetDecoration(this.label6, AnimatorNS.DecorationType.None);
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(76, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 20);
            this.label6.TabIndex = 28;
            this.label6.Text = "Prix Vente";
            // 
            // txtMarge
            // 
            this.txtMarge.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.animator1.SetDecoration(this.txtMarge, AnimatorNS.DecorationType.None);
            this.animator2.SetDecoration(this.txtMarge, AnimatorNS.DecorationType.None);
            this.txtMarge.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtMarge.Location = new System.Drawing.Point(191, 201);
            this.txtMarge.Name = "txtMarge";
            this.txtMarge.ReadOnly = true;
            this.txtMarge.Size = new System.Drawing.Size(166, 23);
            this.txtMarge.TabIndex = 26;
            // 
            // txtPrixAchat
            // 
            this.txtPrixAchat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.animator1.SetDecoration(this.txtPrixAchat, AnimatorNS.DecorationType.None);
            this.animator2.SetDecoration(this.txtPrixAchat, AnimatorNS.DecorationType.None);
            this.txtPrixAchat.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtPrixAchat.Location = new System.Drawing.Point(191, 86);
            this.txtPrixAchat.Name = "txtPrixAchat";
            this.txtPrixAchat.Size = new System.Drawing.Size(166, 23);
            this.txtPrixAchat.TabIndex = 26;
            this.txtPrixAchat.Text = "0";
            this.txtPrixAchat.TextChanged += new System.EventHandler(this.txtPrixAchat_TextChanged);
            this.txtPrixAchat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrixAchat_KeyPress);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.animator1.SetDecoration(this.label5, AnimatorNS.DecorationType.None);
            this.animator2.SetDecoration(this.label5, AnimatorNS.DecorationType.None);
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(76, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 20);
            this.label5.TabIndex = 25;
            this.label5.Text = "Prix Achat";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.animator1.SetDecoration(this.label2, AnimatorNS.DecorationType.None);
            this.animator2.SetDecoration(this.label2, AnimatorNS.DecorationType.None);
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(421, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 20);
            this.label2.TabIndex = 23;
            this.label2.Text = "Famille d\'Article";
            // 
            // ComboFamille
            // 
            this.ComboFamille.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.animator2.SetDecoration(this.ComboFamille, AnimatorNS.DecorationType.None);
            this.animator1.SetDecoration(this.ComboFamille, AnimatorNS.DecorationType.None);
            this.ComboFamille.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ComboFamille.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboFamille.FormattingEnabled = true;
            this.ComboFamille.Location = new System.Drawing.Point(560, 26);
            this.ComboFamille.Name = "ComboFamille";
            this.ComboFamille.Size = new System.Drawing.Size(166, 25);
            this.ComboFamille.TabIndex = 22;
            this.ComboFamille.SelectionChangeCommitted += new System.EventHandler(this.ComboFamille_SelectionChangeCommitted);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.animator1.SetDecoration(this.label4, AnimatorNS.DecorationType.None);
            this.animator2.SetDecoration(this.label4, AnimatorNS.DecorationType.None);
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(449, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 20);
            this.label4.TabIndex = 20;
            this.label4.Text = "Description";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.animator1.SetDecoration(this.label3, AnimatorNS.DecorationType.None);
            this.animator2.SetDecoration(this.label3, AnimatorNS.DecorationType.None);
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = "Article Réference";
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.pnlHeader;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuDragControl2
            // 
            this.bunifuDragControl2.Fixed = true;
            this.bunifuDragControl2.Horizontal = true;
            this.bunifuDragControl2.TargetControl = this.pnlExit;
            this.bunifuDragControl2.Vertical = true;
            // 
            // animator1
            // 
            this.animator1.AnimationType = AnimatorNS.AnimationType.Transparent;
            this.animator1.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 1F;
            this.animator1.DefaultAnimation = animation1;
            // 
            // animator2
            // 
            this.animator2.AnimationType = AnimatorNS.AnimationType.VertSlide;
            this.animator2.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            this.animator2.DefaultAnimation = animation2;
            this.animator2.Interval = 15;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 10;
            this.bunifuElipse2.TargetControl = this;
            // 
            // Ajouter_Articles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 491);
            this.Controls.Add(this.pnlContainer);
            this.Controls.Add(this.pnlLogo);
            this.Controls.Add(this.pnlExit);
            this.Controls.Add(this.pnlHeader);
            this.animator1.SetDecoration(this, AnimatorNS.DecorationType.None);
            this.animator2.SetDecoration(this, AnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Ajouter_Articles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ajouter_Articles";
            this.pnlLogo.ResumeLayout(false);
            this.pnlLogo.PerformLayout();
            this.pnlExit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.pnlContainer.ResumeLayout(false);
            this.pnlContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlExit;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.Panel pnlHeader;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
        private System.Windows.Forms.Panel pnlContainer;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private System.Windows.Forms.TextBox txtTVA;
        private System.Windows.Forms.TextBox txtQte;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPrixVente;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtdesc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPrixAchat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.ComboBox ComboFamille;
        private AnimatorNS.Animator animator1;
        private AnimatorNS.Animator animator2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private System.Windows.Forms.TextBox txtRef;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMarge;
    }
}