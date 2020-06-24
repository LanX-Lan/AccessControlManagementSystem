namespace AccessControlManagementSystem
{
    partial class MainForm
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
            System.Windows.Forms.Label label4;
            this.pl_Part1Button = new System.Windows.Forms.Panel();
            this.bt_Delete = new System.Windows.Forms.Button();
            this.bt_Import = new System.Windows.Forms.Button();
            this.bt_History = new System.Windows.Forms.Button();
            this.bt_Modify = new System.Windows.Forms.Button();
            this.bt_Find = new System.Windows.Forms.Button();
            this.bt_register = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tb_Account = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_Access = new System.Windows.Forms.TextBox();
            this.bt_Save = new System.Windows.Forms.Button();
            this.tb_MACAdress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pl_Part4ALLBasicInfos = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.选择 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.bt_UserAccount = new System.Windows.Forms.Button();
            this.bt_Exit = new System.Windows.Forms.Button();
            this.bt_ShowData = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tp_AccountMessage = new System.Windows.Forms.TabPage();
            this.tp_History = new System.Windows.Forms.TabPage();
            label4 = new System.Windows.Forms.Label();
            this.pl_Part1Button.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel1.SuspendLayout();
            this.pl_Part4ALLBasicInfos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tp_AccountMessage.SuspendLayout();
            this.tp_History.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(46, 21);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(97, 15);
            label4.TabIndex = 6;
            label4.Text = "输入用户名：";
            // 
            // pl_Part1Button
            // 
            this.pl_Part1Button.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pl_Part1Button.Controls.Add(this.bt_Delete);
            this.pl_Part1Button.Controls.Add(this.bt_Import);
            this.pl_Part1Button.Controls.Add(this.bt_History);
            this.pl_Part1Button.Controls.Add(this.bt_Modify);
            this.pl_Part1Button.Controls.Add(this.bt_Find);
            this.pl_Part1Button.Controls.Add(this.bt_register);
            this.pl_Part1Button.Location = new System.Drawing.Point(12, 52);
            this.pl_Part1Button.Name = "pl_Part1Button";
            this.pl_Part1Button.Size = new System.Drawing.Size(609, 239);
            this.pl_Part1Button.TabIndex = 0;
            // 
            // bt_Delete
            // 
            this.bt_Delete.Location = new System.Drawing.Point(104, 125);
            this.bt_Delete.Name = "bt_Delete";
            this.bt_Delete.Size = new System.Drawing.Size(93, 36);
            this.bt_Delete.TabIndex = 3;
            this.bt_Delete.Text = "删除";
            this.bt_Delete.UseVisualStyleBackColor = true;
            this.bt_Delete.Click += new System.EventHandler(this.bt_Delete_Click);
            // 
            // bt_Import
            // 
            this.bt_Import.Location = new System.Drawing.Point(327, 125);
            this.bt_Import.Name = "bt_Import";
            this.bt_Import.Size = new System.Drawing.Size(93, 36);
            this.bt_Import.TabIndex = 5;
            this.bt_Import.Text = "导入";
            this.bt_Import.UseVisualStyleBackColor = true;
            this.bt_Import.Click += new System.EventHandler(this.bt_Import_Click);
            // 
            // bt_History
            // 
            this.bt_History.Location = new System.Drawing.Point(217, 125);
            this.bt_History.Name = "bt_History";
            this.bt_History.Size = new System.Drawing.Size(93, 36);
            this.bt_History.TabIndex = 4;
            this.bt_History.Text = "历史记录";
            this.bt_History.UseVisualStyleBackColor = true;
            this.bt_History.Click += new System.EventHandler(this.bt_History_Click);
            // 
            // bt_Modify
            // 
            this.bt_Modify.Location = new System.Drawing.Point(327, 58);
            this.bt_Modify.Name = "bt_Modify";
            this.bt_Modify.Size = new System.Drawing.Size(93, 36);
            this.bt_Modify.TabIndex = 2;
            this.bt_Modify.Text = "修改";
            this.bt_Modify.UseVisualStyleBackColor = true;
            this.bt_Modify.Click += new System.EventHandler(this.bt_Modify_Click);
            // 
            // bt_Find
            // 
            this.bt_Find.Location = new System.Drawing.Point(217, 58);
            this.bt_Find.Name = "bt_Find";
            this.bt_Find.Size = new System.Drawing.Size(93, 36);
            this.bt_Find.TabIndex = 1;
            this.bt_Find.Text = "查找";
            this.bt_Find.UseVisualStyleBackColor = true;
            this.bt_Find.Click += new System.EventHandler(this.bt_Find_Click);
            // 
            // bt_register
            // 
            this.bt_register.Location = new System.Drawing.Point(104, 58);
            this.bt_register.Name = "bt_register";
            this.bt_register.Size = new System.Drawing.Size(93, 36);
            this.bt_register.TabIndex = 0;
            this.bt_register.Text = "注册";
            this.bt_register.UseVisualStyleBackColor = true;
            this.bt_register.Click += new System.EventHandler(this.bt_register_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.Column7,
            this.Column8,
            this.Column9});
            this.dataGridView2.Location = new System.Drawing.Point(3, 6);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 27;
            this.dataGridView2.Size = new System.Drawing.Size(592, 443);
            this.dataGridView2.TabIndex = 10;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "用户名";
            this.Column5.Name = "Column5";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "蓝牙MAC地址";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "时间";
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.HeaderText = "消息";
            this.Column9.Name = "Column9";
            // 
            // tb_Account
            // 
            this.tb_Account.Location = new System.Drawing.Point(123, 49);
            this.tb_Account.Name = "tb_Account";
            this.tb_Account.ReadOnly = true;
            this.tb_Account.Size = new System.Drawing.Size(240, 25);
            this.tb_Account.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(65, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "用户名：";
            // 
            // tb_Access
            // 
            this.tb_Access.Location = new System.Drawing.Point(133, 161);
            this.tb_Access.Name = "tb_Access";
            this.tb_Access.ReadOnly = true;
            this.tb_Access.Size = new System.Drawing.Size(97, 25);
            this.tb_Access.TabIndex = 7;
            // 
            // bt_Save
            // 
            this.bt_Save.Location = new System.Drawing.Point(261, 307);
            this.bt_Save.Name = "bt_Save";
            this.bt_Save.Size = new System.Drawing.Size(75, 31);
            this.bt_Save.TabIndex = 6;
            this.bt_Save.Text = "保存";
            this.bt_Save.UseVisualStyleBackColor = true;
            this.bt_Save.Click += new System.EventHandler(this.bt_Save_Click);
            // 
            // tb_MACAdress
            // 
            this.tb_MACAdress.Location = new System.Drawing.Point(133, 99);
            this.tb_MACAdress.Name = "tb_MACAdress";
            this.tb_MACAdress.ReadOnly = true;
            this.tb_MACAdress.Size = new System.Drawing.Size(240, 25);
            this.tb_MACAdress.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "权限：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "蓝牙MAC地址：";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(label4);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Location = new System.Drawing.Point(627, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(848, 239);
            this.panel1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(648, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 25);
            this.button1.TabIndex = 6;
            this.button1.Text = "搜索";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(158, 18);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(452, 25);
            this.textBox1.TabIndex = 0;
            // 
            // pl_Part4ALLBasicInfos
            // 
            this.pl_Part4ALLBasicInfos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pl_Part4ALLBasicInfos.Controls.Add(this.dataGridView1);
            this.pl_Part4ALLBasicInfos.Location = new System.Drawing.Point(627, 297);
            this.pl_Part4ALLBasicInfos.Name = "pl_Part4ALLBasicInfos";
            this.pl_Part4ALLBasicInfos.Size = new System.Drawing.Size(852, 489);
            this.pl_Part4ALLBasicInfos.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.选择,
            this.Column1,
            this.Column3,
            this.Column4,
            this.Column6});
            this.dataGridView1.Location = new System.Drawing.Point(14, 7);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(826, 487);
            this.dataGridView1.TabIndex = 0;
            // 
            // 选择
            // 
            this.选择.FillWeight = 99.8632F;
            this.选择.HeaderText = "选择";
            this.选择.Name = "选择";
            this.选择.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.选择.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Column1
            // 
            this.Column1.FillWeight = 100.234F;
            this.Column1.HeaderText = "用户名";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column3
            // 
            this.Column3.FillWeight = 99.84648F;
            this.Column3.HeaderText = "蓝牙MAC地址";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column4
            // 
            this.Column4.FillWeight = 100.2206F;
            this.Column4.HeaderText = "权限";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column6
            // 
            this.Column6.FalseValue = "";
            this.Column6.FillWeight = 99.83579F;
            this.Column6.HeaderText = "禁用";
            this.Column6.IndeterminateValue = "";
            this.Column6.Name = "Column6";
            this.Column6.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // bt_UserAccount
            // 
            this.bt_UserAccount.Location = new System.Drawing.Point(12, 12);
            this.bt_UserAccount.Name = "bt_UserAccount";
            this.bt_UserAccount.Size = new System.Drawing.Size(114, 34);
            this.bt_UserAccount.TabIndex = 4;
            this.bt_UserAccount.Text = "用户账户";
            this.bt_UserAccount.UseVisualStyleBackColor = true;
            this.bt_UserAccount.Click += new System.EventHandler(this.bt_UserAccount_Click);
            // 
            // bt_Exit
            // 
            this.bt_Exit.Location = new System.Drawing.Point(149, 12);
            this.bt_Exit.Name = "bt_Exit";
            this.bt_Exit.Size = new System.Drawing.Size(114, 34);
            this.bt_Exit.TabIndex = 5;
            this.bt_Exit.Text = "退出";
            this.bt_Exit.UseVisualStyleBackColor = true;
            this.bt_Exit.Click += new System.EventHandler(this.bt_Exit_Click);
            // 
            // bt_ShowData
            // 
            this.bt_ShowData.Location = new System.Drawing.Point(1365, 814);
            this.bt_ShowData.Name = "bt_ShowData";
            this.bt_ShowData.Size = new System.Drawing.Size(93, 31);
            this.bt_ShowData.TabIndex = 6;
            this.bt_ShowData.Text = "增加数据";
            this.bt_ShowData.UseVisualStyleBackColor = true;
            this.bt_ShowData.Click += new System.EventHandler(this.bt_ShowData_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tp_AccountMessage);
            this.tabControl1.Controls.Add(this.tp_History);
            this.tabControl1.Location = new System.Drawing.Point(12, 305);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(609, 481);
            this.tabControl1.TabIndex = 11;
            // 
            // tp_AccountMessage
            // 
            this.tp_AccountMessage.Controls.Add(this.tb_MACAdress);
            this.tp_AccountMessage.Controls.Add(this.label3);
            this.tp_AccountMessage.Controls.Add(this.bt_Save);
            this.tp_AccountMessage.Controls.Add(this.tb_Account);
            this.tp_AccountMessage.Controls.Add(this.label2);
            this.tp_AccountMessage.Controls.Add(this.label5);
            this.tp_AccountMessage.Controls.Add(this.tb_Access);
            this.tp_AccountMessage.Location = new System.Drawing.Point(4, 25);
            this.tp_AccountMessage.Name = "tp_AccountMessage";
            this.tp_AccountMessage.Padding = new System.Windows.Forms.Padding(3);
            this.tp_AccountMessage.Size = new System.Drawing.Size(601, 452);
            this.tp_AccountMessage.TabIndex = 0;
            this.tp_AccountMessage.Text = "用户信息";
            this.tp_AccountMessage.UseVisualStyleBackColor = true;
            // 
            // tp_History
            // 
            this.tp_History.Controls.Add(this.dataGridView2);
            this.tp_History.Location = new System.Drawing.Point(4, 25);
            this.tp_History.Name = "tp_History";
            this.tp_History.Padding = new System.Windows.Forms.Padding(3);
            this.tp_History.Size = new System.Drawing.Size(601, 452);
            this.tp_History.TabIndex = 1;
            this.tp_History.Text = "历史记录";
            this.tp_History.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1501, 848);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.bt_ShowData);
            this.Controls.Add(this.bt_Exit);
            this.Controls.Add(this.bt_UserAccount);
            this.Controls.Add(this.pl_Part4ALLBasicInfos);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pl_Part1Button);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "主界面";
            this.pl_Part1Button.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pl_Part4ALLBasicInfos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tp_AccountMessage.ResumeLayout(false);
            this.tp_AccountMessage.PerformLayout();
            this.tp_History.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pl_Part1Button;
        private System.Windows.Forms.Button bt_register;
        private System.Windows.Forms.Button bt_History;
        private System.Windows.Forms.Button bt_Delete;
        private System.Windows.Forms.Button bt_Modify;
        private System.Windows.Forms.Button bt_Find;
        private System.Windows.Forms.Button bt_Import;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel pl_Part4ALLBasicInfos;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bt_Save;
        private System.Windows.Forms.TextBox tb_MACAdress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_Access;
        private System.Windows.Forms.TextBox tb_Account;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bt_UserAccount;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.Button bt_Exit;
        private System.Windows.Forms.Button bt_ShowData;
        private System.Windows.Forms.DataGridViewCheckBoxColumn 选择;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column6;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tp_AccountMessage;
        private System.Windows.Forms.TabPage tp_History;
    }
}