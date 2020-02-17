using Library.ServiceBook;
using Library.ServiceUser;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    enum ModeApplicatif { MODEAJOUT, MODECONSULTATION, MODEMODIFICATION }
    enum ETATCONNECTION { connecter, deconnecter }
    public partial class AdminForm : Form
    {
        DAOBookServiceClient DAOBook=new DAOBookServiceClient() ;
        DAOUserServiceClient DAOUser = new DAOUserServiceClient();
        public book[] books ;
        public user[] users;

        ModeApplicatif _modeApplicatif;
        
        public AdminForm()
        {
            InitializeComponent();
            books = DAOBook.RecupereBooks();
            users = DAOUser.RecupereUsers();
            dataGridBooks.DataSource = books;
            dataGridUsers.DataSource = users;

            ActiverModeconsultation();
         }
        void ActiverModeconsultation()
        {

            _modeApplicatif = ModeApplicatif.MODECONSULTATION;
            textBoxTitre.Enabled = false;
            textBoxAuteur.Enabled = false;
            textBoxGenre.Enabled = false;
            textBoxPrix.Enabled = false;
            textBoxLanguage.Enabled = false;
            textBoxPublisher.Enabled = false;
            textBoxPages.Enabled = false;
            

            butAdd.Visible = true;
            butModify.Visible = true;
            butDelete.Visible = true;
            dataGridBooks.Enabled = true;
            butConfAdd.Visible = false;
            butCancel.Visible = false;

            books = DAOBook.RecupereBooks();
            dataGridBooks.DataSource = books;
           dataGridBooks.Refresh();
        }
        void ActiverModeAjout()
        {
            _modeApplicatif = ModeApplicatif.MODEAJOUT;
            textBoxTitre.Enabled = true;
            textBoxAuteur.Enabled = true;
            textBoxGenre.Enabled = true;
            textBoxPrix.Enabled = true;
            textBoxLanguage.Enabled = true;
            textBoxPublisher.Enabled = true;
            textBoxPages.Enabled = true;

            textBoxTitre.Text = "";
            textBoxAuteur.Text = "";
            textBoxGenre.Text = "";
            textBoxPrix.Text = "";
            textBoxLanguage.Text = "";
            textBoxPublisher.Text = "";
            textBoxPages.Text = "";

           
            butAdd.Visible = false;
            butModify.Visible = false;
            butDelete.Visible = false;
            dataGridBooks.Enabled = false;
            butConfAdd.Visible = true;
            butCancel.Visible = true;
            books = DAOBook.RecupereBooks();
            dataGridBooks.DataSource = books;
            dataGridBooks.Refresh();


        }

        void ActiverModeModification()
        {
            _modeApplicatif = ModeApplicatif.MODEMODIFICATION;
            textBoxTitre.Enabled = true;
            textBoxAuteur.Enabled = true;
            textBoxGenre.Enabled = true;
            textBoxPrix.Enabled = true;
            textBoxLanguage.Enabled = true;
            textBoxPublisher.Enabled = true;
            textBoxPages.Enabled = true;


            butAdd.Visible = false;
            butModify.Visible = false;
            butDelete.Visible = false;
            dataGridBooks.Enabled = false;
            butConfAdd.Visible = true;
            butCancel.Visible = true;
            books = DAOBook.RecupereBooks();
            dataGridBooks.DataSource = books;
            dataGridBooks.Refresh();

        }
        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void logOutLab_Click(object sender, EventArgs e)
        {
            LibraryGCForm Acc = new LibraryGCForm();
            Acc.Show();
            this.Close();
        }

        private void butAdd_Click(object sender, EventArgs e)
        {
            ActiverModeAjout();
        }

        private void butModify_Click(object sender, EventArgs e)
        {
            ActiverModeModification();
        }
        private bool AskConfirmSupp()
        {
            // message confirmation quitter l'application
            if (MessageBox.Show("Are you sure !,You want to delete this book?",
                               "Message de confirmation",
                               MessageBoxButtons.YesNo) == DialogResult.No)
            {
                // non
                return false;
            };

            // oui, quitter
            return true;
        }
        private void butDelete_Click(object sender, EventArgs e)
        {
            if ((AskConfirmSupp() == true))
            {
                if (dataGridBooks.CurrentRow.Cells[0].Value != null)
                {
                    String ch=DAOBook.DeleteBook(Convert.ToInt32(dataGridBooks.CurrentRow.Cells[0].Value));

                    books = DAOBook.RecupereBooks();
                    dataGridBooks.DataSource = books;
                    dataGridBooks.Refresh();
                }
                else
                    MessageBox.Show("Champs Empty");
            }
        }

        private void butCancel_Click(object sender, EventArgs e)
        {
            ActiverModeconsultation();
        }

        private void dataGridBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            textBoxTitre.Text = Convert.ToString(dataGridBooks.CurrentRow.Cells[1].Value);
            textBoxAuteur.Text = Convert.ToString(dataGridBooks.CurrentRow.Cells[2].Value);
            textBoxGenre.Text = Convert.ToString(dataGridBooks.CurrentRow.Cells[3].Value);
            textBoxPrix.Text = Convert.ToString(dataGridBooks.CurrentRow.Cells[4].Value);
            textBoxLanguage.Text = Convert.ToString(dataGridBooks.CurrentRow.Cells[5].Value);
            textBoxPublisher.Text = Convert.ToString(dataGridBooks.CurrentRow.Cells[6].Value);
            textBoxPages.Text = Convert.ToString(dataGridBooks.CurrentRow.Cells[7].Value);
        }

        private void butConfAdd_Click(object sender, EventArgs e)
        {
            
                    if (_modeApplicatif == ModeApplicatif.MODEAJOUT)
                    {
                        string ch = AddNewBook();
                        MessageBox.Show(ch);
                       
                    }

                    else if (_modeApplicatif == ModeApplicatif.MODEMODIFICATION)
            {

                        String j = ModifyBook();
                         MessageBox.Show(j);
                       
                    }
               
              
            ActiverModeconsultation();
        }

        private String ModifyBook()
        {
            book b = new book();
            b.id_book = Convert.ToInt32(dataGridBooks.CurrentRow.Cells[0].Value);
            b.titre = textBoxTitre.Text;
            b.auteur = textBoxAuteur.Text;
            b.genre = textBoxGenre.Text;
            b.prix = float.Parse(textBoxPrix.Text);
            b.language = textBoxLanguage.Text;
            b.publisher = textBoxPublisher.Text;
            b.pages = Convert.ToInt32(textBoxPages.Text);
            return DAOBook.ModifyBook(b);
        }

        private string AddNewBook()
        {
            if (textBoxTitre.Text == "" || textBoxAuteur.Text == "" || textBoxGenre.Text == "" || textBoxPrix.Text == "" || textBoxLanguage.Text == "" || textBoxPublisher.Text == "" || textBoxPages.Text == "")
            {

                return " Empty Champs! ";
                
            }
            else
            {
                book b = new book();

                b.titre = textBoxTitre.Text;
                b.auteur = textBoxAuteur.Text;
                b.genre = textBoxGenre.Text;
                b.prix = float.Parse(textBoxPrix.Text);
                b.language = textBoxLanguage.Text;
                b.publisher = textBoxPublisher.Text;
                b.pages = Convert.ToInt32(textBoxPages.Text);
                String ch=  DAOBook.AddBook(b);
                return ch;
            }
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

        private void deleteUserBut_Click(object sender, EventArgs e)
        {
            if ((AskConfirmSupp() == true))
            {
                if (dataGridBooks.CurrentRow.Cells[0].Value != null)
                {
                    String ch = DAOUser.DeleteUser(Convert.ToInt32(dataGridBooks.CurrentRow.Cells[0].Value));

                    users = DAOUser.RecupereUsers();
                    dataGridUsers.DataSource = users;
                    dataGridUsers.Refresh();
                }
                else
                    MessageBox.Show("Champs Empty");
            }
        }

        private void dataGridUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void searchTB_TextChanged(object sender, EventArgs e)
        {
            try
            {
                book[] _listBooks = new book[100];
                int cptRecherche = 0;
                int cpt = 0;
                while (cpt != books.Length)
                {


                    if (books[cpt].titre.ToString().Contains(searchTB.Text))
                    {
                        _listBooks[cptRecherche++] = books[cpt];
                        cptRecherche++;
                    }


                    cpt++;
                }
                if (searchTB.Text == "")
                {
                    dataGridBooks.DataSource = books;
                }
                else
                    dataGridBooks.DataSource = _listBooks;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
