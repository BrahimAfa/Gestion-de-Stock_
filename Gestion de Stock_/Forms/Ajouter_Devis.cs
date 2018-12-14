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
using AnimatorNS;
using Gestion_de_Stock_.DAL;

namespace Gestion_de_Stock_.Forms

{

    public partial class Ajouter_Devis : Form
    {
        Point _LocationPoint;
        Size _size;
        DataAccess DA = new DataAccess();
        //DataSet DEVIS_EDIT;
        UserControls.UC_LocationInForm UC = UserControls.UC_LocationInForm.Instance;
        ComponentResourceManager resources = new ComponentResourceManager();
        private string _Ref { get; set; }

        public Ajouter_Devis(Point OwnerFormLocaion, Size OwnerFormSize)
        {
            InitializeComponent();
            this.Ref.DataSource = DAL.DataAccess.GetArticles();
            this.Ref.DisplayMember = "DESCRIPTION";
            this.Ref.ValueMember = "REF";
            txtNumdevis.Text = DataAccess.GeneratNums();
          
            _LocationPoint = OwnerFormLocaion;
            _size = OwnerFormSize;
            
            StartTiming();
            UC_Initializ("Devis");
            bunifuFlatButton1.Click += bunifuFlatButton1_Ajouter_Click;
            bunifuImageButton1.Click += bunifuImageButton1_Ajouter_Click;

            bunifuFlatButton2.Click += BunifuFlatButton2_Ajouter_Click;
            dataGridView1.CellClick += dataGridView1_CellClick;


        }

