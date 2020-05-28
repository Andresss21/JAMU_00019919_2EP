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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }
        public static string username = "";
        private void usercmbx_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            if (usercmbx.SelectedValue.Equals(passwordtxt.Text))
            {
                appusers u = (appusers)usercmbx.SelectedItem;
                if (u.usertype.Equals(true))
                {
                    MessageBox.Show("welcome!", "administrator", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    mainA ventana = new mainA(username);
                    ventana.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("welcome!", "user", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    username = u.username;
                    mainB ventana = new mainB(username);
                    ventana.Show();
                    this.Hide();

                }

            }
            else
                MessageBox.Show("wrong password", "HugoApp", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); 
          

        }

        

        private void loadcombobox()
        {
            usercmbx.DataSource = null;
            usercmbx.ValueMember = "password";
            usercmbx.DisplayMember = "username";
            usercmbx.DataSource = appusersDAO.getList();
        }

        private void login_Load_1(object sender, EventArgs e)
        {
            loadcombobox();
        }
    }
}
