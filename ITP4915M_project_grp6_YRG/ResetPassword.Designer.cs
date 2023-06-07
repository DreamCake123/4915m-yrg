namespace ITP4915M_project_grp6_YRG
{
    partial class formResetPswd
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
            this.lblYRGCPS = new System.Windows.Forms.Label();
            this.txtUserId = new System.Windows.Forms.TextBox();
            this.lblUserId = new System.Windows.Forms.Label();
            this.btnRequest = new System.Windows.Forms.Button();
            this.lblResetPswd = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.lblEnterUserId = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblYRGCPS
            // 
            this.lblYRGCPS.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblYRGCPS.AutoSize = true;
            this.lblYRGCPS.Font = new System.Drawing.Font("Garamond", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYRGCPS.Location = new System.Drawing.Point(27, 23);
            this.lblYRGCPS.Name = "lblYRGCPS";
            this.lblYRGCPS.Size = new System.Drawing.Size(253, 59);
            this.lblYRGCPS.TabIndex = 2;
            this.lblYRGCPS.Text = "YRG_CPS";
            // 
            // txtUserId
            // 
            this.txtUserId.Font = new System.Drawing.Font("Garamond", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserId.Location = new System.Drawing.Point(654, 406);
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.Size = new System.Drawing.Size(259, 41);
            this.txtUserId.TabIndex = 7;
            this.txtUserId.Text = " (e.g. 220258636)";
            this.txtUserId.TextChanged += new System.EventHandler(this.txtUserId_TextChanged);
            // 
            // lblUserId
            // 
            this.lblUserId.AutoSize = true;
            this.lblUserId.Font = new System.Drawing.Font("Garamond", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserId.Location = new System.Drawing.Point(466, 411);
            this.lblUserId.Name = "lblUserId";
            this.lblUserId.Size = new System.Drawing.Size(141, 36);
            this.lblUserId.TabIndex = 8;
            this.lblUserId.Text = "User ID : ";
            // 
            // btnRequest
            // 
            this.btnRequest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRequest.Font = new System.Drawing.Font("Garamond", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRequest.Location = new System.Drawing.Point(591, 499);
            this.btnRequest.Name = "btnRequest";
            this.btnRequest.Size = new System.Drawing.Size(197, 48);
            this.btnRequest.TabIndex = 9;
            this.btnRequest.Text = "REQUEST";
            this.btnRequest.UseVisualStyleBackColor = true;
            this.btnRequest.Click += new System.EventHandler(this.btnRequest_Click);
            // 
            // lblResetPswd
            // 
            this.lblResetPswd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblResetPswd.AutoSize = true;
            this.lblResetPswd.Font = new System.Drawing.Font("Garamond", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResetPswd.Location = new System.Drawing.Point(539, 215);
            this.lblResetPswd.Name = "lblResetPswd";
            this.lblResetPswd.Size = new System.Drawing.Size(275, 47);
            this.lblResetPswd.TabIndex = 10;
            this.lblResetPswd.Text = "Reset Password";
            // 
            // btnReturn
            // 
            this.btnReturn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReturn.Font = new System.Drawing.Font("Garamond", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.Location = new System.Drawing.Point(53, 757);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(197, 48);
            this.btnReturn.TabIndex = 11;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblEnterUserId
            // 
            this.lblEnterUserId.AutoSize = true;
            this.lblEnterUserId.Font = new System.Drawing.Font("Garamond", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterUserId.Location = new System.Drawing.Point(496, 320);
            this.lblEnterUserId.Name = "lblEnterUserId";
            this.lblEnterUserId.Size = new System.Drawing.Size(379, 40);
            this.lblEnterUserId.TabIndex = 12;
            this.lblEnterUserId.Text = "Please enter your User ID";
            // 
            // formResetPswd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1438, 844);
            this.Controls.Add(this.lblEnterUserId);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.lblResetPswd);
            this.Controls.Add(this.btnRequest);
            this.Controls.Add(this.lblUserId);
            this.Controls.Add(this.txtUserId);
            this.Controls.Add(this.lblYRGCPS);
            this.Name = "formResetPswd";
            this.Text = "Reset Password - YRG_CPS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblYRGCPS;
        private System.Windows.Forms.TextBox txtUserId;
        private System.Windows.Forms.Label lblUserId;
        private System.Windows.Forms.Button btnRequest;
        private System.Windows.Forms.Label lblResetPswd;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label lblEnterUserId;
    }
}