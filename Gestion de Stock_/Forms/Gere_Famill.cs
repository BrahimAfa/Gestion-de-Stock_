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
    public partial class Gere_Famill : Form
    {   DataAccess da;
        DataView dv;
        public Gere_Famill()
        {
            InitializeComponent();
             da= new DataAccess();
            dataGridView1.DataSource = DataAccess.GetFamilles();
        }
     
        private void Gere_Famill_Load(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(textBox1.Text))
            {
               dataGridView1.DataSource = DataAccess.GetFamilles();
                return;
            }

            filterFamille(textBox1.Text);
        }
        void filterFamille(string filter)
        {
            dv = new DataView();
            dv.Table = DataAccess.GetFamilles();
            dv.RowFilter = "FAMILLE like  '%" + filter + "%'";
            dv.Sort = "IDFAMILLE";

            dataGridView1.DataSource = dv;
        }
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;


             txtIdfamille.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtFamille.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtFamille.Text))
            {
                MessageBox.Show("le champ Famille ne doit pas être vide");
                return;
            }
            if (da.ModifierFamille(txtIdfamille.Text,txtFamille.Text))
            {
                MessageBox.Show("Famille modifiée avec succès", "Succés", MessageBoxButtons.OK, MessageBoxIcon.Information) ;
            }
        }
    }
}
