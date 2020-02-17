using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library.ServiceBook;

namespace Library
{
    public partial class UserForm : Form
    {
        DAOBookServiceClient DAOBook = new DAOBookServiceClient();
        public book[] books;
        public UserForm()
        {
            InitializeComponent();
            books = DAOBook.RecupereBooks();
            dataGridBooks.DataSource = books;
            if(LibraryGCForm.userlog!=null)
                loginTB.Text = LibraryGCForm.userlog.login;
            else
                loginTB.Text = SignInForm.userlog.login;
        }

        private void logoutTB_Click(object sender, EventArgs e)
        {
            LibraryGCForm Acc = new LibraryGCForm();
            Acc.Show();
            this.Close();
        }

        private void logOutBut_Click(object sender, EventArgs e)
        {
            LibraryGCForm Acc = new LibraryGCForm();
            Acc.Show();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
