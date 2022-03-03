
namespace BaeWynCouriersApp
{
    partial class Main
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
            this.lstMenu = new System.Windows.Forms.ListBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblCurrentUser = new System.Windows.Forms.Label();
            this.grpClients = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpReports = new System.Windows.Forms.GroupBox();
            this.grpDeliveries = new System.Windows.Forms.GroupBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.grpClients.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstMenu
            // 
            this.lstMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstMenu.FormattingEnabled = true;
            this.lstMenu.ItemHeight = 24;
            this.lstMenu.Location = new System.Drawing.Point(29, 52);
            this.lstMenu.Name = "lstMenu";
            this.lstMenu.Size = new System.Drawing.Size(194, 268);
            this.lstMenu.TabIndex = 0;
            this.lstMenu.Click += new System.EventHandler(this.lstMenu_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(29, 348);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(94, 51);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblCurrentUser
            // 
            this.lblCurrentUser.AutoSize = true;
            this.lblCurrentUser.Location = new System.Drawing.Point(26, 29);
            this.lblCurrentUser.Name = "lblCurrentUser";
            this.lblCurrentUser.Size = new System.Drawing.Size(69, 13);
            this.lblCurrentUser.TabIndex = 3;
            this.lblCurrentUser.Text = "Current User:";
            // 
            // grpClients
            // 
            this.grpClients.Controls.Add(this.label1);
            this.grpClients.Location = new System.Drawing.Point(241, 29);
            this.grpClients.Name = "grpClients";
            this.grpClients.Size = new System.Drawing.Size(719, 370);
            this.grpClients.TabIndex = 4;
            this.grpClients.TabStop = false;
            this.grpClients.Text = "Clients";
            this.grpClients.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // grpReports
            // 
            this.grpReports.Location = new System.Drawing.Point(111, 11);
            this.grpReports.Name = "grpReports";
            this.grpReports.Size = new System.Drawing.Size(22, 31);
            this.grpReports.TabIndex = 5;
            this.grpReports.TabStop = false;
            this.grpReports.Text = "Reports";
            this.grpReports.Visible = false;
            // 
            // grpDeliveries
            // 
            this.grpDeliveries.Location = new System.Drawing.Point(139, 16);
            this.grpDeliveries.Name = "grpDeliveries";
            this.grpDeliveries.Size = new System.Drawing.Size(16, 26);
            this.grpDeliveries.TabIndex = 0;
            this.grpDeliveries.TabStop = false;
            this.grpDeliveries.Text = "Deliveries";
            this.grpDeliveries.Visible = false;
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(129, 348);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(94, 51);
            this.btnLogout.TabIndex = 6;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 421);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.grpReports);
            this.Controls.Add(this.grpClients);
            this.Controls.Add(this.lstMenu);
            this.Controls.Add(this.lblCurrentUser);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.grpDeliveries);
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.grpClients.ResumeLayout(false);
            this.grpClients.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstMenu;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblCurrentUser;
        private System.Windows.Forms.GroupBox grpClients;
        private System.Windows.Forms.GroupBox grpReports;
        private System.Windows.Forms.GroupBox grpDeliveries;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLogout;
    }
}