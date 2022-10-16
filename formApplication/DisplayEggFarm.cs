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
    public partial class DisplayEggFarm : Form
    {
        DataTable dtEggFarm;
        public DisplayEggFarm()
        {
            InitializeComponent();
        }

        private void frmEggFarmDisplay_Load(object sender, EventArgs e)
        {
            dtEggFarm = DB.Data("select * from eggFarm");
            dgvEggFarm.DataSource = dtEggFarm;
            dgvEggFarm.Columns["ID"].Visible = false;
            dgvEggFarm.ClearSelection();
            dgvEggFarm.Sort(dgvEggFarm.Columns["colRecordDate"], ListSortDirection.Descending);
        }

        bool IsTheSameCellValue(int column, int row)
        {
            DataGridViewCell cell1 = dgvEggFarm[column, row];
            DataGridViewCell cell2 = dgvEggFarm[column, row - 1];
            if (cell1.Value == null || cell2.Value == null)
            {
                return false;
            }
            return cell1.Value.ToString() == cell2.Value.ToString();
        }

        private void dgvHenFarm_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

        }
        private void dgvEggFarm_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
