using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
    public partial class Facture_Detail : Form
    {
        DataAccess da = new DataAccess();
        UC_LocationInForm UC = UC_LocationInForm.Instance;
        public Facture_Detail(string NumFacture)
        {
            InitializeComponent();
            StartTiming();
            UC_Initializ();
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

        void UC_Initializ()
        {


            UC.LabelText = "Facture Detail";

            UC.Allignment = ContentAlignment.MiddleLeft;
            UC.Location = new Point(0, 72);
            UC.Visible = false;
            pnlLogo.Controls.Add(UC);

            animator2.Show(UC, true, Animation.HorizSlide);
            Hide_Components();
            Show_Components();

        }
        void Hide_Components()
        {
            foreach (Control item in pnlContainer.Controls)
            {
                item.Hide();
            }


        }

        void Show_Components()
        {

            foreach (Control item in pnlContainer.Controls)
            {
                animator1.Show(item, true, Animation.Transparent);

            }
        }
        #endregion
    }
}
