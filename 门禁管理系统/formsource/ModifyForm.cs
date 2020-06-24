using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccessControlManagementSystem.formsource
{
    public partial class ModifyForm : Form
    {
        public ModifyForm()
        {
            InitializeComponent();
        }

        private void tabControl1_Click(object sender, EventArgs e)
        {
           /* TabControl tc = sender as TabControl;
            if (tc.SelectedTab == tabPage1)
            {
                String str = tc.Name;
                MessageBox.Show(str);
            }*/
        }

        private void bt_ModifyAccount_Click(object sender, EventArgs e)
        {

        }

        private void br_ModifyPassword_Click(object sender, EventArgs e)
        {

        }

    }
}

