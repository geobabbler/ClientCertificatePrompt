using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlBootstrap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void clientCertificatePrompt1_CertificateChosen(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.clientCertificatePrompt1.ChooseClientCertificate();
        }
    }
    }

