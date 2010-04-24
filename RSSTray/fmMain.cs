using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RSSTray
{
    public partial class fmMain : Form
    {
        public fmMain()
        {
            InitializeComponent();
            this.Visible = false;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void closeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RestoreWindow();
        }

        private void fmMain_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
            Visible = false;
     
        }


        private void RestoreWindow()
        {
            Rectangle rect = new Rectangle();
            WindowState = FormWindowState.Normal;


            MessageBox.Show(this.Width.ToString());
            
            this.Left = Screen.PrimaryScreen.Bounds.Width  - this.Width;
   

       
        }
    }
}
