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
    public partial class ShotpeenListViewer : Form
    {
        private bool isAdmin;
        private string userName;
        private bool canWrite;
        private static readonly string connectionString = "DSN=unipointDB;UID=jbread;PWD=Cloudy2Day";

        public ShotpeenListViewer(bool _isAdmin, string _userName, bool _canWrite)
        {
            InitializeComponent();

            isAdmin = _isAdmin;
            userName = _userName;
            canWrite = _canWrite;
        }

        private void ListViewer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aTIDeliveryDataSet.tblJobProcessLog' table. You can move, or remove it, as needed.
            this.tblJobProcessLogTableAdapter.Fill(this.aTIDeliveryDataSet.tblJobProcessLog);
            dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Descending);

            // check if admin or writable account
            if (!(isAdmin || canWrite))
                newButton.Enabled = false;

            // add filter events
            certNoTextBox.TextChanged += this.ApplyFilters;
            customerTextBox.TextChanged += this.ApplyFilters;
            partNoTextBox.TextChanged += this.ApplyFilters;
            jobTextBox.TextChanged += this.ApplyFilters;
            specificationTextBox.TextChanged += this.ApplyFilters;
            dateTimePicker1.ValueChanged += this.ApplyFilters;
            enableDateFilterCheckBox.CheckedChanged += this.ApplyFilters;
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            Form jobProcessForm = new ShotpeenCert(canWrite, userName);
            jobProcessForm.ShowDialog();
        }

        private void viewEditButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count < 1)
                return;

            string jobProcessNumber = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();

            Form jobProcessForm;

            if (!canWrite)
                jobProcessForm = new ShotpeenCert(jobProcessNumber, false, userName);
            else if (isAdmin)
                jobProcessForm = new ShotpeenCert(jobProcessNumber, true, userName);
            else
            {
                // check if owner of cert
                using (OdbcConnection conn = new OdbcConnection(connectionString))
                {
                    conn.Open();

                    string query = "SELECT owner\n" +
                                    "FROM ATIDelivery.dbo.tblJobProcessLog\n" +
                                    "WHERE process_num = '" + jobProcessNumber.Trim() + "';";

                    OdbcCommand com = new OdbcCommand(query, conn);
                    OdbcDataReader reader = com.ExecuteReader();
                    reader.Read();

                    bool isOwner = reader.IsDBNull(0) ? false : reader.GetString(0).Equals(userName);

                    jobProcessForm = new ShotpeenCert(jobProcessNumber, isOwner, userName);
                }
            }
            jobProcessForm.ShowDialog();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            viewEditButton_Click(sender, e);
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            this.tblJobProcessLogTableAdapter.Fill(this.aTIDeliveryDataSet.tblJobProcessLog);
            dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Descending);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ApplyFilters(object sender, EventArgs e)
        {
            if (enableDateFilterCheckBox.Checked)
                tblJobProcessLogBindingSource.Filter = string.Format("Convert([process_num], 'System.String') LIKE '%{0}%' AND [customer] LIKE '%{1}%' AND [part_num] LIKE '%{2}%' AND [job_num] LIKE '%{3}%' AND [specification] LIKE '%{4}%' AND [date] = #{5}#",
                    certNoTextBox.Text, customerTextBox.Text, partNoTextBox.Text, jobTextBox.Text, specificationTextBox.Text, dateTimePicker1.Value.ToShortDateString());
            else
                tblJobProcessLogBindingSource.Filter = string.Format("Convert([process_num], 'System.String') LIKE '%{0}%' AND [customer] LIKE '%{1}%' AND [part_num] LIKE '%{2}%' AND [job_num] LIKE '%{3}%' AND [specification] LIKE '%{4}%'",
                    certNoTextBox.Text, customerTextBox.Text, partNoTextBox.Text, jobTextBox.Text, specificationTextBox.Text);
        }
    }
}