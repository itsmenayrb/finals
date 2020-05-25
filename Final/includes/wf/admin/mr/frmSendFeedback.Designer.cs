namespace Final.includes.wf.admin.mr
{
    partial class frmSendFeedback
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSendFeedback));
            this.btnBack = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gbTicketID = new Guna.UI2.WinForms.Guna2GroupBox();
            this.gbFindings = new Guna.UI2.WinForms.Guna2GroupBox();
            this.rdbSoftwareRelated = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rdbHardwareRelated = new Guna.UI2.WinForms.Guna2RadioButton();
            this.gbFindingSelection = new Guna.UI2.WinForms.Guna2GroupBox();
            this.gbNewStatus = new Guna.UI2.WinForms.Guna2GroupBox();
            this.rdbCondemned = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rdbDefective = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rdbWorking = new Guna.UI2.WinForms.Guna2RadioButton();
            this.cbItemHavingIssue = new Guna.UI2.WinForms.Guna2ComboBox();
            this.rdbOthers = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rdbApplicationSoftware = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rdbHardwareItems = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rdbComputerUnit = new Guna.UI2.WinForms.Guna2RadioButton();
            this.gbActionTaken = new Guna.UI2.WinForms.Guna2GroupBox();
            this.cbReplaceWith = new Guna.UI2.WinForms.Guna2ComboBox();
            this.rdbReinstall = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rdbTroubleshoot = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rdbReplaceWith = new Guna.UI2.WinForms.Guna2RadioButton();
            this.gbFeedback = new Guna.UI2.WinForms.Guna2GroupBox();
            this.txtFeedback = new Guna.UI.WinForms.GunaTextBox();
            this.gbJobRequestStatus = new Guna.UI2.WinForms.Guna2GroupBox();
            this.rdbOngoing = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rdbCompleted = new Guna.UI2.WinForms.Guna2RadioButton();
            this.btnSendFeedback = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gbFindings.SuspendLayout();
            this.gbFindingSelection.SuspendLayout();
            this.gbNewStatus.SuspendLayout();
            this.gbActionTaken.SuspendLayout();
            this.gbFeedback.SuspendLayout();
            this.gbJobRequestStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.AnimationHoverSpeed = 0.07F;
            this.btnBack.AnimationSpeed = 0.03F;
            this.btnBack.BaseColor = System.Drawing.Color.White;
            this.btnBack.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.btnBack.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.btnBack.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnBack.CheckedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnBack.CheckedImage = null;
            this.btnBack.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnBack.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnBack.FocusedColor = System.Drawing.Color.Empty;
            this.btnBack.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.ImageOffsetX = 8;
            this.btnBack.ImageSize = new System.Drawing.Size(15, 15);
            this.btnBack.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnBack.Location = new System.Drawing.Point(-1, 12);
            this.btnBack.Margin = new System.Windows.Forms.Padding(0);
            this.btnBack.Name = "btnBack";
            this.btnBack.OnHoverBaseColor = System.Drawing.Color.White;
            this.btnBack.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnBack.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnBack.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("btnBack.OnHoverImage")));
            this.btnBack.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnBack.OnPressedColor = System.Drawing.Color.Black;
            this.btnBack.Size = new System.Drawing.Size(112, 22);
            this.btnBack.TabIndex = 211;
            this.btnBack.TabStop = false;
            this.btnBack.Text = "Back";
            this.btnBack.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // gbTicketID
            // 
            this.gbTicketID.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
            this.gbTicketID.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.gbTicketID.CustomBorderThickness = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.gbTicketID.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTicketID.ForeColor = System.Drawing.Color.Black;
            this.gbTicketID.Location = new System.Drawing.Point(66, 43);
            this.gbTicketID.Name = "gbTicketID";
            this.gbTicketID.ShadowDecoration.Parent = this.gbTicketID;
            this.gbTicketID.Size = new System.Drawing.Size(567, 27);
            this.gbTicketID.TabIndex = 213;
            this.gbTicketID.Text = "Ticket ID:";
            this.gbTicketID.TextOffset = new System.Drawing.Point(5, -7);
            // 
            // gbFindings
            // 
            this.gbFindings.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
            this.gbFindings.Controls.Add(this.rdbSoftwareRelated);
            this.gbFindings.Controls.Add(this.rdbHardwareRelated);
            this.gbFindings.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(240)))), ((int)(((byte)(248)))));
            this.gbFindings.CustomBorderThickness = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.gbFindings.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFindings.ForeColor = System.Drawing.Color.Black;
            this.gbFindings.Location = new System.Drawing.Point(66, 76);
            this.gbFindings.Name = "gbFindings";
            this.gbFindings.ShadowDecoration.Parent = this.gbFindings;
            this.gbFindings.Size = new System.Drawing.Size(567, 37);
            this.gbFindings.TabIndex = 214;
            this.gbFindings.Text = "Findings:";
            this.gbFindings.TextOffset = new System.Drawing.Point(5, -7);
            // 
            // rdbSoftwareRelated
            // 
            this.rdbSoftwareRelated.AutoSize = true;
            this.rdbSoftwareRelated.BackColor = System.Drawing.Color.Transparent;
            this.rdbSoftwareRelated.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdbSoftwareRelated.CheckedState.BorderThickness = 0;
            this.rdbSoftwareRelated.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdbSoftwareRelated.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rdbSoftwareRelated.CheckedState.InnerOffset = -4;
            this.rdbSoftwareRelated.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.rdbSoftwareRelated.Location = new System.Drawing.Point(313, 8);
            this.rdbSoftwareRelated.Name = "rdbSoftwareRelated";
            this.rdbSoftwareRelated.Size = new System.Drawing.Size(131, 21);
            this.rdbSoftwareRelated.TabIndex = 216;
            this.rdbSoftwareRelated.Text = "Software-Related";
            this.rdbSoftwareRelated.UncheckedState.BorderColor = System.Drawing.Color.Silver;
            this.rdbSoftwareRelated.UncheckedState.BorderThickness = 1;
            this.rdbSoftwareRelated.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.rdbSoftwareRelated.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rdbSoftwareRelated.UseVisualStyleBackColor = false;
            // 
            // rdbHardwareRelated
            // 
            this.rdbHardwareRelated.AutoSize = true;
            this.rdbHardwareRelated.BackColor = System.Drawing.Color.Transparent;
            this.rdbHardwareRelated.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdbHardwareRelated.CheckedState.BorderThickness = 0;
            this.rdbHardwareRelated.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdbHardwareRelated.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rdbHardwareRelated.CheckedState.InnerOffset = -4;
            this.rdbHardwareRelated.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.rdbHardwareRelated.Location = new System.Drawing.Point(105, 8);
            this.rdbHardwareRelated.Name = "rdbHardwareRelated";
            this.rdbHardwareRelated.Size = new System.Drawing.Size(135, 21);
            this.rdbHardwareRelated.TabIndex = 215;
            this.rdbHardwareRelated.Text = "Hardware-Related";
            this.rdbHardwareRelated.UncheckedState.BorderColor = System.Drawing.Color.Silver;
            this.rdbHardwareRelated.UncheckedState.BorderThickness = 1;
            this.rdbHardwareRelated.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.rdbHardwareRelated.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rdbHardwareRelated.UseVisualStyleBackColor = false;
            this.rdbHardwareRelated.CheckedChanged += new System.EventHandler(this.rdbHardwareRelated_CheckedChanged);
            // 
            // gbFindingSelection
            // 
            this.gbFindingSelection.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
            this.gbFindingSelection.Controls.Add(this.gbNewStatus);
            this.gbFindingSelection.Controls.Add(this.cbItemHavingIssue);
            this.gbFindingSelection.Controls.Add(this.rdbOthers);
            this.gbFindingSelection.Controls.Add(this.rdbApplicationSoftware);
            this.gbFindingSelection.Controls.Add(this.rdbHardwareItems);
            this.gbFindingSelection.Controls.Add(this.rdbComputerUnit);
            this.gbFindingSelection.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(240)))), ((int)(((byte)(248)))));
            this.gbFindingSelection.CustomBorderThickness = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.gbFindingSelection.Enabled = false;
            this.gbFindingSelection.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFindingSelection.ForeColor = System.Drawing.Color.Black;
            this.gbFindingSelection.Location = new System.Drawing.Point(66, 119);
            this.gbFindingSelection.Name = "gbFindingSelection";
            this.gbFindingSelection.ShadowDecoration.Parent = this.gbFindingSelection;
            this.gbFindingSelection.Size = new System.Drawing.Size(567, 173);
            this.gbFindingSelection.TabIndex = 215;
            this.gbFindingSelection.TextOffset = new System.Drawing.Point(5, -7);
            // 
            // gbNewStatus
            // 
            this.gbNewStatus.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
            this.gbNewStatus.Controls.Add(this.rdbCondemned);
            this.gbNewStatus.Controls.Add(this.rdbDefective);
            this.gbNewStatus.Controls.Add(this.rdbWorking);
            this.gbNewStatus.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(240)))), ((int)(((byte)(248)))));
            this.gbNewStatus.CustomBorderThickness = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.gbNewStatus.Enabled = false;
            this.gbNewStatus.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbNewStatus.ForeColor = System.Drawing.Color.Black;
            this.gbNewStatus.Location = new System.Drawing.Point(55, 103);
            this.gbNewStatus.Name = "gbNewStatus";
            this.gbNewStatus.ShadowDecoration.Parent = this.gbNewStatus;
            this.gbNewStatus.Size = new System.Drawing.Size(457, 56);
            this.gbNewStatus.TabIndex = 216;
            this.gbNewStatus.Text = "New status of this item";
            this.gbNewStatus.TextOffset = new System.Drawing.Point(5, -7);
            // 
            // rdbCondemned
            // 
            this.rdbCondemned.AutoSize = true;
            this.rdbCondemned.BackColor = System.Drawing.Color.Transparent;
            this.rdbCondemned.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdbCondemned.CheckedState.BorderThickness = 0;
            this.rdbCondemned.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdbCondemned.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rdbCondemned.CheckedState.InnerOffset = -4;
            this.rdbCondemned.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.rdbCondemned.Location = new System.Drawing.Point(298, 27);
            this.rdbCondemned.Name = "rdbCondemned";
            this.rdbCondemned.Size = new System.Drawing.Size(100, 21);
            this.rdbCondemned.TabIndex = 218;
            this.rdbCondemned.Text = "Condemned";
            this.rdbCondemned.UncheckedState.BorderColor = System.Drawing.Color.Silver;
            this.rdbCondemned.UncheckedState.BorderThickness = 1;
            this.rdbCondemned.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.rdbCondemned.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rdbCondemned.UseVisualStyleBackColor = false;
            // 
            // rdbDefective
            // 
            this.rdbDefective.AutoSize = true;
            this.rdbDefective.BackColor = System.Drawing.Color.Transparent;
            this.rdbDefective.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdbDefective.CheckedState.BorderThickness = 0;
            this.rdbDefective.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdbDefective.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rdbDefective.CheckedState.InnerOffset = -4;
            this.rdbDefective.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.rdbDefective.Location = new System.Drawing.Point(180, 27);
            this.rdbDefective.Name = "rdbDefective";
            this.rdbDefective.Size = new System.Drawing.Size(87, 21);
            this.rdbDefective.TabIndex = 217;
            this.rdbDefective.Text = "Defective";
            this.rdbDefective.UncheckedState.BorderColor = System.Drawing.Color.Silver;
            this.rdbDefective.UncheckedState.BorderThickness = 1;
            this.rdbDefective.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.rdbDefective.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rdbDefective.UseVisualStyleBackColor = false;
            // 
            // rdbWorking
            // 
            this.rdbWorking.AutoSize = true;
            this.rdbWorking.BackColor = System.Drawing.Color.Transparent;
            this.rdbWorking.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdbWorking.CheckedState.BorderThickness = 0;
            this.rdbWorking.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdbWorking.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rdbWorking.CheckedState.InnerOffset = -4;
            this.rdbWorking.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.rdbWorking.Location = new System.Drawing.Point(73, 27);
            this.rdbWorking.Name = "rdbWorking";
            this.rdbWorking.Size = new System.Drawing.Size(75, 21);
            this.rdbWorking.TabIndex = 216;
            this.rdbWorking.Text = "Working";
            this.rdbWorking.UncheckedState.BorderColor = System.Drawing.Color.Silver;
            this.rdbWorking.UncheckedState.BorderThickness = 1;
            this.rdbWorking.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.rdbWorking.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rdbWorking.UseVisualStyleBackColor = false;
            // 
            // cbItemHavingIssue
            // 
            this.cbItemHavingIssue.BackColor = System.Drawing.Color.Transparent;
            this.cbItemHavingIssue.BorderColor = System.Drawing.Color.Silver;
            this.cbItemHavingIssue.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbItemHavingIssue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbItemHavingIssue.Enabled = false;
            this.cbItemHavingIssue.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.cbItemHavingIssue.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbItemHavingIssue.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbItemHavingIssue.FocusedState.Parent = this.cbItemHavingIssue;
            this.cbItemHavingIssue.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.cbItemHavingIssue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbItemHavingIssue.HoverState.Parent = this.cbItemHavingIssue;
            this.cbItemHavingIssue.ItemHeight = 28;
            this.cbItemHavingIssue.Items.AddRange(new object[] {
            "--Select the computer unit or item that having issue with--"});
            this.cbItemHavingIssue.ItemsAppearance.Parent = this.cbItemHavingIssue;
            this.cbItemHavingIssue.Location = new System.Drawing.Point(55, 63);
            this.cbItemHavingIssue.Name = "cbItemHavingIssue";
            this.cbItemHavingIssue.ShadowDecoration.Parent = this.cbItemHavingIssue;
            this.cbItemHavingIssue.Size = new System.Drawing.Size(457, 34);
            this.cbItemHavingIssue.StartIndex = 0;
            this.cbItemHavingIssue.TabIndex = 219;
            this.cbItemHavingIssue.SelectedIndexChanged += new System.EventHandler(this.cbItemHavingIssue_SelectedIndexChanged);
            // 
            // rdbOthers
            // 
            this.rdbOthers.AutoSize = true;
            this.rdbOthers.BackColor = System.Drawing.Color.Transparent;
            this.rdbOthers.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdbOthers.CheckedState.BorderThickness = 0;
            this.rdbOthers.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdbOthers.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rdbOthers.CheckedState.InnerOffset = -4;
            this.rdbOthers.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.rdbOthers.Location = new System.Drawing.Point(313, 36);
            this.rdbOthers.Name = "rdbOthers";
            this.rdbOthers.Size = new System.Drawing.Size(65, 21);
            this.rdbOthers.TabIndex = 218;
            this.rdbOthers.Text = "Others";
            this.rdbOthers.UncheckedState.BorderColor = System.Drawing.Color.Silver;
            this.rdbOthers.UncheckedState.BorderThickness = 1;
            this.rdbOthers.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.rdbOthers.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rdbOthers.UseVisualStyleBackColor = false;
            // 
            // rdbApplicationSoftware
            // 
            this.rdbApplicationSoftware.AutoSize = true;
            this.rdbApplicationSoftware.BackColor = System.Drawing.Color.Transparent;
            this.rdbApplicationSoftware.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdbApplicationSoftware.CheckedState.BorderThickness = 0;
            this.rdbApplicationSoftware.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdbApplicationSoftware.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rdbApplicationSoftware.CheckedState.InnerOffset = -4;
            this.rdbApplicationSoftware.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.rdbApplicationSoftware.Location = new System.Drawing.Point(313, 9);
            this.rdbApplicationSoftware.Name = "rdbApplicationSoftware";
            this.rdbApplicationSoftware.Size = new System.Drawing.Size(155, 21);
            this.rdbApplicationSoftware.TabIndex = 217;
            this.rdbApplicationSoftware.Text = "Application/Software";
            this.rdbApplicationSoftware.UncheckedState.BorderColor = System.Drawing.Color.Silver;
            this.rdbApplicationSoftware.UncheckedState.BorderThickness = 1;
            this.rdbApplicationSoftware.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.rdbApplicationSoftware.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rdbApplicationSoftware.UseVisualStyleBackColor = false;
            this.rdbApplicationSoftware.CheckedChanged += new System.EventHandler(this.rdbApplicationSoftware_CheckedChanged);
            // 
            // rdbHardwareItems
            // 
            this.rdbHardwareItems.AutoSize = true;
            this.rdbHardwareItems.BackColor = System.Drawing.Color.Transparent;
            this.rdbHardwareItems.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdbHardwareItems.CheckedState.BorderThickness = 0;
            this.rdbHardwareItems.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdbHardwareItems.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rdbHardwareItems.CheckedState.InnerOffset = -4;
            this.rdbHardwareItems.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.rdbHardwareItems.Location = new System.Drawing.Point(105, 36);
            this.rdbHardwareItems.Name = "rdbHardwareItems";
            this.rdbHardwareItems.Size = new System.Drawing.Size(120, 21);
            this.rdbHardwareItems.TabIndex = 216;
            this.rdbHardwareItems.Text = "Hardware-items";
            this.rdbHardwareItems.UncheckedState.BorderColor = System.Drawing.Color.Silver;
            this.rdbHardwareItems.UncheckedState.BorderThickness = 1;
            this.rdbHardwareItems.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.rdbHardwareItems.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rdbHardwareItems.UseVisualStyleBackColor = false;
            // 
            // rdbComputerUnit
            // 
            this.rdbComputerUnit.AutoSize = true;
            this.rdbComputerUnit.BackColor = System.Drawing.Color.Transparent;
            this.rdbComputerUnit.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdbComputerUnit.CheckedState.BorderThickness = 0;
            this.rdbComputerUnit.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdbComputerUnit.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rdbComputerUnit.CheckedState.InnerOffset = -4;
            this.rdbComputerUnit.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.rdbComputerUnit.Location = new System.Drawing.Point(105, 9);
            this.rdbComputerUnit.Name = "rdbComputerUnit";
            this.rdbComputerUnit.Size = new System.Drawing.Size(112, 21);
            this.rdbComputerUnit.TabIndex = 215;
            this.rdbComputerUnit.Text = "Computer Unit";
            this.rdbComputerUnit.UncheckedState.BorderColor = System.Drawing.Color.Silver;
            this.rdbComputerUnit.UncheckedState.BorderThickness = 1;
            this.rdbComputerUnit.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.rdbComputerUnit.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rdbComputerUnit.UseVisualStyleBackColor = false;
            this.rdbComputerUnit.CheckedChanged += new System.EventHandler(this.rdbComputerUnit_CheckedChanged);
            // 
            // gbActionTaken
            // 
            this.gbActionTaken.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
            this.gbActionTaken.Controls.Add(this.cbReplaceWith);
            this.gbActionTaken.Controls.Add(this.rdbReinstall);
            this.gbActionTaken.Controls.Add(this.rdbTroubleshoot);
            this.gbActionTaken.Controls.Add(this.rdbReplaceWith);
            this.gbActionTaken.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(173)))), ((int)(((byte)(1)))));
            this.gbActionTaken.CustomBorderThickness = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.gbActionTaken.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbActionTaken.ForeColor = System.Drawing.Color.Black;
            this.gbActionTaken.Location = new System.Drawing.Point(66, 298);
            this.gbActionTaken.Name = "gbActionTaken";
            this.gbActionTaken.ShadowDecoration.Parent = this.gbActionTaken;
            this.gbActionTaken.Size = new System.Drawing.Size(567, 104);
            this.gbActionTaken.TabIndex = 216;
            this.gbActionTaken.Text = "Action Taken:";
            this.gbActionTaken.TextOffset = new System.Drawing.Point(5, -7);
            // 
            // cbReplaceWith
            // 
            this.cbReplaceWith.BackColor = System.Drawing.Color.Transparent;
            this.cbReplaceWith.BorderColor = System.Drawing.Color.Silver;
            this.cbReplaceWith.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbReplaceWith.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbReplaceWith.Enabled = false;
            this.cbReplaceWith.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.cbReplaceWith.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbReplaceWith.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbReplaceWith.FocusedState.Parent = this.cbReplaceWith;
            this.cbReplaceWith.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.cbReplaceWith.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbReplaceWith.HoverState.Parent = this.cbReplaceWith;
            this.cbReplaceWith.ItemHeight = 28;
            this.cbReplaceWith.Items.AddRange(new object[] {
            "--Select new computer unit or item--"});
            this.cbReplaceWith.ItemsAppearance.Parent = this.cbReplaceWith;
            this.cbReplaceWith.Location = new System.Drawing.Point(215, 8);
            this.cbReplaceWith.Name = "cbReplaceWith";
            this.cbReplaceWith.ShadowDecoration.Parent = this.cbReplaceWith;
            this.cbReplaceWith.Size = new System.Drawing.Size(297, 34);
            this.cbReplaceWith.StartIndex = 0;
            this.cbReplaceWith.TabIndex = 220;
            // 
            // rdbReinstall
            // 
            this.rdbReinstall.AutoSize = true;
            this.rdbReinstall.BackColor = System.Drawing.Color.Transparent;
            this.rdbReinstall.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdbReinstall.CheckedState.BorderThickness = 0;
            this.rdbReinstall.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdbReinstall.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rdbReinstall.CheckedState.InnerOffset = -4;
            this.rdbReinstall.Enabled = false;
            this.rdbReinstall.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.rdbReinstall.Location = new System.Drawing.Point(105, 70);
            this.rdbReinstall.Name = "rdbReinstall";
            this.rdbReinstall.Size = new System.Drawing.Size(79, 21);
            this.rdbReinstall.TabIndex = 218;
            this.rdbReinstall.Text = "Re-install";
            this.rdbReinstall.UncheckedState.BorderColor = System.Drawing.Color.Silver;
            this.rdbReinstall.UncheckedState.BorderThickness = 1;
            this.rdbReinstall.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.rdbReinstall.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rdbReinstall.UseVisualStyleBackColor = false;
            // 
            // rdbTroubleshoot
            // 
            this.rdbTroubleshoot.AutoSize = true;
            this.rdbTroubleshoot.BackColor = System.Drawing.Color.Transparent;
            this.rdbTroubleshoot.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdbTroubleshoot.CheckedState.BorderThickness = 0;
            this.rdbTroubleshoot.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdbTroubleshoot.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rdbTroubleshoot.CheckedState.InnerOffset = -4;
            this.rdbTroubleshoot.Enabled = false;
            this.rdbTroubleshoot.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.rdbTroubleshoot.Location = new System.Drawing.Point(105, 43);
            this.rdbTroubleshoot.Name = "rdbTroubleshoot";
            this.rdbTroubleshoot.Size = new System.Drawing.Size(102, 21);
            this.rdbTroubleshoot.TabIndex = 217;
            this.rdbTroubleshoot.Text = "Troubleshoot";
            this.rdbTroubleshoot.UncheckedState.BorderColor = System.Drawing.Color.Silver;
            this.rdbTroubleshoot.UncheckedState.BorderThickness = 1;
            this.rdbTroubleshoot.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.rdbTroubleshoot.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rdbTroubleshoot.UseVisualStyleBackColor = false;
            // 
            // rdbReplaceWith
            // 
            this.rdbReplaceWith.AutoSize = true;
            this.rdbReplaceWith.BackColor = System.Drawing.Color.Transparent;
            this.rdbReplaceWith.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdbReplaceWith.CheckedState.BorderThickness = 0;
            this.rdbReplaceWith.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdbReplaceWith.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rdbReplaceWith.CheckedState.InnerOffset = -4;
            this.rdbReplaceWith.Enabled = false;
            this.rdbReplaceWith.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.rdbReplaceWith.Location = new System.Drawing.Point(105, 16);
            this.rdbReplaceWith.Name = "rdbReplaceWith";
            this.rdbReplaceWith.Size = new System.Drawing.Size(104, 21);
            this.rdbReplaceWith.TabIndex = 216;
            this.rdbReplaceWith.Text = "Replace with";
            this.rdbReplaceWith.UncheckedState.BorderColor = System.Drawing.Color.Silver;
            this.rdbReplaceWith.UncheckedState.BorderThickness = 1;
            this.rdbReplaceWith.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.rdbReplaceWith.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rdbReplaceWith.UseVisualStyleBackColor = false;
            // 
            // gbFeedback
            // 
            this.gbFeedback.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
            this.gbFeedback.Controls.Add(this.txtFeedback);
            this.gbFeedback.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.gbFeedback.CustomBorderThickness = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.gbFeedback.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFeedback.ForeColor = System.Drawing.Color.Black;
            this.gbFeedback.Location = new System.Drawing.Point(66, 408);
            this.gbFeedback.Name = "gbFeedback";
            this.gbFeedback.ShadowDecoration.Parent = this.gbFeedback;
            this.gbFeedback.Size = new System.Drawing.Size(567, 75);
            this.gbFeedback.TabIndex = 217;
            this.gbFeedback.Text = "Feedback:";
            this.gbFeedback.TextOffset = new System.Drawing.Point(5, -7);
            // 
            // txtFeedback
            // 
            this.txtFeedback.BackColor = System.Drawing.Color.Transparent;
            this.txtFeedback.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.txtFeedback.BorderColor = System.Drawing.Color.Silver;
            this.txtFeedback.BorderSize = 1;
            this.txtFeedback.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFeedback.FocusedBaseColor = System.Drawing.Color.White;
            this.txtFeedback.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.txtFeedback.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtFeedback.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFeedback.Location = new System.Drawing.Point(105, 10);
            this.txtFeedback.Margin = new System.Windows.Forms.Padding(2);
            this.txtFeedback.Multiline = true;
            this.txtFeedback.Name = "txtFeedback";
            this.txtFeedback.PasswordChar = '\0';
            this.txtFeedback.SelectedText = "";
            this.txtFeedback.Size = new System.Drawing.Size(407, 55);
            this.txtFeedback.TabIndex = 131;
            this.txtFeedback.TextOffsetX = 5;
            // 
            // gbJobRequestStatus
            // 
            this.gbJobRequestStatus.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
            this.gbJobRequestStatus.Controls.Add(this.rdbOngoing);
            this.gbJobRequestStatus.Controls.Add(this.rdbCompleted);
            this.gbJobRequestStatus.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(240)))), ((int)(((byte)(248)))));
            this.gbJobRequestStatus.CustomBorderThickness = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.gbJobRequestStatus.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbJobRequestStatus.ForeColor = System.Drawing.Color.Black;
            this.gbJobRequestStatus.Location = new System.Drawing.Point(66, 489);
            this.gbJobRequestStatus.Name = "gbJobRequestStatus";
            this.gbJobRequestStatus.ShadowDecoration.Parent = this.gbJobRequestStatus;
            this.gbJobRequestStatus.Size = new System.Drawing.Size(567, 37);
            this.gbJobRequestStatus.TabIndex = 218;
            this.gbJobRequestStatus.Text = "Status:";
            this.gbJobRequestStatus.TextOffset = new System.Drawing.Point(5, -7);
            // 
            // rdbOngoing
            // 
            this.rdbOngoing.AutoSize = true;
            this.rdbOngoing.BackColor = System.Drawing.Color.Transparent;
            this.rdbOngoing.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdbOngoing.CheckedState.BorderThickness = 0;
            this.rdbOngoing.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdbOngoing.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rdbOngoing.CheckedState.InnerOffset = -4;
            this.rdbOngoing.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.rdbOngoing.Location = new System.Drawing.Point(313, 8);
            this.rdbOngoing.Name = "rdbOngoing";
            this.rdbOngoing.Size = new System.Drawing.Size(77, 21);
            this.rdbOngoing.TabIndex = 216;
            this.rdbOngoing.Text = "Ongoing";
            this.rdbOngoing.UncheckedState.BorderColor = System.Drawing.Color.Silver;
            this.rdbOngoing.UncheckedState.BorderThickness = 1;
            this.rdbOngoing.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.rdbOngoing.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rdbOngoing.UseVisualStyleBackColor = false;
            // 
            // rdbCompleted
            // 
            this.rdbCompleted.AutoSize = true;
            this.rdbCompleted.BackColor = System.Drawing.Color.Transparent;
            this.rdbCompleted.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdbCompleted.CheckedState.BorderThickness = 0;
            this.rdbCompleted.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdbCompleted.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rdbCompleted.CheckedState.InnerOffset = -4;
            this.rdbCompleted.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.rdbCompleted.Location = new System.Drawing.Point(105, 8);
            this.rdbCompleted.Name = "rdbCompleted";
            this.rdbCompleted.Size = new System.Drawing.Size(94, 21);
            this.rdbCompleted.TabIndex = 215;
            this.rdbCompleted.Text = "Completed";
            this.rdbCompleted.UncheckedState.BorderColor = System.Drawing.Color.Silver;
            this.rdbCompleted.UncheckedState.BorderThickness = 1;
            this.rdbCompleted.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.rdbCompleted.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rdbCompleted.UseVisualStyleBackColor = false;
            // 
            // btnSendFeedback
            // 
            this.btnSendFeedback.AnimationHoverSpeed = 0.07F;
            this.btnSendFeedback.AnimationSpeed = 0.03F;
            this.btnSendFeedback.BaseColor = System.Drawing.Color.White;
            this.btnSendFeedback.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.btnSendFeedback.BorderSize = 1;
            this.btnSendFeedback.Checked = true;
            this.btnSendFeedback.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.btnSendFeedback.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnSendFeedback.CheckedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnSendFeedback.CheckedImage = null;
            this.btnSendFeedback.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnSendFeedback.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSendFeedback.FocusedColor = System.Drawing.Color.Empty;
            this.btnSendFeedback.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendFeedback.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnSendFeedback.Image = null;
            this.btnSendFeedback.ImageSize = new System.Drawing.Size(30, 30);
            this.btnSendFeedback.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnSendFeedback.Location = new System.Drawing.Point(256, 534);
            this.btnSendFeedback.Margin = new System.Windows.Forms.Padding(0);
            this.btnSendFeedback.Name = "btnSendFeedback";
            this.btnSendFeedback.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btnSendFeedback.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSendFeedback.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnSendFeedback.OnHoverImage = null;
            this.btnSendFeedback.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnSendFeedback.OnPressedColor = System.Drawing.Color.Black;
            this.btnSendFeedback.Size = new System.Drawing.Size(178, 35);
            this.btnSendFeedback.TabIndex = 219;
            this.btnSendFeedback.Text = "Send Feedback";
            this.btnSendFeedback.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSendFeedback.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmSendFeedback
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(700, 600);
            this.Controls.Add(this.btnSendFeedback);
            this.Controls.Add(this.gbJobRequestStatus);
            this.Controls.Add(this.gbFeedback);
            this.Controls.Add(this.gbActionTaken);
            this.Controls.Add(this.gbFindingSelection);
            this.Controls.Add(this.gbFindings);
            this.Controls.Add(this.gbTicketID);
            this.Controls.Add(this.btnBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSendFeedback";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.gbFindings.ResumeLayout(false);
            this.gbFindings.PerformLayout();
            this.gbFindingSelection.ResumeLayout(false);
            this.gbFindingSelection.PerformLayout();
            this.gbNewStatus.ResumeLayout(false);
            this.gbNewStatus.PerformLayout();
            this.gbActionTaken.ResumeLayout(false);
            this.gbActionTaken.PerformLayout();
            this.gbFeedback.ResumeLayout(false);
            this.gbJobRequestStatus.ResumeLayout(false);
            this.gbJobRequestStatus.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaAdvenceButton btnBack;
        private Guna.UI2.WinForms.Guna2GroupBox gbTicketID;
        private Guna.UI2.WinForms.Guna2GroupBox gbFindings;
        private Guna.UI2.WinForms.Guna2RadioButton rdbSoftwareRelated;
        private Guna.UI2.WinForms.Guna2RadioButton rdbHardwareRelated;
        private Guna.UI2.WinForms.Guna2GroupBox gbFindingSelection;
        private Guna.UI2.WinForms.Guna2RadioButton rdbOthers;
        private Guna.UI2.WinForms.Guna2RadioButton rdbApplicationSoftware;
        private Guna.UI2.WinForms.Guna2RadioButton rdbHardwareItems;
        private Guna.UI2.WinForms.Guna2RadioButton rdbComputerUnit;
        private Guna.UI2.WinForms.Guna2ComboBox cbItemHavingIssue;
        private Guna.UI2.WinForms.Guna2GroupBox gbNewStatus;
        private Guna.UI2.WinForms.Guna2RadioButton rdbCondemned;
        private Guna.UI2.WinForms.Guna2RadioButton rdbDefective;
        private Guna.UI2.WinForms.Guna2RadioButton rdbWorking;
        private Guna.UI2.WinForms.Guna2GroupBox gbActionTaken;
        private Guna.UI2.WinForms.Guna2ComboBox cbReplaceWith;
        private Guna.UI2.WinForms.Guna2RadioButton rdbReinstall;
        private Guna.UI2.WinForms.Guna2RadioButton rdbTroubleshoot;
        private Guna.UI2.WinForms.Guna2RadioButton rdbReplaceWith;
        private Guna.UI2.WinForms.Guna2GroupBox gbFeedback;
        private Guna.UI.WinForms.GunaTextBox txtFeedback;
        private Guna.UI2.WinForms.Guna2GroupBox gbJobRequestStatus;
        private Guna.UI2.WinForms.Guna2RadioButton rdbOngoing;
        private Guna.UI2.WinForms.Guna2RadioButton rdbCompleted;
        private Guna.UI.WinForms.GunaAdvenceButton btnSendFeedback;
    }
}