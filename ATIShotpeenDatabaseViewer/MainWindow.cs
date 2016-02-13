using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATICertViewer
{
    public partial class MainWindow : Form
    {
        private string userName;
        private bool shotpeenRead;
        private bool magRead;
        private bool edmRead;
        private bool stressRelieveRead;
        private bool admin;
        private bool shotpeenWrite;
        private bool magWrite;
        private bool edmWrite;
        private bool stressRelieveWrite;

        public MainWindow(string _userName, bool _shotpeenRead, bool _magRead, bool _edmRead, bool _stressRelieveRead, bool _admin, bool _shotpeenWrite, bool _magWrite, bool _edmWrite, bool _stressRelieveWrite)
        {
            InitializeComponent();

            userName = _userName;
            shotpeenRead = _shotpeenRead;
            magRead = _magRead;
            edmRead = _edmRead;
            stressRelieveRead = _stressRelieveRead;
            shotpeenWrite = _shotpeenWrite;
            magWrite = _magWrite;
            edmWrite = _edmWrite;
            stressRelieveWrite = _stressRelieveWrite;

            admin = _admin;
        }

        private void shotpeenButton_Click(object sender, EventArgs e)
        {
            if (shotpeenRead)
            {
                this.Hide();
                Form shotPeenform = new ShotpeenListViewer(admin, userName, shotpeenWrite);
                shotPeenform.FormClosed += (s, args) => this.Close();
                shotPeenform.Show();
            }
            else
            {
                MessageBox.Show("You do not have access to this module. Contact IT administrator if you think this is an error.");
            }
        }

        private void magButton_Click(object sender, EventArgs e)
        {
            if (magRead)
            {
                this.Hide();
                Form magMainWindow = new MagForms(admin, userName, magWrite);
                magMainWindow.FormClosed += (s, args) => this.Close();
                magMainWindow.Show();
            }
            else
            {
                MessageBox.Show("You do not have access to this module. Contact IT administrator if you think this is an error.");
            }
        }

        private void edmButton_Click(object sender, EventArgs e)
        {
            if (edmRead)
            {
                this.Hide();
                Form edmCert = new EDMListViewer(admin, userName, edmWrite);
                edmCert.FormClosed += (s, args) => this.Close();
                edmCert.Show();
            }
            else
            {
                MessageBox.Show("You do not have access to this module. Contact IT administrator if you think this is an error.");
            }
        }

        private void stressRelieveButton_Click(object sender, EventArgs e)
        {
            if (stressRelieveRead)
            {
                this.Hide();
                Form stressCert = new StressRelieveListViewer(admin, userName, stressRelieveWrite);
                stressCert.FormClosed += (s, args) => this.Close();
                stressCert.Show();
            }
            else
            {
                MessageBox.Show("You do not have access to this module. Contact IT administrator if you think this is an error.");
            }
        }

        private void registerUserButton_Click(object sender, EventArgs e)
        {
            Form registerForm = new RegisterUserForm();
            registerForm.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (!admin)
            {
                registerUserButton.Hide();
                editUserButton.Hide();

                this.Height = this.Height * 5 / 6;
            }
        }

        private void editUserButton_Click(object sender, EventArgs e)
        {
            Form editUserForm = new EditUserForm();
            editUserForm.ShowDialog();
        }
    }
}