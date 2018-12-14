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

namespace Gestion_de_Stock_.Forms
{
    public partial class Ajouter_Famille : Form
    {
        public Ajouter_Famille()
        {
            InitializeComponent();
        }
   
        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
          
            this.Close();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            DAL.DataAccess da = new DAL.DataAccess();

            if (String.IsNullOrEmpty(textBox1.Text))
            {
                return;
            }
            SqlParameter[] _params =
            {
                new SqlParameter("@famille",textBox1.Text)
            };
            da.Ajouter_BD(DAL.DataAccess.Manage_Stock.Famille, _params);

            var f = (Ajouter_Articles)this.Owner;
            f.Remplir_combo();
            f.ComboFamille.SelectedIndex = f.ComboFamille.Items.Count - 1;
            MessageBox.Show("Cette Famille a bien ajouter", "Ajouter réussite", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
