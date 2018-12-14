using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_de_Stock_.UserControls
{
    public partial class UC_LocationInForm : UserControl
    {
        // Location i main form 0,72
        static private UC_LocationInForm _instance;

        static public UC_LocationInForm Instance
        {
            get {
                if (_instance is null)
                {
                    _instance = new UC_LocationInForm(); 
                }
                return _instance;
            }
            set { _instance = value; }
        }


        public ContentAlignment Allignment
        {
           
            set { label1.TextAlign = value; }
        }


        public string LabelText
        {
            get { return label1.Text; }
            set { label1.Text = value; }
        }

        public UC_LocationInForm()
        {
            InitializeComponent();
            
        }

        private void LocationInForm_Load(object sender, EventArgs e)
        {

        }
    }

}
