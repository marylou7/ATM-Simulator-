namespace ATM_Simulator
{
    partial class StartForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartForm));
            this.btnDataRace = new System.Windows.Forms.Button();
            this.btnNoDataRace = new System.Windows.Forms.Button();
            this.lblATMmac = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDataRace
            // 
            this.btnDataRace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDataRace.Font = new System.Drawing.Font("Nirmala UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDataRace.Location = new System.Drawing.Point(162, 228);
            this.btnDataRace.Name = "btnDataRace";
            this.btnDataRace.Size = new System.Drawing.Size(256, 181);
            this.btnDataRace.TabIndex = 0;
            this.btnDataRace.Text = "Data Race";
            this.btnDataRace.UseVisualStyleBackColor = false;
            this.btnDataRace.Click += new System.EventHandler(this.btnDataRace_Click);
            // 
            // btnNoDataRace
            // 
            this.btnNoDataRace.BackColor = System.Drawing.Color.LightGreen;
            this.btnNoDataRace.Font = new System.Drawing.Font("Nirmala UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNoDataRace.Location = new System.Drawing.Point(471, 228);
            this.btnNoDataRace.Name = "btnNoDataRace";
            this.btnNoDataRace.Size = new System.Drawing.Size(256, 181);
            this.btnNoDataRace.TabIndex = 1;
            this.btnNoDataRace.Text = "Non- Data Race";
            this.btnNoDataRace.UseVisualStyleBackColor = false;
            this.btnNoDataRace.Click += new System.EventHandler(this.btnNoDataRace_Click);
            // 
            // lblATMmac
            // 
            this.lblATMmac.AutoSize = true;
            this.lblATMmac.Font = new System.Drawing.Font("Nirmala UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblATMmac.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblATMmac.Location = new System.Drawing.Point(203, 70);
            this.lblATMmac.Name = "lblATMmac";
            this.lblATMmac.Size = new System.Drawing.Size(506, 96);
            this.lblATMmac.TabIndex = 2;
            this.lblATMmac.Text = "ATM Simulator";
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(940, 574);
            this.Controls.Add(this.lblATMmac);
            this.Controls.Add(this.btnNoDataRace);
            this.Controls.Add(this.btnDataRace);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StartForm";
            this.Text = "ATM Simulator";
            this.Load += new System.EventHandler(this.StartForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDataRace;
        private System.Windows.Forms.Button btnNoDataRace;
        private System.Windows.Forms.Label lblATMmac;
    }
}