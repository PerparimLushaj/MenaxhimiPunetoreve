namespace Punetori
{
    partial class FrmHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHome));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.punetoretToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.regjistroPunetorinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.regjsitroPagatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shfaqPunetoretToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rrethNeshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtShow = new System.Windows.Forms.TextBox();
            this.btnMbyllshfaqjen = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.punetoretToolStripMenuItem,
            this.rrethNeshToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1014, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // punetoretToolStripMenuItem
            // 
            this.punetoretToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.regjistroPunetorinToolStripMenuItem,
            this.regjsitroPagatToolStripMenuItem,
            this.shfaqPunetoretToolStripMenuItem1,
            this.aToolStripMenuItem});
            this.punetoretToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.punetoretToolStripMenuItem.Name = "punetoretToolStripMenuItem";
            this.punetoretToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.punetoretToolStripMenuItem.Text = "Punëtorët";
            // 
            // regjistroPunetorinToolStripMenuItem
            // 
            this.regjistroPunetorinToolStripMenuItem.Name = "regjistroPunetorinToolStripMenuItem";
            this.regjistroPunetorinToolStripMenuItem.Size = new System.Drawing.Size(207, 24);
            this.regjistroPunetorinToolStripMenuItem.Text = "Regjistro Punëtorin";
            this.regjistroPunetorinToolStripMenuItem.Click += new System.EventHandler(this.regjistroPunetoretToolStripMenuItem_Click);
            // 
            // regjsitroPagatToolStripMenuItem
            // 
            this.regjsitroPagatToolStripMenuItem.Name = "regjsitroPagatToolStripMenuItem";
            this.regjsitroPagatToolStripMenuItem.Size = new System.Drawing.Size(207, 24);
            this.regjsitroPagatToolStripMenuItem.Text = "Regjistro Pagat";
            this.regjsitroPagatToolStripMenuItem.Click += new System.EventHandler(this.regjistroPagatToolStripMenuItem_Click);
            // 
            // shfaqPunetoretToolStripMenuItem1
            // 
            this.shfaqPunetoretToolStripMenuItem1.Name = "shfaqPunetoretToolStripMenuItem1";
            this.shfaqPunetoretToolStripMenuItem1.Size = new System.Drawing.Size(207, 24);
            this.shfaqPunetoretToolStripMenuItem1.Text = "Shfaq Punetorët";
            this.shfaqPunetoretToolStripMenuItem1.Click += new System.EventHandler(this.shfaqPunetoretToolStripMenuItem1_Click_1);
            // 
            // aToolStripMenuItem
            // 
            this.aToolStripMenuItem.Name = "aToolStripMenuItem";
            this.aToolStripMenuItem.Size = new System.Drawing.Size(207, 24);
            this.aToolStripMenuItem.Text = "Shfaq Punetoret GV";
            this.aToolStripMenuItem.Click += new System.EventHandler(this.aToolStripMenuItem_Click_1);
            // 
            // rrethNeshToolStripMenuItem
            // 
            this.rrethNeshToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rrethNeshToolStripMenuItem.Name = "rrethNeshToolStripMenuItem";
            this.rrethNeshToolStripMenuItem.Size = new System.Drawing.Size(93, 24);
            this.rrethNeshToolStripMenuItem.Text = "Rreth Nesh";
            this.rrethNeshToolStripMenuItem.Click += new System.EventHandler(this.rrethNeshToolStripMenuItem_Click);
            // 
            // txtShow
            // 
            this.txtShow.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtShow.Location = new System.Drawing.Point(334, 49);
            this.txtShow.Multiline = true;
            this.txtShow.Name = "txtShow";
            this.txtShow.ReadOnly = true;
            this.txtShow.Size = new System.Drawing.Size(437, 224);
            this.txtShow.TabIndex = 1;
            this.txtShow.Visible = false;
            // 
            // btnMbyllshfaqjen
            // 
            this.btnMbyllshfaqjen.BackColor = System.Drawing.Color.Transparent;
            this.btnMbyllshfaqjen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMbyllshfaqjen.BackgroundImage")));
            this.btnMbyllshfaqjen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMbyllshfaqjen.Location = new System.Drawing.Point(736, 16);
            this.btnMbyllshfaqjen.Name = "btnMbyllshfaqjen";
            this.btnMbyllshfaqjen.Size = new System.Drawing.Size(35, 33);
            this.btnMbyllshfaqjen.TabIndex = 2;
            this.btnMbyllshfaqjen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMbyllshfaqjen.UseVisualStyleBackColor = false;
            this.btnMbyllshfaqjen.Visible = false;
            this.btnMbyllshfaqjen.Click += new System.EventHandler(this.btnMbyllshfaqjen_Click_1);
            // 
            // FrmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1014, 447);
            this.Controls.Add(this.btnMbyllshfaqjen);
            this.Controls.Add(this.txtShow);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menaxhimi i Punetoreve";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem punetoretToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem regjistroPunetorinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rrethNeshToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem regjsitroPagatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shfaqPunetoretToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aToolStripMenuItem;
        private System.Windows.Forms.TextBox txtShow;
        private System.Windows.Forms.Button btnMbyllshfaqjen;
    }
}