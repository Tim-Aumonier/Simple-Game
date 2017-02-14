namespace Simple_Game
{
    partial class frmGameWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGameWindow));
            this.imglstTileImages = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // imglstTileImages
            // 
            this.imglstTileImages.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglstTileImages.ImageStream")));
            this.imglstTileImages.TransparentColor = System.Drawing.Color.Transparent;
            this.imglstTileImages.Images.SetKeyName(0, "Ground.png");
            this.imglstTileImages.Images.SetKeyName(1, "Wall.png");
            // 
            // frmGameWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 761);
            this.Name = "frmGameWindow";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imglstTileImages;
    }
}

