﻿namespace DoAnC_.UI.UI_UserControl
{
    partial class ButtonProduct
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ShapanButtonProduct = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.lblgiaSP = new System.Windows.Forms.Label();
            this.lbltenSP = new System.Windows.Forms.Label();
            this.pictSP = new Guna.UI2.WinForms.Guna2PictureBox();
            this.ShapanButtonProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictSP)).BeginInit();
            this.SuspendLayout();
            // 
            // ShapanButtonProduct
            // 
            this.ShapanButtonProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ShapanButtonProduct.BackColor = System.Drawing.Color.Transparent;
            this.ShapanButtonProduct.Controls.Add(this.pictSP);
            this.ShapanButtonProduct.Controls.Add(this.lblgiaSP);
            this.ShapanButtonProduct.Controls.Add(this.lbltenSP);
            this.ShapanButtonProduct.FillColor = System.Drawing.Color.White;
            this.ShapanButtonProduct.Location = new System.Drawing.Point(16, 17);
            this.ShapanButtonProduct.Name = "ShapanButtonProduct";
            this.ShapanButtonProduct.ShadowColor = System.Drawing.Color.Black;
            this.ShapanButtonProduct.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.ForwardDiagonal;
            this.ShapanButtonProduct.Size = new System.Drawing.Size(216, 232);
            this.ShapanButtonProduct.TabIndex = 0;
            // 
            // lblgiaSP
            // 
            this.lblgiaSP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblgiaSP.AutoSize = true;
            this.lblgiaSP.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblgiaSP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            this.lblgiaSP.Location = new System.Drawing.Point(69, 195);
            this.lblgiaSP.Name = "lblgiaSP";
            this.lblgiaSP.Size = new System.Drawing.Size(70, 28);
            this.lblgiaSP.TabIndex = 0;
            this.lblgiaSP.Text = "Giá SP";
            // 
            // lbltenSP
            // 
            this.lbltenSP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbltenSP.AutoSize = true;
            this.lbltenSP.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbltenSP.ForeColor = System.Drawing.Color.Black;
            this.lbltenSP.Location = new System.Drawing.Point(72, 158);
            this.lbltenSP.Name = "lbltenSP";
            this.lbltenSP.Size = new System.Drawing.Size(67, 28);
            this.lbltenSP.TabIndex = 0;
            this.lbltenSP.Text = "TênSP";
            // 
            // pictSP
            // 
            this.pictSP.BackColor = System.Drawing.Color.Transparent;
            this.pictSP.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictSP.FillColor = System.Drawing.Color.DimGray;
            this.pictSP.Image = global::DoAnC_.Properties.Resources._default;
            this.pictSP.ImageRotate = 0F;
            this.pictSP.Location = new System.Drawing.Point(44, 14);
            this.pictSP.Name = "pictSP";
            this.pictSP.Size = new System.Drawing.Size(126, 131);
            this.pictSP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictSP.TabIndex = 1;
            this.pictSP.TabStop = false;
            // 
            // ButtonProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.ShapanButtonProduct);
            this.Name = "ButtonProduct";
            this.Size = new System.Drawing.Size(248, 266);
            this.ShapanButtonProduct.ResumeLayout(false);
            this.ShapanButtonProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictSP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowPanel ShapanButtonProduct;
        private System.Windows.Forms.Label lbltenSP;
        private System.Windows.Forms.Label lblgiaSP;
        private Guna.UI2.WinForms.Guna2PictureBox pictSP;
    }
}
