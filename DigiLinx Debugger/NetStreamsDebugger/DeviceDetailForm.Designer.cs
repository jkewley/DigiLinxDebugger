namespace NetStreamsDebugger
{
    partial class DeviceDetailForm
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
            this.lblDeviceName = new System.Windows.Forms.Label();
            this.theLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // lblDeviceName
            // 
            this.lblDeviceName.AutoSize = true;
            this.lblDeviceName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeviceName.Location = new System.Drawing.Point(12, 9);
            this.lblDeviceName.Name = "lblDeviceName";
            this.lblDeviceName.Size = new System.Drawing.Size(114, 20);
            this.lblDeviceName.TabIndex = 0;
            this.lblDeviceName.Text = "Device Name";
            // 
            // theLayoutPanel
            // 
            this.theLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.theLayoutPanel.Location = new System.Drawing.Point(12, 33);
            this.theLayoutPanel.Name = "theLayoutPanel";
            this.theLayoutPanel.Size = new System.Drawing.Size(460, 329);
            this.theLayoutPanel.TabIndex = 1;
            // 
            // DeviceDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(484, 374);
            this.Controls.Add(this.theLayoutPanel);
            this.Controls.Add(this.lblDeviceName);
            this.Name = "DeviceDetailForm";
            this.Opacity = 0.9;
            this.Text = "DeviceDetailForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDeviceName;
        private System.Windows.Forms.FlowLayoutPanel theLayoutPanel;



    }
}