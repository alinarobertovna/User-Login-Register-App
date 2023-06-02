using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Question2
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void new_btn_Click(object sender, EventArgs e)
        {
            User_Registration mainForm = new User_Registration();
            this.Hide();
            mainForm.ShowDialog();
            this.Close();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            string username = username_txt.Text;
            string password = psw_txt.Text;

            if (User.users.Keys.Contains(username) && User.users.Values.Contains(password))
            {
                Welcome mainForm = new Welcome();
                this.Hide();
                mainForm.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Please try again or Register!");
            }
        }
    }
}
