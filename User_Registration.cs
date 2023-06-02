using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Question2
{
    public partial class User_Registration : Form
    {
        public User_Registration()
        {
            InitializeComponent();
            User.users = new Dictionary<string, string>();
        }

        private void reg_btn_Click(object sender, EventArgs e)
        {
            string username = email_txt.Text;
            string password = psw_txt.Text;

            if (User.users.ContainsKey(username))
            {
                MessageBox.Show("This user has already been subscribed!");
            }

            User.users.Add(username, password); //adds new user to the collection

            MessageBox.Show("Successfully registered!");

            Login mainForm = new Login();
            this.Hide();
            mainForm.ShowDialog();
            this.Close();

        }

        private void phone_txt_TextChanged(object sender, EventArgs e) //validates phone number
        {
            Regex regex = new Regex(@"^^(?<code>\+?\d{1,3})[-\s]{0,}(?<number>\(?\d{3}\)?[-\s]{0,}\d{3}[-\s]{0,}\d{2}[-\s]{0,}\d{2})$");

            if (regex.IsMatch(phone_txt.Text))
            {
                phone_error.Visible = false;
                reg_btn.Enabled = true;                
            }
            else
            {
                phone_error.Visible = true;
                reg_btn.Enabled = false;               
            }           
        }

        private void email_txt_TextChanged(object sender, EventArgs e) //validates email
        {
            Regex regex = new Regex(@"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|"
                + @"([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)"
                + @"@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$");

            if (regex.IsMatch(email_txt.Text))
            {
                email_error.Visible = false;
                reg_btn.Enabled = true;               
            }
            else
            {
                email_error.Visible = true;               
                reg_btn.Enabled = false;
            }
        }
    }
}

