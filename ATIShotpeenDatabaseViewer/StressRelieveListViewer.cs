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
    public partial class StressRelieveListViewer : Form
    {
        private bool isAdmin;
        private string userName;
        private bool canWrite;
        private static readonly string connectionString = "DSN=unipointDB;UID=jbread;PWD=Cloudy2Day";

        public StressRelieveListViewer(bool _isAdmin, string _userName, bool _canWrite)
        {
            InitializeComponent();
            
            isAdmin = _isAdmin;
            userName = _userName;
            canWrite = _canWrite;
        }

        private void StressRelieveListViewer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aTIDeliveryDataSet.StressRelieveCertificationLog' table. You can move, or remove it, as needed.
            this.stressRelieveCertificationLogTableAdapter.Fill(this.aTIDeliveryDataSet.StressRelieveCertificationLog);
            dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Descending);

            // check if admin or writable account
            if (!(isAdmin || canWrite))
                newButton.Enabled = false;

            // add filtering events
            certNoTextBox.TextChanged += this.ApplyFilters;
            customerTextBox.TextChanged += this.ApplyFilters;
            partNoTextBox.TextChanged += this.ApplyFilters;
            jobTextBox.TextChanged += this.ApplyFilters;
            certifiedByTextBox.TextChanged += this.ApplyFilters;
            dateTimePicker1.ValueChanged += this.ApplyFilters;
            enableDateFilterCheckBox.CheckedChanged += this.ApplyFilters;
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            Form stressRelieveForm = new StressRelieveCert(canWrite, userName);
            stressRelieveForm.ShowDialog();
        }

        private void viewEditButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count < 1)
                return;

            string certNumber = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();

            Form stressRelieveForm;

            if (!canWrite)
                stressRelieveForm = new StressRelieveCert(certNumber, false, userName);
            else if (isAdmin)
                stressRelieveForm = new StressRelieveCert(certNumber, true, userName);
            else
            {
                // check if owner of cert
                using (OdbcConnection conn = new OdbcConnection(connectionString))
                {
                    conn.Open();

                    string query = "SELECT owner\n" +
                                    "FROM ATIDelivery.dbo.StressRelieveCertificationLog\n" +
                                    "WHERE CertNumber = '" + certNumber.Trim() + "';";

                    OdbcCommand com = new OdbcCommand(query, conn);
                    OdbcDataReader reader = com.ExecuteReader();
                    reader.Read();

                    bool isOwner = reader.IsDBNull(0) ? false : reader.GetString(0).Equals(userName);

                    stressRelieveForm = new StressRelieveCert(certNumber, isOwner, userName);
                }
            }
            stressRelieveForm.ShowDialog();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            this.stressRelieveCertificationLogTableAdapter.Fill(this.aTIDeliveryDataSet.StressRelieveCertificationLog);
            dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Descending);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            viewEditButton_Click(sender, e);
        }

        private void ApplyFilters(object sender, EventArgs e)
        {
            if (enableDateFilterCheckBox.Checked)
                stressRelieveCertificationLogBindingSource.Filter = string.Format("Convert([CertNumber], 'System.String') LIKE '%{0}%' AND [Customer] LIKE '%{1}%' AND [Part_Number] LIKE '%{2}%' AND [Job_Number] LIKE '%{3}%' AND [Certified_By] LIKE '%{4}%' AND [Cert_Date] = #{5}#",
                    certNoTextBox.Text, customerTextBox.Text, partNoTextBox.Text, jobTextBox.Text, certifiedByTextBox.Text, dateTimePicker1.Value.ToShortDateString());
            else
                stressRelieveCertificationLogBindingSource.Filter = string.Format("Convert([CertNumber], 'System.String') LIKE '%{0}%' AND [Customer] LIKE '%{1}%' AND [Part_Number] LIKE '%{2}%' AND [Job_Number] LIKE '%{3}%' AND [Certified_By] LIKE '%{4}%'",
                    certNoTextBox.Text, customerTextBox.Text, partNoTextBox.Text, jobTextBox.Text, certifiedByTextBox.Text);
        }
    }
}
