using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gestion_de_Stock_.DAL;
using System.Windows.Forms;
using System.Data.SqlClient;
using Gestion_de_Stock_.UserControls;
using AnimatorNS;

namespace Gestion_de_Stock_.Forms
{
    public partial class Gere_Articles : Form
    {
        DataView dv = new DataView();
        DAL.DataAccess DA = new DataAccess();
       // Point _LocationPoint;
       

        UC_LocationInForm UC = UC_LocationInForm.Instance;

        public Gere_Articles()
        {
            InitializeComponent();

            StartTiming();
            UC_Initializ();
        }

        private void Gere_Articles_Load(object sender, EventArgs e)
        { 
            //comboBox1.
          //  this.Location = _LocationPoint;
           
            dataGridView1.DataSource = DataAccess.GetArticles();
            comboBox1.SelectedIndex = 0;
           
            DGVinitialize();
          
        }





        #region Fonction

        enum FilterOption
        {
            Description,
            PrixAchat,
            PrixVent,
            Qte
        }

        private void DGVinitialize()
        {
            dataGridView1.Columns[1].HeaderText = "ID Famille";
            dataGridView1.Columns[2].Width = 300;
            dataGridView1.Columns[3].HeaderText = "Prix Achat";
            dataGridView1.Columns[4].HeaderText = "Prix Vente";
            dataGridView1.Columns[5].HeaderText = "QTE";
            dataGridView1.Columns[6].HeaderText = "TVA";
        }


        void Filter(FilterOption filter, string Conditoin)
        {
            switch (filter)
            {
                case FilterOption.Description:
                    DescriptionFilter(Conditoin);
                    break;
                case FilterOption.PrixAchat:
                    Main_Filter(0, Conditoin);
                    break;
                case FilterOption.PrixVent:
                    Main_Filter(1, Conditoin);
                    break;
                case FilterOption.Qte:
                    Main_Filter(2, Conditoin);
                    break;
                default:
                    break;
            }
        }

        void DescriptionFilter(string filte)
        {
            dv.Table = DataAccess.GetArticles();
            dv.RowFilter = "DESCRIPTION like  '%" + filte + "%'";
            dv.Sort = "REF";

            dataGridView1.DataSource = dv;
        }

        void Main_Filter(int index, string cond)
        {
            switch (Comboindex)
            {
                case 0:
                    betweenFilter(index, int.Parse(txtmin.Text), int.Parse(txtMax.Text));
                    break;
                case 1:
                    LessThaneFilter(index, cond);
                    break;
                case 2:

                    MoreThaneFilter(index, cond);
                    break;
                default:
                    break;
            }
        }


        string[] ColumnName = { "PU_ACHAT", "PU_VENTE", "QTE_STOCK" };

        void MoreThaneFilter(int ColumnIndex, string Condition)
        {

            dv.Table = DataAccess.GetArticles();
            dv.RowFilter = "" + ColumnName[ColumnIndex] + ">'" + Condition + "'";
            dv.Sort = ColumnName[ColumnIndex];
            dataGridView1.DataSource = dv;
        }

        void LessThaneFilter(int ColumnIndex, string Condition)
        {

            dv.Table = DataAccess.GetArticles();
            dv.RowFilter = "" + ColumnName[ColumnIndex] + "<'" + Condition + "'";
            dv.Sort = ColumnName[ColumnIndex];
            dataGridView1.DataSource = dv;
        }

