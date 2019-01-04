namespace Otel.WFA.Dialogs
{
    partial class ReservationRegisterDialog
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
            this.flpPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flpPanel
            // 
            this.flpPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpPanel.Location = new System.Drawing.Point(0, 0);
            this.flpPanel.Name = "flpPanel";
            this.flpPanel.Padding = new System.Windows.Forms.Padding(20);
            this.flpPanel.Size = new System.Drawing.Size(216, 462);
            this.flpPanel.TabIndex = 0;
            // 
            // ReservationRegisterDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(216, 462);
            this.Controls.Add(this.flpPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReservationRegisterDialog";
            this.Text = "ReservationRegisterDialog";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ReservationRegisterDialog_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.FlowLayoutPanel flpPanel;
    }
}