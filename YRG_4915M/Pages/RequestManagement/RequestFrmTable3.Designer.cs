namespace YRG_4915M.Pages.RequestManagement
{
    partial class RequestFrmTable3
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
            this.tlpInfoSearch = new System.Windows.Forms.TableLayoutPanel();
            this.dgvItemMajor = new Krypton.Toolkit.KryptonDataGridView();
            this.headerRequestQueue = new Krypton.Toolkit.KryptonHeader();
            this.tlpInfoSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemMajor)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpInfoSearch
            // 
            this.tlpInfoSearch.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tlpInfoSearch.ColumnCount = 1;
            this.tlpInfoSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpInfoSearch.Controls.Add(this.dgvItemMajor, 0, 3);
            this.tlpInfoSearch.Controls.Add(this.headerRequestQueue, 0, 2);
            this.tlpInfoSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpInfoSearch.Location = new System.Drawing.Point(0, 0);
            this.tlpInfoSearch.Name = "tlpInfoSearch";
            this.tlpInfoSearch.RowCount = 4;
            this.tlpInfoSearch.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpInfoSearch.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpInfoSearch.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpInfoSearch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpInfoSearch.Size = new System.Drawing.Size(1898, 1424);
            this.tlpInfoSearch.TabIndex = 5;
            // 
            // dgvItemMajor
            // 
            this.dgvItemMajor.AllowUserToAddRows = false;
            this.dgvItemMajor.AllowUserToDeleteRows = false;
            this.dgvItemMajor.AllowUserToResizeRows = false;
            this.dgvItemMajor.ColumnHeadersHeight = 28;
            this.dgvItemMajor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvItemMajor.Location = new System.Drawing.Point(3, 51);
            this.dgvItemMajor.Name = "dgvItemMajor";
            this.dgvItemMajor.RowHeadersWidth = 75;
            this.dgvItemMajor.RowTemplate.Height = 29;
            this.dgvItemMajor.Size = new System.Drawing.Size(1892, 1370);
            this.dgvItemMajor.TabIndex = 3;
            // 
            // headerRequestQueue
            // 
            this.headerRequestQueue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.headerRequestQueue.HeaderStyle = Krypton.Toolkit.HeaderStyle.Form;
            this.headerRequestQueue.Location = new System.Drawing.Point(2, 2);
            this.headerRequestQueue.Margin = new System.Windows.Forms.Padding(2);
            this.headerRequestQueue.Name = "headerRequestQueue";
            this.headerRequestQueue.Size = new System.Drawing.Size(1894, 44);
            this.headerRequestQueue.StateCommon.Border.Color1 = System.Drawing.Color.DarkGray;
            this.headerRequestQueue.StateCommon.Border.Color2 = System.Drawing.Color.DarkGray;
            this.headerRequestQueue.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.headerRequestQueue.StateCommon.ButtonPadding = new System.Windows.Forms.Padding(5);
            this.headerRequestQueue.StateCommon.Content.Padding = new System.Windows.Forms.Padding(5);
            this.headerRequestQueue.TabIndex = 1;
            this.headerRequestQueue.Values.Description = "";
            this.headerRequestQueue.Values.Heading = "Request Queue";
            this.headerRequestQueue.Values.Image = global::YRG_4915M.Properties.Resources.find;
            // 
            // RequestFrmTable3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1898, 1424);
            this.Controls.Add(this.tlpInfoSearch);
            this.Name = "RequestFrmTable3";
            this.Text = "YRGCPS Request Management Table3";
            this.tlpInfoSearch.ResumeLayout(false);
            this.tlpInfoSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemMajor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpInfoSearch;
        private Krypton.Toolkit.KryptonDataGridView dgvItemMajor;
        private Krypton.Toolkit.KryptonHeader headerRequestQueue;
    }
}