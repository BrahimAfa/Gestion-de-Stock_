using Gestion_de_Stock_.DAL;
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
    public partial class Modifier_Client : Form
    {
        public Modifier_Client(DataGridViewRow ClientRow)
        {
            InitializeComponent();
            dr = ClientRow;
        }
        DataGridViewRow dr;
        DataAccess DA = new DataAccess();
        private void Modifier_Client_Load(object sender, EventArgs e)
        {
            InfoInitialize();
        }
        void InfoInitialize()
        {
            lblID.Text = dr.Cells[0].Value.ToString();
            txtRS.Text = dr.Cells[1].Value.ToString();
            txtAdress.Text = dr.Cells[2].Value.ToString();
            txtVille.Text = dr.Cells[3].Value.ToString();
            txtTele.Text = dr.Cells[4].Value.ToString();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            //@ID,@RaisonSocial,@Adresse,@Ville,@Tele
            SqlParameter[] _params =
            {
                new SqlParameter("@ID",int.Parse(lblID.Text)),
                new SqlParameter("@RaisonSocial",txtRS.Text),
                new SqlParameter("@Adresse",txtAdress.Text),
                new SqlParameter("@Ville",txtVille.Text),
                new SqlParameter("@Tele",txtTele.Text),

            };
            DA.Modifier_BD(DataAccess.Manage_Stock.Client, _params);
            if (DA.IsDone)
            {
                this.BeginInvoke((MethodInvoker)delegate { (this.Owner as Gere_Client).RefreshDGV(); });
                MessageBox.Show("the Client Is been Modified!!");
            }

        }
    }
}
