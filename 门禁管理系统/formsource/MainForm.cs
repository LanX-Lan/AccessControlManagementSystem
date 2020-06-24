using AccessControlManagementSystem.formsource;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccessControlManagementSystem
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            foreach (DataGridViewColumn item in this.dataGridView1.Columns)
            {
                item.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            
        }

        private void bt_Delete_Click(object sender, EventArgs e)
        {
            
        }

        private void bt_register_Click(object sender, EventArgs e)
        {
            using (RegisterForm rf = new RegisterForm()) //caozuo是窗口类名，确保访问；后面的是构造函数
            {
                rf.ShowDialog();
            }
        }

        private void bt_Find_Click(object sender, EventArgs e)
        {
            using (SearchForm sf = new SearchForm()) //caozuo是窗口类名，确保访问；后面的是构造函数
            {
                sf.ShowDialog();
            }
        }

        private void bt_Modify_Click(object sender, EventArgs e)
        {
            using (ModifyForm mf = new ModifyForm()) //caozuo是窗口类名，确保访问；后面的是构造函数
            {
                mf.ShowDialog();
            }
        }

        private void bt_History_Click(object sender, EventArgs e)
        {
            using (HistoryForm hf = new HistoryForm()) //caozuo是窗口类名，确保访问；后面的是构造函数
            {
                hf.ShowDialog();
            }
        }

        private void bt_Import_Click(object sender, EventArgs e)
        {
            using (ImportForm importf = new ImportForm()) //caozuo是窗口类名，确保访问；后面的是构造函数
            {
                importf.ShowDialog();
            }
        }

        private void bt_Save_Click(object sender, EventArgs e)
        {

            /* Button bt_Save = sender as Button;
             bt_Save.Text = "点击";*/
        }

        private void bt_UserAccount_Click(object sender, EventArgs e)
        {
            using (AccountForm af = new AccountForm()) //caozuo是窗口类名，确保访问；后面的是构造函数
            {
                af.ShowDialog();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void bt_ShowData_Click(object sender, EventArgs e)
        {
                int index = this.dataGridView1.Rows.Add();
                this.dataGridView1.Rows[index].Cells[1].Value = 1;
                this.dataGridView1.Rows[index].Cells[2].Value = 2;
                this.dataGridView1.Rows[index].Cells[3].Value = 3;
        }

        private void bt_Exit_Click(object sender, EventArgs e)
        {
            using (FormLogin fl = new FormLogin()) //caozuo是窗口类名，确保访问；后面的是构造函数
            {
                this.Hide();
                fl.ShowDialog();
            }
        }
    }
}
