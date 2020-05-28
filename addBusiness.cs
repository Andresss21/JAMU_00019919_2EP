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
    public partial class addBusiness : UserControl
    {
        private string user = "";
        int p = 0;
        int id = 0;
        public addBusiness(string username)
        {
            InitializeComponent();
            user = username;
        }

        private void update()
        {
            List<business> list = businessDAO.getList();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = list;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            businessDAO.addnew(nametxt.Text, descriptiontxt.Text);
            MessageBox.Show("business succesfully added!",
                "hugo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            nametxt.Clear();
            descriptiontxt.Clear();
   
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("are you sure you want to delete the business" + nametxt.Text + "?",
                "hugo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                businessDAO.delete(id);

                MessageBox.Show("business succesfully deleted!",
                    "hugo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                nametxt.Clear();
                descriptiontxt.Clear();
                update();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            p = dataGridView1.CurrentRow.Index;
            id = Convert.ToInt32(dataGridView1[0, p].Value.ToString());
            nametxt.Text = dataGridView1[0, p].Value.ToString();
            descriptiontxt.Text = dataGridView1[1, p].Value.ToString();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            update();
        }

        private void addBusiness_Load(object sender, EventArgs e)
        {
            update();
        }
    }
}
