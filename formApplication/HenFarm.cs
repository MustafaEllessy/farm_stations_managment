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
    public partial class HenFarm : Form
    {
        public HenFarm()
        {
            InitializeComponent();
        }
        SortedDictionary<int, int> station2Data = new SortedDictionary<int, int>();
        SortedDictionary<string, SortedDictionary<string, decimal>> controlsDetails = new SortedDictionary<string, SortedDictionary<string, decimal>>();
        SortedDictionary<string, SortedDictionary<string, decimal>> controlsResult = new SortedDictionary<string, SortedDictionary<string, decimal>>();

        private void frmHenFarm_Load(object sender, EventArgs e)
        {  
            btnStation2.PerformClick();
        }

        private void updateTextBoxes()
        {
            DataTable dt = DB.Data("select * from HenFarmAutofillData");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string anberName = dt.Rows[i][1].ToString();
                int newAge = Convert.ToInt32(dt.Rows[i][2].ToString());
                int remainCount = Convert.ToInt32(dt.Rows[i][3].ToString());
                string textNo = "";
                if (anberName== "عنبر 1أ")
                {
                    textNo = 1+"";
                }
                else if (anberName== "عنبر 1ب")
                {
                    textNo = 2 + "";
                }
              else  if (anberName == "عنبر 2أ")
                {
                    textNo = 3 + "";
                }
                else if (anberName == "عنبر 2ب")
                {
                    textNo = 4 + "";
                }
                else if (anberName == "عنبر 3أ")
                {
                    textNo = 5 + "";
                }
                else if (anberName == "عنبر 3ب")
                {
                    textNo = 6 + "";
                }
                else if (anberName == "عنبر 4أ")
                {
                    textNo = 7 + "";
                }
                else if (anberName == "عنبر 4ب")
                {
                    textNo = 8+ "";
                }
                else if (anberName == "عنبر 5أ")
                {
                    textNo = 9 + "";
                }
                else if (anberName == "عنبر 5ب")
                {
                    textNo = 10 + "";
                }
                else if (anberName == "عنبر 6أ")
                {
                    textNo = 11 + "";
                }
                else if (anberName == "عنبر 6ب")
                {
                    textNo = 12 + "";
                }
        
                string countTextName="txt" + textNo + "CountO";
                string ageTextName = "txt" + textNo + "AgeO";
                tabTasmeen2.TabPages[int.Parse(textNo)-1].Controls[countTextName].Text = remainCount + "";
                ((TextBox)tabTasmeen2.TabPages[int.Parse(textNo) - 1].Controls[countTextName]).ReadOnly = true;
                tabTasmeen2.TabPages[int.Parse(textNo) - 1].Controls[ageTextName].Text = newAge + "";
                ((TextBox)tabTasmeen2.TabPages[int.Parse(textNo) - 1].Controls[ageTextName]).ReadOnly = true;
            }
        }



        /*   private void btnRecord_Click(object sender, EventArgs e)
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
                   DB.insertToDB("henFarm", new string[] { "recordDate", "ageGroup", "livingCount", "deadCount", "produceSoledHenCount" },
                   new object[] { dtRecord.Value.ToString("yyyy/MM/dd"), rdoAgeGroup1.Text, Convert.ToInt32(pnl1.Controls["txtLivingCount1"].Text), Convert.ToInt32(pnl1.Controls["txtDeadCount1"].Text),Convert.ToInt32(pnl1.Controls["txtSoledHensCount1"].Text) });
                   //ثانى فئة 
                   DB.insertToDB("henFarm", new string[] { "recordDate", "ageGroup", "livingCount", "deadCount", "produceSoledHenCount" },
                   new object[] { dtRecord.Value.ToString("yyyy/MM/dd"), rdoAgeGroup2.Text, Convert.ToInt32(pnl2.Controls["txtLivingCount2"].Text), Convert.ToInt32(pnl2.Controls["txtDeadCount2"].Text), Convert.ToInt32(pnl2.Controls["txtSoledHensCount2"].Text) });
                   MessageBox.Show("تم الحفظ");
                   Close();
               }
               catch (Exception ex)
               {
                   MessageBox.Show("لم يتم الحفظ");
                   MessageBox.Show(ex.Message);
               }
           }*/



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox21_TextChanged(object sender, EventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void label29_Click(object sender, EventArgs e)
        {

        }

        private void label30_Click(object sender, EventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void textBox22_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox23_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox24_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox25_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {

        }

    
        private void button2_Click(object sender, EventArgs e)
        {
            pnlTassmen2.Visible = true;
            btnStation2.BackColor = Color.Blue;
            btnStation2.ForeColor = Color.White;
        }
        public bool checkEmpty()
        {
            if (
           
              txt1AgeO.Text == "" || txt2AgeO.Text == "" || txt3AgeO.Text == "" || txt4AgeO.Text == "" || txt5AgeO.Text == "" ||
              txt6AgeO.Text == "" || txt7AgeO.Text == "" || txt8AgeO.Text == "" || txt9AgeO.Text == "" || txt10AgeO.Text == "" ||
              txt11AgeO.Text == "" || txt12AgeO.Text == "" ||
              txt1CountO.Text == "" || txt2CountO.Text == "" || txt3CountO.Text == "" || txt4CountO.Text == "" || txt5CountO.Text == "" ||
              txt6CountO.Text == "" || txt7CountO.Text == "" || txt8CountO.Text == "" || txt9CountO.Text == "" || txt10CountO.Text == "" ||
              txt11CountO.Text == "" || txt12CountO.Text == "" ||
              txt1DeadO.Text == "" || txt2DeadO.Text == "" || txt3DeadO.Text == "" || txt4DeadO.Text == "" || txt5DeadO.Text == "" ||
              txt6DeadO.Text == "" || txt7DeadO.Text == "" || txt8DeadO.Text == "" || txt9DeadO.Text == "" || txt10DeadO.Text == "" ||
              txt11DeadO.Text == "" || txt12DeadO.Text == "" ||
              txt1SoledHensO.Text == "" || txt2SoledHensO.Text == "" || txt3SoledHensO.Text == "" || txt4SoledHensO.Text == "" || txt5SoledHensO.Text == "" ||
              txt6SoledHensO.Text == "" || txt7SoledHensO.Text == "" || txt8SoledHensO.Text == "" || txt9SoledHensO.Text == "" || txt10SoledHensO.Text == "" ||
              txt11SoledHensO.Text == "" || txt12SoledHensO.Text == "" ||
              txt1SoledWeightO.Text == "" || txt2SoledWeightO.Text == "" || txt3SoledWeightO.Text == "" || txt4SoledWeightO.Text == "" || txt5SoledWeightO.Text == "" ||
              txt6SoledWeightO.Text == "" || txt7SoledWeightO.Text == "" || txt8SoledWeightO.Text == "" || txt9SoledWeightO.Text == "" || txt10SoledWeightO.Text == "" ||
              txt11SoledWeightO.Text == "" || txt12SoledWeightO.Text == ""
              )
            {

                return true;
            }
            return false;
        }
        public void loadDataInList()
        {
        
            for (int i = 0; i < tabTasmeen2.Controls.Count; i++)
            {
                for (int j = 0; j < tabTasmeen2.Controls[i].Controls.Count; j++)
                {
                    if (tabTasmeen2.Controls[i].Controls[j].GetType() == typeof(TextBox))
                    {
                        station2Data.Add(Convert.ToInt32(tabTasmeen2.Controls[i].Controls[j].Tag), Convert.ToInt32(tabTasmeen2.Controls[i].Controls[j].Text));
                    }
                }
            }

        }
        public bool checkRecorded()
        {
            DataTable rslt = DB.Data("select * from henFarm where recordDate=#" + dtpRecord.Value.ToString("yyyy/MM/dd") + "#");
            if (rslt.Rows.Count != 0) return true;
            return false;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                bool recorded = checkRecorded();
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
                if (checkEmpty())
                {
                    MessageBox.Show("املأ كل الخانات الفارغة ");
                    return;
                };
             
                loadDataInList();
                string sectionName = "";
                //insert station 2 data
                string stationName = "محطة 2";
                int anberCounter = 1;
                int partCounter=0; 
                for (int i = 1; i <= station2Data.Count; i += 5)
                {
                    if (partCounter == 1)
                    {
                        sectionName = "عنبر " + anberCounter + "ب";
                        partCounter = 0;
                        anberCounter++;
                    }
                    else
                    {
                        partCounter++;
                        sectionName = "عنبر " + anberCounter + "أ";
                    }
                    object[] stationData = new object[] { dtpRecord.Value.ToString("dd/MM/yyyy"), stationName, sectionName, station2Data[i], station2Data[i + 1], station2Data[i + 2], station2Data[i + 3], station2Data[i + 4] };
                    DB.insertToDB("henFarm", new string[] { "recordDate", "stationName", "sectionName", "age", "totalCount", "deadCount", "SoledHenCount", "SoledKiloWeight" }, stationData);
                }
                MessageBox.Show("تم الحفظ");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("يوجد مشكلة كالاتى ");
                MessageBox.Show(ex.Message);
            }
        
        }
        private void txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) e.Handled = true;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
          
            for (int i = 0; i < tabTasmeen2.TabPages.Count; i++)
            {
                for (int j = 0; j < tabTasmeen2.TabPages[i].Controls.Count; j++)
                {
                    if (tabTasmeen2.TabPages[i].Controls[j].GetType() == typeof(TextBox))
                        ((TextBox)tabTasmeen2.TabPages[i].Controls[j]).Text = 0 + "";
                }
            }
        }
        bool firstLoad = true;
        private void HenFarm_Resize(object sender, EventArgs e)
        {
            if (firstLoad)
            {
                formApplication.ResizeForm.initialFormHeight = 757;
                formApplication.ResizeForm.initialFormWidth = 1303;
                formApplication.ResizeForm.setContolDetails(this, controlsDetails);
                formApplication.ResizeForm.setControlResult(this,controlsDetails, controlsResult);
                firstLoad = false;
            }
            ResizeForm.changeControls(this, controlsResult);
        }

        private void HenFarm_Shown(object sender, EventArgs e)
        {
            updateTextBoxes();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabTasmeen2.TabPages[0].Controls["txt1CountO"].Text = "45";
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
        }

        private void dtpRecord_ValueChanged(object sender, EventArgs e)
        {
           bool ok= checkTime();
            if(!ok)
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
            if (year2 == year1 && month2 == month1 &&  day2 == day1)
            {
                return true;
            }

            else
            {
                return false;
            }

        }
    }
}
