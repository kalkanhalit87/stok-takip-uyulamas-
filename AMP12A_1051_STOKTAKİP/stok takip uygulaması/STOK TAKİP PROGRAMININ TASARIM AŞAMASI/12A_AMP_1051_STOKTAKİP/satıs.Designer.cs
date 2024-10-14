namespace _12A_AMP_1051_STOKTAKİP
{
    partial class satıs
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtSatisToplam = new System.Windows.Forms.TextBox();
            this.grdSatilanUrunler = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSatisIptal = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.grdSatislar = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grdSatilanUrunler)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdSatislar)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(814, 332);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Satış Toplam Fiyat";
            // 
            // txtSatisToplam
            // 
            this.txtSatisToplam.Enabled = false;
            this.txtSatisToplam.Location = new System.Drawing.Point(922, 332);
            this.txtSatisToplam.Name = "txtSatisToplam";
            this.txtSatisToplam.Size = new System.Drawing.Size(100, 20);
            this.txtSatisToplam.TabIndex = 21;
            // 
            // grdSatilanUrunler
            // 
            this.grdSatilanUrunler.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.grdSatilanUrunler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdSatilanUrunler.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.grdSatilanUrunler.Location = new System.Drawing.Point(612, 188);
            this.grdSatilanUrunler.Name = "grdSatilanUrunler";
            this.grdSatilanUrunler.Size = new System.Drawing.Size(493, 117);
            this.grdSatilanUrunler.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(814, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Satılan Ürünler";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSatisIptal);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.grdSatislar);
            this.groupBox2.Location = new System.Drawing.Point(32, 116);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(776, 263);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Satış Listesi";
            // 
            // btnSatisIptal
            // 
            this.btnSatisIptal.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSatisIptal.ImageKey = "remove-from-cart.png";
            this.btnSatisIptal.Location = new System.Drawing.Point(579, 216);
            this.btnSatisIptal.Name = "btnSatisIptal";
            this.btnSatisIptal.Size = new System.Drawing.Size(125, 36);
            this.btnSatisIptal.TabIndex = 4;
            this.btnSatisIptal.Text = "Satışı İptal Et";
            this.btnSatisIptal.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(556, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Satış Detayları";
            // 
            // grdSatislar
            // 
            this.grdSatislar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdSatislar.Location = new System.Drawing.Point(6, 11);
            this.grdSatislar.Name = "grdSatislar";
            this.grdSatislar.Size = new System.Drawing.Size(533, 233);
            this.grdSatislar.TabIndex = 0;
            // 
            // satıs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 432);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSatisToplam);
            this.Controls.Add(this.grdSatilanUrunler);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.Name = "satıs";
            this.Text = "satıs";
            ((System.ComponentModel.ISupportInitialize)(this.grdSatilanUrunler)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdSatislar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSatisToplam;
        private System.Windows.Forms.DataGridView grdSatilanUrunler;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSatisIptal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grdSatislar;
    }
}