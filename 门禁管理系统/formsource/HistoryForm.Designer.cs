namespace AccessControlManagementSystem
{
    partial class HistoryForm
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
            this.bt_ManageHistory = new System.Windows.Forms.Button();
            this.bt_OpenDoorHistory = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.bt_Export = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_SelecteFilter = new System.Windows.Forms.ComboBox();
            this.tb_Filter = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bt_Filter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_ManageHistory
            // 
            this.bt_ManageHistory.Location = new System.Drawing.Point(230, 21);
            this.bt_ManageHistory.Name = "bt_ManageHistory";
            this.bt_ManageHistory.Size = new System.Drawing.Size(103, 37);
            this.bt_ManageHistory.TabIndex = 0;
            this.bt_ManageHistory.Text = "管理历史记录";
            this.bt_ManageHistory.UseVisualStyleBackColor = true;
            this.bt_ManageHistory.Click += new System.EventHandler(this.bt_ManageHistory_Click);
            // 
            // bt_OpenDoorHistory
            // 
            this.bt_OpenDoorHistory.Location = new System.Drawing.Point(422, 21);
            this.bt_OpenDoorHistory.Name = "bt_OpenDoorHistory";
            this.bt_OpenDoorHistory.Size = new System.Drawing.Size(103, 37);
            this.bt_OpenDoorHistory.TabIndex = 1;
            this.bt_OpenDoorHistory.Text = "开门历史记录";
            this.bt_OpenDoorHistory.UseVisualStyleBackColor = true;
            this.bt_OpenDoorHistory.Click += new System.EventHandler(this.bt_OpenDoorHistory_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column4,
            this.Column3,
            this.Column5});
            this.dataGridView1.Location = new System.Drawing.Point(12, 154);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(833, 443);
            this.dataGridView1.TabIndex = 2;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "用户名";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "蓝牙MAC地址";
            this.Column2.Name = "Column2";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "时间";
            this.Column4.Name = "Column4";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "消息";
            this.Column3.Name = "Column3";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "选择";
            this.Column5.Name = "Column5";
            this.Column5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // bt_Export
            // 
            this.bt_Export.Location = new System.Drawing.Point(705, 652);
            this.bt_Export.Name = "bt_Export";
            this.bt_Export.Size = new System.Drawing.Size(95, 49);
            this.bt_Export.TabIndex = 3;
            this.bt_Export.Text = "导出";
            this.bt_Export.UseVisualStyleBackColor = true;
            this.bt_Export.Click += new System.EventHandler(this.bt_Export_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(124, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "条件";
            // 
            // cb_SelecteFilter
            // 
            this.cb_SelecteFilter.FormattingEnabled = true;
            this.cb_SelecteFilter.Items.AddRange(new object[] {
            "时间"});
            this.cb_SelecteFilter.Location = new System.Drawing.Point(127, 115);
            this.cb_SelecteFilter.Name = "cb_SelecteFilter";
            this.cb_SelecteFilter.Size = new System.Drawing.Size(108, 23);
            this.cb_SelecteFilter.TabIndex = 5;
            // 
            // tb_Filter
            // 
            this.tb_Filter.Location = new System.Drawing.Point(283, 115);
            this.tb_Filter.Name = "tb_Filter";
            this.tb_Filter.Size = new System.Drawing.Size(302, 25);
            this.tb_Filter.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(280, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "筛选的内容";
            // 
            // bt_Filter
            // 
            this.bt_Filter.Location = new System.Drawing.Point(620, 109);
            this.bt_Filter.Name = "bt_Filter";
            this.bt_Filter.Size = new System.Drawing.Size(91, 39);
            this.bt_Filter.TabIndex = 8;
            this.bt_Filter.Text = "筛选";
            this.bt_Filter.UseVisualStyleBackColor = true;
            // 
            // HistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 725);
            this.Controls.Add(this.bt_Filter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_Filter);
            this.Controls.Add(this.cb_SelecteFilter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_Export);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bt_OpenDoorHistory);
            this.Controls.Add(this.bt_ManageHistory);
            this.MaximizeBox = false;
            this.Name = "HistoryForm";
            this.Text = "历史记录";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_ManageHistory;
        private System.Windows.Forms.Button bt_OpenDoorHistory;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bt_Export;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_SelecteFilter;
        private System.Windows.Forms.TextBox tb_Filter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bt_Filter;
    }
}