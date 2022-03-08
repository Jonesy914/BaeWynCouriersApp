
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
            this.btnClientClear = new System.Windows.Forms.Button();
            this.txtClientId = new System.Windows.Forms.TextBox();
            this.btnSearchClients = new System.Windows.Forms.Button();
            this.btnUpdateClient = new System.Windows.Forms.Button();
            this.btnAddClient = new System.Windows.Forms.Button();
            this.dgvClients = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chkContracted = new System.Windows.Forms.CheckBox();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtBusinessName = new System.Windows.Forms.TextBox();
            this.grpReports = new System.Windows.Forms.GroupBox();
            this.grpDeliveries = new System.Windows.Forms.GroupBox();
            this.pnlDelCourierControl = new System.Windows.Forms.Panel();
            this.btnAcceptDelivery = new System.Windows.Forms.Button();
            this.btnCompleteDelivery = new System.Windows.Forms.Button();
            this.pnlDelAdminControl = new System.Windows.Forms.Panel();
            this.btnCancelDelivery = new System.Windows.Forms.Button();
            this.btnUpdateDelivery = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbDelClientId = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpDelDate = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbTimeBlockId = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnAddDelivery = new System.Windows.Forms.Button();
            this.cmbDelUserId = new System.Windows.Forms.ComboBox();
            this.txtDelStatus = new System.Windows.Forms.TextBox();
            this.txtDeliveryId = new System.Windows.Forms.TextBox();
            this.btnSearchDeliveries = new System.Windows.Forms.Button();
            this.dgvDeliveries = new System.Windows.Forms.DataGridView();
            this.btnLogout = new System.Windows.Forms.Button();
            this.tabReports = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.grpClients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClients)).BeginInit();
            this.grpReports.SuspendLayout();
            this.grpDeliveries.SuspendLayout();
            this.pnlDelCourierControl.SuspendLayout();
            this.pnlDelAdminControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeliveries)).BeginInit();
            this.tabReports.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstMenu
            // 
            this.lstMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstMenu.FormattingEnabled = true;
            this.lstMenu.ItemHeight = 24;
            this.lstMenu.Location = new System.Drawing.Point(29, 39);
            this.lstMenu.Name = "lstMenu";
            this.lstMenu.Size = new System.Drawing.Size(194, 364);
            this.lstMenu.TabIndex = 0;
            this.lstMenu.Click += new System.EventHandler(this.lstMenu_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Navy;
            this.btnExit.Location = new System.Drawing.Point(30, 427);
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
            this.lblCurrentUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentUser.ForeColor = System.Drawing.Color.Navy;
            this.lblCurrentUser.Location = new System.Drawing.Point(26, 12);
            this.lblCurrentUser.Name = "lblCurrentUser";
            this.lblCurrentUser.Size = new System.Drawing.Size(98, 16);
            this.lblCurrentUser.TabIndex = 3;
            this.lblCurrentUser.Text = "Current User:";
            // 
            // grpClients
            // 
            this.grpClients.Controls.Add(this.btnClientClear);
            this.grpClients.Controls.Add(this.txtClientId);
            this.grpClients.Controls.Add(this.btnSearchClients);
            this.grpClients.Controls.Add(this.btnUpdateClient);
            this.grpClients.Controls.Add(this.btnAddClient);
            this.grpClients.Controls.Add(this.dgvClients);
            this.grpClients.Controls.Add(this.label7);
            this.grpClients.Controls.Add(this.label6);
            this.grpClients.Controls.Add(this.label5);
            this.grpClients.Controls.Add(this.label4);
            this.grpClients.Controls.Add(this.label3);
            this.grpClients.Controls.Add(this.label2);
            this.grpClients.Controls.Add(this.chkContracted);
            this.grpClients.Controls.Add(this.txtNotes);
            this.grpClients.Controls.Add(this.txtEmail);
            this.grpClients.Controls.Add(this.txtPhoneNumber);
            this.grpClients.Controls.Add(this.txtAddress);
            this.grpClients.Controls.Add(this.txtBusinessName);
            this.grpClients.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpClients.ForeColor = System.Drawing.Color.Navy;
            this.grpClients.Location = new System.Drawing.Point(189, 7);
            this.grpClients.Name = "grpClients";
            this.grpClients.Size = new System.Drawing.Size(22, 26);
            this.grpClients.TabIndex = 4;
            this.grpClients.TabStop = false;
            this.grpClients.Text = "Clients";
            this.grpClients.Visible = false;
            // 
            // btnClientClear
            // 
            this.btnClientClear.Location = new System.Drawing.Point(411, 164);
            this.btnClientClear.Name = "btnClientClear";
            this.btnClientClear.Size = new System.Drawing.Size(138, 34);
            this.btnClientClear.TabIndex = 19;
            this.btnClientClear.Text = "Clear Fields";
            this.btnClientClear.UseVisualStyleBackColor = true;
            this.btnClientClear.Click += new System.EventHandler(this.btnClientClear_Click);
            // 
            // txtClientId
            // 
            this.txtClientId.Location = new System.Drawing.Point(350, 170);
            this.txtClientId.Name = "txtClientId";
            this.txtClientId.ReadOnly = true;
            this.txtClientId.Size = new System.Drawing.Size(23, 22);
            this.txtClientId.TabIndex = 18;
            // 
            // btnSearchClients
            // 
            this.btnSearchClients.Location = new System.Drawing.Point(555, 164);
            this.btnSearchClients.Name = "btnSearchClients";
            this.btnSearchClients.Size = new System.Drawing.Size(138, 34);
            this.btnSearchClients.TabIndex = 17;
            this.btnSearchClients.Text = "Search";
            this.btnSearchClients.UseVisualStyleBackColor = true;
            this.btnSearchClients.Click += new System.EventHandler(this.btnSearchClients_Click);
            // 
            // btnUpdateClient
            // 
            this.btnUpdateClient.Location = new System.Drawing.Point(166, 164);
            this.btnUpdateClient.Name = "btnUpdateClient";
            this.btnUpdateClient.Size = new System.Drawing.Size(138, 34);
            this.btnUpdateClient.TabIndex = 16;
            this.btnUpdateClient.Text = "Update Client";
            this.btnUpdateClient.UseVisualStyleBackColor = true;
            this.btnUpdateClient.Click += new System.EventHandler(this.btnUpdateClient_Click);
            // 
            // btnAddClient
            // 
            this.btnAddClient.Location = new System.Drawing.Point(22, 164);
            this.btnAddClient.Name = "btnAddClient";
            this.btnAddClient.Size = new System.Drawing.Size(138, 34);
            this.btnAddClient.TabIndex = 15;
            this.btnAddClient.Text = "Add Client";
            this.btnAddClient.UseVisualStyleBackColor = true;
            this.btnAddClient.Click += new System.EventHandler(this.btnAddClient_Click);
            // 
            // dgvClients
            // 
            this.dgvClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClients.Location = new System.Drawing.Point(22, 214);
            this.dgvClients.Name = "dgvClients";
            this.dgvClients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClients.Size = new System.Drawing.Size(671, 220);
            this.dgvClients.TabIndex = 14;
            this.dgvClients.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClients_CellClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(52, 133);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label7.Size = new System.Drawing.Size(83, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Contracted";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(361, 26);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label6.Size = new System.Drawing.Size(49, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Notes";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(88, 110);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(47, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 82);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(110, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Phone Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 54);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(66, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 26);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(116, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Business Name";
            // 
            // chkContracted
            // 
            this.chkContracted.AutoSize = true;
            this.chkContracted.Location = new System.Drawing.Point(141, 135);
            this.chkContracted.Name = "chkContracted";
            this.chkContracted.Size = new System.Drawing.Size(15, 14);
            this.chkContracted.TabIndex = 6;
            this.chkContracted.UseVisualStyleBackColor = true;
            // 
            // txtNotes
            // 
            this.txtNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNotes.Location = new System.Drawing.Point(416, 23);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(277, 106);
            this.txtNotes.TabIndex = 5;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(141, 107);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(193, 22);
            this.txtEmail.TabIndex = 4;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhoneNumber.Location = new System.Drawing.Point(141, 79);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(193, 22);
            this.txtPhoneNumber.TabIndex = 3;
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(141, 51);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(193, 22);
            this.txtAddress.TabIndex = 2;
            // 
            // txtBusinessName
            // 
            this.txtBusinessName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusinessName.Location = new System.Drawing.Point(141, 23);
            this.txtBusinessName.Name = "txtBusinessName";
            this.txtBusinessName.Size = new System.Drawing.Size(193, 22);
            this.txtBusinessName.TabIndex = 1;
            // 
            // grpReports
            // 
            this.grpReports.Controls.Add(this.tabReports);
            this.grpReports.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpReports.ForeColor = System.Drawing.Color.Navy;
            this.grpReports.Location = new System.Drawing.Point(241, 29);
            this.grpReports.Name = "grpReports";
            this.grpReports.Size = new System.Drawing.Size(719, 449);
            this.grpReports.TabIndex = 5;
            this.grpReports.TabStop = false;
            this.grpReports.Text = "Reports";
            this.grpReports.Visible = false;
            // 
            // grpDeliveries
            // 
            this.grpDeliveries.Controls.Add(this.pnlDelCourierControl);
            this.grpDeliveries.Controls.Add(this.pnlDelAdminControl);
            this.grpDeliveries.Controls.Add(this.txtDelStatus);
            this.grpDeliveries.Controls.Add(this.txtDeliveryId);
            this.grpDeliveries.Controls.Add(this.btnSearchDeliveries);
            this.grpDeliveries.Controls.Add(this.dgvDeliveries);
            this.grpDeliveries.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDeliveries.ForeColor = System.Drawing.Color.Navy;
            this.grpDeliveries.Location = new System.Drawing.Point(217, 9);
            this.grpDeliveries.Name = "grpDeliveries";
            this.grpDeliveries.Size = new System.Drawing.Size(13, 21);
            this.grpDeliveries.TabIndex = 0;
            this.grpDeliveries.TabStop = false;
            this.grpDeliveries.Text = "Deliveries";
            this.grpDeliveries.Visible = false;
            // 
            // pnlDelCourierControl
            // 
            this.pnlDelCourierControl.Controls.Add(this.btnAcceptDelivery);
            this.pnlDelCourierControl.Controls.Add(this.btnCompleteDelivery);
            this.pnlDelCourierControl.Location = new System.Drawing.Point(542, 34);
            this.pnlDelCourierControl.Name = "pnlDelCourierControl";
            this.pnlDelCourierControl.Size = new System.Drawing.Size(147, 76);
            this.pnlDelCourierControl.TabIndex = 28;
            this.pnlDelCourierControl.Visible = false;
            // 
            // btnAcceptDelivery
            // 
            this.btnAcceptDelivery.Location = new System.Drawing.Point(0, 0);
            this.btnAcceptDelivery.Name = "btnAcceptDelivery";
            this.btnAcceptDelivery.Size = new System.Drawing.Size(147, 34);
            this.btnAcceptDelivery.TabIndex = 21;
            this.btnAcceptDelivery.Tag = "";
            this.btnAcceptDelivery.Text = "Accept Delivery";
            this.btnAcceptDelivery.UseVisualStyleBackColor = true;
            this.btnAcceptDelivery.Click += new System.EventHandler(this.btnAcceptDelivery_Click);
            // 
            // btnCompleteDelivery
            // 
            this.btnCompleteDelivery.Location = new System.Drawing.Point(0, 40);
            this.btnCompleteDelivery.Name = "btnCompleteDelivery";
            this.btnCompleteDelivery.Size = new System.Drawing.Size(147, 34);
            this.btnCompleteDelivery.TabIndex = 22;
            this.btnCompleteDelivery.Tag = "";
            this.btnCompleteDelivery.Text = "Complete Delivery";
            this.btnCompleteDelivery.UseVisualStyleBackColor = true;
            this.btnCompleteDelivery.Click += new System.EventHandler(this.btnCompleteDelivery_Click);
            // 
            // pnlDelAdminControl
            // 
            this.pnlDelAdminControl.Controls.Add(this.btnCancelDelivery);
            this.pnlDelAdminControl.Controls.Add(this.btnUpdateDelivery);
            this.pnlDelAdminControl.Controls.Add(this.label1);
            this.pnlDelAdminControl.Controls.Add(this.cmbDelClientId);
            this.pnlDelAdminControl.Controls.Add(this.label8);
            this.pnlDelAdminControl.Controls.Add(this.dtpDelDate);
            this.pnlDelAdminControl.Controls.Add(this.label9);
            this.pnlDelAdminControl.Controls.Add(this.cmbTimeBlockId);
            this.pnlDelAdminControl.Controls.Add(this.label10);
            this.pnlDelAdminControl.Controls.Add(this.btnAddDelivery);
            this.pnlDelAdminControl.Controls.Add(this.cmbDelUserId);
            this.pnlDelAdminControl.Location = new System.Drawing.Point(14, 21);
            this.pnlDelAdminControl.Name = "pnlDelAdminControl";
            this.pnlDelAdminControl.Size = new System.Drawing.Size(462, 177);
            this.pnlDelAdminControl.TabIndex = 27;
            this.pnlDelAdminControl.Visible = false;
            // 
            // btnCancelDelivery
            // 
            this.btnCancelDelivery.Location = new System.Drawing.Point(310, 136);
            this.btnCancelDelivery.Name = "btnCancelDelivery";
            this.btnCancelDelivery.Size = new System.Drawing.Size(138, 34);
            this.btnCancelDelivery.TabIndex = 25;
            this.btnCancelDelivery.Tag = "";
            this.btnCancelDelivery.Text = "Cancel Delivery";
            this.btnCancelDelivery.UseVisualStyleBackColor = true;
            this.btnCancelDelivery.Click += new System.EventHandler(this.btnCancelDelivery_Click);
            // 
            // btnUpdateDelivery
            // 
            this.btnUpdateDelivery.Location = new System.Drawing.Point(166, 136);
            this.btnUpdateDelivery.Name = "btnUpdateDelivery";
            this.btnUpdateDelivery.Size = new System.Drawing.Size(138, 34);
            this.btnUpdateDelivery.TabIndex = 20;
            this.btnUpdateDelivery.Tag = "";
            this.btnUpdateDelivery.Text = "Update Delivery";
            this.btnUpdateDelivery.UseVisualStyleBackColor = true;
            this.btnUpdateDelivery.Click += new System.EventHandler(this.btnUpdateDelivery_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 10);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 10;
            this.label1.Tag = "";
            this.label1.Text = "Client";
            // 
            // cmbDelClientId
            // 
            this.cmbDelClientId.FormattingEnabled = true;
            this.cmbDelClientId.Location = new System.Drawing.Point(117, 7);
            this.cmbDelClientId.Name = "cmbDelClientId";
            this.cmbDelClientId.Size = new System.Drawing.Size(227, 24);
            this.cmbDelClientId.TabIndex = 11;
            this.cmbDelClientId.Tag = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 40);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label8.Size = new System.Drawing.Size(103, 16);
            this.label8.TabIndex = 12;
            this.label8.Tag = "";
            this.label8.Text = "Delivery Date";
            // 
            // dtpDelDate
            // 
            this.dtpDelDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDelDate.Location = new System.Drawing.Point(117, 37);
            this.dtpDelDate.Name = "dtpDelDate";
            this.dtpDelDate.Size = new System.Drawing.Size(227, 22);
            this.dtpDelDate.TabIndex = 13;
            this.dtpDelDate.Tag = "";
            this.dtpDelDate.Leave += new System.EventHandler(this.dtpDelDate_Leave);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 68);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label9.Size = new System.Drawing.Size(105, 16);
            this.label9.TabIndex = 14;
            this.label9.Tag = "";
            this.label9.Text = "Delivery Time";
            // 
            // cmbTimeBlockId
            // 
            this.cmbTimeBlockId.FormattingEnabled = true;
            this.cmbTimeBlockId.Location = new System.Drawing.Point(117, 65);
            this.cmbTimeBlockId.Name = "cmbTimeBlockId";
            this.cmbTimeBlockId.Size = new System.Drawing.Size(227, 24);
            this.cmbTimeBlockId.TabIndex = 15;
            this.cmbTimeBlockId.Tag = "";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(47, 98);
            this.label10.Name = "label10";
            this.label10.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label10.Size = new System.Drawing.Size(58, 16);
            this.label10.TabIndex = 16;
            this.label10.Tag = "";
            this.label10.Text = "Courier";
            // 
            // btnAddDelivery
            // 
            this.btnAddDelivery.Location = new System.Drawing.Point(22, 136);
            this.btnAddDelivery.Name = "btnAddDelivery";
            this.btnAddDelivery.Size = new System.Drawing.Size(138, 34);
            this.btnAddDelivery.TabIndex = 19;
            this.btnAddDelivery.Tag = "";
            this.btnAddDelivery.Text = "Add Delivery";
            this.btnAddDelivery.UseVisualStyleBackColor = true;
            this.btnAddDelivery.Click += new System.EventHandler(this.btnAddDelivery_Click);
            // 
            // cmbDelUserId
            // 
            this.cmbDelUserId.FormattingEnabled = true;
            this.cmbDelUserId.Location = new System.Drawing.Point(117, 95);
            this.cmbDelUserId.Name = "cmbDelUserId";
            this.cmbDelUserId.Size = new System.Drawing.Size(227, 24);
            this.cmbDelUserId.TabIndex = 17;
            this.cmbDelUserId.Tag = "";
            // 
            // txtDelStatus
            // 
            this.txtDelStatus.Location = new System.Drawing.Point(666, 119);
            this.txtDelStatus.Name = "txtDelStatus";
            this.txtDelStatus.ReadOnly = true;
            this.txtDelStatus.Size = new System.Drawing.Size(23, 22);
            this.txtDelStatus.TabIndex = 26;
            // 
            // txtDeliveryId
            // 
            this.txtDeliveryId.Location = new System.Drawing.Point(513, 163);
            this.txtDeliveryId.Name = "txtDeliveryId";
            this.txtDeliveryId.ReadOnly = true;
            this.txtDeliveryId.Size = new System.Drawing.Size(23, 22);
            this.txtDeliveryId.TabIndex = 24;
            // 
            // btnSearchDeliveries
            // 
            this.btnSearchDeliveries.Location = new System.Drawing.Point(542, 157);
            this.btnSearchDeliveries.Name = "btnSearchDeliveries";
            this.btnSearchDeliveries.Size = new System.Drawing.Size(147, 34);
            this.btnSearchDeliveries.TabIndex = 23;
            this.btnSearchDeliveries.Text = "Search";
            this.btnSearchDeliveries.UseVisualStyleBackColor = true;
            this.btnSearchDeliveries.Click += new System.EventHandler(this.btnSearchDeliveries_Click);
            // 
            // dgvDeliveries
            // 
            this.dgvDeliveries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDeliveries.Location = new System.Drawing.Point(18, 213);
            this.dgvDeliveries.Name = "dgvDeliveries";
            this.dgvDeliveries.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDeliveries.Size = new System.Drawing.Size(671, 220);
            this.dgvDeliveries.TabIndex = 18;
            this.dgvDeliveries.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDeliveries_CellClick);
            // 
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.Navy;
            this.btnLogout.Location = new System.Drawing.Point(130, 427);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(94, 51);
            this.btnLogout.TabIndex = 6;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // tabReports
            // 
            this.tabReports.Controls.Add(this.tabPage1);
            this.tabReports.Controls.Add(this.tabPage2);
            this.tabReports.Controls.Add(this.tabPage3);
            this.tabReports.Controls.Add(this.tabPage4);
            this.tabReports.Location = new System.Drawing.Point(3, 18);
            this.tabReports.Name = "tabReports";
            this.tabReports.SelectedIndex = 0;
            this.tabReports.Size = new System.Drawing.Size(716, 431);
            this.tabReports.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(708, 402);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Courier Assignments";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(708, 402);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Month\'s Assignments";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(708, 402);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Contract/Non-Contract";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(708, 402);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Month\'s Client Value";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 490);
            this.ControlBox = false;
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.grpReports);
            this.Controls.Add(this.grpClients);
            this.Controls.Add(this.lstMenu);
            this.Controls.Add(this.lblCurrentUser);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.grpDeliveries);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BaeWyn Couriers";
            this.Load += new System.EventHandler(this.Main_Load);
            this.grpClients.ResumeLayout(false);
            this.grpClients.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClients)).EndInit();
            this.grpReports.ResumeLayout(false);
            this.grpDeliveries.ResumeLayout(false);
            this.grpDeliveries.PerformLayout();
            this.pnlDelCourierControl.ResumeLayout(false);
            this.pnlDelAdminControl.ResumeLayout(false);
            this.pnlDelAdminControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeliveries)).EndInit();
            this.tabReports.ResumeLayout(false);
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
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnUpdateClient;
        private System.Windows.Forms.Button btnAddClient;
        private System.Windows.Forms.DataGridView dgvClients;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkContracted;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtBusinessName;
        private System.Windows.Forms.Button btnSearchClients;
        private System.Windows.Forms.TextBox txtClientId;
        private System.Windows.Forms.DateTimePicker dtpDelDate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbDelClientId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCompleteDelivery;
        private System.Windows.Forms.Button btnAcceptDelivery;
        private System.Windows.Forms.Button btnUpdateDelivery;
        private System.Windows.Forms.Button btnAddDelivery;
        private System.Windows.Forms.DataGridView dgvDeliveries;
        private System.Windows.Forms.ComboBox cmbDelUserId;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbTimeBlockId;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnSearchDeliveries;
        private System.Windows.Forms.TextBox txtDeliveryId;
        private System.Windows.Forms.Button btnCancelDelivery;
        private System.Windows.Forms.TextBox txtDelStatus;
        private System.Windows.Forms.Button btnClientClear;
        private System.Windows.Forms.Panel pnlDelAdminControl;
        private System.Windows.Forms.Panel pnlDelCourierControl;
        private System.Windows.Forms.TabControl tabReports;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
    }
}