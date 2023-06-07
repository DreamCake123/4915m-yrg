namespace ITP4915M_project_grp6_YRG
{
    partial class Logout
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
            this.lblLoggedOut = new System.Windows.Forms.Label();
            this.linkblLogin = new System.Windows.Forms.LinkLabel();
            this.lblCPS = new System.Windows.Forms.Label();
            this.lblYRGL = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblLoggedOut
            // 
            this.lblLoggedOut.AutoSize = true;
            this.lblLoggedOut.Font = new System.Drawing.Font("Garamond", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoggedOut.Location = new System.Drawing.Point(517, 390);
            this.lblLoggedOut.Name = "lblLoggedOut";
            this.lblLoggedOut.Size = new System.Drawing.Size(416, 45);
            this.lblLoggedOut.TabIndex = 0;
            this.lblLoggedOut.Text = "Successfully Logged Out!";
            // 
            // linkblLogin
            // 
            this.linkblLogin.AutoSize = true;
            this.linkblLogin.Font = new System.Drawing.Font("Garamond", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkblLogin.Location = new System.Drawing.Point(664, 562);
            this.linkblLogin.Name = "linkblLogin";
            this.linkblLogin.Size = new System.Drawing.Size(98, 40);
            this.linkblLogin.TabIndex = 1;
            this.linkblLogin.TabStop = true;
            this.linkblLogin.Text = "Login";
            this.linkblLogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkblLogin_LinkClicked);
            // 
            // lblCPS
            // 
            this.lblCPS.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCPS.AutoSize = true;
            this.lblCPS.Font = new System.Drawing.Font("Garamond", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPS.Location = new System.Drawing.Point(431, 199);
            this.lblCPS.Name = "lblCPS";
            this.lblCPS.Size = new System.Drawing.Size(556, 47);
            this.lblCPS.TabIndex = 4;
            this.lblCPS.Text = "Centralized Procurement System";
            // 
            // lblYRGL
            // 
            this.lblYRGL.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblYRGL.AutoSize = true;
            this.lblYRGL.Font = new System.Drawing.Font("Garamond", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYRGL.Location = new System.Drawing.Point(320, 123);
            this.lblYRGL.Name = "lblYRGL";
            this.lblYRGL.Size = new System.Drawing.Size(796, 59);
            this.lblYRGL.TabIndex = 3;
            this.lblYRGL.Text = "Yummy Restaurant Group Limited";
            // 
            // Logout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1438, 844);
            this.Controls.Add(this.lblCPS);
            this.Controls.Add(this.lblYRGL);
            this.Controls.Add(this.linkblLogin);
            this.Controls.Add(this.lblLoggedOut);
            this.Name = "Logout";
            this.Text = "Logout";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLoggedOut;
        private System.Windows.Forms.LinkLabel linkblLogin;
        private System.Windows.Forms.Label lblCPS;
        private System.Windows.Forms.Label lblYRGL;
    }
}