using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Apis;
using Google.Apis.Customsearch.v1;
using log4net;
using Google.Apis.Customsearch.v1.Data;
using System.Web;
using System.Net.Http;
using System.Net;
using System.IO;
using System.Diagnostics;
using HtmlAgilityPack;
using ARSoft.Tools.Net.Dns;
using System.Net.NetworkInformation;

namespace EmailAccountCheck
{
    public partial class Form1 : Form
    {
        Loading cs = new Loading();
        public Form1()
        {
            InitializeComponent();
        }

       

        private void Submit_Click(object sender, EventArgs e)
        {            
            cs.Show();
            this.Hide();
            DomainsListBox.Items.Clear();
            MXListBox.Items.Clear();
            DomainContainsMX.Items.Clear();
            DomainContainsMX.Items.Add("-----RESULT-----");
            var myList = new List<string>();
            var myList2 = new List<string>();
            if (Prop.RadioBoxOption == "GS")
            {

                StringBuilder sb = new StringBuilder();
                byte[] ResultsBuffer = new byte[8192];
                string SearchResults = "http://google.com/search?as_q=" + KeyWords.Text.Trim() + "&num=" + MinGSResult.Value;
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(SearchResults);
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();

                Stream resStream = response.GetResponseStream();
                string tempString = null;
                int count = 0;
                do
                {
                    count = resStream.Read(ResultsBuffer, 0, ResultsBuffer.Length);
                    if (count != 0)
                    {
                        tempString = Encoding.ASCII.GetString(ResultsBuffer, 0, count);
                        sb.Append(tempString);
                        cs.Refresh();
                    }
                }

                while (count > 0);
                string sbb = sb.ToString();

                HtmlAgilityPack.HtmlDocument html = new HtmlAgilityPack.HtmlDocument();
                html.OptionOutputAsXml = true;
                html.LoadHtml(sbb);
                HtmlNode doc = html.DocumentNode;

                foreach (HtmlNode link in doc.SelectNodes("//a[@href]"))
                {
                    cs.Refresh();
                    //HtmlAttribute att = link.Attributes["href"];
                    string hrefValue = link.GetAttributeValue("href", string.Empty);
                    //hrefValue.ToString().ToUpper().Contains("HTTP://")
                    if (hrefValue.ToString().Contains("/url?q="))
                    {
                        int index = hrefValue.IndexOf("&");
                        if (index > 0)
                        {
                            hrefValue = hrefValue.Substring(0, index);
                            hrefValue = hrefValue.Replace("/url?q=", "");
                            System.Uri uri = new Uri(hrefValue);
                            string uriWithoutScheme = uri.Host.Replace("www.", "");

                            if (!myList.Contains(uriWithoutScheme))
                            {
                                myList.Add(uriWithoutScheme);
                                DomainsListBox.Items.Add(uriWithoutScheme);
                            }
                            if (CheckIfContainsMXRecords(uriWithoutScheme))
                            {
                                if (!myList2.Contains(uriWithoutScheme))
                                {
                                    myList2.Add(uriWithoutScheme);
                                    DomainContainsMX.Items.Add(uriWithoutScheme);
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                string MSValue = KeyWords.Text;
                try
                {
                    System.Uri uri2 = new Uri(MSValue);
                    string uriWithoutScheme2 = uri2.Host.Replace("www.", "");
                    if (CheckIfContainsMXRecords(uriWithoutScheme2))
                    {
                        DomainContainsMX.Items.Add(uriWithoutScheme2);
                    }
                }
                catch (Exception ex)
                {
                    if (CheckIfContainsMXRecords(MSValue))
                    {
                        DomainContainsMX.Items.Add(MSValue);
                    }
                }

            }
            //Cursor.Current = Cursors.Default;
            this.Show();
            this.StartPosition = FormStartPosition.CenterScreen;
            cs.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.MinimizeBox = false;
            this.MinimizeBox = false;
            this.MaximizeBox = false;

            cs.StartPosition = FormStartPosition.CenterScreen;
            cs.FormBorderStyle = FormBorderStyle.FixedSingle;
            cs.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            cs.ControlBox = false;

            GSQuery.Checked = true;
            GSorMSLabel.Text = "Please Enter Search Query";
            Prop.RadioBoxOption = "GS";
            MXFind1.Text = "mxbiz1.qq.com";
            MXFind1.ReadOnly = true;
            MXFind1.BackColor = Color.DimGray;
            MXFind1.TabStop = false;
            MXFind1.Cursor = Cursors.Arrow;

            MXFind2.Text = "mxbiz2.qq.com";
            MXFind2.ReadOnly = true;
            MXFind2.BackColor = Color.DimGray;
            MXFind2.TabStop = false;
            MXFind2.Cursor = Cursors.Arrow;

            MinGSResult.Value = 100;
            MinGSResult.Maximum = 1000;
            MinGSResult.Minimum = 1;

            SecsData.Value = 2;
            SecsData.Maximum = 25;
            SecsData.Minimum = 1;
            SecsData.Increment = 0.1M;
            MaxSecLabel.Text = "";

            OpenFileButton.Enabled = false;
            Submit.Enabled = true;
            MinGSResult.Enabled = true;
            SecsData.Enabled = false;
            KeyWords.Enabled = true;
        }

        private void GSQuery_CheckedChanged(object sender, EventArgs e)
        {
            GSorMSLabel.Text = "Please Enter Search Query";
            Prop.RadioBoxOption = "GS";
            OpenFileButton.Enabled = false;
            Submit.Enabled = true;
            MinGSResult.Enabled = true;
            SecsData.Enabled = false;
            KeyWords.Enabled = true;
            MaxSecLabel.Text = "";
        }

        private void ImportFile_CheckedChanged(object sender, EventArgs e)
        {
            GSorMSLabel.Text = "Import a File";
            Prop.RadioBoxOption = "IF";
            OpenFileButton.Enabled = true;
            Submit.Enabled = false;
            MinGSResult.Enabled = false;
            SecsData.Enabled = true;
            KeyWords.Enabled = false;
            MaxSecLabel.Text = "Maximum Seconds Each Domain";
        }

        private void ManualQuery_CheckedChanged(object sender, EventArgs e)
        {
            GSorMSLabel.Text = "Please Enter Domain Name";
            Prop.RadioBoxOption = "MS";
            OpenFileButton.Enabled = false;
            Submit.Enabled = true;
            MinGSResult.Enabled = false;
            SecsData.Enabled = false;
            KeyWords.Enabled = true;
            MaxSecLabel.Text = "";
        }

        private void ChangeOrNot_CheckedChanged(object sender, EventArgs e)
        {
            if (ChangeOrNot.Checked)
            {
                //MXFind1.Enabled = true;
                MXFind1.ReadOnly = false;
                MXFind1.BackColor = Color.White;
                MXFind1.TabStop = true;
                MXFind1.Cursor = Cursors.Default;

                //MXFind2.Enabled = true;
                MXFind2.ReadOnly = false;
                MXFind2.BackColor = Color.White;
                MXFind2.TabStop = true;
                MXFind2.Cursor = Cursors.Default;
            }
            else
            {
                //MXFind1.Enabled = false;
                MXFind1.ReadOnly = true;
                MXFind1.BackColor = Color.DimGray;
                MXFind1.TabStop = false;
                MXFind1.Cursor = Cursors.Arrow;

                //MXFind2.Enabled = false;
                MXFind2.ReadOnly = true;
                MXFind2.BackColor = Color.DimGray;
                MXFind2.TabStop = false;
                MXFind2.Cursor = Cursors.Arrow;
            }
        }

        private void DomainsListBox_MouseDoubleClick_1(object sender, MouseEventArgs e)
        {
            string text = DomainsListBox.GetItemText(DomainsListBox.SelectedItem);
            RedirectToWebBrowser redirect = new RedirectToWebBrowser();
            redirect.OpenBrowser(text);
        }

        private void SaveDomainsList_Click(object sender, EventArgs e)
        {
            if (DomainsListBox.Items.Count > 0)
            {
                string fileName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory),
                                   "SearchDomains.txt");
                System.IO.StreamWriter SaveFile = new System.IO.StreamWriter(fileName);
                foreach (var item in DomainsListBox.Items)
                {
                    SaveFile.WriteLine(item);
                }

                SaveFile.Close();

                MessageBox.Show("Program Saved as SearchDomains.txt in your Desktop");
            }
            else
            {
                MessageBox.Show("Unable to Save, No Items!");
            }
        }

        private void SaveMXListBox_Click(object sender, EventArgs e)
        {
            if (MXListBox.Items.Count > 0)
            {
                string fileName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory),
                                  "MXRecords.txt");
                System.IO.StreamWriter SaveFile = new System.IO.StreamWriter(fileName);
                foreach (var item in MXListBox.Items)
                {
                    SaveFile.WriteLine(item);
                }

                SaveFile.Close();

                MessageBox.Show("Program Saved as MXRecords.txt in your Desktop");
            }
            else
            {
                MessageBox.Show("Unable to Save, No Items!");
            }
        }

        private void DomainsContainsMXButton_Click(object sender, EventArgs e)
        {
            if (DomainContainsMX.Items.Count > 0)
            {
                string fileName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory),
                                 "MXRecords-Result.txt");
                System.IO.StreamWriter SaveFile = new System.IO.StreamWriter(fileName);
                foreach (var item in DomainContainsMX.Items)
                {
                    SaveFile.WriteLine(item);
                }

                SaveFile.Close();

                MessageBox.Show("Program Saved as MXRecords-Result.txt in your Desktop");
            }
            else
            {
                MessageBox.Show("Unable to Save, No Items!");
            }
        }

