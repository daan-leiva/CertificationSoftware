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
    public partial class MagCert : Form
    {
        // connection string used to set up connection to Microsoft SQL Server Database
        private static readonly string connectionString = "DSN=unipointDB;UID=jbread;PWD=Cloudy2Day";
        private bool newForm;
        private bool canEdit;
        private string userName;

        public MagCert(bool _canEdit, string _userName)
        {
            InitializeComponent();
            
            newForm = true;
            canEdit = _canEdit;
            userName = _userName;
        }

        public MagCert(string process_num, bool _canEdit, string _userName)
        {
            InitializeComponent();

            newForm = false;
            canEdit = _canEdit;
            certNumberTextBox.Text = process_num;
            userName = _userName;
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
            if (certNumberTextBox.Text.Length == 0)
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
                certNumberTextBox.Text = newProcessNumber;

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

        private void UpdateForm()
        {
            using (OdbcConnection conn = new OdbcConnection(connectionString))
            {
                conn.Open();

                string query = "SELECT part_num, [rev], [part_description], [material_type], [job_num], [date], [customer], [qty_inspected], [qty_accepted], [qty_rejected], [inspector]," +
                                "[spec], spec_rev, [spec_type], [spec_class], [acceptance_criteria], acceptance_criteria_rev , [accept_type], [accept_grade], [spec_grade], [accept_class], [comments], [mag_machine]\n" +
                                "FROM ATIDelivery.dbo.MagListLog\n" +
                                "WHERE cert_num = " + certNumberTextBox.Text + ";";

                OdbcCommand com = new OdbcCommand(query, conn);

                OdbcDataReader reader = com.ExecuteReader();

                try
                {
                    reader.Read();

                    // Fill out corresponding form values
                    partNumberTextBox.Text = reader.IsDBNull(0) ? "" : reader.GetString(0);
                    revisionTextBox.Text = reader.IsDBNull(1) ? "" : reader.GetString(1);
                    partDescriptionTextBox.Text = reader.IsDBNull(2) ? "" : reader.GetString(2);
                    TrySelectDropdownItem(materialTypeComboBox, reader.IsDBNull(3) ? "" : reader.GetString(3));
                    jobNumberTextBox.Text = reader.IsDBNull(4) ? "" : reader.GetString(4);
                    dateTimePicker.Value = reader.IsDBNull(5) ? dateTimePicker.MinDate : (reader.GetString(5).Length > 0 ? Convert.ToDateTime(reader.GetString(5)) : dateTimePicker.MinDate);
                    customerTextBox.Text = reader.IsDBNull(6) ? "" : reader.GetString(6);
                    quantityInspectedTextBox.Text = reader.IsDBNull(7) ? "" : reader.GetString(7);
                    quantityAcceptedTextBox.Text = reader.IsDBNull(8) ? "" : reader.GetString(8);
                    quantityRejectedTextBox.Text = reader.IsDBNull(9) ? "" : reader.GetString(9);
                    TrySelectDropdownItem(technicianComboBox, reader.IsDBNull(10) ? "" : reader.GetString(10));
                    TrySelectDropdownItem(specComboBox, reader.IsDBNull(11) ? "" : reader.GetString(11));
                    TrySelectDropdownItem(specRevComboBox, reader.IsDBNull(12) ? "" : reader.GetString(12));
                    specificatinTypeTextBox.Text = reader.IsDBNull(13) ? "" : reader.GetString(13);
                    specificationClassTextBox.Text = reader.IsDBNull(14) ? "" : reader.GetString(14);
                    TrySelectDropdownItem(acceptCriteriaComboBox, reader.IsDBNull(15) ? "" : reader.GetString(15));
                    TrySelectDropdownItem(acceptCriteriaRevComboBox, reader.IsDBNull(16) ? "" : reader.GetString(16));
                    typeAcceptCriteriaTextBox.Text = reader.IsDBNull(17) ? "" : reader.GetString(17);
                    gradeAcceptCriteriaTextBox.Text = reader.IsDBNull(18) ? "" : reader.GetString(18);
                    gradeSpecificationTextBox.Text = reader.IsDBNull(19) ? "" : reader.GetString(19);
                    classAcceptCriteriaTextBox.Text = reader.IsDBNull(20) ? "" : reader.GetString(20);
                    notesTextBox.Text = reader.IsDBNull(21) ? "" : reader.GetString(21);
                    TrySelectDropdownItem(magMachineComboBox, reader.IsDBNull(22) ? "" : reader.GetString(22));
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

            // mag machine
            query = "SELECT Machine\n" +
                    "FROM ATIDelivery.dbo.MagMachine;";
            controlContent = GetValuesFromDB(query, magMachineComboBox);
            PopulateControl(controlContent, magMachineComboBox);
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

        private void SubmitNewRow()
        {
            // connect to DB
            using (OdbcConnection conn = new OdbcConnection(connectionString))
            {
                // open connection
                conn.Open();

                // specify query
                string query = "INSERT INTO ATIDelivery.dbo.MagCerts\n" +
                                "([cert_num]\n" +
                                ",[part_num]\n" +
                                ",[rev]\n" +
                                ",[part_description]\n" +
                                ",[material_type]\n" +
                                ",[job_num]\n" +
                                ",[date]\n" +
                                ",[customer]\n" +
                                ",[qty_inspected]\n" +
                                ",[qty_accepted]\n" +
                                ",[qty_rejected]\n" +
                                ",[inspector]\n" +
                                ",[spec]\n" +
                                ",[spec_rev]\n" +
                                ",[spec_type]\n" +
                                ",[spec_class]\n" +
                                ",[acceptance_criteria]\n" +
                                ",[acceptance_criteria_rev]\n" +
                                ",[accept_type]\n" +
                                ",[accept_grade]\n" +
                                ",[spec_grade]\n" +
                                ",[accept_class]\n" +
                                ",[comments]\n" +
                                ",[mag_machine]\n" +
                                ",[owner])\n" +
                                "VALUES (\n" +
                                "'" + certNumberTextBox.Text + "',\n" +
                                "'" + partNumberTextBox.Text + "',\n" +
                                "'" + revisionTextBox.Text + "',\n" +
                                "'" + partDescriptionTextBox.Text + "',\n" +
                                "'" + materialTypeComboBox.SelectedValue.ToString() + ",\n" +
                                "'" + jobNumberTextBox.Text + ",\n" +
                                "'" + dateTimePicker.Value.ToShortDateString() + "',\n" +
                                "'" + customerTextBox.Text + ",\n" +
                                "'" + quantityRejectedTextBox.Text + ",\n" +
                                "'" + quantityAcceptedTextBox.Text + ",\n" +
                                "'" + quantityRejectedTextBox.Text + ",\n" +
                                "'" + technicianComboBox.SelectedValue.ToString() + ",\n" +
                                "'" + specComboBox.SelectedValue.ToString() + ",\n" +
                                "'" + specRevComboBox.SelectedValue.ToString() + ",\n" +
                                "'" + specificatinTypeTextBox.Text + ",\n" +
                                "'" + specificationClassTextBox.Text + ",\n" +
                                "'" + acceptCriteriaComboBox.SelectedValue.ToString() + ",\n" +
                                "'" + acceptCriteriaRevComboBox.SelectedValue.ToString() + ",\n" +
                                "'" + typeAcceptCriteriaTextBox.Text + ",\n" +
                                "'" + gradeAcceptCriteriaTextBox.Text + ",\n" +
                                "'" + gradeSpecificationTextBox.Text + ",\n" +
                                "'" + notesTextBox.Text + ",\n" +
                                "'" + magMachineComboBox + ",\n" +
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

        private void UpdateRow()
        {
            // connect to DB
            using (OdbcConnection conn = new OdbcConnection(connectionString))
            {
                // open connection
                conn.Open();

                // specify query
                string query = "UPDATE [dbo].[MagListLog]\n" +
                                "SET [part_num] = '" + partNumberTextBox.Text + "'\n" +
                                ",[rev] = '" + revisionTextBox.Text + "'\n" +
                                ",[part_description] = '" + partDescriptionTextBox.Text + "'\n" +
                                ",[material_type] = '" + materialTypeComboBox.SelectedItem.ToString() + "'\n" +
                                ",[job_num] = '" + jobNumberTextBox.Text + "'\n" +
                                ",[date] = '" + dateTimePicker.Value.ToShortDateString() + "'\n" +
                                ",[customer] = '" + customerTextBox.Text + "'\n" +
                                ",[qty_inspected] = '" + quantityInspectedTextBox.Text + "'\n" +
                                ",[qty_accepted] = '" + quantityAcceptedTextBox.Text + "'\n" +
                                ",[qty_rejected] = '" + quantityRejectedTextBox.Text + "'\n" +
                                ",[inspector] = '" + technicianComboBox.SelectedItem.ToString() + "'\n" +
                                ",[spec] = '" + specComboBox.SelectedItem.ToString() + "'\n" +
                                ",[spec_rev] = '" + specRevComboBox.SelectedItem.ToString() + "'\n" +
                                ",[spec_type] = '" + specificatinTypeTextBox.Text + "'\n" +
                                ",[spec_class] = '" + specificationClassTextBox.Text + "'\n" +
                                ",[acceptance_criteria] = '" + acceptCriteriaComboBox.SelectedItem.ToString() + "'\n" +
                                ",[acceptance_criteria_rev] = '" + acceptCriteriaRevComboBox.SelectedItem.ToString() + "'\n" +
                                ",[accept_type] = '" + typeAcceptCriteriaTextBox.Text + "'\n" +
                                ",[accept_grade] = '" + gradeAcceptCriteriaTextBox.Text + "'\n" +
                                ",[spec_grade] = '" + gradeSpecificationTextBox.Text + "'\n" +
                                ",[accept_class] = '" + specificationClassTextBox.Text + "'\n" +
                                ",[comments] = '" + notesTextBox.Text + "'\n" +
                                ",[mag_machine] = '" + magMachineComboBox.SelectedItem.ToString() + "'\n" +
                                ",[owner] = '" + userName + "'\n" +
                                "WHERE cert_num = '" + certNumberTextBox.Text + "';";

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

        // checks that all of the values are numeric for sieve section and that combo boxes have an item selected
        private bool CheckFormatting()
        {
            int dummyTest;

            // check numeric values
            bool numberFormattignOk = int.TryParse(lotNumberTextBox.Text, out dummyTest) &&
                                        int.TryParse(quantityInspectedTextBox.Text, out dummyTest) &&
                                        int.TryParse(quantityAcceptedTextBox.Text, out dummyTest) &&
                                        int.TryParse(quantityRejectedTextBox.Text, out dummyTest);

            // check dropdowns
            bool dropDownFormattingOk = specComboBox.SelectedItem != null &&
                                        specRevComboBox.SelectedItem != null &&
                                        acceptCriteriaComboBox.SelectedItem != null &&
                                        acceptCriteriaRevComboBox.SelectedItem != null &&
                                        technicianComboBox.SelectedItem != null &&
                                        magMachineComboBox.SelectedItem != null &&
                                        rejectionTypeComboBox.SelectedItem != null;

            // check textboxes
            bool textBoxesFormattingOk = jobNumberTextBox.Text.Length > 0 &&
                                            partDescriptionTextBox.Text.Length > 0 &&
                                            revisionTextBox.Text.Length > 0 &&
                                            partNumberTextBox.Text.Length > 0;

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