        void betweenFilter(int ColumnIndex, int Min, int Max)
        {

            dv.Table = DataAccess.GetArticles();
            dv.RowFilter = "" + ColumnName[ColumnIndex] + ">" + Min + " and " + ColumnName[ColumnIndex] + "<" + Max + "";
            dv.Sort = ColumnName[ColumnIndex];
            dataGridView1.DataSource = dv;
        }
        #endregion
 

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {


            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    dataGridView1.DataSource = DataAccess.GetArticles();
                    break;
                case 1:
                    Filter(FilterOption.Description, textBox1.Text);
                    break;
                case 2:
                    Filter(FilterOption.PrixAchat, textBox1.Text);
                    break;
                case 3:
                    Filter(FilterOption.PrixVent, textBox1.Text);
                    break;
                case 4:
                    Filter(FilterOption.Qte, textBox1.Text);
                    break;
               
                default:
                    break;
            }
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    dataGridView1.DataSource = DataAccess.GetArticles();
                    ComponentsHIde();
                    break;
                case 1 :
                    ComponentsHIde();
                    animator1.Show(textBox1);
                    textBox1.Text = "";
                    break;
                case 2:
                    ComponentsHIde();
                    animator1.Show(ComboPU);
                   
                    break;
                case 3:
                    ComponentsHIde();
                    animator1.Show(ComboPU);
                    break;
                case 4:
                    ComponentsHIde();
                    animator1.Show(ComboPU);
                    break;

                default:
                    break;
            }
        }
        
        void ComponentsHIde(bool vis =false)
        {
            textBox1.Visible = false;
            txtMax.Visible = false;
            txtmin.Visible = false;
            ComboPU.Visible = vis;
      
        }

      
        int Comboindex;
        private void ComboPU_SelectedIndexChanged(object sender, EventArgs e)
        {
            Comboindex = ComboPU.SelectedIndex;
            switch (ComboPU.SelectedIndex)
            {
                case 0:

                    ComponentsHIde(true);
                    animator1.Show(txtmin);
                    animator1.Show(txtMax);
                    txtmin.Text="Min";
                    txtMax.Text = "Max";
                    break;
                case 1:
                    ComponentsHIde(true);
                    animator1.Show(textBox1);
                    textBox1.Text = "";
                    
                    break;
                case 2:
                    ComponentsHIde(true);
                    animator1.Show(textBox1);
                    textBox1.Text = "";
                    break;
                default:
                    break;
            }
        }

 
        int RowIndex;
        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            //   string Ref = dataGridView1.Rows[RowIndex].Cells[0].Value.ToString();
            if (MessageBox.Show("DO you want to delete this Article","Supprimer",MessageBoxButtons.OKCancel)==DialogResult.OK)
            {
                DA.Supprimer_BD(DataAccess.Manage_Stock.Article, dataGridView1.Rows[RowIndex].Cells[0].Value.ToString());
                if (DA.IsDone)
                {
                    // i refshed datagridview with dv(dataview) to keep the same filter User Chosed
                    dv.Table = DataAccess.GetArticles();
                    dataGridView1.DataSource = dv;
                    // we shoud pay attention if there is only one article in table and we selected a row in the same position (out of range execption)
                    MessageBox.Show("Bien Supprimer", "supprimer", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
       
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            RowIndex = e.RowIndex;
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            //q
            try
            {
                if (RowIndex<0)
                {
                    return;
                }
                Modifier_Article ModifyForm = new Modifier_Article(dataGridView1.Rows[RowIndex]);
                //dataGridView1.Rows[RowIndex].Selected = false;
                ModifyForm.StartPosition = FormStartPosition.CenterScreen;
                //animator2.ShowSync(ModifyForm, false, Animation.Scale);
                ModifyForm.ShowDialog(this);
            }
            catch (Exception EX)
            {

                MessageBox.Show(EX.Message,"Exeception",MessageBoxButtons.OK,MessageBoxIcon.Information);
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

        void UC_Initializ()
        {


            UC.LabelText = "Gérer Articles";

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
            bunifuFlatButton1.Hide();
            bunifuFlatButton2.Hide();

        }

        void Show_Components()
        {

            foreach (Control item in pnlContainer.Controls)
            {
                animator1.Show(item, true, Animation.Transparent);

            }
            animator1.Show(bunifuFlatButton1, true, Animation.VertSlide);
            animator1.Show(bunifuFlatButton2, true, Animation.VertSlide);
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

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
           // Hide_Component_WithANimation();

          //  new HomeForm(this.Location, this.Size).Show();
            this.Close();
        }
    }
}
