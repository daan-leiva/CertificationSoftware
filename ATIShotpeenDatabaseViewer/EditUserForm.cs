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
using System.Security.Cryptography;

namespace ATICertViewer
{
    public partial class EditUserForm : Form
    {
        private static readonly string connectionString = "DSN=unipointDB;UID=jbread;PWD=Cloudy2Day";

        public EditUserForm()
        {
            InitializeComponent();
        }

        private void EditUserForm_Load(object sender, EventArgs e)
        {
            // loads names into combobox

            using (OdbcConnection conn = new OdbcConnection(connectionString))
            {
                conn.Open();

                string query = "SELECT userID\n" +
                                "FROM ATIDelivery.dbo.CertUserLogIns\n" +
                                "WHERE role <> 'admin'";

                OdbcCommand com = new OdbcCommand(query, conn);
                OdbcDataReader reader = com.ExecuteReader();

                while (reader.Read())
                    userNameComboBox.Items.Add(reader.GetString(0));
            }

            // set up form environment
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

            // disable resizing
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            // check that a user has been selected
            if (string.IsNullOrEmpty(userNameComboBox.Text))
            {
                MessageBox.Show("A user name has to be selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // check that item is selected and new password entered
            bool passwordUpdate = !string.IsNullOrEmpty(passwordTextBox.Text);

            PasswordHash hash;
            byte[] password = null;
            if (passwordUpdate)
            {
                // convert passwords
                hash = new PasswordHash(passwordTextBox.Text);
                password = hash.ToArray();
            }

            using (OdbcConnection conn = new OdbcConnection(connectionString))
            {
                conn.Open();

                // update query
                string query = "UPDATE ATIDelivery.dbo.CertUserLogIns\n" +
                    "SET\n" +
                    (passwordUpdate ? "password = '" + @System.Text.Encoding.Default.GetString(password).ToString() + "',\n" : string.Empty) +
                    "shotpeenRead = " + Convert.ToByte(dataGridView1.Rows[0].Cells[0].Value) + ",\n" +
                    "magRead = " + Convert.ToByte(dataGridView1.Rows[1].Cells[0].Value) + ",\n" +
                    "edmRead = " + Convert.ToByte(dataGridView1.Rows[2].Cells[0].Value) + ",\n" +
                    "stressRelieveRead = " + Convert.ToByte(dataGridView1.Rows[3].Cells[0].Value) + ",\n" +
                    "shotpeenWrite = " + Convert.ToByte(dataGridView1.Rows[0].Cells[1].Value) + ",\n" +
                    "magWrite = " + Convert.ToByte(dataGridView1.Rows[1].Cells[1].Value) + ",\n" +
                    "edmWrite = " + Convert.ToByte(dataGridView1.Rows[2].Cells[1].Value) + ",\n" +
                    "stressRelieveWrite = " + Convert.ToByte(dataGridView1.Rows[3].Cells[1].Value) + "\n" +
                    "WHERE userID = '" + userNameComboBox.SelectedItem.ToString() + "';";

                OdbcCommand com = new OdbcCommand(query, conn);

                if (com.ExecuteNonQuery() != 1)
                    MessageBox.Show("There has been a problem with the update of user information. Please contact your IT administrator");
                else
                {
                    MessageBox.Show("User data has been updated succesfully");
                    this.Close();
                }
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void userNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // load this users data into the information grid
            using (OdbcConnection conn = new OdbcConnection(connectionString))
            {
                conn.Open();

                string query = "SELECT shotpeenRead, magRead, edmRead, stressRelieveRead, shotpeenWrite, magWrite, edmWrite, stressRelieveWrite\n" +
                                "FROM ATIDelivery.dbo.certUserLogIns\n" +
                                "WHERE userID = '" + userNameComboBox.SelectedItem.ToString() + "';\n";

                OdbcCommand com = new OdbcCommand(query, conn);
                OdbcDataReader reader = com.ExecuteReader();

                if (reader.Read())
                {
                    dataGridView1.Rows[0].Cells[0].Value = reader.GetFieldType(0) == typeof(bool) ? reader.GetBoolean(0) : Convert.ToBoolean(reader.GetByte(0));
                    dataGridView1.Rows[1].Cells[0].Value = reader.GetFieldType(1) == typeof(bool) ? reader.GetBoolean(1) : Convert.ToBoolean(reader.GetByte(1));
                    dataGridView1.Rows[2].Cells[0].Value = reader.GetFieldType(2) == typeof(bool) ? reader.GetBoolean(2) : Convert.ToBoolean(reader.GetByte(2));
                    dataGridView1.Rows[3].Cells[0].Value = reader.GetFieldType(3) == typeof(bool) ? reader.GetBoolean(3) : Convert.ToBoolean(reader.GetByte(3));
                    dataGridView1.Rows[0].Cells[1].Value = reader.GetFieldType(4) == typeof(bool) ? reader.GetBoolean(4) : Convert.ToBoolean(reader.GetByte(4));
                    dataGridView1.Rows[1].Cells[1].Value = reader.GetFieldType(5) == typeof(bool) ? reader.GetBoolean(5) : Convert.ToBoolean(reader.GetByte(5));
                    dataGridView1.Rows[2].Cells[1].Value = reader.GetFieldType(6) == typeof(bool) ? reader.GetBoolean(6) : Convert.ToBoolean(reader.GetByte(6));
                    dataGridView1.Rows[3].Cells[1].Value = reader.GetFieldType(7) == typeof(bool) ? reader.GetBoolean(7) : Convert.ToBoolean(reader.GetByte(7));
                }
                else
                    MessageBox.Show("Could not connect to DB. Please contact your IT administration", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = !(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == null ? false : (bool)dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
        }
    }
}
