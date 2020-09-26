namespace Risk___Cahill_Edition_v._1._0
{
    partial class frmRisk
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
            this.btnendTurn = new System.Windows.Forms.Button();
            this.picplayerCrest = new System.Windows.Forms.PictureBox();
            this.btntrialA = new System.Windows.Forms.Button();
            this.lblplayerName = new System.Windows.Forms.Label();
            this.btnredeemTroops = new System.Windows.Forms.Button();
            this.btnsuperPower = new System.Windows.Forms.Button();
            this.btnhelp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picplayerCrest)).BeginInit();
            this.SuspendLayout();
            // 
            // btnendTurn
            // 
            this.btnendTurn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnendTurn.Location = new System.Drawing.Point(1177, 578);
            this.btnendTurn.Name = "btnendTurn";
            this.btnendTurn.Size = new System.Drawing.Size(150, 30);
            this.btnendTurn.TabIndex = 6;
            this.btnendTurn.Text = "End Turn";
            this.btnendTurn.UseVisualStyleBackColor = true;
            this.btnendTurn.Click += new System.EventHandler(this.btnendTurn_Click);
            // 
            // picplayerCrest
            // 
            this.picplayerCrest.BackColor = System.Drawing.Color.Transparent;
            this.picplayerCrest.BackgroundImage = global::Risk___Cahill_Edition_v._1._0.Properties.Resources.tomas;
            this.picplayerCrest.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picplayerCrest.Location = new System.Drawing.Point(1148, 125);
            this.picplayerCrest.Name = "picplayerCrest";
            this.picplayerCrest.Size = new System.Drawing.Size(188, 193);
            this.picplayerCrest.TabIndex = 5;
            this.picplayerCrest.TabStop = false;
            // 
            // btntrialA
            // 
            this.btntrialA.Location = new System.Drawing.Point(1177, 650);
            this.btntrialA.Name = "btntrialA";
            this.btntrialA.Size = new System.Drawing.Size(150, 30);
            this.btntrialA.TabIndex = 2;
            this.btntrialA.Text = "AUTOWIN";
            this.btntrialA.UseVisualStyleBackColor = true;
            this.btntrialA.Click += new System.EventHandler(this.btntrialA_Click);
            // 
            // lblplayerName
            // 
            this.lblplayerName.AutoSize = true;
            this.lblplayerName.BackColor = System.Drawing.Color.Transparent;
            this.lblplayerName.Font = new System.Drawing.Font("Bauhaus 93", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblplayerName.Location = new System.Drawing.Point(1187, 89);
            this.lblplayerName.Name = "lblplayerName";
            this.lblplayerName.Size = new System.Drawing.Size(105, 33);
            this.lblplayerName.TabIndex = 9;
            this.lblplayerName.Text = "TOMAS";
            // 
            // btnredeemTroops
            // 
            this.btnredeemTroops.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnredeemTroops.Location = new System.Drawing.Point(1177, 542);
            this.btnredeemTroops.Name = "btnredeemTroops";
            this.btnredeemTroops.Size = new System.Drawing.Size(150, 30);
            this.btnredeemTroops.TabIndex = 10;
            this.btnredeemTroops.Text = "Redeem Troops";
            this.btnredeemTroops.UseVisualStyleBackColor = true;
            this.btnredeemTroops.Click += new System.EventHandler(this.btnredeemTroops_Click);
            // 
            // btnsuperPower
            // 
            this.btnsuperPower.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsuperPower.Location = new System.Drawing.Point(1177, 614);
            this.btnsuperPower.Name = "btnsuperPower";
            this.btnsuperPower.Size = new System.Drawing.Size(150, 30);
            this.btnsuperPower.TabIndex = 11;
            this.btnsuperPower.Text = "Brute Force";
            this.btnsuperPower.UseVisualStyleBackColor = true;
            this.btnsuperPower.Click += new System.EventHandler(this.btnsuperPower_Click);
            // 
            // btnhelp
            // 
            this.btnhelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhelp.Location = new System.Drawing.Point(1323, 614);
            this.btnhelp.Name = "btnhelp";
            this.btnhelp.Size = new System.Drawing.Size(51, 29);
            this.btnhelp.TabIndex = 12;
            this.btnhelp.Text = "Help";
            this.btnhelp.UseVisualStyleBackColor = true;
            this.btnhelp.Click += new System.EventHandler(this.btnhelp_Click);
            // 
            // frmRisk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Risk___Cahill_Edition_v._1._0.Properties.Resources.RiskMap11;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1362, 741);
            this.Controls.Add(this.btnhelp);
            this.Controls.Add(this.btnsuperPower);
            this.Controls.Add(this.btnredeemTroops);
            this.Controls.Add(this.lblplayerName);
            this.Controls.Add(this.btnendTurn);
            this.Controls.Add(this.btntrialA);
            this.Controls.Add(this.picplayerCrest);
            this.Name = "frmRisk";
            this.Text = "Risk - Cahill Edition v.1.0";
            this.Load += new System.EventHandler(this.frmRisk_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picplayerCrest)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btntrialA;
        private System.Windows.Forms.PictureBox picplayerCrest;
        private System.Windows.Forms.Button btnendTurn;
        private System.Windows.Forms.Label lblplayerName;
        private System.Windows.Forms.Button btnredeemTroops;
        private System.Windows.Forms.Button btnsuperPower;
        private System.Windows.Forms.Button btnhelp;
    }
}

