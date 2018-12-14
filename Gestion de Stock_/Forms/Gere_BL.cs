
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
    public partial class Gere_BL : Form
    {
        Point _LocationPoint;
        Size _size;
        string NumBL;
        UC_LocationInForm UC = UC_LocationInForm.Instance;

        public Gere_BL(Point OwnerFormLocaion, Size OwnerFormSize)
        {
            InitializeComponent();
            StartTiming();
            _LocationPoint = OwnerFormLocaion;
            _size = OwnerFormSize;
            UC_Initializ();

        }


        private void Gere_BL_Load(object sender, EventArgs e)
        {

            this.Location = _LocationPoint;
            this.Size = _size;
            dataGridView1.DataSource = DataAccess.GetBL();
            DGVinitialize();
        }

        private void DGVinitialize()
        {

            dataGridView1.Columns[0].HeaderText = "Num";

            dataGridView1.Columns[1].HeaderText = "ID Client";
            dataGridView1.Columns[1].Width = 50;

            dataGridView1.Columns[2].HeaderText = "Date";
            dataGridView1.Columns[2].DefaultCellStyle.Format = "dd/MM/yyyy";

            dataGridView1.Columns[3].HeaderText = "Observation";


        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex < 0)
                return;


            NumBL = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();

            Detail_Devis_DGV(NumBL);
        }

        void Detail_Devis_DGV(string Num)
        {
            string[] selectedColumns = new[] { "REF", "QTE", "PRIX_VENTEHT", "PT_TTC" };

            DataTable dt = new DataView(DataAccess.GetDetailBL(Num)).ToTable(true, selectedColumns);

            dataGridView2.DataSource = dt;
        }


        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            //Hide_Component_WithANimation();
            //new Ajouter_Devis(this.Location, this.Size, NumBL).Show();
            //this.Hide();
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


            UC.LabelText = "Gérer BL";

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


        }

        void Show_Components()
        {

            foreach (Control item in pnlContainer.Controls)
            {
                animator1.Show(item, true, Animation.Transparent);

            }
            animator1.Show(bunifuFlatButton1, true, Animation.VertSlide);

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
            Hide_Component_WithANimation();

            new HomeForm(this.Location, this.Size).Show();
            this.Close();
        }

        private void bunifuFlatButton1_Click_1(object sender, EventArgs e)
        {
            Hide_Component_WithANimation();
            new Ajouter_BL(this.Location, this.Size, NumBL).Show();
            this.Hide();
        }
    }
}

