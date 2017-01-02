namespace StreamingSetupV2
{
    partial class LiveStreamControls
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
            this.youtubeVideoPlayer = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // youtubeVideoPlayer
            // 
            this.youtubeVideoPlayer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.youtubeVideoPlayer.Location = new System.Drawing.Point(568, 12);
            this.youtubeVideoPlayer.MinimumSize = new System.Drawing.Size(20, 20);
            this.youtubeVideoPlayer.Name = "youtubeVideoPlayer";
            this.youtubeVideoPlayer.Size = new System.Drawing.Size(480, 295);
            this.youtubeVideoPlayer.TabIndex = 0;
            // 
            // LiveStreamControls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 599);
            this.Controls.Add(this.youtubeVideoPlayer);
            this.Name = "LiveStreamControls";
            this.Text = "LiveStreamControls";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser youtubeVideoPlayer;
    }
}