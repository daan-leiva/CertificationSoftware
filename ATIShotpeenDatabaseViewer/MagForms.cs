using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATICertViewer
{
    public partial class MagForms : Form
    {
        bool admin;
        string userName;
        bool canWrite;

        public MagForms(bool _admin, string _userName, bool _canWrite)
        {
            InitializeComponent();

            admin = _admin;
            userName = _userName;
            canWrite = _canWrite;
        }

        private void taqButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form taqCert = new TAQ525ListViewer(admin, userName, canWrite);
            taqCert.FormClosed += (s, args) => this.Close();
            taqCert.Show();
        }

        private void magCertButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form magCert = new MagListViewer(admin, userName, canWrite);
            magCert.FormClosed += (s, args) => this.Close();
            magCert.Show();
        }

        private void d2060Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form d2060Cert = new D2060RListViewer(admin, userName, canWrite);
            d2060Cert.FormClosed += (s, args) => this.Close();
            d2060Cert.Show();
        }
    }
}
