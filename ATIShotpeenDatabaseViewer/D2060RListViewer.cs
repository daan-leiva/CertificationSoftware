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
    public partial class D2060RListViewer : Form
    {
        private bool isAdmin;
        private string userName;
        private bool canWrite;
        private static readonly string connectionString = "DSN=unipointDB;UID=jbread;PWD=Cloudy2Day";

        public D2060RListViewer(bool _isAdmin, string _userName, bool _canWrite)
        {
            isAdmin = _isAdmin;
            userName = _userName;
            canWrite = _canWrite;

            InitializeComponent();
        }

        private void D2060RListViewer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aTIDeliveryDataSet._MagD_2060RProcessControlLog' table. You can move, or remove it, as needed.
            this.magD_2060RProcessControlLogTableAdapter.Fill(this.aTIDeliveryDataSet._MagD_2060RProcessControlLog);
            dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Descending);

            // check if admin or writable account
            if (!(isAdmin || canWrite))
                newButton.Enabled = false;
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            Form d2060Form = new D2060RForm(canWrite, userName);
            d2060Form.ShowDialog();
        }

        private void viewEditButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count < 1)
                return;

            string idNumber = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();

            Form D260Form;

            if (!canWrite)
                D260Form = new D2060RForm(idNumber, false, userName);
            else if (isAdmin)
                D260Form = new D2060RForm(idNumber, true, userName);
            else
            {
                // check if owner of cert
                using (OdbcConnection conn = new OdbcConnection(connectionString))
                {
                    conn.Open();

                    string query = "SELECT owner\n" +
                                    "FROM ATIDelivery.dbo.MagD2060RProcessControlLog\n" +
                                    "WHERE ID = '" + idNumber.Trim() + "';";

                    OdbcCommand com = new OdbcCommand(query, conn);
                    OdbcDataReader reader = com.ExecuteReader();
                    reader.Read();

                    bool isOwner = reader.IsDBNull(0) ? false : reader.GetString(0).Equals(userName);

                    D260Form = new D2060RForm(idNumber, isOwner, userName);
                }
            }
            D260Form.ShowDialog();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aTIDeliveryDataSet._MagD_2060RProcessControlLog' table. You can move, or remove it, as needed.
            this.magD_2060RProcessControlLogTableAdapter.Fill(this.aTIDeliveryDataSet._MagD_2060RProcessControlLog);
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
    }
}
