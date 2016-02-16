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

namespace ATICertViewer
{
    public partial class D2060RForm : Form
    {
        // connection string used to set up connection to Microsoft SQL Server Database
        private static readonly string connectionString = "DSN=unipointDB;UID=jbread;PWD=Cloudy2Day";
        private bool newForm;
        private bool canEdit;
        private string userName;

        private int ID;

        public D2060RForm(bool _canEdit, string _userName)
        {
            InitializeComponent();

            newForm = true;
            canEdit = _canEdit;
            userName = _userName;

            ID = -1;
        }

        public D2060RForm(string ID_num, bool _canEdit, string _userName)
        {
            InitializeComponent();

            newForm = false;
            canEdit = _canEdit;
            ID = Convert.ToInt32(ID_num);
            userName = _userName;
        }

        // TO_DO
        private void printButton_Click(object sender, EventArgs e)
        {

        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            // check if the process number is empty
            if (ID == -1)
            {
                // check document formating
                if (!CheckFormatting())
                {
                    MessageBox.Show("Formatting error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // get new process number
                int newIDNumber = GetNextProcessNumber();

                // assign it to the document
                ID = newIDNumber;

                // submit to DB
                SubmitNewRow();
            }
            else // run update query
            {
                UpdateRow();
            }
        }

        private void UpdateForm()
        {
            using (OdbcConnection conn = new OdbcConnection(connectionString))
            {
                conn.Open();

                string query = @"SELECT [Date], [Internal Shorts], [Particle Conc 1-4 ml], [Blacklight Min 1000uw@ 15], [Avail Light Min 100FC]," +
                                "[UV Ambient Light / Ambient White Light Max 2 FC], [500 (3 holes)], [1000 (5 holes)], [1500 (6 holes)], [2500 (7 holes)], " +
                                "[3500 (9 holes)], [AS5282 QQI @ 1000 amps (5 holes)], [Bath Comparison], [Comments], [Inspector], [ASTM 1400], [ASTM 2500]," +
                                " [ASTM 3400], [owner]\n" +
                                "FROM ATIDelivery.dbo.MagD2060RProcessControlLog\n" +
                                "WHERE ID = " + ID + ";";
                try
                {
                    OdbcCommand com = new OdbcCommand(query, conn);
                    OdbcDataReader reader = com.ExecuteReader();

                    reader.Read();

                    // Fill out corresponding form values
                    dateTimePicker.Value = reader.IsDBNull(0) ? DateTime.MinValue : Convert.ToDateTime(reader.GetString(0));
                    internalShortsTextBox.Text = reader.IsDBNull(1) ? "" : reader.GetString(1);
                    particleConcTextBox.Text = reader.IsDBNull(2) ? "" : reader.GetString(2);
                    blacklightMinTextBox.Text = reader.IsDBNull(3) ? "" : reader.GetString(3);
                    availLightMinTextBox.Text = reader.IsDBNull(4) ? "" : reader.GetString(4);
                    uvAmbientLightTextBox.Text = reader.IsDBNull(5) ? "" : reader.GetString(5);
                    as500TextBox.Text = reader.IsDBNull(6) ? "" : reader.GetString(6);
                    as1000TextBox.Text = reader.IsDBNull(7) ? "" : reader.GetString(7);
                    as1500TextBox.Text = reader.IsDBNull(8) ? "" : reader.GetString(8);
                    as2500TextBox.Text = reader.IsDBNull(9) ? "" : reader.GetString(9);
                    as3500TextBox.Text = reader.IsDBNull(10) ? "" : reader.GetString(10);
                    as5282QQITextBox.Text = reader.IsDBNull(11) ? "" : reader.GetString(11);
                    bathComparisonTextBox.Text = reader.IsDBNull(12) ? "" : reader.GetString(12);
                    commentsTextBox.Text = reader.IsDBNull(13) ? "" : reader.GetString(13);
                    inspectorTextBox.Text = reader.IsDBNull(14) ? "" : reader.GetString(14);
                    astm1400TextBox.Text = reader.IsDBNull(15) ? "" : reader.GetString(15);
                    astm2500TextBox.Text = reader.IsDBNull(16) ? "" : reader.GetString(16);
                    astm3400TextBox.Text = reader.IsDBNull(17) ? "" : reader.GetString(17);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void D2060RForm_Load(object sender, EventArgs e)
        {
            if (!newForm) // update form with current data
                UpdateForm();

            // lock if the form is user can't edit
            if (!canEdit)
                LockForm();
        }

        // inserts a new row to the Production.dbo.tblJobProcessLog database
        private void SubmitNewRow()
        {
            // connect to DB
            using (OdbcConnection conn = new OdbcConnection(connectionString))
            {
                // open connection
                conn.Open();

                // specify query
                string query = "INSERT INTO ATIDelivery.dbo.MagD2060RProcessControlLog\n" +
                                "([ID]\n" +
                                ",[Date]\n" +
                                ",[Internal Shorts]\n" +
                                ",[Particle Conc 1-4 ml]\n" +
                                ",[Blacklight Min 1000uw@ 15]\n" +
                                ",[Avail Light Min 100FC]\n" +
                                ",[UV Ambient Light / Ambient White Light Max 2 FC]\n" +
                                ",[500 (3 holes)]\n" +
                                ",[1000 (5 holes)]\n" +
                                ",[1500 (6 holes)]\n" +
                                ",[2500 (7 holes)]\n" +
                                ",[3500 (9 holes)]\n" +
                                ",[AS5282 QQI @ 1000 amps (5 holes)]\n" +
                                ",[Bath Comparison]\n" +
                                ",[Comments]\n" +
                                ",[Inspector]\n" +
                                ",[ASTM 1400]\n" +
                                ",[ASTM 2500]\n" +
                                ",[ASTM 3400]\n" +
                                ",[owner])\n" +
                                "VALUES (\n" +
                                "" + ID + ",\n" +
                                "'" + dateTimePicker.Value.ToShortDateString() + "',\n" +
                                "'" + internalShortsTextBox.Text + "',\n" +
                                "'" + particleConcTextBox.Text + "',\n" +
                                "'" + blacklightMinTextBox.Text + "',\n" +
                                "'" + availLight.Text + "',\n" +
                                "'" + uvAmbientLightTextBox.Text + "',\n" +
                                "'" + as500TextBox.Text + "',\n" +
                                "'" + as1000TextBox.Text + "',\n" +
                                "'" + as1500TextBox.Text + "',\n" +
                                "'" + as2500TextBox.Text + "',\n" +
                                "'" + as3500TextBox.Text + "',\n" +
                                "'" + as5282QQITextBox.Text + "',\n" +
                                "'" + bathComparisonTextBox.Text + "',\n" +
                                "'" + commentsTextBox.Text + "',\n" +
                                "'" + astm1400TextBox.Text + "',\n" +
                                "'" + astm2500TextBox.Text + "',\n" +
                                "'" + astm3400TextBox.Text + "',\n" +
                                "'" + userName + "',\n" +
                                ");";

                OdbcCommand com = new OdbcCommand(query, conn);

                int rowsAffected = com.ExecuteNonQuery();

                if (rowsAffected != 1)
                    MessageBox.Show("Problem submitting to DB. Contact IT support");
                else
                    MessageBox.Show("Sucessfully submitted");
            }
        }

        // TO_DO
        // updates an old row in the database based on the process number
        private void UpdateRow()
        {
            // connect to DB
            using (OdbcConnection conn = new OdbcConnection(connectionString))
            {
                // open connection
                conn.Open();

                // specify query
                string query = "UPDATE ATIDelivery.dbo.MagD2060RProcessControlLog\n" +
                                "SET [Date] = '" + dateTimePicker.Value.ToShortDateString() + "'\n" +
                                ",[Internal Shorts] = '" + internalShortsTextBox.Text + "'\n" +
                                ",[Particle Conc 1-4 ml] = '" + particleConcTextBox.Text + "'\n" +
                                ",[Blacklight Min 1000uw@ 15] = '" + blacklightMinTextBox.Text + "'\n" +
                                ",[Avail Light Min 100FC] = '" + availLightMinTextBox.Text + "'\n" +
                                ",[UV Ambient Light / Ambient White Light Max 2 FC] = '" + uvAmbientLightTextBox.Text + "'\n" +
                                ",[500 (3 holes)] = '" + as500TextBox.Text + "'\n" +
                                ",[1000 (5 holes)] = '" + as1000TextBox.Text + "'\n" +
                                ",[1500 (6 holes)] = '" + as1500TextBox.Text + "'\n" +
                                ",[2500 (7 holes)] = '" + as2500TextBox.Text + "'\n" +
                                ",[3500 (9 holes)] = '" + as3500TextBox.Text + "'\n" +
                                ",[AS5282 QQI @ 1000 amps (5 holes)] = '" + as5282QQITextBox.Text + "'\n" +
                                ",[Bath Comparison] = '" + bathComparisonTextBox.Text + "'\n" +
                                ",[Comments] = '" + commentsTextBox.Text + "'\n" +
                                ",[Inspector] = '" + inspectorTextBox.Text + "'\n" +
                                ",[ASTM 1400] = '" + astm1400TextBox.Text + "'\n" +
                                ",[ASTM 2500] = '" + astm2500TextBox.Text + "'\n" +
                                ",[ASTM 3400] = '" + astm3400TextBox.Text + "'\n" +
                                ",[owner] = '" + userName + "'\n" +
                                "WHERE ID = " + ID + ";";

                OdbcCommand com = new OdbcCommand(query, conn);

                int rowsAffected = com.ExecuteNonQuery();

                if (rowsAffected != 1)
                    MessageBox.Show("Problem submitting to DB. Contact IT support");
                else
                    MessageBox.Show("Succesfully updated");
            }
        }

        private int GetNextProcessNumber()
        {
            using (OdbcConnection conn = new OdbcConnection(connectionString))
            {
                // open connection to DB
                // check if connection is available
                try
                {
                    conn.Open();
                }
                catch (OdbcException)
                {
                    MessageBox.Show("No connection to DB available");
                }

                // query to run
                string query = "SELECT MAX(ID) + 1\n" +
                                "FROM ATIDelivery.dbo.MagD2060RProcessControlLog;";

                // execute query
                OdbcCommand com = new OdbcCommand(query, conn);
                OdbcDataReader reader = com.ExecuteReader();


                // check tha query ran
                if (reader.Read())
                {
                    // check for null (means it's the first record being added)
                    return reader.IsDBNull(0) ? 999 : reader.GetInt32(0);
                }
                else
                {
                    MessageBox.Show("DB error. Contact IT Suppor", "DB ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return 999;
                }
            }
        }

        // TO_DO
        private bool CheckFormatting()
        {
            int dummyTest;

            // check numeric values
            bool numberFormattingOK = true;

            // check textboxes
            bool textBoxesFormattingOK = true;

            return numberFormattingOK && textBoxesFormattingOK;
        }

        private void LockForm()
        {
            foreach (Control control in this.Controls)
                DisableControls(control);

            // leave print button enabled
            printButton.Enabled = true;
        }

        private void DisableControls(Control con)
        {
            foreach (Control c in con.Controls)
            {
                DisableControls(c);
            }
            if (!(con is Label))
                con.Enabled = false;
        }
    }
}
