namespace PerawatanIT
{
    partial class frmMaintenance
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
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.grpHardware = new System.Windows.Forms.GroupBox();
            this.chkNetworkCard = new System.Windows.Forms.CheckBox();
            this.chkMouse = new System.Windows.Forms.CheckBox();
            this.chkKeyboard = new System.Windows.Forms.CheckBox();
            this.chkCasing = new System.Windows.Forms.CheckBox();
            this.chkPS = new System.Windows.Forms.CheckBox();
            this.chkVGA = new System.Windows.Forms.CheckBox();
            this.chkDVD = new System.Windows.Forms.CheckBox();
            this.chkHarddisk = new System.Windows.Forms.CheckBox();
            this.chkProces = new System.Windows.Forms.CheckBox();
            this.chkMB = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtUpdate = new System.Windows.Forms.DateTimePicker();
            this.chkOS = new System.Windows.Forms.CheckBox();
            this.chkAV = new System.Windows.Forms.CheckBox();
            this.dtLapor = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSelectKomp = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKompName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.grpHardware.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(259, 362);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 25);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "&Simpan";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(340, 362);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 25);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "&Batal";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // grpHardware
            // 
            this.grpHardware.Controls.Add(this.chkNetworkCard);
            this.grpHardware.Controls.Add(this.chkMouse);
            this.grpHardware.Controls.Add(this.chkKeyboard);
            this.grpHardware.Controls.Add(this.chkCasing);
            this.grpHardware.Controls.Add(this.chkPS);
            this.grpHardware.Controls.Add(this.chkVGA);
            this.grpHardware.Controls.Add(this.chkDVD);
            this.grpHardware.Controls.Add(this.chkHarddisk);
            this.grpHardware.Controls.Add(this.chkProces);
            this.grpHardware.Controls.Add(this.chkMB);
            this.grpHardware.Location = new System.Drawing.Point(12, 73);
            this.grpHardware.Name = "grpHardware";
            this.grpHardware.Size = new System.Drawing.Size(200, 283);
            this.grpHardware.TabIndex = 3;
            this.grpHardware.TabStop = false;
            this.grpHardware.Text = "Hardware";
            // 
            // chkNetworkCard
            // 
            this.chkNetworkCard.AutoSize = true;
            this.chkNetworkCard.Location = new System.Drawing.Point(6, 254);
            this.chkNetworkCard.Name = "chkNetworkCard";
            this.chkNetworkCard.Size = new System.Drawing.Size(102, 20);
            this.chkNetworkCard.TabIndex = 0;
            this.chkNetworkCard.Text = "Network Card";
            this.chkNetworkCard.UseVisualStyleBackColor = true;
            // 
            // chkMouse
            // 
            this.chkMouse.AutoSize = true;
            this.chkMouse.Location = new System.Drawing.Point(6, 228);
            this.chkMouse.Name = "chkMouse";
            this.chkMouse.Size = new System.Drawing.Size(63, 20);
            this.chkMouse.TabIndex = 0;
            this.chkMouse.Text = "Mouse";
            this.chkMouse.UseVisualStyleBackColor = true;
            // 
            // chkKeyboard
            // 
            this.chkKeyboard.AutoSize = true;
            this.chkKeyboard.Location = new System.Drawing.Point(6, 202);
            this.chkKeyboard.Name = "chkKeyboard";
            this.chkKeyboard.Size = new System.Drawing.Size(81, 20);
            this.chkKeyboard.TabIndex = 0;
            this.chkKeyboard.Text = "Keyboard";
            this.chkKeyboard.UseVisualStyleBackColor = true;
            // 
            // chkCasing
            // 
            this.chkCasing.AutoSize = true;
            this.chkCasing.Location = new System.Drawing.Point(6, 176);
            this.chkCasing.Name = "chkCasing";
            this.chkCasing.Size = new System.Drawing.Size(64, 20);
            this.chkCasing.TabIndex = 0;
            this.chkCasing.Text = "Casing";
            this.chkCasing.UseVisualStyleBackColor = true;
            // 
            // chkPS
            // 
            this.chkPS.AutoSize = true;
            this.chkPS.Location = new System.Drawing.Point(6, 150);
            this.chkPS.Name = "chkPS";
            this.chkPS.Size = new System.Drawing.Size(101, 20);
            this.chkPS.TabIndex = 0;
            this.chkPS.Text = "Power Supply";
            this.chkPS.UseVisualStyleBackColor = true;
            // 
            // chkVGA
            // 
            this.chkVGA.AutoSize = true;
            this.chkVGA.Location = new System.Drawing.Point(6, 124);
            this.chkVGA.Name = "chkVGA";
            this.chkVGA.Size = new System.Drawing.Size(51, 20);
            this.chkVGA.TabIndex = 0;
            this.chkVGA.Text = "VGA";
            this.chkVGA.UseVisualStyleBackColor = true;
            // 
            // chkDVD
            // 
            this.chkDVD.AutoSize = true;
            this.chkDVD.Location = new System.Drawing.Point(6, 98);
            this.chkDVD.Name = "chkDVD";
            this.chkDVD.Size = new System.Drawing.Size(78, 20);
            this.chkDVD.TabIndex = 0;
            this.chkDVD.Text = "CD / DVD";
            this.chkDVD.UseVisualStyleBackColor = true;
            // 
            // chkHarddisk
            // 
            this.chkHarddisk.AutoSize = true;
            this.chkHarddisk.Location = new System.Drawing.Point(6, 72);
            this.chkHarddisk.Name = "chkHarddisk";
            this.chkHarddisk.Size = new System.Drawing.Size(73, 20);
            this.chkHarddisk.TabIndex = 0;
            this.chkHarddisk.Text = "Harddisk";
            this.chkHarddisk.UseVisualStyleBackColor = true;
            // 
            // chkProces
            // 
            this.chkProces.AutoSize = true;
            this.chkProces.Location = new System.Drawing.Point(6, 46);
            this.chkProces.Name = "chkProces";
            this.chkProces.Size = new System.Drawing.Size(76, 20);
            this.chkProces.TabIndex = 0;
            this.chkProces.Text = "Processor";
            this.chkProces.UseVisualStyleBackColor = true;
            // 
            // chkMB
            // 
            this.chkMB.AutoSize = true;
            this.chkMB.Location = new System.Drawing.Point(6, 20);
            this.chkMB.Name = "chkMB";
            this.chkMB.Size = new System.Drawing.Size(100, 20);
            this.chkMB.TabIndex = 0;
            this.chkMB.Text = "Motherboard";
            this.chkMB.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.dtUpdate);
            this.groupBox2.Controls.Add(this.chkOS);
            this.groupBox2.Controls.Add(this.chkAV);
            this.groupBox2.Location = new System.Drawing.Point(218, 73);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 131);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Software";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 69);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 16);
            this.label4.TabIndex = 26;
            this.label4.Text = "Terakhir Diupdate :";
            // 
            // dtUpdate
            // 
            this.dtUpdate.CustomFormat = "dd - MMM - yyyy";
            this.dtUpdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtUpdate.Location = new System.Drawing.Point(6, 91);
            this.dtUpdate.Name = "dtUpdate";
            this.dtUpdate.Size = new System.Drawing.Size(188, 21);
            this.dtUpdate.TabIndex = 6;
            // 
            // chkOS
            // 
            this.chkOS.AutoSize = true;
            this.chkOS.Location = new System.Drawing.Point(6, 20);
            this.chkOS.Name = "chkOS";
            this.chkOS.Size = new System.Drawing.Size(105, 20);
            this.chkOS.TabIndex = 0;
            this.chkOS.Text = "Sistem Operasi";
            this.chkOS.UseVisualStyleBackColor = true;
            // 
            // chkAV
            // 
            this.chkAV.AutoSize = true;
            this.chkAV.Location = new System.Drawing.Point(6, 46);
            this.chkAV.Name = "chkAV";
            this.chkAV.Size = new System.Drawing.Size(73, 20);
            this.chkAV.TabIndex = 0;
            this.chkAV.Text = "Anti Virus";
            this.chkAV.UseVisualStyleBackColor = true;
            this.chkAV.CheckedChanged += new System.EventHandler(this.chkAV_CheckedChanged);
            // 
            // dtLapor
            // 
            this.dtLapor.CustomFormat = "dd - MMM - yyyy";
            this.dtLapor.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtLapor.Location = new System.Drawing.Point(88, 39);
            this.dtLapor.Name = "dtLapor";
            this.dtLapor.Size = new System.Drawing.Size(327, 21);
            this.dtLapor.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 16);
            this.label1.TabIndex = 30;
            this.label1.Text = "Tgl :";
            // 
            // btnSelectKomp
            // 
            this.btnSelectKomp.Location = new System.Drawing.Point(385, 11);
            this.btnSelectKomp.Name = "btnSelectKomp";
            this.btnSelectKomp.Size = new System.Drawing.Size(30, 23);
            this.btnSelectKomp.TabIndex = 1;
            this.btnSelectKomp.Text = "...";
            this.btnSelectKomp.UseVisualStyleBackColor = true;
            this.btnSelectKomp.Click += new System.EventHandler(this.btnSelectKomp_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 29;
            this.label2.Text = "Komputer :";
            // 
            // txtKompName
            // 
            this.txtKompName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtKompName.Enabled = false;
            this.txtKompName.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKompName.Location = new System.Drawing.Point(88, 12);
            this.txtKompName.Name = "txtKompName";
            this.txtKompName.Size = new System.Drawing.Size(291, 21);
            this.txtKompName.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNotes);
            this.groupBox1.Location = new System.Drawing.Point(218, 210);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 146);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Catatan :";
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(6, 20);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(188, 120);
            this.txtNotes.TabIndex = 0;
            // 
            // frmMaintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 399);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtLapor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSelectKomp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtKompName);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grpHardware);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmMaintenance";
            this.Text = "Maintenance";
            this.Load += new System.EventHandler(this.frmMaintenance_Load);
            this.grpHardware.ResumeLayout(false);
            this.grpHardware.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox grpHardware;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dtLapor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSelectKomp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKompName;
        private System.Windows.Forms.CheckBox chkPS;
        private System.Windows.Forms.CheckBox chkVGA;
        private System.Windows.Forms.CheckBox chkDVD;
        private System.Windows.Forms.CheckBox chkHarddisk;
        private System.Windows.Forms.CheckBox chkProces;
        private System.Windows.Forms.CheckBox chkMB;
        private System.Windows.Forms.CheckBox chkMouse;
        private System.Windows.Forms.CheckBox chkKeyboard;
        private System.Windows.Forms.CheckBox chkCasing;
        private System.Windows.Forms.CheckBox chkNetworkCard;
        private System.Windows.Forms.CheckBox chkOS;
        private System.Windows.Forms.CheckBox chkAV;
        private System.Windows.Forms.DateTimePicker dtUpdate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNotes;
    }
}