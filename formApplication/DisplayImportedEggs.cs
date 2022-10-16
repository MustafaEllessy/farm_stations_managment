using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formApplication
{
    public partial class DisplayImportedEggs : Form
    {
        public DisplayImportedEggs()
        {
            InitializeComponent();
        }
        DataTable dtImportedEggs;
        private void frmImportedEggsDisplay_Load(object sender, EventArgs e)
        {
            dtImportedEggs = DB.Data("select * from ImportedEggs");
            dgvFarmEggsStore.DataSource = dtImportedEggs;
            dgvFarmEggsStore.Columns["ID"].Visible = false;
            dgvFarmEggsStore.ClearSelection();
        }

        private void dgvFarmEggsStore_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
