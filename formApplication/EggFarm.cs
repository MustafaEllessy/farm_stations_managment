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
    public partial class EggFarm : Form
    {
        public EggFarm()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
           if(!char.IsDigit(e.KeyChar)&&!char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void pnl1_Paint(object sender, PaintEventArgs e)
        {

        }

      
        
        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }
        /*
        private void btnRecord_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (var ctr in pnl1.Controls)
                {
                    if (ctr.GetType() == typeof(TextBox))
                    {
                        if (((TextBox)ctr).Text == "")
                        {
                            MessageBox.Show("يجب ملأ بيانات كل الفئات العمرية");
                            return;
                        }
                    }
                }
                foreach (var ctr in pnl2.Controls)
                {
                    if (ctr.GetType() == typeof(TextBox))
                    {
                        if (((TextBox)ctr).Text == "")
                        {
                            MessageBox.Show("يجب ملأ بيانات كل الفئات العمرية");
                            return;
                        }

                    }
                }
       

                //check complete
                // insert on db
                //اول فئة 
                DB.insertToDB("eggFarm", new string[] { "recordDate", "ageGroup", "livingCount", "deadCount", "produceEggCount", "produceSoledHenCount" },
                new object[] { dtRecord.Value.ToString("yyyy/MM/dd"), rdoAgeGroup1.Text, Convert.ToInt32(pnl1.Controls["txtLivingCount1"].Text), Convert.ToInt32(pnl1.Controls["txtDeadCount1"].Text), Convert.ToInt32(pnl1.Controls["txtEggsCount1"].Text), Convert.ToInt32(pnl1.Controls["txtSoledHensCount1"].Text) });
                //ثانى فئة 
                DB.insertToDB("eggFarm", new string[] { "recordDate", "ageGroup", "livingCount", "deadCount", "produceEggCount", "produceSoledHenCount" },
                new object[] { dtRecord.Value.ToString("yyyy/MM/dd"), rdoAgeGroup2.Text, Convert.ToInt32(pnl2.Controls["txtLivingCount2"].Text), Convert.ToInt32(pnl2.Controls["txtDeadCount2"].Text), Convert.ToInt32(pnl2.Controls["txtEggsCount2"].Text), Convert.ToInt32(pnl2.Controls["txtSoledHensCount2"].Text) });
                 MessageBox.Show("تم الحفظ");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("لم يتم الحفظ");
                MessageBox.Show(ex.Message);
            }
            }
        */
        SortedDictionary<string, SortedDictionary<string, SortedDictionary<string, SortedDictionary<int, int>>>> station = new SortedDictionary<string, SortedDictionary<string, SortedDictionary<string, SortedDictionary<int, int>>>>();
        SortedDictionary<string, SortedDictionary<string, decimal>> controlsDetails = new SortedDictionary<string, SortedDictionary<string, decimal>>();
        SortedDictionary<string, SortedDictionary<string, decimal>> controlsResult = new SortedDictionary<string, SortedDictionary<string, decimal>>();
        decimal initialFormWidth = 0;
        decimal initialFormHeight = 0;
        public void mesure(Form frm)
        {

        }
        private void frmEggFarm_Load(object sender, EventArgs e)
        {
            btnStation3.PerformClick();
            initiateDictionary();
            disableAllTexts();
        }
        private void setControlResult()
        {
            foreach (var item in controlsDetails)
            {
                SortedDictionary<string, decimal> values = new SortedDictionary<string, decimal>();
                foreach (var item2 in item.Value)
                {
                    if (item2.Key == "width")
                    {
                        decimal widthPercentage = item2.Value / initialFormWidth;
                        values.Add(item2.Key, widthPercentage);
                    }
                    else if (item2.Key == "height")
                    {
                        decimal heightPercentage = item2.Value / initialFormHeight;
                        values.Add(item2.Key, heightPercentage);
                    }
                    else if (item2.Key == "x")
                    {
                        decimal xPercentage = item2.Value / initialFormWidth;
                        values.Add(item2.Key, xPercentage);
                    }
                    else if (item2.Key == "y")
                    {
                        decimal yPercentage = item2.Value / initialFormHeight;
                        values.Add(item2.Key, yPercentage);
                    }
                }
                string controlName = item.Key;

                controlsResult.Add(controlName, values);
            }
        }

        private void setContolDetails(Control control)
        {
            if (!control.HasChildren)
            {
                return;
            }
            foreach (Control c in control.Controls)
            {
                SortedDictionary<string, decimal> item = new SortedDictionary<string, decimal>();
                item.Add("width", c.Width);
                item.Add("height", c.Height);
                item.Add("x", c.Location.X);
                item.Add("y", c.Location.Y);
                controlsDetails.Add(c.Name, item);
            }
        }
        public void autoResizing()
        {
         //   panel1.Width=
        }
        private void disableAllTexts()
        {
            for (int i = 0; i < 12; i++)
            {
                for (int j = 0; j < tcByad3.TabPages[i].Controls.Count; j++)
                {
                    if(tcByad3.TabPages[i].Controls[j].GetType()==typeof(TextBox))
                    {
                        ((TextBox)tcByad3.TabPages[i].Controls[j]).Enabled = false;
                    }
                } 
            }

            for (int i = 0; i < 12; i++)
            {
                for (int j = 0; j < tcByad5.TabPages[i].Controls.Count; j++)
                {
                    if (tcByad5.TabPages[i].Controls[j].GetType() == typeof(TextBox))
                    {
                        ((TextBox)tcByad5.TabPages[i].Controls[j]).Enabled = false;
                    }
                }
            }
        }

        private void initiateDictionary()
        {
            SortedDictionary<string, SortedDictionary<string, SortedDictionary<int, int>>> anber = new SortedDictionary<string, SortedDictionary<string, SortedDictionary<int, int>>>();
            anber.Add("عنبر 1أ", new SortedDictionary<string, SortedDictionary<int, int>>());
            anber.Add("عنبر 1ب", new SortedDictionary<string, SortedDictionary<int, int>>());
            anber.Add("عنبر 2أ", new SortedDictionary<string, SortedDictionary<int, int>>());
            anber.Add("عنبر 2ب", new SortedDictionary<string, SortedDictionary<int, int>>());
            anber.Add("عنبر 3أ", new SortedDictionary<string, SortedDictionary<int, int>>());
            anber.Add("عنبر 3ب", new SortedDictionary<string, SortedDictionary<int, int>>());
            anber.Add("عنبر 4أ", new SortedDictionary<string, SortedDictionary<int, int>>());
            anber.Add("عنبر 4ب", new SortedDictionary<string, SortedDictionary<int, int>>());
            anber.Add("عنبر 5أ", new SortedDictionary<string, SortedDictionary<int, int>>());
            anber.Add("عنبر 5ب", new SortedDictionary<string, SortedDictionary<int, int>>());
            anber.Add("عنبر 6أ", new SortedDictionary<string, SortedDictionary<int, int>>());
            anber.Add("عنبر 6ب", new SortedDictionary<string, SortedDictionary<int, int>>());
            SortedDictionary<string, SortedDictionary<string, SortedDictionary<int, int>>> anber3 = new SortedDictionary<string, SortedDictionary<string, SortedDictionary<int, int>>>();
            anber3.Add("عنبر 1أ", new SortedDictionary<string, SortedDictionary<int, int>>());
            anber3.Add("عنبر 1ب", new SortedDictionary<string, SortedDictionary<int, int>>());
            anber3.Add("عنبر 2أ", new SortedDictionary<string, SortedDictionary<int, int>>());
            anber3.Add("عنبر 2ب", new SortedDictionary<string, SortedDictionary<int, int>>());
            anber3.Add("عنبر 3أ", new SortedDictionary<string, SortedDictionary<int, int>>());
            anber3.Add("عنبر 3ب", new SortedDictionary<string, SortedDictionary<int, int>>());
            anber3.Add("عنبر 4أ", new SortedDictionary<string, SortedDictionary<int, int>>());
            anber3.Add("عنبر 4ب", new SortedDictionary<string, SortedDictionary<int, int>>());
            anber3.Add("عنبر 5أ", new SortedDictionary<string, SortedDictionary<int, int>>());
            anber3.Add("عنبر 5ب", new SortedDictionary<string, SortedDictionary<int, int>>());
            anber3.Add("عنبر 6أ", new SortedDictionary<string, SortedDictionary<int, int>>());
            anber3.Add("عنبر 6ب", new SortedDictionary<string, SortedDictionary<int, int>>());

            station.Add("محطة 3", anber);
            station.Add("محطة 5", anber3);
        }
        public int getStationNo(string station)
        {
            if(station== "محطة 3")
            {
                return 3;
            }
       else if (station == "محطة 5")
            {
                return 5;
            }
            return -1;

        }
        public int getSectionNo(string anberName)
        {
            if (anberName == "عنبر 1أ")
            {
                return 1;
            }
            else if (anberName == "عنبر 1ب")
            {
                return 2;
            }
            else if (anberName == "عنبر 2أ")
            {
                return 3;
            }
            else if (anberName == "عنبر 2ب")
            {
                return 4;
            }
            else if (anberName == "عنبر 3أ")
            {
                return 5;
            }
            else if (anberName == "عنبر 3ب")
            {
                return 6;
            }
            else if (anberName == "عنبر 4أ")
            {
                return 7;
            }
            else if (anberName == "عنبر 4ب")
            {
                return 8;
            }
            else if (anberName == "عنبر 5أ")
            {
                return 9;
            }
            else if (anberName == "عنبر 5ب")
            {
                return 10;
            }
            else if (anberName == "عنبر 6أ")
            {
                return 11;
            }
            else if (anberName == "عنبر 6ب")
            {
                return 12;
            }
            return -1;
        }
        private void strains_click(object sender, EventArgs e)
        {        
            
            string stationName = getStation();
            TabPage tabPG = ((TabPage)(((Panel)((Button)(sender)).Parent).Parent));
            string anberName = tabPG.Text;
            string strainName = ((Button)(sender)).Text;
            if (((Button)(sender)).BackColor == Color.White)
            {
                thereIsAnyRedButtons((Button)sender,tabPG);

                ((Button)(sender)).BackColor = Color.Red;
                ((Button)(sender)).ForeColor = Color.White;
                int idx = getRow(stationName, anberName, strainName);
                if(idx!=-1)
                {
                 int secNO = getSectionNo(anberName);
                 int StatNO = getStationNo(stationName);
                 string countTextName = "txt" + secNO + "Count"+StatNO;
                 string ageTextName = "txt" + secNO + "Age"+ StatNO;
                    tabPG.Controls[ageTextName].Text = dtFillData.Rows[idx][3].ToString();
                    ((TextBox)tabPG.Controls[ageTextName]).ReadOnly = true;
                    tabPG.Controls[countTextName].Text = dtFillData.Rows[idx][4].ToString();
                    ((TextBox)tabPG.Controls[countTextName]).ReadOnly = true;
                }
                return;
            }
            SortedDictionary<int,int> strainData = new SortedDictionary<int, int>();
            if (((Button)(sender)).BackColor == Color.Blue)
            {
            /*    string count = station[stationName][anberName][strainName][] + "";
                string dead = station[stationName][anberName][strainName][1] + "";
                string egg = station[stationName][anberName][strainName][2] + "";
                string soledHens = station[stationName][anberName][strainName][3] + "";
                string soledWegiht = station[stationName][anberName][strainName][4] + "";*/
                for (int i = 0; i < tabPG.Controls.Count; i++)
                {
                    if (tabPG.Controls[i].GetType() == typeof(TextBox)  )
                    {
                        TextBox txt = (TextBox)tabPG.Controls[i];
                        txt.Text = station[stationName][anberName][strainName][Convert.ToInt32( txt.Tag)] + "";
                    }
                }
            

                ((Button)(sender)).BackColor = Color.Green;
                ((Button)(sender)).Text = strainName;
                editMode(((Button)(sender)));
                return;
            }
            List<int> txtIndx = new List<int>();
            for (int i = 0; i < tabPG.Controls.Count; i++)
            {
                if (tabPG.Controls[i].GetType() == typeof(TextBox))
                {
                    TextBox txt = (TextBox)tabPG.Controls[i];
                    if(txt.Text=="")
                    {
                        MessageBox.Show("يجب ملأ كل الخانات الفارغة");
                        return;
                    }
                    strainData.Add(Convert.ToInt32(txt.Tag), Convert.ToInt32(txt.Text));
                    txtIndx.Add(i);
                }
            }
            if (station[stationName][anberName].ContainsKey(strainName))
            {
                station[stationName][anberName].Remove(strainName);
            }
            station[stationName][anberName].Add(strainName, strainData);    
            //clear
            foreach (var indx in txtIndx)
            {
                TextBox txt = (TextBox)tabPG.Controls[indx];
                txt.Text = "";
            }
            ((TextBox)tabPG.Controls[txtIndx[0]]).Select();
            if(((Button)sender).BackColor==Color.Green)
            {
                MessageBox.Show("تم التعديل");
            }
            else
            MessageBox.Show("تم التسجيل");
            ((Button)(sender)).BackColor = Color.Blue;
            ((Button)(sender)).ForeColor = Color.White;
            activeMode(((Button)(sender)));
        }

        private void thereIsAnyRedButtons(Button btn,TabPage tabPG)
        {
            Panel p = (Panel)btn.Parent;
            for (int i = 0; i < p.Controls.Count; i++)
            {
                if (p.Controls[i].GetType() == typeof(Button) )
                {
                    Button btnLoop = (Button)p.Controls[i];
                    if(btnLoop.BackColor==Color.Red)
                    {
                        btnLoop.BackColor = Color.White;
                        btnLoop.ForeColor = Color.Black;
                    }
                }
            }
            for (int i = 0; i < tabPG.Controls.Count; i++)
            {
                if (tabPG.Controls[i].GetType() == typeof(TextBox))
                {
                   ((TextBox)tabPG.Controls[i]).Text="";
                    ((TextBox)tabPG.Controls[i]).ReadOnly = false;
                }
            }

       }

        private int getRow(string station,string section,string strain)
        {
            for (int i = 0; i < dtFillData.Rows.Count; i++)
            {
                string sourceStation = dtFillData.Rows[i][0].ToString();
                string sourceSection = dtFillData.Rows[i][1].ToString();
                string sourceStrain = dtFillData.Rows[i][2].ToString();
                if(station==sourceStation && section == sourceSection && strain == sourceStrain )
                {
                    return i;
                }
            }
            return -1;
        }

        private void activeMode(Button btn)
        {
            Panel p = (Panel)btn.Parent;
            for (int i = 0; i < p.Controls.Count; i++)
            {
                if (p.Controls[i].GetType() == typeof(Button))
                {
                    Button btnLoop = (Button)p.Controls[i];
                    btnLoop.Enabled = true;
                }
            }
        }

        private void editMode(Button btn)
        {
            Panel p = (Panel)btn.Parent;
            for (int i = 0; i < p.Controls.Count; i++)
            {
                if (p.Controls[i].GetType() == typeof(Button))
                {
                  Button  btnLoop = (Button)p.Controls[i];
                    if (btnLoop.Text == btn.Text) continue;
                    btnLoop.Enabled = false;
                }
            }
        }

        private string getStation()
        {
            if(btnStation3.BackColor==Color.Blue)
            {
                return "محطة 3";
            }
        
          else  
            {
                return "محطة 5";
            }
        }

        private void btnUse_Click(object sender, EventArgs e)
        {
            Button useBtn = (Button)sender;
            Panel strainsPnl = ((Panel)(useBtn.Parent));
            CheckedListBox strainsClb = (strainsPnl.Controls[0]).GetType() == typeof(CheckedListBox) ? (CheckedListBox)(strainsPnl.Controls[0]) : (CheckedListBox)(strainsPnl.Controls[1]);
            TabPage usedTab = ((TabPage)(((Panel)(useBtn.Parent)).Parent));
  
            Panel usedStrainsPnl =new Panel();
            for (int i = 0; i < usedTab.Controls.Count; i++)
            {
                if(usedTab.Controls[i].GetType()==typeof(Panel))
                {
                    if(usedTab.Controls[i].Width>700)
                    {
                        usedStrainsPnl = ((Panel)usedTab.Controls[i]);
                        break;
                    }
                }
            }


            int x =11;
          
            int listCount = strainsClb.CheckedItems.Count;
            if(listCount==0)
            {
                MessageBox.Show("على الأقل توجد سلالة واحدة");
                return;
            }
            for (int i = 0; i < listCount; i++)
            {
                string strainName = strainsClb.CheckedItems[i].ToString();
                Button btn = new Button();
                btn.Name = "btn" +( i + 1);
                btn.Text = strainName;
                btn.Height = 121;
                btn.Width = (pnl1UsedStrains3.Width / listCount) - 20;
                btn.Font = new Font("Times New Roman", 22, FontStyle.Bold);
                btn.Location = new Point(x, 0);
                btn.Click += strains_click;
                x += btn.Width + 1;
                btn.BackColor = Color.White;
                btn.ForeColor = Color.Black;
                usedStrainsPnl.Controls.Add(btn);
            }
            activateTextBoxesInTab(usedTab);
            strainsPnl.Enabled = false;
        }

        private void activateTextBoxesInTab(TabPage tab)
        {
            for (int i = 0; i < tab.Controls.Count; i++)
            {
                if (tab.Controls[i].GetType() == typeof(TextBox)) ((TextBox)tab.Controls[i]).Enabled = true;
            }
        }

        private void tabPage18_Click(object sender, EventArgs e)
        {

        }

        private void btnStation3_Click(object sender, EventArgs e)
        {
            pnlByad3.Visible = true;
            pnlByad5.Visible = false;
            btnStation3.BackColor = Color.Blue;
            btnStation3.ForeColor = Color.White;
            btnStation5.BackColor = Color.White;
            btnStation5.ForeColor = Color.Black;
        }

    
        private void btnStation5_Click(object sender, EventArgs e)
        {
            pnlByad3.Visible = false;
            pnlByad5.Visible = true;
            btnStation5.BackColor = Color.Blue;
            btnStation5.ForeColor = Color.White;
            btnStation3.BackColor = Color.White;
            btnStation3.ForeColor = Color.Black;
        }

        private void tabPage25_Click(object sender, EventArgs e)
        {

        }
        private void txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        public bool checkRecorded(string stationName)
        {
            DataTable rslt = DB.Data("select * from eggFarm where recordDate=#" + dtpRecord.Value.ToString("yyyy/MM/dd") + "#" + " and stationName='" + stationName + "'");
            if (rslt.Rows.Count != 0) return true;
            return false;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            bool station3 = false;
            if (btnStation3.BackColor == Color.Blue)
            {
                station3 = true;
            }
            else
                station3 = false;
            bool recorded = false;

            if (station3)
            {
                recorded = checkRecorded("محطة 3");
            }
            else
            {
                recorded = checkRecorded("محطة 5");
            }
            if (recorded)
            {
                MessageBox.Show("تم التسجيل لهذا اليوم مسبقاً");
                return;
            }
            bool ok = checkTime();
            if (!ok)
            {
                MessageBox.Show("يجب تسجيل بيانات اليوم الحالى فقط");
                return;
            }

            bool checkResult = false;

            if (station3)
            {
                checkResult = checkStrainButtons3();
            }
            else
            {
                checkResult = checkStrainButtons5();
            }
            if (!checkResult) return;

            foreach (var item in station)
            {
                string stationName = item.Key;
                if ((station3 && stationName == "محطة 5") || (!station3 && stationName == "محطة 3"))
                {
                    continue;
                }

                SortedDictionary<string, SortedDictionary<string, SortedDictionary<int, int>>> anber = item.Value;
                foreach (var item2 in anber)
                {
                    string sectionName = item2.Key;
                    SortedDictionary<string, SortedDictionary<int, int>> strain = item2.Value;

                    foreach (var item3 in strain)
                    {
                        string strainName = item3.Key;
                        SortedDictionary<int, int> values = item3.Value;
                        List<int> sortedValues = new List<int>();
                        foreach (var item4 in values)
                        {
                            sortedValues.Add(item4.Value);
                        }
                        DB.insertToDB("eggFarm", new string[] { "recordDate", "stationName", "sectionName", "strainName", "Age", "totalCount", "deadCount", "produceEggCount", "soledHenCount", "soledKiloWeight" },
                      new object[] { dtpRecord.Value.ToString("dd/MM/yyyy"), stationName, sectionName, strainName, sortedValues[0], sortedValues[1], sortedValues[2], sortedValues[3], sortedValues[4], sortedValues[5] });
                    }
                }
            }
            MessageBox.Show("تم الحفظ بنجاح");
        }

        private bool checkStrainButtons3()
        {
            bool pnlExist = false;
            for (int i = 0; i < 12; i++)
            {
                pnlExist = false;
                for (int j = 0; j < tcByad3.TabPages[i].Controls.Count; j++)
                {
                    if (tcByad3.TabPages[i].Controls[j].GetType() == typeof(Panel))
                    {
                        Panel pnl3 = ((Panel)tcByad3.TabPages[i].Controls[j]);
                        if (pnl3.Width > 700)
                        {
                            if (pnl3.Controls.Count > 0)
                                pnlExist = true;
                            for (int k = 0; k < pnl3.Controls.Count; k++)
                            {
                                if (((Button)pnl3.Controls[k]).BackColor != Color.Blue)
                                {
                                    MessageBox.Show("املأ بيانات جميع السلالات اولاً");
                                    return false;
                                }
                            }
                        }
                    }
                }
                if (!pnlExist)
                {
                    MessageBox.Show("املأ بيانات جميع السلالات اولاً");
                    return false;
                }

            }



            return true;
        }

        private bool checkStrainButtons5()
        {
            bool pnlExist = false;


            for (int i = 0; i < 12; i++)
            {
                pnlExist = false;
                for (int j = 0; j < tcByad5.TabPages[i].Controls.Count; j++)
                {
                    if (tcByad5.TabPages[i].Controls[j].GetType() == typeof(Panel))
                    {
                        Panel pnl5 = ((Panel)tcByad5.TabPages[i].Controls[j]);
                        if (pnl5.Width > 700)
                        {
                            if (pnl5.Controls.Count > 0)
                                pnlExist = true;
                            for (int k = 0; k < pnl5.Controls.Count; k++)
                            {
                                if (((Button)pnl5.Controls[k]).BackColor != Color.Blue)
                                {
                                    MessageBox.Show("املأ بيانات جميع السلالات اولاً");
                                    return false;
                                }
                            }
                        }
                    }
                }
                if (!pnlExist)
                {
                    MessageBox.Show("املأ بيانات جميع السلالات اولاً");
                    return false;
                }
            }
            return true;
        }
        private void button36_Click_1(object sender, EventArgs e)
        {
            for (int i = 0; i < 12; i++)
            {
                for (int j = 0; j < tcByad3.TabPages[i].Controls.Count; j++)
                {
                    if (tcByad3.TabPages[i].Controls[j].GetType() == typeof(TextBox))
                    {
                        ((TextBox)tcByad3.TabPages[i].Controls[j]).Text = 0 + "";
                    }
                    if (tcByad3.TabPages[i].Controls[j].GetType() == typeof(Panel))
                    {
                       if (((Panel)tcByad3.TabPages[i].Controls[j]).Width<800)
                        {
                            for (int k = 0; k < ((Panel)tcByad3.TabPages[i].Controls[j]).Controls.Count; k++)
                            {
                                if((((Panel)tcByad3.TabPages[i].Controls[j]).Controls[k]).GetType()==typeof(Button))
                                {
                                    if(k==0)
                                    {
                                        ((CheckedListBox)(((Panel)tcByad3.TabPages[i].Controls[j]).Controls[1])).SetItemChecked(0, true);
                                    }
                                    else
                                    {
                                        ((CheckedListBox)(((Panel)tcByad3.TabPages[i].Controls[j]).Controls[0])).SetItemChecked(0, true);
                                    }
                                    ((Button)((Panel)tcByad3.TabPages[i].Controls[j]).Controls[k]).PerformClick();

                                }
                            }
                        }
                       else if(((Panel)tcByad3.TabPages[i].Controls[j]).Name.Contains("UsedStrains") )
                        {
                            if (((Panel)tcByad3.TabPages[i].Controls[j]).Controls.Count == 0) continue;
                            ((Button)((Panel)tcByad3.TabPages[i].Controls[j]).Controls[0]).BackColor=Color.Blue;
                            ((Button)((Panel)tcByad3.TabPages[i].Controls[j]).Controls[0]).ForeColor = Color.White;
                        }
                    }

                }
            }

            for (int i = 0; i < 12; i++)
            {
                for (int j = 0; j < tcByad5.TabPages[i].Controls.Count; j++)
                {
                    if (tcByad5.TabPages[i].Controls[j].GetType() == typeof(TextBox))
                    {
                        ((TextBox)tcByad5.TabPages[i].Controls[j]).Text = 0 + "";
                    }
                    if (tcByad5.TabPages[i].Controls[j].GetType() == typeof(Panel))
                    {
                        if (((Panel)tcByad5.TabPages[i].Controls[j]).Width < 800)
                        {
                            for (int k = 0; k < ((Panel)tcByad5.TabPages[i].Controls[j]).Controls.Count; k++)
                            {
                                if ((((Panel)tcByad5.TabPages[i].Controls[j]).Controls[k]).GetType() == typeof(Button))
                                {
                                    if (k == 0)
                                    {
                                        ((CheckedListBox)(((Panel)tcByad5.TabPages[i].Controls[j]).Controls[1])).SetItemChecked(0, true);
                                    }
                                    else
                                    {
                                        ((CheckedListBox)(((Panel)tcByad5.TabPages[i].Controls[j]).Controls[0])).SetItemChecked(0, true);
                                    }
                                    ((Button)((Panel)tcByad5.TabPages[i].Controls[j]).Controls[k]).PerformClick();

                                }
                            }
                        }
                        else if (((Panel)tcByad5.TabPages[i].Controls[j]).Name.Contains("UsedStrains"))
                        {
                            if (((Panel)tcByad5.TabPages[i].Controls[j]).Controls.Count == 0) continue;
                            ((Button)((Panel)tcByad5.TabPages[i].Controls[j]).Controls[0]).BackColor = Color.Blue;
                            ((Button)((Panel)tcByad5.TabPages[i].Controls[j]).Controls[0]).ForeColor = Color.White;
                        }
                    }
                }
            }
        }

        private void button37_Click(object sender, EventArgs e)
        {
         
        }
        private void changeControls()
        {
            foreach (var item in controlsResult)
            {
                Control c = this.Controls.Find(item.Key, true).FirstOrDefault();
                List<int> targetValues = new List<int>();
                int newWidth = 0, newHeight = 0, newX = 0, newY = 0;
                foreach (var item2 in item.Value)
                {
                    if (item2.Key == "width")
                    {
                        newWidth = Convert.ToInt32(item2.Value * Width);
                    }
                    else if (item2.Key == "height")
                    {
                        newHeight = Convert.ToInt32(item2.Value * Height);
                    }
                    else if (item2.Key == "x")
                    {
                        newX = Convert.ToInt32(item2.Value * Width);
                    }
                    else if (item2.Key == "y")
                    {
                        newY = Convert.ToInt32(item2.Value * Height);

                    }

                }
                c.Width = newWidth;
                c.Height = newHeight;
                c.Location = new Point(newX, newY);
            }
        }
        bool firstLoad = true;
        private void EggFarm_Resize(object sender, EventArgs e)
        {
            if (firstLoad)
            {
                formApplication.ResizeForm.initialFormHeight = 757;
                formApplication.ResizeForm.initialFormWidth = 1303;
                formApplication.ResizeForm.setContolDetails(this, controlsDetails);
                formApplication.ResizeForm.setControlResult(this,controlsDetails, controlsResult);
                firstLoad = false;
            }
            ResizeForm.changeControls(this,controlsResult);
        }

        private void tabPage13_Click(object sender, EventArgs e)
        {

        }

        private void txt9Count5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label165_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txt4Count3_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage22_Click(object sender, EventArgs e)
        {

        }

        private void txt1Count3_TextChanged(object sender, EventArgs e)
        {

        }
        DataTable dtFillData;
        private void EggFarm_Shown(object sender, EventArgs e)
        {
            dtFillData = DB.Data("select * from EggFarmAutofillData");
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }
        public List<string> getStrainNames(string anberNO,string stationNO,TabPage tp)
        {
            string pnlName = "pnl" + anberNO + "UsedStrains" + stationNO;
            List<string> strainNames = new List<string>();
            Panel pnl = (Panel)tp.Controls[pnlName];
            for (int i = 0; i < pnl.Controls.Count; i++)
            {
                Button btn =(Button) pnl.Controls[i];
                strainNames.Add(btn.Text);
            }
            return strainNames;
            
        }
        private void btnReturn_Click(object sender, EventArgs e)
        {
            
            TabPage tp = (TabPage)((Button)sender).Parent;
            string sectionNO = getSectionNo(tp.Text)+"";
            string stationNO = getStationNo(getStation()) +"";
            List<string> strainNames = getStrainNames(sectionNO, stationNO, tp);
            deleteStrainsFromDic(strainNames, getStation(), tp.Text);
            //delete stainBtns
            string strainsPnlName = "pnl" + sectionNO + "UsedStrains" + stationNO;
            ((Panel)(tp.Controls[strainsPnlName])).Controls.Clear();
            //enable use button
            string strainsListPanelName= "pnl" + sectionNO + "Strains" + stationNO;
            Panel pnlStrains = (Panel)tp.Controls[strainsListPanelName];
            pnlStrains.Enabled = true;
        }

        private void deleteStrainsFromDic(List<string> strainNames,string stationName,string sectionName)
        {
            foreach (string name in strainNames)
            {
                if(station[stationName][sectionName].ContainsKey(name))
                    station[stationName][sectionName].Remove(name);
            }
        }

        private void label62_Click(object sender, EventArgs e)
        {

        }

        private void tabPage26_Click(object sender, EventArgs e)
        {

        }

        private void dtpRecord_ValueChanged(object sender, EventArgs e)
        {
            bool ok = checkTime();
            if (!ok)
            {
                MessageBox.Show("يجب تسجيل بيانات اليوم الحالى فقط");
                return;
            }
        }
        private bool checkTime()
        {
            DateTime now = DateTime.Now;
            DateTime dt = dtpRecord.Value;
            int day1 = now.Day;
            int day2 = dt.Day;
            int month1 = now.Month;
            int month2 = dt.Month;
            int year1 = now.Year;
            int year2 = dt.Year;
            if (year2 == year1 && month2 == month1 && day2 == day1)
            {
                return true;
            }

            else
            {
                return false;
            }

        }

        private void pnl12Strains3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
