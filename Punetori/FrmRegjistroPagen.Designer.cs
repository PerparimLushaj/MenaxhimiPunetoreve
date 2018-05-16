namespace Punetori
{
    partial class FrmRegjistroPagen
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
            this.txtmuaji = new System.Windows.Forms.TextBox();
            this.txtViti = new System.Windows.Forms.TextBox();
            this.txtPaga = new System.Windows.Forms.TextBox();
            this.btnRegjistroPagen = new System.Windows.Forms.Button();
            this.gridPunetoret = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridPunetoret)).BeginInit();
            this.SuspendLayout();
            // 
            // txtmuaji
            // 
            this.txtmuaji.Location = new System.Drawing.Point(555, 38);
            this.txtmuaji.Name = "txtmuaji";
            this.txtmuaji.Size = new System.Drawing.Size(100, 20);
            this.txtmuaji.TabIndex = 2;
            // 
            // txtViti
            // 
            this.txtViti.Location = new System.Drawing.Point(555, 64);
            this.txtViti.Name = "txtViti";
            this.txtViti.Size = new System.Drawing.Size(100, 20);
            this.txtViti.TabIndex = 3;
            // 
            // txtPaga
            // 
            this.txtPaga.Location = new System.Drawing.Point(555, 12);
            this.txtPaga.Name = "txtPaga";
            this.txtPaga.Size = new System.Drawing.Size(100, 20);
            this.txtPaga.TabIndex = 1;
            // 
            // btnRegjistroPagen
            // 
            this.btnRegjistroPagen.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegjistroPagen.Location = new System.Drawing.Point(555, 105);
            this.btnRegjistroPagen.Name = "btnRegjistroPagen";
            this.btnRegjistroPagen.Size = new System.Drawing.Size(100, 30);
            this.btnRegjistroPagen.TabIndex = 4;
            this.btnRegjistroPagen.Text = "Regjistro";
            this.btnRegjistroPagen.UseVisualStyleBackColor = true;
            this.btnRegjistroPagen.Click += new System.EventHandler(this.btnRegjistroPagen_Click);
            // 
            // gridPunetoret
            // 
            this.gridPunetoret.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPunetoret.Location = new System.Drawing.Point(23, 12);
            this.gridPunetoret.MultiSelect = false;
            this.gridPunetoret.Name = "gridPunetoret";
            this.gridPunetoret.ReadOnly = true;
            this.gridPunetoret.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridPunetoret.Size = new System.Drawing.Size(475, 241);
            this.gridPunetoret.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(517, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Paga";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(517, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Muaji";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(528, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Viti";
            // 
            // FrmRegjistroPagen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 277);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridPunetoret);
            this.Controls.Add(this.btnRegjistroPagen);
            this.Controls.Add(this.txtmuaji);
            this.Controls.Add(this.txtViti);
            this.Controls.Add(this.txtPaga);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmRegjistroPagen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Regjistro Pagen";
            this.Load += new System.EventHandler(this.FrmRegjistroPagen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridPunetoret)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtmuaji;
        private System.Windows.Forms.TextBox txtViti;
        private System.Windows.Forms.TextBox txtPaga;
        private System.Windows.Forms.Button btnRegjistroPagen;
        private System.Windows.Forms.DataGridView gridPunetoret;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}