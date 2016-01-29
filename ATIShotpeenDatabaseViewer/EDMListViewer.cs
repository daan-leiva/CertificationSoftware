using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATIShotpeenDatabaseViewer
{
    public partial class EDMListViewer : Form
    {
        private bool isAdmin;
        private string userName;
        private bool canWrite;
        private static readonly string connectionString = "DSN=unipointDB;UID=jbread;PWD=Cloudy2Day";

        public EDMListViewer(bool _isAdmin, string _userName, bool _canWrite)
        {
            isAdmin = _isAdmin;
            userName = _userName;
            canWrite = _canWrite;

            InitializeComponent();
        }

        private void EDMListViewer_Load(object sender, EventArgs e)
        {

        }

        private void newButton_Click(object sender, EventArgs e)
        {

        }

        private void viewEditButton_Click(object sender, EventArgs e)
        {

        }

        private void refreshButton_Click(object sender, EventArgs e)
        {

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
