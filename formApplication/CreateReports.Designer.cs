namespace formApplication
{
    partial class CreateReports
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateReports));
            this.cbxFarmType = new System.Windows.Forms.ComboBox();
            this.cbxShowType = new System.Windows.Forms.ComboBox();
            this.cbxShowOn = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlStatic = new System.Windows.Forms.Panel();
            this.pnlDynamic = new System.Windows.Forms.Panel();
            this.cbxCountPlace = new System.Windows.Forms.ComboBox();
            this.lblCountPlace = new System.Windows.Forms.Label();
            this.cbxReportType = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.clbItems = new System.Windows.Forms.CheckedListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxCount = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnMakeReport = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.btnPrintReport = new System.Windows.Forms.Button();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.pnlStatic.SuspendLayout();
            this.pnlDynamic.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbxFarmType
            // 
            this.cbxFarmType.FormattingEnabled = true;
            this.cbxFarmType.Items.AddRange(new object[] {
            "بياض",
            "تسمين"});
            this.cbxFarmType.Location = new System.Drawing.Point(623, 22);
            this.cbxFarmType.Name = "cbxFarmType";
            this.cbxFarmType.Size = new System.Drawing.Size(154, 39);
            this.cbxFarmType.TabIndex = 1;
            this.cbxFarmType.SelectedIndexChanged += new System.EventHandler(this.cbxFarmType_SelectedIndexChanged);
            // 
            // cbxShowType
            // 
            this.cbxShowType.FormattingEnabled = true;
            this.cbxShowType.Items.AddRange(new object[] {
            "مجمل",
            "مفصل"});
            this.cbxShowType.Location = new System.Drawing.Point(288, 21);
            this.cbxShowType.Name = "cbxShowType";
            this.cbxShowType.Size = new System.Drawing.Size(157, 39);
            this.cbxShowType.TabIndex = 1;
            // 
            // cbxShowOn
            // 
            this.cbxShowOn.FormattingEnabled = true;
            this.cbxShowOn.Items.AddRange(new object[] {
            "مزرعة",
            "محطة",
            "عنبر"});
            this.cbxShowOn.Location = new System.Drawing.Point(3, 17);
            this.cbxShowOn.Name = "cbxShowOn";
            this.cbxShowOn.Size = new System.Drawing.Size(142, 39);
            this.cbxShowOn.TabIndex = 2;
            this.cbxShowOn.SelectedIndexChanged += new System.EventHandler(this.cbxShowOn_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(795, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "نوع المزرعة";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(468, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "نوع العرض";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(157, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 32);
            this.label3.TabIndex = 5;
            this.label3.Text = "الحصر على";
            // 
            // pnlStatic
            // 
            this.pnlStatic.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlStatic.Controls.Add(this.cbxFarmType);
            this.pnlStatic.Controls.Add(this.label3);
            this.pnlStatic.Controls.Add(this.label1);
            this.pnlStatic.Controls.Add(this.cbxShowOn);
            this.pnlStatic.Controls.Add(this.label2);
            this.pnlStatic.Controls.Add(this.cbxShowType);
            this.pnlStatic.Location = new System.Drawing.Point(212, 102);
            this.pnlStatic.Name = "pnlStatic";
            this.pnlStatic.Size = new System.Drawing.Size(936, 92);
            this.pnlStatic.TabIndex = 0;
            this.pnlStatic.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlStatic_Paint);
            // 
            // pnlDynamic
            // 
            this.pnlDynamic.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlDynamic.Controls.Add(this.cbxCountPlace);
            this.pnlDynamic.Controls.Add(this.lblCountPlace);
            this.pnlDynamic.Controls.Add(this.cbxReportType);
            this.pnlDynamic.Controls.Add(this.label8);
            this.pnlDynamic.Controls.Add(this.dtpEnd);
            this.pnlDynamic.Controls.Add(this.dtpStart);
            this.pnlDynamic.Controls.Add(this.label7);
            this.pnlDynamic.Controls.Add(this.label6);
            this.pnlDynamic.Controls.Add(this.clbItems);
            this.pnlDynamic.Controls.Add(this.label5);
            this.pnlDynamic.Controls.Add(this.cbxCount);
            this.pnlDynamic.Controls.Add(this.label4);
            this.pnlDynamic.Location = new System.Drawing.Point(212, 246);
            this.pnlDynamic.Name = "pnlDynamic";
            this.pnlDynamic.Size = new System.Drawing.Size(936, 298);
            this.pnlDynamic.TabIndex = 1;
            this.pnlDynamic.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlDynamic_Paint);
            // 
            // cbxCountPlace
            // 
            this.cbxCountPlace.FormattingEnabled = true;
            this.cbxCountPlace.Location = new System.Drawing.Point(623, 71);
            this.cbxCountPlace.Name = "cbxCountPlace";
            this.cbxCountPlace.Size = new System.Drawing.Size(154, 39);
            this.cbxCountPlace.TabIndex = 6;
            this.cbxCountPlace.SelectedIndexChanged += new System.EventHandler(this.cbxCountPlace_SelectedIndexChanged);
            // 
            // lblCountPlace
            // 
            this.lblCountPlace.AutoSize = true;
            this.lblCountPlace.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountPlace.Location = new System.Drawing.Point(825, 74);
            this.lblCountPlace.Name = "lblCountPlace";
            this.lblCountPlace.Size = new System.Drawing.Size(99, 32);
            this.lblCountPlace.TabIndex = 0;
            this.lblCountPlace.Text = "مكان العد";
            // 
            // cbxReportType
            // 
            this.cbxReportType.FormattingEnabled = true;
            this.cbxReportType.Items.AddRange(new object[] {
            "جداول",
            "رسومات بيانية"});
            this.cbxReportType.Location = new System.Drawing.Point(310, 232);
            this.cbxReportType.Name = "cbxReportType";
            this.cbxReportType.Size = new System.Drawing.Size(213, 39);
            this.cbxReportType.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(547, 235);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 32);
            this.label8.TabIndex = 5;
            this.label8.Text = "نوع التقرير";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // dtpEnd
            // 
            this.dtpEnd.Location = new System.Drawing.Point(46, 146);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.RightToLeftLayout = true;
            this.dtpEnd.Size = new System.Drawing.Size(200, 38);
            this.dtpEnd.TabIndex = 10;
            // 
            // dtpStart
            // 
            this.dtpStart.Location = new System.Drawing.Point(46, 68);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.RightToLeftLayout = true;
            this.dtpStart.Size = new System.Drawing.Size(200, 38);
            this.dtpStart.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(257, 152);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 32);
            this.label7.TabIndex = 4;
            this.label7.Text = "إلى";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(260, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 32);
            this.label6.TabIndex = 3;
            this.label6.Text = "من";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // clbItems
            // 
            this.clbItems.BackColor = System.Drawing.SystemColors.Menu;
            this.clbItems.FormattingEnabled = true;
            this.clbItems.Location = new System.Drawing.Point(349, 39);
            this.clbItems.Name = "clbItems";
            this.clbItems.Size = new System.Drawing.Size(143, 136);
            this.clbItems.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(513, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 32);
            this.label5.TabIndex = 2;
            this.label5.Text = "الحقول";
            // 
            // cbxCount
            // 
            this.cbxCount.FormattingEnabled = true;
            this.cbxCount.Location = new System.Drawing.Point(623, 174);
            this.cbxCount.Name = "cbxCount";
            this.cbxCount.Size = new System.Drawing.Size(154, 39);
            this.cbxCount.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(833, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 32);
            this.label4.TabIndex = 1;
            this.label4.Text = "نوع العد";
            // 
            // btnMakeReport
            // 
            this.btnMakeReport.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMakeReport.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMakeReport.Location = new System.Drawing.Point(354, 592);
            this.btnMakeReport.Name = "btnMakeReport";
            this.btnMakeReport.Size = new System.Drawing.Size(314, 51);
            this.btnMakeReport.TabIndex = 2;
            this.btnMakeReport.Text = "عرض التقرير";
            this.btnMakeReport.UseVisualStyleBackColor = true;
            this.btnMakeReport.Click += new System.EventHandler(this.btnMakeReport_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // btnPrintReport
            // 
            this.btnPrintReport.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPrintReport.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintReport.Location = new System.Drawing.Point(701, 592);
            this.btnPrintReport.Name = "btnPrintReport";
            this.btnPrintReport.Size = new System.Drawing.Size(314, 51);
            this.btnPrintReport.TabIndex = 2;
            this.btnPrintReport.Text = "طباعة التقرير";
            this.btnPrintReport.UseVisualStyleBackColor = true;
            this.btnPrintReport.Click += new System.EventHandler(this.btnPrintReport_Click);
            // 
            // printDialog1
            // 
            this.printDialog1.Document = this.printDocument1;
            this.printDialog1.UseEXDialog = true;
            // 
            // CreateReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1295, 710);
            this.Controls.Add(this.btnPrintReport);
            this.Controls.Add(this.btnMakeReport);
            this.Controls.Add(this.pnlDynamic);
            this.Controls.Add(this.pnlStatic);
            this.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "CreateReports";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "عمل تقرير";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmFarms_Load);
            this.Shown += new System.EventHandler(this.CreateReports_Shown);
            this.Resize += new System.EventHandler(this.FarmsMenu_Resize);
            this.pnlStatic.ResumeLayout(false);
            this.pnlStatic.PerformLayout();
            this.pnlDynamic.ResumeLayout(false);
            this.pnlDynamic.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxFarmType;
        private System.Windows.Forms.ComboBox cbxShowType;
        private System.Windows.Forms.ComboBox cbxShowOn;
        private System.Windows.Forms.Panel pnlStatic;
        private System.Windows.Forms.Panel pnlDynamic;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMakeReport;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckedListBox clbItems;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxCount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbxReportType;
        private System.Windows.Forms.ComboBox cbxCountPlace;
        private System.Windows.Forms.Label lblCountPlace;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Button btnPrintReport;
        private System.Windows.Forms.PrintDialog printDialog1;
    }
}