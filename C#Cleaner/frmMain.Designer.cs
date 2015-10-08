namespace CSharp_Cleaner
{
    partial class frmMain
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
            this.pnlActions = new System.Windows.Forms.Panel();
            this.btnUninstall = new System.Windows.Forms.Button();
            this.btnRefreshList = new System.Windows.Forms.Button();
            this.lstApps = new System.Windows.Forms.ListBox();
            this.pnlActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlActions
            // 
            this.pnlActions.Controls.Add(this.btnUninstall);
            this.pnlActions.Controls.Add(this.btnRefreshList);
            this.pnlActions.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlActions.Location = new System.Drawing.Point(1, 5);
            this.pnlActions.Name = "pnlActions";
            this.pnlActions.Size = new System.Drawing.Size(346, 35);
            this.pnlActions.TabIndex = 1;
            // 
            // btnUninstall
            // 
            this.btnUninstall.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUninstall.Enabled = false;
            this.btnUninstall.Location = new System.Drawing.Point(112, 0);
            this.btnUninstall.Margin = new System.Windows.Forms.Padding(4);
            this.btnUninstall.Name = "btnUninstall";
            this.btnUninstall.Size = new System.Drawing.Size(234, 35);
            this.btnUninstall.TabIndex = 3;
            this.btnUninstall.Text = "Uninstall selection";
            this.btnUninstall.UseVisualStyleBackColor = true;
            this.btnUninstall.Click += new System.EventHandler(this.btnUninstall_Click);
            // 
            // btnRefreshList
            // 
            this.btnRefreshList.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnRefreshList.Location = new System.Drawing.Point(0, 0);
            this.btnRefreshList.Margin = new System.Windows.Forms.Padding(4);
            this.btnRefreshList.Name = "btnRefreshList";
            this.btnRefreshList.Size = new System.Drawing.Size(112, 35);
            this.btnRefreshList.TabIndex = 2;
            this.btnRefreshList.Text = "Refresh";
            this.btnRefreshList.UseVisualStyleBackColor = true;
            this.btnRefreshList.Click += new System.EventHandler(this.btnRefreshList_Click);
            // 
            // lstApps
            // 
            this.lstApps.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstApps.FormattingEnabled = true;
            this.lstApps.ItemHeight = 18;
            this.lstApps.Location = new System.Drawing.Point(1, 40);
            this.lstApps.Name = "lstApps";
            this.lstApps.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstApps.Size = new System.Drawing.Size(346, 408);
            this.lstApps.TabIndex = 0;
            this.lstApps.SelectedIndexChanged += new System.EventHandler(this.lstApps_SelectedIndexChanged);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 448);
            this.Controls.Add(this.lstApps);
            this.Controls.Add(this.pnlActions);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.Padding = new System.Windows.Forms.Padding(1, 5, 1, 0);
            this.ShowIcon = false;
            this.Text = "C#Cleaner";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.pnlActions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlActions;
        private System.Windows.Forms.Button btnUninstall;
        private System.Windows.Forms.Button btnRefreshList;
        private System.Windows.Forms.ListBox lstApps;

    }
}

