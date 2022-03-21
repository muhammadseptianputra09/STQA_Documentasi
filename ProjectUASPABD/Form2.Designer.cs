
namespace ProjectUASPABD
{
    partial class Barang
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
            this.btnbrngtmbh = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtnamabarang = new System.Windows.Forms.TextBox();
            this.txtharga = new System.Windows.Forms.TextBox();
            this.txtjumlah = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnubahbrg = new System.Windows.Forms.Button();
            this.btnbrghapus = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtid = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnbrngtmbh
            // 
            this.btnbrngtmbh.Location = new System.Drawing.Point(136, 244);
            this.btnbrngtmbh.Name = "btnbrngtmbh";
            this.btnbrngtmbh.Size = new System.Drawing.Size(164, 39);
            this.btnbrngtmbh.TabIndex = 0;
            this.btnbrngtmbh.Text = "Tambahkan";
            this.btnbrngtmbh.UseVisualStyleBackColor = true;
            this.btnbrngtmbh.Click += new System.EventHandler(this.btnbrngtmbh_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(130, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nama_Barang :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(131, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Harga :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(130, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Jumlah :";
            // 
            // txtnamabarang
            // 
            this.txtnamabarang.Location = new System.Drawing.Point(251, 95);
            this.txtnamabarang.Name = "txtnamabarang";
            this.txtnamabarang.Size = new System.Drawing.Size(466, 22);
            this.txtnamabarang.TabIndex = 7;
            // 
            // txtharga
            // 
            this.txtharga.Location = new System.Drawing.Point(251, 142);
            this.txtharga.Name = "txtharga";
            this.txtharga.Size = new System.Drawing.Size(466, 22);
            this.txtharga.TabIndex = 8;
            // 
            // txtjumlah
            // 
            this.txtjumlah.Location = new System.Drawing.Point(251, 178);
            this.txtjumlah.Name = "txtjumlah";
            this.txtjumlah.Size = new System.Drawing.Size(466, 22);
            this.txtjumlah.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(329, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 37);
            this.label1.TabIndex = 10;
            this.label1.Text = "DATA BARANG";
            // 
            // btnubahbrg
            // 
            this.btnubahbrg.Location = new System.Drawing.Point(349, 244);
            this.btnubahbrg.Name = "btnubahbrg";
            this.btnubahbrg.Size = new System.Drawing.Size(164, 39);
            this.btnubahbrg.TabIndex = 11;
            this.btnubahbrg.Text = "Ubah";
            this.btnubahbrg.UseVisualStyleBackColor = true;
            this.btnubahbrg.Click += new System.EventHandler(this.btnubahbrg_Click);
            // 
            // btnbrghapus
            // 
            this.btnbrghapus.Location = new System.Drawing.Point(555, 244);
            this.btnbrghapus.Name = "btnbrghapus";
            this.btnbrghapus.Size = new System.Drawing.Size(164, 39);
            this.btnbrghapus.TabIndex = 12;
            this.btnbrghapus.Text = "Hapus";
            this.btnbrghapus.UseVisualStyleBackColor = true;
            this.btnbrghapus.Click += new System.EventHandler(this.btnbrghapus_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(40, 307);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(959, 245);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(790, 89);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(100, 22);
            this.txtid.TabIndex = 14;
            this.txtid.Visible = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(1015, 73);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 16;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProjectUASPABD.Properties.Resources.back;
            this.pictureBox1.Location = new System.Drawing.Point(972, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(37, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Barang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 564);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnbrghapus);
            this.Controls.Add(this.btnubahbrg);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtjumlah);
            this.Controls.Add(this.txtharga);
            this.Controls.Add(this.txtnamabarang);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnbrngtmbh);
            this.Name = "Barang";
            this.Text = "Barang";
            this.Load += new System.EventHandler(this.Barang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnbrngtmbh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtnamabarang;
        private System.Windows.Forms.TextBox txtharga;
        private System.Windows.Forms.TextBox txtjumlah;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnubahbrg;
        private System.Windows.Forms.Button btnbrghapus;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}