        private void BunifuFlatButton2_Ajouter_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to clear this Articles","Clear",MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                dataGridView1.Rows.Clear();
            }
         
        }

        private void bunifuFlatButton1_Ajouter_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 1)
            {
                MessageBox.Show("Pas des donner Ajouter!!!");
                return;
            }

            DA.Ajouter_BD(DataAccess.Manage_Stock.Devis, null, Ajouter_detail_devis());

            if (DA.IsDone)
            {
                MessageBox.Show("Les Donner a Bien Ajouter");
                txtNumdevis.Text = DataAccess.GeneratNums();
            }


        }

       public Ajouter_Devis(Point OwnerFormLocaion, Size OwnerFormSize,string NumDevis)
        {
            InitializeComponent();
        
            InitializeFFE(NumDevis);
            _LocationPoint = OwnerFormLocaion;
            _size = OwnerFormSize;
            StartTiming();
            UC_Initializ("Edit Devis");

            bunifuFlatButton1.Click += bunifuFlatButton1_Modifier_Click;

            bunifuFlatButton2.Click += BunifuFlatButton2_Delete_Click; ;

            bunifuImageButton1.Click += BunifuImageButton1_Modifier_Click;
            dataGridView1.CellClick += dataGridView1_WithDelete_CellClick;
        }

        private void BunifuFlatButton2_Delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("tu va supprimer cette Devis ", "Supprision", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                dataGridView1.Rows.Clear();
                DA.Supprimer_BD(DataAccess.Manage_Stock.Devis, txtNumdevis.Text);
                txtNumdevis.Text = DataAccess.GeneratNums();
            }
        }

        private void bunifuFlatButton1_Modifier_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count ==0)
            {
                MessageBox.Show("Pas des donner Ajouter!!!");
                return;
            }
            DA.Modifier_BD(DataAccess.Manage_Stock.Devis,null, Ajouter_detail_devis());

            if (DA.IsDone)
            {
                MessageBox.Show("Les Donner a Bien Modifier");
               // txtNumdevis.Text = DataAccess.GeneratNums();
            }

        }

        //FFE =initialize ( Form For Editing )
        void InitializeFFE(string Num)
        {
            //BUttons
            bunifuFlatButton2.Text = "                Supprimer";
            bunifuFlatButton2.Iconimage = Properties.Resources.icons8_Trash_96px_1;
            bunifuFlatButton1.Text = "                    Save";
            bunifuFlatButton1.Iconimage = Properties.Resources.icons8_Checkmark_96px;
           // DGV
            dataGridView1.AllowUserToAddRows = false;
            //txtBox
            txtNumdevis.ReadOnly = true;

            var BL_Info = DA.Bl_Par_Devis(Num);
            if (!DA.IsDone)
            {
                MessageBox.Show("cette reference n'est pas existe");
                return;
            }
            FillInfo(BL_Info.Devis, BL_Info.Detail_Devis);

        }
        void FillInfo(DataTable Devis, DataTable Devis_Dtail)
        {
            txtNumdevis.Text = Devis.Rows[0][0].ToString();
            ComboClient.SelectedValue = Devis.Rows[0][1].ToString();
            txtObserv.Text = Devis.Rows[0][3].ToString();
            foreach (DataRow item in Devis_Dtail.Rows)
            {
                if (DA.IsArticlExist(item["REF"].ToString()))
                {
                    MessageBox.Show("l'Article \"" + item["REF"].ToString() + "\" Pas Exist ");
                    continue;
                }
                int TX = Convert.ToInt32(item["TXREMISE"]) * 100;

                dataGridView1.Rows.Add(new object[] { item["REF"], Convert.ToDecimal( item["PRIX_VENTEHT"]), int.Parse(item["QTE"].ToString()), TX, Convert.ToDecimal(item["PT_HT"]), Convert.ToDecimal(item["PT_TTC"] )});
            }
            
        }


        private void Ajouter_Devis_Load(object sender, EventArgs e)
        {
            this.Ref.DataSource = DAL.DataAccess.GetArticles();
            this.Ref.DisplayMember = "DESCRIPTION";
            this.Ref.ValueMember = "REF";
            this.Location = _LocationPoint;
            this.Size = _size;

            try
            {
             //   this.aRTICLESTableAdapter.Fill(this.gestion_De_StockDataSet.ARTICLES);
                ComboClient.DataSource = DataAccess.GetClient();
                ComboClient.DisplayMember = "RAISONSOCIALE";
                ComboClient.ValueMember = "IDCLIENT";
               
               
            }
            // had l method dyal   When khdama f  C#6 l fog 
            catch (Exception ex) //when( ex.InnerException is SqlException" you condition is true...")
            {
                if (ex.GetType().IsAssignableFrom(typeof(System.Data.SqlClient.SqlException)))
                {
                    //what you want to do when ThreadAbortException occurs  
                    MessageBox.Show("you should check is your Server running");
                    MessageBox.Show("anythign you do now is not gonna saved in our datatbase\n" +
                                     "so you should fix the problem first \n\n" +
                                  " Message Error : " + ex.Message + "");
                }

            }

        }
        // Timer Fonction
    

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "PU_HT")
            {
                PU_TTC_Calculate(e.RowIndex);
            }

            //  PU_TTC_Calculate(index);
        }
  
        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

            int index = e.RowIndex;
            string Cname = dataGridView1.Columns[e.ColumnIndex].Name;
            _Ref = dataGridView1.Rows[index].Cells["Ref"].Value.ToString();
            switch (Cname)
            {
                //  Ref Prix_vente Qte TXREMISE PU_HT PU_TTC
               
                case "Ref":

                    if (dataGridView1.Rows[index].Cells["Ref"].Value != null)
                    {
                        var PU_V = DA.GetArticlePrixVent(_Ref);
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



        private DataSet Ajouter_detail_devis()
        {
            #region Creating DataSets
            // @NUM,@IDCLIENT,@OBSERV
            DataSet ds = new DataSet();
            ds.Tables.Add("devis");
            ds.Tables["devis"].Columns.AddRange(new DataColumn[]
            {
                new DataColumn("NUM"),
                new DataColumn("IDCLIENT"),
                new DataColumn("OBSERV"),
            });

            //  Ref,  Qte,  PU,  PT_HTTC,  TXremis
         

            ds.Tables.Add("Detail_Devis");

            ds.Tables["Detail_Devis"].Columns.AddRange(new DataColumn[]
            {
                //@NumDvis,@REF,@QTE,@PRIX_Vent,@TXREMIS,@PT_HTTC
                new DataColumn("NumDvis"),
                new DataColumn("Ref"),
                new DataColumn("Qte"),
                new DataColumn("PU"),
                 new DataColumn("PT_HTTC"),
                  new DataColumn("TXremis"),
            });
            #endregion

            ds.Tables["devis"].Rows.Add(new object[] { txtNumdevis.Text, ComboClient.SelectedValue, txtObserv.Text });

            foreach (DataGridViewRow item in dataGridView1.Rows)
            {
                if (!item.IsNewRow && item.Cells[3].Value!=null)
                {
                    //       DA.Ajouter_BD(DataAccess.Ajouter.Devis,null, DetailDevisParams(item.Cells[0].Value, item.Cells[2].Value, item.Cells[1].Value, item.Cells[5].Value, tx));
                    int TXREMIS = int.Parse(item.Cells[3].Value.ToString());
                    decimal tx = (decimal)TXREMIS / 100;
                    // item.Cells[0].Value, item.Cells[2].Value, item.Cells[1].Value, item.Cells[5].Value, tx
                    ds.Tables["Detail_Devis"].Rows.Add(new object[] { txtNumdevis.Text,item.Cells[0].Value, item.Cells[2].Value, item.Cells[1].Value, item.Cells[5].Value, tx });
                }

               if (!item.IsNewRow && item.Cells[3].Value == null)
                {
                    // if the discount culumn is empty or null I  set THE VALUE  to  0 (By deafault)
                    //   DA.Ajouter_BD(DataAccess.Ajouter.Devis,null, DetailDevisParams(item.Cells[0].Value, item.Cells[2].Value, item.Cells[1].Value, item.Cells[5].Value));
                    ds.Tables["Detail_Devis"].Rows.Add(new object[] { txtNumdevis.Text, item.Cells[0].Value, item.Cells[2].Value, item.Cells[1].Value, item.Cells[5].Value, 0 });


                }

            }
            return ds;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
         //coulum index 6 == Button COlumn !!!! to remember
            if (e.ColumnIndex == 6 && e.RowIndex>=0 && !dataGridView1.Rows[e.RowIndex].IsNewRow)
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
                    DA.Suppr_Article_Devis(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString(), txtNumdevis.Text);
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


            UC.LabelText = LabelText ;

            UC.Allignment = ContentAlignment.MiddleLeft;
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
                animator1.Show(item, true,Animation.Transparent);

            }
        }

    
        void Hide_Component_WithANimation()
        {
            animator2.Hide(UC, true, Animation.HorizSlide);
            foreach (Control item in pnlContainer.Controls)
            {
                animator1.Hide(item, true,Animation.Transparent);
            }

            animator1.WaitAllAnimations();

            animator2.WaitAllAnimations();

        }
        #endregion

        private void bunifuImageButton1_Ajouter_Click(object sender, EventArgs e)
        {
            Hide_Component_WithANimation();

            new HomeForm(this.Location, this.Size).Show();
            this.Close();
        }

        private void BunifuImageButton1_Modifier_Click(object sender, EventArgs e)
        {
            Hide_Component_WithANimation();

            new Gere_Devis(this.Location,this.Size).Show();
            this.Close();
        }
     
    }
}

