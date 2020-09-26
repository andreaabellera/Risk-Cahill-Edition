namespace Risk___Cahill_Edition_v._1._0
{
    partial class frmSendTroops
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
            this.numsendingTroops = new System.Windows.Forms.NumericUpDown();
            this.lblselectInstructions = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numsendingTroops)).BeginInit();
            this.SuspendLayout();
            // 
            // numsendingTroops
            // 
            this.numsendingTroops.Location = new System.Drawing.Point(143, 90);
            this.numsendingTroops.Name = "numsendingTroops";
            this.numsendingTroops.Size = new System.Drawing.Size(120, 20);
            this.numsendingTroops.TabIndex = 0;
            this.numsendingTroops.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numsendingTroops_KeyPress);
            // 
            // lblselectInstructions
            // 
            this.lblselectInstructions.AutoSize = true;
            this.lblselectInstructions.BackColor = System.Drawing.Color.Transparent;
            this.lblselectInstructions.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblselectInstructions.ForeColor = System.Drawing.Color.Maroon;
            this.lblselectInstructions.Location = new System.Drawing.Point(21, 38);
            this.lblselectInstructions.Name = "lblselectInstructions";
            this.lblselectInstructions.Size = new System.Drawing.Size(372, 18);
            this.lblselectInstructions.TabIndex = 4;
            this.lblselectInstructions.Text = "Select number of troops to send. Press ENTER to confirm";
            // 
            // frmSendTroops
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(410, 168);
            this.Controls.Add(this.lblselectInstructions);
            this.Controls.Add(this.numsendingTroops);
            this.Name = "frmSendTroops";
            this.Text = "Send Troops";
            ((System.ComponentModel.ISupportInitialize)(this.numsendingTroops)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numsendingTroops;
        private System.Windows.Forms.Label lblselectInstructions;
    }
}