        private void OpenFileButton_Click(object sender, EventArgs e)
        {                        
            Stream myStream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;
     
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = openFileDialog1.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            DomainsListBox.Items.Clear();
                            MXListBox.Items.Clear();
                            DomainContainsMX.Items.Clear();
                            DomainContainsMX.Items.Add("-----RESULT-----");
                            cs.Show();
                            this.Hide();
                            FileInfo fInfo = new FileInfo(openFileDialog1.FileName);
                            string strFileName = fInfo.Name;
                            string strFilePath = fInfo.DirectoryName;
                            string combinedString = strFilePath + "\\" + strFileName;
                            //FolderBrowserDialog fbd = new FolderBrowserDialog(combinedString);

                            string[] linesTxt = File.ReadAllLines(combinedString);
                            var myList = new List<string>();
                            foreach (var s in linesTxt)
                            {
                                cs.Refresh();
                                if (!myList.Contains(s))
                                {
                                    myList.Add(s);
                                }

                            }

                            foreach (var x in myList)
                            {
                                cs.Refresh();
                                DomainsListBox.Items.Add(x);
                                if(CheckIfContainsMXRecords(x))
                                {
                                    DomainContainsMX.Items.Add(x);
                                }
                            }
                            this.Show();
                            this.StartPosition = FormStartPosition.CenterScreen;
                            cs.Hide();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }

