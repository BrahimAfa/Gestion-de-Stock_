﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AnimatorNS;
using Gestion_de_Stock_.DAL;
using Gestion_de_Stock_.UserControls;

namespace Gestion_de_Stock_.Forms
{
    public partial class Reglement_Form : Form
    {
        DataAccess da;
        UC_LocationInForm UC = UC_LocationInForm.Instance;
        DataSet ds;
        public Reglement_Form()
        {
            InitializeComponent();

            StartTiming();
            UC_Initializ("Reg et Fact");
            EditeState = false;
            SetupComponents();
        }
        public Reglement_Form(string NumFacture)
        {
            InitializeComponent();

            StartTiming();
            UC_Initializ("Edit Reg et Fact");
            EditeState = true;
            SetupComponents();
            InitializeDataset(NumFacture);
            FillControlersWithData();
           
        }

        private void InitializeDataset(string NumFacture)
        {
            try
            {
                da = new DataAccess();
                ds = new DataSet();
                ds.Tables.Add(da.GetDonnerFacture(NumFacture));
                ds.Tables.Add(da.GetFactureDetail(NumFacture));
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
          
        }
        private void FillControlersWithData()
        {
            //facture Table
           // SetupComponents();
            txtNumFact.Text = ds.Tables[0].Rows[0][0].ToString();

            comboBoxClient.SelectedValue = ds.Tables[0].Rows[0][1].ToString();

            lblMontant.Text = ds.Tables[0].Rows[0][3].ToString();

            lblAncienRestPayer.Text = ds.Tables[0].Rows[0][4].ToString();

            lblAncienTotalReg.Text = (Convert.ToDecimal(lblMontant.Text)- Convert.ToDecimal(lblAncienRestPayer.Text)).ToString();

            // reglement
    
            comboBoxArticle.SelectedValue = ds.Tables[1].Rows[0][1].ToString();
            IsArticleChosen = true;
           // MessageBox.Show(ds.Tables[1].Rows[0][1].ToString());
            comboBoxClient.Enabled = false;
            comboBoxArticle.Enabled = false;
        }

        public bool EcheanceState { get; set; }
        public bool IsArticleChosen { get; set; }
        DataAccess DA = new DataAccess();
        private void Reglement_Form_Load(object sender, EventArgs e)
        {

          
        }
        bool EditeState;
        void SetupComponents()
        {
            //client - type - Article
            //texts
            DataTable DT = DataAccess.GetArticles();
            if (!EditeState)
            {
                txtNumFact.Text = DataAccess.GeneratFactureID();
                DataRow dr = DT.NewRow();
                dr[0] = "-1";
                dr[2] = "Selctionner L'article";
                DT.Rows.InsertAt(dr, 0);
            }
            lblNumReg.Text = DataAccess.GeneratReglementsID();
            //Comboboxes
            //Articles
            
       
            comboBoxArticle.DataSource = DT;
            comboBoxArticle.DisplayMember = "DESCRIPTION";
            comboBoxArticle.ValueMember = "REF";
            //CLients
            comboBoxClient.DataSource = DataAccess.GetClient();
            comboBoxClient.DisplayMember = "RaisonSociale";
            comboBoxClient.ValueMember = "IdClient";
            //CLients
            comboBoxType.DataSource = this.Type_Reg.DataSource = DataAccess.GetRegType();
            comboBoxType.DisplayMember = Type_Reg.DisplayMember = "TypeReg";
            comboBoxType.ValueMember = Type_Reg.ValueMember = "IdType";
            EcheanceState = IsArticleChosen = false;
        }


        private void comboBoxArticle_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (comboBoxArticle.SelectedValue.ToString() == "-1")
            {
                IsArticleChosen = false;
                return;
            }
            IsArticleChosen = true;
            Calculate_Prix(DA.GetArticlePrixVent(comboBoxArticle.SelectedValue.ToString()));
        }
        void Calculate_Prix(decimal Montant)
        {

            lblMontant.Text = Montant.ToString();

            lblAncienRestPayer.Text = (Montant - decimal.Parse(lblAncienTotalReg.Text)).ToString("0.00");

        }

        private void txtPayer_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != (char)Keys.Delete;

        }

