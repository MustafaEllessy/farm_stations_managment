using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace formApplication
{
    public partial class ReportCharts : Form
    {
        public ReportCharts()
        {
            InitializeComponent();
        }
        SortedDictionary<string, SortedDictionary<string, decimal>> controlsDetails = new SortedDictionary<string, SortedDictionary<string, decimal>>();
        SortedDictionary<string, SortedDictionary<string, decimal>> controlsResult = new SortedDictionary<string, SortedDictionary<string, decimal>>();
        bool firstLoad = true;
        private void FarmsMenu_Resize(object sender, EventArgs e)
        {
            if (firstLoad)
            {
                formApplication.ResizeForm.initialFormHeight = 757;
                formApplication.ResizeForm.initialFormWidth = 1303;
                formApplication.ResizeForm.setContolDetails(this, controlsDetails);
                formApplication.ResizeForm.setControlResult(this, controlsDetails, controlsResult);
                firstLoad = false;
            }
            ResizeForm.changeControls(this, controlsResult);
        }

      public static  Bitmap bmp;
        DataTable dt;
        private void ReportCharts_Load(object sender, EventArgs e)
        {
            // chart1.Series["Series1"].
            dt = DB.Data(CreateReports.cmd);
            int max = int.MinValue, min = int.MaxValue;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if(max<Convert.ToInt32( dt.Rows[i][1].ToString()))
                   {
                    max = Convert.ToInt32(dt.Rows[i][1].ToString());
                   }
                if (min > Convert.ToInt32(dt.Rows[i][1].ToString()))
                {
                    min = Convert.ToInt32(dt.Rows[i][1].ToString());
                }
            }
            chart1.DataSource = dt;
            chart1.Series["Series1"].XValueMember = dt.Columns[0].ColumnName;
            chart1.Series["Series1"].YValueMembers = dt.Columns[1].ColumnName;
            chart1.Series["Series1"].XValueType = ChartValueType.DateTime;
            chart1.Series["Series1"].YValueType = ChartValueType.Int32;
            chart1.ChartAreas[0].AxisY.Minimum = min;
            chart1.ChartAreas[0].AxisY.Maximum = max+1;
            chart1.ChartAreas[0].AxisX.TitleFont = new Font("Arial", 22, FontStyle.Bold);
            chart1.ChartAreas[0].AxisY.TitleFont = new Font("Arial", 22, FontStyle.Bold);
            chart1.ChartAreas[0].AxisX.Title = CreateReports.columnsNames[0];
            chart1.ChartAreas[0].AxisY.Title = CreateReports.columnsNames[1];
            //chart1.Series["Series1"].Points.AddXY(Convert.ToDateTime("1/6/2022"),10);
            //chart1.Series["Series1"]. Points.AddXY( Convert.ToDateTime("2/6/2022"),20);
            //chart1.Series["Series1"].Points.AddXY( Convert.ToDateTime("3/6/2022"),30);
            //chart1.Series["Series1"].Points.AddXY( Convert.ToDateTime("4/6/2022"),20);
            //chart1.Series["Series1"].Points.AddXY( Convert.ToDateTime("5/6/2022"),50);
            //chart1.Series["Series1"].Points.AddXY(Convert.ToDateTime("6/6/2022"),60);
            //chart1.Series["Series1"].Points.AddXY(Convert.ToDateTime("7/6/2022"),70);
            //lblMainTitle.Text = "إنتاج البيض خلال الفترة ";
            //lblMainTitle.Text += "من 1/9/2022 الى 1/10/2022";

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            //  printPreviewDialog1.ShowDialog();
            Size sz = new Size(chart1.Size.Width +  140, chart1.Size.Height + 200);
            bmp = new Bitmap(sz.Width,sz.Height);
            Graphics g = Graphics.FromImage(bmp);
            Point sourcPoint = PointToScreen(new Point( chart1.Location.X,chart1.Location.Y));
            g.CopyFromScreen(chart1.Location.X, chart1.Location.Y, 0, 0, sz);
            Close();
           // bmp.Save("myPC.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
        }
    }
}
