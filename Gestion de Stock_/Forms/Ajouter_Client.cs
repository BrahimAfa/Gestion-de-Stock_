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
using Gestion_de_Stock_.UserControls;

namespace Gestion_de_Stock_.Forms
{
    /// <summary>
    /// Todo Later : 
    /// 1 Auto increament ID CLient 
    /// 2 make it readonly
    /// 
    /// thats all for now..
    /// </summary>
    public partial class Ajouter_Client : Form
    {
        public Ajouter_Client()
        {
            InitializeComponent();
        }
        Point _LocationPoint;
        Size _size;
        DataAccess DAT;
        UC_LocationInForm UC = UC_LocationInForm.Instance;
        public Ajouter_Client(Point OwnerFormLocaion, Size OwnerFormSize)
        {
            InitializeComponent();
            _LocationPoint = OwnerFormLocaion;
            _size = OwnerFormSize;
            StartTiming();
            UC_Initializ();

        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.Location = _LocationPoint;
            this.Size = _size;
        }

    

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            DAT = new DataAccess();
            try
            {
                //  @ID,@RaisonSocial,@Adresse,@Ville,@Tele
                SqlParameter[] _params =
                {

                new SqlParameter("@ID", txtID.Text),
                new SqlParameter("@RaisonSocial",txtRS.Text),
                new SqlParameter("@Adresse", txtAdresse.Text),
                new SqlParameter("@Ville", txtVille.Text),
                new SqlParameter("@Tele", txtTele.Text),
            

                };

                DAT.Ajouter_BD(DataAccess.Manage_Stock.Client, _params);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
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
            

            UC.LabelText = "Devis";

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

        private void bunifuImageButton1_Click_1(object sender, EventArgs e)
        {
            Hide_Component_WithANimation();
            (new HomeForm(this.Location, this.Size)).Show();
            this.Close();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            foreach (Control C in pnlContainer.Controls)
            {
                if (C is TextBox)
                {
                    (C as TextBox).Clear();
                }
            }
        }
    }
}
