using AnimatorNS;
using Gestion_de_Stock_.DAL;
using Gestion_de_Stock_.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_de_Stock_.Forms
{
    public partial class Gere_Client : Form
    {
        //Point _LocationPoint;
        //Size size;
        DataView dv = new DataView();
        DataAccess DA = new DataAccess();
        int RowIndex;
        UC_LocationInForm UC = UC_LocationInForm.Instance;
        public Gere_Client()
        {

            InitializeComponent();
          
            StartTiming();
            UC_Initializ();
        }

        private void DGVinitialize()
        {
            dataGridView1.Columns[0].HeaderText = "ID Client";
        
            dataGridView1.Columns[1].HeaderText = "Raison Sociale";
            dataGridView1.Columns[2].HeaderText = "Adresse";
            dataGridView1.Columns[3].HeaderText = "Ville";
            dataGridView1.Columns[4].HeaderText = "TELE";

        }

        private void Gere_Client_Load(object sender, EventArgs e)
        {
           
            //this.Location = _LocationPoint;
            //this.Size = size;
            dataGridView1.DataSource = DataAccess.GetClient();
            DGVinitialize();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          
            RowIndex = e.RowIndex;
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("DO you want to delete this Client", "Supprimer", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                DA.Supprimer_BD(DataAccess.Manage_Stock.Client, dataGridView1.Rows[RowIndex].Cells[0].Value.ToString());
                if (DA.IsDone)
                {
                    // i refshed datagridview with dv(dataview) to keep the same filter User Chosed
                    dv.Table = DataAccess.GetClient();
                    dataGridView1.DataSource = dv;
                    // we shoud pay attention if there is only one article in table and we selected a row in the same position (out of range execption)
                    MessageBox.Show("Bien Supprimer", "supprimer", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBox1.Text))
            {
                dv.Table = DataAccess.GetClient();
                dv.RowFilter = "RAISONSOCIALE LIKE '%" + textBox1.Text + "%'";
                dataGridView1.DataSource = dv;
            }
            else
            {
                dv = new DataView();
                dataGridView1.DataSource = DataAccess.GetClient();
            }
          
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {

            Modifier_Client ModifyForm = new Modifier_Client(dataGridView1.Rows[RowIndex]);

            ModifyForm.StartPosition = FormStartPosition.CenterScreen;
            //animator2.ShowSync(ModifyForm, false, Animation.Scale);
            ModifyForm.ShowDialog(this);
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


            UC.LabelText = "Gérer Clients";

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
        public void RefreshDGV()
        {
            dataGridView1.DataSource = DataAccess.GetClient();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
          //  Hide_Component_WithANimation();

          //  new HomeForm(this.Location, this.Size).Show();
            this.Close();
        }
    }
}
