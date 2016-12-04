namespace Drugstore
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.miLogin = new System.Windows.Forms.ToolStripMenuItem();
            this.miSetting = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miWindows = new System.Windows.Forms.ToolStripMenuItem();
            this.каскадомToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.горизонтальноToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вертикальноToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.закритиВікноToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.закритиВсіВікнаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miExit = new System.Windows.Forms.ToolStripMenuItem();
            this.miContrDir = new System.Windows.Forms.ToolStripMenuItem();
            this.стартоваСторінкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.керуванняТоварамиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.керуванняПрацівникамиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.керуванняКлієнтамиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miContrMan = new System.Windows.Forms.ToolStripMenuItem();
            this.стартоваСторінкаToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.керуванняТоварамиToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.керуванняКлієнтамиToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.miContrCas = new System.Windows.Forms.ToolStripMenuItem();
            this.стартоваСторінкаToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.переглядТоварівToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.продажТоварівToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miLogin,
            this.miSetting,
            this.miWindows,
            this.miExit,
            this.miContrDir,
            this.miContrMan,
            this.miContrCas});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(761, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // miLogin
            // 
            this.miLogin.Name = "miLogin";
            this.miLogin.Size = new System.Drawing.Size(54, 20);
            this.miLogin.Text = "Увійти";
            this.miLogin.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // miSetting
            // 
            this.miSetting.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutToolStripMenuItem,
            this.changeUserToolStripMenuItem});
            this.miSetting.Name = "miSetting";
            this.miSetting.Size = new System.Drawing.Size(101, 20);
            this.miSetting.Text = "Налаштування";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.logoutToolStripMenuItem.Text = "Вийти";
            this.logoutToolStripMenuItem.Visible = false;
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // changeUserToolStripMenuItem
            // 
            this.changeUserToolStripMenuItem.Name = "changeUserToolStripMenuItem";
            this.changeUserToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.changeUserToolStripMenuItem.Text = "Змінити користувача";
            this.changeUserToolStripMenuItem.Visible = false;
            this.changeUserToolStripMenuItem.Click += new System.EventHandler(this.changeUserToolStripMenuItem_Click);
            // 
            // miWindows
            // 
            this.miWindows.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.каскадомToolStripMenuItem,
            this.горизонтальноToolStripMenuItem,
            this.вертикальноToolStripMenuItem,
            this.toolStripMenuItem1,
            this.закритиВікноToolStripMenuItem,
            this.закритиВсіВікнаToolStripMenuItem});
            this.miWindows.Name = "miWindows";
            this.miWindows.Size = new System.Drawing.Size(48, 20);
            this.miWindows.Text = "Вікна";
            // 
            // каскадомToolStripMenuItem
            // 
            this.каскадомToolStripMenuItem.Name = "каскадомToolStripMenuItem";
            this.каскадомToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.каскадомToolStripMenuItem.Text = "Каскадом";
            this.каскадомToolStripMenuItem.Click += new System.EventHandler(this.каскадомToolStripMenuItem_Click);
            // 
            // горизонтальноToolStripMenuItem
            // 
            this.горизонтальноToolStripMenuItem.Name = "горизонтальноToolStripMenuItem";
            this.горизонтальноToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.горизонтальноToolStripMenuItem.Text = "Горизонтально";
            this.горизонтальноToolStripMenuItem.Click += new System.EventHandler(this.горизонтальноToolStripMenuItem_Click);
            // 
            // вертикальноToolStripMenuItem
            // 
            this.вертикальноToolStripMenuItem.Name = "вертикальноToolStripMenuItem";
            this.вертикальноToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.вертикальноToolStripMenuItem.Text = "Вертикально";
            this.вертикальноToolStripMenuItem.Click += new System.EventHandler(this.вертикальноToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(165, 6);
            // 
            // закритиВікноToolStripMenuItem
            // 
            this.закритиВікноToolStripMenuItem.Name = "закритиВікноToolStripMenuItem";
            this.закритиВікноToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.закритиВікноToolStripMenuItem.Text = "Закрити вікно";
            this.закритиВікноToolStripMenuItem.Click += new System.EventHandler(this.закритиВікноToolStripMenuItem_Click);
            // 
            // закритиВсіВікнаToolStripMenuItem
            // 
            this.закритиВсіВікнаToolStripMenuItem.Name = "закритиВсіВікнаToolStripMenuItem";
            this.закритиВсіВікнаToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.закритиВсіВікнаToolStripMenuItem.Text = "Закрити всі вікна";
            this.закритиВсіВікнаToolStripMenuItem.Click += new System.EventHandler(this.закритиВсіВікнаToolStripMenuItem_Click);
            // 
            // miExit
            // 
            this.miExit.Name = "miExit";
            this.miExit.Size = new System.Drawing.Size(47, 20);
            this.miExit.Text = "Вихід";
            this.miExit.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // miContrDir
            // 
            this.miContrDir.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.стартоваСторінкаToolStripMenuItem,
            this.керуванняТоварамиToolStripMenuItem,
            this.керуванняПрацівникамиToolStripMenuItem,
            this.керуванняКлієнтамиToolStripMenuItem});
            this.miContrDir.Name = "miContrDir";
            this.miContrDir.Size = new System.Drawing.Size(77, 20);
            this.miContrDir.Text = "Керування";
            this.miContrDir.Visible = false;
            // 
            // стартоваСторінкаToolStripMenuItem
            // 
            this.стартоваСторінкаToolStripMenuItem.Name = "стартоваСторінкаToolStripMenuItem";
            this.стартоваСторінкаToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.стартоваСторінкаToolStripMenuItem.Text = "Стартова сторінка";
            this.стартоваСторінкаToolStripMenuItem.Click += new System.EventHandler(this.директорToolStripMenuItem_Click);
            // 
            // керуванняТоварамиToolStripMenuItem
            // 
            this.керуванняТоварамиToolStripMenuItem.Name = "керуванняТоварамиToolStripMenuItem";
            this.керуванняТоварамиToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.керуванняТоварамиToolStripMenuItem.Text = "Керування товарами";
            this.керуванняТоварамиToolStripMenuItem.Click += new System.EventHandler(this.керуванняТоварамиToolStripMenuItem_Click);
            // 
            // керуванняПрацівникамиToolStripMenuItem
            // 
            this.керуванняПрацівникамиToolStripMenuItem.Name = "керуванняПрацівникамиToolStripMenuItem";
            this.керуванняПрацівникамиToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.керуванняПрацівникамиToolStripMenuItem.Text = "Керування працівниками";
            this.керуванняПрацівникамиToolStripMenuItem.Click += new System.EventHandler(this.керуванняПрацівникамиToolStripMenuItem_Click);
            // 
            // керуванняКлієнтамиToolStripMenuItem
            // 
            this.керуванняКлієнтамиToolStripMenuItem.Name = "керуванняКлієнтамиToolStripMenuItem";
            this.керуванняКлієнтамиToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.керуванняКлієнтамиToolStripMenuItem.Text = "Керування клієнтами";
            this.керуванняКлієнтамиToolStripMenuItem.Click += new System.EventHandler(this.керуванняКлієнтамиToolStripMenuItem_Click);
            // 
            // miContrMan
            // 
            this.miContrMan.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.стартоваСторінкаToolStripMenuItem1,
            this.керуванняТоварамиToolStripMenuItem1,
            this.керуванняКлієнтамиToolStripMenuItem1});
            this.miContrMan.Name = "miContrMan";
            this.miContrMan.Size = new System.Drawing.Size(77, 20);
            this.miContrMan.Text = "Керування";
            this.miContrMan.Visible = false;
            // 
            // стартоваСторінкаToolStripMenuItem1
            // 
            this.стартоваСторінкаToolStripMenuItem1.Name = "стартоваСторінкаToolStripMenuItem1";
            this.стартоваСторінкаToolStripMenuItem1.Size = new System.Drawing.Size(191, 22);
            this.стартоваСторінкаToolStripMenuItem1.Text = "Стартова сторінка";
            this.стартоваСторінкаToolStripMenuItem1.Click += new System.EventHandler(this.менеджерToolStripMenuItem_Click);
            // 
            // керуванняТоварамиToolStripMenuItem1
            // 
            this.керуванняТоварамиToolStripMenuItem1.Name = "керуванняТоварамиToolStripMenuItem1";
            this.керуванняТоварамиToolStripMenuItem1.Size = new System.Drawing.Size(191, 22);
            this.керуванняТоварамиToolStripMenuItem1.Text = "Керування товарами";
            this.керуванняТоварамиToolStripMenuItem1.Click += new System.EventHandler(this.керуванняТоварамиToolStripMenuItem_Click);
            // 
            // керуванняКлієнтамиToolStripMenuItem1
            // 
            this.керуванняКлієнтамиToolStripMenuItem1.Name = "керуванняКлієнтамиToolStripMenuItem1";
            this.керуванняКлієнтамиToolStripMenuItem1.Size = new System.Drawing.Size(191, 22);
            this.керуванняКлієнтамиToolStripMenuItem1.Text = "Керування клієнтами";
            this.керуванняКлієнтамиToolStripMenuItem1.Click += new System.EventHandler(this.керуванняКлієнтамиToolStripMenuItem_Click);
            // 
            // miContrCas
            // 
            this.miContrCas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.стартоваСторінкаToolStripMenuItem2,
            this.переглядТоварівToolStripMenuItem,
            this.продажТоварівToolStripMenuItem});
            this.miContrCas.Name = "miContrCas";
            this.miContrCas.Size = new System.Drawing.Size(77, 20);
            this.miContrCas.Text = "Керування";
            this.miContrCas.Visible = false;
            // 
            // стартоваСторінкаToolStripMenuItem2
            // 
            this.стартоваСторінкаToolStripMenuItem2.Name = "стартоваСторінкаToolStripMenuItem2";
            this.стартоваСторінкаToolStripMenuItem2.Size = new System.Drawing.Size(174, 22);
            this.стартоваСторінкаToolStripMenuItem2.Text = "Стартова сторінка";
            this.стартоваСторінкаToolStripMenuItem2.Click += new System.EventHandler(this.аптекарToolStripMenuItem_Click);
            // 
            // переглядТоварівToolStripMenuItem
            // 
            this.переглядТоварівToolStripMenuItem.Name = "переглядТоварівToolStripMenuItem";
            this.переглядТоварівToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.переглядТоварівToolStripMenuItem.Text = "Перегляд товарів";
            this.переглядТоварівToolStripMenuItem.Click += new System.EventHandler(this.керуванняТоварамиToolStripMenuItem_Click);
            // 
            // продажТоварівToolStripMenuItem
            // 
            this.продажТоварівToolStripMenuItem.Name = "продажТоварівToolStripMenuItem";
            this.продажТоварівToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.продажТоварівToolStripMenuItem.Text = "Продаж товарів";
            this.продажТоварівToolStripMenuItem.Click += new System.EventHandler(this.продажТоварівToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(761, 452);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Аптека";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem miExit;
        private System.Windows.Forms.ToolStripMenuItem miWindows;
        private System.Windows.Forms.ToolStripMenuItem каскадомToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem горизонтальноToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вертикальноToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem закритиВікноToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem закритиВсіВікнаToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem miSetting;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeUserToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem miLogin;
        private System.Windows.Forms.ToolStripMenuItem miContrDir;
        private System.Windows.Forms.ToolStripMenuItem miContrMan;
        private System.Windows.Forms.ToolStripMenuItem miContrCas;
        private System.Windows.Forms.ToolStripMenuItem стартоваСторінкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem керуванняТоварамиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem керуванняПрацівникамиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem керуванняКлієнтамиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem стартоваСторінкаToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem керуванняТоварамиToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem керуванняКлієнтамиToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem стартоваСторінкаToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem переглядТоварівToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem продажТоварівToolStripMenuItem;
    }
}