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
    public partial class DisplayHenFarm : Form
    {
        DataTable dtHenFarm;
        public DisplayHenFarm()
        {
            InitializeComponent();
        }

        private void frmHenFarmDisplay_Load(object sender, EventArgs e)
        {
            dtHenFarm = DB.Data("select * from henFarm");
            dgvHenFarm.DataSource = dtHenFarm;
            dgvHenFarm.Columns["ID"].Visible = false;
            dgvHenFarm.ClearSelection();
            dgvHenFarm.Sort(dgvHenFarm.Columns["colRecordDate"], ListSortDirection.Descending);

        }

        bool IsTheSameCellValue(int column, int row)
        {
            DataGridViewCell cell1 = dgvHenFarm[column, row];
            DataGridViewCell cell2 = dgvHenFarm[column, row - 1];
            if (cell1.Value == null || cell2.Value == null)
            {
                return false;
            }
            return cell1.Value.ToString() == cell2.Value.ToString();
        }

        private void dgvHenFarm_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {

        }

        private void dgvHenFarm_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

        }
    }
}
