namespace LogMonitor.Controls
{
    partial class ucNode
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
            this.gpBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblElement = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gpBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpBox
            // 
            this.gpBox.Controls.Add(this.lblStatus);
            this.gpBox.Controls.Add(this.label4);
            this.gpBox.Controls.Add(this.lblElement);
            this.gpBox.Controls.Add(this.label1);
            this.gpBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpBox.Location = new System.Drawing.Point(0, 0);
            this.gpBox.Name = "gpBox";
            this.gpBox.Size = new System.Drawing.Size(214, 80);
            this.gpBox.TabIndex = 0;
            this.gpBox.TabStop = false;
            this.gpBox.Text = "TEXT";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Element";
            // 
            // lblElement
            // 
            this.lblElement.AutoSize = true;
            this.lblElement.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblElement.Location = new System.Drawing.Point(89, 16);
            this.lblElement.Name = "lblElement";
            this.lblElement.Size = new System.Drawing.Size(49, 20);
            this.lblElement.TabIndex = 1;
            this.lblElement.Text = "TEXT";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(89, 46);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(49, 20);
            this.lblStatus.TabIndex = 3;
            this.lblStatus.Text = "TEXT";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Status";
            // 
            // ucNode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gpBox);
            this.Name = "ucNode";
            this.Size = new System.Drawing.Size(214, 80);
            this.gpBox.ResumeLayout(false);
            this.gpBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpBox;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblElement;
        private System.Windows.Forms.Label label1;
    }
}
