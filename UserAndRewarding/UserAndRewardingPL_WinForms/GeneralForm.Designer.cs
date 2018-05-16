namespace UsersAndRewardingPL_WinForms
{
    partial class GeneralForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnExitMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMenuAddUser = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMenuAddReward = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMenuEditUser = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMenuEditReward = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMenuDeleteUser = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMenuDeleteReward = new System.Windows.Forms.ToolStripMenuItem();
            this.ctlTab = new System.Windows.Forms.TabControl();
            this.ctlMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnAddUserToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDeleteUserToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMenuStripEditUser = new System.Windows.Forms.ToolStripMenuItem();
            this.ctlStudentPage = new System.Windows.Forms.TabPage();
            this.ctlDataGridViewUsers = new System.Windows.Forms.DataGridView();
            this.clmId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFirtsName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnBirthDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnReward = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ctlRewardsPage = new System.Windows.Forms.TabPage();
            this.ctlDataGridViewRewards = new System.Windows.Forms.DataGridView();
            this.clmRewardID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDiscription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ctlContextMenuREwards = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ctlAddRewards = new System.Windows.Forms.ToolStripMenuItem();
            this.editRewardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteRewardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenu.SuspendLayout();
            this.ctlTab.SuspendLayout();
            this.ctlMenuStrip.SuspendLayout();
            this.ctlStudentPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ctlDataGridViewUsers)).BeginInit();
            this.ctlRewardsPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ctlDataGridViewRewards)).BeginInit();
            this.ctlContextMenuREwards.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(602, 24);
            this.MainMenu.TabIndex = 0;
            this.MainMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnExitMenu});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // btnExitMenu
            // 
            this.btnExitMenu.Name = "btnExitMenu";
            this.btnExitMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.btnExitMenu.Size = new System.Drawing.Size(134, 22);
            this.btnExitMenu.Text = "Exit";
            this.btnExitMenu.Click += new System.EventHandler(this.btnExitMenu_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnMenuAddUser,
            this.btnMenuAddReward,
            this.btnMenuEditUser,
            this.btnMenuEditReward,
            this.btnMenuDeleteUser,
            this.btnMenuDeleteReward});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // btnMenuAddUser
            // 
            this.btnMenuAddUser.Name = "btnMenuAddUser";
            this.btnMenuAddUser.Size = new System.Drawing.Size(180, 22);
            this.btnMenuAddUser.Text = "Add user...";
            this.btnMenuAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // btnMenuAddReward
            // 
            this.btnMenuAddReward.Name = "btnMenuAddReward";
            this.btnMenuAddReward.Size = new System.Drawing.Size(180, 22);
            this.btnMenuAddReward.Text = "Add reward...";
            this.btnMenuAddReward.Click += new System.EventHandler(this.btnMenuAddReward_Click);
            // 
            // btnMenuEditUser
            // 
            this.btnMenuEditUser.Name = "btnMenuEditUser";
            this.btnMenuEditUser.Size = new System.Drawing.Size(180, 22);
            this.btnMenuEditUser.Text = "Edit user...";
            this.btnMenuEditUser.Click += new System.EventHandler(this.btnMenuEditUser_Click);
            // 
            // btnMenuEditReward
            // 
            this.btnMenuEditReward.Name = "btnMenuEditReward";
            this.btnMenuEditReward.Size = new System.Drawing.Size(180, 22);
            this.btnMenuEditReward.Text = "Edit reward...";
            this.btnMenuEditReward.Click += new System.EventHandler(this.btnMenuEditReward_Click);
            // 
            // btnMenuDeleteUser
            // 
            this.btnMenuDeleteUser.Name = "btnMenuDeleteUser";
            this.btnMenuDeleteUser.Size = new System.Drawing.Size(180, 22);
            this.btnMenuDeleteUser.Text = "Delete user";
            this.btnMenuDeleteUser.Click += new System.EventHandler(this.btnMenuDeleteUser_Click);
            // 
            // btnMenuDeleteReward
            // 
            this.btnMenuDeleteReward.Name = "btnMenuDeleteReward";
            this.btnMenuDeleteReward.Size = new System.Drawing.Size(180, 22);
            this.btnMenuDeleteReward.Text = "Delete reward";
            this.btnMenuDeleteReward.Click += new System.EventHandler(this.btnMenuDeleteReward_Click);
            // 
            // ctlTab
            // 
            this.ctlTab.ContextMenuStrip = this.ctlMenuStrip;
            this.ctlTab.Controls.Add(this.ctlStudentPage);
            this.ctlTab.Controls.Add(this.ctlRewardsPage);
            this.ctlTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctlTab.Location = new System.Drawing.Point(0, 24);
            this.ctlTab.Name = "ctlTab";
            this.ctlTab.SelectedIndex = 0;
            this.ctlTab.Size = new System.Drawing.Size(602, 311);
            this.ctlTab.TabIndex = 2;
            // 
            // ctlMenuStrip
            // 
            this.ctlMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddUserToolStripMenu,
            this.btnDeleteUserToolStripMenu,
            this.btnMenuStripEditUser});
            this.ctlMenuStrip.Name = "contextMenuStrip1";
            this.ctlMenuStrip.Size = new System.Drawing.Size(133, 70);
            // 
            // btnAddUserToolStripMenu
            // 
            this.btnAddUserToolStripMenu.Name = "btnAddUserToolStripMenu";
            this.btnAddUserToolStripMenu.Size = new System.Drawing.Size(132, 22);
            this.btnAddUserToolStripMenu.Text = "Add user...";
            this.btnAddUserToolStripMenu.Click += new System.EventHandler(this.btnAddUserToolStripMenu_Click);
            // 
            // btnDeleteUserToolStripMenu
            // 
            this.btnDeleteUserToolStripMenu.Name = "btnDeleteUserToolStripMenu";
            this.btnDeleteUserToolStripMenu.Size = new System.Drawing.Size(132, 22);
            this.btnDeleteUserToolStripMenu.Text = "Delete user";
            this.btnDeleteUserToolStripMenu.Click += new System.EventHandler(this.btnDeleteUserToolStripMenu_Click);
            // 
            // btnMenuStripEditUser
            // 
            this.btnMenuStripEditUser.Name = "btnMenuStripEditUser";
            this.btnMenuStripEditUser.Size = new System.Drawing.Size(132, 22);
            this.btnMenuStripEditUser.Text = "Edit user...";
            this.btnMenuStripEditUser.Click += new System.EventHandler(this.btnMenuStripEditUser_Click);
            // 
            // ctlStudentPage
            // 
            this.ctlStudentPage.Controls.Add(this.ctlDataGridViewUsers);
            this.ctlStudentPage.Location = new System.Drawing.Point(4, 22);
            this.ctlStudentPage.Name = "ctlStudentPage";
            this.ctlStudentPage.Padding = new System.Windows.Forms.Padding(3);
            this.ctlStudentPage.Size = new System.Drawing.Size(594, 285);
            this.ctlStudentPage.TabIndex = 0;
            this.ctlStudentPage.Text = "Students";
            this.ctlStudentPage.UseVisualStyleBackColor = true;
            // 
            // ctlDataGridViewUsers
            // 
            this.ctlDataGridViewUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ctlDataGridViewUsers.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ctlDataGridViewUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ctlDataGridViewUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmId,
            this.clmFirtsName,
            this.clmLastName,
            this.clmAge,
            this.clmnBirthDate,
            this.clmnReward});
            this.ctlDataGridViewUsers.ContextMenuStrip = this.ctlMenuStrip;
            this.ctlDataGridViewUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctlDataGridViewUsers.Location = new System.Drawing.Point(3, 3);
            this.ctlDataGridViewUsers.MultiSelect = false;
            this.ctlDataGridViewUsers.Name = "ctlDataGridViewUsers";
            this.ctlDataGridViewUsers.RowHeadersVisible = false;
            this.ctlDataGridViewUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ctlDataGridViewUsers.Size = new System.Drawing.Size(588, 279);
            this.ctlDataGridViewUsers.TabIndex = 0;
            // 
            // clmId
            // 
            this.clmId.DataPropertyName = "UserId";
            this.clmId.HeaderText = "Id";
            this.clmId.Name = "clmId";
            this.clmId.Visible = false;
            // 
            // clmFirtsName
            // 
            this.clmFirtsName.DataPropertyName = "FirstName";
            this.clmFirtsName.FillWeight = 98.98476F;
            this.clmFirtsName.HeaderText = "First Name";
            this.clmFirtsName.Name = "clmFirtsName";
            this.clmFirtsName.ReadOnly = true;
            // 
            // clmLastName
            // 
            this.clmLastName.DataPropertyName = "LastName";
            this.clmLastName.FillWeight = 98.98476F;
            this.clmLastName.HeaderText = "Last Name";
            this.clmLastName.Name = "clmLastName";
            this.clmLastName.ReadOnly = true;
            // 
            // clmAge
            // 
            this.clmAge.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.clmAge.DataPropertyName = "Age";
            this.clmAge.FillWeight = 126.9036F;
            this.clmAge.HeaderText = "Age";
            this.clmAge.Name = "clmAge";
            this.clmAge.ReadOnly = true;
            this.clmAge.Width = 50;
            // 
            // clmnBirthDate
            // 
            this.clmnBirthDate.DataPropertyName = "BirthDate";
            this.clmnBirthDate.FillWeight = 76.14213F;
            this.clmnBirthDate.HeaderText = "Birthdate";
            this.clmnBirthDate.Name = "clmnBirthDate";
            this.clmnBirthDate.ReadOnly = true;
            // 
            // clmnReward
            // 
            this.clmnReward.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmnReward.DataPropertyName = "Rewards";
            this.clmnReward.FillWeight = 98.98476F;
            this.clmnReward.HeaderText = "Rewards";
            this.clmnReward.Name = "clmnReward";
            this.clmnReward.ReadOnly = true;
            // 
            // ctlRewardsPage
            // 
            this.ctlRewardsPage.Controls.Add(this.ctlDataGridViewRewards);
            this.ctlRewardsPage.Location = new System.Drawing.Point(4, 22);
            this.ctlRewardsPage.Name = "ctlRewardsPage";
            this.ctlRewardsPage.Padding = new System.Windows.Forms.Padding(3);
            this.ctlRewardsPage.Size = new System.Drawing.Size(594, 285);
            this.ctlRewardsPage.TabIndex = 1;
            this.ctlRewardsPage.Text = "Rewars";
            this.ctlRewardsPage.UseVisualStyleBackColor = true;
            // 
            // ctlDataGridViewRewards
            // 
            this.ctlDataGridViewRewards.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ctlDataGridViewRewards.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ctlDataGridViewRewards.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ctlDataGridViewRewards.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmRewardID,
            this.clmTitle,
            this.clmDiscription});
            this.ctlDataGridViewRewards.ContextMenuStrip = this.ctlContextMenuREwards;
            this.ctlDataGridViewRewards.Location = new System.Drawing.Point(-1, 3);
            this.ctlDataGridViewRewards.Name = "ctlDataGridViewRewards";
            this.ctlDataGridViewRewards.RowHeadersVisible = false;
            this.ctlDataGridViewRewards.Size = new System.Drawing.Size(595, 286);
            this.ctlDataGridViewRewards.TabIndex = 0;
            // 
            // clmRewardID
            // 
            this.clmRewardID.DataPropertyName = "RewardId";
            this.clmRewardID.HeaderText = "RewardId";
            this.clmRewardID.Name = "clmRewardID";
            this.clmRewardID.Visible = false;
            // 
            // clmTitle
            // 
            this.clmTitle.DataPropertyName = "Title";
            this.clmTitle.HeaderText = "Title";
            this.clmTitle.Name = "clmTitle";
            // 
            // clmDiscription
            // 
            this.clmDiscription.DataPropertyName = "Description";
            this.clmDiscription.HeaderText = "Description";
            this.clmDiscription.Name = "clmDiscription";
            // 
            // ctlContextMenuREwards
            // 
            this.ctlContextMenuREwards.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctlAddRewards,
            this.editRewardToolStripMenuItem,
            this.deleteRewardToolStripMenuItem});
            this.ctlContextMenuREwards.Name = "ctlContextMenuREwards";
            this.ctlContextMenuREwards.Size = new System.Drawing.Size(181, 92);
            // 
            // ctlAddRewards
            // 
            this.ctlAddRewards.Name = "ctlAddRewards";
            this.ctlAddRewards.Size = new System.Drawing.Size(180, 22);
            this.ctlAddRewards.Text = "Add reward...";
            this.ctlAddRewards.Click += new System.EventHandler(this.ctlAddRewards_Click);
            // 
            // editRewardToolStripMenuItem
            // 
            this.editRewardToolStripMenuItem.Name = "editRewardToolStripMenuItem";
            this.editRewardToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editRewardToolStripMenuItem.Text = "Edit reward...";
            this.editRewardToolStripMenuItem.Click += new System.EventHandler(this.editRewardToolStripMenuItem_Click);
            // 
            // deleteRewardToolStripMenuItem
            // 
            this.deleteRewardToolStripMenuItem.Name = "deleteRewardToolStripMenuItem";
            this.deleteRewardToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deleteRewardToolStripMenuItem.Text = "Delete reward...";
            this.deleteRewardToolStripMenuItem.Click += new System.EventHandler(this.deleteRewardToolStripMenuItem_Click);
            // 
            // GeneralForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 335);
            this.Controls.Add(this.ctlTab);
            this.Controls.Add(this.MainMenu);
            this.MainMenuStrip = this.MainMenu;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GeneralForm";
            this.Text = "User and Reward";
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.ctlTab.ResumeLayout(false);
            this.ctlMenuStrip.ResumeLayout(false);
            this.ctlStudentPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ctlDataGridViewUsers)).EndInit();
            this.ctlRewardsPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ctlDataGridViewRewards)).EndInit();
            this.ctlContextMenuREwards.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnExitMenu;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnMenuAddUser;
        private System.Windows.Forms.ToolStripMenuItem btnMenuAddReward;
        private System.Windows.Forms.TabControl ctlTab;
        private System.Windows.Forms.TabPage ctlStudentPage;
        private System.Windows.Forms.DataGridView ctlDataGridViewUsers;
        private System.Windows.Forms.TabPage ctlRewardsPage;
        private System.Windows.Forms.ContextMenuStrip ctlMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem btnAddUserToolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem btnDeleteUserToolStripMenu;
        private System.Windows.Forms.DataGridView ctlDataGridViewRewards;
        private System.Windows.Forms.ContextMenuStrip ctlContextMenuREwards;
        private System.Windows.Forms.ToolStripMenuItem ctlAddRewards;
        private System.Windows.Forms.ToolStripMenuItem btnMenuEditUser;
        private System.Windows.Forms.ToolStripMenuItem btnMenuEditReward;
        private System.Windows.Forms.ToolStripMenuItem btnMenuDeleteUser;
        private System.Windows.Forms.ToolStripMenuItem btnMenuDeleteReward;
        private System.Windows.Forms.ToolStripMenuItem editRewardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteRewardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnMenuStripEditUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmRewardID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDiscription;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFirtsName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAge;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnBirthDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnReward;
    }
}

