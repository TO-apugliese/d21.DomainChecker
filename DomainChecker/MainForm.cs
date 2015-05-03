using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GetActicePages
{
    public partial class MainForm : Form
    {
        #region Konstruktor
        public MainForm()
        {
            InitializeComponent();
            FormTitle = "Domain Checker";

            pbFortschritt.Value = 0;
            backgroundWorker1.WorkerSupportsCancellation = true;
            backgroundWorker1.WorkerReportsProgress = true;

            DomainList = new List<string>();
        }
        #endregion

        #region Properties
        private List<string> DomainList { get; set; }
        private List<export> exportList { get; set; }
        private string FormTitle { get; set; }
        #endregion

        #region Help functions
        public PingReply PingDomain(string domain)
        {
            Ping sender = new Ping();
            PingReply reply = null;

            try
            {
                reply = sender.Send(domain);
            }
            catch (Exception)
            {
            }

            return reply;
        }

        public void addItemsToList(string path)
        {
            StreamReader sr = new StreamReader(path);

            String dataString = sr.ReadToEnd();

            StringBuilder sb = new StringBuilder();
            dataString = dataString.Replace("\r\n", ",");
            String[] dataRows = dataString.Split(',');

            this.DomainList = dataRows.Where(x => x != string.Empty).Distinct().ToList();

            foreach (var domain in this.DomainList)
            {
                lbAllDomains.Items.Add(domain);
            }

            lblAllDomainsCount.Text = "Alle Domains: " + this.DomainList.Count;
            lblPercProgress.Text = "0 von " + this.DomainList.Count;

            this.Refresh();
        }

        private void closeApplication()
        {
            if (backgroundWorker1.IsBusy)
            {
                backgroundWorker1.CancelAsync();
            }

            Application.Exit();
        }

        //public string printPingReply(PingReply reply)
        //{
        //    StringBuilder sb = new StringBuilder();

        //    foreach (var item in reply.GetType().GetProperties())
        //    {
        //        sb.AppendFormat("{0}: {1} \n", item.Name, GetPropValue(reply, item.Name));
        //    }

        //    return sb.ToString();
        //}

        //public static object GetPropValue(object src, string propName)
        //{
        //    return src.GetType().GetProperty(propName).GetValue(src);
        //}
        #endregion

        #region Form Reset functions
        public void resetForm()
        {
            resetLabels();

            resetListBoxes();

            resetButtons();

            txtPath.Text = string.Empty;

            pbFortschritt.Value = 0;
        }

        public void resetLabels()
        {
            lblAllDomainsCount.Text = "Anzahl aller Domains: ";
            lblActiveDomainsCount.Text = "Anzahl aller aktiven Domains: ";
            lblInactiveDomainsCount.Text = "Anzahl aller inaktiven Domains: ";
            lblPercProgress.Text = "0 von 0";
        }

        public void resetListBoxes()
        {
            lbAllDomains.Items.Clear();
            lbActiveDomains.Items.Clear();
            lbInactiveDomains.Items.Clear();
        }

        public void resetButtons()
        {
            btnCheckDomains.Enabled = false;
            btnExport.Enabled = false;
        }
        #endregion

        #region Handler
        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            resetForm();
            // Create an instance of the open file dialog box.
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            // Set filter options and filter index.
            openFileDialog1.Filter = "CSV (.csv)|*.csv|All Files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;

            openFileDialog1.Multiselect = false;

            // Call the ShowDialog method to show the dialog box.
            DialogResult result = openFileDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                txtPath.Text = openFileDialog1.FileName;
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            lbAllDomains.Items.Clear();

            addItemsToList(txtPath.Text);

            if (lbAllDomains.Items.Count > 0)
            {
                btnCheckDomains.Enabled = true;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            resetForm();
        }

        private void btnCheckDomains_Click(object sender, EventArgs e)
        {
            btnImport.Enabled = false;
            btnOpenFile.Enabled = false;
            btnReset.Enabled = false;

            pbFortschritt.Maximum = DomainList.Count;
            lblActiveDomainsCount.Text = "Anzahl aller aktiven Domains: ";
            lblInactiveDomainsCount.Text = "Anzahl aller inaktiven Domains: ";
            this.Refresh();
            lbActiveDomains.Items.Clear();
            lbInactiveDomains.Items.Clear();

            backgroundWorker1.RunWorkerAsync(this.DomainList);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            closeApplication();         
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            closeApplication();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            // Create an instance of the open file dialog box.
            SaveFileDialog fd = new SaveFileDialog();
            exportList = exportList.OrderBy(x => x.pingReply.Status).ToList();

            // Set filter options and filter index.
            fd.Filter = "CSV (.csv)|*.csv";
            fd.FilterIndex = 1;

            // Call the ShowDialog method to show the dialog box.
            DialogResult result = fd.ShowDialog();
            StringBuilder sb = new StringBuilder();

            if (result == System.Windows.Forms.DialogResult.OK)
            {
                sb.AppendFormat("{0};{1};{2}", "Domain", "IP", "Ping Antwort \n");

                foreach (var export in exportList)
                {
                    sb.AppendFormat("{0};{1};{2}", export.domain, export.adress, export.pingReply.Status + "\n");
                }

                StreamWriter sw = new StreamWriter(fd.FileName);
                sw.Write(sb.ToString());

                sw.Close();
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            List<export> exportList = new List<export>();
            List<string> domains = e.Argument as List<string>;
            int count = 0;

            if (domains != null)
            {
                foreach (var domain in domains)
                {
                    count++;

                    if (this.backgroundWorker1.CancellationPending)
                    {
                        e.Cancel = true;
                        return;
                    }

                    backgroundWorker1.ReportProgress(count);

                    PingReply result = PingDomain(domain);
                    IPAddress[] adresses = null;
                    string adressesAsString = string.Empty;

                    try
                    {
                        adresses = Dns.GetHostAddresses(domain);
                    }
                    catch (Exception)
                    {
                    }

                    if (adresses != null)
                    {
                        bool isFirst = true;
                        foreach (var adress in adresses)
                        {
                            if (!isFirst)
                            {
                                adressesAsString += ", " + adress;
                            }
                            else
                            {
                                isFirst = false;
                                adressesAsString += adress;
                            }

                        }

                    }

                    exportList.Add(new export { domain = domain, adress = adressesAsString, pingReply = result });
                }
            }

            e.Result = exportList;
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            pbFortschritt.Value = e.ProgressPercentage;

            string progressText = pbFortschritt.Value + " von " + pbFortschritt.Maximum;
            string progressTextTitle = FormTitle + ": " + pbFortschritt.Value + " von " + pbFortschritt.Maximum;

            lblPercProgress.Text = pbFortschritt.Value + " von " + pbFortschritt.Maximum;
            this.Text = progressTextTitle;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.exportList = e.Result as List<export>;

            foreach (var exportItem in this.exportList)
            {
                if (exportItem != null)
                {
                    if (exportItem.pingReply.Status == IPStatus.Success)
                    {
                        lbActiveDomains.Items.Add(exportItem.domain + " (" + exportItem.adress + ")");
                    }
                    else
                    {
                        lbInactiveDomains.Items.Add(exportItem.domain + " (" + exportItem.adress + ")");
                    }
                }
            }

            if (lbActiveDomains.Items.Count > 0 || lbInactiveDomains.Items.Count > 0)
            {
                btnExport.Enabled = true;
            }

            lblActiveDomainsCount.Text = "Anzahl aller aktiven Domains: " + lbActiveDomains.Items.Count;
            lblInactiveDomainsCount.Text = "Anzahl aller inaktiven Domains: " + lbInactiveDomains.Items.Count;

            btnImport.Enabled = true;
            btnOpenFile.Enabled = true;
            btnReset.Enabled = true;
        }
        #endregion
    }
}
