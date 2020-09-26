namespace Risk___Cahill_Edition_v._1._0
{
    partial class frmWin
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
            this.picwinnerCrest = new System.Windows.Forms.PictureBox();
            this.btnexit = new System.Windows.Forms.Button();
            this.lblmessage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picwinnerCrest)).BeginInit();
            this.SuspendLayout();
            // 
            // picwinnerCrest
            // 
            this.picwinnerCrest.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picwinnerCrest.Location = new System.Drawing.Point(106, 69);
            this.picwinnerCrest.Name = "picwinnerCrest";
            this.picwinnerCrest.Size = new System.Drawing.Size(145, 157);
            this.picwinnerCrest.TabIndex = 0;
            this.picwinnerCrest.TabStop = false;
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.Color.ForestGreen;
            this.btnexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnexit.Location = new System.Drawing.Point(124, 259);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(104, 51);
            this.btnexit.TabIndex = 2;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // lblmessage
            // 
            this.lblmessage.AutoSize = true;
            this.lblmessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblmessage.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblmessage.Location = new System.Drawing.Point(12, 9);
            this.lblmessage.Name = "lblmessage";
            this.lblmessage.Size = new System.Drawing.Size(155, 25);
            this.lblmessage.TabIndex = 3;
            this.lblmessage.Text = "Congratulations!";
            // 
            // frmWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OliveDrab;
            this.ClientSize = new System.Drawing.Size(362, 340);
            this.Controls.Add(this.lblmessage);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.picwinnerCrest);
            this.Name = "frmWin";
            this.Text = "Congratulations!";
            ((System.ComponentModel.ISupportInitialize)(this.picwinnerCrest)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picwinnerCrest;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Label lblmessage;
    }
}