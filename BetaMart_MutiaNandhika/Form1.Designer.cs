namespace BetaMart_MutiaNandhika
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
            this.components = new System.ComponentModel.Container();
            this.panel = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKeterangan = new System.Windows.Forms.TextBox();
            this.barangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appDataBrg = new BetaMart_MutiaNandhika.AppDataBrg();
            this.btnPicture = new System.Windows.Forms.Button();
            this.txtHarga = new System.Windows.Forms.TextBox();
            this.txtJenis = new System.Windows.Forms.TextBox();
            this.txtStok = new System.Windows.Forms.TextBox();
            this.txtNamaBrg = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.iDBarangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stokDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jenisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hargaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.keteranganDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imageDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.barangTableAdapter = new BetaMart_MutiaNandhika.AppDataBrgTableAdapters.BarangTableAdapter();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appDataBrg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.LightGreen;
            this.panel.Controls.Add(this.label5);
            this.panel.Controls.Add(this.label4);
            this.panel.Controls.Add(this.label3);
            this.panel.Controls.Add(this.label2);
            this.panel.Controls.Add(this.txtKeterangan);
            this.panel.Controls.Add(this.btnPicture);
            this.panel.Controls.Add(this.txtHarga);
            this.panel.Controls.Add(this.txtJenis);
            this.panel.Controls.Add(this.txtStok);
            this.panel.Controls.Add(this.txtNamaBrg);
            this.panel.Controls.Add(this.label1);
            this.panel.Controls.Add(this.pictureBox);
            this.panel.Enabled = false;
            this.panel.Location = new System.Drawing.Point(49, 62);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(855, 241);
            this.panel.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poppins Medium", 10F);
            this.label5.Location = new System.Drawing.Point(556, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 25);
            this.label5.TabIndex = 15;
            this.label5.Text = "Keterangan";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins Medium", 10F);
            this.label4.Location = new System.Drawing.Point(187, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 25);
            this.label4.TabIndex = 14;
            this.label4.Text = "Harga Barang";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins Medium", 10F);
            this.label3.Location = new System.Drawing.Point(187, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 25);
            this.label3.TabIndex = 13;
            this.label3.Text = "Jenis Barang";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins Medium", 10F);
            this.label2.Location = new System.Drawing.Point(187, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "Stok Barang";
            // 
            // txtKeterangan
            // 
            this.txtKeterangan.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.barangBindingSource, "Keterangan", true));
            this.txtKeterangan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtKeterangan.Location = new System.Drawing.Point(561, 55);
            this.txtKeterangan.Multiline = true;
            this.txtKeterangan.Name = "txtKeterangan";
            this.txtKeterangan.Size = new System.Drawing.Size(272, 128);
            this.txtKeterangan.TabIndex = 4;
            // 
            // barangBindingSource
            // 
            this.barangBindingSource.DataMember = "Barang";
            this.barangBindingSource.DataSource = this.appDataBrg;
            // 
            // appDataBrg
            // 
            this.appDataBrg.DataSetName = "AppDataBrg";
            this.appDataBrg.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnPicture
            // 
            this.btnPicture.BackColor = System.Drawing.Color.Plum;
            this.btnPicture.Font = new System.Drawing.Font("Poppins Medium", 9F);
            this.btnPicture.Location = new System.Drawing.Point(18, 198);
            this.btnPicture.Name = "btnPicture";
            this.btnPicture.Size = new System.Drawing.Size(144, 28);
            this.btnPicture.TabIndex = 9;
            this.btnPicture.Text = "Gambar Barang";
            this.btnPicture.UseVisualStyleBackColor = false;
            this.btnPicture.Click += new System.EventHandler(this.btnPicture_Click);
            // 
            // txtHarga
            // 
            this.txtHarga.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.barangBindingSource, "Harga", true));
            this.txtHarga.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtHarga.Location = new System.Drawing.Point(323, 158);
            this.txtHarga.Multiline = true;
            this.txtHarga.Name = "txtHarga";
            this.txtHarga.Size = new System.Drawing.Size(199, 25);
            this.txtHarga.TabIndex = 3;
            // 
            // txtJenis
            // 
            this.txtJenis.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.barangBindingSource, "Jenis", true));
            this.txtJenis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtJenis.Location = new System.Drawing.Point(323, 114);
            this.txtJenis.Multiline = true;
            this.txtJenis.Name = "txtJenis";
            this.txtJenis.Size = new System.Drawing.Size(199, 25);
            this.txtJenis.TabIndex = 2;
            // 
            // txtStok
            // 
            this.txtStok.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.barangBindingSource, "Stok", true));
            this.txtStok.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtStok.Location = new System.Drawing.Point(323, 68);
            this.txtStok.Multiline = true;
            this.txtStok.Name = "txtStok";
            this.txtStok.Size = new System.Drawing.Size(199, 25);
            this.txtStok.TabIndex = 1;
            // 
            // txtNamaBrg
            // 
            this.txtNamaBrg.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.barangBindingSource, "Nama Barang", true));
            this.txtNamaBrg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtNamaBrg.Location = new System.Drawing.Point(323, 23);
            this.txtNamaBrg.Multiline = true;
            this.txtNamaBrg.Name = "txtNamaBrg";
            this.txtNamaBrg.Size = new System.Drawing.Size(199, 25);
            this.txtNamaBrg.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins Medium", 10F);
            this.label1.Location = new System.Drawing.Point(187, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nama Barang";
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.White;
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.barangBindingSource, "Image", true));
            this.pictureBox.Location = new System.Drawing.Point(18, 13);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(144, 179);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Poppins SemiBold", 16F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(420, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 39);
            this.label7.TabIndex = 19;
            this.label7.Text = "BETA MART";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Plum;
            this.btnAdd.Font = new System.Drawing.Font("Poppins Medium", 9F);
            this.btnAdd.Location = new System.Drawing.Point(278, 495);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(104, 45);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add Data";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Plum;
            this.btnEdit.Font = new System.Drawing.Font("Poppins Medium", 9F);
            this.btnEdit.Location = new System.Drawing.Point(412, 495);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(104, 45);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "Edit Data";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Plum;
            this.btnSave.Font = new System.Drawing.Font("Poppins Medium", 9F);
            this.btnSave.Location = new System.Drawing.Point(548, 495);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(104, 45);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save Data";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.BackgroundColor = System.Drawing.Color.ForestGreen;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDBarangDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn2,
            this.stokDataGridViewTextBoxColumn,
            this.jenisDataGridViewTextBoxColumn,
            this.hargaDataGridViewTextBoxColumn,
            this.keteranganDataGridViewTextBoxColumn,
            this.imageDataGridViewImageColumn});
            this.dataGridView.DataSource = this.barangBindingSource;
            this.dataGridView.Location = new System.Drawing.Point(12, 322);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(931, 160);
            this.dataGridView.TabIndex = 21;
            this.dataGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView_KeyDown);
            // 
            // iDBarangDataGridViewTextBoxColumn
            // 
            this.iDBarangDataGridViewTextBoxColumn.DataPropertyName = "ID Barang";
            this.iDBarangDataGridViewTextBoxColumn.HeaderText = "ID Barang";
            this.iDBarangDataGridViewTextBoxColumn.Name = "iDBarangDataGridViewTextBoxColumn";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nama Barang";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nama Barang";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // stokDataGridViewTextBoxColumn
            // 
            this.stokDataGridViewTextBoxColumn.DataPropertyName = "Stok";
            this.stokDataGridViewTextBoxColumn.HeaderText = "Stok";
            this.stokDataGridViewTextBoxColumn.Name = "stokDataGridViewTextBoxColumn";
            // 
            // jenisDataGridViewTextBoxColumn
            // 
            this.jenisDataGridViewTextBoxColumn.DataPropertyName = "Jenis";
            this.jenisDataGridViewTextBoxColumn.HeaderText = "Jenis";
            this.jenisDataGridViewTextBoxColumn.Name = "jenisDataGridViewTextBoxColumn";
            // 
            // hargaDataGridViewTextBoxColumn
            // 
            this.hargaDataGridViewTextBoxColumn.DataPropertyName = "Harga";
            this.hargaDataGridViewTextBoxColumn.HeaderText = "Harga";
            this.hargaDataGridViewTextBoxColumn.Name = "hargaDataGridViewTextBoxColumn";
            // 
            // keteranganDataGridViewTextBoxColumn
            // 
            this.keteranganDataGridViewTextBoxColumn.DataPropertyName = "Keterangan";
            this.keteranganDataGridViewTextBoxColumn.HeaderText = "Keterangan";
            this.keteranganDataGridViewTextBoxColumn.Name = "keteranganDataGridViewTextBoxColumn";
            this.keteranganDataGridViewTextBoxColumn.Width = 180;
            // 
            // imageDataGridViewImageColumn
            // 
            this.imageDataGridViewImageColumn.DataPropertyName = "Image";
            this.imageDataGridViewImageColumn.HeaderText = "Image";
            this.imageDataGridViewImageColumn.Name = "imageDataGridViewImageColumn";
            this.imageDataGridViewImageColumn.Width = 200;
            // 
            // barangTableAdapter
            // 
            this.barangTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(955, 553);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CRUD BETA MART";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appDataBrg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKeterangan;
        private System.Windows.Forms.Button btnPicture;
        private System.Windows.Forms.TextBox txtHarga;
        private System.Windows.Forms.TextBox txtJenis;
        private System.Windows.Forms.TextBox txtStok;
        private System.Windows.Forms.TextBox txtNamaBrg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnSave;
        private AppDataBrg appDataBrg;
        private System.Windows.Forms.BindingSource barangBindingSource;
        private AppDataBrgTableAdapters.BarangTableAdapter barangTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaBarangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDBarangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn stokDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jenisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hargaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn keteranganDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn imageDataGridViewImageColumn;
    }
}

