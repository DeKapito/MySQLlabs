namespace MySQLlabs
{
    partial class LabWindow
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
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.fileMainMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitMainMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dovidnikiMainMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kafedryMainMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.konferentsiyiMainMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zvityMainMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mistsyaProzhyvannyaMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMainMenuItem,
            this.dovidnikiMainMenuItem,
            this.konferentsiyiMainMenuItem,
            this.zvityMainMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(800, 28);
            this.mainMenu.TabIndex = 0;
            this.mainMenu.Text = "menuStrip1";
            // 
            // fileMainMenuItem
            // 
            this.fileMainMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitMainMenuItem});
            this.fileMainMenuItem.Name = "fileMainMenuItem";
            this.fileMainMenuItem.Size = new System.Drawing.Size(57, 24);
            this.fileMainMenuItem.Text = "Файл";
            // 
            // exitMainMenuItem
            // 
            this.exitMainMenuItem.Name = "exitMainMenuItem";
            this.exitMainMenuItem.Size = new System.Drawing.Size(121, 26);
            this.exitMainMenuItem.Text = "Вихід";
            this.exitMainMenuItem.Click += new System.EventHandler(this.exitMainMenuItem_Click);
            // 
            // dovidnikiMainMenuItem
            // 
            this.dovidnikiMainMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kafedryMainMenuItem,
            this.mistsyaProzhyvannyaMenuItem});
            this.dovidnikiMainMenuItem.Name = "dovidnikiMainMenuItem";
            this.dovidnikiMainMenuItem.Size = new System.Drawing.Size(94, 24);
            this.dovidnikiMainMenuItem.Text = "Довідники";
            // 
            // kafedryMainMenuItem
            // 
            this.kafedryMainMenuItem.Name = "kafedryMainMenuItem";
            this.kafedryMainMenuItem.Size = new System.Drawing.Size(218, 26);
            this.kafedryMainMenuItem.Text = "Кафедри";
            this.kafedryMainMenuItem.Click += new System.EventHandler(this.kafedryMainMenuItem_Click);
            // 
            // konferentsiyiMainMenuItem
            // 
            this.konferentsiyiMainMenuItem.Name = "konferentsiyiMainMenuItem";
            this.konferentsiyiMainMenuItem.Size = new System.Drawing.Size(109, 24);
            this.konferentsiyiMainMenuItem.Text = "Конференції";
            // 
            // zvityMainMenuItem
            // 
            this.zvityMainMenuItem.Name = "zvityMainMenuItem";
            this.zvityMainMenuItem.Size = new System.Drawing.Size(56, 24);
            this.zvityMainMenuItem.Text = "Звіти";
            // 
            // mistsyaProzhyvannyaMenuItem
            // 
            this.mistsyaProzhyvannyaMenuItem.Name = "mistsyaProzhyvannyaMenuItem";
            this.mistsyaProzhyvannyaMenuItem.Size = new System.Drawing.Size(218, 26);
            this.mistsyaProzhyvannyaMenuItem.Text = "Місця проживання";
            this.mistsyaProzhyvannyaMenuItem.Click += new System.EventHandler(this.mistsyaProzhyvannyaMenuItem_Click);
            // 
            // LabWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mainMenu);
            this.MainMenuStrip = this.mainMenu;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LabWindow";
            this.Text = "MySQLlabs";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LabWindow_FormClosing);
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem fileMainMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitMainMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dovidnikiMainMenuItem;
        private System.Windows.Forms.ToolStripMenuItem konferentsiyiMainMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zvityMainMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kafedryMainMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mistsyaProzhyvannyaMenuItem;
    }
}

