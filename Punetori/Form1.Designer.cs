namespace Punetori
{
    partial class FrmRegjstroPunetor
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
            this.lblEmri = new System.Windows.Forms.Label();
            this.lblMbiemri = new System.Windows.Forms.Label();
            this.TxtEmri = new System.Windows.Forms.TextBox();
            this.txtMbiemri = new System.Windows.Forms.TextBox();
            this.btnRegjistroPunetorin = new System.Windows.Forms.Button();
            this.txtNrPersonal = new System.Windows.Forms.TextBox();
            this.txtKompania = new System.Windows.Forms.TextBox();
            this.lblListaPunetoreve = new System.Windows.Forms.Label();
            this.cmbPozita = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pbPuntori = new System.Windows.Forms.PictureBox();
            this.btnfoto = new System.Windows.Forms.Button();
            this.dtpdatelindja = new System.Windows.Forms.DateTimePicker();
            this.btnDalja = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbPuntori)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEmri
            // 
            this.lblEmri.AutoSize = true;
            this.lblEmri.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmri.Location = new System.Drawing.Point(97, 73);
            this.lblEmri.Name = "lblEmri";
            this.lblEmri.Size = new System.Drawing.Size(50, 20);
            this.lblEmri.TabIndex = 0;
            this.lblEmri.Text = "Emri:";
            // 
            // lblMbiemri
            // 
            this.lblMbiemri.AutoSize = true;
            this.lblMbiemri.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMbiemri.Location = new System.Drawing.Point(71, 101);
            this.lblMbiemri.Name = "lblMbiemri";
            this.lblMbiemri.Size = new System.Drawing.Size(76, 20);
            this.lblMbiemri.TabIndex = 4;
            this.lblMbiemri.Text = "Mbiemri:";
            // 
            // TxtEmri
            // 
            this.TxtEmri.Location = new System.Drawing.Point(157, 73);
            this.TxtEmri.Name = "TxtEmri";
            this.TxtEmri.Size = new System.Drawing.Size(182, 20);
            this.TxtEmri.TabIndex = 2;
            // 
            // txtMbiemri
            // 
            this.txtMbiemri.Location = new System.Drawing.Point(157, 101);
            this.txtMbiemri.Name = "txtMbiemri";
            this.txtMbiemri.Size = new System.Drawing.Size(182, 20);
            this.txtMbiemri.TabIndex = 3;
            // 
            // btnRegjistroPunetorin
            // 
            this.btnRegjistroPunetorin.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegjistroPunetorin.Location = new System.Drawing.Point(157, 227);
            this.btnRegjistroPunetorin.Name = "btnRegjistroPunetorin";
            this.btnRegjistroPunetorin.Size = new System.Drawing.Size(86, 32);
            this.btnRegjistroPunetorin.TabIndex = 8;
            this.btnRegjistroPunetorin.Text = "Regjistro";
            this.btnRegjistroPunetorin.UseVisualStyleBackColor = true;
            this.btnRegjistroPunetorin.Click += new System.EventHandler(this.btnRegjistroPunetorin_Click);
            // 
            // txtNrPersonal
            // 
            this.txtNrPersonal.Location = new System.Drawing.Point(157, 47);
            this.txtNrPersonal.Name = "txtNrPersonal";
            this.txtNrPersonal.Size = new System.Drawing.Size(182, 20);
            this.txtNrPersonal.TabIndex = 1;
            // 
            // txtKompania
            // 
            this.txtKompania.Location = new System.Drawing.Point(157, 153);
            this.txtKompania.Name = "txtKompania";
            this.txtKompania.Size = new System.Drawing.Size(182, 20);
            this.txtKompania.TabIndex = 5;
            // 
            // lblListaPunetoreve
            // 
            this.lblListaPunetoreve.AutoSize = true;
            this.lblListaPunetoreve.Location = new System.Drawing.Point(314, 104);
            this.lblListaPunetoreve.Name = "lblListaPunetoreve";
            this.lblListaPunetoreve.Size = new System.Drawing.Size(0, 13);
            this.lblListaPunetoreve.TabIndex = 11;
            // 
            // cmbPozita
            // 
            this.cmbPozita.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPozita.FormattingEnabled = true;
            this.cmbPozita.Items.AddRange(new object[] {
            "Punetor",
            "Shef",
            "Pastrues",
            "Menaxher"});
            this.cmbPozita.Location = new System.Drawing.Point(157, 179);
            this.cmbPozita.Name = "cmbPozita";
            this.cmbPozita.Size = new System.Drawing.Size(182, 21);
            this.cmbPozita.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Numri Personal:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(52, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Datelindja:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(54, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "Kompania:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(83, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "Pozita:";
            // 
            // pbPuntori
            // 
            this.pbPuntori.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbPuntori.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbPuntori.Location = new System.Drawing.Point(355, 47);
            this.pbPuntori.Name = "pbPuntori";
            this.pbPuntori.Size = new System.Drawing.Size(209, 153);
            this.pbPuntori.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPuntori.TabIndex = 19;
            this.pbPuntori.TabStop = false;
            // 
            // btnfoto
            // 
            this.btnfoto.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfoto.Location = new System.Drawing.Point(420, 206);
            this.btnfoto.Name = "btnfoto";
            this.btnfoto.Size = new System.Drawing.Size(82, 32);
            this.btnfoto.TabIndex = 7;
            this.btnfoto.Text = "Foto/...";
            this.btnfoto.UseVisualStyleBackColor = true;
            this.btnfoto.Click += new System.EventHandler(this.btnfoto_Click);
            // 
            // dtpdatelindja
            // 
            this.dtpdatelindja.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpdatelindja.Location = new System.Drawing.Point(157, 127);
            this.dtpdatelindja.Name = "dtpdatelindja";
            this.dtpdatelindja.Size = new System.Drawing.Size(182, 20);
            this.dtpdatelindja.TabIndex = 4;
            this.dtpdatelindja.Value = new System.DateTime(2016, 1, 12, 0, 0, 0, 0);
            // 
            // btnDalja
            // 
            this.btnDalja.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDalja.Location = new System.Drawing.Point(249, 227);
            this.btnDalja.Name = "btnDalja";
            this.btnDalja.Size = new System.Drawing.Size(90, 32);
            this.btnDalja.TabIndex = 9;
            this.btnDalja.Text = "Dalja";
            this.btnDalja.UseVisualStyleBackColor = true;
            this.btnDalja.Click += new System.EventHandler(this.btnDalja_Click);
            // 
            // FrmRegjstroPunetor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 289);
            this.Controls.Add(this.btnDalja);
            this.Controls.Add(this.dtpdatelindja);
            this.Controls.Add(this.btnfoto);
            this.Controls.Add(this.pbPuntori);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbPozita);
            this.Controls.Add(this.lblListaPunetoreve);
            this.Controls.Add(this.txtKompania);
            this.Controls.Add(this.txtNrPersonal);
            this.Controls.Add(this.btnRegjistroPunetorin);
            this.Controls.Add(this.txtMbiemri);
            this.Controls.Add(this.TxtEmri);
            this.Controls.Add(this.lblMbiemri);
            this.Controls.Add(this.lblEmri);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmRegjstroPunetor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Regjistrimi i Punetoreve";
            this.Load += new System.EventHandler(this.FrmRegjstroPunetor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbPuntori)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEmri;
        private System.Windows.Forms.Label lblMbiemri;
        private System.Windows.Forms.TextBox TxtEmri;
        private System.Windows.Forms.TextBox txtMbiemri;
        private System.Windows.Forms.Button btnRegjistroPunetorin;
        private System.Windows.Forms.TextBox txtNrPersonal;
        private System.Windows.Forms.TextBox txtKompania;
        private System.Windows.Forms.Label lblListaPunetoreve;
        private System.Windows.Forms.ComboBox cmbPozita;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pbPuntori;
        private System.Windows.Forms.Button btnfoto;
        private System.Windows.Forms.DateTimePicker dtpdatelindja;
        private System.Windows.Forms.Button btnDalja;
    }
}