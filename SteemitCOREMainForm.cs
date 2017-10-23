using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;  
using System.Threading.Tasks;  
using HtmlAgilityPack;  
using System.Net;
using System.Text.RegularExpressions;
using System.Threading;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;

namespace SteemitCOREINFO
{
    public partial class SteemitCOREMainForm : Form
    {
        public SteemitCOREMainForm()
        {
            InitializeComponent();
            toolStripStatusLabel1.IsLink = true;
            check = new ToolCheckBox();
        }

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int SendMessage(IntPtr hWnd, int msg, int wParam, int lParam);
        ToolCheckBox check = null;

        private void SetProgressBars()
        {
            if (pbBandwith.Value <= 30)
            {
                SendMessage(this.pbBandwith.Handle, 0x410, 2, 0);
            }

            if (pbBandwith.Value >= 31 && pbBandwith.Value <= 60)
            {
                SendMessage(this.pbBandwith.Handle, 0x410, 3, 0);
            }

            if (pbBandwith.Value >= 61 && pbBandwith.Value <= 100)
            {
                SendMessage(this.pbBandwith.Handle, 0x410, 1, 0);
            }

            if (pbVoting.Value <= 30)
            {
                SendMessage(this.pbVoting.Handle, 0x410, 2, 0);
            }

            if (pbVoting.Value >= 31 && pbBandwith.Value <= 60)
            {
                SendMessage(this.pbVoting.Handle, 0x410, 3, 0);
            }

            if (pbVoting.Value >= 61 && pbBandwith.Value <= 100)
            {
                SendMessage(this.pbVoting.Handle, 0x410, 1, 0);
            }
        }

        private void WaitNSeconds(int sec)
        {
            if (sec < 1) return;
            DateTime _desired = DateTime.Now.AddSeconds(sec);
            while (DateTime.Now < _desired)
            {
                Thread.Sleep(1);
                System.Windows.Forms.Application.DoEvents();
            }
        }

        private void NotifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
                if (this.WindowState == FormWindowState.Minimized)
                    this.WindowState = FormWindowState.Normal;
                this.Activate();
        }

        public string res = null;

        public class ReturnedData
        {
            public string Vests { get; set; }
            public string Steem { get; set; }
            public string Sbd { get; set; }
            public string TotalSP { get; set; }
            public string SPdelegation { get; set; }
            public string Bandwith { get; set; }
            public string Reputation { get; set; }
            public string Voting { get; set; }
            public string Posts { get; set; }
            public string Age { get; set; }
            public string Seconds { get; set; }
            public string Minutes { get; set; }
            public string Hours { get; set; }
            public string Days { get; set; }
            public string Status { get; set; }
            public string Upvote { get; set; }
            public string CurrentUpvote { get; set; }
        }

        private void ToolStripButton1_Click(object sender, EventArgs e)
        {
            if (txtUser.Text.Trim() != String.Empty)
            {
                lblStatusBar.Text = "Getting info, user @" + txtUser.Text + ", please wait..";
                progressStatus.Style = ProgressBarStyle.Marquee;
                CheckUserInfoAsync();
            }
            else
            {
                lblStatusBar.Text = "Please enter STEEM user, then press 'get info' button.";
                txtUser.Focus();
            }
           
        }

        public class ToolCheckBox : ToolStripControlHost
        {
            public ToolCheckBox() : base(new CheckBox()) { }

            public CheckBox CheckBoxControl
            {
                get
                {
                    return Control as CheckBox;
                }
            }

            protected override void OnSubscribeControlEvents(Control c)
            {
                base.OnSubscribeControlEvents(c);
                CheckBox checkBox = (CheckBox)c;
                checkBox.BackColor = Color.Transparent; 
            }

            protected override void OnUnsubscribeControlEvents(Control c)
            {
                base.OnUnsubscribeControlEvents(c);
                CheckBox checkBox = (CheckBox)c;
            }
        }

