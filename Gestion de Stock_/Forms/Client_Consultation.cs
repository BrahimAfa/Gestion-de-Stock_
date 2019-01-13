using AnimatorNS;
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
    public partial class Client_Consultation : Form
    {
        DAL.DataAccess Da = new DAL.DataAccess();
        string[] ColumnChosed = { "[ID Client]", "[Raison Sociale]", "[Tele]" };
        UC_LocationInForm UC = UC_LocationInForm.Instance;

        public Client_Consultation()
        {;
            InitializeComponent();
            StartTiming();
            UC_Initializ();
            dataGridView1.DataSource = Da.GetClientReg();
        }
        int Index;
        private DataView dv_Filter;

        public int ChosedIndexFilter { get; private set; }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            Index = dataGridView1.HitTest(e.X, e.Y).RowIndex;
            // MessageBox.Show(Index.ToString());

            if (Index >= 0)
            {

                if (e.Button == MouseButtons.Right)
                {
                    dataGridView1.Rows[Index].Selected = true;
                    ContextMenuStrip CM = new ContextMenuStrip();

                    CM.Items.Add($"Detaill de CLient {dataGridView1.Rows[Index].Cells[0].Value.ToString()}").Click += DetaillCM_Click;
                    CM.Show(dataGridView1, e.Location);


                }
            }
        }
        private void DetaillCM_Click(object sender, EventArgs e)
        {
            //    MessageBox.Show("detaill CLICKED ");
            new Facture_Client(Convert.ToInt32(dataGridView1.Rows[Index].Cells[0].Value.ToString())).ShowDialog();
        }
        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {

            //Variable that change the column name in the selected change proprieter

            SearchBtn.Enabled = comboBox1.SelectedIndex != 0 ? true : false;

            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    TousFilter();
                    dataGridView1.DataSource = Da.GetClientReg();
                    break;
                case 1:
                    ChosedIndexFilter = 0;
                    NumClientFilterinitializ();
                    break;
                case 2:
                    ChosedIndexFilter = 1;
                    RSFilterinitializ();
                    break;
                case 3:
                    ChosedIndexFilter = 2;
                    TeleFilterinitializ();
                    break;

            }
        }
        void NumClientFilterinitializ()
        {
            textBox1.Visible = true;
            textBox1.BringToFront();
            label2.Visible = true;
            label2.Text = "Num de Client :";
        }
        void RSFilterinitializ()
        {
           
            textBox1.Visible = true;
            textBox1.BringToFront();
            label2.Visible = true;
            label2.Text = "Raison Social :";
        }
   
        void TeleFilterinitializ()
        {
            textBox1.Visible = true;
            textBox1.BringToFront();
            label2.Visible = true;
            label2.Text = "Tele Client :";
        }
        void TousFilter()
        {

            textBox1.Visible = false;
         
            label2.Visible = false;
        }


        private void SearchBtn_Click(object sender, EventArgs e)
        {
            if (ChosedIndexFilter == 0)
            {
                NumClientFIlter();
            }
            else if (ChosedIndexFilter == 1)
            {
                RSFIlter();
            }
            else if (ChosedIndexFilter == 2)
            {
                TeleFIlter();
            }
        }

        void NumClientFIlter()
        {
            dv_Filter = new DataView(Da.GetClientReg());
            dv_Filter.RowFilter = $"{ColumnChosed[ChosedIndexFilter].ToString()} = {textBox1.Text}";
            dataGridView1.DataSource = dv_Filter;
        }
        void RSFIlter()
        {
            dv_Filter = new DataView(Da.GetClientReg());
            dv_Filter.RowFilter = $"{ColumnChosed[ChosedIndexFilter].ToString()} like '%{textBox1.Text}%'";
            dataGridView1.DataSource = dv_Filter;
        }
        void TeleFIlter()
        {
            dv_Filter = new DataView(Da.GetClientReg());
            dv_Filter.RowFilter = $"{ColumnChosed[ChosedIndexFilter].ToString()} like '%{textBox1.Text}%'";
            dataGridView1.DataSource = dv_Filter;
        }


        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
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


            UC.LabelText = "Clients";

            UC.Allignment = ContentAlignment.MiddleLeft;
            UC.Location = new Point(0, 72);
            UC.Visible = false;
            pnlLogo.Controls.Add(UC);

            animator2.Show(UC, true,Animation.HorizSlide);


        }

        #endregion
    }
}
