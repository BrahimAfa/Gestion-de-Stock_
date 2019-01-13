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
    public partial class Facture_Client : Form
    {
        DataAccess Da;
        DataView dv_Filter;
        UC_LocationInForm UC = UC_LocationInForm.Instance;

        public int ChosedIndexFilter { get; set; }
        string[] ColumnChosed = { "NumFact", "IdClient", "DateFact" };
        int IDClient;
        public Facture_Client(int IdClient)
        {
            InitializeComponent();
            StartTiming();
            UC_Initializ();
            IDClient = IdClient;
            Da = new DataAccess();
            dataGridView1.DataSource = Da.GetDonnerFacture(IDClient);
            comboBox1.SelectedIndex = 0;
        }


        private void Facture_Cherch_Form_Load(object sender, EventArgs e) { }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {

            //Variable that change the column name in the selected change proprieter

            SearchBtn.Enabled = comboBox1.SelectedIndex != 0 ? true : false;

            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    TousFilter();
                    dataGridView1.DataSource = Da.GetDonnerFacture(IDClient);
                    break;
                case 1:
                    ChosedIndexFilter = 0;
                    NumFactFilterinitializ();
                    break;
                case 2:
                    ChosedIndexFilter = 2;
                    DateFactureFilterinitializ();
                    break;
            }
        }

        void NumFactFilterinitializ()
        {
            dateTimePicker1.Visible = false;
            textBox1.Visible = true;
            textBox1.BringToFront();
            label2.Visible = true;
            label2.Text = "Num de Facture :";
        }

        void DateFactureFilterinitializ()
        {
            textBox1.Visible = false;
            dateTimePicker1.Visible = true;
            dateTimePicker1.BringToFront();
            label2.Visible = true;
            label2.Text = "Date De Facture :";
        }
        void TousFilter()
        {

            textBox1.Visible = false;
            dateTimePicker1.Visible = false;
            label2.Visible = false;
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            if (ChosedIndexFilter == 0)
            {
                NumFactureFIlter();
            }
            else if (ChosedIndexFilter == 2)
            {
                DateFactureFilter();
            }
        }

        void NumFactureFIlter()
        {
            dv_Filter = new DataView(Da.GetDonnerFacture(IDClient));
            dv_Filter.RowFilter = $"{ColumnChosed[ChosedIndexFilter].ToString()} like '%{textBox1.Text}%'";
            dataGridView1.DataSource = dv_Filter;
        }



        void DateFactureFilter()
        {
            dv_Filter = new DataView(Da.GetDonnerFacture(IDClient));
            dv_Filter.RowFilter = $"{ColumnChosed[ChosedIndexFilter]} = '#{dateTimePicker1.Value.ToShortDateString()}#' ";
            dataGridView1.DataSource = dv_Filter;
        }
        int Index;
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

                    CM.Items.Add("Detaill...").Click += DetaillCM_Click;
                    CM.Show(dataGridView1, e.Location);


                }
            }
        }
        private void DetaillCM_Click(object sender, EventArgs e)
        {
            //    MessageBox.Show("detaill CLICKED ");
            new Facture_Detail(dataGridView1.Rows[Index].Cells[0].Value.ToString()).ShowDialog();
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


            UC.LabelText = "Facture de Client";

            UC.Allignment = ContentAlignment.MiddleLeft;
            UC.Location = new Point(0, 72);
            UC.Visible = false;
            pnlLogo.Controls.Add(UC);

            animator2.Show(UC, true, Animation.HorizSlide);


        }

        #endregion
    }
}
