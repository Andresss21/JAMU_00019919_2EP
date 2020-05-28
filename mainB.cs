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
    public partial class mainB : Form
    {
        private UserControl current = null;
        string username = "";
        public mainB(string username)
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

        private void mainB_Load(object sender, EventArgs e)
        {

        }

        private void ordersbtn_Click(object sender, EventArgs e)
        {
            changeUserControl(new addAdress(username));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            changeUserControl(new addOrders(username));
        }
    }
}
