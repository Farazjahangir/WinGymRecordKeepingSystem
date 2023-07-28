namespace WinGymRecordKeepingSystem
{
    partial class frmAddEquipment
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
            this.lblAddEquipmentForm = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKg = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.pnAddEquipment = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pnAddEquipment.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAddEquipmentForm
            // 
            this.lblAddEquipmentForm.AutoSize = true;
            this.lblAddEquipmentForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddEquipmentForm.Location = new System.Drawing.Point(54, 34);
            this.lblAddEquipmentForm.Name = "lblAddEquipmentForm";
            this.lblAddEquipmentForm.Size = new System.Drawing.Size(286, 42);
            this.lblAddEquipmentForm.TabIndex = 0;
            this.lblAddEquipmentForm.Text = "Add Equipment";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(96, 125);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(224, 20);
            this.txtName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(94, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(94, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Quantity";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(96, 257);
            this.txtQuantity.Multiline = true;
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(224, 27);
            this.txtQuantity.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(94, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "KG";
            // 
            // txtKg
            // 
            this.txtKg.Location = new System.Drawing.Point(96, 191);
            this.txtKg.Name = "txtKg";
            this.txtKg.Size = new System.Drawing.Size(224, 20);
            this.txtKg.TabIndex = 7;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(159)))), ((int)(((byte)(67)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAdd.Location = new System.Drawing.Point(96, 303);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(224, 31);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // pnAddEquipment
            // 
            this.pnAddEquipment.Controls.Add(this.btnAdd);
            this.pnAddEquipment.Controls.Add(this.lblAddEquipmentForm);
            this.pnAddEquipment.Controls.Add(this.txtName);
            this.pnAddEquipment.Controls.Add(this.label3);
            this.pnAddEquipment.Controls.Add(this.label2);
            this.pnAddEquipment.Controls.Add(this.txtKg);
            this.pnAddEquipment.Controls.Add(this.txtQuantity);
            this.pnAddEquipment.Controls.Add(this.label4);
            this.pnAddEquipment.Controls.Add(this.label1);
            this.pnAddEquipment.Controls.Add(this.label6);
            this.pnAddEquipment.Location = new System.Drawing.Point(79, 21);
            this.pnAddEquipment.Name = "pnAddEquipment";
            this.pnAddEquipment.Size = new System.Drawing.Size(444, 391);
            this.pnAddEquipment.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(140, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(157, 224);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 25);
            this.label6.TabIndex = 12;
            this.label6.Text = "*";
            // 
            // frmAddEquipment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(681, 450);
            this.ControlBox = false;
            this.Controls.Add(this.pnAddEquipment);
            this.Name = "frmAddEquipment";
            this.Text = "Add Equipment";
            this.SizeChanged += new System.EventHandler(this.frmAddEquipment_SizeChanged);
            this.pnAddEquipment.ResumeLayout(false);
            this.pnAddEquipment.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblAddEquipmentForm;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtKg;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel pnAddEquipment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
    }
}