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


namespace Gestion_de_Stock_
{
    public partial class Form1 : Form
    {
        public Form1()
        {


            // this.WindowState = FormWindowState.Minimized;
            (new Forms.HomeForm()).Show();
        }

        
  
        private void button1_Click(object sender, EventArgs e)
        {

         //   var f = new Forms.HomeForm();
         //   f.Location = new Point (this.Location.X,this.Location.Y);
         ////   f.DesktopLocation = new Point(this.DesktopLocation.X, this.DesktopLocation.Y);

         //   f.ShowDialog(this);

       }
        private void Form1_Load(object sender, EventArgs e)
        {
            //  this.WindowState = FormWindowState.Minimized;
           
       


        }
    } }
