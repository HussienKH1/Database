namespace Database
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlNav = new System.Windows.Forms.Panel();
            this.btndashb = new System.Windows.Forms.Button();
            this.Account = new System.Windows.Forms.Button();
            this.Settings = new System.Windows.Forms.Button();
            this.Transactions = new System.Windows.Forms.Button();
            this.Card = new System.Windows.Forms.Button();
            this.btnAnalytics = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Exit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pnlNav);
            this.panel1.Controls.Add(this.btndashb);
            this.panel1.Controls.Add(this.Account);
            this.panel1.Controls.Add(this.Settings);
            this.panel1.Controls.Add(this.Transactions);
            this.panel1.Controls.Add(this.Card);
            this.panel1.Controls.Add(this.btnAnalytics);
            this.panel1.Controls.Add(this.btnProfile);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(191, 582);
            this.panel1.TabIndex = 0;
            // 
            // pnlNav
            // 
            this.pnlNav.BackColor = System.Drawing.Color.Lime;
            this.pnlNav.Location = new System.Drawing.Point(0, 193);
            this.pnlNav.Name = "pnlNav";
            this.pnlNav.Size = new System.Drawing.Size(3, 100);
            this.pnlNav.TabIndex = 3;
            // 
            // btndashb
            // 
            this.btndashb.BackColor = System.Drawing.Color.Transparent;
            this.btndashb.FlatAppearance.BorderSize = 0;
            this.btndashb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndashb.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndashb.Image = ((System.Drawing.Image)(resources.GetObject("btndashb.Image")));
            this.btndashb.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btndashb.Location = new System.Drawing.Point(-1, 83);
            this.btndashb.Name = "btndashb";
            this.btndashb.Size = new System.Drawing.Size(191, 28);
            this.btndashb.TabIndex = 10;
            this.btndashb.Text = "Dasboard";
            this.btndashb.UseVisualStyleBackColor = false;
            this.btndashb.Click += new System.EventHandler(this.btndashb_Click);
            this.btndashb.Leave += new System.EventHandler(this.btndashb_Leave);
            // 
            // Account
            // 
            this.Account.BackColor = System.Drawing.Color.Transparent;
            this.Account.FlatAppearance.BorderSize = 0;
            this.Account.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Account.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Account.Location = new System.Drawing.Point(-1, 355);
            this.Account.Name = "Account";
            this.Account.Size = new System.Drawing.Size(191, 28);
            this.Account.TabIndex = 9;
            this.Account.Text = "Account";
            this.Account.UseVisualStyleBackColor = false;
            this.Account.Click += new System.EventHandler(this.Account_Click);
            this.Account.Leave += new System.EventHandler(this.Account_Leave);
            // 
            // Settings
            // 
            this.Settings.BackColor = System.Drawing.Color.Transparent;
            this.Settings.FlatAppearance.BorderSize = 0;
            this.Settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Settings.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Settings.Image = ((System.Drawing.Image)(resources.GetObject("Settings.Image")));
            this.Settings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Settings.Location = new System.Drawing.Point(-1, 321);
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(191, 28);
            this.Settings.TabIndex = 8;
            this.Settings.Text = "Settings";
            this.Settings.UseVisualStyleBackColor = false;
            this.Settings.Click += new System.EventHandler(this.Settings_Click);
            this.Settings.Leave += new System.EventHandler(this.Settings_Leave);
            // 
            // Transactions
            // 
            this.Transactions.BackColor = System.Drawing.Color.Transparent;
            this.Transactions.FlatAppearance.BorderSize = 0;
            this.Transactions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Transactions.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Transactions.Image = ((System.Drawing.Image)(resources.GetObject("Transactions.Image")));
            this.Transactions.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Transactions.Location = new System.Drawing.Point(-1, 216);
            this.Transactions.Name = "Transactions";
            this.Transactions.Size = new System.Drawing.Size(191, 28);
            this.Transactions.TabIndex = 7;
            this.Transactions.Text = "Transactions";
            this.Transactions.UseVisualStyleBackColor = false;
            this.Transactions.Click += new System.EventHandler(this.Transactions_Click);
            this.Transactions.Leave += new System.EventHandler(this.Transactions_Leave);
            // 
            // Card
            // 
            this.Card.BackColor = System.Drawing.Color.Transparent;
            this.Card.FlatAppearance.BorderSize = 0;
            this.Card.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Card.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Card.Image = ((System.Drawing.Image)(resources.GetObject("Card.Image")));
            this.Card.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Card.Location = new System.Drawing.Point(-1, 182);
            this.Card.Name = "Card";
            this.Card.Size = new System.Drawing.Size(191, 28);
            this.Card.TabIndex = 6;
            this.Card.Text = "Card";
            this.Card.UseVisualStyleBackColor = false;
            this.Card.Click += new System.EventHandler(this.Card_Click);
            this.Card.Leave += new System.EventHandler(this.Card_Leave);
            // 
            // btnAnalytics
            // 
            this.btnAnalytics.BackColor = System.Drawing.Color.Transparent;
            this.btnAnalytics.FlatAppearance.BorderSize = 0;
            this.btnAnalytics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnalytics.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnalytics.Image = ((System.Drawing.Image)(resources.GetObject("btnAnalytics.Image")));
            this.btnAnalytics.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnalytics.Location = new System.Drawing.Point(-1, 148);
            this.btnAnalytics.Name = "btnAnalytics";
            this.btnAnalytics.Size = new System.Drawing.Size(191, 28);
            this.btnAnalytics.TabIndex = 5;
            this.btnAnalytics.Text = "Analytics";
            this.btnAnalytics.UseVisualStyleBackColor = false;
            this.btnAnalytics.Click += new System.EventHandler(this.btnAnalytics_Click);
            this.btnAnalytics.Leave += new System.EventHandler(this.btnAnalytics_Leave);
            // 
            // btnProfile
            // 
            this.btnProfile.BackColor = System.Drawing.Color.Transparent;
            this.btnProfile.FlatAppearance.BorderSize = 0;
            this.btnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfile.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfile.Image = ((System.Drawing.Image)(resources.GetObject("btnProfile.Image")));
            this.btnProfile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProfile.Location = new System.Drawing.Point(-1, 114);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(191, 28);
            this.btnProfile.TabIndex = 4;
            this.btnProfile.Text = "Profile";
            this.btnProfile.UseVisualStyleBackColor = false;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            this.btnProfile.Leave += new System.EventHandler(this.btnProfile_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label3.Location = new System.Drawing.Point(3, 287);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Settings";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label2.Location = new System.Drawing.Point(3, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Menu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "MoneyMinder";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.Exit);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1311, 33);
            this.panel3.TabIndex = 2;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // Exit
            // 
            this.Exit.FlatAppearance.BorderSize = 0;
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit.Image = ((System.Drawing.Image)(resources.GetObject("Exit.Image")));
            this.Exit.Location = new System.Drawing.Point(1283, 4);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(25, 23);
            this.Exit.TabIndex = 0;
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1311, 615);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Leave += new System.EventHandler(this.Form1_Leave);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Panel pnlNav;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Button btnAnalytics;
        private System.Windows.Forms.Button Card;
        private System.Windows.Forms.Button Transactions;
        private System.Windows.Forms.Button Account;
        private System.Windows.Forms.Button Settings;
        private System.Windows.Forms.Button btndashb;
    }
}

