using System;
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
    public partial class RegisterUserForm : Form
    {
        private static readonly string connectionString = "DSN=unipointDB;UID=jbread;PWD=Cloudy2Day";

        public RegisterUserForm()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SubmitForm()
        {
            // check that textboxes aren't empty
            if (userNameTextBox.Text.Length == 0 || passwordTextBox.Text.Length == 0)
            {
                MessageBox.Show("Username and password cannot have length 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // check that username doesn't already exist
            using (OdbcConnection conn = new OdbcConnection(connectionString))
            {
                conn.Open();

                string query = "SELECT *\n" +
                                "FROM ATIDelivery.dbo.CertUserLogIns\n" +
                                "WHERE userID = '" + userNameTextBox.Text.Trim().ToLower() + "';";

                OdbcCommand com = new OdbcCommand(query, conn);
                OdbcDataReader reader = com.ExecuteReader();

                // if a row exists then username is already taken
                if (reader.Read())
                {
                    MessageBox.Show("Username already exists. Please select a different username", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // convert passwords
                PasswordHash hash = new PasswordHash(passwordTextBox.Text);
                byte[] password = hash.ToArray();


                // else submit userdata
                query = "INSERT INTO ATIDelivery.dbo.CertUserLogIns\n" +
                        "VALUES (\n" +
                        "'" + userNameTextBox.Text + "',\n" +
                        "'" + System.Text.Encoding.Default.GetString(password) + "',\n" +
                        "'Active',\n" +
                        "'operator',\n" +
                        "'" + Convert.ToByte(dataGridView1.Rows[0].Cells[0].Value) + "',\n" +
                        "'" + Convert.ToByte(dataGridView1.Rows[1].Cells[0].Value) + "',\n" +
                        "'" + Convert.ToByte(dataGridView1.Rows[2].Cells[0].Value) + "',\n" +
                        "'" + Convert.ToByte(dataGridView1.Rows[3].Cells[0].Value) + "',\n" +
                        "'" + Convert.ToByte(dataGridView1.Rows[0].Cells[1].Value) + "',\n" +
                        "'" + Convert.ToByte(dataGridView1.Rows[1].Cells[1].Value) + "',\n" +
                        "'" + Convert.ToByte(dataGridView1.Rows[2].Cells[1].Value) + "',\n" +
                        "'" + Convert.ToByte(dataGridView1.Rows[3].Cells[1].Value) + "'\n" +
                        ");";

                com = new OdbcCommand(query, conn);
                if (com.ExecuteNonQuery() == 1)
                    MessageBox.Show("User has been succesfully registered!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Cannot commit user to database. Please contact IT support for help.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.Close();
        }

        private void userNameTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SubmitForm();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            SubmitForm();
        }

        private void passwordTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SubmitForm();
        }

        private void RegisterUserForm_Load(object sender, EventArgs e)
        {
            // fix datagridview
            dataGridView1.Rows.Add(4);

            dataGridView1.Rows[0].HeaderCell.Value = "Shotpeen Permissions";
            dataGridView1.Rows[0].ReadOnly = false;
            dataGridView1.Rows[1].HeaderCell.Value = "Mag Permissions";
            dataGridView1.Rows[1].ReadOnly = false;
            dataGridView1.Rows[2].HeaderCell.Value = "EDM Permissions";
            dataGridView1.Rows[2].ReadOnly = false;
            dataGridView1.Rows[3].HeaderCell.Value = "Stress Relieve Permissions";
            dataGridView1.Rows[3].ReadOnly = false;

            // set up password field
            passwordTextBox.PasswordChar = '*';
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = !(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == null ? false : (bool)dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
        }
    }
}
