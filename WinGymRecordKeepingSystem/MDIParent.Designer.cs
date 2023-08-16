namespace WinGymRecordKeepingSystem
{
    partial class MDIParent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MDIParent));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.pnMdiParent = new System.Windows.Forms.Panel();
            this.btnNutritionCompany = new System.Windows.Forms.Button();
            this.btnNutritionType = new System.Windows.Forms.Button();
            this.btnPayments = new System.Windows.Forms.Button();
            this.btnTrainer = new System.Windows.Forms.Button();
            this.btnLogo = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnEquipments = new System.Windows.Forms.Button();
            this.btnMembers = new System.Windows.Forms.Button();
            this.statusStrip.SuspendLayout();
            this.pnMdiParent.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(879, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 574);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(879, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // pnMdiParent
            // 
            this.pnMdiParent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnMdiParent.Controls.Add(this.btnNutritionCompany);
            this.pnMdiParent.Controls.Add(this.btnNutritionType);
            this.pnMdiParent.Controls.Add(this.btnPayments);
            this.pnMdiParent.Controls.Add(this.btnTrainer);
            this.pnMdiParent.Controls.Add(this.btnLogo);
            this.pnMdiParent.Controls.Add(this.btnLogout);
            this.pnMdiParent.Controls.Add(this.btnEquipments);
            this.pnMdiParent.Controls.Add(this.btnMembers);
            this.pnMdiParent.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnMdiParent.ForeColor = System.Drawing.SystemColors.GrayText;
            this.pnMdiParent.Location = new System.Drawing.Point(0, 24);
            this.pnMdiParent.Name = "pnMdiParent";
            this.pnMdiParent.Size = new System.Drawing.Size(227, 550);
            this.pnMdiParent.TabIndex = 4;
            // 
            // btnNutritionCompany
            // 
            this.btnNutritionCompany.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnNutritionCompany.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNutritionCompany.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNutritionCompany.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNutritionCompany.Image = ((System.Drawing.Image)(resources.GetObject("btnNutritionCompany.Image")));
            this.btnNutritionCompany.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNutritionCompany.Location = new System.Drawing.Point(14, 385);
            this.btnNutritionCompany.Name = "btnNutritionCompany";
            this.btnNutritionCompany.Size = new System.Drawing.Size(197, 30);
            this.btnNutritionCompany.TabIndex = 18;
            this.btnNutritionCompany.Text = "Nutrition Company";
            this.btnNutritionCompany.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNutritionCompany.UseVisualStyleBackColor = false;
            this.btnNutritionCompany.Click += new System.EventHandler(this.btnNutritionCompany_Click);
            // 
            // btnNutritionType
            // 
            this.btnNutritionType.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnNutritionType.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNutritionType.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNutritionType.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNutritionType.Image = ((System.Drawing.Image)(resources.GetObject("btnNutritionType.Image")));
            this.btnNutritionType.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNutritionType.Location = new System.Drawing.Point(14, 349);
            this.btnNutritionType.Name = "btnNutritionType";
            this.btnNutritionType.Size = new System.Drawing.Size(197, 30);
            this.btnNutritionType.TabIndex = 17;
            this.btnNutritionType.Text = "Nutrition Types";
            this.btnNutritionType.UseVisualStyleBackColor = false;
            this.btnNutritionType.Click += new System.EventHandler(this.btnNutritionType_Click);
            // 
            // btnPayments
            // 
            this.btnPayments.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnPayments.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPayments.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayments.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPayments.Image = ((System.Drawing.Image)(resources.GetObject("btnPayments.Image")));
            this.btnPayments.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPayments.Location = new System.Drawing.Point(14, 313);
            this.btnPayments.Name = "btnPayments";
            this.btnPayments.Size = new System.Drawing.Size(197, 30);
            this.btnPayments.TabIndex = 12;
            this.btnPayments.Text = "Payments";
            this.btnPayments.UseVisualStyleBackColor = false;
            this.btnPayments.Click += new System.EventHandler(this.btnPayments_Click);
            // 
            // btnTrainer
            // 
            this.btnTrainer.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnTrainer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTrainer.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrainer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTrainer.Image = ((System.Drawing.Image)(resources.GetObject("btnTrainer.Image")));
            this.btnTrainer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTrainer.Location = new System.Drawing.Point(14, 277);
            this.btnTrainer.Name = "btnTrainer";
            this.btnTrainer.Size = new System.Drawing.Size(197, 30);
            this.btnTrainer.TabIndex = 11;
            this.btnTrainer.Text = "Trainers";
            this.btnTrainer.UseVisualStyleBackColor = false;
            this.btnTrainer.Click += new System.EventHandler(this.btnTrainer_Click);
            // 
            // btnLogo
            // 
            this.btnLogo.BackColor = System.Drawing.Color.Transparent;
            this.btnLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLogo.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnLogo.FlatAppearance.BorderSize = 0;
            this.btnLogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogo.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogo.ForeColor = System.Drawing.Color.Transparent;
            this.btnLogo.Image = ((System.Drawing.Image)(resources.GetObject("btnLogo.Image")));
            this.btnLogo.Location = new System.Drawing.Point(42, 25);
            this.btnLogo.Name = "btnLogo";
            this.btnLogo.Size = new System.Drawing.Size(139, 147);
            this.btnLogo.TabIndex = 13;
            this.btnLogo.UseVisualStyleBackColor = false;
            this.btnLogo.Click += new System.EventHandler(this.btnLogo_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(12, 478);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(199, 30);
            this.btnLogout.TabIndex = 10;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnEquipments
            // 
            this.btnEquipments.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnEquipments.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEquipments.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEquipments.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEquipments.Image = ((System.Drawing.Image)(resources.GetObject("btnEquipments.Image")));
            this.btnEquipments.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEquipments.Location = new System.Drawing.Point(14, 241);
            this.btnEquipments.Name = "btnEquipments";
            this.btnEquipments.Size = new System.Drawing.Size(197, 30);
            this.btnEquipments.TabIndex = 9;
            this.btnEquipments.Text = "Equpiments";
            this.btnEquipments.UseVisualStyleBackColor = false;
            this.btnEquipments.Click += new System.EventHandler(this.btnEquipments_Click);
            // 
            // btnMembers
            // 
            this.btnMembers.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnMembers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnMembers.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMembers.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMembers.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMembers.Image = ((System.Drawing.Image)(resources.GetObject("btnMembers.Image")));
            this.btnMembers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMembers.Location = new System.Drawing.Point(14, 205);
            this.btnMembers.Name = "btnMembers";
            this.btnMembers.Size = new System.Drawing.Size(197, 30);
            this.btnMembers.TabIndex = 8;
            this.btnMembers.Text = "Members";
            this.btnMembers.UseVisualStyleBackColor = false;
            this.btnMembers.Click += new System.EventHandler(this.btnMembers_Click);
            // 
            // MDIParent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 596);
            this.Controls.Add(this.pnMdiParent);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.DoubleBuffered = true;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MDIParent";
            this.Text = "Gym Record Keeping System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MDIParent_Load);
            this.MdiChildActivate += new System.EventHandler(this.MDIParent_MdiChildActivate);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.pnMdiParent.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Panel pnMdiParent;
        private System.Windows.Forms.Button btnEquipments;
        private System.Windows.Forms.Button btnMembers;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnTrainer;
        private System.Windows.Forms.Button btnPayments;
        private System.Windows.Forms.Button btnLogo;
        private System.Windows.Forms.Button btnNutritionType;
        private System.Windows.Forms.Button btnNutritionCompany;
    }
}



