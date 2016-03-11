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
    public partial class MagListViewer : Form
    {
        private bool isAdmin;
        private string userName;
        private bool canWrite;
        private static readonly string connectionString = "DSN=unipointDB;UID=jbread;PWD=Cloudy2Day";

        public MagListViewer(bool _isAdmin, string _userName, bool _canWrite)
        {
            InitializeComponent();

            isAdmin = _isAdmin;
            userName = _userName;
            canWrite = _canWrite;
        }

        private void MagListViewer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aTIDeliveryDataSet.MagListLog' table. You can move, or remove it, as needed.
            this.magListLogTableAdapter.Fill(this.aTIDeliveryDataSet.MagListLog);
            dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Descending);
            
            // check if admin or writable account
            if (!(isAdmin || canWrite))
                newButton.Enabled = false;

            // add filter events
            certNoTextBox.TextChanged += this.ApplyFilters;
            partNoTextBox.TextChanged += this.ApplyFilters;
            jobTextBox.TextChanged += this.ApplyFilters;
            customerTextBox.TextChanged += this.ApplyFilters;
            dateTimePicker1.ValueChanged += this.ApplyFilters;
            inspectorTextBox.TextChanged += this.ApplyFilters;
            enableDateFilterCheckBox.CheckedChanged += this.ApplyFilters;
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            Form magProcessForm = new MagCert(canWrite, userName);
            magProcessForm.ShowDialog();
        }

        private void viewEditButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count < 1)
                return;

            string certNumber = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();

            Form magCert;

            if (!canWrite)
                magCert = new MagCert(certNumber, false, userName);
            else if (isAdmin)
                magCert = new MagCert(certNumber, true, userName);
            else
            {
                // check if owner of cert
                using (OdbcConnection conn = new OdbcConnection(connectionString))
                {
                    conn.Open();

                    string query = "SELECT owner\n" +
                                    "FROM ATIDelivery.dbo.MagListLog\n" +
                                    "WHERE process_num = '" + certNumber.Trim() + "';";

                    OdbcCommand com = new OdbcCommand(query, conn);
                    OdbcDataReader reader = com.ExecuteReader();
                    reader.Read();

                    bool isOwner = reader.IsDBNull(0) ? false : reader.GetString(0).Equals(userName);

                    magCert = new MagCert(certNumber, isOwner, userName);
                }
            }
            magCert.ShowDialog();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            viewEditButton_Click(sender, e);
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            this.magListLogTableAdapter.Fill(this.aTIDeliveryDataSet.MagListLog);
            dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Descending);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ApplyFilters(object sender, EventArgs e)
        {
            if (enableDateFilterCheckBox.Checked)
                magListLogBindingSource.Filter = string.Format("Convert([cert_num], 'System.String') LIKE '%{0}%' AND [customer] LIKE '%{1}%' AND [part_num] LIKE '%{2}%' AND [job_num] LIKE '%{3}%' AND [inspector] LIKE '%{4}%' AND [date] = #{5}#",
                    certNoTextBox.Text, customerTextBox.Text, partNoTextBox.Text, jobTextBox.Text, inspectorTextBox.Text, dateTimePicker1.Value.ToShortDateString());
            else
                magListLogBindingSource.Filter = string.Format("Convert([cert_num], 'System.String') LIKE '%{0}%' AND [customer] LIKE '%{1}%' AND [part_num] LIKE '%{2}%' AND [job_num] LIKE '%{3}%' AND [inspector] LIKE '%{4}%'",
                    certNoTextBox.Text, customerTextBox.Text, partNoTextBox.Text, jobTextBox.Text, inspectorTextBox.Text);
        }
    }
}
