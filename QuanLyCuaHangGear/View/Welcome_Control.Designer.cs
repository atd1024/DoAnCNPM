namespace QuanLyCuaHangGear
{
    partial class Welcome_Control
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
            this.pic_BigLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_BigLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_BigLogo
            // 
            this.pic_BigLogo.Image = global::QuanLyCuaHangGear.Properties.Resources.Store_Logo;
            this.pic_BigLogo.Location = new System.Drawing.Point(375, 88);
            this.pic_BigLogo.Name = "pic_BigLogo";
            this.pic_BigLogo.Size = new System.Drawing.Size(500, 500);
            this.pic_BigLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_BigLogo.TabIndex = 0;
            this.pic_BigLogo.TabStop = false;
            // 
            // Welcome_Control
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(59)))));
            this.Controls.Add(this.pic_BigLogo);
            this.Name = "Welcome_Control";
            this.Size = new System.Drawing.Size(1250, 700);
            ((System.ComponentModel.ISupportInitialize)(this.pic_BigLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_BigLogo;
    }
}
