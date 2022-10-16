namespace formApplication
{
    partial class DisplayImportedEggs
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvFarmEggsStore = new System.Windows.Forms.DataGridView();
            this.colLastUpate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFarmEggsStore)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFarmEggsStore
            // 
            this.dgvFarmEggsStore.AllowUserToAddRows = false;
            this.dgvFarmEggsStore.AllowUserToDeleteRows = false;
            this.dgvFarmEggsStore.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFarmEggsStore.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Times New Roman", 16F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFarmEggsStore.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvFarmEggsStore.ColumnHeadersHeight = 60;
            this.dgvFarmEggsStore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvFarmEggsStore.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colLastUpate,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn4});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Times New Roman", 16F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFarmEggsStore.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvFarmEggsStore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFarmEggsStore.EnableHeadersVisualStyles = false;
            this.dgvFarmEggsStore.Location = new System.Drawing.Point(0, 0);
            this.dgvFarmEggsStore.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvFarmEggsStore.MultiSelect = false;
            this.dgvFarmEggsStore.Name = "dgvFarmEggsStore";
            this.dgvFarmEggsStore.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Times New Roman", 16F);
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFarmEggsStore.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvFarmEggsStore.RowHeadersWidth = 51;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvFarmEggsStore.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvFarmEggsStore.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvFarmEggsStore.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgvFarmEggsStore.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvFarmEggsStore.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Yellow;
            this.dgvFarmEggsStore.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvFarmEggsStore.RowTemplate.Height = 50;
            this.dgvFarmEggsStore.Size = new System.Drawing.Size(1285, 674);
            this.dgvFarmEggsStore.TabIndex = 9;
            this.dgvFarmEggsStore.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFarmEggsStore_CellContentClick);
            // 
            // colLastUpate
            // 
            this.colLastUpate.DataPropertyName = "ImportDate";
            this.colLastUpate.HeaderText = "تاريخ التوريد";
            this.colLastUpate.Name = "colLastUpate";
            this.colLastUpate.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "StationsName";
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewTextBoxColumn2.FillWeight = 160F;
            this.dataGridViewTextBoxColumn2.HeaderText = "اسم المحطة";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "EggsCount";
            this.dataGridViewTextBoxColumn4.FillWeight = 80F;
            this.dataGridViewTextBoxColumn4.HeaderText = "عدد البيض";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // DisplayImportedEggs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1285, 674);
            this.Controls.Add(this.dgvFarmEggsStore);
            this.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "DisplayImportedEggs";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "عرض وارد البيض";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmImportedEggsDisplay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFarmEggsStore)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFarmEggsStore;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLastUpate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}