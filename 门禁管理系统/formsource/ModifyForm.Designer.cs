namespace AccessControlManagementSystem.formsource
{
    partial class ModifyForm
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.bt_ModifyAccount = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_NewUserName = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.br_ModifyPassword = new System.Windows.Forms.Button();
            this.tb_ComfirmPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_NewPassword = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.bt_ModifyAuthority = new System.Windows.Forms.Button();
            this.rb_Normal = new System.Windows.Forms.RadioButton();
            this.rb_Manage = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "小梁",
            "胖墩"});
            this.comboBox1.Location = new System.Drawing.Point(194, 53);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(71, 126);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(646, 309);
            this.tabControl1.TabIndex = 4;
            this.tabControl1.Click += new System.EventHandler(this.tabControl1_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.bt_ModifyAccount);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.tb_NewUserName);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(638, 280);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "修改账户名";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // bt_ModifyAccount
            // 
            this.bt_ModifyAccount.Location = new System.Drawing.Point(441, 204);
            this.bt_ModifyAccount.Name = "bt_ModifyAccount";
            this.bt_ModifyAccount.Size = new System.Drawing.Size(86, 39);
            this.bt_ModifyAccount.TabIndex = 4;
            this.bt_ModifyAccount.Text = "应用";
            this.bt_ModifyAccount.UseVisualStyleBackColor = true;
            this.bt_ModifyAccount.Click += new System.EventHandler(this.bt_ModifyAccount_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "新用户名：";
            // 
            // tb_NewUserName
            // 
            this.tb_NewUserName.Location = new System.Drawing.Point(155, 106);
            this.tb_NewUserName.Name = "tb_NewUserName";
            this.tb_NewUserName.Size = new System.Drawing.Size(224, 25);
            this.tb_NewUserName.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.br_ModifyPassword);
            this.tabPage2.Controls.Add(this.tb_ComfirmPassword);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.tb_NewPassword);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(638, 280);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "修改密码";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // br_ModifyPassword
            // 
            this.br_ModifyPassword.Location = new System.Drawing.Point(445, 201);
            this.br_ModifyPassword.Name = "br_ModifyPassword";
            this.br_ModifyPassword.Size = new System.Drawing.Size(87, 43);
            this.br_ModifyPassword.TabIndex = 4;
            this.br_ModifyPassword.Text = "应用";
            this.br_ModifyPassword.UseVisualStyleBackColor = true;
            this.br_ModifyPassword.Click += new System.EventHandler(this.br_ModifyPassword_Click);
            // 
            // tb_ComfirmPassword
            // 
            this.tb_ComfirmPassword.Location = new System.Drawing.Point(163, 120);
            this.tb_ComfirmPassword.Name = "tb_ComfirmPassword";
            this.tb_ComfirmPassword.Size = new System.Drawing.Size(199, 25);
            this.tb_ComfirmPassword.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "确认密码：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "新密码：";
            // 
            // tb_NewPassword
            // 
            this.tb_NewPassword.Location = new System.Drawing.Point(163, 63);
            this.tb_NewPassword.Name = "tb_NewPassword";
            this.tb_NewPassword.Size = new System.Drawing.Size(199, 25);
            this.tb_NewPassword.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.bt_ModifyAuthority);
            this.tabPage3.Controls.Add(this.rb_Normal);
            this.tabPage3.Controls.Add(this.rb_Manage);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(638, 280);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "修改权限";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // bt_ModifyAuthority
            // 
            this.bt_ModifyAuthority.Location = new System.Drawing.Point(426, 203);
            this.bt_ModifyAuthority.Name = "bt_ModifyAuthority";
            this.bt_ModifyAuthority.Size = new System.Drawing.Size(93, 41);
            this.bt_ModifyAuthority.TabIndex = 2;
            this.bt_ModifyAuthority.Text = "应用";
            this.bt_ModifyAuthority.UseVisualStyleBackColor = true;
            // 
            // rb_Normal
            // 
            this.rb_Normal.AutoSize = true;
            this.rb_Normal.Location = new System.Drawing.Point(107, 118);
            this.rb_Normal.Name = "rb_Normal";
            this.rb_Normal.Size = new System.Drawing.Size(88, 19);
            this.rb_Normal.TabIndex = 1;
            this.rb_Normal.TabStop = true;
            this.rb_Normal.Text = "普通用户";
            this.rb_Normal.UseVisualStyleBackColor = true;
            // 
            // rb_Manage
            // 
            this.rb_Manage.AutoSize = true;
            this.rb_Manage.Location = new System.Drawing.Point(107, 60);
            this.rb_Manage.Name = "rb_Manage";
            this.rb_Manage.Size = new System.Drawing.Size(73, 19);
            this.rb_Manage.TabIndex = 0;
            this.rb_Manage.TabStop = true;
            this.rb_Manage.Text = "管理员";
            this.rb_Manage.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "选择用户：";
            // 
            // ModifyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 500);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.comboBox1);
            this.MaximizeBox = false;
            this.Name = "ModifyForm";
            this.Text = "修改";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox tb_NewUserName;
        private System.Windows.Forms.Button bt_ModifyAccount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button br_ModifyPassword;
        private System.Windows.Forms.TextBox tb_ComfirmPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_NewPassword;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.RadioButton rb_Normal;
        private System.Windows.Forms.RadioButton rb_Manage;
        private System.Windows.Forms.Button bt_ModifyAuthority;
        private System.Windows.Forms.Label label2;
    }
}