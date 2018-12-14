namespace Gestion_de_Stock_.Forms
{
    partial class Reglement_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reglement_Form));
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxClient = new System.Windows.Forms.ComboBox();
            this.txtNumFact = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.lblAncienRestPayer = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.lblAncienTotalReg = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.lblMontant = new System.Windows.Forms.Label();
            this.lblNumReg = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label19 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lblRestPayer = new System.Windows.Forms.Label();
            this.lblTotalReg = new System.Windows.Forms.Label();
            this.datetimepickerECH = new System.Windows.Forms.DateTimePicker();
            this.comboBoxArticle = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label55 = new System.Windows.Forms.Label();
            this.txtPayer = new System.Windows.Forms.TextBox();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlExit = new System.Windows.Forms.Panel();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.animator1 = new AnimatorNS.Animator(this.components);
            this.animator2 = new AnimatorNS.Animator(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Type_Reg = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Qte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateECH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TXREMISE = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.PU_HT = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.pnlContainer.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pnlLogo.SuspendLayout();
            this.pnlExit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlContainer
            // 
            this.pnlContainer.Controls.Add(this.groupBox1);
            this.pnlContainer.Controls.Add(this.groupBox2);
            this.animator2.SetDecoration(this.pnlContainer, AnimatorNS.DecorationType.None);
            this.animator1.SetDecoration(this.pnlContainer, AnimatorNS.DecorationType.None);
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainer.Location = new System.Drawing.Point(0, 121);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(792, 422);
            this.pnlContainer.TabIndex = 22;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxClient);
            this.groupBox1.Controls.Add(this.txtNumFact);
            this.groupBox1.Controls.Add(this.label24);
            this.groupBox1.Controls.Add(this.label25);
            this.groupBox1.Controls.Add(this.label26);
            this.groupBox1.Controls.Add(this.lblAncienRestPayer);
            this.groupBox1.Controls.Add(this.label28);
            this.groupBox1.Controls.Add(this.lblAncienTotalReg);
            this.groupBox1.Controls.Add(this.label30);
            this.groupBox1.Controls.Add(this.lblMontant);
            this.groupBox1.Controls.Add(this.lblNumReg);
            this.groupBox1.Controls.Add(this.label33);
            this.animator2.SetDecoration(this.groupBox1, AnimatorNS.DecorationType.None);
            this.animator1.SetDecoration(this.groupBox1, AnimatorNS.DecorationType.None);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(4, -2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(772, 95);
            this.groupBox1.TabIndex = 49;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Reglement";
            // 
            // comboBoxClient
            // 
            this.animator2.SetDecoration(this.comboBoxClient, AnimatorNS.DecorationType.None);
            this.animator1.SetDecoration(this.comboBoxClient, AnimatorNS.DecorationType.None);
            this.comboBoxClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxClient.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxClient.FormattingEnabled = true;
            this.comboBoxClient.Location = new System.Drawing.Point(549, 23);
            this.comboBoxClient.Name = "comboBoxClient";
            this.comboBoxClient.Size = new System.Drawing.Size(166, 25);
            this.comboBoxClient.TabIndex = 60;
            // 
            // txtNumFact
            // 
            this.animator1.SetDecoration(this.txtNumFact, AnimatorNS.DecorationType.None);
            this.animator2.SetDecoration(this.txtNumFact, AnimatorNS.DecorationType.None);
            this.txtNumFact.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtNumFact.Location = new System.Drawing.Point(292, 23);
            this.txtNumFact.Name = "txtNumFact";
            this.txtNumFact.ReadOnly = true;
            this.txtNumFact.Size = new System.Drawing.Size(166, 23);
            this.txtNumFact.TabIndex = 59;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.animator1.SetDecoration(this.label24, AnimatorNS.DecorationType.None);
            this.animator2.SetDecoration(this.label24, AnimatorNS.DecorationType.None);
            this.label24.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(492, 23);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(51, 20);
            this.label24.TabIndex = 49;
            this.label24.Text = "Client";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.animator1.SetDecoration(this.label25, AnimatorNS.DecorationType.None);
            this.animator2.SetDecoration(this.label25, AnimatorNS.DecorationType.None);
            this.label25.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(565, 65);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(117, 20);
            this.label25.TabIndex = 50;
            this.label25.Text = "Reste à Payer :";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.animator1.SetDecoration(this.label26, AnimatorNS.DecorationType.None);
            this.animator2.SetDecoration(this.label26, AnimatorNS.DecorationType.None);
            this.label26.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(305, 66);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(83, 20);
            this.label26.TabIndex = 51;
            this.label26.Text = "Total Reg :";
            // 
            // lblAncienRestPayer
            // 
            this.lblAncienRestPayer.AutoSize = true;
            this.animator1.SetDecoration(this.lblAncienRestPayer, AnimatorNS.DecorationType.None);
            this.animator2.SetDecoration(this.lblAncienRestPayer, AnimatorNS.DecorationType.None);
            this.lblAncienRestPayer.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAncienRestPayer.ForeColor = System.Drawing.Color.Peru;
            this.lblAncienRestPayer.Location = new System.Drawing.Point(683, 66);
            this.lblAncienRestPayer.Name = "lblAncienRestPayer";
            this.lblAncienRestPayer.Size = new System.Drawing.Size(45, 19);
            this.lblAncienRestPayer.TabIndex = 52;
            this.lblAncienRestPayer.Text = "0000";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.animator1.SetDecoration(this.label28, AnimatorNS.DecorationType.None);
            this.animator2.SetDecoration(this.label28, AnimatorNS.DecorationType.None);
            this.label28.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(22, 64);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(84, 20);
            this.label28.TabIndex = 53;
            this.label28.Text = "Montant  :";
            // 
            // lblAncienTotalReg
            // 
            this.lblAncienTotalReg.AutoSize = true;
            this.animator1.SetDecoration(this.lblAncienTotalReg, AnimatorNS.DecorationType.None);
            this.animator2.SetDecoration(this.lblAncienTotalReg, AnimatorNS.DecorationType.None);
            this.lblAncienTotalReg.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAncienTotalReg.ForeColor = System.Drawing.Color.Peru;
            this.lblAncienTotalReg.Location = new System.Drawing.Point(388, 67);
            this.lblAncienTotalReg.Name = "lblAncienTotalReg";
            this.lblAncienTotalReg.Size = new System.Drawing.Size(45, 19);
            this.lblAncienTotalReg.TabIndex = 54;
            this.lblAncienTotalReg.Text = "0000";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.animator1.SetDecoration(this.label30, AnimatorNS.DecorationType.None);
            this.animator2.SetDecoration(this.label30, AnimatorNS.DecorationType.None);
            this.label30.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(19, 23);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(87, 20);
            this.label30.TabIndex = 55;
            this.label30.Text = "Num Reg : ";
            // 
            // lblMontant
            // 
            this.lblMontant.AutoSize = true;
            this.animator1.SetDecoration(this.lblMontant, AnimatorNS.DecorationType.None);
            this.animator2.SetDecoration(this.lblMontant, AnimatorNS.DecorationType.None);
            this.lblMontant.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontant.ForeColor = System.Drawing.Color.Peru;
            this.lblMontant.Location = new System.Drawing.Point(106, 65);
            this.lblMontant.Name = "lblMontant";
            this.lblMontant.Size = new System.Drawing.Size(45, 19);
            this.lblMontant.TabIndex = 56;
            this.lblMontant.Text = "0000";
            // 
            // lblNumReg
            // 
            this.lblNumReg.AutoSize = true;
            this.animator1.SetDecoration(this.lblNumReg, AnimatorNS.DecorationType.None);
            this.animator2.SetDecoration(this.lblNumReg, AnimatorNS.DecorationType.None);
            this.lblNumReg.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumReg.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblNumReg.Location = new System.Drawing.Point(104, 24);
            this.lblNumReg.Name = "lblNumReg";
            this.lblNumReg.Size = new System.Drawing.Size(45, 19);
            this.lblNumReg.TabIndex = 57;
            this.lblNumReg.Text = "0000";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.animator1.SetDecoration(this.label33, AnimatorNS.DecorationType.None);
            this.animator2.SetDecoration(this.label33, AnimatorNS.DecorationType.None);
            this.label33.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.Location = new System.Drawing.Point(208, 23);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(78, 20);
            this.label33.TabIndex = 58;
            this.label33.Text = "Num Fact";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.lblRestPayer);
            this.groupBox2.Controls.Add(this.lblTotalReg);
            this.groupBox2.Controls.Add(this.datetimepickerECH);
            this.groupBox2.Controls.Add(this.comboBoxArticle);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.comboBoxType);
            this.groupBox2.Controls.Add(this.bunifuFlatButton1);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label55);
            this.groupBox2.Controls.Add(this.txtPayer);
            this.animator2.SetDecoration(this.groupBox2, AnimatorNS.DecorationType.None);
            this.animator1.SetDecoration(this.groupBox2, AnimatorNS.DecorationType.None);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(3, 99);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(772, 288);
            this.groupBox2.TabIndex = 38;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detail Reglement";
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
            this.Type_Reg,
            this.Qte,
            this.DateECH,
            this.TXREMISE,
            this.PU_HT});
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
            this.dataGridView1.Location = new System.Drawing.Point(4, 106);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 5;
            this.dataGridView1.Size = new System.Drawing.Size(760, 151);
            this.dataGridView1.TabIndex = 44;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.animator1.SetDecoration(this.label19, AnimatorNS.DecorationType.None);
            this.animator2.SetDecoration(this.label19, AnimatorNS.DecorationType.None);
            this.label19.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(575, 261);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(100, 20);
            this.label19.TabIndex = 45;
            this.label19.Text = "Rest à payer";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.animator1.SetDecoration(this.label17, AnimatorNS.DecorationType.None);
            this.animator2.SetDecoration(this.label17, AnimatorNS.DecorationType.None);
            this.label17.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(48, 261);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(83, 20);
            this.label17.TabIndex = 46;
            this.label17.Text = "Total Reg :";
            // 
            // lblRestPayer
            // 
            this.lblRestPayer.AutoSize = true;
            this.animator1.SetDecoration(this.lblRestPayer, AnimatorNS.DecorationType.None);
            this.animator2.SetDecoration(this.lblRestPayer, AnimatorNS.DecorationType.None);
            this.lblRestPayer.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRestPayer.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblRestPayer.Location = new System.Drawing.Point(681, 261);
            this.lblRestPayer.Name = "lblRestPayer";
            this.lblRestPayer.Size = new System.Drawing.Size(45, 19);
            this.lblRestPayer.TabIndex = 47;
            this.lblRestPayer.Text = "0000";
            // 
            // lblTotalReg
            // 
            this.lblTotalReg.AutoSize = true;
            this.animator1.SetDecoration(this.lblTotalReg, AnimatorNS.DecorationType.None);
            this.animator2.SetDecoration(this.lblTotalReg, AnimatorNS.DecorationType.None);
            this.lblTotalReg.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalReg.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblTotalReg.Location = new System.Drawing.Point(131, 261);
            this.lblTotalReg.Name = "lblTotalReg";
            this.lblTotalReg.Size = new System.Drawing.Size(45, 19);
            this.lblTotalReg.TabIndex = 48;
            this.lblTotalReg.Text = "0000";
            // 
            // datetimepickerECH
            // 
            this.animator1.SetDecoration(this.datetimepickerECH, AnimatorNS.DecorationType.None);
            this.animator2.SetDecoration(this.datetimepickerECH, AnimatorNS.DecorationType.None);
            this.datetimepickerECH.Enabled = false;
            this.datetimepickerECH.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datetimepickerECH.Location = new System.Drawing.Point(599, 18);
            this.datetimepickerECH.Name = "datetimepickerECH";
            this.datetimepickerECH.Size = new System.Drawing.Size(144, 25);
            this.datetimepickerECH.TabIndex = 43;
            // 
            // comboBoxArticle
            // 
            this.animator2.SetDecoration(this.comboBoxArticle, AnimatorNS.DecorationType.None);
            this.animator1.SetDecoration(this.comboBoxArticle, AnimatorNS.DecorationType.None);
            this.comboBoxArticle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxArticle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxArticle.FormattingEnabled = true;
            this.comboBoxArticle.Location = new System.Drawing.Point(67, 67);
            this.comboBoxArticle.Name = "comboBoxArticle";
            this.comboBoxArticle.Size = new System.Drawing.Size(354, 25);
            this.comboBoxArticle.TabIndex = 42;
            this.comboBoxArticle.SelectionChangeCommitted += new System.EventHandler(this.comboBoxArticle_SelectionChangeCommitted);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.animator1.SetDecoration(this.label15, AnimatorNS.DecorationType.None);
            this.animator2.SetDecoration(this.label15, AnimatorNS.DecorationType.None);
            this.label15.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(9, 67);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(56, 20);
            this.label15.TabIndex = 38;
            this.label15.Text = "Article";
            // 
            // comboBoxType
            // 
            this.animator2.SetDecoration(this.comboBoxType, AnimatorNS.DecorationType.None);
            this.animator1.SetDecoration(this.comboBoxType, AnimatorNS.DecorationType.None);
            this.comboBoxType.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxType.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Location = new System.Drawing.Point(67, 23);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(166, 25);
            this.comboBoxType.TabIndex = 42;
            this.comboBoxType.SelectionChangeCommitted += new System.EventHandler(this.comboBoxType_SelectionChangeCommitted);
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
            this.bunifuFlatButton1.IconZoom = 50D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(609, 68);
            this.bunifuFlatButton1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(141, 31);
            this.bunifuFlatButton1.TabIndex = 35;
            this.bunifuFlatButton1.Text = "    Ajouter";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.animator1.SetDecoration(this.label13, AnimatorNS.DecorationType.None);
            this.animator2.SetDecoration(this.label13, AnimatorNS.DecorationType.None);
            this.label13.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(9, 23);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(42, 20);
            this.label13.TabIndex = 38;
            this.label13.Text = "Type";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.animator1.SetDecoration(this.label14, AnimatorNS.DecorationType.None);
            this.animator2.SetDecoration(this.label14, AnimatorNS.DecorationType.None);
            this.label14.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(493, 22);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(84, 20);
            this.label14.TabIndex = 38;
            this.label14.Text = "Date Ech :";
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.animator1.SetDecoration(this.label55, AnimatorNS.DecorationType.None);
            this.animator2.SetDecoration(this.label55, AnimatorNS.DecorationType.None);
            this.label55.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label55.Location = new System.Drawing.Point(265, 22);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(58, 20);
            this.label55.TabIndex = 38;
            this.label55.Text = "Payé  :";
            // 
            // txtPayer
            // 
            this.animator1.SetDecoration(this.txtPayer, AnimatorNS.DecorationType.None);
            this.animator2.SetDecoration(this.txtPayer, AnimatorNS.DecorationType.None);
            this.txtPayer.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtPayer.Location = new System.Drawing.Point(329, 22);
            this.txtPayer.Name = "txtPayer";
            this.txtPayer.Size = new System.Drawing.Size(130, 23);
            this.txtPayer.TabIndex = 39;
            this.txtPayer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPayer_KeyPress);
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
            this.pnlLogo.Size = new System.Drawing.Size(792, 101);
            this.pnlLogo.TabIndex = 21;
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
            this.pnlExit.Size = new System.Drawing.Size(40, 523);
            this.pnlExit.TabIndex = 20;
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
            this.pnlHeader.TabIndex = 19;
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
            animation2.TransparencyCoeff = 1F;
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
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 10;
            this.bunifuElipse2.TargetControl = this;
            // 
            // Type_Reg
            // 
            this.Type_Reg.FillWeight = 40F;
            this.Type_Reg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Type_Reg.HeaderText = "Type Reglement";
            this.Type_Reg.Name = "Type_Reg";
            this.Type_Reg.ReadOnly = true;
            this.Type_Reg.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Type_Reg.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Qte
            // 
            this.Qte.FillWeight = 30F;
            this.Qte.HeaderText = "Payé";
            this.Qte.Name = "Qte";
            this.Qte.ReadOnly = true;
            // 
            // DateECH
            // 
            this.DateECH.FillWeight = 40F;
            this.DateECH.HeaderText = "Date Echéance";
            this.DateECH.Name = "DateECH";
            this.DateECH.ReadOnly = true;
            // 
            // TXREMISE
            // 
            this.TXREMISE.FillWeight = 17.73269F;
            this.TXREMISE.HeaderText = "Echéance";
            this.TXREMISE.Name = "TXREMISE";
            this.TXREMISE.ReadOnly = true;
            this.TXREMISE.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.TXREMISE.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // PU_HT
            // 
            this.PU_HT.FillWeight = 23.90877F;
            this.PU_HT.HeaderText = "Encaisment";
            this.PU_HT.Name = "PU_HT";
            this.PU_HT.ReadOnly = true;
            this.PU_HT.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.PU_HT.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Reglement_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 543);
            this.Controls.Add(this.pnlContainer);
            this.Controls.Add(this.pnlLogo);
            this.Controls.Add(this.pnlExit);
            this.Controls.Add(this.pnlHeader);
            this.animator1.SetDecoration(this, AnimatorNS.DecorationType.None);
            this.animator2.SetDecoration(this, AnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Reglement_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reglement_Form";
            this.Load += new System.EventHandler(this.Reglement_Form_Load);
            this.pnlContainer.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.pnlLogo.ResumeLayout(false);
            this.pnlLogo.PerformLayout();
            this.pnlExit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlContainer;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlExit;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker datetimepickerECH;
        public System.Windows.Forms.ComboBox comboBoxArticle;
        private System.Windows.Forms.Label label15;
        public System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.TextBox txtPayer;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lblRestPayer;
        private System.Windows.Forms.Label lblTotalReg;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.ComboBox comboBoxClient;
        private System.Windows.Forms.TextBox txtNumFact;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label lblAncienRestPayer;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label lblAncienTotalReg;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label lblMontant;
        private System.Windows.Forms.Label lblNumReg;
        private System.Windows.Forms.Label label33;
        private AnimatorNS.Animator animator2;
        private AnimatorNS.Animator animator1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private System.Windows.Forms.DataGridViewComboBoxColumn Type_Reg;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qte;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateECH;
        private System.Windows.Forms.DataGridViewCheckBoxColumn TXREMISE;
        private System.Windows.Forms.DataGridViewCheckBoxColumn PU_HT;
    }
}