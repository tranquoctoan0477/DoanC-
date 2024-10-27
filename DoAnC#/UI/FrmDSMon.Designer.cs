namespace DoAnC_.UI
{
    partial class FrmDSMon
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
            this.panDSTD = new System.Windows.Forms.Panel();
            this.flPanDSTD = new System.Windows.Forms.FlowLayoutPanel();
            this.txtTimKiem = new Guna.UI2.WinForms.Guna2TextBox();
            this.panDSTD.SuspendLayout();
            this.SuspendLayout();
            // 
            // panDSTD
            // 
            this.panDSTD.Controls.Add(this.flPanDSTD);
            this.panDSTD.Location = new System.Drawing.Point(3, 43);
            this.panDSTD.Margin = new System.Windows.Forms.Padding(0);
            this.panDSTD.Name = "panDSTD";
            this.panDSTD.Size = new System.Drawing.Size(694, 562);
            this.panDSTD.TabIndex = 1;
            // 
            // flPanDSTD
            // 
            this.flPanDSTD.AutoScroll = true;
            this.flPanDSTD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flPanDSTD.Location = new System.Drawing.Point(0, 0);
            this.flPanDSTD.Name = "flPanDSTD";
            this.flPanDSTD.Size = new System.Drawing.Size(694, 562);
            this.flPanDSTD.TabIndex = 0;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Animated = true;
            this.txtTimKiem.AutoRoundedCorners = true;
            this.txtTimKiem.BorderRadius = 16;
            this.txtTimKiem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTimKiem.DefaultText = "";
            this.txtTimKiem.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTimKiem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTimKiem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimKiem.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimKiem.FillColor = System.Drawing.Color.Silver;
            this.txtTimKiem.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimKiem.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.txtTimKiem.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimKiem.IconRight = global::DoAnC_.Properties.Resources.timkiem;
            this.txtTimKiem.IconRightSize = new System.Drawing.Size(24, 24);
            this.txtTimKiem.Location = new System.Drawing.Point(9, 9);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(0);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.PasswordChar = '\0';
            this.txtTimKiem.PlaceholderText = "Tìm Kiếm...";
            this.txtTimKiem.SelectedText = "";
            this.txtTimKiem.Size = new System.Drawing.Size(395, 34);
            this.txtTimKiem.TabIndex = 0;
            // 
            // FrmDSMon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(700, 608);
            this.Controls.Add(this.panDSTD);
            this.Controls.Add(this.txtTimKiem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmDSMon";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Text = "FrmGoiMon";
            this.Load += new System.EventHandler(this.FrmDSMon_Load);
            this.panDSTD.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox txtTimKiem;
        private System.Windows.Forms.Panel panDSTD;
        private System.Windows.Forms.FlowLayoutPanel flPanDSTD;
    }
}