        private void comboBoxType_SelectionChangeCommitted(object sender, EventArgs e)
        {

            datetimepickerECH.Enabled = EcheanceState = comboBoxType.SelectedValue.ToString() == "1" ? false : true;

           
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            if (!IsArticleChosen)
            {
                MessageBox.Show("choisir un Article!!!");
                return;
            }
            if (String.IsNullOrEmpty(txtPayer.Text))
            {
                MessageBox.Show("Montant Paye Vide !!!!");
                return;
            }

            if (!EcheanceState)
            {
                dataGridView1.Rows.Add(new object[] { comboBoxType.SelectedValue, txtPayer.Text, DateTime.Now.ToShortDateString(), EcheanceState, !EcheanceState });

            }
            else
            {
                dataGridView1.Rows.Add(new object[] { comboBoxType.SelectedValue, txtPayer.Text, datetimepickerECH.Value.ToShortDateString(), EcheanceState, !EcheanceState });

            }

            calculate_datagrid();
        }

        void calculate_datagrid()
        {
            if (dataGridView1.Rows.Count == 0) {
                MessageBox.Show("Data Gride View est Vide");
                return;
            }
            decimal sum = 0;
            foreach (DataGridViewRow dr in dataGridView1.Rows)
            {
                sum += Convert.ToDecimal(dr.Cells[1].Value);
            }
            sum = Convert.ToDecimal(lblAncienTotalReg.Text) + sum; 
            lblTotalReg.Text = sum.ToString("0.00");
            lblRestPayer.Text = (Decimal.Parse(lblMontant.Text) - sum).ToString();
        }

        DataSet RemplirDataset()
        {

            DataSet ds = new DataSet();

            ds.Tables.Add("Facture");
            ds.Tables["Facture"].Columns.AddRange(new DataColumn[]
            {
                    new DataColumn ("NumFacture"),
                    new DataColumn ("Client"),
                    new DataColumn ("Date"),
                    new DataColumn ("MontantFact"),
                     new DataColumn ("RestPaye")
            });
            ds.Tables["Facture"].Rows.Add(new object[] { txtNumFact.Text, comboBoxClient.SelectedValue, DateTime.Now.ToShortDateString(), Convert.ToDecimal(lblMontant.Text), Convert.ToDecimal(lblRestPayer.Text) });
            //   Facture Reg Detail_Reg
            ds.Tables.Add("Reg");
            ds.Tables["Reg"].Columns.AddRange(new DataColumn[]
  {
                    new DataColumn ("NumReg"),
                    new DataColumn ("Date"),
                    new DataColumn ("NumFact")

  });
            ds.Tables["Reg"].Rows.Add(new object[] { lblNumReg.Text, DateTime.Now.ToShortDateString(), txtNumFact.Text });

            ds.Tables.Add("Detail_Reg");
            ds.Tables["Detail_Reg"].Columns.AddRange(new DataColumn[]
  {
                    new DataColumn ("Numreg"),
                    new DataColumn ("Type"),
                    new DataColumn ("MontantReg"),
                    new DataColumn ("Ref"),
                    new DataColumn ("Dateech"),
                    new DataColumn ("Encais")
  });
            foreach (DataGridViewRow dr in dataGridView1.Rows)
            {
                ds.Tables["Detail_Reg"].Rows.Add(new object[] { lblNumReg.Text, dr.Cells[0].Value, dr.Cells[1].Value, comboBoxArticle.SelectedValue, dr.Cells[2].Value, dr.Cells[4].Value });
            }

            return ds;

        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {

                MessageBox.Show("Pas des données saisir !!!");
                return;
            }
            if (!EditeState)
            {
                DA.AddFacture(RemplirDataset());
            }
            else
            {
                DA.EditFacture(RemplirDataset());
            }
           
            if (DA.IsDone)
            {
                MessageBox.Show("Bien AJouter");
            }
        }
        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count==0)
            {
                return;
            }
            if (MessageBox.Show("voulez-vous supprimer les enregistrements", "Effacer", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                dataGridView1.Rows.Clear();
                txtPayer.Clear();
                lblTotalReg.Text= "0000";
                lblRestPayer.Text = "0000";
            }

        }
        #region Cummon Thing Betwwen the Forms
        void StartTiming()
        {
            Timer timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            lblDate.Text = DateTime.Now.ToShortDateString();
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongTimeString();

        }

        void UC_Initializ(string State)
        {


            UC.LabelText = State;

            UC.Allignment = ContentAlignment.MiddleLeft;
            UC.Location = new Point(0, 72);
            UC.Visible = false;
            pnlLogo.Controls.Add(UC);

            animator2.Show(UC, true, AnimatorNS.Animation.HorizSlide);

            //   animator1.WaitAllAnimations();

        }



        #endregion

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
    