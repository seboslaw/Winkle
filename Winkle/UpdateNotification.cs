using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Winkle
{
    public partial class UpdateNotification : Form
    {
        private string updateDownloadLink = "";

        public UpdateNotification()
        {
            InitializeComponent();
        }

        public bool setVersion(string appName, string versionText)
        {
            this.NewVersionAvailable.Text = "Version " + versionText + " of " + appName + " available";
            return true;
        }

        public bool setDescription( string descriptionText)
        {
            this.description.Text = descriptionText;
            return true;
        }

        public bool setDownloadLink(string downloadLinkText)
        {
            this.updateDownloadLink = downloadLinkText;
            return true;
        }

        private void buttonGetUpdate_Click(object sender, EventArgs e)
        {
            if (this.updateDownloadLink.StartsWith("http://") || this.updateDownloadLink.StartsWith("https://"))
                {
                    System.Diagnostics.Process.Start(updateDownloadLink);
                }
        }

        private void buttonIgnore_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
