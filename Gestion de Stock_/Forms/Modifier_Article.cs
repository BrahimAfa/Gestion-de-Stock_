using Gestion_de_Stock_.DAL;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace Gestion_de_Stock_.Forms
{
    public partial class Modifier_Article : Form
    {
        DataGridViewRow dr;
        DataAccess DA = new DataAccess();
        public Modifier_Article(DataGridViewRow ArticleRow)
        {
            InitializeComponent();
            

            dr = ArticleRow;
            Remplir_combo();
          
          
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Modifier_Article_Load(object sender, EventArgs e)
        {
            Remplir_combo();
            Informatializ();
        }
        public void Remplir_combo()
        {

            DataTable Famille_TB = DataAccess.GetFamilles();

            DataRow row = Famille_TB.NewRow();
            row[0] = -1;
            row[1] = "----Ajouter new Famille----";
            Famille_TB.Rows.InsertAt(row, 0);
            ComboFamille.DataSource = Famille_TB;
            ComboFamille.DisplayMember = "FAMILLE";
            ComboFamille.ValueMember = "IDFAMILLE";
        }
        void Informatializ()
        {
            lblRef.Text = dr.Cells[0].Value.ToString();
            ComboFamille.SelectedValue = Convert.ToInt32( dr.Cells[1].Value);
             txtdesc.Text = dr.Cells[2].Value.ToString();
             txtPrixAchat.Text = dr.Cells[3].Value.ToString();
              txtPrixVente.Text = dr.Cells[4].Value.ToString();
               txtQte.Text =   dr.Cells[5].Value.ToString();
              txtTVA.Text =   dr.Cells[6].Value.ToString(); 

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
           // decimal tva = (decimal)int.Parse(txtTVA.Text) / 100;
            SqlParameter[] _params =
            {

                new SqlParameter("@REF", lblRef.Text),
                new SqlParameter("@IDFamille", ComboFamille.SelectedValue),
                new SqlParameter("@Desc", txtdesc.Text),
                new SqlParameter("@PU_Achat", decimal.Parse(txtPrixAchat.Text)),
                new SqlParameter("@PU_Vente", decimal.Parse(txtPrixVente.Text)),
                new SqlParameter("@QTE", int.Parse(txtQte.Text)),
                new SqlParameter("@TXTVA",decimal.Parse(txtTVA.Text))

                };
            DA.Modifier_BD(DataAccess.Manage_Stock.Article, _params);
            if (DA.IsDone)    
            {
             
                MessageBox.Show("Bien Modifier");

            }
        }
        //void Clear()
        //{

        //    txtTVA.Clear();
        //    ComboFamille.SelectedIndex = 1;
        //    txtdesc.Clear();
        //    txtPrixAchat.Clear();
        //    txtPrixVente.Clear();
        //    txtQte.Clear();
        //}
    }
}
