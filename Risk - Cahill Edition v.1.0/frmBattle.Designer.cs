namespace Risk___Cahill_Edition_v._1._0
{
    partial class frmBattle
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
            this.btnSpin = new System.Windows.Forms.Button();
            this.lblverdict = new System.Windows.Forms.Label();
            this.lbldefenders = new System.Windows.Forms.Label();
            this.lblattackers = new System.Windows.Forms.Label();
            this.picdefend1 = new System.Windows.Forms.PictureBox();
            this.picdefend2 = new System.Windows.Forms.PictureBox();
            this.picattack1 = new System.Windows.Forms.PictureBox();
            this.picattack2 = new System.Windows.Forms.PictureBox();
            this.picattack3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picdefend1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picdefend2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picattack1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picattack2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picattack3)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSpin
            // 
            this.btnSpin.Location = new System.Drawing.Point(346, 221);
            this.btnSpin.Name = "btnSpin";
            this.btnSpin.Size = new System.Drawing.Size(126, 43);
            this.btnSpin.TabIndex = 1;
            this.btnSpin.Text = "SPIN";
            this.btnSpin.UseVisualStyleBackColor = true;
            this.btnSpin.Click += new System.EventHandler(this.btnSpin_Click);
            // 
            // lblverdict
            // 
            this.lblverdict.AutoSize = true;
            this.lblverdict.BackColor = System.Drawing.Color.Transparent;
            this.lblverdict.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.lblverdict.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblverdict.Location = new System.Drawing.Point(274, 23);
            this.lblverdict.Name = "lblverdict";
            this.lblverdict.Size = new System.Drawing.Size(252, 25);
            this.lblverdict.TabIndex = 10;
            this.lblverdict.Text = "Press SPIN to start battle";
            // 
            // lbldefenders
            // 
            this.lbldefenders.AutoSize = true;
            this.lbldefenders.BackColor = System.Drawing.Color.Transparent;
            this.lbldefenders.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.lbldefenders.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbldefenders.Location = new System.Drawing.Point(112, 84);
            this.lbldefenders.Name = "lbldefenders";
            this.lbldefenders.Size = new System.Drawing.Size(0, 25);
            this.lbldefenders.TabIndex = 11;
            // 
            // lblattackers
            // 
            this.lblattackers.AutoSize = true;
            this.lblattackers.BackColor = System.Drawing.Color.Transparent;
            this.lblattackers.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.lblattackers.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblattackers.Location = new System.Drawing.Point(592, 84);
            this.lblattackers.Name = "lblattackers";
            this.lblattackers.Size = new System.Drawing.Size(0, 25);
            this.lblattackers.TabIndex = 12;
            // 
            // picdefend1
            // 
            this.picdefend1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picdefend1.Location = new System.Drawing.Point(84, 125);
            this.picdefend1.Name = "picdefend1";
            this.picdefend1.Size = new System.Drawing.Size(75, 75);
            this.picdefend1.TabIndex = 13;
            this.picdefend1.TabStop = false;
            // 
            // picdefend2
            // 
            this.picdefend2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picdefend2.Location = new System.Drawing.Point(183, 125);
            this.picdefend2.Name = "picdefend2";
            this.picdefend2.Size = new System.Drawing.Size(75, 75);
            this.picdefend2.TabIndex = 14;
            this.picdefend2.TabStop = false;
            // 
            // picattack1
            // 
            this.picattack1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picattack1.Location = new System.Drawing.Point(526, 125);
            this.picattack1.Name = "picattack1";
            this.picattack1.Size = new System.Drawing.Size(75, 75);
            this.picattack1.TabIndex = 15;
            this.picattack1.TabStop = false;
            // 
            // picattack2
            // 
            this.picattack2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picattack2.Location = new System.Drawing.Point(620, 125);
            this.picattack2.Name = "picattack2";
            this.picattack2.Size = new System.Drawing.Size(75, 75);
            this.picattack2.TabIndex = 16;
            this.picattack2.TabStop = false;
            // 
            // picattack3
            // 
            this.picattack3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picattack3.Location = new System.Drawing.Point(716, 125);
            this.picattack3.Name = "picattack3";
            this.picattack3.Size = new System.Drawing.Size(75, 75);
            this.picattack3.TabIndex = 17;
            this.picattack3.TabStop = false;
            // 
            // frmBattle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Risk___Cahill_Edition_v._1._0.Properties.Resources.prepareforbattle;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(806, 272);
            this.Controls.Add(this.picattack3);
            this.Controls.Add(this.picattack2);
            this.Controls.Add(this.picattack1);
            this.Controls.Add(this.picdefend2);
            this.Controls.Add(this.picdefend1);
            this.Controls.Add(this.lblattackers);
            this.Controls.Add(this.lbldefenders);
            this.Controls.Add(this.lblverdict);
            this.Controls.Add(this.btnSpin);
            this.Name = "frmBattle";
            this.Text = "Assault!";
            ((System.ComponentModel.ISupportInitialize)(this.picdefend1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picdefend2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picattack1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picattack2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picattack3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSpin;
        private System.Windows.Forms.Label lblverdict;
        private System.Windows.Forms.Label lbldefenders;
        private System.Windows.Forms.Label lblattackers;
        private System.Windows.Forms.PictureBox picdefend1;
        private System.Windows.Forms.PictureBox picdefend2;
        private System.Windows.Forms.PictureBox picattack1;
        private System.Windows.Forms.PictureBox picattack2;
        private System.Windows.Forms.PictureBox picattack3;
    }
}