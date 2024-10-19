using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using UserAccountNamespace;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {

        string user_name;
        string user_password;
        string full_name;
        string department;
        string name;

        public Form1()
        {
            InitializeComponent();
        }
       
        private void tb_password_TextChanged(object sender, EventArgs e)
        {
            tb_password.PasswordChar = '*'; //hide the password
        }

        private void bt_login_Click(object sender, EventArgs e)
        {
            user_name = tb_username.Text;
            user_password = tb_password.Text;

            Cashier cs = new Cashier(full_name, department, user_name, user_password);

            if (cs.validateLogin(user_name, user_password))
            {
                name = cs.getFullname();
                department = cs.getDepartment();

                MessageBox.Show("Welcome " + name + " of " + department);
                Form2 calulator = new Form2();
                calulator.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Invalid ID");
            }
        }


    }
}

