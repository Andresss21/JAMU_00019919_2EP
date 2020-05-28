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
    public partial class addOrders : UserControl
    {
        private string user = "";
        int p = 0;
        int id = 0;
        public addOrders(String username)
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

        private void loadcombobox1()
        {
            productcmbx.DataSource = null;
            productcmbx.ValueMember = "idProduct";
            productcmbx.DisplayMember = "idProduct";
            productcmbx.DataSource = productDAO.getList();
        }
        private void loadcombobox2()
        {
            addresscmbx.DataSource = null;
            addresscmbx.ValueMember = "idAddress";
            addresscmbx.DisplayMember = "idAddress";
            addresscmbx.DataSource = addressDAO.getList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            orderDAO.addnew(Convert.ToInt32(productcmbx.Text), Convert.ToInt32(addresscmbx.Text));
            MessageBox.Show("order succesfully added!",
                "hugo", MessageBoxButtons.OK, MessageBoxIcon.Information);


            
            update();
        }

        private void addOrders_Load(object sender, EventArgs e)
        {
            loadcombobox1();
            loadcombobox2();
            update();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            p = dataGridView1.CurrentRow.Index;
            id = Convert.ToInt32(dataGridView1[0, p].Value.ToString());
            productcmbx.Text = dataGridView1[2, p].Value.ToString();
            addresscmbx.Text = dataGridView1[3, p].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("are you sure you want to delete this order?",
               "hugo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                orderDAO.delete(id);

                MessageBox.Show("order succesfully deleted",
                    "hugo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                update();
            }
        }
    }
}
