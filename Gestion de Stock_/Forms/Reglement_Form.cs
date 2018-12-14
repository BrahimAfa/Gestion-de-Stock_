using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gestion_de_Stock_.DAL;

namespace Gestion_de_Stock_.Forms
{
    public partial class Reglement_Form : Form
    {
        public Reglement_Form()
        {
            InitializeComponent();
        }
      
        public bool EcheanceState { get; set; }
        public bool IsArticleChosen { get; set; }
        DataAccess data = new DataAccess();
        private void Reglement_Form_Load(object sender, EventArgs e)
        {
           
            SetupComponents();
        }

        void SetupComponents()
        {
            //client - type - Article
            //texts
            txtNumFact.Text = DataAccess.GeneratFactureID();
            lblNumReg.Text = DataAccess.GeneratReglementsID();
            //Comboboxes
            //Articles
            DataTable DT = DataAccess.GetArticles();
            DataRow dr = DT.NewRow();
            dr[0] = "-1";
            dr[2] = "Selctionner L'article";
            DT.Rows.InsertAt(dr, 0);
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
            if (comboBoxArticle.SelectedValue.ToString()=="-1")
            {
                IsArticleChosen = false;
                return;
            }
            IsArticleChosen = true ;
            Calculate_Prix(data.GetArticlePrixVent(comboBoxArticle.SelectedValue.ToString()));
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
            if (String.IsNullOrEmpty(txtPayer.Text) )
            {
                MessageBox.Show("Montant Paye Vide !!!!");
                    return;
            }
         
            if (!EcheanceState )
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
            lblTotalReg.Text = sum.ToString("0.00");
            lblRestPayer.Text = (Decimal.Parse(lblMontant.Text) - sum).ToString();
        }
    }
}
