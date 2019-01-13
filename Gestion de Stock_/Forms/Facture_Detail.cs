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
    public partial class Facture_Detail : Form
    {
        DataAccess da = new DataAccess();
        public Facture_Detail(string NumFacture)
        {
            InitializeComponent();
            comboBoxClient.DataSource = DataAccess.GetClient();
            comboBoxClient.DisplayMember = "RaisonSociale";
            comboBoxClient.ValueMember = "IdClient";
           
            InitializeDonner(NumFacture);
        }
        void InitializeDonner(string NumFacture)
        {
            DataTable dt = da.GetDonnerFacture(NumFacture);
            txtNumFact.Text = dt.Rows[0][0].ToString();
            comboBoxClient.SelectedValue = dt.Rows[0][1].ToString();
            lblMontant.Text = dt.Rows[0][3].ToString();
            lblRestPayer.Text = dt.Rows[0][4].ToString();

            dataGridView1.DataSource = da.GetFactureDetail(NumFacture);
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            new Reglement_Form(txtNumFact.Text).ShowDialog();
        }
    }
}
