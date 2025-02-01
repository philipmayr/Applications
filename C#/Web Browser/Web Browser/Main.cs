using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Net.NetworkInformation;

namespace Web_Browser
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            
            NetworkChange.NetworkAvailabilityChanged += new NetworkAvailabilityChangedEventHandler(NetworkAvailabilityChanged);
              
            WebBrowser.CanGoBackChanged += new EventHandler(WebBrowser_CanGoBackChanged);
            WebBrowser.CanGoForwardChanged += new EventHandler(WebBrowser_CanGoForwardChanged);
            WebBrowser.DocumentTitleChanged += new EventHandler(WebBrowser_DocumentTitleChanged);
            WebBrowser.StatusTextChanged += new EventHandler(WebBrowser_StatusTextChanged);
        }

        private void NetworkAvailabilityChanged(object sender, EventArgs e)
        {
            if (NetworkInterface.GetIsNetworkAvailable()) MessageBox.Show("Connected", "Network", MessageBoxButtons.OK, MessageBoxIcon.Information); else MessageBox.Show("Not Connected", "Network", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void GoBackButton_Click(object sender, EventArgs e)
        {
            WebBrowser.GoBack();
            WebBrowser.Select();
        }

        private void GoForwardButton_Click(object sender, EventArgs e)
        {
            WebBrowser.GoForward();
            WebBrowser.Select();
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            WebBrowser.Stop();
            WebBrowser.Select();
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            if (!WebBrowser.Url.Equals("about:blank")) WebBrowser.Refresh();
            WebBrowser.Select();
        }

        private void URLComboBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Escape) e.SuppressKeyPress = true;
            if (e.KeyCode == Keys.Enter && URLComboBox.Text.Trim() != string.Empty)
            {
                WebBrowser.Navigate(URLComboBox.Text.Trim());
                WebBrowser.Select();
                StopButton.Enabled = true;
                RefreshButton.Enabled = true;
            }
        }
        private void WebBrowser_CanGoBackChanged(object sender, EventArgs e)
        {
            GoBackButton.Enabled = WebBrowser.CanGoBack;
        }

        private void WebBrowser_CanGoForwardChanged(object sender, EventArgs e)
        {
            GoForwardButton.Enabled = WebBrowser.CanGoForward;
        }

        private void WebBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if (WebBrowser.ReadyState == WebBrowserReadyState.Complete)
            {
                URLComboBox.Text = e.Url.AbsoluteUri;
                URLComboBox.Items.Insert(0, e.Url.AbsoluteUri);
            }
        }

        private void WebBrowser_DocumentTitleChanged(object sender, EventArgs e)
        {
            Text = (WebBrowser.DocumentTitle != string.Empty ? WebBrowser.DocumentTitle : WebBrowser.Document.Domain) + " - Web Browser";
        }

        private void WebBrowser_NewWindow(object sender, CancelEventArgs e)
        {
            e.Cancel = true;
            Main newWindow = new Main();
            newWindow.StartPosition = FormStartPosition.CenterScreen;
            newWindow.WebBrowser.Navigate(WebBrowser.Document.ActiveElement.GetAttribute("href"));
            newWindow.WebBrowser.Select();
            newWindow.Show();
        }

        private void WebBrowser_ProgressChanged(object sender, WebBrowserProgressChangedEventArgs e)
        {
            ToolStripProgressBar.Maximum = (int) e.MaximumProgress;
            ToolStripProgressBar.Value = (int) e.CurrentProgress;
        }

        private void WebBrowser_StatusTextChanged(object sender, EventArgs e)
        {
            ToolStripStatusLabel.Text = WebBrowser.StatusText;
        }
    }
}
