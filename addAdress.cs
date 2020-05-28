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
    public partial class addAdress : UserControl
    {
        private string user = "";
        int p = 0;
        int id = 0;
        public addAdress(String username)
        {
            InitializeComponent();
            user = username;
        }
        private void update()
        {
            List<address> list = addressDAO.getList();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = list;
        }

        private void loadcombobox()
        {
            usercmbx.DataSource = null;
            usercmbx.ValueMember = "idUser";
            usercmbx.DisplayMember = "idUser";
            usercmbx.DataSource = appusersDAO.getList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addressDAO.addnew(Convert.ToInt32(usercmbx.Text), addresstxt.Text);
            MessageBox.Show("address succesfully added!",
                "hugo", MessageBoxButtons.OK, MessageBoxIcon.Information);


            addresstxt.Clear();
            update();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("are you sure you want to delete the address: " + addresstxt.Text + "?",
               "hugo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                addressDAO.delete(id);

                MessageBox.Show("address succesfully deleted",
                    "hugo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                addresstxt.Clear();
                update();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            p = dataGridView1.CurrentRow.Index;
            id = Convert.ToInt32(dataGridView1[0, p].Value.ToString());
            usercmbx.Text = dataGridView1[1, p].Value.ToString();
            addresstxt.Text = dataGridView1[2, p].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            update();
        }

        private void addAdress_Load(object sender, EventArgs e)
        {
            update();
            loadcombobox();
        }
    }
}
