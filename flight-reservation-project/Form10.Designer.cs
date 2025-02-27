namespace prototype1
{
    partial class Form10
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
            this.Search_Menubar = new System.Windows.Forms.ToolStripMenuItem();
            this.Reservation_MenuBar = new System.Windows.Forms.ToolStripMenuItem();
            this.Sd_Manage_MenuBar = new System.Windows.Forms.ToolStripMenuItem();
            this.Exit_MenuBar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Search_Menubar,
            this.Reservation_MenuBar,
            this.Sd_Manage_MenuBar,
            this.Exit_MenuBar});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1536, 40);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Search_Menubar
            // 
            this.Search_Menubar.Name = "Search_Menubar";
            this.Search_Menubar.Size = new System.Drawing.Size(162, 36);
            this.Search_Menubar.Text = "항공편 조회";
            this.Search_Menubar.Click += new System.EventHandler(this.Search_Menubar_Click);
            // 
            // Reservation_MenuBar
            // 
            this.Reservation_MenuBar.Name = "Reservation_MenuBar";
            this.Reservation_MenuBar.Size = new System.Drawing.Size(194, 36);
            this.Reservation_MenuBar.Text = "예약 내역 조회";
            this.Reservation_MenuBar.Click += new System.EventHandler(this.Reservation_MenuBar_Click);
            // 
            // Sd_Manage_MenuBar
            // 
            this.Sd_Manage_MenuBar.Name = "Sd_Manage_MenuBar";
            this.Sd_Manage_MenuBar.Size = new System.Drawing.Size(162, 36);
            this.Sd_Manage_MenuBar.Text = "스케쥴 관리";
            this.Sd_Manage_MenuBar.Click += new System.EventHandler(this.Sd_Manage_MenuBar_Click);
            // 
            // Exit_MenuBar
            // 
            this.Exit_MenuBar.Name = "Exit_MenuBar";
            this.Exit_MenuBar.Size = new System.Drawing.Size(82, 36);
            this.Exit_MenuBar.Text = "종료";
            this.Exit_MenuBar.Click += new System.EventHandler(this.Exit_MenuBar_Click);
            // 
            // Form10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1536, 1229);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form10";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "항공편 구매 및 관리";
            this.Load += new System.EventHandler(this.Form10_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Search_Menubar;
        private System.Windows.Forms.ToolStripMenuItem Reservation_MenuBar;
        private System.Windows.Forms.ToolStripMenuItem Sd_Manage_MenuBar;
        private System.Windows.Forms.ToolStripMenuItem Exit_MenuBar;
    }
}