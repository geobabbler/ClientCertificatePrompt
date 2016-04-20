using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Reflection;

namespace Mangrove.Security.X509.Controls
{
    public delegate void CertificateChosenHandler(X509Certificate2 certificate);
    public delegate void CertificateNotChosenHandler();

    public partial class ClientCertificatePrompt : Component
    {
        private StoreName mStoreName = StoreName.My;
        private StoreLocation mStoreLocation = StoreLocation.CurrentUser;
        private X509FindType mFindType = X509FindType.FindByIssuerName;
        private string mFindTerm = "";
        private bool mValidOnly = true;
        private X509Certificate2 mCert = null;

        public event CertificateChosenHandler CertificateChosen;
        public event CertificateNotChosenHandler CertificateNotChosen;

        public ClientCertificatePrompt()
        {
            InitializeComponent();
        }

        public ClientCertificatePrompt(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        public StoreName Store
        {
            get
            {
                return mStoreName;
            }
            set
            {
                mStoreName = value;
            }
        }

        public StoreLocation Location
        {
            get
            {
                return mStoreLocation;
            }
            set
            {
                mStoreLocation = value;
            }
        }

        public X509FindType FindType
        {
            get
            {
                return mFindType;
            }
            set
            {
                mFindType = value;
            }
        }

        public string FindTerm
        {
            get
            {
                return mFindTerm;
            }
            set
            {
                mFindTerm = value;
            }
        }

        public bool ValidOnly
        {
            get
            {
                return mValidOnly;
            }
            set
            {
                mValidOnly = value;
            }
        }

        public void ChooseClientCertificate()
        {
            var store = new X509Store(mStoreName, mStoreLocation);
            store.Open(OpenFlags.ReadOnly);
            var c = store.Certificates.Find(mFindType, mFindTerm, mValidOnly);
            var selectedCertificate = X509Certificate2UI.SelectFromCollection(
                c,
                "Client Certificate",
                "Choose a client certificate for this session",
                X509SelectionFlag.SingleSelection);
            if (selectedCertificate != null)
            {
                if (selectedCertificate.Count > 0)
                {
                    mCert = selectedCertificate[0];
                    if (CertificateChosen != null)
                    {
                        CertificateChosen(mCert);
                    }
                }
                else
                {
                    if (CertificateNotChosen != null)
                    {
                        CertificateNotChosen();
                    }
                }
            }
        }

 
    }

    public interface IRemoteCertificateHelper
    {
        bool ValidateRemoteCertificate();
    }
}
