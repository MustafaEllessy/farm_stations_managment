
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formApplication
{
    public partial class CreateReports : Form
    {
       
        public CreateReports()
        {
            InitializeComponent();
        }

 

        private void pnlEggFarm_Click(object sender, EventArgs e)
        {
            
        }
        SortedDictionary<string, SortedDictionary<string, decimal>> controlsDetails = new SortedDictionary<string, SortedDictionary<string, decimal>>();
        SortedDictionary<string, SortedDictionary<string, decimal>> controlsResult = new SortedDictionary<string, SortedDictionary<string, decimal>>();
        bool formLoaded = false;    
        private void frmFarms_Load(object sender, EventArgs e)
        {
            formLoaded = true;
        }

        private void loadCbx()
        {
            cbxFarmType.SelectedIndex = 0;
            cbxShowType.SelectedIndex = 0;
            cbxShowOn.SelectedIndex = 0;
            cbxReportType.SelectedIndex = 0;

        }

        bool firstLoad = true;
        private void FarmsMenu_Resize(object sender, EventArgs e)
        {
            if (firstLoad)
            {
                formApplication.ResizeForm.initialFormHeight = 757;
                formApplication.ResizeForm.initialFormWidth = 1313;
                formApplication.ResizeForm.setContolDetails(this, controlsDetails);
                formApplication.ResizeForm.setControlResult(this,controlsDetails, controlsResult);
                firstLoad = false;
            }
            ResizeForm.changeControls(this, controlsResult);
        }

        private bool checkConditions()
        {

            if (cbxFarmType.SelectedIndex==-1)
            {
                MessageBox.Show("يجب اختيار نوع المزرعة من القائمة");
                return false;
            }
           else if (cbxShowType.SelectedIndex == -1)
            {
                MessageBox.Show("يجب اختيار نوع العرض من القائمة");
                return false;
            }
            else if (cbxShowOn.SelectedIndex == -1)
            {
                MessageBox.Show("يجب اختيار الحصر من القائمة");
                return false;
            }
            else if (cbxCount.SelectedIndex == -1)
            {
                MessageBox.Show("يجب اختيار نوع العد من القائمة");
                return false;
            }
            else if (clbItems.CheckedIndices.Count ==0)
            {
                MessageBox.Show("يجب أختيار حقل واحد على الأقل");
                return false;
            }
            else if (!checkTime())
            {
                MessageBox.Show("يجب أن يكون تاريخ البدأ قبل تاريخ الإنتهاء");
                return false;
            }
            else if (cbxReportType.SelectedIndex == -1)
            {
                MessageBox.Show("يجب اختيار نوع التقرير من القائمة");
                return false;
            }
            else if (cbxCountPlace.SelectedIndex == -1)
            {
                MessageBox.Show("يجب الاختيار من القائمة للشئ الذى يتم عليه الحصر");
                return false;
            }

            return true;
        }

        private bool checkTime()
        {
            int day1 = dtpStart.Value.Day;
            int day2 = dtpEnd.Value.Day;
            int month1 = dtpStart.Value.Month;
            int month2 = dtpEnd.Value.Month;
            int year1 = dtpStart.Value.Year;
            int year2 = dtpEnd.Value.Year;
            if(year2>year1 || (year2 == year1&& month2 >month1 ) || (year2 == year1 && month2 == month1 &&day2>=day1) )
            {
                return true;
            }
        
            else
            {
                return false;
            }

        }

        private void cbxShowOn_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if farm
         if(cbxShowOn.SelectedIndex==0)
            {
                cbxCountPlace.Items.Clear();
                lblCountPlace.Text = "اسم المزرعة";
                cbxCountPlace.Items.Add("مزرعة " + cbxFarmType.SelectedItem.ToString());
                cbxCountPlace.SelectedIndex = 0;
                cbxCountPlace.Enabled = false;
            }
         //if station
            else if (cbxShowOn.SelectedIndex == 1)
            {
                cbxCountPlace.Enabled = true;
                cbxCountPlace.Items.Clear();
                lblCountPlace.Text = "اسم المحطة";
                if (cbxFarmType.SelectedIndex == 1)
                {
                    cbxCountPlace.Items.Add("محطة 2");
                    cbxCountPlace.SelectedIndex = 0;
                }
                else if (cbxFarmType.SelectedIndex == 0)
                {
                    cbxCountPlace.Items.Add("محطة 3");
                    cbxCountPlace.Items.Add("محطة 5");
                    cbxCountPlace.SelectedIndex = 0;
                }
       
            }
            //if anber
            else if (cbxShowOn.SelectedIndex == 2)
            {
                cbxCountPlace.Enabled = true;
                cbxCountPlace.Items.Clear();
                lblCountPlace.Text = "اسم العنبر";
                cbxCountPlace.Items.Add("عنبر 1أ");
                cbxCountPlace.Items.Add("عنبر 1ب ");
                cbxCountPlace.Items.Add("عنبر 2أ");
                cbxCountPlace.Items.Add("عنبر 2ب");
                cbxCountPlace.Items.Add("عنبر 3أ");
                cbxCountPlace.Items.Add("عنبر 3ب");
                cbxCountPlace.Items.Add("عنبر 4أ");
                cbxCountPlace.Items.Add("عنبر 4ب");
                cbxCountPlace.Items.Add("عنبر 5أ");
                cbxCountPlace.Items.Add("عنبر 5ب");
                cbxCountPlace.Items.Add("عنبر 6أ");
                cbxCountPlace.Items.Add("عنبر 6ب");
                cbxCountPlace.SelectedIndex = 0;

            }
        }

        private void clear()
        {
            cbxCount.Items.Clear();
            clbItems.Items.Clear();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void cbxFarmType_SelectedIndexChanged(object sender, EventArgs e)
        {
             if (cbxFarmType.SelectedIndex == -1)
            {
                return;
            }   clear();
            if (formLoaded&& cbxFarmType.SelectedIndex == 0)
            {
                cbxCount.Items.Add("سلالة");
                cbxCount.Items.Add("عدد");
                clbItems.Items.Add("الإجمالى");
                clbItems.Items.Add("العمر");
                clbItems.Items.Add("الدورة");
                clbItems.Items.Add("العدد");
                clbItems.Items.Add("النافق");
                clbItems.Items.Add("الفراخ المباعة");
                clbItems.Items.Add("الأوزان المباعة");
                clbItems.Items.Add("البيض");        
            }
            else if (cbxFarmType.SelectedIndex == 1)
            {
                cbxCount.Items.Add("عدد");
                clbItems.Items.Add("الإجمالى");
                clbItems.Items.Add("العمر");
                clbItems.Items.Add("الدورة");
                clbItems.Items.Add("العدد");
                clbItems.Items.Add("النافق");
                clbItems.Items.Add("الفراخ المباعة");
                clbItems.Items.Add("الأوزان المباعة");
            }

            clbItems.SetItemChecked(1, true);

            cbxCount.SelectedIndex = 0;
            if(cbxShowOn.SelectedIndex==0)
            {
                changeCountPlace();
            }
            if (cbxShowOn.SelectedIndex == 1)
            {
                changeCountPlace2();
            }
            
        }

        public void changeCountPlace()
        {
            cbxCountPlace.Items.Clear();
            lblCountPlace.Text = "اسم المزرعة";
            cbxCountPlace.Items.Add("مزرعة " + cbxFarmType.SelectedItem.ToString());
            cbxCountPlace.SelectedIndex = 0;
            cbxCountPlace.Enabled = false;
        }
        public void changeCountPlace2()
        {
            cbxCountPlace.Enabled = true;
            cbxCountPlace.Items.Clear();
            lblCountPlace.Text = "اسم المحطة";
            if (cbxFarmType.SelectedIndex == 1)
            {
                cbxCountPlace.Items.Add("محطة 2");
                cbxCountPlace.SelectedIndex = 0;
            }
            else if (cbxFarmType.SelectedIndex == 0)
            {
                cbxCountPlace.Items.Add("محطة 3");
                cbxCountPlace.Items.Add("محطة 5");
                cbxCountPlace.SelectedIndex = 0;
            }
        }
        private void CreateReports_Shown(object sender, EventArgs e)
        {
            loadCbx();
        }

        private void pnlDynamic_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlStatic_Paint(object sender, PaintEventArgs e)
        {

        }
       public static string cmd = "";
        DataTable dtCMD;
       public static List<string> columnsNames;
        int totalPageNO = 0;
        int currPage = 0;
        int rowsCounter = 0;
        bool isCharts = false;
        private void btnMakeReport_Click(object sender, EventArgs e)
        {
            if (checkConditions())
            {

                cmd = makeCMD();

                if (cbxReportType.SelectedIndex == 1 && chartsConditions())
                {
                    isCharts = true;
                     totalPageNO = 1;
                     currPage = 1;
                    ReportCharts rc = new ReportCharts();
                    rc.ShowDialog();
                    if (printDialog1.ShowDialog() == DialogResult.OK)
                        printDocument1.Print();
                  
                }
                else
                {
                    isCharts = false;
                    dtCMD = DB.Data(cmd);
                    if (dtCMD.Rows.Count < 15)
                    {
                        totalPageNO = 1;
                    }
                    else
                    {
                        float remain = dtCMD.Rows.Count - 17;
                        totalPageNO = 1 + Convert.ToInt32(Math.Ceiling(remain / 21));
                    }
                    currPage = 1;
                    rowsCounter = 0;
                    ((Form)printPreviewDialog1).WindowState = FormWindowState.Maximized;
                    printPreviewDialog1.ShowDialog();
                 }
            }
        }

        private bool chartsConditions()
        {
            if (clbItems.CheckedItems.Count > 1) return false;
            for (int i = 0; i < clbItems.CheckedItems.Count; i++)
            {
                string item = clbItems.CheckedItems[i].ToString();
                if (item == "العمر" || item == "الدورة")
                {
                    return false;
                }
            }
            if (cbxShowType.SelectedIndex!=0 || cbxCount.SelectedIndex!=1 ||cbxShowOn.SelectedIndex!=0 )
            {
                return false;
            }
            return true;
        }

        private string makeCMD()
        {
            columnsNames = new List<string>();
            string cmd1 = "select recordDate ";
            columnsNames.Add("التاريخ");
            List<string> fields;
            if (cbxFarmType.SelectedIndex == 0)
                fields = getEggFields();
            else
                fields = getHenFields();
            //مجمل
            if (cbxShowType.SelectedIndex == 0)
            {
                if (cbxFarmType.SelectedIndex == 0)
                {
                     if (cbxShowOn.SelectedIndex == 1)
                    {
                        cmd1 += ",stationName ";
                        columnsNames.Add("المحطة");

                    }
                    else if (cbxShowOn.SelectedIndex == 2)
                    {
                        cmd1 += ",sectionName ";
                        columnsNames.Add("العنبر");
                    }
                    if (cbxCount.SelectedIndex==0)
                    {
                        cmd1 += ",strainName ";
                        columnsNames.Add("السلالة");
                    }
                    for (int i = 0; i < fields.Count; i++)
                    {
                        if (fields[i] == "totalCount")
                        {
                            cmd1 += ", sum(totalCount-(deadCount+soledHenCount)) as theCount";
                            columnsNames.Add("العدد");
                        }
                        else if (fields[i] == "Age")
                        {
                            cmd1 += ", avg(Age) as theAge";
                            columnsNames.Add("العمر");
                        }
                        else if (fields[i] == "total")
                        {
                            cmd1 += ", sum(totalCount) as theTotal";
                            columnsNames.Add("الإجمالى");
                        }
                        else if (fields[i] == "period")
                        {
                            cmd1 += ", '420-560'";
                            columnsNames.Add("الدورة");
                        }
                        else
                        {
                            cmd1 += ", sum(" + fields[i] + ") as the"+fields[i];
                         
                              if (fields[i] == "deadCount")
                            {
                                columnsNames.Add("النافق");

                            }
                            else   if (fields[i] == "soledHenCount")
                            {
                                columnsNames.Add("عدد مباع");

                            }
                            else  if (fields[i] == "soledKiloWeight")
                            {
                                columnsNames.Add("وزن مباع");

                            }
                            else if (fields[i] == "produceEggCount")
                            {
                                columnsNames.Add("البيض");

                            }
                        }
                    }
                    cmd1 += " from eggFarm ";
                }
                else if (cbxFarmType.SelectedIndex == 1)
                {
                    if (cbxShowOn.SelectedIndex == 1)
                    {
                        cmd1 += ",stationName ";
                        columnsNames.Add("المحطة");
                    }
                    else if (cbxShowOn.SelectedIndex == 2)
                    {
                        cmd1 += ",sectionName ";
                        columnsNames.Add("العنبر");
                    }

                    for (int i = 0; i < fields.Count; i++)
                    {
                        if (fields[i] == "totalCount")
                        {
                            cmd1 += ", sum(totalCount-(deadCount+SoledHenCount)) as theCount";
                            columnsNames.Add("العدد");
                        }
                        else if (fields[i] == "age")
                        {
                            cmd1 += ", avg(age) as theage ";
                            columnsNames.Add("العمر");
                        }
                        else if (fields[i] == "total")
                        {
                            cmd1 += ", sum(totalCount) as theTotal";
                            columnsNames.Add("الإجمالى");
                        }
                        else if (fields[i] == "period")
                        {
                            cmd1 += ", '50-95'";
                            columnsNames.Add("الدورة");
                        }
                        else
                        {
                            cmd1 += ", sum(" + fields[i] + ") as the" + fields[i];
                            if (fields[i] == "deadCount")
                            {
                                columnsNames.Add("النافق");

                            }
                            else if (fields[i] == "SoledHenCount")
                            {
                                columnsNames.Add("عدد مباع");

                            }
                            else if (fields[i] == "SoledKiloWeight")
                            {
                                columnsNames.Add("وزن مباع");

                            }
                        }
                    }
                    cmd1 += " from henFarm ";
                }
                cmd1 += "where recordDate >=#" + dtpStart.Value.ToString("yyyy/MM/dd") + "# and recordDate <= #" + dtpEnd.Value.ToString("yyyy/MM/dd") + "# ";
                
                if (cbxShowOn.SelectedIndex == 0)
                {
                    cmd1 += "group by recordDate";
                }
                else if (cbxShowOn.SelectedIndex == 1)
                {
                    cmd1 += "and stationName= '" +cbxCountPlace.SelectedItem.ToString()+"' ";
                    cmd1 += "group by recordDate,stationName";
                }
                else if(cbxShowOn.SelectedIndex == 2)
                {
                    cmd1 += "and sectionName= '" + cbxCountPlace.SelectedItem.ToString()+"' ";
                    cmd1 += "group by recordDate,sectionName";
                }

                 if(cbxFarmType.SelectedIndex == 0 && cbxCount.SelectedIndex==0)
                {
                    cmd1 += ",strainName ";
                }

            }
            else if (cbxShowType.SelectedIndex == 1)
            {
                if (cbxFarmType.SelectedIndex == 0)
                {
                        cmd1 += ",stationName ";
                        cmd1 += ",sectionName ";
                    columnsNames.Add("المحطة");
                    columnsNames.Add("العنبر");
                    if (cbxCount.SelectedIndex == 0)
                    {
                        cmd1 += ",strainName ";
                        columnsNames.Add("السلالة");
                    }
                    for (int i = 0; i < fields.Count; i++)
                    {
                        if (fields[i] == "totalCount")
                        {
                            cmd1 += ", (totalCount-(deadCount+soledHenCount)) as theCount";
                            columnsNames.Add("العدد");
                        }
                        else if (fields[i] == "total")
                        {
                            cmd1 += ", totalCount";
                            columnsNames.Add("الإجمالى");
                        }
                        else if (fields[i] == "period")
                        {
                            cmd1 += ", '420-560'";
                            columnsNames.Add("الدورة");
                        }
                        else
                        { 
                            cmd1 += ", " +fields[i]+" " ;
                            if (fields[i] == "deadCount")
                            {
                                columnsNames.Add("النافق");

                            }
                            else if (fields[i] == "soledHenCount")
                            {
                                columnsNames.Add("عدد مباع");

                            }
                            else if (fields[i] == "Age")
                            {
                                columnsNames.Add("العمر");

                            }
                            else if (fields[i] == "soledKiloWeight")
                            {
                                columnsNames.Add("وزن مباع");

                            }
                            else if (fields[i] == "produceEggCount")
                            {
                                columnsNames.Add("البيض");

                            }
                        }
                    }
                    cmd1 += " from eggFarm ";
                }
                else if (cbxFarmType.SelectedIndex == 1)
                {
                        cmd1 += ",stationName ";
                        cmd1 += ",sectionName ";
                    columnsNames.Add("المحطة");
                    columnsNames.Add("العنبر");
                    for (int i = 0; i < fields.Count; i++)
                    {
                        if (fields[i] == "totalCount")
                        {
                            cmd1 += ", (totalCount-(deadCount+SoledHenCount)) as theCount";
                            columnsNames.Add("العدد");
                        }
                        else if (fields[i] == "total")
                        {
                            cmd1 += ", totalCount";
                            columnsNames.Add("الإجمالى");
                        }
                        else if (fields[i] == "period")
                        {
                            cmd1 += ", '50-95'";
                            columnsNames.Add("الدورة");
                        }
                        else
                        {
                        cmd1 += ", " + fields[i] + " ";
                            if (fields[i] == "deadCount")
                            {
                                columnsNames.Add("النافق");

                            }
                            else if (fields[i] == "SoledHenCount")
                            {
                                columnsNames.Add("عدد مباع");

                            }
                            else if (fields[i] == "age")
                            {
                                columnsNames.Add("العمر");

                            }
                            else if (fields[i] == "SoledKiloWeight")
                            {
                                columnsNames.Add("وزن مباع");

                            }
                        
                        }
                }
                    cmd1 += " from henFarm ";
                }
                cmd1 += "where recordDate >=#" + dtpStart.Value.ToString("yyyy/MM/dd")+ "# and recordDate <= #" + dtpEnd.Value.ToString("yyyy/MM/dd") + "# ";
              
                 if (cbxShowOn.SelectedIndex == 1)
                {
                    cmd1 += "and stationName= '" + cbxCountPlace.SelectedItem.ToString() + "' ";
                }
                else if (cbxShowOn.SelectedIndex == 2)
                {
                    cmd1 += "and sectionName= '" + cbxCountPlace.SelectedItem.ToString() + "' ";
                }
                cmd1 += "order by recordDate,stationName,sectionName ";
                if (cbxFarmType.SelectedIndex == 0 && cbxCount.SelectedIndex == 0)
                {
                    cmd1 += ",strainName ";
                }
                cmd1 += "asc;";
            }

            return cmd1;
        }

        private List<string> getEggFields()
        {
            List<string> eggFields = new List<string>();
            foreach (var item in clbItems.CheckedItems)
            {
                string itemName = item.ToString();
                //byad
                if (cbxFarmType.SelectedIndex == 0)
                {
                    if (itemName == "العدد")
                    {
                        eggFields.Add("totalCount");
                    }
                    else if (itemName == "الإجمالى")
                    {
                        eggFields.Add("total");
                    }
                    else if (itemName == "الدورة")
                    {
                        eggFields.Add("period");
                    }
                    else if (itemName == "العمر")
                    {
                        eggFields.Add("Age");
                    }
                    else if (itemName == "النافق")
                    {
                        eggFields.Add("deadCount");
                    }
                    else if (itemName == "الفراخ المباعة")
                    {
                        eggFields.Add("soledHenCount");

                    }
                    else if (itemName == "الأوزان المباعة")
                    {
                        eggFields.Add("soledKiloWeight");

                    }
                    else if (itemName == "البيض")
                    {
                        eggFields.Add("produceEggCount");
                    }
                }
            

            }
            return eggFields;
        }

        private List<string> getHenFields()
        {
            //tasmeen
            List<string> henFields = new List<string>();
            foreach (var item in clbItems.CheckedItems)
            {
                string itemName = item.ToString();
                if(cbxFarmType.SelectedIndex==1)
                {
                if (itemName == "العدد")
                {
                    henFields.Add("totalCount");
                }
                else if (itemName == "الإجمالى")
                {
                    henFields.Add("total");
                }
                else if (itemName == "الدورة")
                {
                    henFields.Add("period");
                }
                    else if (itemName == "العمر")
                {
                    henFields.Add("age");
                }
                else if (itemName == "النافق")
                {
                    henFields.Add("deadCount");
                }
                else if (itemName == "الفراخ المباعة")
                {
                    henFields.Add("SoledHenCount");
                }
                else if (itemName == "الأوزان المباعة")
                {
                    henFields.Add("SoledKiloWeight");
                }

                }
             }
            return henFields; 
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            if (currPage <= totalPageNO)
            {
                if (currPage == 1)
                {

                    int pageWidth = e.PageBounds.Width;
                    int pageHeight = e.PageBounds.Height;

                    string startDate = dtpStart.Value.ToString("yyyy/MM/dd");
                    string endDate = dtpEnd.Value.ToString("yyyy/MM/dd");

                    string showType = cbxShowType.SelectedItem.ToString();
                    int showON = cbxShowOn.SelectedIndex;
                    string countPlace= cbxCountPlace.SelectedItem.ToString();
                    string countType = cbxCount.SelectedItem.ToString();
                    List<string> fields = new List<string>();
                    for (int i = 0; i < clbItems.CheckedItems.Count; i++)
                    {
                        fields.Add(clbItems.CheckedItems[i].ToString());
                    }

                    string farmType = "مزرعة " + cbxFarmType.SelectedItem.ToString();
                    string reportType = "تقرير " + cbxShowType.SelectedItem.ToString();
                    int leftMargin = 50;
                    int rightMargin = 50;
                    int topMargin = 50;
                    string timeP1 = "الفترة الزمنية";
                    string timeP2 = "من " + startDate;
                    string timeP3 = "الى " + endDate;
                    Image logoImg = formApplication.Properties.Resources.logo1;
                    string udaTitle = "هيئة تنمية الصعيد";
                    string titleP1 = farmType;
                    //if station case

                    Font logoTitleFont = new Font("Arial", 16, FontStyle.Bold);
                    Font mainTitleFont = new Font("Arial", 20, FontStyle.Bold);

                    SizeF t1 = e.Graphics.MeasureString(farmType, mainTitleFont);

                    int titleVerticalSpace = 10;
                    e.Graphics.DrawImage(logoImg, new Point(leftMargin, topMargin));
                    int imgHight = logoImg.Height;
                    int tableTopMargin = imgHight + 5;
                    int tableHeight = pageHeight - tableTopMargin - 30;
                    int tableWidth = pageWidth - (leftMargin * 2);
                    e.Graphics.DrawString(udaTitle, logoTitleFont, Brushes.Black, new Point(leftMargin, imgHight - 25));
                    int t1TopMargin = topMargin + 10;

                    e.Graphics.DrawString(farmType, mainTitleFont, Brushes.Black, new Point(pageWidth / 2 - Convert.ToInt32(t1.Width / 2), t1TopMargin));
                    SizeF t3 = e.Graphics.MeasureString(reportType, mainTitleFont);
                    int t2TopMargin = t1TopMargin + Convert.ToInt32(t3.Height);

                    e.Graphics.DrawString(reportType, mainTitleFont, Brushes.Blue ,new Point(pageWidth / 2 - Convert.ToInt32(t3.Width / 2), t1TopMargin+Convert.ToInt32( t3.Height)+5));

                    if (showON != 0)
                    {
                        string itemName = cbxCountPlace.SelectedItem.ToString();
                        SizeF t2 = e.Graphics.MeasureString(itemName, mainTitleFont);
                        e.Graphics.DrawString(convertToArabicNumbers(itemName), mainTitleFont, Brushes.Red, new Point(pageWidth / 2 - Convert.ToInt32(t2.Width / 2), t2TopMargin+40));
                    }
                    //draw time
                    SizeF timeP1Size = e.Graphics.MeasureString(timeP1, mainTitleFont);
                    SizeF timeP2Size = e.Graphics.MeasureString(timeP2, mainTitleFont);
                    SizeF timeP3Size = e.Graphics.MeasureString(timeP3, mainTitleFont);
                    int timeTopMargin = t1TopMargin + 33;
                    e.Graphics.DrawString(timeP1, mainTitleFont, Brushes.Black, new Point(pageWidth - leftMargin - Convert.ToInt32(timeP1Size.Width), timeTopMargin));

                    e.Graphics.DrawString(convertToArabicNumbers(timeP2), mainTitleFont, Brushes.Black, new Point(pageWidth - leftMargin - Convert.ToInt32(timeP2Size.Width), timeTopMargin + Convert.ToInt32(timeP1Size.Height)));
                    e.Graphics.DrawString(convertToArabicNumbers(timeP3), mainTitleFont, Brushes.Black, new Point(pageWidth - leftMargin - Convert.ToInt32(timeP3Size.Width), timeTopMargin + Convert.ToInt32(timeP1Size.Height) + Convert.ToInt32(timeP2Size.Height)));
                    int tableStartX = leftMargin;
                    int startX = leftMargin;
                    int tableStartY = tableTopMargin;
                    int endX = leftMargin + tableWidth;
                    int columnWidth = tableWidth / columnsNames.Count;
                    int rowHeight = tableHeight / 18;

                    if (!isCharts)
                    {
                        e.Graphics.DrawRectangle(Pens.Black, leftMargin, tableTopMargin, tableWidth, tableHeight);
                
                        for (int i = 0; i < columnsNames.Count - 1; i++)
                    {
                        tableStartX += columnWidth;
                        e.Graphics.DrawLine(Pens.Black, new Point(tableStartX, tableStartY), new Point(tableStartX, tableStartY + tableHeight));
                    }
                    //make rows
                    int rowIndexer = tableTopMargin;
                    for (int i = 0; i < 17; i++)
                    {
                        rowIndexer += rowHeight;
                        e.Graphics.DrawLine(Pens.Black, new Point(startX, rowIndexer), new Point(endX, rowIndexer));
                    }
                    //draw header
                    Font headerTitleFont = new Font("Arial", 18, FontStyle.Bold);
                    int rowWriterX = leftMargin;
                    int rowWriterY = tableTopMargin;
                    SizeF tHeader = e.Graphics.MeasureString("start", headerTitleFont);
                    for (int i = columnsNames.Count - 1; i >= 0; i--)
                    {
                        for (int k = 18; k >= 14; k--)
                        {
                            headerTitleFont = new Font("Arial", k, FontStyle.Bold);
                            tHeader = e.Graphics.MeasureString(columnsNames[i], headerTitleFont);
                            if (tHeader.Width < columnWidth)
                                break;
                        }
                        int wordWidthMid = Convert.ToInt32((tHeader.Width / 2));
                        int wordHeightMid = Convert.ToInt32((tHeader.Height / 2));
                        int xSpace = (columnWidth / 2) - wordWidthMid;
                        int ySpace = (rowHeight / 2) - wordHeightMid;
                        e.Graphics.DrawString(columnsNames[i], headerTitleFont, Brushes.Black, new Point(rowWriterX + xSpace, rowWriterY + ySpace));
                        rowWriterX += columnWidth;
                    }
                 
                        rowWriterX = leftMargin;
                        rowWriterY += rowHeight;
                        for (int k = 0; ((k < 17) && (k < dtCMD.Rows.Count)); k++)
                        {
                            rowWriterX = leftMargin;
                            for (int i = dtCMD.Columns.Count - 1; i >= 0; i--)
                            {
                                //write word
                                string theWord = dtCMD.Rows[k][i].ToString();
                                if (columnsNames[i] == "التاريخ")
                                    theWord = ((DateTime)(dtCMD.Rows[k][i])).ToString("MM/dd");
                                else if (columnsNames[i] == "العمر")
                                {
                                    theWord = Math.Round(Convert.ToDecimal(dtCMD.Rows[k][i].ToString())) + "";
                                }
                                theWord = convertToArabicNumbers(theWord);
                                for (int l = 18; l >= 14; l--)
                                {
                                    headerTitleFont = new Font("Arial", l, FontStyle.Bold);
                                    tHeader = e.Graphics.MeasureString(theWord, headerTitleFont);
                                    if (tHeader.Width < columnWidth)
                                        break;
                                }
                                int wordWidthMid = Convert.ToInt32((tHeader.Width / 2));
                                int wordHeightMid = Convert.ToInt32((tHeader.Height / 2));
                                int xSpace = (columnWidth / 2) - wordWidthMid;
                                int ySpace = (rowHeight / 2) - wordHeightMid;


                                e.Graphics.DrawString(theWord, headerTitleFont, Brushes.Black, new Point(rowWriterX + xSpace, rowWriterY + ySpace));
                                rowWriterX += columnWidth;
                            }
                            rowWriterY += rowHeight;
                        }
                        rowsCounter = 17;
                    }
                   else
                    {
                        Bitmap newBmp = new Bitmap(ReportCharts.bmp, new Size(tableWidth, tableHeight/2));
                        e.Graphics.DrawImage(newBmp, new Point(leftMargin, tableTopMargin+50));
                    }
                }
                else
                {
                    //make rows
                    int tableTopMargin = 30;
                    int leftMargin = 50;
                    int pageWidth = e.PageBounds.Width;
                    int tableStartX = leftMargin;
                    int tableStartY = tableTopMargin;
                    int tableHeight = e.PageBounds.Height - 60;
                    int tableWidth = pageWidth - (leftMargin * 2);
                    int startX = leftMargin;
                    int endX = leftMargin + tableWidth;
                    int columnWidth = tableWidth / columnsNames.Count;
                    int rowHeight = tableHeight / 22;

                    int rowIndexer = tableTopMargin;
                    e.Graphics.DrawRectangle(Pens.Black, leftMargin, tableTopMargin, tableWidth, tableHeight);
                    for (int i = 0; i < columnsNames.Count - 1; i++)
                    {
                        tableStartX += columnWidth;
                        e.Graphics.DrawLine(Pens.Black, new Point(tableStartX, tableStartY), new Point(tableStartX, tableStartY + tableHeight));
                    }
                    for (int i = 0; i < 21; i++)
                    {
                        rowIndexer += rowHeight;
                        e.Graphics.DrawLine(Pens.Black, new Point(startX, rowIndexer), new Point(endX, rowIndexer));
                    }
                    //draw header
                    Font headerTitleFont = new Font("Arial", 18, FontStyle.Bold);
                    int rowWriterX = leftMargin;
                    int rowWriterY = tableTopMargin;
                    SizeF tHeader = e.Graphics.MeasureString("start", headerTitleFont);
                    for (int i = columnsNames.Count - 1; i >= 0; i--)
                    {
                        for (int k = 18; k >= 14; k--)
                        {
                            headerTitleFont = new Font("Arial", k, FontStyle.Bold);
                            tHeader = e.Graphics.MeasureString(columnsNames[i], headerTitleFont);
                            if (tHeader.Width < columnWidth)
                                break;
                        }
                        int wordWidthMid = Convert.ToInt32((tHeader.Width / 2));
                        int wordHeightMid = Convert.ToInt32((tHeader.Height / 2));
                        int xSpace = (columnWidth / 2) - wordWidthMid;
                        int ySpace = (rowHeight / 2) - wordHeightMid;
                        e.Graphics.DrawString(columnsNames[i], headerTitleFont, Brushes.Black, new Point(rowWriterX + xSpace, rowWriterY + ySpace));
                        rowWriterX += columnWidth;
                    }
                    rowWriterX = leftMargin;
                    rowWriterY += rowHeight;
                    for (int k = rowsCounter; ((k < (rowsCounter+21)) && (k < dtCMD.Rows.Count)); k++)
                    {
                        rowWriterX = leftMargin;
                        for (int i = dtCMD.Columns.Count - 1; i >= 0; i--)
                        {
                            //write word
                            string theWord = dtCMD.Rows[k][i].ToString();
                            if (columnsNames[i] == "التاريخ")
                                theWord = ((DateTime)(dtCMD.Rows[k][i])).ToString("MM/dd");
                            else if (columnsNames[i] == "العمر")
                            {
                                theWord = Math.Round(Convert.ToDecimal(dtCMD.Rows[k][i].ToString())) + "";
                            }
                            theWord = convertToArabicNumbers(theWord);
                            for (int l = 18; l >= 14; l--)
                            {
                                headerTitleFont = new Font("Arial", l, FontStyle.Bold);
                                tHeader = e.Graphics.MeasureString(theWord, headerTitleFont);
                                if (tHeader.Width < columnWidth)
                                    break;
                            }
                            int wordWidthMid = Convert.ToInt32((tHeader.Width / 2));
                            int wordHeightMid = Convert.ToInt32((tHeader.Height / 2));
                            int xSpace = (columnWidth / 2) - wordWidthMid;
                            int ySpace = (rowHeight / 2) - wordHeightMid;


                            e.Graphics.DrawString(theWord, headerTitleFont, Brushes.Black, new Point(rowWriterX + xSpace, rowWriterY + ySpace));
                            rowWriterX += columnWidth;
                        }
                        rowWriterY += rowHeight;
                    }
                    rowsCounter += 21;
                }
                currPage++;
                if (currPage <= totalPageNO) 
                e.HasMorePages = true;
            }
            else
            {
                e.HasMorePages = false;
            }
        }
        public string convertToArabicNumbers(string str)
        {
            string strNew = "";
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == '1')
                {
                    strNew += "١";
                }
                else if(str[i] == '2')
                {
                    strNew += "٢";
                }
                else if (str[i] == '3')
                {
                    strNew += "٣";
                }
                else if (str[i] == '4')
                {
                    strNew += "٤";
                }
                else if (str[i] == '5')
                {
                    strNew += "٥";
                }
                else if (str[i] == '6')
                {
                    strNew += "٦";
                }
                else if (str[i] == '7')
                {
                    strNew += "٧";
                }
                else if (str[i] == '8')
                {
                    strNew += "٨";
                }
                else if (str[i] == '9')
                {
                    strNew += "٩";
                }
                else if (str[i] == '0')
                {
                    strNew += "٠";
                }
                else
                {
                    strNew += str[i];
                }
             
            }
            return strNew;
        }
        private void cbxCountPlace_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnPrintReport_Click(object sender, EventArgs e)
        {
            if (checkConditions())
            {
                cmd = makeCMD();
                dtCMD = DB.Data(cmd);
                if (dtCMD.Rows.Count < 15)
                {
                    totalPageNO = 1;
                }
                else
                {
                    float remain = dtCMD.Rows.Count - 17;
                    totalPageNO = 1 + Convert.ToInt32(Math.Ceiling(remain / 21));
                }
                currPage = 1;
                rowsCounter = 0;
                if(printDialog1.ShowDialog()==DialogResult.OK)
                printDocument1.Print();
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
