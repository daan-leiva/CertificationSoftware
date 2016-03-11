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
    public partial class TAQ525ListViewer : Form
    {
        private bool isAdmin;
        private string userName;
        private bool canWrite;
        private static readonly string connectionString = "DSN=unipointDB;UID=jbread;PWD=Cloudy2Day";

        public TAQ525ListViewer(bool _isAdmin, string _userName, bool _canWrite)
        {
            InitializeComponent();

            isAdmin = _isAdmin;
            userName = _userName;
            canWrite = _canWrite;
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            Form taqForm = new TAQ525Form(canWrite, userName);
            taqForm.ShowDialog();
        }

        private void viewEditButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count < 1)
                return;

            string idNumber = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();

            Form TAQForm;

            if (!canWrite)
                TAQForm = new TAQ525Form(idNumber, false, userName);
            else if (isAdmin)
                TAQForm = new TAQ525Form(idNumber, true, userName);
            else
            {
                // check if owner of cert
                using (OdbcConnection conn = new OdbcConnection(connectionString))
                {
                    conn.Open();

                    string query = "SELECT owner\n" +
                                    "FROM ATIDelivery.dbo.MagTAQ525ProcessControlLog\n" +
                                    "WHERE ID = '" + idNumber.Trim() + "';";

                    OdbcCommand com = new OdbcCommand(query, conn);
                    OdbcDataReader reader = com.ExecuteReader();
                    reader.Read();

                    bool isOwner = reader.IsDBNull(0) ? false : reader.GetString(0).Equals(userName);

                    TAQForm = new TAQ525Form(idNumber, isOwner, userName);
                }
            }
            TAQForm.ShowDialog();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            this.magTaq525ProcessControlLogTableAdapter.Fill(this.aTIDeliveryDataSet.MagTaq525ProcessControlLog);
            dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Descending);
        }

        private void TAQ525ListViewer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aTIDeliveryDataSet.MagTaq525ProcessControlLog' table. You can move, or remove it, as needed.
            this.magTaq525ProcessControlLogTableAdapter.Fill(this.aTIDeliveryDataSet.MagTaq525ProcessControlLog);
            dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Descending);

            // check if admin or writable account
            if (!(isAdmin || canWrite))
                newButton.Enabled = false;

            // add filtering events
            idTextBox.TextChanged += this.ApplyFilters;
            dateTimePicker1.ValueChanged += this.ApplyFilters;
            inspectorTextBox.TextChanged += this.ApplyFilters;
            enableDateFilterCheckBox.CheckedChanged += this.ApplyFilters;
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
                magTaq525ProcessControlLogBindingSource.Filter = string.Format("Convert([ID], 'System.String') LIKE '%{0}%' AND [inspector] LIKE '%{1}%' AND [Date] = #{2}#",
                    idTextBox.Text, inspectorTextBox.Text, dateTimePicker1.Value.ToShortDateString());
            else
                magTaq525ProcessControlLogBindingSource.Filter = string.Format("Convert([ID], 'System.String') LIKE '%{0}%' AND [inspector] LIKE '%{1}%'",
                    idTextBox.Text, inspectorTextBox.Text);
        }
    }
}
