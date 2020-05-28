using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial02
{
    public partial class orderview : UserControl
    {
        private string user = "";
        public orderview(string username)
        {
            InitializeComponent();
            user = username;
        }
        private void update()
        {
            List<order> list = orderDAO.getList();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = list;
        }
        private void orderview_Load(object sender, EventArgs e)
        {
            update();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            update();
        }
    }
}
