namespace AccessControlManagementSystem
{
    partial class SearchForm
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
            this.cb_SelectMessage = new System.Windows.Forms.ComboBox();
            this.tb_SearchValue = new System.Windows.Forms.TextBox();
            this.bt_Search = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cb_SelectMessage
            // 
            this.cb_SelectMessage.FormattingEnabled = true;
            this.cb_SelectMessage.Items.AddRange(new object[] {
            "用户名",
            "蓝牙MAC地址"});
            this.cb_SelectMessage.Location = new System.Drawing.Point(83, 72);
            this.cb_SelectMessage.Name = "cb_SelectMessage";
            this.cb_SelectMessage.Size = new System.Drawing.Size(121, 23);
            this.cb_SelectMessage.TabIndex = 0;
            // 
            // tb_SearchValue
            // 
            this.tb_SearchValue.Location = new System.Drawing.Point(245, 70);
            this.tb_SearchValue.Name = "tb_SearchValue";
            this.tb_SearchValue.Size = new System.Drawing.Size(315, 25);
            this.tb_SearchValue.TabIndex = 2;
            // 
            // bt_Search
            // 
            this.bt_Search.Location = new System.Drawing.Point(616, 61);
            this.bt_Search.Name = "bt_Search";
            this.bt_Search.Size = new System.Drawing.Size(87, 34);
            this.bt_Search.TabIndex = 3;
            this.bt_Search.Text = "查找";
            this.bt_Search.UseVisualStyleBackColor = true;
            this.bt_Search.Click += new System.EventHandler(this.bt_Search_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "选择条件";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(242, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "输入需要查找的内容";
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 531);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_Search);
            this.Controls.Add(this.tb_SearchValue);
            this.Controls.Add(this.cb_SelectMessage);
            this.MaximizeBox = false;
            this.Name = "SearchForm";
            this.Text = "查找";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_SelectMessage;
        private System.Windows.Forms.TextBox tb_SearchValue;
        private System.Windows.Forms.Button bt_Search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}