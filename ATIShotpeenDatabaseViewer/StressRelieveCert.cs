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
    public partial class StressRelieveCert : Form
    {
        // connection string used to set up connection to Microsoft SQL Server Database
        private static readonly string connectionString = "DSN=unipointDB;UID=jbread;PWD=Cloudy2Day";
        private bool newForm;
        private bool canEdit;
        private string userName;

        public StressRelieveCert(bool _canEdit, string _userName)
        {
            newForm = true;
            canEdit = _canEdit;
            userName = _userName;
            
            InitializeComponent();
        }

        public StressRelieveCert(string process_num, bool _canEdit, string _userName)
        {
            newForm = false;
            canEdit = _canEdit;
            //processNumberTextBox.Text = process_num;
            userName = _userName;

            InitializeComponent();
        }

        private void StressRelieveCert_Load(object sender, EventArgs e)
        {

        }
    }
}
