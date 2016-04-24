using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace PCMS
{
    public partial class frmReports : MetroForm 
    {
        public frmReports()
        {
            InitializeComponent();
        }

        private void metroGrid6_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmReports_Load(object sender, EventArgs e)
        {
            dtpYear.ShowUpDown = true;
            
        }
    }
}
