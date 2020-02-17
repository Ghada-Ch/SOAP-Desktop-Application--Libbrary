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
    public partial class SignInForm : Form
    {
        public static user userlog=null;
        DAOUserServiceClient DAOUser = new DAOUserServiceClient();

        public SignInForm()
        {
            InitializeComponent();

        }

        private void ButSign_Click(object sender, EventArgs e)
        {
            userlog = new user();
            userlog.login = loginTB.Text;
            userlog.password = passwordTB.Text;
           String ch= DAOUser.AddUser(userlog);
            if(ch== "ADD WITH SUCCESS")
            {
                MessageBox.Show("Welcome in our Library ,You will found Top Books here.", "Welcome", MessageBoxButtons.OK);
                UserForm userform = new UserForm();
                userform.Show();
                this.Close();

            }
            
        }
    }
}
