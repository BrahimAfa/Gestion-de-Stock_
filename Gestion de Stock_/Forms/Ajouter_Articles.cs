using Gestion_de_Stock_.DAL;
using Gestion_de_Stock_.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_de_Stock_.Forms
{
   
    public partial class Ajouter_Articles : Form
    {
        Point _LocationPoint;
        Size size;
        DataAccess DAT;
        UC_LocationInForm UC = UserControls.UC_LocationInForm.Instance;
        public Ajouter_Articles(Point OwnerFormLocaion, Size OwnerFormSize)
        {
            InitializeComponent();
            StartTiming();
            _LocationPoint = OwnerFormLocaion;
            size = OwnerFormSize;
        
            UC_Initializ();
            


        }
      
        void UC_Initializ()
        {
            
            
           // var UC = UserControls.UC_LocationInForm.Instance;
            UC.LabelText = "Articles";

            UC.Allignment = ContentAlignment.MiddleLeft;
            UC.Location = new Point(0, 72);
            UC.Visible = false;
            pnlLogo.Controls.Add(UC);

            animator2.Show(UC,true,AnimatorNS.Animation.HorizSlide);

            Hide_Components();
            Show_Components();
           
        }
        void StartTiming()
        {
            var timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            lblDate.Text = DateTime.Now.ToShortDateString();
            lblTime.Text = DateTime.Now.ToLongTimeString();
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongTimeString();

        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.Location = _LocationPoint;
            this.Size = size;
            //lblRef.Text = DataAccess.GeneratArticlesRef();
            Remplir_combo();
            

        }
        public void Remplir_combo()
        {

            DataTable Famille_TB = DataAccess.GetFamilles();
       
            DataRow row = Famille_TB.NewRow();
            row[0] = -1;
            row[1] = "----Ajouter new Famille----";
            Famille_TB.Rows.InsertAt(row, 0);
            ComboFamille.DataSource = Famille_TB;
            ComboFamille.SelectedIndex = 1;
            ComboFamille.DisplayMember = "FAMILLE";
            ComboFamille.ValueMember = "IDFAMILLE";
        }
        void Hide_Component_WithANimation()
        {
            animator2.Hide(UC, true,AnimatorNS.Animation.HorizSlide);
            foreach (Control item in pnlContainer.Controls)
            {
                animator1.Hide(item, true);
            }
           
            animator1.WaitAllAnimations();
           
            animator2.WaitAllAnimations();
           
        }
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Hide_Component_WithANimation();

            new HomeForm(this.Location,this.Size).Show();
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

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
                animator1.Show(item, true,AnimatorNS.Animation.Transparent);
             
            }
        }
       
        private void bunifuFlatButton1_Click_1(object sender, EventArgs e)
        {
            DAT = new DataAccess();
            try
            {
                string str_tva = txtTVA.Text.Remove(txtTVA.Text.Length - 1);

                decimal tva = (decimal)int.Parse(str_tva) / 100;
                SqlParameter[] _params =
                {

                new SqlParameter("@REF", txtRef.Text),
                new SqlParameter("@IDFamille", ComboFamille.SelectedValue),
                new SqlParameter("@Desc", txtdesc.Text),
                new SqlParameter("@PU_Achat", decimal.Parse(txtPrixAchat.Text)),
                new SqlParameter("@PU_Vente", decimal.Parse(txtPrixVente.Text)),
                new SqlParameter("@QTE", int.Parse(txtQte.Text)),
                new SqlParameter("@TXTVA",tva)

                };

                DAT.Ajouter_BD(DataAccess.Manage_Stock.Article, _params);
                if (DAT.IsDone)
                {
                    MessageBox.Show("Bien Ajouter");
                    //lblRef.Text = DataAccess.GeneratArticlesRef();
                    Clear();
                }
               
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
         //   decimal tva =

        }

        void Clear()
        {

            txtTVA.Clear();
            ComboFamille.SelectedIndex = 1;
            txtdesc.Clear();
            txtPrixAchat.Clear();
            txtPrixVente.Clear();
            txtQte.Clear();
            txtMarge.Clear();
        }

    

        private void ComboFamille_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (ComboFamille.SelectedValue.ToString() == "-1")
            {
                var f = new Forms.Ajouter_Famille();
                f.StartPosition = FormStartPosition.CenterParent;
                f.ShowDialog(this);
            }
        }
    



    

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void txtPrixAchat_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != (char)Keys.Delete ;
        }

        private void txtTVA_TextChanged(object sender, EventArgs e)
        {
            if (Decimal.TryParse(txtTVA.Text, out decimal b))
            {
             
                txtTVA.Text = b.ToString("%");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void txtPrixAchat_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtPrixAchat.Text) && !String.IsNullOrEmpty(txtPrixVente.Text))
            {
                txtMarge.Text = (Convert.ToDecimal(txtPrixVente.Text) - Convert.ToDecimal(txtPrixAchat.Text)).ToString();
            }
         
        }

        private void txtPrixVente_TextChanged(object sender, EventArgs e)
        {
        
            if (!String.IsNullOrEmpty(txtPrixAchat.Text) && !String.IsNullOrEmpty(txtPrixVente.Text))
            {
                decimal vent = Convert.ToDecimal(txtPrixVente.Text);
                decimal achat = Convert.ToDecimal(txtPrixAchat.Text);
                txtMarge.Text = (vent - achat).ToString();
            }
        }
        //void calculateMarge(string PVent,string )
        //{

        //}
    }
}
