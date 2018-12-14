using AnimatorNS;
using Gestion_de_Stock_.DAL;
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
    public partial class Ajouter_BL : Form
    {
        Point _LocationPoint;
        Size _size;
        DataAccess DA = new DataAccess();
        UserControls.UC_LocationInForm UC = UserControls.UC_LocationInForm.Instance;
        private string _Ref { get; set; }
        // Main Constructor SECTION
        public Ajouter_BL(Point OwnerFormLocaion, Size OwnerFormSize)
        {
            InitializeComponent();

            _LocationPoint = OwnerFormLocaion;
            _size = OwnerFormSize;

            StartTiming();
            UC_Initializ("Bon Livraison");
            txtNumBL.Text = DataAccess.GeneratNums(true);
            bunifuFlatButton1.Click += bunifuFlatButton1_Ajouter_Click;
           bunifuImageButton1.Click += bunifuImageButton1_Ajouter_Click;

            bunifuFlatButton2.Click += BunifuFlatButton2_Ajouter_Click;
            dataGridView1.CellClick += dataGridView1_CellClick;
        }
        private void bunifuFlatButton1_Ajouter_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 1)
            {
                MessageBox.Show("Ajouter des donner!!!");
                return;
            }

            DA.Ajouter_BD(DataAccess.Manage_Stock.BL, null, Ajouter_detail_BL());

            if (DA.IsDone)
            {
                MessageBox.Show("Les Donner a Bien Ajouter");
                txtNumBL.Text = DataAccess.GeneratNums(true);
            }


        }
        private void BunifuFlatButton2_Ajouter_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            txtDevis.Text = "";
            //bunifuCheckbox1.Checked = !bunifuCheckbox1.Checked;
            txtNumBL.Text = DataAccess.GeneratNums(true);
        }
        private void bunifuImageButton1_Ajouter_Click(object sender, EventArgs e)
        {
            Hide_Component_WithANimation();

            new HomeForm(this.Location, this.Size).Show();
            this.Close();
        }
        //EDITING SECTION

        public Ajouter_BL(Point OwnerFormLocaion, Size OwnerFormSize,string NumBL)
        {
            InitializeComponent();
          
            InitializeFFE(NumBL);

            _LocationPoint = OwnerFormLocaion;
            _size = OwnerFormSize;
            StartTiming();
            UC_Initializ("Edit BL");


        }

        private void BunifuImageButton1_Modifier_Click(object sender, EventArgs e)
        {
              Hide_Component_WithANimation();

            new Gere_BL(this.Location, this.Size).Show();
            this.Close();
        }

        private void BunifuFlatButton2_Delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("tu va supprimer cette BL ", "Supprision", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                dataGridView1.Rows.Clear();
                DA.Supprimer_BD(DataAccess.Manage_Stock.BL, txtNumBL.Text);
                txtNumBL.Text = DataAccess.GeneratNums(true);

            }
        }

        private void bunifuFlatButton1_Modifier_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("Pas des donner Ajouter!!!");
                return;
            }
            DA.Modifier_BD(DataAccess.Manage_Stock.BL, null, Ajouter_detail_BL());

            if (DA.IsDone)
            {
                MessageBox.Show("Les Donner a Bien Modifier");
                // txtNumdevis.Text = DataAccess.GeneratNums();
            }
        }
        void InitializeFFE(string Num)
        {
            //BUttons
            bunifuFlatButton2.Text = "                Supprimer";
            bunifuFlatButton2.Iconimage = Properties.Resources.icons8_Trash_96px_1;
            bunifuFlatButton1.Text = "                    Save";
            bunifuFlatButton1.Iconimage = Properties.Resources.icons8_Checkmark_96px;

            bunifuFlatButton1.Click += bunifuFlatButton1_Modifier_Click;

            bunifuFlatButton2.Click += BunifuFlatButton2_Delete_Click;

            bunifuImageButton1.Click += BunifuImageButton1_Modifier_Click;

            dataGridView1.CellClick += dataGridView1_WithDelete_CellClick;

            // DGV
            dataGridView1.AllowUserToAddRows = false;
            this.Ref.ReadOnly = true;
            // GroupBox
            groupBox3.Enabled = false;
            var BL_Info = DA.BL_INfo(Num);
            if (!DA.IsDone)
            {
                MessageBox.Show("cette reference n'est pas existe");
                return;
            }


            FillInfo(BL_Info.BL, BL_Info.Detail_BL);

        }
        void FillInfo(DataTable BL, DataTable Devis_BL)
        {
            txtNumBL.Text = BL.Rows[0][0].ToString();
            ComboClient.SelectedValue = BL.Rows[0][1].ToString();
            txtObserv.Text = BL.Rows[0][3].ToString();
            foreach (DataRow item in Devis_BL.Rows)
            {
                if (DA.IsArticlExist(item["REF"].ToString()))
                {
                    MessageBox.Show("l'Article \"" + item["REF"].ToString() + "\" Pas Exist ");
                    continue;
                }
                decimal TX = Convert.ToDecimal(item["TXREMISE"]) * 100;
          
                dataGridView1.Rows.Add(new object[] { item["REF"], Convert.ToDecimal(item["PRIX_VENTEHT"]), int.Parse(item["QTE"].ToString()), TX.ToString("0"), Convert.ToDecimal(item["PT_HT"]).ToString("0.00"), Convert.ToDecimal(item["PT_TTC"]) });
            }

        }
        private void Ajouter_BL_Load(object sender, EventArgs e)
        {
            this.Ref.DataSource = DAL.DataAccess.GetArticles();
            this.Ref.DisplayMember = "DESCRIPTION";
            this.Ref.ValueMember = "REF";
            this.Location = _LocationPoint;
            this.Size = _size;

            //try
            //{
                //   this.aRTICLESTableAdapter.Fill(this.gestion_De_StockDataSet.ARTICLES);
                ComboClient.DataSource = DataAccess.GetClient();
                ComboClient.DisplayMember = "RAISONSOCIALE";
                ComboClient.ValueMember = "IDCLIENT";
           

          //  }
            // had l method dyal   When khdama f  C#6 l fog 
            //catch (Exception ex) //when( ex.InnerException is SqlException" you condition is true...")

            //}

        }
        // Timer Fonction
        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

            int index = e.RowIndex;
            string Cname = dataGridView1.Columns[e.ColumnIndex].Name;
            switch (Cname)
            {
                //  Ref Prix_vente Qte TXREMISE PU_HT PU_TTC
                case "Ref":
                    if (dataGridView1.Rows[index].Cells["Ref"].Value != null)
                    {
                        var PU_V = DA.GetArticlePrixVent(_Ref = dataGridView1.Rows[index].Cells["Ref"].Value.ToString());
                        dataGridView1.Rows[index].Cells["Prix_vente"].Value = PU_V;
                        PU_HT_Calculat(index);
                        PU_TTC_Calculate(index);
                    }
                    break;
                case "Qte":
                    PU_HT_Calculat(index);
                    PU_TTC_Calculate(index);
                    break;
                case "TXREMISE":
                    PU_HT_Calculat(index);
                    PU_TTC_Calculate(index);
                    break;
                default:
                    break;
            }
        }

        void PU_HT_Calculat(int index)
        {
            decimal TX, PRIXV;
            int Qte;
            try
            {
                PRIXV = Decimal.Parse(dataGridView1.Rows[index].Cells["Prix_vente"].Value.ToString());
                if (dataGridView1.Rows[index].Cells["TXREMISE"].Value != null &&
                    dataGridView1.Rows[index].Cells["QTE"].Value != null)
                {

                    Qte = int.Parse(dataGridView1.Rows[index].Cells["QTE"].Value.ToString());
                    TX = Decimal.Parse(dataGridView1.Rows[index].Cells["TXREMISE"].Value.ToString());
                    dataGridView1.Rows[index].Cells["PU_HT"].Value = ((PRIXV - (PRIXV * (TX / 100))) * Qte).ToString("0.00");
                    return;

                }
                else
                {
                    if (dataGridView1.Rows[index].Cells["TXREMISE"].Value == null && dataGridView1.Rows[index].Cells["QTE"].Value != null)
                    {
                        Qte = int.Parse(dataGridView1.Rows[index].Cells["QTE"].Value.ToString());

                        dataGridView1.Rows[index].Cells["PU_HT"].Value = (PRIXV * Qte).ToString("0.00");
                        return;
                    }

                    dataGridView1.Rows[index].Cells["PU_HT"].Value = PRIXV.ToString("0.00");

                }
            }
            catch (Exception EX)
            {

                MessageBox.Show(EX.Message);
            }

        }


        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "PU_HT")
            {
                PU_TTC_Calculate(e.RowIndex);
            }

            //  PU_TTC_Calculate(index);
        }

        void PU_TTC_Calculate(int index)
        {
            decimal pu_ht, PU_TTC;
            decimal tva = DA.GetTVA(_Ref);
            if (dataGridView1.Rows[index].Cells["PU_HT"].Value != null)
            {
                pu_ht = Convert.ToDecimal(dataGridView1.Rows[index].Cells["PU_HT"].Value);
                PU_TTC = (pu_ht + (pu_ht * tva));
                dataGridView1.Rows[index].Cells["PU_TTC"].Value = PU_TTC.ToString("0.00");
            }
        }

        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(Column1_KeyPress);
            if (dataGridView1.CurrentCell.ColumnIndex == 2 || dataGridView1.CurrentCell.ColumnIndex == 3) //Desired Column
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(Column1_KeyPress);
                }
            }
        }

        private void Column1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

       

        private DataSet Ajouter_detail_BL()
        {
            #region Creating DataSets
            // @NUM,@IDCLIENT,@OBSERV
            DataSet ds = new DataSet();
            ds.Tables.Add("BL");
            ds.Tables["BL"].Columns.AddRange(new DataColumn[]
            {
                new DataColumn("NUM"),
                new DataColumn("IDCLIENT"),
                new DataColumn("OBSERV"),
            });

            //  Ref,  Qte,  PU,  PT_HTTC,  TXremis


            ds.Tables.Add("Detail_BL");

            ds.Tables["Detail_BL"].Columns.AddRange(new DataColumn[]
            {
                //@NumBL,@REF,@QTE,@PRIX_Vent,@TXREMIS,@PT_HTTC
                new DataColumn("NumBL"),
                new DataColumn("Ref"),
                new DataColumn("Qte"),
                new DataColumn("PU"),
                 new DataColumn("PT_HTTC"),
                  new DataColumn("TXremis"),
            });
            #endregion

            ds.Tables["BL"].Rows.Add(new object[] { txtNumBL.Text, ComboClient.SelectedValue, txtObserv.Text });

            foreach (DataGridViewRow item in dataGridView1.Rows)
            {
                if (!item.IsNewRow && item.Cells[3].Value != null)
                {
                    //       DA.Ajouter_BD(DataAccess.Ajouter.Devis,null, DetailDevisParams(item.Cells[0].Value, item.Cells[2].Value, item.Cells[1].Value, item.Cells[5].Value, tx));
                    int TXREMIS = int.Parse(item.Cells[3].Value.ToString());
                    decimal tx = (decimal)TXREMIS / 100;
                    // item.Cells[0].Value, item.Cells[2].Value, item.Cells[1].Value, item.Cells[5].Value, tx
                    ds.Tables["Detail_BL"].Rows.Add(new object[] { txtNumBL.Text, item.Cells[0].Value, item.Cells[2].Value, item.Cells[1].Value, item.Cells[5].Value, tx });
                }

                if (!item.IsNewRow && item.Cells[3].Value == null)
                {
                    // if the discount culumn is empty or null I  set THE VALUE  to  0 (By deafault)
                    //   DA.Ajouter_BD(DataAccess.Ajouter.Devis,null, DetailDevisParams(item.Cells[0].Value, item.Cells[2].Value, item.Cells[1].Value, item.Cells[5].Value));
                    ds.Tables["Detail_BL"].Rows.Add(new object[] { txtNumBL.Text, item.Cells[0].Value, item.Cells[2].Value, item.Cells[1].Value, item.Cells[5].Value, 0 });


                }

            }
            return ds;
        }
      
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == 6 && e.RowIndex >= 0 && !dataGridView1.Rows[e.RowIndex].IsNewRow)
            {
                dataGridView1.Rows.RemoveAt(e.RowIndex);
            }
        }
        private void dataGridView1_WithDelete_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //coulum index 6 == Button COlumn !!!! to remember
            if (e.ColumnIndex == 6 && e.RowIndex >= 0 && !dataGridView1.Rows[e.RowIndex].IsNewRow)
            {
                if (MessageBox.Show("Do you want to delete this Article", "Supprision", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    DA.Suppr_Article_BL(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString(), txtNumBL.Text);
                    dataGridView1.Rows.RemoveAt(e.RowIndex);
                }

            }
        }
        // Region for Cummon FonctionsBetwwen the Forms

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

        void UC_Initializ(string LabelText)
        {


            UC.LabelText = LabelText;

           // UC.Allignment = ContentAlignment.MiddleLeft;
            UC.Location = new Point(0, 72);
            UC.Visible = false;
            pnlLogo.Controls.Add(UC);

            animator2.Show(UC, true, AnimatorNS.Animation.HorizSlide);

            Hide_Components();
            Show_Components();
            //   animator1.WaitAllAnimations();

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


        void Hide_Component_WithANimation()
        {
            animator2.Hide(UC, true, Animation.HorizSlide);
            foreach (Control item in pnlContainer.Controls)
            {
                animator1.Hide(item, true, Animation.Transparent);
            }

            animator1.WaitAllAnimations();

            animator2.WaitAllAnimations();

        }
        #endregion



        private void bunifuCheckbox1_OnChange(object sender, EventArgs e)
        {
            if (bunifuCheckbox1.Checked)
            {
                Check_Enabled(true);
                lblCheck.Text = "ON";
                return;
            }
            Check_Enabled(false);
            lblCheck.Text = "OFF";
        }
        private void Check_Enabled(bool enable)
        {
            btnSearch.Enabled = enable;
            txtDevis.Enabled = enable;
            txtObserv.Enabled = !enable;
            ComboClient.Enabled = !enable;
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtDevis.Text))
            {
                if (txtDevis.Text.Length==10)
                {
                    var BL_Info = DA.Bl_Par_Devis(txtDevis.Text);
                    if (!DA.IsDone)
                    {
                        MessageBox.Show("cette reference n'est pas existe");
                        return;
                    }
                    dataGridView1.Rows.Clear();
                    Remplir_Par_Devis(BL_Info.Devis, BL_Info.Detail_Devis);
                }
                else
                {
                    MessageBox.Show("les Donner est Incorrect!!!!");
                }
            }
            else
            {
                MessageBox.Show("Champ Vide!!!!");
            }
        }
       private void Remplir_Par_Devis(DataTable Devis,DataTable Devis_Dtail)
        {
           //dataGridView1.Columns[3].DefaultCellStyle.Format = "P";
            txtNumBL.Text = Devis.Rows[0][0].ToString();
            ComboClient.SelectedValue = Devis.Rows[0][1].ToString();
            txtObserv.Text = Devis.Rows[0][3].ToString();
            foreach (DataRow item in Devis_Dtail.Rows)
            {
                decimal TX = Convert.ToDecimal(item["TXREMISE"]) * 100;
                decimal pt_ht= Convert.ToDecimal(item["PT_HT"]);
                dataGridView1.Rows.Add(new object[] { item["REF"], item["PRIX_VENTEHT"], item["QTE"], TX.ToString("0"), pt_ht.ToString("0.00"), item["PT_TTC"] });
            }
        }


    }
}

