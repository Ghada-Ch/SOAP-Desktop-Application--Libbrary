using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library.ServiceUser;

namespace Library
{
    
    public partial class LibraryGCForm : Form
    {
        public static user userlog = null;
        DAOUserServiceClient DAOUser = new DAOUserServiceClient();
        public LibraryGCForm()
        {
            InitializeComponent();

            userlog = null;
        }

        private void LibraryGCForm_Load(object sender, EventArgs e)
        {
            
        }
        private void logBut_Click(object sender, EventArgs e)
        {
            
            if (verif())
            {
                if ((String)typelog.SelectedItem == "Admin")
                {
                    AdminForm Ad = new AdminForm();
                    Ad.Show();
                    this.Hide();
                }
                  else
                {
                    UserForm Us = new UserForm();
                    Us.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Login or passsword wrong !","Error", MessageBoxButtons.OK);
            }
        }

        private bool verif()
        {
            if ((String)typelog.SelectedItem == "Admin")
            {
                if (loginTB.Text.Equals("Admin") & passwordTB.Text.Equals("Admin"))

                    return true;
                else
                    return false;
            }
            else
            {
                try
                {
                    userlog = DAOUser.find(loginTB.Text, passwordTB.Text);
                }
                catch(Exception e)
                {
                    MessageBox.Show(e.Message);
                }
                if (userlog != null)
                {
                    return true;
                }
                   
                else
                    return false;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SignInForm Us = new SignInForm();
            Us.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            SignInForm Us = new SignInForm();
            Us.Show();
            this.Hide();
        }
    }
}
