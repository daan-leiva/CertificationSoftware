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
    public partial class MagListViewer : Form
    {
        private bool isAdmin;
        private string userName;
        private bool canWrite;
        private static readonly string connectionString = "DSN=unipointDB;UID=jbread;PWD=Cloudy2Day";

        public MagListViewer(bool _isAdmin, string _userName, bool _canWrite)
        {
            isAdmin = _isAdmin;
            userName = _userName;
            canWrite = _canWrite;

            InitializeComponent();
        }

        private void MagListViewer_Load(object sender, EventArgs e)
        {
            // check if admin or writable account
            if (!(isAdmin || canWrite))
                newButton.Enabled = false;
        }

        private void newButton_Click(object sender, EventArgs e)
        {

        }

        private void viewEditButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count < 1)
                return;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            viewEditButton_Click(sender, e);
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
