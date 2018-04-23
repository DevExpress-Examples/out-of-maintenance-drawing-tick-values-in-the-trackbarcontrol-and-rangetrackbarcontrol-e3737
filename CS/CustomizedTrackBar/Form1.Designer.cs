namespace CustomizedTrackBar
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
            this.customTrackBar1 = new CustomizedTrackBar.CustomTrackBar();
            this.customRangeTrackBar1 = new CustomizedRangeTrackBar.CustomRangeTrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.customTrackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customTrackBar1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customRangeTrackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customRangeTrackBar1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // customTrackBar1
            // 
            this.customTrackBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.customTrackBar1.EditValue = null;
            this.customTrackBar1.Location = new System.Drawing.Point(0, 0);
            this.customTrackBar1.Name = "customTrackBar1";
            this.customTrackBar1.Properties.TickDisplayText = "3";
            this.customTrackBar1.Properties.DrawingTick += new System.EventHandler(this.customTrackBar1_Properties_DrawingTick);
            this.customTrackBar1.Size = new System.Drawing.Size(415, 45);
            this.customTrackBar1.TabIndex = 3;
            // 
            // customRangeTrackBar1
            // 
            this.customRangeTrackBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.customRangeTrackBar1.EditValue = new DevExpress.XtraEditors.Repository.TrackBarRange(0, 0);
            this.customRangeTrackBar1.Location = new System.Drawing.Point(0, 68);
            this.customRangeTrackBar1.Name = "customRangeTrackBar1";
            this.customRangeTrackBar1.Properties.TickDisplayText = "7";
            this.customRangeTrackBar1.Properties.DrawingTick += new System.EventHandler(this.customRangeTrackBar1_Properties_DrawingTick);
            this.customRangeTrackBar1.Size = new System.Drawing.Size(415, 45);
            this.customRangeTrackBar1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 113);
            this.Controls.Add(this.customTrackBar1);
            this.Controls.Add(this.customRangeTrackBar1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.customTrackBar1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customTrackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customRangeTrackBar1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customRangeTrackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private CustomizedRangeTrackBar.CustomRangeTrackBar customRangeTrackBar1;
        private CustomTrackBar customTrackBar1;


    }
}

