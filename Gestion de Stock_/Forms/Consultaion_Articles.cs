using AnimatorNS;
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
    public partial class Consultaion_Articles : Form
    {
        Point _LocationPoint;
        Size _size;
        public Consultaion_Articles(Point OwnerFormLocaion,Size OwnerFormSize)
        {
            InitializeComponent();
            StartTiming();
            _LocationPoint = OwnerFormLocaion;
            _size = OwnerFormSize;
            dataGridView1.DataSource = DAL.DataAccess.GetArticles();

            UC_Initializ();
        
        }
        
        UserControls.UC_LocationInForm UC = UserControls.UC_LocationInForm.Instance;
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.Location = _LocationPoint;
            this.Size = _size;
            dataGridView1.Columns[1].HeaderText = "ID Famille";
            dataGridView1.Columns[2].Width = 300;
            dataGridView1.Columns[3].HeaderText = "Prix Achat";
            dataGridView1.Columns[4].HeaderText = "Prix Vente";
            dataGridView1.Columns[5].HeaderText = "QTE";
            dataGridView1.Columns[6].HeaderText = "TVA";
            
            
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                foreach (DataGridViewRow item in dataGridView1.Rows)
                {
                    int qte = Convert.ToInt32(item.Cells[5].Value);
                    if (qte < 100)
                    {
                        item.DefaultCellStyle.BackColor = Color.FromArgb(226, 63, 63);
                        item.DefaultCellStyle.SelectionBackColor = Color.FromArgb(233, 106, 106);
                    }
                }
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


            UC.LabelText = "Articles";

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

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Hide_Component_WithANimation();

            new HomeForm(this.Location, this.Size).Show();
            this.Close();
        }
    }
}
