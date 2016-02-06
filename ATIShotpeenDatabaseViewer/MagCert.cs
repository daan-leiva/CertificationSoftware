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

        // TO_DO
        private void FillInDropDowns()
        {

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
