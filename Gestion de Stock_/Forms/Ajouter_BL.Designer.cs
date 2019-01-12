namespace Gestion_de_Stock_.Forms
{
    partial class Ajouter_BL
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            AnimatorNS.Animation animation2 = new AnimatorNS.Animation();
            AnimatorNS.Animation animation1 = new AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ajouter_BL));
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuCheckbox1 = new Bunifu.Framework.UI.BunifuCheckbox();
            this.txtDevis = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCheck = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Ref = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Prix_vente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TXREMISE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PU_HT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PU_TTC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BTN = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.ComboClient = new System.Windows.Forms.ComboBox();
            this.txtObserv = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNumBL = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlExit = new System.Windows.Forms.Panel();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.animator1 = new AnimatorNS.Animator(this.components);
            this.animator2 = new AnimatorNS.Animator(this.components);
            this.pnlContainer.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.pnlLogo.SuspendLayout();
            this.pnlExit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlContainer
            // 
            this.pnlContainer.Controls.Add(this.groupBox3);
            this.pnlContainer.Controls.Add(this.groupBox2);
            this.pnlContainer.Controls.Add(this.groupBox1);
            this.pnlContainer.Controls.Add(this.bunifuFlatButton2);
            this.pnlContainer.Controls.Add(this.bunifuFlatButton1);
            this.animator2.SetDecoration(this.pnlContainer, AnimatorNS.DecorationType.None);
            this.animator1.SetDecoration(this.pnlContainer, AnimatorNS.DecorationType.None);
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainer.Location = new System.Drawing.Point(0, 127);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(792, 364);
            this.pnlContainer.TabIndex = 18;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnSearch);
            this.groupBox3.Controls.Add(this.bunifuCheckbox1);
            this.groupBox3.Controls.Add(this.txtDevis);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.lblCheck);
            this.animator2.SetDecoration(this.groupBox3, AnimatorNS.DecorationType.None);
            this.animator1.SetDecoration(this.groupBox3, AnimatorNS.DecorationType.None);
            this.groupBox3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(13, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(772, 42);
            this.groupBox3.TabIndex = 44;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ajouter Par un Devis";
            // 
            // btnSearch
            // 
            this.btnSearch.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearch.BorderRadius = 0;
            this.btnSearch.ButtonText = "Recherche";
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator2.SetDecoration(this.btnSearch, AnimatorNS.DecorationType.None);
            this.animator1.SetDecoration(this.btnSearch, AnimatorNS.DecorationType.None);
            this.btnSearch.DisabledColor = System.Drawing.Color.Gray;
            this.btnSearch.Enabled = false;
            this.btnSearch.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSearch.Iconimage = null;
            this.btnSearch.Iconimage_right = null;
            this.btnSearch.Iconimage_right_Selected = null;
            this.btnSearch.Iconimage_Selected = null;
            this.btnSearch.IconMarginLeft = 0;
            this.btnSearch.IconMarginRight = 0;
            this.btnSearch.IconRightVisible = true;
            this.btnSearch.IconRightZoom = 0D;
            this.btnSearch.IconVisible = true;
            this.btnSearch.IconZoom = 90D;
            this.btnSearch.IsTab = false;
            this.btnSearch.Location = new System.Drawing.Point(667, 14);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSearch.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnSearch.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSearch.selected = false;
            this.btnSearch.Size = new System.Drawing.Size(79, 24);
            this.btnSearch.TabIndex = 43;
            this.btnSearch.Text = "Recherche";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSearch.Textcolor = System.Drawing.Color.White;
            this.btnSearch.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Click += new System.EventHandler(this.bunifuFlatButton3_Click);
            // 
            // bunifuCheckbox1
            // 
            this.bunifuCheckbox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.bunifuCheckbox1.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.bunifuCheckbox1.Checked = false;
            this.bunifuCheckbox1.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.animator1.SetDecoration(this.bunifuCheckbox1, AnimatorNS.DecorationType.None);
            this.animator2.SetDecoration(this.bunifuCheckbox1, AnimatorNS.DecorationType.None);
            this.bunifuCheckbox1.ForeColor = System.Drawing.Color.White;
            this.bunifuCheckbox1.Location = new System.Drawing.Point(175, 15);
            this.bunifuCheckbox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bunifuCheckbox1.Name = "bunifuCheckbox1";
            this.bunifuCheckbox1.Size = new System.Drawing.Size(20, 20);
            this.bunifuCheckbox1.TabIndex = 42;
            this.bunifuCheckbox1.OnChange += new System.EventHandler(this.bunifuCheckbox1_OnChange);
            // 
            // txtDevis
            // 
            this.animator1.SetDecoration(this.txtDevis, AnimatorNS.DecorationType.None);
            this.animator2.SetDecoration(this.txtDevis, AnimatorNS.DecorationType.None);
            this.txtDevis.Enabled = false;
            this.txtDevis.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtDevis.Location = new System.Drawing.Point(476, 15);
            this.txtDevis.Name = "txtDevis";
            this.txtDevis.Size = new System.Drawing.Size(166, 23);
            this.txtDevis.TabIndex = 41;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.animator1.SetDecoration(this.label4, AnimatorNS.DecorationType.None);
            this.animator2.SetDecoration(this.label4, AnimatorNS.DecorationType.None);
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(380, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 20);
            this.label4.TabIndex = 40;
            this.label4.Text = "Num Devis";
            // 
            // lblCheck
            // 
            this.lblCheck.AutoSize = true;
            this.animator1.SetDecoration(this.lblCheck, AnimatorNS.DecorationType.None);
            this.animator2.SetDecoration(this.lblCheck, AnimatorNS.DecorationType.None);
            this.lblCheck.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheck.Location = new System.Drawing.Point(197, 15);
            this.lblCheck.Name = "lblCheck";
            this.lblCheck.Size = new System.Drawing.Size(36, 20);
            this.lblCheck.TabIndex = 37;
            this.lblCheck.Text = "OFF";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.animator2.SetDecoration(this.groupBox2, AnimatorNS.DecorationType.None);
            this.animator1.SetDecoration(this.groupBox2, AnimatorNS.DecorationType.None);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(13, 126);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(772, 192);
            this.groupBox2.TabIndex = 38;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detail BL";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ref,
            this.Prix_vente,
            this.Qte,
            this.TXREMISE,
            this.PU_HT,
            this.PU_TTC,
            this.BTN});
            this.animator2.SetDecoration(this.dataGridView1, AnimatorNS.DecorationType.None);
            this.animator1.SetDecoration(this.dataGridView1, AnimatorNS.DecorationType.None);
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(6, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 5;
            this.dataGridView1.Size = new System.Drawing.Size(760, 164);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            this.dataGridView1.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dataGridView1_EditingControlShowing);
            // 
            // Ref
            // 
            this.Ref.DropDownWidth = 300;
            this.Ref.FillWeight = 200F;
            this.Ref.HeaderText = "Articles";
            this.Ref.Name = "Ref";
            // 
            // Prix_vente
            // 
            this.Prix_vente.FillWeight = 45F;
            this.Prix_vente.HeaderText = "Prix Vente";
            this.Prix_vente.Name = "Prix_vente";
            this.Prix_vente.ReadOnly = true;
            // 
            // Qte
            // 
            this.Qte.FillWeight = 25F;
            this.Qte.HeaderText = "Qte";
            this.Qte.Name = "Qte";
            // 
            // TXREMISE
            // 
            this.TXREMISE.FillWeight = 35F;
            this.TXREMISE.HeaderText = "% Remise";
            this.TXREMISE.Name = "TXREMISE";
            // 
            // PU_HT
            // 
            this.PU_HT.FillWeight = 47.19006F;
            this.PU_HT.HeaderText = "Prix HT";
            this.PU_HT.Name = "PU_HT";
            this.PU_HT.ReadOnly = true;
            // 
            // PU_TTC
            // 
            this.PU_TTC.FillWeight = 41.77816F;
            this.PU_TTC.HeaderText = "Prix TTC";
            this.PU_TTC.Name = "PU_TTC";
            this.PU_TTC.ReadOnly = true;
            // 
            // BTN
            // 
            this.BTN.FillWeight = 33F;
            this.BTN.HeaderText = "Delete";
            this.BTN.Name = "BTN";
            this.BTN.Text = "Delete";
            this.BTN.UseColumnTextForButtonValue = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bunifuSeparator2);
            this.groupBox1.Controls.Add(this.bunifuSeparator1);
            this.groupBox1.Controls.Add(this.ComboClient);
            this.groupBox1.Controls.Add(this.txtObserv);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtNumBL);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.animator2.SetDecoration(this.groupBox1, AnimatorNS.DecorationType.None);
            this.animator1.SetDecoration(this.groupBox1, AnimatorNS.DecorationType.None);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(772, 83);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "BL";
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.animator2.SetDecoration(this.bunifuSeparator2, AnimatorNS.DecorationType.None);
            this.animator1.SetDecoration(this.bunifuSeparator2, AnimatorNS.DecorationType.None);
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator2.LineThickness = 21;
            this.bunifuSeparator2.Location = new System.Drawing.Point(507, 17);
            this.bunifuSeparator2.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(5, 35);
            this.bunifuSeparator2.TabIndex = 43;
            this.bunifuSeparator2.Transparency = 255;
            this.bunifuSeparator2.Vertical = true;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.animator2.SetDecoration(this.bunifuSeparator1, AnimatorNS.DecorationType.None);
            this.animator1.SetDecoration(this.bunifuSeparator1, AnimatorNS.DecorationType.None);
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 21;
            this.bunifuSeparator1.Location = new System.Drawing.Point(258, 17);
            this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(5, 35);
            this.bunifuSeparator1.TabIndex = 43;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = true;
            // 
            // ComboClient
            // 
            this.animator2.SetDecoration(this.ComboClient, AnimatorNS.DecorationType.None);
            this.animator1.SetDecoration(this.ComboClient, AnimatorNS.DecorationType.None);
            this.ComboClient.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ComboClient.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboClient.FormattingEnabled = true;
            this.ComboClient.Location = new System.Drawing.Point(338, 20);
            this.ComboClient.Name = "ComboClient";
            this.ComboClient.Size = new System.Drawing.Size(166, 25);
            this.ComboClient.TabIndex = 42;
            // 
            // txtObserv
            // 
            this.animator1.SetDecoration(this.txtObserv, AnimatorNS.DecorationType.None);
            this.animator2.SetDecoration(this.txtObserv, AnimatorNS.DecorationType.None);
            this.txtObserv.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtObserv.Location = new System.Drawing.Point(616, 20);
            this.txtObserv.Multiline = true;
            this.txtObserv.Name = "txtObserv";
            this.txtObserv.Size = new System.Drawing.Size(152, 62);
            this.txtObserv.TabIndex = 41;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.animator1.SetDecoration(this.label5, AnimatorNS.DecorationType.None);
            this.animator2.SetDecoration(this.label5, AnimatorNS.DecorationType.None);
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(510, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 20);
            this.label5.TabIndex = 40;
            this.label5.Text = "Observation";
            // 
            // txtNumBL
            // 
            this.animator1.SetDecoration(this.txtNumBL, AnimatorNS.DecorationType.None);
            this.animator2.SetDecoration(this.txtNumBL, AnimatorNS.DecorationType.None);
            this.txtNumBL.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtNumBL.Location = new System.Drawing.Point(88, 22);
            this.txtNumBL.Name = "txtNumBL";
            this.txtNumBL.ReadOnly = true;
            this.txtNumBL.Size = new System.Drawing.Size(166, 23);
            this.txtNumBL.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.animator1.SetDecoration(this.label2, AnimatorNS.DecorationType.None);
            this.animator2.SetDecoration(this.label2, AnimatorNS.DecorationType.None);
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(263, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 38;
            this.label2.Text = "ID Client";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.animator1.SetDecoration(this.label3, AnimatorNS.DecorationType.None);
            this.animator2.SetDecoration(this.label3, AnimatorNS.DecorationType.None);
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 37;
            this.label3.Text = "Num BL";
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(81)))), ((int)(((byte)(69)))));
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
            this.bunifuFlatButton2.IconZoom = 70D;
            this.bunifuFlatButton2.IsTab = false;
            this.bunifuFlatButton2.Location = new System.Drawing.Point(601, 320);
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
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
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
            this.bunifuFlatButton1.IconZoom = 70D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(428, 320);
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
            this.pnlLogo.Size = new System.Drawing.Size(792, 107);
            this.pnlLogo.TabIndex = 17;
            // 
            // lblDate
            // 
            this.lblDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDate.AutoSize = true;
            this.animator1.SetDecoration(this.lblDate, AnimatorNS.DecorationType.None);
            this.animator2.SetDecoration(this.lblDate, AnimatorNS.DecorationType.None);
            this.lblDate.Font = new System.Drawing.Font("Lane - Upper", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(50)))), ((int)(((byte)(74)))));
            this.lblDate.Location = new System.Drawing.Point(662, 64);
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
            this.lblTime.Location = new System.Drawing.Point(592, 7);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(203, 57);
            this.lblTime.TabIndex = 0;
            this.lblTime.Text = "14:23:55";
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
            this.pnlExit.Location = new System.Drawing.Point(792, 20);
            this.pnlExit.Name = "pnlExit";
            this.pnlExit.Size = new System.Drawing.Size(40, 471);
            this.pnlExit.TabIndex = 16;
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.BackColor = System.Drawing.Color.Transparent;
            this.animator2.SetDecoration(this.bunifuImageButton2, AnimatorNS.DecorationType.None);
            this.animator1.SetDecoration(this.bunifuImageButton2, AnimatorNS.DecorationType.None);
            this.bunifuImageButton2.Image = global::Gestion_de_Stock_.Properties.Resources.Minus_96px;
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(-2, 51);
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
            this.bunifuImageButton1.Location = new System.Drawing.Point(-2, 5);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(46, 46);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 0;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
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
            this.pnlHeader.TabIndex = 15;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 10;
            this.bunifuElipse2.TargetControl = this;
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
            this.animator1.AnimationType = AnimatorNS.AnimationType.VertSlide;
            this.animator1.Cursor = null;
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
            this.animator1.DefaultAnimation = animation2;
            // 
            // animator2
            // 
            this.animator2.AnimationType = AnimatorNS.AnimationType.VertSlide;
            this.animator2.Cursor = null;
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
            animation1.TransparencyCoeff = 0F;
            this.animator2.DefaultAnimation = animation1;
            this.animator2.Interval = 15;
            // 
            // Ajouter_BL
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
            this.Name = "Ajouter_BL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ajouter_BL";
            this.Load += new System.EventHandler(this.Ajouter_BL_Load);
            this.pnlContainer.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnlLogo.ResumeLayout(false);
            this.pnlLogo.PerformLayout();
            this.pnlExit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlContainer;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewComboBoxColumn Ref;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prix_vente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qte;
        private System.Windows.Forms.DataGridViewTextBoxColumn TXREMISE;
        private System.Windows.Forms.DataGridViewTextBoxColumn PU_HT;
        private System.Windows.Forms.DataGridViewTextBoxColumn PU_TTC;
        private System.Windows.Forms.DataGridViewButtonColumn BTN;
        private System.Windows.Forms.GroupBox groupBox1;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        public System.Windows.Forms.ComboBox ComboClient;
        private System.Windows.Forms.TextBox txtObserv;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNumBL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlExit;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.Panel pnlHeader;
        private AnimatorNS.Animator animator2;
        private AnimatorNS.Animator animator1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDevis;
        private Bunifu.Framework.UI.BunifuCheckbox bunifuCheckbox1;
        private System.Windows.Forms.Label lblCheck;
        private Bunifu.Framework.UI.BunifuFlatButton btnSearch;
    }
}