        public async void CheckUserInfoAsync()
        {
            Task<ReturnedData> taskAsync = GetUserInfo(txtUser.Text);
            await taskAsync;

            if (taskAsync.IsCompleted)
            {
                if (taskAsync.Result.Status == "OK")
                {
                    lblVests.Text = taskAsync.Result.Vests;
                    lblSteem.Text = taskAsync.Result.Steem;
                    lblSBD.Text = taskAsync.Result.Sbd;
                    lblTotalSP.Text = taskAsync.Result.TotalSP;
                    lblSPDeleg.Text = taskAsync.Result.SPdelegation;
                    lblBandwith.Text = taskAsync.Result.Bandwith;
                    lblReputation.Text = taskAsync.Result.Reputation;
                    lblVoting.Text = taskAsync.Result.Voting;
                    lblPosts.Text = taskAsync.Result.Posts;
                    lblAge.Text = taskAsync.Result.Age;
                    lblSeconds.Text = taskAsync.Result.Seconds;
                    lblMinutes.Text = taskAsync.Result.Minutes;
                    lblHours.Text = taskAsync.Result.Hours;
                    lblDays.Text = taskAsync.Result.Days;
                    lblUpvote.Text = taskAsync.Result.Upvote;
                    lblCurrUpvote.Text = taskAsync.Result.CurrentUpvote;
                    lblStatusBar.Text = "Finished, " + taskAsync.Result.Status + ", waiting 5 min before next check..";
                    progressStatus.Style = ProgressBarStyle.Blocks;
                    pbVoting.Value = (int)(Convert.ToDouble(taskAsync.Result.Voting) * 1.0f);
                    pbBandwith.Value = (int)(Convert.ToDouble(taskAsync.Result.Bandwith) * 1.0f);
                    SetProgressBars();
                    pbVoting.Refresh();
                    pbBandwith.Refresh();
                    WaitNSeconds(300);
                }

                else
                {
                    lblStatusBar.Text = taskAsync.Result.Status;
                    progressStatus.Style = ProgressBarStyle.Blocks;
                }
            }
            else
            {
                CheckUserInfoAsync();
            }
        }

