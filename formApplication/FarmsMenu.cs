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
    public partial class FarmsMenu : Form
    {
       
        public FarmsMenu()
        {
            InitializeComponent();
        }

        private void pnlHenFarm_Click(object sender, EventArgs e)
        {
            if (frmMode == 0)
            {
                formApplication.HenFarm frm = new formApplication.HenFarm();
                frm.ShowDialog();
            }
           else
            {
                formApplication.DisplayHenFarm frm = new formApplication.DisplayHenFarm();
                frm.ShowDialog();
            }
        }

        private void pnlEggFarm_Click(object sender, EventArgs e)
        {
            if (frmMode == 0)
            {
                formApplication.EggFarm frm = new formApplication.EggFarm();
                frm.ShowDialog();
            }
            else
            {
                formApplication.DisplayEggFarm frm = new formApplication.DisplayEggFarm();
                frm.ShowDialog();
            }
        }
        SortedDictionary<string, SortedDictionary<string, decimal>> controlsDetails = new SortedDictionary<string, SortedDictionary<string, decimal>>();
        SortedDictionary<string, SortedDictionary<string, decimal>> controlsResult = new SortedDictionary<string, SortedDictionary<string, decimal>>();

        private void frmFarms_Load(object sender, EventArgs e)
        {
           panel1.BackgroundImage =formApplication.Properties.Resources.ادخال1;
            frmMode = 0;
        }
        bool firstLoad = true;
        private void FarmsMenu_Resize(object sender, EventArgs e)
        {
            if (firstLoad)
            {
                formApplication.ResizeForm.initialFormHeight = 757;
                formApplication.ResizeForm.initialFormWidth = 1303;
                formApplication.ResizeForm.setContolDetails(this, controlsDetails);
                formApplication.ResizeForm.setControlResult(this,controlsDetails, controlsResult);
                firstLoad = false;
                return;
            }
            ResizeForm.changeControls(this, controlsResult);
        }
        int frmMode = 0;
        private void pnlView_Click(object sender, EventArgs e)
        {
            panel1.BackgroundImage = formApplication.Properties.Resources.عرض1;
            frmMode = 0;
            frmMode = 1;
        }

        private void pnlEnter_Click(object sender, EventArgs e)
        {
            panel1.BackgroundImage = formApplication.Properties.Resources.ادخال1;
            frmMode = 0;
        }

        private void pnlEnter_Paint(object sender, PaintEventArgs e)
        {

        }

  

        private void panel2_Click_1(object sender, EventArgs e)
        {
            formApplication.CreateReports frm = new formApplication.CreateReports();
            frm.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
