using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Drawing.Drawing2D;


namespace RSSTray
{
    public partial class fmMain : Form
    {

        private int fWidth, fHeight;

        RssListView lvRss = new RssListView();
        List<string> URLS = new List<string>();

        public fmMain()
        {

            InitializeComponent();

            lvRss.Parent = this;
            lvRss.Dock = DockStyle.Top;
            lvRss.View = View.Details;
            lvRss.FullRowSelect = true;
           
            

            RSSFeedCollection feeds = GetRssFeedsFromConfig();

            for (int i = 0; i < feeds.Count; i++)
            {
                URLS.Add(feeds[i].FeedURL);
            }
            Rectangle rect = Screen.PrimaryScreen.WorkingArea;
            this.Left = rect.Width - fWidth;
            this.Top = rect.Height - fHeight;
            fWidth = Properties.Settings.Default.Width;
            fHeight = Properties.Settings.Default.Height;
            //this.Visible = false;
           // lvRss.SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint, true);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void closeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            HideWindow();
        
        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RestoreWindow();
        }

        private void fmMain_Load(object sender, EventArgs e)
        {
          
           // WindowState = FormWindowState.Minimized;
            RefreshFeeds();
        }


        private void RestoreWindow()
        {          
            Rectangle rect = Screen.PrimaryScreen.WorkingArea;
            this.Left = rect.Width - fWidth;
            this.Top = rect.Height - fHeight;
            Width = fWidth;
            Height = fHeight; 
            WindowState = FormWindowState.Normal;
         
        }

        private void HideWindow()
        {
            fWidth = Math.Max(200, Width);
            fHeight = Math.Max(200, Height);
           // WindowState = FormWindowState.Minimized;
        }
        private void fmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            // don't save window settings that are too small...
            Properties.Settings.Default.Width = Math.Max(200, fWidth);
            Properties.Settings.Default.Height = Math.Max(200, fHeight);
            Properties.Settings.Default.Save();
        }


        private void RefreshFeeds()
        {

            lvRss.Items.Clear();
            lvRss.Columns.Add("");
            
            foreach (string url in URLS){
                RefreshSingleFeed(url);
            }
            lvRss.Columns[0].Width = -2;
            
        


  }


        private void RefreshSingleFeed(string URL)
        {
           DataSet ds = new DataSet();
            ds.ReadXml(URL);
            dgRSS.Columns.Clear();

            dgRSS.Columns.Add("Title", "Title");
  
            for (int k = 0; k < ds.Tables.Count; k++)
            {
                DataTable dtable = ds.Tables[k];
                if(dtable.TableName == "item"){
                    for (int i = 0; i < dtable.Rows.Count; i++)
                    {
                        DataRow drow = dtable.Rows[i];
                        if (drow.RowState != DataRowState.Deleted)
                        {
                            ListViewItem lvi = new ListViewItem(drow["title"].ToString());
                            

                            lvi.SubItems.Add(drow["description"].ToString());
                            lvi.SubItems.Add(drow["link"].ToString());
                            //lvi.SubItems.Add(drow["pubDate"].ToString());                   

                            // Add the list items to the ListView
                            lvRss.Items.Add(lvi);


                            dgRSS.Rows.Add();
                            dgRSS.Rows[i].Cells[0].Value = drow["title"].ToString() + "<br/>"+ drow["description"].ToString();
                        }
                    }

                }
     

            }


           

        }


        private void NotifyRSSTray_DoubleClick(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                RestoreWindow();
            }
            else
            {
                HideWindow();
            }
        }


        private static RSSFeedCollection GetRssFeedsFromConfig()
        {
            RSSFeedConfiguration config = (RSSFeedConfiguration)ConfigurationManager.GetSection("RSSFeedConfiguration");
            return config.RSSFeeds;    
           
        }



    }
}