        private static Task<ReturnedData> GetUserInfo(string user)
        {
            return Task<ReturnedData>.Factory.StartNew(() =>
            {
                var returnValue = new ReturnedData();
               
                HtmlAgilityPack.HtmlDocument htmlDoc = new HtmlAgilityPack.HtmlDocument
                {
                    OptionFixNestedTags = true
                };

                //steemd.com
                string urlToLoad = "http://steemd.com/@" + user;
                HttpWebRequest request = HttpWebRequest.Create(urlToLoad) as HttpWebRequest;
                request.Method = "GET";

                /* Sart browser signature */
                request.UserAgent = "Mozilla/5.0 (Windows NT 6.3; WOW64; rv:31.0) Gecko/20100101 Firefox/31.0";
                request.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8";
                request.Headers.Add(HttpRequestHeader.AcceptLanguage, "en-us,en;q=0.5");
                /* Sart browser signature */

                try
                {
                    Console.WriteLine(request.RequestUri.AbsoluteUri);
                    WebResponse response = request.GetResponse();
                    htmlDoc.Load(response.GetResponseStream(), true);
                }

                catch (Exception ex)
                {
                    returnValue.Status = ex.Message;
                    return returnValue;
                }

                if (htmlDoc.DocumentNode != null)
                {
                    var articleNodes = htmlDoc.DocumentNode.SelectNodes("/html[1]/body[1]/div[1]/div[1]/div[1]/div[1]");

                    string text = null;
                    string v_vests = null;
                    string v_steem = null;
                    string v_sbd = null;
                    string v_totalSP = null;
                    string v_spDelegation = null;
                    string v_voting = null;
                    string v_bandwith = null;
                    string v_reputation = null;
                    string v_age = null;
                    string v_posts = null;
                    string v_upvote = null;
                    string v_currUpvote = null;

                    if (articleNodes != null && articleNodes.Any())
                    {
                        foreach (var articleNode in articleNodes)
                        {
                            v_vests = htmlDoc.DocumentNode.SelectSingleNode("/html[1]/body[1]/div[1]/div[1]/span[1]/text()[1]").InnerText; // vests
                            v_vests = v_vests.Replace("\n", "");
                            v_vests = v_vests.Replace("VESTS", "");
                            v_vests = v_vests.Replace(" ", "");

                            text = htmlDoc.DocumentNode.SelectSingleNode("/html[1]/body[1]/div[1]/div[1]/span[1]/text()[2]").InnerText;
                          
                            if (text.Contains("STEEM"))
                            {
                                v_steem = text.Replace("\n", "");
                                v_steem = v_steem.Replace("STEEM", "");
                                v_steem = v_steem.Replace(" ", "");

                                v_sbd = htmlDoc.DocumentNode.SelectSingleNode("/html[1]/body[1]/div[1]/div[1]/span[1]/text()[3]").InnerText; // sbd
                                v_sbd = v_sbd.Replace("\n", "");
                                v_sbd = v_sbd.Replace(" ", "");
                            }
                            else
                            {
                                v_steem = htmlDoc.DocumentNode.SelectSingleNode("/html[1]/body[1]/div[1]/div[1]/span[1]/text()[3]").InnerText; // steem
                                v_steem = v_steem.Replace("\n", "");
                                v_steem = v_steem.Replace("STEEM", "");
                                v_steem = v_steem.Replace(" ", "");

                                if (htmlDoc.DocumentNode.SelectSingleNode("/html[1]/body[1]/div[1]/div[1]/span[1]/text()[4]") != null)
                                {
                                    v_sbd = htmlDoc.DocumentNode.SelectSingleNode("/html[1]/body[1]/div[1]/div[1]/span[1]/text()[4]").InnerText; // sbd
                                    v_sbd = v_sbd.Replace("\n", "");
                                    v_sbd = v_sbd.Replace(" ", "");
                                }
                            }

                            v_totalSP = htmlDoc.DocumentNode.SelectSingleNode("/html[1]/body[1]/div[1]/div[1]/div[1]/div[1]/div[1]/p[1]/text()[1]").InnerText; // SP total
                            v_totalSP = v_totalSP.Replace("\n", "");
                            v_totalSP = v_totalSP.Replace(" ", "");

                            v_totalSP = new String(v_totalSP.Where(c => char.IsDigit(c)).ToArray());

                            v_spDelegation = htmlDoc.DocumentNode.SelectSingleNode("/html[1]/body[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]").InnerText; // SP + delegation

                            if (v_spDelegation.Contains("%"))
                            {
                                v_voting = v_spDelegation.Replace("\n", "");
                                v_voting = v_voting.Replace("%", "");
                                v_voting = v_voting.Replace(" ", "");
                                v_voting = v_voting.Replace(".", ",");
                            }

                            else
                            {
                                v_spDelegation = v_spDelegation.Replace("\n", "");
                                v_spDelegation = v_spDelegation.Replace("SP", "");
                                v_spDelegation = v_spDelegation.Replace(" ", "");
                            }

                            if (!v_spDelegation.Contains("%"))
                            {
                                v_voting = htmlDoc.DocumentNode.SelectSingleNode("/html[1]/body[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[2]").InnerText; // voting power
                                v_voting = v_voting.Replace("\n", "");
                                v_voting = v_voting.Replace("%", "");
                                v_voting = v_voting.Replace(" ", "");
                                v_voting = v_voting.Replace(".", ",");

                                v_bandwith = htmlDoc.DocumentNode.SelectSingleNode("/html[1]/body[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[3]").InnerText; // bandwith remaining
                                v_bandwith = v_bandwith.Replace("\n", "");
                                v_bandwith = v_bandwith.Replace("%", "");
                                v_bandwith = v_bandwith.Replace(" ", "");
                                v_bandwith = v_bandwith.Replace(".", ",");

                                v_reputation = htmlDoc.DocumentNode.SelectSingleNode("/html[1]/body[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[5]/div[1]/p[1]").InnerText; // reputation
                                v_reputation = v_reputation.Replace("\n", "");
                                v_reputation = v_reputation.Replace(" ", "");

                                v_posts = htmlDoc.DocumentNode.SelectSingleNode("/html[1]/body[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[5]/div[1]/div[1]/text()[1]").InnerText; // number of posts
                                v_posts = v_posts.Replace("\n", "");
                                v_posts = v_posts.Replace(" ", "");

                                v_posts = new String(v_posts.Where(c => char.IsDigit(c)).ToArray());

                                v_age = htmlDoc.DocumentNode.SelectSingleNode("/html[1]/body[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[5]/div[2]/p[1]").InnerText; // age
                                v_age = v_age.Replace("\n", "");
                                v_age = v_age.Replace(" ", "");

                                v_age = new String(v_age.Where(c => char.IsDigit(c)).ToArray());
                            }
                            else
                            {
                                v_bandwith = htmlDoc.DocumentNode.SelectSingleNode("/html[1]/body[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[2]").InnerText; // bandwith remaining
                                v_bandwith = v_bandwith.Replace("\n", "");
                                v_bandwith = v_bandwith.Replace("%", "");
                                v_bandwith = v_bandwith.Replace(" ", "");
                                v_bandwith = v_bandwith.Replace(".", ",");

                                v_reputation = htmlDoc.DocumentNode.SelectSingleNode("/html[1]/body[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[4]/div[1]/p[1]").InnerText; // reputation
                                v_reputation = v_reputation.Replace("\n", "");
                                v_reputation = v_reputation.Replace(" ", "");

                                v_posts = htmlDoc.DocumentNode.SelectSingleNode("/html[1]/body[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[4]/div[1]/div[1]/text()[1]").InnerText; // number of posts
                                v_posts = v_posts.Replace("\n", "");
                                v_posts = v_posts.Replace(" ", "");

                                v_posts = new String(v_posts.Where(c => char.IsDigit(c)).ToArray());

                                v_age = htmlDoc.DocumentNode.SelectSingleNode("/html[1]/body[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[4]/div[2]/p[1]").InnerText; // age
                                v_age = v_age.Replace("\n", "");
                                v_age = v_age.Replace(" ", "");

                                v_age = new String(v_age.Where(c => char.IsDigit(c)).ToArray());

                                v_spDelegation = v_totalSP;
                            }
                        }
                    }

                    float upvote = (float)Convert.ToDouble(v_voting);

                    float totalSeconds = (float)(Convert.ToDouble(100) - upvote) * (float)Convert.ToDouble(43.2) / (float)Convert.ToDouble(0.01);
                    float totalMinutes = totalSeconds / (float)Convert.ToDouble(60);
                    float totalHours = totalMinutes / (float)Convert.ToDouble(60);
                    float totalDays = totalHours / (float)Convert.ToDouble(24);

                    //steemdollar.com
                    htmlDoc = new HtmlAgilityPack.HtmlDocument
                    {
                        OptionFixNestedTags = true
                    };

                    urlToLoad = "http://www.steemdollar.com/dollar_per_vote.php?name=" + user;
                    request = HttpWebRequest.Create(urlToLoad) as HttpWebRequest;
                    request.Method = "GET";

                    /* Sart browser signature */
                    request.UserAgent = "Mozilla/5.0 (Windows NT 6.3; WOW64; rv:31.0) Gecko/20100101 Firefox/31.0";
                    request.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8";
                    request.Headers.Add(HttpRequestHeader.AcceptLanguage, "en-us,en;q=0.5");
                    /* Sart browser signature */

                    try
                    {
                        Console.WriteLine(request.RequestUri.AbsoluteUri);
                        WebResponse response = request.GetResponse();
                        htmlDoc.Load(response.GetResponseStream(), true);
                    }

                    catch (Exception ex)
                    {
                        returnValue.Status = ex.Message;
                        return returnValue;
                    }

                    if (htmlDoc.DocumentNode != null)
                    {
                        var articleNodesD = htmlDoc.DocumentNode.SelectNodes("/html[1]/body[1]/div[3]/section[1]/div[3]");

                        if (articleNodes != null && articleNodesD.Any())
                        {
                            foreach (var articleNode in articleNodes)
                            {
                                v_currUpvote = htmlDoc.DocumentNode.SelectSingleNode("/html[1]/body[1]/div[3]/section[1]/div[3]/h2[1]/strong[1]/text()[1]").InnerText; // vests
                                v_currUpvote = v_currUpvote.Replace("\n", "");
                                v_currUpvote = v_currUpvote.Replace(" ", "");

                                v_upvote = htmlDoc.DocumentNode.SelectSingleNode("/html[1]/body[1]/div[3]/section[1]/div[3]/strong[2]/text()[1]").InnerText; // vests
                                v_upvote = v_upvote.Replace("\n", "");
                                v_upvote = v_upvote.Replace(" ", "");
                            }
                        }
                    }

                    returnValue.Seconds = "" + totalSeconds;
                    returnValue.Minutes = "" + totalMinutes;
                    returnValue.Hours = "" + totalHours;
                    returnValue.Days = "" + totalDays;
                    returnValue.Vests = v_vests;
                    returnValue.Steem = v_steem;
                    returnValue.Sbd = v_sbd;
                    returnValue.TotalSP = v_totalSP;
                    returnValue.SPdelegation = v_spDelegation;
                    returnValue.Voting = v_voting;
                    returnValue.Bandwith = v_bandwith;
                    returnValue.Reputation = v_reputation;
                    returnValue.Age = v_age;
                    returnValue.Posts = v_posts;
                    returnValue.Upvote = v_upvote;
                    returnValue.CurrentUpvote = v_currUpvote;
                    returnValue.Status = "OK";
                }

                return returnValue;

            });

        }

        private void ToolStripStatusLabel1_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.steemit.com/@steemitcore");
        }

        private void ToolStripButton3_Click(object sender, EventArgs e)
        {
            Process.Start("https://steemit.com/pick_account");
        }

        private void ToolStripButton4_Click(object sender, EventArgs e)
        {
            Process.Start("https://utopian.io");
        }

        private void BtnAbout_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Directory.GetCurrentDirectory() + "\\about.txt");
        }

        private void SteemitCOREMainForm_Resize(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Normal)
            {
                if (txtUser.Text.Trim() != String.Empty)
                {
                    notifyIcon1.Visible = true;
                    notifyIcon1.ShowBalloonTip(3000, "SteemitCORE v1.05", "User: " + txtUser.Text + "; " + lblSteem.Text + " STEEM, " + lblSBD.Text + " SBD, Current Upvote worth: " + lblCurrUpvote.Text, ToolTipIcon.Info);
                }
                else
                {
                    notifyIcon1.Visible = true;
                    notifyIcon1.ShowBalloonTip(3000, "SteemitCORE v1.05", "App minimized. Double click on icon to show app", ToolTipIcon.Info);
                }
            }
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            Process.Start("https://busy.org");
        }
    }
}
