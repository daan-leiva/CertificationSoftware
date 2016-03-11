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
    public partial class EDMCert : Form
    {
        // connection string used to set up connection to Microsoft SQL Server Database
        private static readonly string connectionString = "DSN=unipointDB;UID=jbread;PWD=Cloudy2Day";
        private bool newForm;
        private bool canEdit;
        private string userName;

        public EDMCert(bool _canEdit, string _userName)
        {
            InitializeComponent();

            newForm = true;
            canEdit = _canEdit;
            userName = _userName;
        }

        public EDMCert(string process_num, bool _canEdit, string _userName)
        {
            InitializeComponent();

            newForm = false;
            canEdit = _canEdit;
            certNumberTextBox.Text = process_num;
            userName = _userName;
        }

        private void printCertButton_Click(object sender, EventArgs e)
        {

        }

        private void autoFillButton_Click(object sender, EventArgs e)
        {
            // set up connection to DB
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

                // Explain query TO_DO
                string query = "SELECT Part_Number, Rev, Description, cT.Name\n" +
                                "FROM Production.dbo.Job As jT\n" +
                                "LEFT JOIN PRODUCTION.dbo.Customer as cT\n" +
                                "ON jT.Customer = cT.Customer\n" +
                                "WHERE Job = '" + jobNumberTextBox.Text + "';";

                // execute query and get results
                OdbcCommand com = new OdbcCommand(query, conn);
                OdbcDataReader reader = com.ExecuteReader();

                // read in single row of data
                if (reader.Read())
                {
                    partNumberTextBox.Text = reader.GetString(0);
                    revisionTextBox.Text = reader.GetString(1);
                    partDescriptionTextBox.Text = reader.GetString(2);
                    customerTextBox.Text = reader.GetString(3);
                }
                else // if false no rows were returned. Job number was probably typed incorrectly
                    MessageBox.Show("Job doesn't exist");
            }
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            // check if the process number is empty
            if (certNumberTextBox.Text.Length == 0)
            {
                // check document formating
                if (!CheckFormatting())
                {
                    MessageBox.Show("Formatting error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // get new process number
                string newProcessNumber = GetNextProcessNumber().ToString();

                // assign it to the document
                certNumberTextBox.Text = newProcessNumber;

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

                string query = "SELECT job_num ,part_num ,part_rev ,part_desc ,customer ,lot_num ,op_num ,date ,edm_program ,qty ,performed ,specification ,specificationRev ,certifier\n" +
                                "FROM ATIDelivery.dbo.EDMCerts\n" +
                                "WHERE cert_num = " + certNumberTextBox.Text + ";";
                try
                {
                    OdbcCommand com = new OdbcCommand(query, conn);
                    OdbcDataReader reader = com.ExecuteReader();

                    reader.Read();

                    // Fill out corresponding form values
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

        private void TrySelectDropdownItem(ComboBox cBox, string item)
        {
            if (cBox.Items.Contains(item))
                cBox.SelectedItem = item;
            else
            {
                cBox.Items.Add(item);
                cBox.SelectedItem = item;
            }
        }

        private void FillInDropDowns()
        {
            string query = string.Empty;
            List<string> controlContent;

            // populate specification dropdown
            query = "SELECT specification\n" +
                    "FROM ATIDelivery.dbo.EDMSpecifications;";
            controlContent = GetValuesFromDB(query, specificationComboBox);
            PopulateControl(controlContent, specificationComboBox);

            // populate rev specification dropdown
            query = "SELECT REV\n" +
                    "FROM ATIDelivery.dbo.Rev;";
            controlContent = GetValuesFromDB(query, specificationRevComboBox);
            PopulateControl(controlContent, specificationRevComboBox);
        }

        private List<string> GetValuesFromDB(string query, ListControl control)
        {
            List<string> values = new List<string>();

            if (control is ComboBox)
                values.Add("");

            using (OdbcConnection conn = new OdbcConnection(connectionString))
            {
                conn.Open();

                OdbcCommand comm = new OdbcCommand(query, conn);

                OdbcDataReader reader = comm.ExecuteReader();

                while (reader.Read())
                {
                    switch (Type.GetTypeCode(reader.GetFieldType(0)))
                    {
                        case TypeCode.Decimal:
                            values.Add(reader.GetDecimal(0).ToString());
                            break;
                        case TypeCode.Double:
                            values.Add(reader.GetDouble(0).ToString());
                            break;
                        case TypeCode.String:
                            values.Add(reader.GetString(0).ToString());
                            break;
                        case TypeCode.Int32:
                            values.Add(reader.GetInt32(0).ToString());
                            break;
                    }
                }
            }

            return values;
        }

        // this adds the string of values to a single dropdown
        private void PopulateControl(List<string> values, ListControl target)
        {
            if (target is ListBox)
            {
                ListBox control = (ListBox)target;
                foreach (string value in values)
                    control.Items.Add(value);
            }
            else
            {
                ComboBox control = (ComboBox)target;
                foreach (string value in values)
                    control.Items.Add(value);
            }
        }

        private void EDMCert_Load(object sender, EventArgs e)
        {
            FillInDropDowns();

            if (!newForm) // update form with current data
                UpdateForm();

            // lock if the form is user can't edit
            if (!canEdit)
                LockForm();

            // load format checks
            // check ints
            quantityProcesseTextBox.TextChanged += FormatCheckInteger;
            // check empty
            jobNumberTextBox.TextChanged += FormatCheckEmptyTextBox;
            partNumberTextBox.TextChanged += FormatCheckEmptyTextBox;
            revisionTextBox.TextChanged += FormatCheckEmptyTextBox;
            customerTextBox.TextChanged += FormatCheckEmptyTextBox;
            operationNoTextBox.TextChanged += FormatCheckEmptyTextBox;
            edmProgramTextBox.TextChanged += FormatCheckEmptyTextBox;
            certifiedByTextBox.TextChanged += FormatCheckEmptyTextBox;
            // check drop downs
            specificationComboBox.TextChanged += FormatCheckInvalidComboBox;
            specificationRevComboBox.TextChanged += FormatCheckInvalidComboBox;

            // disable resizing
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
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

        // updates an old row in the database based on the process number
        private void UpdateRow()
        {
            // connect to DB
            using (OdbcConnection conn = new OdbcConnection(connectionString))
            {
                // open connection
                conn.Open();

                // specify query
                string query = "UPDATE ATIDelivery.dbo.EDMCerts\n" +
                                "SET [job_num] = '" + jobNumberTextBox.Text + "',\n" +
                                "[part_num]= '" + partNumberTextBox.Text + "',\n" +
                                "[part_rev] = '" + revisionTextBox.Text + "',\n" +
                                "[part_desc] = '" + partDescriptionTextBox.Text + "',\n" +
                                "[customer] = '" + customerTextBox.Text + "',\n" +
                                "[lot_num] = '" + lotNumberTextBox.Text + "',\n" +
                                "[op_num] = '" + operationNoTextBox.Text + "',\n" +
                                "[date] = '" + dateTimePicker.Value.ToShortDateString() + "',\n" +
                                "[edm_program] = '" + edmProgramTextBox.Text + "',\n" +
                                "[qty] = '" + quantityProcesseTextBox.Text + "',\n" +
                                "[performed] = '" + performedNotesTextBox.Text + "',\n" +
                                "[specification] = '" + specificationComboBox.SelectedItem.ToString() + "',\n" +
                                "[specificationRev] = '" + specificationRevComboBox.SelectedItem.ToString() + "',\n" +
                                "[certifier] = '" + certifiedByTextBox.Text + "'\n" +
                                "WHERE cert_num = '" + certNumberTextBox.Text + "';";

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
                string query = "SELECT MAX(cert_num) + 1\n" +
                                "FROM ATIDelivery.dbo.EDMCerts;";

                // execute query
                OdbcCommand com = new OdbcCommand(query, conn);
                OdbcDataReader reader = com.ExecuteReader();


                // check tha query ran
                if (reader.Read())
                {
                    // check for null (means it's the first record being added)
                    return reader.IsDBNull(0) ? 1000 : reader.GetInt32(0);
                }
                else
                {
                    MessageBox.Show("DB error. Contact IT Suppor", "DB ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return -999;
                }
            }
        }

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
                                        && certifiedByTextBox.Text.Length > 0
                                        && customerTextBox.Text.Length > 0
                                        ;

            // numeric
            if (!int.TryParse(quantityProcesseTextBox.Text, out dummyTest))
                errorProvider1.SetError(quantityProcesseTextBox, "Needs to be a numeric quantity");
            if (specificationComboBox.SelectedItem == null)
                errorProvider1.SetError(specificationComboBox, "Need to select an item");
            // drop down
            if (specificationRevComboBox.SelectedItem == null)
                errorProvider1.SetError(specificationRevComboBox, "Need to select an item");
            // text boxes
            if (jobNumberTextBox.Text.Length < 1)
                errorProvider1.SetError(jobNumberTextBox, "Cannot leave empty");
            if (revisionTextBox.Text.Length < 1)
                errorProvider1.SetError(revisionTextBox, "Cannot leave empty");
            if (partNumberTextBox.Text.Length < 1)
                errorProvider1.SetError(partNumberTextBox, "Cannot leave empty");
            if (operationNoTextBox.Text.Length < 1)
                errorProvider1.SetError(operationNoTextBox, "Cannot leave empty");
            if (edmProgramTextBox.Text.Length < 1)
                errorProvider1.SetError(edmProgramTextBox, "Cannot leave empty");
            if (certifiedByTextBox.Text.Length < 1)
                errorProvider1.SetError(certifiedByTextBox, "Cannot leave empty");
            if (customerTextBox.Text.Length < 1)
                errorProvider1.SetError(customerTextBox, "Cannot leave empty");

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

        private void FormatCheckInteger(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            int dummyOut;
            if (!int.TryParse(textBox.Text, out dummyOut))
                errorProvider1.SetError(textBox, "Needs to be a numeric quantity");
            else
                errorProvider1.SetError(textBox, "");
        }

        private void FormatCheckEmptyTextBox(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            if (!(textBox.Text.Length > 0))
                errorProvider1.SetError(textBox, "Cannot leave field empty");
            else
                errorProvider1.SetError(textBox, "");
        }

        private void FormatCheckInvalidComboBox(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;

            if (comboBox.SelectedItem == null)
                errorProvider1.SetError(comboBox, "Need to select an item");
            else
                errorProvider1.SetError(comboBox, "");
        }

        private void FormatCheckDouble(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            double dummyOut;
            if (!double.TryParse(textBox.Text, out dummyOut))
                errorProvider1.SetError(textBox, "Needs to be a numeric quantity");
            else
                errorProvider1.SetError(textBox, "");
        }
    }
}
