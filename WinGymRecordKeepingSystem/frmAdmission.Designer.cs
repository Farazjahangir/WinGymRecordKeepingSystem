namespace WinGymRecordKeepingSystem
{
    partial class frmAdmission
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
            this.lblAdmissonFrom = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblContact = new System.Windows.Forms.Label();
            this.lblNic = new System.Windows.Forms.Label();
            this.mtbContact = new System.Windows.Forms.MaskedTextBox();
            this.mtbNic = new System.Windows.Forms.MaskedTextBox();
            this.btnsubmit = new System.Windows.Forms.Button();
            this.pnAdmission = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pnAdmission.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAdmissonFrom
            // 
            this.lblAdmissonFrom.AutoSize = true;
            this.lblAdmissonFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdmissonFrom.Location = new System.Drawing.Point(142, 19);
            this.lblAdmissonFrom.Name = "lblAdmissonFrom";
            this.lblAdmissonFrom.Size = new System.Drawing.Size(291, 42);
            this.lblAdmissonFrom.TabIndex = 0;
            this.lblAdmissonFrom.Text = "Admisson Form";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.BackColor = System.Drawing.Color.Transparent;
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(102, 104);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(86, 20);
            this.lblFirstName.TabIndex = 1;
            this.lblFirstName.Text = "First Name";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.BackColor = System.Drawing.Color.Transparent;
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(102, 149);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(86, 20);
            this.lblLastName.TabIndex = 2;
            this.lblLastName.Text = "Last Name";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(102, 186);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(48, 20);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "Email";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(211, 104);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(275, 20);
            this.txtFirstName.TabIndex = 4;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(211, 188);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(275, 20);
            this.txtEmail.TabIndex = 5;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(211, 149);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(275, 20);
            this.txtLastName.TabIndex = 6;
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.BackColor = System.Drawing.Color.Transparent;
            this.lblContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContact.Location = new System.Drawing.Point(102, 218);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(65, 20);
            this.lblContact.TabIndex = 7;
            this.lblContact.Text = "Contact";
            // 
            // lblNic
            // 
            this.lblNic.AutoSize = true;
            this.lblNic.BackColor = System.Drawing.Color.Transparent;
            this.lblNic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNic.Location = new System.Drawing.Point(102, 258);
            this.lblNic.Name = "lblNic";
            this.lblNic.Size = new System.Drawing.Size(31, 20);
            this.lblNic.TabIndex = 8;
            this.lblNic.Text = "Nic";
            // 
            // mtbContact
            // 
            this.mtbContact.Location = new System.Drawing.Point(211, 220);
            this.mtbContact.Mask = "0000-0000000";
            this.mtbContact.Name = "mtbContact";
            this.mtbContact.Size = new System.Drawing.Size(130, 20);
            this.mtbContact.TabIndex = 9;
            // 
            // mtbNic
            // 
            this.mtbNic.Location = new System.Drawing.Point(211, 258);
            this.mtbNic.Mask = "00000-0000000-0";
            this.mtbNic.Name = "mtbNic";
            this.mtbNic.Size = new System.Drawing.Size(130, 20);
            this.mtbNic.TabIndex = 10;
            // 
            // btnsubmit
            // 
            this.btnsubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(159)))), ((int)(((byte)(67)))));
            this.btnsubmit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnsubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsubmit.ForeColor = System.Drawing.SystemColors.Control;
            this.btnsubmit.Location = new System.Drawing.Point(242, 319);
            this.btnsubmit.Name = "btnsubmit";
            this.btnsubmit.Size = new System.Drawing.Size(99, 28);
            this.btnsubmit.TabIndex = 11;
            this.btnsubmit.Text = "Submit";
            this.btnsubmit.UseVisualStyleBackColor = false;
            this.btnsubmit.Click += new System.EventHandler(this.btnsubmit_Click);
            // 
            // pnAdmission
            // 
            this.pnAdmission.Controls.Add(this.btnsubmit);
            this.pnAdmission.Controls.Add(this.lblContact);
            this.pnAdmission.Controls.Add(this.mtbNic);
            this.pnAdmission.Controls.Add(this.lblFirstName);
            this.pnAdmission.Controls.Add(this.lblNic);
            this.pnAdmission.Controls.Add(this.mtbContact);
            this.pnAdmission.Controls.Add(this.lblAdmissonFrom);
            this.pnAdmission.Controls.Add(this.lblLastName);
            this.pnAdmission.Controls.Add(this.txtFirstName);
            this.pnAdmission.Controls.Add(this.txtLastName);
            this.pnAdmission.Controls.Add(this.txtEmail);
            this.pnAdmission.Controls.Add(this.lblEmail);
            this.pnAdmission.Controls.Add(this.label1);
            this.pnAdmission.Controls.Add(this.label4);
            this.pnAdmission.Controls.Add(this.label3);
            this.pnAdmission.Controls.Add(this.label2);
            this.pnAdmission.Location = new System.Drawing.Point(80, 13);
            this.pnAdmission.Name = "pnAdmission";
            this.pnAdmission.Size = new System.Drawing.Size(568, 391);
            this.pnAdmission.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(182, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(182, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(161, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 25);
            this.label3.TabIndex = 14;
            this.label3.Text = "*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(128, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 25);
            this.label4.TabIndex = 15;
            this.label4.Text = "*";
            // 
            // frmAdmission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 450);
            this.ControlBox = false;
            this.Controls.Add(this.pnAdmission);
            this.Name = "frmAdmission";
            this.Text = "Admission From";
            this.SizeChanged += new System.EventHandler(this.frmAdmission_SizeChanged);
            this.pnAdmission.ResumeLayout(false);
            this.pnAdmission.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblAdmissonFrom;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.Label lblNic;
        private System.Windows.Forms.MaskedTextBox mtbContact;
        private System.Windows.Forms.MaskedTextBox mtbNic;
        private System.Windows.Forms.Button btnsubmit;
        private System.Windows.Forms.Panel pnAdmission;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}