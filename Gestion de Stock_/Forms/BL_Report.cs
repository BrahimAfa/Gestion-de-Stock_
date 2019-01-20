using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gestion_de_Stock_.Reports;
using System.Windows.Forms;
using Gestion_de_Stock_.DAL;
using AnimatorNS;

namespace Gestion_de_Stock_.Forms
{
    public partial class BL_Report : Form
    {
        //Point _LocationPoint;
        //Size _size;

        UserControls.UC_LocationInForm UC = UserControls.UC_LocationInForm.Instance;
        bool ISMaxiMized = false;
        public BL_Report ()
        {
            InitializeComponent();
            //_LocationPoint = OwnerFormLocaion;
            //_size = OwnerFormSize;

            StartTiming();
            UC_Initializ("BL Report");
            MaximizeWindow();
            ISMaxiMized = true;
        }
        public BL_Report(string NumBL)
        {
            InitializeComponent();
            //_LocationPoint = OwnerFormLocaion;
            //_size = OwnerFormSize;

            StartTiming();
            UC_Initializ("BL Report");
            PrintBLInitializ(NumBL);
        }
        void PrintBLInitializ(string numdevis)
        {
            foreach (Control c in groupBox1.Controls)
            {
                c.Visible = false;
            }
            BL_Reporting rp = new BL_Reporting();
            DataTable dt = DA.GetBLInfos(numdevis);
            rp.SetDataSource(dt);

            crystalReportViewer1.ReportSource = rp;
        }
        DataAccess DA = new DataAccess();
        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("le champe est Vide Entrer Num de Bon de Livraison");
                return;
            }

            else if (textBox1.Text.Length < 10)
            {
                MessageBox.Show("Num de BL est Incorecte !!!");
                return;
            }
            DataTable dt = DA.GetBLInfos(textBox1.Text);
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Cette Num Pas Existe !");
                return;
            }

            BL_Reporting rp = new BL_Reporting();

            rp.SetDataSource(dt);

            crystalReportViewer1.ReportSource = rp;
        }

        private void Devis_Report_Load(object sender, EventArgs e)
        {
            //this.Location = _LocationPoint;
            //this.Size = _size;
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

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            //Hide_Component_WithANimation();

            //new HomeForm(this.Location, this.Size).Show();
            this.Close();
        }
        private void MaximizeWindow()
        {
            var rectangle = Screen.FromControl(this).Bounds;
            this.FormBorderStyle = FormBorderStyle.None;
            Size = new Size(rectangle.Width, rectangle.Height);
            Location = new Point(0, 0);
            Rectangle workingRectangle = Screen.PrimaryScreen.WorkingArea;
            this.Size = new Size(workingRectangle.Width, workingRectangle.Height);
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            if (ISMaxiMized)
            {
                this.Size = new Size(832, 491);
                this.CenterToScreen();
                ISMaxiMized = false;
            }
            else
            {
                MaximizeWindow();
                ISMaxiMized = true;
            }
        }
    }
}
