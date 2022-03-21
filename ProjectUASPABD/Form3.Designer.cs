
namespace ProjectUASPABD
{
    partial class Form3
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
            this.btntmbhpmbli = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtnama = new System.Windows.Forms.TextBox();
            this.txtnohp = new System.Windows.Forms.TextBox();
            this.btnubahpmbli = new System.Windows.Forms.Button();
            this.btnhapuspmbli = new System.Windows.Forms.Button();
            this.dataGridViewpembeli = new System.Windows.Forms.DataGridView();
            this.txtidpmbli = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewpembeli)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btntmbhpmbli
            // 
            this.btntmbhpmbli.Location = new System.Drawing.Point(144, 238);
            this.btntmbhpmbli.Name = "btntmbhpmbli";
            this.btntmbhpmbli.Size = new System.Drawing.Size(142, 42);
            this.btntmbhpmbli.TabIndex = 0;
            this.btntmbhpmbli.Text = "Tambahkan";
            this.btntmbhpmbli.UseVisualStyleBackColor = true;
            this.btntmbhpmbli.Click += new System.EventHandler(this.btntmbhpmbli_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(158, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nama :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(161, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "NoHp :";
            // 
            // txtnama
            // 
            this.txtnama.Location = new System.Drawing.Point(277, 113);
            this.txtnama.Name = "txtnama";
            this.txtnama.Size = new System.Drawing.Size(443, 22);
            this.txtnama.TabIndex = 5;
            // 
            // txtnohp
            // 
            this.txtnohp.Location = new System.Drawing.Point(277, 148);
            this.txtnohp.Name = "txtnohp";
            this.txtnohp.Size = new System.Drawing.Size(443, 22);
            this.txtnohp.TabIndex = 6;
            // 
            // btnubahpmbli
            // 
            this.btnubahpmbli.Location = new System.Drawing.Point(361, 238);
            this.btnubahpmbli.Name = "btnubahpmbli";
            this.btnubahpmbli.Size = new System.Drawing.Size(142, 42);
            this.btnubahpmbli.TabIndex = 7;
            this.btnubahpmbli.Text = "Ubah";
            this.btnubahpmbli.UseVisualStyleBackColor = true;
            this.btnubahpmbli.Click += new System.EventHandler(this.btnubahpmbli_Click);
            // 
            // btnhapuspmbli
            // 
            this.btnhapuspmbli.Location = new System.Drawing.Point(582, 238);
            this.btnhapuspmbli.Name = "btnhapuspmbli";
            this.btnhapuspmbli.Size = new System.Drawing.Size(142, 42);
            this.btnhapuspmbli.TabIndex = 8;
            this.btnhapuspmbli.Text = "Hapus";
            this.btnhapuspmbli.UseVisualStyleBackColor = true;
            this.btnhapuspmbli.Click += new System.EventHandler(this.btnhapuspmbli_Click);
            // 
            // dataGridViewpembeli
            // 
            this.dataGridViewpembeli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewpembeli.Location = new System.Drawing.Point(144, 310);
            this.dataGridViewpembeli.Name = "dataGridViewpembeli";
            this.dataGridViewpembeli.RowHeadersWidth = 51;
            this.dataGridViewpembeli.RowTemplate.Height = 24;
            this.dataGridViewpembeli.Size = new System.Drawing.Size(580, 223);
            this.dataGridViewpembeli.TabIndex = 9;
            this.dataGridViewpembeli.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewpembeli_CellMouseDoubleClick);
            // 
            // txtidpmbli
            // 
            this.txtidpmbli.Location = new System.Drawing.Point(379, 210);
            this.txtidpmbli.Name = "txtidpmbli";
            this.txtidpmbli.Size = new System.Drawing.Size(100, 22);
            this.txtidpmbli.TabIndex = 10;
            this.txtidpmbli.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(355, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 32);
            this.label1.TabIndex = 11;
            this.label1.Text = "Data Pembeli ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProjectUASPABD.Properties.Resources.back;
            this.pictureBox1.Location = new System.Drawing.Point(939, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(37, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 545);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtidpmbli);
            this.Controls.Add(this.dataGridViewpembeli);
            this.Controls.Add(this.btnhapuspmbli);
            this.Controls.Add(this.btnubahpmbli);
            this.Controls.Add(this.txtnohp);
            this.Controls.Add(this.txtnama);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btntmbhpmbli);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewpembeli)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btntmbhpmbli;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtnama;
        private System.Windows.Forms.TextBox txtnohp;
        private System.Windows.Forms.Button btnubahpmbli;
        private System.Windows.Forms.Button btnhapuspmbli;
        private System.Windows.Forms.DataGridView dataGridViewpembeli;
        private System.Windows.Forms.TextBox txtidpmbli;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}