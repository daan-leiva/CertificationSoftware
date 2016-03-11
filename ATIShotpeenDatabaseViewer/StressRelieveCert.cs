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
    public partial class StressRelieveCert : Form
    {
        // connection string used to set up connection to Microsoft SQL Server Database
        private static readonly string connectionString = "DSN=unipointDB;UID=jbread;PWD=Cloudy2Day";
        private bool newForm;
        private bool canEdit;
        private string userName;

        public StressRelieveCert(bool _canEdit, string _userName)
        {
            InitializeComponent();

            newForm = true;
            canEdit = _canEdit;
            userName = _userName;
        }

        public StressRelieveCert(string process_num, bool _canEdit, string _userName)
        {
            InitializeComponent();

            newForm = false;
            canEdit = _canEdit;
            certNumberTextBox.Text = process_num;
            userName = _userName;
        }

        private void StressRelieveCert_Load(object sender, EventArgs e)
        {
            FillInDropDowns();

            if (!newForm) // update form with current data
                UpdateForm();

            // lock if the form is user can't edit
            if (!canEdit)
                LockForm();

            // load events
            // check numeric
            quantityTextBox.TextChanged += FormatCheckInteger;
            hoursRequiredTimeTextBox.TextChanged += FormatCheckInteger;
            minutesRequiredTimeTextBox.TextChanged += FormatCheckInteger;
            requiredTemperatureTextBox.TextChanged += FormatCheckInteger;
            plusMinTemperatureTextBox.TextChanged += FormatCheckInteger;
            // check dropdowns
            specificationComboBox.SelectedIndexChanged += FormatCheckInvalidComboBox;
            specRevComboBox.SelectedIndexChanged += FormatCheckInvalidComboBox;
            ovenSNComboBox.SelectedIndexChanged += FormatCheckInvalidComboBox;
            certifiedByComboBox.SelectedIndexChanged += FormatCheckInvalidComboBox;
            // check textboxes
            jobNumberTextBox.TextChanged += FormatCheckEmptyTextBox;
            partNumberTextBox.TextChanged += FormatCheckEmptyTextBox;
            revisionTextBox.TextChanged += FormatCheckEmptyTextBox;
            customerTextBox.TextChanged += FormatCheckEmptyTextBox;
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
            // check document formating
            if (!CheckFormatting())
            {
                MessageBox.Show("Formatting error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // check if the process number is empty
            if (certNumberTextBox.Text.Length == 0)
            {
                // get new process number
                string newProcessNumber = GetNextProcessNumber();

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

        // TO_DO
        private void printCertButton_Click(object sender, EventArgs e)
        {

        }

        private void UpdateForm()
        {
            using (OdbcConnection conn = new OdbcConnection(connectionString))
            {
                conn.Open();

                string query = "SELECT [Customer], [Part_Number], [Revision], [Job_Number], [Lot_Number], [Operation_Number], [Process_Per], [Process_Rev], [Time_Hours], [Time_Minutes], [Time], [Temp], [Temp_Degree], [Temp_Dev], [Lot_Quantity], [Serial_Numbers], [Certified_By], [Cert_Date], [Oven_SN], part_desc\n" +
                                "FROM ATIDelivery.dbo.StressRelieveCertificationLog\n" +
                                "WHERE CertNumber = " + certNumberTextBox.Text + ";";
                try
                {
                    OdbcCommand com = new OdbcCommand(query, conn);
                    OdbcDataReader reader = com.ExecuteReader();

                    reader.Read();

                    // Fill out corresponding form values
                    customerTextBox.Text = reader.IsDBNull(0) ? "" : reader.GetString(0);
                    partNumberTextBox.Text = reader.IsDBNull(1) ? "" : reader.GetString(1);
                    revisionTextBox.Text = reader.IsDBNull(2) ? "" : reader.GetString(2);
                    jobNumberTextBox.Text = reader.IsDBNull(3) ? "" : reader.GetString(3);
                    lotNumberTextBox.Text = reader.IsDBNull(4) ? "" : reader.GetString(4);
                    opNumberTextBox.Text = reader.IsDBNull(5) ? "" : reader.GetString(5);
                    TrySelectDropDown(specificationComboBox, reader.IsDBNull(6) ? "" : reader.GetString(6));
                    TrySelectDropDown(specRevComboBox, reader.IsDBNull(7) ? "" : reader.GetString(7));
                    // time check
                    if (reader.IsDBNull(10))
                    {
                        hoursRequiredTimeTextBox.Text = reader.IsDBNull(8) ? "0" : reader.GetString(8);
                        minutesRequiredTimeTextBox.Text = reader.IsDBNull(9) ? "0" : reader.GetString(9);
                    }
                    else
                    {
                        hoursRequiredTimeTextBox.Text = reader.IsDBNull(10) ? "0" : reader.GetString(10);
                    }
                    // temp check
                    if (reader.IsDBNull(11))
                    {
                        requiredTemperatureTextBox.Text = reader.IsDBNull(12) ? "" : reader.GetString(12);
                        plusMinTemperatureTextBox.Text = reader.IsDBNull(13) ? "0" : reader.GetString(13);
                    }
                    else
                    {
                        requiredTemperatureTextBox.Text = reader.IsDBNull(11) ? "" : reader.GetString(11);
                    }
                    quantityTextBox.Text = reader.IsDBNull(14) ? "" : reader.GetString(14);
                    serialNumbersTextBox.Text = reader.IsDBNull(15) ? "" : reader.GetString(15);
                    TrySelectDropDown(certifiedByComboBox, reader.IsDBNull(16) ? "" : reader.GetString(16));
                    dateTimePicker.Value = dateTimePicker.Value = reader.IsDBNull(17) ? dateTimePicker.MinDate : (reader.GetString(17).Length > 0 ? Convert.ToDateTime(reader.GetString(17)) : dateTimePicker.MinDate);
                    partDescriptionTextBox.Text = reader.IsDBNull(18) ? "" : reader.GetString(18);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void TrySelectDropDown(ComboBox cBox, string item)
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
            query = "SELECT [spec_rev]\n" +
                    "FROM [ATIDelivery].[dbo].[StressRelieveSpecification];";
            controlContent = GetValuesFromDB(query, specificationComboBox);
            PopulateControl(controlContent, specificationComboBox);

            // populate rev dropdown
            // populate rev specification dropdown
            query = "SELECT REV\n" +
                    "FROM ATIDelivery.dbo.Rev;";
            controlContent = GetValuesFromDB(query, specRevComboBox);
            PopulateControl(controlContent, specRevComboBox);

            // popualte over dropdown
            query = "SELECT [Oven_SN]\n" +
                    "FROM [ATIDelivery].[dbo].[StressRelievetblOven];";
            controlContent = GetValuesFromDB(query, ovenSNComboBox);
            PopulateControl(controlContent, ovenSNComboBox);
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

        // inserts a new row to the Production.dbo.tblJobProcessLog database
        private void SubmitNewRow()
        {
            // connect to DB
            using (OdbcConnection conn = new OdbcConnection(connectionString))
            {
                // open connection
                conn.Open();

                // specify query
                string query = "INSERT INTO ATIDelivery.[dbo].[StressRelieveCertificationLog]\n" +
                                "([CertNumber]\n" +
                                ",[Customer]\n" +
                                ",[Part_Number]\n" +
                                ",[part_desc]\n" +
                                ",[Revision]\n" +
                                ",[Job_Number]\n" +
                                ",[Lot_Number]\n" +
                                ",[Operation_Number]\n" +
                                ",[Process_Per]\n" +
                                ",[Process_Rev]\n" +
                                ",[Time_Hours]\n" +
                                ",[Time_Minutes]\n" +
                                ",[Temp_Degree]\n" +
                                ",[Temp_Dev]\n" +
                                ",[Lot_Quantity]\n" +
                                ",[Serial_Numbers]\n" +
                                ",[Certified_By]\n" +
                                ",[Cert_Date]\n" +
                                ",[Oven_SN]\n" +
                                ",[owner])\n" +
                                "VALUES (\n" +
                                "'" + certNumberTextBox.Text + "',\n" +
                                "'" + customerTextBox.Text + "',\n" +
                                "'" + partNumberTextBox.Text + "',\n" +
                                "'" + partDescriptionTextBox.Text + "',\n" +
                                "'" + revisionTextBox.Text + "',\n" +
                                "'" + jobNumberTextBox.Text + "',\n" +
                                "'" + lotNumberTextBox.Text + "',\n" +
                                "'" + opNumberTextBox.Text + "',\n" +
                                "'" + specificationComboBox.SelectedItem.ToString() + "',\n" +
                                "'" + specRevComboBox.SelectedItem.ToString() + "',\n" +
                                "'" + hoursRequiredTimeTextBox.Text + "',\n" +
                                "'" + minutesRequiredTimeTextBox.Text + "',\n" +
                                "'" + requiredTemperatureTextBox.Text + "',\n" +
                                "'" + plusMinTemperatureTextBox.Text + "',\n" +
                                "'" + quantityTextBox.Text + "',\n" +
                                "'" + serialNumbersTextBox.Text + "',\n" +
                                "'" + certifiedByComboBox.SelectedItem.ToString() + "',\n" +
                                "'" + dateTimePicker.Value.ToShortDateString() + "',\n" +
                                "'" + ovenSNComboBox.SelectedItem.ToString() + "',\n" +
                                "'" + userName + "'" +
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
                string query = "ATIDelivery.[dbo].[StressRelieveCertificationLog]\n" +
                                "SET [Customer] = '" + customerTextBox.Text + "'\n" +
                                ",[Part_Number] = '" + partNumberTextBox.Text + "'\n" +
                                ",[Revision] = '" + revisionTextBox.Text + "'\n" +
                                ",[Job_Number] = '" + jobNumberTextBox.Text + "'\n" +
                                ",[Lot_Number] = '" + customerTextBox.Text + "'\n" +
                                ",[Operation_Number] = '" + opNumberTextBox.Text + "'\n" +
                                ",[Process_Per] = '" + specificationComboBox.Text + "'\n" +
                                ",[Process_Rev] = '" + specRevComboBox.Text + "'\n" +
                                ",[Time_Hours] = '" + hoursRequiredTimeTextBox.Text + "'\n" +
                                ",[Time_Minutes] = '" + minutesRequiredTimeTextBox.Text + "'\n" +
                                ",[Temp_Degree] = '" + requiredTemperatureTextBox.Text + "'\n" +
                                ",[Temp_Dev] = '" + plusMinTemperatureTextBox.Text + "'\n" +
                                ",[Lot_Quantity] = '" + quantityTextBox.Text + "'\n" +
                                ",[Serial_Numbers] = '" + serialNumbersTextBox.Text + "'\n" +
                                ",[Certified_By] = '" + certifiedByComboBox.SelectedItem.ToString() + "'\n" +
                                ",[Cert_Date] = '" + dateTimePicker.Value.ToShortDateString() + "'\n" +
                                ",[Oven_SN] = '" + ovenSNComboBox.Text + "'\n" +
                                ",[owner] = '" + userName + "'\n" +
                                ",[part_desc] = '" + partDescriptionTextBox.Text + "'\n" +
                                "WHERE CertNumber = '" + certNumberTextBox.Text + "'\n";

                OdbcCommand com = new OdbcCommand(query, conn);

                int rowsAffected = com.ExecuteNonQuery();

                if (rowsAffected != 1)
                    MessageBox.Show("Problem submitting to DB. Contact IT support");
                else
                    MessageBox.Show("Succesfully updated");
            }
        }

        private string GetNextProcessNumber()
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
                string query = "SELECT MAX(CertNumber) + 1\n" +
                                "FROM ATIDelivery.dbo.StressRelieveCertificationLog;";

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

        private bool CheckFormatting()
        {
            int dummyInt;

            // check numeric values
            bool numberFormattingOK = int.TryParse(quantityTextBox.Text, out dummyInt)
                                        && int.TryParse(hoursRequiredTimeTextBox.Text, out dummyInt)
                                        && int.TryParse(minutesRequiredTimeTextBox.Text, out dummyInt)
                                        && int.TryParse(requiredTemperatureTextBox.Text, out dummyInt)
                                        && int.TryParse(plusMinTemperatureTextBox.Text, out dummyInt);

            // check dropdowns
            bool comboBoxesFormattingOK = specificationComboBox.SelectedItem != null
                                            && specRevComboBox.SelectedItem != null
                                            && ovenSNComboBox.SelectedItem != null
                                            && certifiedByComboBox.SelectedItem != null;

            // check textboxes
            bool textBoxesFormattingOK = jobNumberTextBox.Text.Length > 0
                                            && partNumberTextBox.Text.Length > 0
                                            && revisionTextBox.Text.Length > 0
                                            && customerTextBox.Text.Length > 0;

            // format checks
            // numeric
            if (!int.TryParse(quantityTextBox.Text, out dummyInt))
                errorProvider1.SetError(quantityTextBox, "Numeric Value Required");
            if (!int.TryParse(hoursRequiredTimeTextBox.Text, out dummyInt))
                errorProvider1.SetError(hoursRequiredTimeTextBox, "Numeric Value Required");
            if (!int.TryParse(minutesRequiredTimeTextBox.Text, out dummyInt))
                errorProvider1.SetError(minutesRequiredTimeTextBox, "Numeric Value Required");
            if (!int.TryParse(requiredTemperatureTextBox.Text, out dummyInt))
                errorProvider1.SetError(requiredTemperatureTextBox, "Numeric Value Required");
            if (!int.TryParse(plusMinTemperatureTextBox.Text, out dummyInt))
                errorProvider1.SetError(plusMinTemperatureTextBox, "Numeric Value Required");
            // dropdowns
            if (specificationComboBox.SelectedItem == null)
                errorProvider1.SetError(specificationComboBox, "Field Required");
            if (specRevComboBox.SelectedItem == null)
                errorProvider1.SetError(specRevComboBox, "Field Required");
            if (ovenSNComboBox.SelectedItem == null)
                errorProvider1.SetError(ovenSNComboBox, "Field Required");
            if (certifiedByComboBox.SelectedItem == null)
                errorProvider1.SetError(certifiedByComboBox, "Field Required");
            // textboxes
            if (jobNumberTextBox.Text.Length == 0)
                errorProvider1.SetError(jobNumberTextBox, "Field Required");
            if (partNumberTextBox.Text.Length == 0)
                errorProvider1.SetError(partNumberTextBox, "Field Required");
            if (revisionTextBox.Text.Length == 0)
                errorProvider1.SetError(revisionTextBox, "Field Required");
            if (customerTextBox.Text.Length == 0)
                errorProvider1.SetError(customerTextBox, "Field Required");

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
