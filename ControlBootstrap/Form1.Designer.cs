namespace ControlBootstrap
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.clientCertificatePrompt1 = new Mangrove.Security.X509.Controls.ClientCertificatePrompt(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // clientCertificatePrompt1
            // 
            this.clientCertificatePrompt1.FindTerm = "Fiddler";
            this.clientCertificatePrompt1.FindType = System.Security.Cryptography.X509Certificates.X509FindType.FindByIssuerName;
            this.clientCertificatePrompt1.Location = System.Security.Cryptography.X509Certificates.StoreLocation.CurrentUser;
            this.clientCertificatePrompt1.Store = System.Security.Cryptography.X509Certificates.StoreName.My;
            this.clientCertificatePrompt1.ValidOnly = true;
            this.clientCertificatePrompt1.CertificateChosen += new Mangrove.Security.X509.Controls.CertificateChosenHandler(this.clientCertificatePrompt1_CertificateChosen);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(51, 123);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "show dialog";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Mangrove.Security.X509.Controls.ClientCertificatePrompt clientCertificatePrompt1;
        private System.Windows.Forms.Button button1;
    }
}

