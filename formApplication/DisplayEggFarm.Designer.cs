namespace formApplication
{
    partial class DisplayEggFarm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvEggFarm = new System.Windows.Forms.DataGridView();
            this.colRecordDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAnberName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStrainName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLivingCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDeadCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEggsCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoledHensCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoledWeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEggFarm)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEggFarm
            // 
            this.dgvEggFarm.AllowUserToAddRows = false;
            this.dgvEggFarm.AllowUserToDeleteRows = false;
            this.dgvEggFarm.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEggFarm.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEggFarm.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEggFarm.ColumnHeadersHeight = 70;
            this.dgvEggFarm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvEggFarm.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colRecordDate,
            this.colStation,
            this.colAnberName,
            this.colStrainName,
            this.colAge,
            this.colLivingCount,
            this.colDeadCount,
            this.colEggsCount,
            this.colSoledHensCount,
            this.colSoledWeight});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEggFarm.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvEggFarm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEggFarm.EnableHeadersVisualStyles = false;
            this.dgvEggFarm.Location = new System.Drawing.Point(0, 0);
            this.dgvEggFarm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvEggFarm.MultiSelect = false;
            this.dgvEggFarm.Name = "dgvEggFarm";
            this.dgvEggFarm.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEggFarm.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvEggFarm.RowHeadersWidth = 51;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvEggFarm.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvEggFarm.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvEggFarm.RowTemplate.Height = 60;
            this.dgvEggFarm.Size = new System.Drawing.Size(1285, 674);
            this.dgvEggFarm.TabIndex = 6;
            this.dgvEggFarm.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEggFarm_CellContentClick);
            // 
            // colRecordDate
            // 
            this.colRecordDate.DataPropertyName = "recordDate";
            dataGridViewCellStyle2.Format = "D";
            dataGridViewCellStyle2.NullValue = null;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.colRecordDate.DefaultCellStyle = dataGridViewCellStyle2;
            this.colRecordDate.FillWeight = 110F;
            this.colRecordDate.HeaderText = "تاريخ التسجيل";
            this.colRecordDate.MinimumWidth = 6;
            this.colRecordDate.Name = "colRecordDate";
            this.colRecordDate.ReadOnly = true;
            this.colRecordDate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colRecordDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colStation
            // 
            this.colStation.DataPropertyName = "stationName";
            this.colStation.HeaderText = "المحطة";
            this.colStation.MinimumWidth = 6;
            this.colStation.Name = "colStation";
            this.colStation.ReadOnly = true;
            this.colStation.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colStation.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colAnberName
            // 
            this.colAnberName.DataPropertyName = "sectionName";
            this.colAnberName.HeaderText = "القسم";
            this.colAnberName.MinimumWidth = 6;
            this.colAnberName.Name = "colAnberName";
            this.colAnberName.ReadOnly = true;
            // 
            // colStrainName
            // 
            this.colStrainName.DataPropertyName = "strainName";
            this.colStrainName.HeaderText = "السلالة";
            this.colStrainName.MinimumWidth = 6;
            this.colStrainName.Name = "colStrainName";
            this.colStrainName.ReadOnly = true;
            // 
            // colAge
            // 
            this.colAge.DataPropertyName = "Age";
            this.colAge.HeaderText = "العمر باليوم";
            this.colAge.MinimumWidth = 6;
            this.colAge.Name = "colAge";
            this.colAge.ReadOnly = true;
            // 
            // colLivingCount
            // 
            this.colLivingCount.DataPropertyName = "totalCount";
            this.colLivingCount.HeaderText = "العدد";
            this.colLivingCount.MinimumWidth = 6;
            this.colLivingCount.Name = "colLivingCount";
            this.colLivingCount.ReadOnly = true;
            this.colLivingCount.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // colDeadCount
            // 
            this.colDeadCount.DataPropertyName = "deadCount";
            this.colDeadCount.FillWeight = 90F;
            this.colDeadCount.HeaderText = "النافق";
            this.colDeadCount.MinimumWidth = 6;
            this.colDeadCount.Name = "colDeadCount";
            this.colDeadCount.ReadOnly = true;
            this.colDeadCount.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // colEggsCount
            // 
            this.colEggsCount.DataPropertyName = "produceEggCount";
            this.colEggsCount.HeaderText = "البيض الناتج";
            this.colEggsCount.MinimumWidth = 6;
            this.colEggsCount.Name = "colEggsCount";
            this.colEggsCount.ReadOnly = true;
            // 
            // colSoledHensCount
            // 
            this.colSoledHensCount.DataPropertyName = "soledHenCount";
            this.colSoledHensCount.HeaderText = "الدواجن المباعة";
            this.colSoledHensCount.MinimumWidth = 6;
            this.colSoledHensCount.Name = "colSoledHensCount";
            this.colSoledHensCount.ReadOnly = true;
            // 
            // colSoledWeight
            // 
            this.colSoledWeight.DataPropertyName = "soledKiloWeight";
            this.colSoledWeight.HeaderText = "الأوزان المباعة";
            this.colSoledWeight.MinimumWidth = 6;
            this.colSoledWeight.Name = "colSoledWeight";
            this.colSoledWeight.ReadOnly = true;
            // 
            // DisplayEggFarm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1285, 674);
            this.Controls.Add(this.dgvEggFarm);
            this.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "DisplayEggFarm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "عرض مزرعة البياض";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmEggFarmDisplay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEggFarm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEggFarm;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoledWeight;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoledHensCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEggsCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDeadCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLivingCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAge;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStrainName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAnberName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStation;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRecordDate;
    }
}