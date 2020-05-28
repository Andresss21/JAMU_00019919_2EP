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
    public partial class addProduct : UserControl
    {
        private string user = "";
        int p = 0;
        int id = 0;
        public addProduct(string username)
        {
            InitializeComponent();
            user = username;
        }

        private void update()
        {
            List<product> list = productDAO.getList();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = list;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            productDAO.addnew(Convert.ToInt32(businesscmbx.Text), descriptiontxt.Text);
            MessageBox.Show("Product succesfully added",
                "hugo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            
            descriptiontxt.Clear();
            update();
        }

        

       

        private void loadcombobox()
        {
            businesscmbx.DataSource = null;
            businesscmbx.ValueMember = "idbusiness";
            businesscmbx.DisplayMember = "idbusiness";
            businesscmbx.DataSource = businessDAO.getList();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            update();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            p = dataGridView1.CurrentRow.Index;
            id = Convert.ToInt32(dataGridView1[0, p].Value.ToString());
            businesscmbx.Text = dataGridView1[1, p].Value.ToString();
            descriptiontxt.Text = dataGridView1[2, p].Value.ToString();

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("are you sure you want to delete the product: " + businesscmbx.Text + "?",
               "hugo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                productDAO.delete(id);

                MessageBox.Show("product succesfully added",
                    "hugo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                descriptiontxt.Clear();
                update();
            }
        }

        private void addProduct_Load(object sender, EventArgs e)
        {
            update();
            loadcombobox();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
