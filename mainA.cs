using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial02
{
    public partial class mainA : Form
    {
        private UserControl current = null;
        string username = "";
        public mainA(string username)
        {
            InitializeComponent();
            this.username = username;
        }

        public void changeUserControl(UserControl obj)
        {
            tableLayoutPanel1.Controls.Remove(current);
            current = obj;
            current.Dock = DockStyle.Fill;
            tableLayoutPanel1.Controls.Add(current, 1, 0);
            tableLayoutPanel1.SetRowSpan(current, 11);
        }

        private void usersMbtn_Click(object sender, EventArgs e)
        {
            changeUserControl(new add(username));

        }

        private void button2_Click(object sender, EventArgs e)
        {
            changeUserControl(new addBusiness(username));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            changeUserControl(new addProduct(username));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            changeUserControl(new orderview(username));
        }
    }
}
