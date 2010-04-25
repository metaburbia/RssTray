namespace RSSTray
{
    partial class fmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmMain));
            this.NotifyRSSTray = new System.Windows.Forms.NotifyIcon(this.components);
            this.menuContextMain = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgRSS = new System.Windows.Forms.DataGridView();
            this.menuContextMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgRSS)).BeginInit();
            this.SuspendLayout();
            // 
            // NotifyRSSTray
            // 
            this.NotifyRSSTray.ContextMenuStrip = this.menuContextMain;
            this.NotifyRSSTray.Icon = ((System.Drawing.Icon)(resources.GetObject("NotifyRSSTray.Icon")));
            this.NotifyRSSTray.Text = "NotifyRSSTray";
            this.NotifyRSSTray.Visible = true;
            this.NotifyRSSTray.DoubleClick += new System.EventHandler(this.NotifyRSSTray_DoubleClick);
            // 
            // menuContextMain
            // 
            this.menuContextMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showToolStripMenuItem,
            this.closeToolStripMenuItem1,
            this.toolStripMenuItem1,
            this.closeToolStripMenuItem});
            this.menuContextMain.Name = "menuContextMain";
            this.menuContextMain.Size = new System.Drawing.Size(104, 76);
            // 
            // showToolStripMenuItem
            // 
            this.showToolStripMenuItem.Name = "showToolStripMenuItem";
            this.showToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.showToolStripMenuItem.Text = "Show";
            this.showToolStripMenuItem.Click += new System.EventHandler(this.showToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem1
            // 
            this.closeToolStripMenuItem1.Name = "closeToolStripMenuItem1";
            this.closeToolStripMenuItem1.Size = new System.Drawing.Size(103, 22);
            this.closeToolStripMenuItem1.Text = "Close";
            this.closeToolStripMenuItem1.Click += new System.EventHandler(this.closeToolStripMenuItem1_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(100, 6);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.closeToolStripMenuItem.Text = "Exit";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // dgRSS
            // 
            this.dgRSS.AllowUserToResizeColumns = false;
            this.dgRSS.AllowUserToResizeRows = false;
            this.dgRSS.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgRSS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgRSS.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgRSS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgRSS.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgRSS.Location = new System.Drawing.Point(0, 215);
            this.dgRSS.Name = "dgRSS";
            this.dgRSS.RowHeadersVisible = false;
            this.dgRSS.ShowEditingIcon = false;
            this.dgRSS.Size = new System.Drawing.Size(443, 273);
            this.dgRSS.TabIndex = 1;
            // 
            // fmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 488);
            this.ContextMenuStrip = this.menuContextMain;
            this.ControlBox = false;
            this.Controls.Add(this.dgRSS);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.fmMain_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fmMain_FormClosing);
            this.menuContextMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgRSS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon NotifyRSSTray;
        private System.Windows.Forms.ContextMenuStrip menuContextMain;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgRSS;
    }
}

