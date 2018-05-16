namespace Punetori
{
    partial class frmPunetorimepaga
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNrPunetoreve = new System.Windows.Forms.Label();
            this.txtKerko = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(5, 49);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(544, 201);
            this.dataGridView1.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 263);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 14);
            this.label1.TabIndex = 20;
            this.label1.Text = "Numri i punetoreve te regjistruar eshte: ";
            // 
            // lblNrPunetoreve
            // 
            this.lblNrPunetoreve.AutoSize = true;
            this.lblNrPunetoreve.Location = new System.Drawing.Point(302, 263);
            this.lblNrPunetoreve.Name = "lblNrPunetoreve";
            this.lblNrPunetoreve.Size = new System.Drawing.Size(0, 13);
            this.lblNrPunetoreve.TabIndex = 21;
            // 
            // txtKerko
            // 
            this.txtKerko.Location = new System.Drawing.Point(141, 14);
            this.txtKerko.Name = "txtKerko";
            this.txtKerko.Size = new System.Drawing.Size(100, 20);
            this.txtKerko.TabIndex = 22;
            this.txtKerko.TextChanged += new System.EventHandler(this.txtKerko_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(2, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 14);
            this.label2.TabIndex = 23;
            this.label2.Text = "Kerko sipas emrit:";
            // 
            // frmPunetorimepaga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 286);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtKerko);
            this.Controls.Add(this.lblNrPunetoreve);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPunetorimepaga";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Punetori me pagat";
            this.Load += new System.EventHandler(this.frmPunetorimepaga_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNrPunetoreve;
        private System.Windows.Forms.TextBox txtKerko;
        private System.Windows.Forms.Label label2;
    }
}