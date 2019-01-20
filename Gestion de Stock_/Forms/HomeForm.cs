using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using AnimatorNS;
using Gestion_de_Stock_.DAL;
using System.Data.SqlClient;
using System.Threading;

namespace Gestion_de_Stock_.Forms
{
    public partial class HomeForm : Form
    {
        UserControls.UC_LocationInForm UC = UserControls.UC_LocationInForm.Instance;
        public bool IsMaximized { get; set; } = false;
        public HomeForm()
        {
            InitializeComponent();
            StartTiming();
            //_LocationPoint = getScreenCenter();
          
        }
        //Point _LocationPoint ;
        //Size size;
  
        //public HomeForm(Point P,Size S)
        //{
        //    InitializeComponent();
        //    StartTiming();
        //    _LocationPoint = P;
        //    size = S;
        //}
      //  DataAccess DAT;
      private void RadPanoramaInitializ()
        {
            radPanorama1.PanoramaElement.ScrollBar.Visibility = Telerik.WinControls.ElementVisibility.Hidden;
            radPanorama1.PanoramaElement.BackColor = Color.FromArgb(240, 240, 240);
            radPanorama1.PanoramaElement.PanelImage = null;
            radPanorama1.Visible = false;
        }
        private void HomeForm_Load(object sender, EventArgs e)
        {
            IsMaximized = false;

            //this.Location = _LocationPoint;
            //this.Size = size;
            MaximizeWindow();
            RadPanoramaInitializ();
            UC_Initializ();
         
            LiveTilAnimation(LivetileClient);
            LiveTilAnimation(livetileArticles);
            LiveTilAnimation(LiveTileGereBL);
            LiveTilAnimation(LiveTileGereDevis);

            radPanorama1.AllowDragDrop = false;

            ConnectioChecker();



        }
        void ConnectioChecker()
        {
            DataAccess.open();
            DataAccess.close();
            if (!DataAccess.cnxChecker)
            {
                radPanorama1.Enabled = false;
            }
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("voulez-vous quitter cette application?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2, MessageBoxOptions.RightAlign) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        #region Fonctions

        void Hide_Component_WithANimation()
        {
            animator2.Hide(UC, true, Animation.HorizSlide);
          
           animator1.Hide(this.radPanorama1, true, Animation.Transparent);
         
            animator1.WaitAllAnimations();

            animator2.WaitAllAnimations();

        }
        void UC_Initializ()
        {


            UC.LabelText = "Home";
            UC.Location = new Point(0, 72);
            UC.Visible = false;
            pnlLogo.Controls.Add(UC);
            animator2.Show(UC,true,Animation.HorizSlide);
           
            animator1.Show(radPanorama1,true);
            //   animator1.WaitAllAnimations();

        }

        void LiveTilAnimation(RadLiveTileElement Livetile)
        {
            Livetile.ContentChangeInterval = 3000;
            Livetile.TransitionType = ContentTransitionType.SlideLeft;
            Livetile.Items.Add(new LightVisualElement()
            {
                Text = "Modification",
                TextAlignment = ContentAlignment.TopCenter,
                Font = new Font("Century Gothic", 12, GraphicsUnit.Point),
                Padding = new Padding(4, 25, 0, 0),
                ForeColor = Color.WhiteSmoke,
                ShouldHandleMouseInput = false,

                NotifyParentOnMouseInput = true
            
            });
            Livetile.Items.Add(new LightVisualElement()
            {
                Text = "Suppression",
                TextAlignment = ContentAlignment.TopCenter,
                Padding = new Padding(4, 25, 0, 0),
                Font = new Font("Century Gothic", 12, GraphicsUnit.Point),
                ShouldHandleMouseInput = false,
                ForeColor = Color.WhiteSmoke,
                NotifyParentOnMouseInput = true

            });


        }

        #region Time_Fonction
        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        void StartTiming()
        {
         
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

        #endregion

        #endregion

        private void tileAddArticles_Click(object sender, EventArgs e)

        {
         
         //   Hide_Component_WithANimation();
         
        
            //animator1.WaitAnimation(this);
            // this.Hide();
 
            new Ajouter_Articles().ShowDialog(); ;
            
          //  animator1.Show(_Articles);
       
           

            //  animator1.WaitAllAnimations();

        }

        private void AddClient_Click(object sender, EventArgs e)
        {
            ///Hide_Component_WithANimation();
          
           new Ajouter_Client().ShowDialog();
           // this.Hide();

        }

        private void radTileElement1_Click(object sender, EventArgs e)
        {
           // Hide_Component_WithANimation();
            
           new Ajouter_Devis().ShowDialog();

           // this.Hide();

        }

        private void radTileElement2_Click(object sender, EventArgs e)
        {
           // Hide_Component_WithANimation();
           
          new Ajouter_BL().ShowDialog();
          //  this.Hide();
           
        }

        private void tileConsultation_Click(object sender, EventArgs e)
        {
          //  Hide_Component_WithANimation();

            new Consultaion_Articles().ShowDialog();
           // this.Hide();
        }

        private void livetileArticles_Click(object sender, EventArgs e)
        {
            //Hide_Component_WithANimation();

            new Gere_Articles().ShowDialog();
            //this.Hide();
        }

        private void LivetileClient_Click(object sender, EventArgs e)
        {
           // Hide_Component_WithANimation();

            new Gere_Client().ShowDialog();
          //  this.Hide();
        }

        private void LiveTileGereDevis_Click(object sender, EventArgs e)
        {
            //Hide_Component_WithANimation();

            new Gere_Devis().ShowDialog();
            //this.Hide();
        }

        private void LiveTileGereBL_Click(object sender, EventArgs e)
        {

         //   Hide_Component_WithANimation(   );
            new Gere_BL().ShowDialog();
           // this.Hide();
        }
       
        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {

            //if (!IsMaximized)
            //{
            //    MaximizeWindow();
            //}
            //else
            //{
            //    //WindowState = FormWindowState.Normal;
            //    ResizableWindow();
            //    IsMaximized = false;
            //}

            //}
            //else
            //{
            //    
            //    ResizableWindow();
            //}
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

        //private void ResizableWindow()
        //{
        //   // this.ControlBox = false;
        //    this.Size = new Size(832, 491);
        //    this.Location = getScreenCenter();
            
        //    //this.FormBorderStyle = FormBorderStyle.SizableToolWindow;
        //}

        private void radTileDevisRaport_Click(object sender, EventArgs e)
        { 
          //  Hide_Component_WithANimation();
            new Devis_Report().ShowDialog();
          //  this.Hide();
        }

        private void radTileElement10_Click(object sender, EventArgs e)
        {
            //Hide_Component_WithANimation();
            new Reglement_Form().ShowDialog();
        }

        private void radTileElement11_Click(object sender, EventArgs e)
        {
            new Facture_Cherch_Form().ShowDialog();
        }

        private void ConsultClient_Click(object sender, EventArgs e)
        {
            new Client_Consultation().ShowDialog();
        }

        private void radTileBLRaport_Click(object sender, EventArgs e)
        {
            new BL_Report().ShowDialog();
        }

        private void LiveTileGereFamilles_Click(object sender, EventArgs e)
        {
            new Gere_Famill().ShowDialog();
        }
    }
}
