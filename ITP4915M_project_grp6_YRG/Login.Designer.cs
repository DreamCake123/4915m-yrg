namespace ITP4915M_project_grp6_YRG
{
    partial class formLogin
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
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblYRGL = new System.Windows.Forms.Label();
            this.lblCPS = new System.Windows.Forms.Label();
            this.lblUserId = new System.Windows.Forms.Label();
            this.lblPswd = new System.Windows.Forms.Label();
            this.linklblForgot = new System.Windows.Forms.LinkLabel();
            this.txtPswd = new System.Windows.Forms.TextBox();
            this.txtUserId = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.Font = new System.Drawing.Font("Garamond", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(733, 549);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(197, 48);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "LOGIN";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblYRGL
            // 
            this.lblYRGL.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblYRGL.AutoSize = true;
            this.lblYRGL.Font = new System.Drawing.Font("Garamond", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYRGL.Location = new System.Drawing.Point(311, 147);
            this.lblYRGL.Name = "lblYRGL";
            this.lblYRGL.Size = new System.Drawing.Size(796, 59);
            this.lblYRGL.TabIndex = 1;
            this.lblYRGL.Text = "Yummy Restaurant Group Limited";
            // 
            // lblCPS
            // 
            this.lblCPS.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCPS.AutoSize = true;
            this.lblCPS.Font = new System.Drawing.Font("Garamond", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPS.Location = new System.Drawing.Point(422, 223);
            this.lblCPS.Name = "lblCPS";
            this.lblCPS.Size = new System.Drawing.Size(556, 47);
            this.lblCPS.TabIndex = 2;
            this.lblCPS.Text = "Centralized Procurement System";
            // 
            // lblUserId
            // 
            this.lblUserId.AutoSize = true;
            this.lblUserId.Font = new System.Drawing.Font("Garamond", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserId.Location = new System.Drawing.Point(525, 371);
            this.lblUserId.Name = "lblUserId";
            this.lblUserId.Size = new System.Drawing.Size(141, 36);
            this.lblUserId.TabIndex = 3;
            this.lblUserId.Text = "User ID : ";
            // 
            // lblPswd
            // 
            this.lblPswd.AutoSize = true;
            this.lblPswd.Font = new System.Drawing.Font("Garamond", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPswd.Location = new System.Drawing.Point(509, 437);
            this.lblPswd.Name = "lblPswd";
            this.lblPswd.Size = new System.Drawing.Size(157, 36);
            this.lblPswd.TabIndex = 4;
            this.lblPswd.Text = "Password : ";
            // 
            // linklblForgot
            // 
            this.linklblForgot.AutoSize = true;
            this.linklblForgot.Font = new System.Drawing.Font("Garamond", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linklblForgot.LinkColor = System.Drawing.Color.Blue;
            this.linklblForgot.Location = new System.Drawing.Point(526, 561);
            this.linklblForgot.Name = "linklblForgot";
            this.linklblForgot.Size = new System.Drawing.Size(186, 29);
            this.linklblForgot.TabIndex = 5;
            this.linklblForgot.TabStop = true;
            this.linklblForgot.Text = "Forgot Password";
            this.linklblForgot.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklblForgot_LinkClicked);
            // 
            // txtPswd
            // 
            this.txtPswd.Font = new System.Drawing.Font("Garamond", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPswd.Location = new System.Drawing.Point(687, 436);
            this.txtPswd.Name = "txtPswd";
            this.txtPswd.Size = new System.Drawing.Size(259, 41);
            this.txtPswd.TabIndex = 6;
            this.txtPswd.TextChanged += new System.EventHandler(this.txtPswd_TextChanged);
            // 
            // txtUserId
            // 
            this.txtUserId.Font = new System.Drawing.Font("Garamond", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserId.Location = new System.Drawing.Point(687, 370);
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.Size = new System.Drawing.Size(243, 41);
            this.txtUserId.TabIndex = 7;
            this.txtUserId.Text = " (e.g. 220258636)";
            this.txtUserId.TextChanged += new System.EventHandler(this.txtUserId_TextChanged);
            // 
            // formLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1438, 844);
            this.Controls.Add(this.txtUserId);
            this.Controls.Add(this.txtPswd);
            this.Controls.Add(this.linklblForgot);
            this.Controls.Add(this.lblPswd);
            this.Controls.Add(this.lblUserId);
            this.Controls.Add(this.lblCPS);
            this.Controls.Add(this.lblYRGL);
            this.Controls.Add(this.btnLogin);
            this.Name = "formLogin";
            this.Text = "Login - YRG_CPS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblYRGL;
        private System.Windows.Forms.Label lblCPS;
        private System.Windows.Forms.Label lblUserId;
        private System.Windows.Forms.Label lblPswd;
        private System.Windows.Forms.LinkLabel linklblForgot;
        private System.Windows.Forms.TextBox txtPswd;
        private System.Windows.Forms.TextBox txtUserId;
    }
}

