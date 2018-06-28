namespace AutoServiceApp
{
    partial class Main
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
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.selectedMenu = new System.Windows.Forms.Label();
            this.PanelDashboard = new System.Windows.Forms.Panel();
            this.costumer = new AutoServiceApp.Costumer();
            this.service = new AutoServiceApp.Service();
            this.stock = new AutoServiceApp.Stock();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dashboard = new AutoServiceApp.Dashboard();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.PanelDashboard.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1005, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changePinToolStripMenuItem,
            this.quitToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // changePinToolStripMenuItem
            // 
            this.changePinToolStripMenuItem.Name = "changePinToolStripMenuItem";
            this.changePinToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.changePinToolStripMenuItem.Text = "Change pin";
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.quitToolStripMenuItem.Text = "Save changes";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkCyan;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button1.Location = new System.Drawing.Point(0, 386);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(185, 63);
            this.button1.TabIndex = 2;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkCyan;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button2.Location = new System.Drawing.Point(0, 317);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(185, 63);
            this.button2.TabIndex = 2;
            this.button2.Text = "Service";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DarkCyan;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button3.Location = new System.Drawing.Point(0, 248);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(185, 63);
            this.button3.TabIndex = 2;
            this.button3.Text = "Stock";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // selectedMenu
            // 
            this.selectedMenu.AutoSize = true;
            this.selectedMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectedMenu.ForeColor = System.Drawing.SystemColors.Window;
            this.selectedMenu.Location = new System.Drawing.Point(3, -2);
            this.selectedMenu.Name = "selectedMenu";
            this.selectedMenu.Size = new System.Drawing.Size(147, 31);
            this.selectedMenu.TabIndex = 0;
            this.selectedMenu.Text = "Dashboard";
            // 
            // PanelDashboard
            // 
            this.PanelDashboard.BackColor = System.Drawing.Color.DarkSlateGray;
            this.PanelDashboard.Controls.Add(this.costumer);
            this.PanelDashboard.Controls.Add(this.service);
            this.PanelDashboard.Controls.Add(this.stock);
            this.PanelDashboard.Controls.Add(this.panel2);
            this.PanelDashboard.Controls.Add(this.dashboard);
            this.PanelDashboard.Controls.Add(this.selectedMenu);
            this.PanelDashboard.Location = new System.Drawing.Point(191, 24);
            this.PanelDashboard.Name = "PanelDashboard";
            this.PanelDashboard.Size = new System.Drawing.Size(2000, 2000);
            this.PanelDashboard.TabIndex = 1;
            // 
            // costumer
            // 
            this.costumer.Location = new System.Drawing.Point(6, 34);
            this.costumer.Name = "costumer";
            this.costumer.Size = new System.Drawing.Size(800, 400);
            this.costumer.TabIndex = 5;
            // 
            // service
            // 
            this.service.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.service.Location = new System.Drawing.Point(4, 34);
            this.service.Name = "service";
            this.service.Size = new System.Drawing.Size(800, 400);
            this.service.TabIndex = 4;
            // 
            // stock
            // 
            this.stock.Location = new System.Drawing.Point(7, 34);
            this.stock.Name = "stock";
            this.stock.Size = new System.Drawing.Size(800, 400);
            this.stock.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkCyan;
            this.panel2.Location = new System.Drawing.Point(4, 28);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(805, 2);
            this.panel2.TabIndex = 2;
            // 
            // dashboard
            // 
            this.dashboard.Location = new System.Drawing.Point(9, 37);
            this.dashboard.Name = "dashboard";
            this.dashboard.Size = new System.Drawing.Size(800, 400);
            this.dashboard.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkCyan;
            this.panel1.Location = new System.Drawing.Point(0, 461);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(185, 2000);
            this.panel1.TabIndex = 2;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.DarkCyan;
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button5.Location = new System.Drawing.Point(0, 110);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(185, 63);
            this.button5.TabIndex = 2;
            this.button5.Text = "Dashboard";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button4_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DarkCyan;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button4.Location = new System.Drawing.Point(0, 179);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(185, 63);
            this.button4.TabIndex = 3;
            this.button4.Text = "Custumer";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(1005, 461);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PanelDashboard);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Auto Service";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.PanelDashboard.ResumeLayout(false);
            this.PanelDashboard.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label selectedMenu;
        private System.Windows.Forms.Panel PanelDashboard;
        private System.Windows.Forms.Panel panel1;
        private Dashboard dashboard;
        private System.Windows.Forms.Panel panel2;
        private Stock stock;
        private Service service;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private Costumer costumer;
    }
}