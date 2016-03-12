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
    public partial class ShotpeenCert : Form
    {
        // connection string used to set up connection to Microsoft SQL Server Database
        private static readonly string connectionString = "DSN=unipointDB;UID=jbread;PWD=Cloudy2Day";
        private bool newForm;
        private bool canEdit;
        private string userName;

        public ShotpeenCert(bool _canEdit, string _userName)
        {
            InitializeComponent();

            newForm = true;
            canEdit = _canEdit;
            userName = _userName;
        }

        public ShotpeenCert(string process_num, bool _canEdit, string _userName)
        {
            InitializeComponent();

            newForm = false;
            canEdit = _canEdit;
            processNumberTextBox.Text = process_num;
            userName = _userName;
        }

        private void JobProcessForm_Load(object sender, EventArgs e)
        {
            FillInDropDowns();

            if (!newForm) // update form with current data
                UpdateForm();

            UpdatePostTotalMediaPassing(new object(), new EventArgs());
            UpdatePreTotalMediaPassing(new object(), new EventArgs());

            // lock if the form is user can't edit
            if (!canEdit)
                LockForm();

            // load format checks
            // check numeric
            sieve18PreTextBox.TextChanged += FormatCheckInteger;
            sieve20PreTextBox.TextChanged += FormatCheckInteger;
            sieve25PreTextBox.TextChanged += FormatCheckInteger;
            sieve30PreTextBox.TextChanged += FormatCheckInteger;
            sieve35PreTextBox.TextChanged += FormatCheckInteger;
            sieve40PreTextBox.TextChanged += FormatCheckInteger;
            sieve45PreTextBox.TextChanged += FormatCheckInteger;
            sieve50PreTextBox.TextChanged += FormatCheckInteger;
            sieve80PreTextBox.TextChanged += FormatCheckInteger;
            sieve18PostTextBox.TextChanged += FormatCheckInteger;
            sieve20PostTextBox.TextChanged += FormatCheckInteger;
            sieve25PostTextBox.TextChanged += FormatCheckInteger;
            sieve30PostTextBox.TextChanged += FormatCheckInteger;
            sieve35PostTextBox.TextChanged += FormatCheckInteger;
            sieve40PostTextBox.TextChanged += FormatCheckInteger;
            sieve45PostTextBox.TextChanged += FormatCheckInteger;
            sieve50PostTextBox.TextChanged += FormatCheckInteger;
            sieve80PostTextBox.TextChanged += FormatCheckInteger;
            quantityTextBox.TextChanged += FormatCheckInteger;
            fractureCountPriorTextBox.TextChanged += FormatCheckInteger;
            fractureCountPostTextBox.TextChanged += FormatCheckInteger;
            almen1PostTextBox.TextChanged += FormatCheckInteger;
            almen1PriorTextBox.TextChanged += FormatCheckInteger;
            almen2PostTextBox.TextChanged += FormatCheckInteger;
            almen2PriorTextBox.TextChanged += FormatCheckInteger;
            // check empty
            jobNumberTextBox.TextChanged += FormatCheckEmptyTextBox;
            partNumberTextBox.TextChanged += FormatCheckEmptyTextBox;
            revisionTextBox.TextChanged += FormatCheckEmptyTextBox;
            customerTextBox.TextChanged += FormatCheckEmptyTextBox;
            // check dropdowns
            specificationComboBox.SelectedIndexChanged += FormatCheckInvalidComboBox;
            specRevComboBox.SelectedIndexChanged += FormatCheckInvalidComboBox;
            shotSizeComboBox.SelectedIndexChanged += FormatCheckInvalidComboBox;
            intensityComboBox.SelectedIndexChanged += FormatCheckInvalidComboBox;
            coverageComboBox.SelectedIndexChanged += FormatCheckInvalidComboBox;
            preCleanComboBox.SelectedIndexChanged += FormatCheckInvalidComboBox;
            toolingCheckComboBox.SelectedIndexChanged += FormatCheckInvalidComboBox;
            coverageMethodComboBox.SelectedIndexChanged += FormatCheckInvalidComboBox;
            sampleSizeComboBox.SelectedIndexChanged += FormatCheckInvalidComboBox;
            machineNumberTextBox.SelectedIndexChanged += FormatCheckInvalidComboBox;
            technicianComboBox.SelectedIndexChanged += FormatCheckInvalidComboBox;
        }


        private void UpdateForm()
        {
            using (OdbcConnection conn = new OdbcConnection(connectionString))
            {
                conn.Open();

                string query = "SELECT job_num, date, finish_date, part_num, part_desc, customer, part_rev, lot_num, qty, serial_num, specification, specificationRev, add_spec, add_specRev, shot_sz, intensity, coverage, [pre-clean], tooling_chk, cov_ver_mthd, sample_sz, frac_cnt_pre, frac_cnt_post, almen1_pre, almen1_post, almen2_pre, almen2_post, machine, technician, Notes, sievepre1, sievepre2, sievepost3, sievepre4, sievepre5, sievepre6, sievepre7, sievepre8, sievepre9, sievepost1, sievepost2, sievepost3, sievepost4, sievepost5, sievepost6, sievepost7, sievepost8, sievepost9\n" +
                                "FROM ATIDelivery.dbo.tblJobProcessLog\n" +
                                "WHERE process_num = " + processNumberTextBox.Text + ";";

                OdbcCommand com = new OdbcCommand(query, conn);

                OdbcDataReader reader = com.ExecuteReader();

                try
                {
                    reader.Read();

                    // Fill out corresponding form values
                    jobNumberTextBox.Text = reader.IsDBNull(0) ? "" : reader.GetString(0);
                    startDateTimePicker.Value = reader.IsDBNull(1) ? startDateTimePicker.MinDate : (reader.GetString(1).Length > 0 ? Convert.ToDateTime(reader.GetString(1)) : startDateTimePicker.MinDate);
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
                UpdatePreTotalMediaPassing(new object(), new EventArgs());
                UpdatePostTotalMediaPassing(new object(), new EventArgs());
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

        // This method fills in the corresponding data into the form's dropdowns
        // the data comes from the ATIDelivery database (multiple tables being used)
        private void FillInDropDowns()
        {
            string query = string.Empty;
            List<string> controlContent;

            // populate specification dropdown
            query = "SELECT specification\n" +
                    "FROM ATIDelivery.dbo.tblSpecification;";
            controlContent = GetValuesFromDB(query, specificationComboBox);
            PopulateControl(controlContent, specificationComboBox);

            // populate rev specification dropdown
            query = "SELECT REV\n" +
                    "FROM ATIDelivery.dbo.Rev;";
            controlContent = GetValuesFromDB(query, specRevComboBox);
            PopulateControl(controlContent, specRevComboBox);
            
            // populate additional specs dropdown
            query = "SELECT specification\n" +
                    "FROM ATIDelivery.dbo.tblSpecification;";
            controlContent = GetValuesFromDB(query, additionalSpecsComboBox);
            PopulateControl(controlContent, additionalSpecsComboBox);

            // populate additional rev specification dropdown
            query = "SELECT REV\n" +
                    "FROM ATIDelivery.dbo.Rev;";
            controlContent = GetValuesFromDB(query, additionalSpecRevComboBox);
            PopulateControl(controlContent, additionalSpecRevComboBox);
            
            // populate shot size dropdown
            query = "SELECT size\n" +
                    "FROM ATIDelivery.dbo.ShotSize;";
            controlContent = GetValuesFromDB(query, shotSizeComboBox);
            PopulateControl(controlContent, shotSizeComboBox);

            // populate intensity dropdown
            query = "SELECT intensity\n" +
                    "FROM ATIDelivery.dbo.tblintensity";
            controlContent = GetValuesFromDB(query, intensityComboBox);
            PopulateControl(controlContent, intensityComboBox);

            // populate coverage dropdown
            query = "SELECT coverage\n" +
                    "FROM ATIDelivery.dbo.tblcoverage";
            controlContent = GetValuesFromDB(query, coverageComboBox);
            PopulateControl(controlContent, coverageComboBox);

            // populate preclean dropdown
            // hardcoded drop down
            controlContent = new List<string>(new string[] { "Yes", "No" });
            PopulateControl(controlContent, preCleanComboBox);

            // populate tooling check dropdown
            // hardcoded drop down
            controlContent = new List<string>(new string[] { "Yes", "No" });
            PopulateControl(controlContent, toolingCheckComboBox);

            // populate coverage method dropdown
            query = "SELECT method\n" +
                    "FROM ATIDelivery.dbo.CoverageInspectionMethod";
            controlContent = GetValuesFromDB(query, coverageMethodComboBox);
            PopulateControl(controlContent, coverageMethodComboBox);

            // populate sample size dropdown
            query = "SELECT sample_sz\n" +
                    "FROM ATIDelivery.dbo.tblsample_size";
            controlContent = GetValuesFromDB(query, sampleSizeComboBox);
            PopulateControl(controlContent, sampleSizeComboBox);

            // populate machine # dropdown
            query = "SELECT machine\n" +
                    "FROM ATIDelivery.dbo.tbl_machine#";
            controlContent = GetValuesFromDB(query, machineNumberTextBox);
            PopulateControl(controlContent, machineNumberTextBox);

            // populate technician dropdown
            query = "SELECT technician\n" +
                    "FROM ATIDelivery.dbo.tbltechnician";
            controlContent = GetValuesFromDB(query, technicianComboBox);
            PopulateControl(controlContent, technicianComboBox);
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

        // This button fills in the following data automatically
        // from the jobboss data base
        // Data: Part number, Revision, Part Description, Customer Name
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

        private void printCertButton_Click(object sender, EventArgs e)
        {

        }

        // this submits all of the data to the database or edits an old row if already exists
        private void submitButton_Click(object sender, EventArgs e)
        {
            // check document formating
            if (!CheckFormatting())
            {
                MessageBox.Show("Formatting error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // check if the process number is empty
            if (processNumberTextBox.Text.Length == 0)
            {
                // get new process number
                int newProcessNumber = GetNextProcessNumber();

                // assign it to the document
                processNumberTextBox.Text = newProcessNumber.ToString();

                // submit to DB
                SubmitNewRow();
            }
            else // run update query
            {
                UpdateRow();
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
                string query = "INSERT INTO ATIDelivery.dbo.tblJobProcessLog\n" +
                                "([process_num]\n" +
                                ",[job_num]\n" +
                                ",[part_num]\n" +
                                ",[part_rev]\n" +
                                ",[part_desc]\n" +
                                ",[customer]\n" +
                                ",[qty]\n" +
                                ",[Notes]\n" +
                                ",[lot_num]\n" +
                                ",[date]\n" +
                                ",[finish_date]\n" +
                                ",[specification]\n" +
                                ",[specificationRev]\n" +
                                ",[add_spec]\n" +
                                ",[add_specRev]\n" +
                                ",[shot_sz]\n" +
                                ",[intensity]\n" +
                                ",[frac_cnt_pre]\n" +
                                ",[frac_cnt_post]\n" +
                                ",[almen1_pre]\n" +
                                ",[almen1_post]\n" +
                                ",[almen2_pre]\n" +
                                ",[almen2_post]\n" +
                                ",[pre-clean]\n" +
                                ",[tooling_chk]\n" +
                                ",[cov_ver_mthd]\n" +
                                ",[coverage]\n" +
                                ",[technician]\n" +
                                ",[sievepre1]\n" +
                                ",[sievepre2]\n" +
                                ",[sievepre3]\n" +
                                ",[sievepre4]\n" +
                                ",[sievepre5]\n" +
                                ",[sievepost1]\n" +
                                ",[sievepost2]\n" +
                                ",[sievepost3]\n" +
                                ",[sievepost4]\n" +
                                ",[sievepost5]\n" +
                                ",[sievepre6]\n" +
                                ",[sievepost6]\n" +
                                ",[sievepre7]\n" +
                                ",[sievepost7]\n" +
                                ",[sievepre8]\n" +
                                ",[sievepost8]\n" +
                                ",[sievepre9]\n" +
                                ",[sievepost9]\n" +
                                ",[sample_sz]\n" +
                                ",[serial_num]\n" +
                                ",[serial_num2]\n" +
                                ",[machine]\n" +
                                ",[owner])\n" +
                                "VALUES (\n" +
                                "'" + processNumberTextBox.Text + "',\n" +
                                "'" + jobNumberTextBox.Text + "',\n" +
                                "'" + partNumberTextBox.Text + "',\n" +
                                "'" + revisionTextBox.Text + "',\n" +
                                "'" + partDescriptionTextBox.Text + "',\n" +
                                "'" + customerTextBox.Text + "',\n" +
                                "'" + quantityTextBox.Text + "',\n" +
                                "'" + notesTextBox.Text + "',\n" +
                                "'" + lotNumberTextBox.Text + "',\n" +
                                "'" + startDateTimePicker.Value.ToShortDateString() + "',\n" +
                                "'" + finishDateTimePicker.Value.ToShortDateString() + "',\n" +
                                "'" + specificationComboBox.SelectedItem.ToString() + "',\n" +
                                "'" + specRevComboBox.SelectedItem.ToString() + "',\n" +
                                (additionalSpecsComboBox.SelectedItem == null ? "NULL" : "'" + additionalSpecsComboBox.SelectedItem.ToString() + "'") + ",\n" +
                                (additionalSpecRevComboBox.SelectedItem == null ? "NULL" : "'" + additionalSpecRevComboBox.SelectedItem.ToString() + "'") + ",\n" +
                                "'" + shotSizeComboBox.SelectedItem.ToString() + "',\n" +
                                "'" + intensityComboBox.SelectedItem.ToString() + "',\n" +
                                "'" + fractureCountPriorTextBox.Text + "',\n" +
                                "'" + fractureCountPostTextBox.Text + "',\n" +
                                "'" + almen1PriorTextBox.Text + "',\n" +
                                "'" + almen1PostTextBox.Text + "',\n" +
                                "'" + almen2PriorTextBox.Text + "',\n" +
                                "'" + almen2PostTextBox.Text + "',\n" +
                                "'" + preCleanComboBox.SelectedItem.ToString() + "',\n" +
                                "'" + toolingCheckComboBox.SelectedItem.ToString() + "',\n" +
                                "'" + coverageMethodComboBox.SelectedItem.ToString() + "',\n" +
                                "'" + coverageComboBox.SelectedItem.ToString() + "',\n" +
                                "'" + technicianComboBox.Text + "',\n" +
                                "'" + sieve18PreTextBox.Text + "',\n" +
                                "'" + sieve20PreTextBox.Text + "',\n" +
                                "'" + sieve25PreTextBox.Text + "',\n" +
                                "'" + sieve30PreTextBox.Text + "',\n" +
                                "'" + sieve35PreTextBox.Text + "',\n" +
                                "'" + sieve18PostTextBox.Text + "',\n" +
                                "'" + sieve20PostTextBox.Text + "',\n" +
                                "'" + sieve25PostTextBox.Text + "',\n" +
                                "'" + sieve30PostTextBox.Text + "',\n" +
                                "'" + sieve35PostTextBox.Text + "',\n" +
                                "'" + sieve40PreTextBox.Text + "',\n" +
                                "'" + sieve40PostTextBox.Text + "',\n" +
                                "'" + sieve45PreTextBox.Text + "',\n" +
                                "'" + sieve45PostTextBox.Text + "',\n" +
                                "'" + sieve50PreTextBox.Text + "',\n" +
                                "'" + sieve50PostTextBox.Text + "',\n" +
                                "'" + sieve80PreTextBox.Text + "',\n" +
                                "'" + sieve80PostTextBox.Text + "',\n" +
                                "'" + sampleSizeComboBox.SelectedItem + "',\n" +
                                "'" + serialNumbersTextBox.Text + "',\n" +
                                "NULL,\n" +
                                "'" + machineNumberTextBox.Text + "',\n" +
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
                string query = "UPDATE ATIDelivery.dbo.tblJobProcessLog\n" +
                                "SET [job_num] = '" + jobNumberTextBox.Text + "',\n" +
                                "[part_num]= '" + partNumberTextBox.Text + "',\n" +
                                "[part_rev] = '" + revisionTextBox.Text + "',\n" +
                                "[part_desc] = '" + partDescriptionTextBox.Text + "',\n" +
                                "[customer] = '" + customerTextBox.Text + "',\n" +
                                "[qty] = '" + quantityTextBox.Text + "',\n" +
                                "[Notes] = '" + notesTextBox.Text + "',\n" +
                                "[lot_num] = '" + lotNumberTextBox.Text + "',\n" +
                                "[date] = '" + startDateTimePicker.Value.ToShortDateString() + "',\n" +
                                "[finish_date] = '" + finishDateTimePicker.Value.ToShortDateString() + "',\n" +
                                "[specification] = '" + specificationComboBox.SelectedItem.ToString() + "',\n" +
                                "[specificationRev] = '" + specRevComboBox.SelectedItem.ToString() + "',\n" +
                                "[add_spec] = " + (additionalSpecsComboBox.SelectedItem == null ? "NULL" : "'" + additionalSpecsComboBox.SelectedItem.ToString() + "'") + ",\n" +
                                "[add_specRev] = " + (additionalSpecRevComboBox.SelectedItem == null ? "NULL" : "'" + additionalSpecRevComboBox.SelectedItem.ToString() + "'") + ",\n" +
                                "[shot_sz] = '" + shotSizeComboBox.SelectedItem.ToString() + "',\n" +
                                "[intensity] = '" + intensityComboBox.SelectedItem.ToString() + "',\n" +
                                "[frac_cnt_pre] = '" + fractureCountPriorTextBox.Text + "',\n" +
                                "[frac_cnt_post] = '" + fractureCountPostTextBox.Text + "',\n" +
                                "[almen1_pre] = '" + almen1PriorTextBox.Text + "',\n" +
                                "[almen1_post] = '" + almen1PostTextBox.Text + "',\n" +
                                "[almen2_pre] = '" + almen2PriorTextBox.Text + "',\n" +
                                "[almen2_post] = '" + almen2PostTextBox.Text + "',\n" +
                                "[pre-clean] = '" + preCleanComboBox.SelectedItem.ToString() + "',\n" +
                                "[tooling_chk] = '" + toolingCheckComboBox.SelectedItem.ToString() + "',\n" +
                                "[cov_ver_mthd] = '" + coverageMethodComboBox.SelectedItem.ToString() + "',\n" +
                                "[coverage] = '" + coverageComboBox.SelectedItem.ToString() + "',\n" +
                                "[technician] = '" + technicianComboBox.SelectedItem.ToString() + "',\n" +
                                "[sievepre1] = '" + sieve18PreTextBox.Text + "',\n" +
                                "[sievepre2] = '" + sieve20PreTextBox.Text + "',\n" +
                                "[sievepre3] = '" + sieve30PreTextBox.Text + "',\n" +
                                "[sievepre4] = '" + sieve35PreTextBox.Text + "',\n" +
                                "[sievepre5] = '" + sieve40PreTextBox.Text + "',\n" +
                                "[sievepost1] = '" + sieve18PostTextBox.Text + "',\n" +
                                "[sievepost2] = '" + sieve20PostTextBox.Text + "',\n" +
                                "[sievepost3] = '" + sieve25PostTextBox.Text + "',\n" +
                                "[sievepost4] = '" + sieve30PostTextBox.Text + "',\n" +
                                "[sievepost5] = '" + sieve35PostTextBox.Text + "',\n" +
                                "[sievepre6] = '" + sieve40PreTextBox.Text + "',\n" +
                                "[sievepost6] = '" + sieve40PostTextBox.Text + "',\n" +
                                "[sievepre7] = '" + sieve45PreTextBox.Text + "',\n" +
                                "[sievepost7] = '" + sieve45PostTextBox.Text + "',\n" +
                                "[sievepre8] = '" + sieve50PreTextBox.Text + "',\n" +
                                "[sievepost8] = '" + sieve50PostTextBox.Text + "',\n" +
                                "[sievepre9] = '" + sieve80PreTextBox.Text + "',\n" +
                                "[sievepost9] = '" + sieve80PostTextBox.Text + "',\n" +
                                "[serial_num] = '" + sampleSizeComboBox.SelectedItem + "',\n" +
                                "[machine] = '" + machineNumberTextBox.Text + "'\n" +
                                "WHERE process_num = '" + processNumberTextBox.Text + "';";

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
                string query = "SELECT MAX(process_num) + 1\n" +
                                "FROM ATIDelivery.dbo.tblJobProcessLog;";

                // execute query
                OdbcCommand com = new OdbcCommand(query, conn);
                OdbcDataReader reader = com.ExecuteReader();


                if (reader.Read())
                    return reader.IsDBNull(0) ? 1000 : reader.GetInt32(0);
                else
                {
                    MessageBox.Show("DB error. Contact IT Suppor", "DB ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return 0000;
                }
            }
        }

        // checks that all of the values are numeric for sieve section and that combo boxes have an item selected
        private bool CheckFormatting()
        {
            decimal dummyDecimal;

            // check numeric values
            bool numberFormattignOk = decimal.TryParse(sieve18PreTextBox.Text, out dummyDecimal)
                && decimal.TryParse(sieve20PreTextBox.Text, out dummyDecimal)
                && decimal.TryParse(sieve25PreTextBox.Text, out dummyDecimal)
                && decimal.TryParse(sieve30PreTextBox.Text, out dummyDecimal)
                && decimal.TryParse(sieve35PreTextBox.Text, out dummyDecimal)
                && decimal.TryParse(sieve40PreTextBox.Text, out dummyDecimal)
                && decimal.TryParse(sieve45PreTextBox.Text, out dummyDecimal)
                && decimal.TryParse(sieve50PreTextBox.Text, out dummyDecimal)
                && decimal.TryParse(sieve80PreTextBox.Text, out dummyDecimal)
                && decimal.TryParse(sieve18PostTextBox.Text, out dummyDecimal)
                && decimal.TryParse(sieve20PostTextBox.Text, out dummyDecimal)
                && decimal.TryParse(sieve25PostTextBox.Text, out dummyDecimal)
                && decimal.TryParse(sieve30PostTextBox.Text, out dummyDecimal)
                && decimal.TryParse(sieve35PostTextBox.Text, out dummyDecimal)
                && decimal.TryParse(sieve40PostTextBox.Text, out dummyDecimal)
                && decimal.TryParse(sieve45PostTextBox.Text, out dummyDecimal)
                && decimal.TryParse(sieve50PostTextBox.Text, out dummyDecimal)
                && decimal.TryParse(sieve80PostTextBox.Text, out dummyDecimal)
                && decimal.TryParse(fractureCountPriorTextBox.Text, out dummyDecimal)
                && decimal.TryParse(fractureCountPostTextBox.Text, out dummyDecimal)
                && decimal.TryParse(almen1PriorTextBox.Text, out dummyDecimal)
                && decimal.TryParse(almen1PostTextBox.Text, out dummyDecimal)
                && (almen2PostTextBox.Text.Length > 0 ? decimal.TryParse(almen2PostTextBox.Text, out dummyDecimal) : true) // field is not required, only check when content is available
                && (almen2PriorTextBox.Text.Length > 0 ? decimal.TryParse(almen2PriorTextBox.Text, out dummyDecimal) : true) // field is not required, only check when content is available;
                && decimal.TryParse(quantityTextBox.Text, out dummyDecimal);


            // check dropdowns
            bool dropDownFormattingOk = specificationComboBox.SelectedItem != null
                                     && specRevComboBox.SelectedItem != null
                                     && shotSizeComboBox.SelectedItem != null
                                     && intensityComboBox.SelectedItem != null
                                     && coverageComboBox.SelectedItem != null
                                     && preCleanComboBox.SelectedItem != null
                                     && toolingCheckComboBox.SelectedItem != null
                                     && coverageMethodComboBox.SelectedItem != null
                                     && sampleSizeComboBox.SelectedItem != null
                                     && machineNumberTextBox.SelectedItem != null
                                     && technicianComboBox.SelectedItem != null;

            // check textboxes
            bool textBoxesFormattingOk = jobNumberTextBox.Text.Length > 0
                                        && partNumberTextBox.Text.Length > 0
                                        && revisionTextBox.Text.Length > 0
                                        && customerTextBox.Text.Length > 0;

            // numeric
            int dummyInt;
            if (!int.TryParse(sieve18PreTextBox.Text, out dummyInt))
                errorProvider1.SetError(sieve18PreTextBox, "Numeric value required");
            if (!int.TryParse(sieve20PreTextBox.Text, out dummyInt))
                errorProvider1.SetError(sieve20PreTextBox, "Numeric value required");
            if (!int.TryParse(sieve25PreTextBox.Text, out dummyInt))
                errorProvider1.SetError(sieve25PreTextBox, "Numeric value required");
            if (!int.TryParse(sieve30PreTextBox.Text, out dummyInt))
                errorProvider1.SetError(sieve30PreTextBox, "Numeric value required");
            if (!int.TryParse(sieve35PreTextBox.Text, out dummyInt))
                errorProvider1.SetError(sieve35PreTextBox, "Numeric value required");
            if (!int.TryParse(sieve40PreTextBox.Text, out dummyInt))
                errorProvider1.SetError(sieve40PreTextBox, "Numeric value required");
            if (!int.TryParse(sieve45PreTextBox.Text, out dummyInt))
                errorProvider1.SetError(sieve45PreTextBox, "Numeric value required");
            if (!int.TryParse(sieve50PreTextBox.Text, out dummyInt))
                errorProvider1.SetError(sieve50PreTextBox, "Numeric value required");
            if (!int.TryParse(sieve80PreTextBox.Text, out dummyInt))
                errorProvider1.SetError(sieve80PreTextBox, "Numeric value required");
            if (!int.TryParse(sieve18PostTextBox.Text, out dummyInt))
                errorProvider1.SetError(sieve18PostTextBox, "Numeric value required");
            if (!int.TryParse(sieve20PostTextBox.Text, out dummyInt))
                errorProvider1.SetError(sieve20PostTextBox, "Numeric value required");
            if (!int.TryParse(sieve25PostTextBox.Text, out dummyInt))
                errorProvider1.SetError(sieve25PostTextBox, "Numeric value required");
            if (!int.TryParse(sieve30PostTextBox.Text, out dummyInt))
                errorProvider1.SetError(sieve30PostTextBox, "Numeric value required");
            if (!int.TryParse(sieve35PostTextBox.Text, out dummyInt))
                errorProvider1.SetError(sieve35PostTextBox, "Numeric value required");
            if (!int.TryParse(sieve40PostTextBox.Text, out dummyInt))
                errorProvider1.SetError(sieve40PostTextBox, "Numeric value required");
            if (!int.TryParse(sieve45PostTextBox.Text, out dummyInt))
                errorProvider1.SetError(sieve45PostTextBox, "Numeric value required");
            if (!int.TryParse(sieve50PostTextBox.Text, out dummyInt))
                errorProvider1.SetError(sieve50PostTextBox, "Numeric value required");
            if (!int.TryParse(sieve80PostTextBox.Text, out dummyInt))
                errorProvider1.SetError(sieve80PostTextBox, "Numeric value required");
            if (!int.TryParse(fractureCountPriorTextBox.Text, out dummyInt))
                errorProvider1.SetError(fractureCountPriorTextBox, "Numeric value required");
            if (!int.TryParse(fractureCountPostTextBox.Text, out dummyInt))
                errorProvider1.SetError(fractureCountPostTextBox, "Numeric value required");
            if (!int.TryParse(almen1PriorTextBox.Text, out dummyInt))
                errorProvider1.SetError(almen1PriorTextBox, "Numeric value required");
            if (!int.TryParse(almen1PostTextBox.Text, out dummyInt))
                errorProvider1.SetError(almen1PostTextBox, "Numeric value required");
            if (almen2PostTextBox.Text.Length > 0 && (!int.TryParse(almen2PostTextBox.Text, out dummyInt))) // field is not required, only check when content is available
                errorProvider1.SetError(almen2PostTextBox, "Numeric value required");
            if (almen2PriorTextBox.Text.Length > 0 && (!int.TryParse(almen2PriorTextBox.Text, out dummyInt))) // field is not required, only check when content is available;
                errorProvider1.SetError(almen2PriorTextBox, "Numeric value required");
            if (!int.TryParse(quantityTextBox.Text, out dummyInt))
                errorProvider1.SetError(quantityTextBox, "Numeric value required");
            // dropdown
            if (specificationComboBox.SelectedItem == null)
                errorProvider1.SetError(specificationComboBox, "Selection Required");
            if (specRevComboBox.SelectedItem == null)
                errorProvider1.SetError(specRevComboBox, "Selection Required");
            if (shotSizeComboBox.SelectedItem == null)
                errorProvider1.SetError(shotSizeComboBox, "Selection Required");
            if (intensityComboBox.SelectedItem == null)
                errorProvider1.SetError(intensityComboBox, "Selection Required");
            if (coverageComboBox.SelectedItem == null)
                errorProvider1.SetError(coverageComboBox, "Selection Required");
            if (preCleanComboBox.SelectedItem == null)
                errorProvider1.SetError(preCleanComboBox, "Selection Required");
            if (toolingCheckComboBox.SelectedItem == null)
                errorProvider1.SetError(toolingCheckComboBox, "Selection Required");
            if (coverageMethodComboBox.SelectedItem == null)
                errorProvider1.SetError(coverageMethodComboBox, "Selection Required");
            if (sampleSizeComboBox.SelectedItem == null)
                errorProvider1.SetError(sampleSizeComboBox, "Selection Required");
            if (machineNumberTextBox.SelectedItem == null)
                errorProvider1.SetError(machineNumberTextBox, "Selection Required");
            if (technicianComboBox.SelectedItem == null)
                errorProvider1.SetError(technicianComboBox, "Selection Required");
            // textbox
            if (jobNumberTextBox.Text.Length == 0)
                errorProvider1.SetError(jobNumberTextBox, "Text Required");
            if (partNumberTextBox.Text.Length == 0)
                errorProvider1.SetError(partNumberTextBox, "Text Required");
            if (revisionTextBox.Text.Length == 0)
                errorProvider1.SetError(revisionTextBox, "Text Required");
            if (customerTextBox.Text.Length == 0)
                errorProvider1.SetError(customerTextBox, "Text Required");

            return numberFormattignOk && dropDownFormattingOk && textBoxesFormattingOk;

        }

        private void UpdatePreTotalMediaPassing(object sender, EventArgs e)
        {
            double sum = 0;
            double result;

            if (double.TryParse(sieve18PreTextBox.Text, out result))
                sum += result;
            if (double.TryParse(sieve20PreTextBox.Text, out result))
                sum += result;
            if (double.TryParse(sieve25PreTextBox.Text, out result))
                sum += result;
            if (double.TryParse(sieve30PreTextBox.Text, out result))
                sum += result;
            if (double.TryParse(sieve35PreTextBox.Text, out result))
                sum += result;
            if (double.TryParse(sieve40PreTextBox.Text, out result))
                sum += result;
            if (double.TryParse(sieve45PreTextBox.Text, out result))
                sum += result;
            if (double.TryParse(sieve50PreTextBox.Text, out result))
                sum += result;
            if (double.TryParse(sieve80PreTextBox.Text, out result))
                sum += result;

            totalMediaPassingPreTextBox.Text = (100 - Math.Round(sum, 2)).ToString();
        }

        private void UpdatePostTotalMediaPassing(object sender, EventArgs e)
        {
            double sum = 0;
            double result;

            if (double.TryParse(sieve18PostTextBox.Text, out result))
                sum += result;
            if (double.TryParse(sieve20PostTextBox.Text, out result))
                sum += result;
            if (double.TryParse(sieve25PostTextBox.Text, out result))
                sum += result;
            if (double.TryParse(sieve30PostTextBox.Text, out result))
                sum += result;
            if (double.TryParse(sieve35PostTextBox.Text, out result))
                sum += result;
            if (double.TryParse(sieve40PostTextBox.Text, out result))
                sum += result;
            if (double.TryParse(sieve45PostTextBox.Text, out result))
                sum += result;
            if (double.TryParse(sieve50PostTextBox.Text, out result))
                sum += result;
            if (double.TryParse(sieve80PostTextBox.Text, out result))
                sum += result;

            totalMediaPassingPostTextBox.Text = (100 - Math.Round(sum, 2)).ToString();
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

        private void FormatCheckInteger(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            int dummyOut;
            if (textBox.Text.Length > 0 && !int.TryParse(textBox.Text, out dummyOut))
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