        public string checkIfDown(string URL)
        {
            try
            {
                //Creating the HttpWebRequest
                HttpWebRequest request = WebRequest.Create("http://" + URL) as HttpWebRequest;
                //Setting the Request method HEAD, you can also use GET too.
                request.Method = "HEAD";
                request.Timeout = 2900;
                //Getting the Web Response.
                HttpWebResponse response = request.GetResponse() as HttpWebResponse;
                //Returns TRUE if the Status code == 200                
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    return "True";
                }
                return "False";
            }
            catch(WebException ex)
            {
                string s1 = ex.ToString();
                string s2 = "The remote name could not be resolved";
                bool b = s1.Contains(s2);
                if (b)
                {
                    return "remoteError";
                }
                //Any exception will returns false.
                return "False";
            }
        }

        public bool CheckIfContainsMXRecords(string URL)
        {            
            string checker = "True";
            try
            {
                if (!string.IsNullOrEmpty(URL))
                {
                    if (Prop.RadioBoxOption == "IF")
                    {
                        var task = Task.Run(() => checkIfDown(URL));
                        if (task.Wait(TimeSpan.FromSeconds(Prop.MaxSec)))
                            checker = checkIfDown(URL);
                        else
                        {
                            checker = "Down";
                        }

                        if (checker == "True" || checker == "remoteError")
                        {
                            var response = DnsClient.Default.Resolve(URL, RecordType.Mx);
                            var records = response.AnswerRecords.OfType<MxRecord>();
                            foreach (var record in records)
                            {
                                MXListBox.Items.Add(URL + " -> " + record.ExchangeDomainName);
                            }

                            foreach (var record in records)
                            {
                                if (record.ExchangeDomainName == MXFind1.Text || record.ExchangeDomainName == MXFind2.Text)
                                {
                                    return true;
                                }
                            }
                        }
                        else if (checker == "Down")
                        {
                            MXListBox.Items.Add(URL + " -> " + "Host Unreachable");
                            return false;
                        }
                        return false;
                    }
                    else if (Prop.RadioBoxOption == "GS" || Prop.RadioBoxOption == "MS")
                    {
                        var response = DnsClient.Default.Resolve(URL, RecordType.Mx);
                        var records = response.AnswerRecords.OfType<MxRecord>();
                        foreach (var record in records)
                        {
                            MXListBox.Items.Add(URL + " -> " + record.ExchangeDomainName);
                        }

                        foreach (var record in records)
                        {
                            if (record.ExchangeDomainName == MXFind1.Text || record.ExchangeDomainName == MXFind2.Text)
                            {
                                return true;
                            }
                        }
                    }                   
                }
                return false;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        private void SecsData_ValueChanged(object sender, EventArgs e)
        {
            Prop.MaxSec = Convert.ToDouble(SecsData.Value);
        }
    }
}
