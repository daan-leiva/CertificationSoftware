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

        // TO_DO
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


                    jobNumberTextBox.Text = reader.IsDBNull(0) ? "" : reader.GetString(0);
                    partDescriptionTextBox.Text = reader.IsDBNull(1) ? "" : reader.GetString(1);
                    revisionTextBox.Text = reader.IsDBNull(2) ? "" : reader.GetString(2);
                    partDescriptionTextBox.Text = reader.IsDBNull(3) ? "" : reader.GetString(3);
                    customerTextBox.Text = reader.IsDBNull(4) ? "" : reader.GetString(4);
                    lotNumberTextBox.Text = reader.IsDBNull(5) ? "" : reader.GetString(5);
                    operationNoTextBox.Text = reader.IsDBNull(6) ? "" : reader.GetString(6);
                    dateTimePicker.Value = reader.IsDBNull(7) ? DateTime.MinValue : Convert.ToDateTime(reader.GetString(7));
                    edmProgramTextBox.Text = reader.IsDBNull(8) ? "" : reader.GetString(8);
                    quantityProcesseTextBox.Text = reader.IsDBNull(9) ? "" : reader.GetString(9);
                    performedNotesTextBox.Text = reader.IsDBNull(10) ? "" : reader.GetString(10);
                    TrySelectDropdownItem(specificationComboBox, reader.IsDBNull(11) ? "" : reader.GetString(11));
                    TrySelectDropdownItem(specificationRevComboBox, reader.IsDBNull(12) ? "" : reader.GetString(12));
                    certifiedByTextBox.Text = reader.IsDBNull(13) ? "" : reader.GetString(13);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        // TO_DO
        private void D2060RForm_Load(object sender, EventArgs e)
        {

        }

        // TO_DO
        // inserts a new row to the Production.dbo.tblJobProcessLog database
        private void SubmitNewRow()
        {
            // connect to DB
            using (OdbcConnection conn = new OdbcConnection(connectionString))
            {
                // open connection
                conn.Open();

                // specify query
                string query = "INSERT INTO ATIDelivery.dbo.EDMCerts\n" +
                                "([cert_num]\n" +
                                ",[job_num]\n" +
                                ",[part_num]\n" +
                                ",[part_rev]\n" +
                                ",[part_desc]\n" +
                                ",[customer]\n" +
                                ",[lot_num]\n" +
                                ",[op_num]\n" +
                                ",[date]\n" +
                                ",[edm_program]\n" +
                                ",[qty]\n" +
                                ",[performed]\n" +
                                ",[specification]\n" +
                                ",[specificationRev]\n" +
                                ",[certifier]\n" +
                                ",[owner])\n" +
                                "VALUES (\n" +
                                "'" + certNumberTextBox.Text + "',\n" +
                                "'" + jobNumberTextBox.Text + "',\n" +
                                "'" + partNumberTextBox.Text + "',\n" +
                                "'" + revisionTextBox.Text + "',\n" +
                                "'" + partDescriptionTextBox.Text + "',\n" +
                                "'" + customerTextBox.Text + "',\n" +
                                "'" + lotNumberTextBox.Text + "',\n" +
                                "'" + operationNoTextBox.Text + "',\n" +
                                "'" + dateTimePicker.Value.ToShortDateString() + "',\n" +
                                "'" + edmProgramTextBox.Text + "',\n" +
                                "'" + quantityProcesseTextBox.Text + "',\n" +
                                "'" + performedNotesTextBox.Text + "',\n" +
                                "'" + specificationComboBox.SelectedItem.ToString() + "',\n" +
                                "'" + specificationRevComboBox.SelectedItem.ToString() + "',\n" +
                                "'" + certifiedByTextBox.Text + "',\n" +
                                "'" + userName + "'\n" +
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
                string query = "UPDATE ATIDelivery.dbo.tblJobProcessLog\n" +
                                "SET [job_num] = '" + jobNumberTextBox.Text + "',\n" +
                                "[part_num]= '" + partNumberTextBox.Text + "',\n" +
                                "[part_rev] = '" + revisionTextBox.Text + "',\n" +
                                "[part_desc] = '" + partDescriptionTextBox.Text + "',\n" +
                                "[customer] = '" + customerTextBox.Text + "',\n" +
                                "[lot_num] = '" + lotNumberTextBox.Text + "',\n" +
                                "[op_num] = '" + operationNoTextBox.Text + ",\n" +
                                "[date] = '" + dateTimePicker.Value.ToShortDateString() + "',\n" +
                                "[edm_program] = '" + edmProgramTextBox.Text + "',\n" +
                                "[qty] = '" + quantityProcesseTextBox.Text + "',\n" +
                                "[performed] = '" + performedNotesTextBox.Text + "',\n" +
                                "[specification] = '" + specificationComboBox.SelectedItem.ToString() + "',\n" +
                                "[specificationRev] = '" + specificationRevComboBox.SelectedItem.ToString() + "',\n" +
                                "[certifier] = '" + certifiedByTextBox.Text + "',\n" +
                                "WHERE cert_num = '" + certNumberTextBox.Text + "';";

                OdbcCommand com = new OdbcCommand(query, conn);

                int rowsAffected = com.ExecuteNonQuery();

                if (rowsAffected != 1)
                    MessageBox.Show("Problem submitting to DB. Contact IT support");
                else
                    MessageBox.Show("Succesfully updated");
            }
        }

        // TO_DO
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
                string query = "SELECT MAX(cert_num) + 1\n" +
                                "FROM ATIDelivery.dbo.EDMCerts;";

                // execute query
                OdbcCommand com = new OdbcCommand(query, conn);
                OdbcDataReader reader = com.ExecuteReader();


                // check tha query ran
                if (reader.Read())
                {
                    // check for null (means it's the first record being added)
                    return reader.IsDBNull(0) ? "1000" : reader.GetString(0);
                }
                else
                {
                    MessageBox.Show("DB error. Contact IT Suppor", "DB ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return "0000";
                }
            }
        }

        // TO_DO
        private bool CheckFormatting()
        {
            int dummyTest;

            // check numeric values
            bool numberFormattingOK = int.TryParse(quantityProcesseTextBox.Text, out dummyTest);

            // check dropdowns
            bool comboBoxesFormattingOK = specificationComboBox.SelectedItem != null
                                        && specificationRevComboBox.SelectedItem != null;

            // check textboxes
            bool textBoxesFormattingOK = jobNumberTextBox.Text.Length > 0
                                        && revisionTextBox.Text.Length > 0
                                        && partNumberTextBox.Text.Length > 0
                                        && operationNoTextBox.Text.Length > 0
                                        && edmProgramTextBox.Text.Length > 0
                                        && certifiedByTextBox.Text.Length > 0;

            return numberFormattingOK && comboBoxesFormattingOK && textBoxesFormattingOK;
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
