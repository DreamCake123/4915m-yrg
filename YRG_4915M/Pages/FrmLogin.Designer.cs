namespace YRG_4915M
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblForgotPswd = new System.Windows.Forms.Label();
            this.lblUserID = new System.Windows.Forms.Label();
            this.lblPswd = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.txtPswd = new System.Windows.Forms.TextBox();
            this.btnCancelLogin = new System.Windows.Forms.Button();
            this.kryptonTableLayoutPanel1 = new Krypton.Toolkit.KryptonTableLayoutPanel();
            this.lblCPS = new System.Windows.Forms.Label();
            this.lblYRG = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.kryptonTableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.lblForgotPswd, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblUserID, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblPswd, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnLogin, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtUserID, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtPswd, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnCancelLogin, 2, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 188);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(978, 436);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // lblForgotPswd
            // 
            this.lblForgotPswd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblForgotPswd.AutoSize = true;
            this.lblForgotPswd.Font = new System.Drawing.Font("Garamond", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForgotPswd.ForeColor = System.Drawing.Color.Blue;
            this.lblForgotPswd.Location = new System.Drawing.Point(554, 308);
            this.lblForgotPswd.Name = "lblForgotPswd";
            this.lblForgotPswd.Size = new System.Drawing.Size(170, 25);
            this.lblForgotPswd.TabIndex = 15;
            this.lblForgotPswd.Text = "Forgot Password ?";
            this.lblForgotPswd.Click += new System.EventHandler(this.lblForgotPswd_Click);
            // 
            // lblUserID
            // 
            this.lblUserID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUserID.AutoSize = true;
            this.lblUserID.Font = new System.Drawing.Font("Garamond", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserID.Location = new System.Drawing.Point(280, 92);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(117, 31);
            this.lblUserID.TabIndex = 10;
            this.lblUserID.Text = "User ID :";
            // 
            // lblPswd
            // 
            this.lblPswd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPswd.AutoSize = true;
            this.lblPswd.Font = new System.Drawing.Font("Garamond", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPswd.Location = new System.Drawing.Point(274, 172);
            this.lblPswd.Name = "lblPswd";
            this.lblPswd.Size = new System.Drawing.Size(130, 31);
            this.lblPswd.TabIndex = 11;
            this.lblPswd.Text = "Password :";
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLogin.Font = new System.Drawing.Font("Garamond", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(268, 244);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(141, 48);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtUserID
            // 
            this.txtUserID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUserID.Font = new System.Drawing.Font("Garamond", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserID.Location = new System.Drawing.Point(509, 88);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(259, 39);
            this.txtUserID.TabIndex = 9;
            // 
            // txtPswd
            // 
            this.txtPswd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPswd.Font = new System.Drawing.Font("Garamond", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPswd.Location = new System.Drawing.Point(509, 168);
            this.txtPswd.Name = "txtPswd";
            this.txtPswd.Size = new System.Drawing.Size(259, 39);
            this.txtPswd.TabIndex = 12;
            // 
            // btnCancelLogin
            // 
            this.btnCancelLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancelLogin.Font = new System.Drawing.Font("Garamond", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelLogin.Location = new System.Drawing.Point(571, 245);
            this.btnCancelLogin.Name = "btnCancelLogin";
            this.btnCancelLogin.Size = new System.Drawing.Size(135, 46);
            this.btnCancelLogin.TabIndex = 7;
            this.btnCancelLogin.Text = "Cancel";
            this.btnCancelLogin.UseVisualStyleBackColor = true;
            this.btnCancelLogin.Click += new System.EventHandler(this.btnCancelLogin_Click);
            // 
            // kryptonTableLayoutPanel1
            // 
            this.kryptonTableLayoutPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("kryptonTableLayoutPanel1.BackgroundImage")));
            this.kryptonTableLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.kryptonTableLayoutPanel1.ColumnCount = 3;
            this.kryptonTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.kryptonTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.kryptonTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.kryptonTableLayoutPanel1.Controls.Add(this.lblYRG, 1, 1);
            this.kryptonTableLayoutPanel1.Controls.Add(this.lblCPS, 1, 2);
            this.kryptonTableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonTableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonTableLayoutPanel1.Name = "kryptonTableLayoutPanel1";
            this.kryptonTableLayoutPanel1.RowCount = 4;
            this.kryptonTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.kryptonTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.kryptonTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.kryptonTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.kryptonTableLayoutPanel1.Size = new System.Drawing.Size(978, 188);
            this.kryptonTableLayoutPanel1.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.kryptonTableLayoutPanel1.StateCommon.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.kryptonTableLayoutPanel1.TabIndex = 7;
            // 
            // lblCPS
            // 
            this.lblCPS.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblCPS.AutoSize = true;
            this.lblCPS.Font = new System.Drawing.Font("Garamond", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPS.Location = new System.Drawing.Point(199, 98);
            this.lblCPS.Name = "lblCPS";
            this.lblCPS.Size = new System.Drawing.Size(579, 50);
            this.lblCPS.TabIndex = 16;
            this.lblCPS.Text = "Centralized Procurement System";
            this.lblCPS.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lblYRG
            // 
            this.lblYRG.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblYRG.AutoSize = true;
            this.lblYRG.Font = new System.Drawing.Font("Garamond", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYRG.Location = new System.Drawing.Point(185, 39);
            this.lblYRG.Name = "lblYRG";
            this.lblYRG.Size = new System.Drawing.Size(607, 59);
            this.lblYRG.TabIndex = 15;
            this.lblYRG.Text = "Yummy Restaurant Group";
            this.lblYRG.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(978, 624);
            this.Controls.Add(this.kryptonTableLayoutPanel1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FrmLogin";
            this.Text = "Login - YRGCPS";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.kryptonTableLayoutPanel1.ResumeLayout(false);
            this.kryptonTableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.Button btnCancelLogin;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblPswd;
        private System.Windows.Forms.TextBox txtPswd;
        private System.Windows.Forms.Label lblForgotPswd;
        private Krypton.Toolkit.KryptonTableLayoutPanel kryptonTableLayoutPanel1;
        private System.Windows.Forms.Label lblYRG;
        private System.Windows.Forms.Label lblCPS;
    }
}