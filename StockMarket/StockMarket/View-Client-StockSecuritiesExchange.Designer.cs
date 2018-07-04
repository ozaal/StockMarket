namespace StockExchangeMarket
{
    partial class StockSecuritiesExchange
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockSecuritiesExchange));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.marketToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.beginTradingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopTradingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.watchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockStateSummaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.marketByOrderToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.marketByPriceToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ordersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bidToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.askToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cascadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.horizontalTileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verticalTileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Username = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ClientIP = new System.Windows.Forms.ToolStripTextBox();
            this.clientPortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ClientPort = new System.Windows.Forms.ToolStripTextBox();
            this.serverIPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ServerIP = new System.Windows.Forms.ToolStripTextBox();
            this.serverPortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ServerPort = new System.Windows.Forms.ToolStripTextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userToolStripMenuItem,
            this.Username,
            this.marketToolStripMenuItem,
            this.watchToolStripMenuItem,
            this.ordersToolStripMenuItem,
            this.windowsToolStripMenuItem,
            this.toolStripMenuItem1,
            this.ClientIP,
            this.clientPortToolStripMenuItem,
            this.ClientPort,
            this.serverIPToolStripMenuItem,
            this.ServerIP,
            this.serverPortToolStripMenuItem,
            this.ServerPort});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.MdiWindowListItem = this.windowsToolStripMenuItem;
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1678, 37);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // marketToolStripMenuItem
            // 
            this.marketToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.beginTradingToolStripMenuItem,
            this.stopTradingToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.marketToolStripMenuItem.Name = "marketToolStripMenuItem";
            this.marketToolStripMenuItem.Size = new System.Drawing.Size(193, 31);
            this.marketToolStripMenuItem.Text = "&Join <<Connected>>";
            this.marketToolStripMenuItem.Click += new System.EventHandler(this.marketToolStripMenuItem_Click);
            // 
            // beginTradingToolStripMenuItem
            // 
            this.beginTradingToolStripMenuItem.Name = "beginTradingToolStripMenuItem";
            this.beginTradingToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.beginTradingToolStripMenuItem.Text = "&Begin Trading";
            this.beginTradingToolStripMenuItem.Click += new System.EventHandler(this.beginTradingToolStripMenuItem_Click);
            // 
            // stopTradingToolStripMenuItem
            // 
            this.stopTradingToolStripMenuItem.Name = "stopTradingToolStripMenuItem";
            this.stopTradingToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.stopTradingToolStripMenuItem.Text = "S&top Trading";
            this.stopTradingToolStripMenuItem.Click += new System.EventHandler(this.stopTradingToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(249, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // watchToolStripMenuItem
            // 
            this.watchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stockStateSummaryToolStripMenuItem,
            this.marketByOrderToolStripMenuItem1,
            this.marketByPriceToolStripMenuItem1});
            this.watchToolStripMenuItem.Name = "watchToolStripMenuItem";
            this.watchToolStripMenuItem.Size = new System.Drawing.Size(73, 31);
            this.watchToolStripMenuItem.Text = "Watc&h";
            this.watchToolStripMenuItem.Visible = false;
            // 
            // stockStateSummaryToolStripMenuItem
            // 
            this.stockStateSummaryToolStripMenuItem.Name = "stockStateSummaryToolStripMenuItem";
            this.stockStateSummaryToolStripMenuItem.Size = new System.Drawing.Size(264, 30);
            this.stockStateSummaryToolStripMenuItem.Text = "&Stock State Summary";
            this.stockStateSummaryToolStripMenuItem.Click += new System.EventHandler(this.StockStateSummaryToolStripMenuItem_Click);
            // 
            // marketByOrderToolStripMenuItem1
            // 
            this.marketByOrderToolStripMenuItem1.Name = "marketByOrderToolStripMenuItem1";
            this.marketByOrderToolStripMenuItem1.Size = new System.Drawing.Size(264, 30);
            this.marketByOrderToolStripMenuItem1.Text = "Market By &Order";
            // 
            // marketByPriceToolStripMenuItem1
            // 
            this.marketByPriceToolStripMenuItem1.Name = "marketByPriceToolStripMenuItem1";
            this.marketByPriceToolStripMenuItem1.Size = new System.Drawing.Size(264, 30);
            this.marketByPriceToolStripMenuItem1.Text = "Market By &Price";
            // 
            // ordersToolStripMenuItem
            // 
            this.ordersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bidToolStripMenuItem,
            this.askToolStripMenuItem});
            this.ordersToolStripMenuItem.Name = "ordersToolStripMenuItem";
            this.ordersToolStripMenuItem.Size = new System.Drawing.Size(78, 31);
            this.ordersToolStripMenuItem.Text = "&Orders";
            this.ordersToolStripMenuItem.Visible = false;
            // 
            // bidToolStripMenuItem
            // 
            this.bidToolStripMenuItem.Name = "bidToolStripMenuItem";
            this.bidToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.bidToolStripMenuItem.Text = "&Bid";
            this.bidToolStripMenuItem.Click += new System.EventHandler(this.bidToolStripMenuItem_Click);
            // 
            // askToolStripMenuItem
            // 
            this.askToolStripMenuItem.Name = "askToolStripMenuItem";
            this.askToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.askToolStripMenuItem.Text = "&Ask";
            this.askToolStripMenuItem.Click += new System.EventHandler(this.askToolStripMenuItem_Click);
            // 
            // windowsToolStripMenuItem
            // 
            this.windowsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cascadeToolStripMenuItem,
            this.horizontalTileToolStripMenuItem,
            this.verticalTileToolStripMenuItem});
            this.windowsToolStripMenuItem.Name = "windowsToolStripMenuItem";
            this.windowsToolStripMenuItem.Size = new System.Drawing.Size(98, 31);
            this.windowsToolStripMenuItem.Text = "&Windows";
            // 
            // cascadeToolStripMenuItem
            // 
            this.cascadeToolStripMenuItem.Name = "cascadeToolStripMenuItem";
            this.cascadeToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.cascadeToolStripMenuItem.Text = "Cascade";
            this.cascadeToolStripMenuItem.Click += new System.EventHandler(this.cascadeToolStripMenuItem_Click);
            // 
            // horizontalTileToolStripMenuItem
            // 
            this.horizontalTileToolStripMenuItem.Name = "horizontalTileToolStripMenuItem";
            this.horizontalTileToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.horizontalTileToolStripMenuItem.Text = "Horizontal Tile";
            this.horizontalTileToolStripMenuItem.Click += new System.EventHandler(this.horizontalTileToolStripMenuItem_Click);
            // 
            // verticalTileToolStripMenuItem
            // 
            this.verticalTileToolStripMenuItem.Name = "verticalTileToolStripMenuItem";
            this.verticalTileToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.verticalTileToolStripMenuItem.Text = "Vertical Tile ";
            this.verticalTileToolStripMenuItem.Click += new System.EventHandler(this.verticalTileToolStripMenuItem_Click);
            // 
            // userToolStripMenuItem
            // 
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.Size = new System.Drawing.Size(59, 31);
            this.userToolStripMenuItem.Text = "User";
            // 
            // Username
            // 
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(100, 31);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(88, 31);
            this.toolStripMenuItem1.Text = "Client IP";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // ClientIP
            // 
            this.ClientIP.Name = "ClientIP";
            this.ClientIP.Size = new System.Drawing.Size(100, 31);
            // 
            // clientPortToolStripMenuItem
            // 
            this.clientPortToolStripMenuItem.Name = "clientPortToolStripMenuItem";
            this.clientPortToolStripMenuItem.Size = new System.Drawing.Size(105, 31);
            this.clientPortToolStripMenuItem.Text = "Client Port";
            this.clientPortToolStripMenuItem.Click += new System.EventHandler(this.clientPortToolStripMenuItem_Click);
            // 
            // ClientPort
            // 
            this.ClientPort.Name = "ClientPort";
            this.ClientPort.Size = new System.Drawing.Size(100, 31);
            // 
            // serverIPToolStripMenuItem
            // 
            this.serverIPToolStripMenuItem.Name = "serverIPToolStripMenuItem";
            this.serverIPToolStripMenuItem.Size = new System.Drawing.Size(93, 31);
            this.serverIPToolStripMenuItem.Text = "Server IP";
            // 
            // ServerIP
            // 
            this.ServerIP.Name = "ServerIP";
            this.ServerIP.Size = new System.Drawing.Size(100, 31);
            // 
            // serverPortToolStripMenuItem
            // 
            this.serverPortToolStripMenuItem.Name = "serverPortToolStripMenuItem";
            this.serverPortToolStripMenuItem.Size = new System.Drawing.Size(110, 31);
            this.serverPortToolStripMenuItem.Text = "Server Port";
            this.serverPortToolStripMenuItem.Click += new System.EventHandler(this.serverPortToolStripMenuItem_Click);
            // 
            // ServerPort
            // 
            this.ServerPort.Name = "ServerPort";
            this.ServerPort.Size = new System.Drawing.Size(100, 31);
            // 
            // StockSecuritiesExchange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1678, 808);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "StockSecuritiesExchange";
            this.Text = "Stock Security Exchange";
            this.Load += new System.EventHandler(this.StockSecuritiesExchange_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem marketToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cascadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem horizontalTileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verticalTileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem beginTradingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopTradingToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem watchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockStateSummaryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem marketByOrderToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem marketByPriceToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ordersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bidToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem askToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox Username;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripTextBox ClientIP;
        private System.Windows.Forms.ToolStripMenuItem clientPortToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox ClientPort;
        private System.Windows.Forms.ToolStripMenuItem serverIPToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox ServerIP;
        private System.Windows.Forms.ToolStripMenuItem serverPortToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox ServerPort;
    }
}