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
    public partial class MagCert : Form
    {
        // connection string used to set up connection to Microsoft SQL Server Database
        private static readonly string connectionString = "DSN=unipointDB;UID=jbread;PWD=Cloudy2Day";
        private bool newForm;
        private bool canEdit;
        private string userName;

        public MagCert(bool _canEdit, string _userName)
        {
            newForm = true;
            canEdit = _canEdit;
            userName = _userName;

            InitializeComponent();
        }

        public MagCert(string process_num, bool _canEdit, string _userName)
        {
            newForm = false;
            canEdit = _canEdit;
            processNumberTextBox.Text = process_num;
            userName = _userName;

            InitializeComponent();
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

                // Explain query
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

        // TO_DO
        private void printCertButton_Click(object sender, EventArgs e)
        {

        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            // check if the process number is empty
            if (processNumberTextBox.Text.Length == 0)
            {
                // check document formating
                if (!CheckFormatting())
                {
                    MessageBox.Show("Formatting error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // get new process number
                string newProcessNumber = GetNextProcessNumber();

                // assign it to the document
                processNumberTextBox.Text = newProcessNumber;

                // submit to DB
                SubmitNewRow();
            }
            else // run update query
            {
                UpdateRow();
            }
        }

        private void MagCert_Load(object sender, EventArgs e)
        {
            FillInDropDowns();

            if (!newForm) // update form with current data
                UpdateForm();

            // lock if the form is user can't edit
            if (!canEdit)
                LockForm();
        }

        // TO_DO
        private void UpdateForm()
        {
            using (OdbcConnection conn = new OdbcConnection(connectionString))
            {
                conn.Open();

                string query = "SELECT part_num, [rev], [part_description], [material_type], [job_num], [date], [customer], [qty_inspected], [qty_accepted], [qty_rejected], [inspector]," +
                                "[spec], [spec_type], [spec_class], [acceptance_criteria], [accept_type], [accept_grade], [type_grade], [accept_class], [comments], [mag_machine]\n" +
                                "FROM ATIDelivery.dbo.MagListLog\n" +
                                "WHERE cert_num = " + processNumberTextBox.Text + ";";

                OdbcCommand com = new OdbcCommand(query, conn);

                OdbcDataReader reader = com.ExecuteReader();

                try
                {
                    reader.Read();

                    // Fill out corresponding form values
                    partNumberTextBox.Text = reader.IsDBNull(0) ? "" : reader.GetString(0);
                    revisionTextBox.Text = reader.IsDBNull(0) ? "" : reader.GetString(0);
                    partDescriptionTextBox.Text = reader.IsDBNull(0) ? "" : reader.GetString(0);
                    TrySelectDropdownItem(materialTypeComboBox, reader.IsDBNull(0) ? "" : reader.GetString(0));
                    jobNumberTextBox.Text = reader.IsDBNull(0) ? "" : reader.GetString(0);
                    dateTimePicker.Value = reader.IsDBNull(1) ? dateTimePicker.MinDate : (reader.GetString(1).Length > 0 ? Convert.ToDateTime(reader.GetString(1)) : dateTimePicker.MinDate);
                    customerTextBox.Text = reader.IsDBNull(0) ? "" : reader.GetString(0);
                    quantity

                    finishDateTimePicker.Value = reader.IsDBNull(2) ? Convert.ToDateTime(reader.GetString(1)) : (reader.GetString(2).Length > 0 ? Convert.ToDateTime(reader.GetString(2)) : Convert.ToDateTime(reader.GetString(1)));
                    partNumberTextBox.Text = reader.IsDBNull(3) ? "" : reader.GetString(3);
                    partDescriptionTextBox.Text = reader.IsDBNull(4) ? "" : reader.GetString(4);
                    customerTextBox.Text = reader.IsDBNull(5) ? "" : reader.GetString(5);
                    revisionTextBox.Text = reader.IsDBNull(6) ? "" : reader.GetString(6);
                    lotNumberTextBox.Text = reader.IsDBNull(7) ? "" : reader.GetString(7);
                    quantityTextBox.Text = reader.IsDBNull(8) ? "" : reader.GetString(8);
                    serialNumbersTextBox.Text = reader.IsDBNull(9) ? "" : reader.GetString(9);
                    TrySelectDropdownItem(specificationComboBox, reader.IsDBNull(10) ? "" : reader.GetString(10));
                    TrySelectDropdownItem(specRevComboBox, reader.IsDBNull(11) ? "" : reader.GetString(11));
                    TrySelectDropdownItem(additionalSpecsComboBox, reader.IsDBNull(12) ? "" : reader.GetString(12));
                    TrySelectDropdownItem(additionalSpecRevComboBox, reader.IsDBNull(13) ? "" : reader.GetString(13));
                    TrySelectDropdownItem(shotSizeComboBox, reader.IsDBNull(14) ? "" : reader.GetString(14));
                    TrySelectDropdownItem(intensityComboBox, reader.IsDBNull(15) ? "" : reader.GetString(15));
                    TrySelectDropdownItem(coverageComboBox, reader.IsDBNull(16) ? "" : reader.GetString(16));
                    TrySelectDropdownItem(preCleanComboBox, reader.IsDBNull(17) ? "" : reader.GetString(17));
                    TrySelectDropdownItem(toolingCheckComboBox, reader.IsDBNull(18) ? "" : reader.GetString(18));
                    TrySelectDropdownItem(coverageMethodComboBox, reader.IsDBNull(19) ? "" : reader.GetString(19));
                    TrySelectDropdownItem(sampleSizeComboBox, reader.IsDBNull(20) ? "" : reader.GetString(20));
                    fractureCountPriorTextBox.Text = reader.IsDBNull(21) ? "" : reader.GetString(21);
                    fractureCountPostTextBox.Text = reader.IsDBNull(22) ? "" : reader.GetString(22);
                    almen1PriorTextBox.Text = reader.IsDBNull(23) ? "" : reader.GetString(23);
                    almen1PostTextBox.Text = reader.IsDBNull(24) ? "" : reader.GetString(24);
                    almen2PriorTextBox.Text = reader.IsDBNull(25) ? "" : reader.GetString(25);
                    almen2PostTextBox.Text = reader.IsDBNull(26) ? "" : reader.GetString(26);
                    machineNumberTextBox.Text = reader.IsDBNull(27) ? "" : reader.GetString(27);
                    TrySelectDropdownItem(technicianComboBox, reader.IsDBNull(28) ? "" : reader.GetString(28));
                    notesTextBox.SelectedText = reader.IsDBNull(29) ? "" : reader.GetString(29);
                    sieve18PreTextBox.Text = reader.IsDBNull(30) ? "0" : reader.GetFloat(30).ToString();
                    sieve20PreTextBox.Text = reader.IsDBNull(31) ? "0" : reader.GetFloat(31).ToString();
                    sieve25PreTextBox.Text = reader.IsDBNull(32) ? "0" : reader.GetFloat(32).ToString();
                    sieve30PreTextBox.Text = reader.IsDBNull(33) ? "0" : reader.GetFloat(33).ToString();
                    sieve35PreTextBox.Text = reader.IsDBNull(34) ? "0" : reader.GetFloat(34).ToString();
                    sieve40PreTextBox.Text = reader.IsDBNull(35) ? "0" : reader.GetFloat(35).ToString();
                    sieve45PreTextBox.Text = reader.IsDBNull(36) ? "0" : reader.GetFloat(36).ToString();
                    sieve50PreTextBox.Text = reader.IsDBNull(37) ? "0" : reader.GetFloat(37).ToString();
                    sieve80PreTextBox.Text = reader.IsDBNull(38) ? "0" : reader.GetFloat(38).ToString();
                    sieve18PostTextBox.Text = reader.IsDBNull(39) ? "0" : reader.GetFloat(39).ToString();
                    sieve20PostTextBox.Text = reader.IsDBNull(40) ? "0" : reader.GetFloat(40).ToString();
                    sieve25PostTextBox.Text = reader.IsDBNull(41) ? "0" : reader.GetFloat(41).ToString();
                    sieve30PostTextBox.Text = reader.IsDBNull(42) ? "0" : reader.GetFloat(42).ToString();
                    sieve35PostTextBox.Text = reader.IsDBNull(43) ? "0" : reader.GetFloat(43).ToString();
                    sieve40PostTextBox.Text = reader.IsDBNull(44) ? "0" : reader.GetFloat(44).ToString();
                    sieve45PostTextBox.Text = reader.IsDBNull(45) ? "0" : reader.GetFloat(45).ToString();
                    sieve50PostTextBox.Text = reader.IsDBNull(46) ? "0" : reader.GetFloat(46).ToString();
                    sieve80PostTextBox.Text = reader.IsDBNull(47) ? "0" : reader.GetFloat(47).ToString();
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

            // material type
            query = "SELECT [Material Type]\n" +
                    "FROM ATIDelivery.dbo.MagMaterialType;";
            controlContent = GetValuesFromDB(query, materialTypeComboBox);
            PopulateControl(controlContent, materialTypeComboBox);

            // spec
            query = "SELECT Spec\n" +
                    "FROM ATIDelivery.dbo.MagSpec;";
            controlContent = GetValuesFromDB(query, specComboBox);
            PopulateControl(controlContent, specComboBox);

            // spec rev
            query = "SELECT Rev\n" +
                    "FROM ATIDelivery.dbo.Rev;";
            controlContent = GetValuesFromDB(query, specRevComboBox);
            PopulateControl(controlContent, specRevComboBox);

            // accept criteria
            query = "SELECT [Acceptance Criteria]\n" +
                    "FROM ATIDelivery.dbo.MagAcceptanceCriteria;";
            controlContent = GetValuesFromDB(query, acceptCriteriaComboBox);
            PopulateControl(controlContent, acceptCriteriaComboBox);

            // accept creteria rev
            query = "SELECT Rev\n" +
                    "FROM ATIDelivery.dbo.Rev;";
            controlContent = GetValuesFromDB(query, acceptCriteriaRevComboBox);
            PopulateControl(controlContent, acceptCriteriaRevComboBox);
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

        // TO_DO
        private void SubmitNewRow()
        {

        }

        // TO_DO
        private void UpdateRow()
        {

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
                string query = "SELECT MAX(cert_num) + 1\n" +
                                "FROM ATIDelivery.dbo.MagListLog;";

                // execute query
                OdbcCommand com = new OdbcCommand(query, conn);
                OdbcDataReader reader = com.ExecuteReader();


                if (reader.Read())
                    return reader.IsDBNull(0) ? "1000" : reader.GetString(0);
                else
                {
                    MessageBox.Show("DB error. Contact IT Suppor", "DB ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return "0000";
                }
            }
        }

        // TO_DO
        // checks that all of the values are numeric for sieve section and that combo boxes have an item selected
        private bool CheckFormatting()
        {
            decimal dummyTest;

            // check numeric values
            bool numberFormattignOk = true;

            // check dropdowns
            bool dropDownFormattingOk = true;

            // check textboxes
            bool textBoxesFormattingOk = true;

            return numberFormattignOk && dropDownFormattingOk && textBoxesFormattingOk;
        }

        private void LockForm()
        {
            foreach (Control control in this.Controls)
                DisableControls(control);

            // leave print button enabled
            printCertButton.Enabled = true;
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
