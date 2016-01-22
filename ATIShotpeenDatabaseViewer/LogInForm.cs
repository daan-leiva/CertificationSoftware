﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;

namespace ATIShotpeenDatabaseViewer
{
    public partial class LogInForm : Form
    {
        private static readonly string connectionString = "DSN=unipointDB;UID=jbread;PWD=Cloudy2Day";

        public LogInForm()
        {
            InitializeComponent();
        }

        private void logInButton_Click(object sender, EventArgs e)
        {
            VerifyLogin();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void VerifyLogin()
        {
            //verify that user account exists
            if (userNameTextBox.Text.Length > 0 && passwordTextBox.Text.Length > 0)
                // query table for user
                using (OdbcConnection conn = new OdbcConnection(connectionString))
                {
                    conn.Open();

                    string query = "SELECT userId, shotpeenRead, magRead, edmRead, stressRelieveRead, role, shotpeenWrite, magWrite, edmWrite, stressRelieveWrite\n" +
                                    "FROM ATIDelivery.dbo.CertUserLogIns\n" +
                                    "WHERE userID = '" + userNameTextBox.Text.Trim().ToLower() + "' AND password = '" + passwordTextBox.Text + "'AND status = 'Active'";

                    OdbcCommand com = new OdbcCommand(query, conn);

                    OdbcDataReader reader = com.ExecuteReader();

                    if (reader.Read())
                    {
                        this.Hide();

                        Form mainForm = new MainForm(reader.GetString(0), Convert.ToBoolean(reader.GetByte(1)), Convert.ToBoolean(reader.GetByte(2)), Convert.ToBoolean(reader.GetByte(3)), Convert.ToBoolean(reader.GetByte(4)), reader.GetString(5).Equals("admin"), Convert.ToBoolean(reader.GetByte(6)), Convert.ToBoolean(reader.GetByte(7)), Convert.ToBoolean(reader.GetByte(8)), Convert.ToBoolean(reader.GetByte(9)));
                        mainForm.FormClosed += (s, args) => this.Close();
                        mainForm.Show();
                    }
                    else
                        MessageBox.Show("Invalid password and/or username\nMake user that user account is currently active.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            else
                MessageBox.Show("Username and password fields cannnot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void userNameTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                VerifyLogin();
        }

        private void passwordTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                VerifyLogin();
        }

        private void LogInDialog_Load(object sender, EventArgs e)
        {
            passwordTextBox.PasswordChar = '*';
        }
    }
}
