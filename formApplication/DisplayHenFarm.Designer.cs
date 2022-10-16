namespace formApplication
{
    partial class DisplayHenFarm
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
            this.dgvHenFarm = new System.Windows.Forms.DataGridView();
            this.colRecordDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAgeGroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAnberName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLivingCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDeadCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoledHensCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHenFarm)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvHenFarm
            // 
            this.dgvHenFarm.AllowUserToAddRows = false;
            this.dgvHenFarm.AllowUserToDeleteRows = false;
            this.dgvHenFarm.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHenFarm.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHenFarm.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvHenFarm.ColumnHeadersHeight = 70;
            this.dgvHenFarm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvHenFarm.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colRecordDate,
            this.colAgeGroup,
            this.colAnberName,
            this.Column1,
            this.colLivingCount,
            this.colDeadCount,
            this.colSoledHensCount,
            this.Column2});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvHenFarm.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvHenFarm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHenFarm.EnableHeadersVisualStyles = false;
            this.dgvHenFarm.Location = new System.Drawing.Point(0, 0);
            this.dgvHenFarm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvHenFarm.MultiSelect = false;
            this.dgvHenFarm.Name = "dgvHenFarm";
            this.dgvHenFarm.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHenFarm.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvHenFarm.RowHeadersWidth = 51;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvHenFarm.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvHenFarm.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvHenFarm.RowTemplate.Height = 60;
            this.dgvHenFarm.Size = new System.Drawing.Size(1303, 721);
            this.dgvHenFarm.TabIndex = 7;
            // 
            // colRecordDate
            // 
            this.colRecordDate.DataPropertyName = "recordDate";
            dataGridViewCellStyle2.Format = "D";
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.colRecordDate.DefaultCellStyle = dataGridViewCellStyle2;
            this.colRecordDate.FillWeight = 120F;
            this.colRecordDate.HeaderText = "تاريخ التسجيل";
            this.colRecordDate.MinimumWidth = 6;
            this.colRecordDate.Name = "colRecordDate";
            this.colRecordDate.ReadOnly = true;
            this.colRecordDate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colRecordDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colAgeGroup
            // 
            this.colAgeGroup.DataPropertyName = "stationName";
            this.colAgeGroup.HeaderText = "المحطة";
            this.colAgeGroup.MinimumWidth = 6;
            this.colAgeGroup.Name = "colAgeGroup";
            this.colAgeGroup.ReadOnly = true;
            this.colAgeGroup.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colAgeGroup.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colAnberName
            // 
            this.colAnberName.DataPropertyName = "sectionName";
            this.colAnberName.FillWeight = 90F;
            this.colAnberName.HeaderText = "القسم";
            this.colAnberName.MinimumWidth = 6;
            this.colAnberName.Name = "colAnberName";
            this.colAnberName.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "age";
            this.Column1.FillWeight = 90F;
            this.Column1.HeaderText = "العمر باليوم";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // colLivingCount
            // 
            this.colLivingCount.DataPropertyName = "totalCount";
            this.colLivingCount.HeaderText = "عدد الدواجن";
            this.colLivingCount.MinimumWidth = 6;
            this.colLivingCount.Name = "colLivingCount";
            this.colLivingCount.ReadOnly = true;
            this.colLivingCount.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colLivingCount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colDeadCount
            // 
            this.colDeadCount.DataPropertyName = "deadCount";
            this.colDeadCount.HeaderText = "عدد النافق";
            this.colDeadCount.MinimumWidth = 6;
            this.colDeadCount.Name = "colDeadCount";
            this.colDeadCount.ReadOnly = true;
            this.colDeadCount.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colDeadCount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colSoledHensCount
            // 
            this.colSoledHensCount.DataPropertyName = "SoledHenCount";
            this.colSoledHensCount.HeaderText = "الدواجن المباعة";
            this.colSoledHensCount.MinimumWidth = 6;
            this.colSoledHensCount.Name = "colSoledHensCount";
            this.colSoledHensCount.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "SoledKiloWeight";
            this.Column2.HeaderText = "الأوزان المباعة";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // DisplayHenFarm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1303, 721);
            this.Controls.Add(this.dgvHenFarm);
            this.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "DisplayHenFarm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "عرض مزرعة التسمين";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmHenFarmDisplay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHenFarm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHenFarm;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoledHensCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDeadCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLivingCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAnberName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAgeGroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRecordDate;
    }
}