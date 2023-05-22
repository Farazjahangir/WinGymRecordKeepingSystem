namespace WinGymRecordKeepingSystem
{
    partial class frmCollectFee
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
            this.pnCollectFee = new System.Windows.Forms.Panel();
            this.btnCollect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFee = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbName = new System.Windows.Forms.ComboBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.pnCollectFee.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnCollectFee
            // 
            this.pnCollectFee.Controls.Add(this.dtpDate);
            this.pnCollectFee.Controls.Add(this.cmbName);
            this.pnCollectFee.Controls.Add(this.btnCollect);
            this.pnCollectFee.Controls.Add(this.label1);
            this.pnCollectFee.Controls.Add(this.label3);
            this.pnCollectFee.Controls.Add(this.label2);
            this.pnCollectFee.Controls.Add(this.txtFee);
            this.pnCollectFee.Controls.Add(this.label4);
            this.pnCollectFee.Location = new System.Drawing.Point(213, 30);
            this.pnCollectFee.Name = "pnCollectFee";
            this.pnCollectFee.Size = new System.Drawing.Size(374, 391);
            this.pnCollectFee.TabIndex = 15;
            // 
            // btnCollect
            // 
            this.btnCollect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(159)))), ((int)(((byte)(67)))));
            this.btnCollect.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCollect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCollect.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCollect.Location = new System.Drawing.Point(59, 307);
            this.btnCollect.Name = "btnCollect";
            this.btnCollect.Size = new System.Drawing.Size(224, 31);
            this.btnCollect.TabIndex = 9;
            this.btnCollect.Text = "Collect";
            this.btnCollect.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Collect Fee";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(57, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Fee";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(55, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name";
            // 
            // txtFee
            // 
            this.txtFee.Location = new System.Drawing.Point(59, 195);
            this.txtFee.Name = "txtFee";
            this.txtFee.Size = new System.Drawing.Size(224, 20);
            this.txtFee.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(57, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Date";
            // 
            // cmbName
            // 
            this.cmbName.FormattingEnabled = true;
            this.cmbName.Location = new System.Drawing.Point(61, 131);
            this.cmbName.Name = "cmbName";
            this.cmbName.Size = new System.Drawing.Size(222, 21);
            this.cmbName.TabIndex = 10;
            // 
            // dtpDate
            // 
            this.dtpDate.Enabled = false;
            this.dtpDate.Location = new System.Drawing.Point(61, 264);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(222, 20);
            this.dtpDate.TabIndex = 11;
            // 
            // frmCollectFee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.pnCollectFee);
            this.Name = "frmCollectFee";
            this.Text = "Collect Fee";
            this.Load += new System.EventHandler(this.frmCollectFee_Load);
            this.pnCollectFee.ResumeLayout(false);
            this.pnCollectFee.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnCollectFee;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.ComboBox cmbName;
        private System.Windows.Forms.Button btnCollect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFee;
        private System.Windows.Forms.Label label4;
    }
}