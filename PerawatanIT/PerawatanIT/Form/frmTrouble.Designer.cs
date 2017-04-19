namespace PerawatanIT
{
    partial class frmTrouble
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtKompName = new System.Windows.Forms.TextBox();
            this.cboKategori = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSelectKomp = new System.Windows.Forms.Button();
            this.dtLapor = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtFinish = new System.Windows.Forms.DateTimePicker();
            this.txtTroubles = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPelapor = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSolusi = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 73);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Komputer :";
            // 
            // txtKompName
            // 
            this.txtKompName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtKompName.Enabled = false;
            this.txtKompName.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKompName.Location = new System.Drawing.Point(87, 70);
            this.txtKompName.Name = "txtKompName";
            this.txtKompName.Size = new System.Drawing.Size(234, 21);
            this.txtKompName.TabIndex = 2;
            // 
            // cboKategori
            // 
            this.cboKategori.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboKategori.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboKategori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKategori.FormattingEnabled = true;
            this.cboKategori.Items.AddRange(new object[] {
            "- PILIH -",
            "BOILER-1",
            "BOILER-2",
            "ENGINEERING WORKSHOP",
            "GUDANG",
            "OFFICE",
            "PROSES",
            "PURCHASING",
            "QAC"});
            this.cboKategori.Location = new System.Drawing.Point(87, 12);
            this.cboKategori.Name = "cboKategori";
            this.cboKategori.Size = new System.Drawing.Size(270, 24);
            this.cboKategori.Sorted = true;
            this.cboKategori.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 15);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "Kategori :";
            // 
            // btnSelectKomp
            // 
            this.btnSelectKomp.Location = new System.Drawing.Point(327, 69);
            this.btnSelectKomp.Name = "btnSelectKomp";
            this.btnSelectKomp.Size = new System.Drawing.Size(30, 23);
            this.btnSelectKomp.TabIndex = 3;
            this.btnSelectKomp.Text = "...";
            this.btnSelectKomp.UseVisualStyleBackColor = true;
            this.btnSelectKomp.Click += new System.EventHandler(this.btnSelectKomp_Click);
            // 
            // dtLapor
            // 
            this.dtLapor.CustomFormat = "dd - MMM - yyyy";
            this.dtLapor.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtLapor.Location = new System.Drawing.Point(87, 97);
            this.dtLapor.Name = "dtLapor";
            this.dtLapor.Size = new System.Drawing.Size(270, 21);
            this.dtLapor.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 101);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 25;
            this.label1.Text = "Tgl Lapor :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 128);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 16);
            this.label4.TabIndex = 25;
            this.label4.Text = "Tgl Selesai :";
            // 
            // dtFinish
            // 
            this.dtFinish.CustomFormat = "dd - MMM - yyyy";
            this.dtFinish.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFinish.Location = new System.Drawing.Point(87, 124);
            this.dtFinish.Name = "dtFinish";
            this.dtFinish.ShowCheckBox = true;
            this.dtFinish.Size = new System.Drawing.Size(270, 21);
            this.dtFinish.TabIndex = 5;
            // 
            // txtTroubles
            // 
            this.txtTroubles.Location = new System.Drawing.Point(87, 151);
            this.txtTroubles.Multiline = true;
            this.txtTroubles.Name = "txtTroubles";
            this.txtTroubles.Size = new System.Drawing.Size(270, 94);
            this.txtTroubles.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 154);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 16);
            this.label5.TabIndex = 25;
            this.label5.Text = "Deskripsi :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(25, 45);
            this.label6.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 16);
            this.label6.TabIndex = 25;
            this.label6.Text = "Pelapor :";
            // 
            // txtPelapor
            // 
            this.txtPelapor.Location = new System.Drawing.Point(87, 42);
            this.txtPelapor.Name = "txtPelapor";
            this.txtPelapor.Size = new System.Drawing.Size(270, 21);
            this.txtPelapor.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(39, 254);
            this.label7.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 16);
            this.label7.TabIndex = 25;
            this.label7.Text = "Solusi :";
            // 
            // txtSolusi
            // 
            this.txtSolusi.Location = new System.Drawing.Point(87, 251);
            this.txtSolusi.Multiline = true;
            this.txtSolusi.Name = "txtSolusi";
            this.txtSolusi.Size = new System.Drawing.Size(270, 163);
            this.txtSolusi.TabIndex = 7;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(201, 420);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 25);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "&Simpan";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(282, 420);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 25);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "&Batal";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmTrouble
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 457);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtSolusi);
            this.Controls.Add(this.txtPelapor);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtTroubles);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtFinish);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtLapor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSelectKomp);
            this.Controls.Add(this.cboKategori);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtKompName);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmTrouble";
            this.Text = "Trouble";
            this.Load += new System.EventHandler(this.frmTrouble_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKompName;
        private System.Windows.Forms.ComboBox cboKategori;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSelectKomp;
        private System.Windows.Forms.DateTimePicker dtLapor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtFinish;
        private System.Windows.Forms.TextBox txtTroubles;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPelapor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSolusi;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}