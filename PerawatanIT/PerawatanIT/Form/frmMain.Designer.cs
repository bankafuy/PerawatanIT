namespace PerawatanIT
{
    partial class frmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.programToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maintenanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.instalasiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.perawatanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.permasalahanToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.masterDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kategoriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.permasalahanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.computersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.laporanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hasilPerawatanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historyPermasalahanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Window;
            this.menuStrip1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programToolStripMenuItem,
            this.maintenanceToolStripMenuItem,
            this.masterDataToolStripMenuItem,
            this.laporanToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(851, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // programToolStripMenuItem
            // 
            this.programToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.programToolStripMenuItem.Name = "programToolStripMenuItem";
            this.programToolStripMenuItem.Size = new System.Drawing.Size(70, 21);
            this.programToolStripMenuItem.Text = "&Program";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.logoutToolStripMenuItem.Text = "&Logout";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // maintenanceToolStripMenuItem
            // 
            this.maintenanceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.instalasiToolStripMenuItem,
            this.perawatanToolStripMenuItem,
            this.permasalahanToolStripMenuItem1});
            this.maintenanceToolStripMenuItem.Name = "maintenanceToolStripMenuItem";
            this.maintenanceToolStripMenuItem.Size = new System.Drawing.Size(78, 21);
            this.maintenanceToolStripMenuItem.Text = "&Komputer";
            // 
            // instalasiToolStripMenuItem
            // 
            this.instalasiToolStripMenuItem.Name = "instalasiToolStripMenuItem";
            this.instalasiToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.instalasiToolStripMenuItem.Text = "&Instalasi";
            this.instalasiToolStripMenuItem.Click += new System.EventHandler(this.instalasiToolStripMenuItem_Click);
            // 
            // perawatanToolStripMenuItem
            // 
            this.perawatanToolStripMenuItem.Name = "perawatanToolStripMenuItem";
            this.perawatanToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.perawatanToolStripMenuItem.Text = "Pera&watan";
            this.perawatanToolStripMenuItem.Click += new System.EventHandler(this.jadwalToolStripMenuItem_Click);
            // 
            // permasalahanToolStripMenuItem1
            // 
            this.permasalahanToolStripMenuItem1.Name = "permasalahanToolStripMenuItem1";
            this.permasalahanToolStripMenuItem1.Size = new System.Drawing.Size(160, 22);
            this.permasalahanToolStripMenuItem1.Text = "Per&masalahan";
            this.permasalahanToolStripMenuItem1.Click += new System.EventHandler(this.permasalahanToolStripMenuItem1_Click);
            // 
            // masterDataToolStripMenuItem
            // 
            this.masterDataToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kategoriToolStripMenuItem,
            this.computersToolStripMenuItem,
            this.itemsToolStripMenuItem,
            this.userToolStripMenuItem});
            this.masterDataToolStripMenuItem.Name = "masterDataToolStripMenuItem";
            this.masterDataToolStripMenuItem.Size = new System.Drawing.Size(61, 21);
            this.masterDataToolStripMenuItem.Text = "&Master";
            // 
            // kategoriToolStripMenuItem
            // 
            this.kategoriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemToolStripMenuItem,
            this.permasalahanToolStripMenuItem});
            this.kategoriToolStripMenuItem.Name = "kategoriToolStripMenuItem";
            this.kategoriToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.kategoriToolStripMenuItem.Text = "&Kategori";
            // 
            // itemToolStripMenuItem
            // 
            this.itemToolStripMenuItem.Name = "itemToolStripMenuItem";
            this.itemToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.itemToolStripMenuItem.Text = "&Item";
            this.itemToolStripMenuItem.Click += new System.EventHandler(this.itemToolStripMenuItem_Click);
            // 
            // permasalahanToolStripMenuItem
            // 
            this.permasalahanToolStripMenuItem.Name = "permasalahanToolStripMenuItem";
            this.permasalahanToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.permasalahanToolStripMenuItem.Text = "&Permasalahan";
            this.permasalahanToolStripMenuItem.Click += new System.EventHandler(this.permasalahanToolStripMenuItem_Click);
            // 
            // computersToolStripMenuItem
            // 
            this.computersToolStripMenuItem.Name = "computersToolStripMenuItem";
            this.computersToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.computersToolStripMenuItem.Text = "&Komputer";
            this.computersToolStripMenuItem.Click += new System.EventHandler(this.computersToolStripMenuItem_Click);
            // 
            // itemsToolStripMenuItem
            // 
            this.itemsToolStripMenuItem.Name = "itemsToolStripMenuItem";
            this.itemsToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.itemsToolStripMenuItem.Text = "&Items";
            this.itemsToolStripMenuItem.Click += new System.EventHandler(this.itemsToolStripMenuItem_Click);
            // 
            // userToolStripMenuItem
            // 
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.userToolStripMenuItem.Text = "&User";
            this.userToolStripMenuItem.Click += new System.EventHandler(this.userToolStripMenuItem_Click);
            // 
            // laporanToolStripMenuItem
            // 
            this.laporanToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hasilPerawatanToolStripMenuItem,
            this.historyPermasalahanToolStripMenuItem});
            this.laporanToolStripMenuItem.Name = "laporanToolStripMenuItem";
            this.laporanToolStripMenuItem.Size = new System.Drawing.Size(69, 21);
            this.laporanToolStripMenuItem.Text = "&Laporan";
            // 
            // hasilPerawatanToolStripMenuItem
            // 
            this.hasilPerawatanToolStripMenuItem.Name = "hasilPerawatanToolStripMenuItem";
            this.hasilPerawatanToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.hasilPerawatanToolStripMenuItem.Text = "Hasil Perawatan";
            // 
            // historyPermasalahanToolStripMenuItem
            // 
            this.historyPermasalahanToolStripMenuItem.Name = "historyPermasalahanToolStripMenuItem";
            this.historyPermasalahanToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.historyPermasalahanToolStripMenuItem.Text = "Riwayat Permasalahan";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 526);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem programToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maintenanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem perawatanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem instalasiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem masterDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem computersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem laporanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hasilPerawatanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historyPermasalahanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kategoriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem permasalahanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem permasalahanToolStripMenuItem1;
    }
}