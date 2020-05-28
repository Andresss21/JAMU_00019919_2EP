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
    public partial class add : UserControl
    {
        private string user = "";
        int p = 0;
        int id = 0;
        public add(string username)
        {
            InitializeComponent();
            user = username;
        }

        private void update()
        {
            List<appusers> list = appusersDAO.getList();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = list;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                if (adminchbx.Checked)
                {
                    appusersDAO.addnew(nametxt.Text,usertxt.Text,usertxt.Text,"true");
                    MessageBox.Show("¡user succesfully added! ",
                        "hugo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {

                    appusersDAO.addnew(nametxt.Text, usertxt.Text, usertxt.Text, "false");
                    MessageBox.Show("¡user succesfully added!",
                        "hugo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                nametxt.Clear();
                usertxt.Clear();
                update();

            }
            catch (Exception)
            {
                MessageBox.Show("Error with adding username.",
                    "hugo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            p = dataGridView1.CurrentRow.Index;
            id = Convert.ToInt32(dataGridView1[0, p].Value.ToString());
            nametxt.Text = dataGridView1[1, p].Value.ToString();
            usertxt.Text = dataGridView1[2, p].Value.ToString();
            
            if (dataGridView1[4, p].Value.ToString().Equals("true"))
            {
                adminchbx.Checked = true;
            }
            else
            {
                adminchbx.Checked = false;
            }

        }

       

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("are you sure you want to delete the user:" + usertxt.Text + "?",
                "hugo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                appusersDAO.delete(id);

                MessageBox.Show("user succesfully deleted",
                    "hugo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                usertxt.Clear();
                nametxt.Clear();
                update();
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            update();
        }

        private void add_Load(object sender, EventArgs e)
        {

        }
    }
}
