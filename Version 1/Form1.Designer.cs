namespace Version_1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.OngTren1 = new System.Windows.Forms.PictureBox();
            this.OngDuoi1 = new System.Windows.Forms.PictureBox();
            this.OngTren2 = new System.Windows.Forms.PictureBox();
            this.OngDuoi2 = new System.Windows.Forms.PictureBox();
            this.ConChim = new System.Windows.Forms.PictureBox();
            this.NutPlay = new System.Windows.Forms.PictureBox();
            this.lblDiemSo = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.OngTren1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OngDuoi1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OngTren2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OngDuoi2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConChim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NutPlay)).BeginInit();
            this.SuspendLayout();
            // 
            // OngTren1
            // 
            this.OngTren1.Image = ((System.Drawing.Image)(resources.GetObject("OngTren1.Image")));
            this.OngTren1.Location = new System.Drawing.Point(319, -706);
            this.OngTren1.Name = "OngTren1";
            this.OngTren1.Size = new System.Drawing.Size(276, 1002);
            this.OngTren1.TabIndex = 0;
            this.OngTren1.TabStop = false;
            // 
            // OngDuoi1
            // 
            this.OngDuoi1.Image = ((System.Drawing.Image)(resources.GetObject("OngDuoi1.Image")));
            this.OngDuoi1.Location = new System.Drawing.Point(319, 378);
            this.OngDuoi1.Name = "OngDuoi1";
            this.OngDuoi1.Size = new System.Drawing.Size(276, 1001);
            this.OngDuoi1.TabIndex = 1;
            this.OngDuoi1.TabStop = false;
            // 
            // OngTren2
            // 
            this.OngTren2.Image = ((System.Drawing.Image)(resources.GetObject("OngTren2.Image")));
            this.OngTren2.Location = new System.Drawing.Point(791, -716);
            this.OngTren2.Name = "OngTren2";
            this.OngTren2.Size = new System.Drawing.Size(276, 1002);
            this.OngTren2.TabIndex = 2;
            this.OngTren2.TabStop = false;
            // 
            // OngDuoi2
            // 
            this.OngDuoi2.Image = ((System.Drawing.Image)(resources.GetObject("OngDuoi2.Image")));
            this.OngDuoi2.Location = new System.Drawing.Point(791, 378);
            this.OngDuoi2.Name = "OngDuoi2";
            this.OngDuoi2.Size = new System.Drawing.Size(276, 1001);
            this.OngDuoi2.TabIndex = 3;
            this.OngDuoi2.TabStop = false;
            // 
            // ConChim
            // 
            this.ConChim.Image = ((System.Drawing.Image)(resources.GetObject("ConChim.Image")));
            this.ConChim.Location = new System.Drawing.Point(66, 358);
            this.ConChim.Name = "ConChim";
            this.ConChim.Size = new System.Drawing.Size(128, 101);
            this.ConChim.TabIndex = 4;
            this.ConChim.TabStop = false;
            // 
            // NutPlay
            // 
            this.NutPlay.Image = ((System.Drawing.Image)(resources.GetObject("NutPlay.Image")));
            this.NutPlay.Location = new System.Drawing.Point(-1, 1);
            this.NutPlay.Name = "NutPlay";
            this.NutPlay.Size = new System.Drawing.Size(51, 50);
            this.NutPlay.TabIndex = 5;
            this.NutPlay.TabStop = false;
            this.NutPlay.Click += new System.EventHandler(this.NutPlay_Click);
            // 
            // lblDiemSo
            // 
            this.lblDiemSo.AutoSize = true;
            this.lblDiemSo.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiemSo.Location = new System.Drawing.Point(1033, 1);
            this.lblDiemSo.Name = "lblDiemSo";
            this.lblDiemSo.Size = new System.Drawing.Size(88, 31);
            this.lblDiemSo.TabIndex = 6;
            this.lblDiemSo.Text = "Score:";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1190, 584);
            this.Controls.Add(this.lblDiemSo);
            this.Controls.Add(this.NutPlay);
            this.Controls.Add(this.ConChim);
            this.Controls.Add(this.OngDuoi2);
            this.Controls.Add(this.OngTren2);
            this.Controls.Add(this.OngDuoi1);
            this.Controls.Add(this.OngTren1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.OngTren1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OngDuoi1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OngTren2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OngDuoi2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConChim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NutPlay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox OngTren1;
        private System.Windows.Forms.PictureBox OngDuoi1;
        private System.Windows.Forms.PictureBox OngTren2;
        private System.Windows.Forms.PictureBox OngDuoi2;
        private System.Windows.Forms.PictureBox ConChim;
        private System.Windows.Forms.PictureBox NutPlay;
        private System.Windows.Forms.Label lblDiemSo;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}

