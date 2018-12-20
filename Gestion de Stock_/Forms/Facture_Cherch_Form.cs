using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gestion_de_Stock_.DAL;
namespace Gestion_de_Stock_.Forms
{
    public partial class Facture_Cherch_Form : Form
    {
        DataAccess DT;
        DataView dv_Filter;
        public int ChosedIndexFilter { get; set; }
        string[] ColumnChosed = { "NumFact", "IdClient", "DateFact" };

        public Facture_Cherch_Form()
        {
            InitializeComponent();

            DT= new DataAccess();
            dataGridView1.DataSource = DT.GetDonnerFacture();
            comboBox1.SelectedIndex = 0;
        }

        private void Facture_Cherch_Form_Load(object sender, EventArgs e){}

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
            //Variable that change the column name in the selected change proprieter

            SearchBtn.Enabled = comboBox1.SelectedIndex != 0 ? true : false;
          
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    TousFilter();
                    dataGridView1.DataSource = DT.GetDonnerFacture();
                    break;
                case 1:
                    ChosedIndexFilter = 0;
                    NumFactFilterinitializ();
                    break;
                case 2:
                    ChosedIndexFilter = 1;
                    NumClientFilterinitializ();
                    break;
                case 3:
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
        void NumClientFilterinitializ()
        {
            dateTimePicker1.Visible = false;
            textBox1.Visible = true;
            textBox1.BringToFront();
            label2.Visible = true;
            label2.Text = "Num de Client :";
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
            if (ChosedIndexFilter==0)
            {
                NumFactureFIlter();
            }
            else if (ChosedIndexFilter == 1)
            {
                NumClientFIlter();
            }
            else if (ChosedIndexFilter == 2)
            {
                DateFactureFilter();
            }
        }

        void NumFactureFIlter()
        {
            dv_Filter = new DataView(DT.GetDonnerFacture());
            dv_Filter.RowFilter = $"{ColumnChosed[ChosedIndexFilter].ToString()} like '%{textBox1.Text}%'";
            dataGridView1.DataSource = dv_Filter;
        }

        void NumClientFIlter()
        {
            if (int.TryParse(textBox1.Text,out int Id))
            {
                dv_Filter = new DataView(DT.GetDonnerFacture());
                dv_Filter.RowFilter = $"{ColumnChosed[ChosedIndexFilter].ToString()} = {Id}";
                dataGridView1.DataSource = dv_Filter;
            }
            else
            {
                MessageBox.Show("Client only filtred with Number Id's!!\n'Enter a valid Number'");
            }
         
        }
        void DateFactureFilter()
        {
            dv_Filter = new DataView(DT.GetDonnerFacture());
            dv_Filter.RowFilter = $"{ColumnChosed[ChosedIndexFilter]} = '#{dateTimePicker1.Value.ToShortDateString()}#' ";
            dataGridView1.DataSource = dv_Filter;
        }
    }
}
