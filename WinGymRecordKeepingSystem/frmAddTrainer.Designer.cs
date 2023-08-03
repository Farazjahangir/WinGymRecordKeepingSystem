namespace WinGymRecordKeepingSystem
{
    partial class frmAddTrainer
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
            this.pnTrainer = new System.Windows.Forms.Panel();
            this.btnsubmit = new System.Windows.Forms.Button();
            this.lblContact = new System.Windows.Forms.Label();
            this.mtbNic = new System.Windows.Forms.MaskedTextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblNic = new System.Windows.Forms.Label();
            this.mtbContact = new System.Windows.Forms.MaskedTextBox();
            this.lblTrainerFrom = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pnTrainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnTrainer
            // 
            this.pnTrainer.Controls.Add(this.label5);
            this.pnTrainer.Controls.Add(this.label4);
            this.pnTrainer.Controls.Add(this.label3);
            this.pnTrainer.Controls.Add(this.label2);
            this.pnTrainer.Controls.Add(this.label1);
            this.pnTrainer.Controls.Add(this.btnsubmit);
            this.pnTrainer.Controls.Add(this.lblContact);
            this.pnTrainer.Controls.Add(this.mtbNic);
            this.pnTrainer.Controls.Add(this.lblFirstName);
            this.pnTrainer.Controls.Add(this.lblNic);
            this.pnTrainer.Controls.Add(this.mtbContact);
            this.pnTrainer.Controls.Add(this.lblTrainerFrom);
            this.pnTrainer.Controls.Add(this.lblLastName);
            this.pnTrainer.Controls.Add(this.txtFirstName);
            this.pnTrainer.Controls.Add(this.txtLastName);
            this.pnTrainer.Controls.Add(this.txtEmail);
            this.pnTrainer.Controls.Add(this.lblEmail);
            this.pnTrainer.Location = new System.Drawing.Point(2, 2);
            this.pnTrainer.Name = "pnTrainer";
            this.pnTrainer.Size = new System.Drawing.Size(568, 391);
            this.pnTrainer.TabIndex = 14;
            // 
            // btnsubmit
            // 
            this.btnsubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(159)))), ((int)(((byte)(67)))));
            this.btnsubmit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnsubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsubmit.ForeColor = System.Drawing.SystemColors.Control;
            this.btnsubmit.Location = new System.Drawing.Point(124, 291);
            this.btnsubmit.Name = "btnsubmit";
            this.btnsubmit.Size = new System.Drawing.Size(200, 28);
            this.btnsubmit.TabIndex = 11;
            this.btnsubmit.Text = "Submit";
            this.btnsubmit.UseVisualStyleBackColor = false;
            this.btnsubmit.Click += new System.EventHandler(this.btnsubmit_Click);
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContact.Location = new System.Drawing.Point(15, 207);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(65, 20);
            this.lblContact.TabIndex = 7;
            this.lblContact.Text = "Contact";
            // 
            // mtbNic
            // 
            this.mtbNic.Location = new System.Drawing.Point(124, 247);
            this.mtbNic.Mask = "00000-0000000-0";
            this.mtbNic.Name = "mtbNic";
            this.mtbNic.Size = new System.Drawing.Size(130, 20);
            this.mtbNic.TabIndex = 10;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(15, 93);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(86, 20);
            this.lblFirstName.TabIndex = 1;
            this.lblFirstName.Text = "First Name";
            // 
            // lblNic
            // 
            this.lblNic.AutoSize = true;
            this.lblNic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNic.Location = new System.Drawing.Point(15, 247);
            this.lblNic.Name = "lblNic";
            this.lblNic.Size = new System.Drawing.Size(31, 20);
            this.lblNic.TabIndex = 8;
            this.lblNic.Text = "Nic";
            // 
            // mtbContact
            // 
            this.mtbContact.Location = new System.Drawing.Point(124, 209);
            this.mtbContact.Mask = "0000-0000000";
            this.mtbContact.Name = "mtbContact";
            this.mtbContact.Size = new System.Drawing.Size(130, 20);
            this.mtbContact.TabIndex = 9;
            // 
            // lblTrainerFrom
            // 
            this.lblTrainerFrom.AutoSize = true;
            this.lblTrainerFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrainerFrom.Location = new System.Drawing.Point(142, 19);
            this.lblTrainerFrom.Name = "lblTrainerFrom";
            this.lblTrainerFrom.Size = new System.Drawing.Size(244, 42);
            this.lblTrainerFrom.TabIndex = 0;
            this.lblTrainerFrom.Text = "Trainer Form";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(15, 138);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(86, 20);
            this.lblLastName.TabIndex = 2;
            this.lblLastName.Text = "Last Name";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(124, 93);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(275, 20);
            this.txtFirstName.TabIndex = 4;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(124, 138);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(275, 20);
            this.txtLastName.TabIndex = 6;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(124, 177);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(275, 20);
            this.txtEmail.TabIndex = 5;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(15, 175);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(48, 20);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "Email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(96, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 24);
            this.label1.TabIndex = 12;
            this.label1.Text = "*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(57, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 24);
            this.label2.TabIndex = 13;
            this.label2.Text = "*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(96, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 24);
            this.label3.TabIndex = 14;
            this.label3.Text = "*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(41, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 24);
            this.label4.TabIndex = 15;
            this.label4.Text = "*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(77, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 24);
            this.label5.TabIndex = 16;
            this.label5.Text = "*";
            // 
            // frmAddTrainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 393);
            this.ControlBox = false;
            this.Controls.Add(this.pnTrainer);
            this.Name = "frmAddTrainer";
            this.Text = "frmAddTrainer";
            this.SizeChanged += new System.EventHandler(this.frmAddTrainer_SizeChanged);
            this.pnTrainer.ResumeLayout(false);
            this.pnTrainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnTrainer;
        private System.Windows.Forms.Button btnsubmit;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.MaskedTextBox mtbNic;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblNic;
        private System.Windows.Forms.MaskedTextBox mtbContact;
        private System.Windows.Forms.Label lblTrainerFrom;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}