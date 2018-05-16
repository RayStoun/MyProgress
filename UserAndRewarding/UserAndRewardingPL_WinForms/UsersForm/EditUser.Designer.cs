namespace UsersAndRewardingPL_WinForms
{
    partial class EditUser
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
            this.components = new System.ComponentModel.Container();
            this.checkedEditListRewards = new System.Windows.Forms.CheckedListBox();
            this.btnEditCancel = new System.Windows.Forms.Button();
            this.btnEditOk = new System.Windows.Forms.Button();
            this.txtEditBirthdate = new System.Windows.Forms.DateTimePicker();
            this.txtEditFirstName = new System.Windows.Forms.TextBox();
            this.txtEditLastName = new System.Windows.Forms.TextBox();
            this.lblEditBirthdate = new System.Windows.Forms.Label();
            this.lblEditLastName = new System.Windows.Forms.Label();
            this.lblEditFirstName = new System.Windows.Forms.Label();
            this.errorProviderEditUser = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderEditUser)).BeginInit();
            this.SuspendLayout();
            // 
            // checkedEditListRewards
            // 
            this.checkedEditListRewards.FormattingEnabled = true;
            this.checkedEditListRewards.Location = new System.Drawing.Point(8, 92);
            this.checkedEditListRewards.Name = "checkedEditListRewards";
            this.checkedEditListRewards.Size = new System.Drawing.Size(272, 124);
            this.checkedEditListRewards.TabIndex = 15;
            this.checkedEditListRewards.Validated += new System.EventHandler(this.checkedListRewards_Validated);
            // 
            // btnEditCancel
            // 
            this.btnEditCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnEditCancel.Location = new System.Drawing.Point(205, 222);
            this.btnEditCancel.Name = "btnEditCancel";
            this.btnEditCancel.Size = new System.Drawing.Size(75, 23);
            this.btnEditCancel.TabIndex = 14;
            this.btnEditCancel.Text = "Cancel";
            this.btnEditCancel.UseVisualStyleBackColor = true;
            // 
            // btnEditOk
            // 
            this.btnEditOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnEditOk.Location = new System.Drawing.Point(117, 222);
            this.btnEditOk.Name = "btnEditOk";
            this.btnEditOk.Size = new System.Drawing.Size(75, 23);
            this.btnEditOk.TabIndex = 13;
            this.btnEditOk.Text = "Ok";
            this.btnEditOk.UseVisualStyleBackColor = true;
            this.btnEditOk.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // txtEditBirthdate
            // 
            this.txtEditBirthdate.Location = new System.Drawing.Point(69, 61);
            this.txtEditBirthdate.Name = "txtEditBirthdate";
            this.txtEditBirthdate.Size = new System.Drawing.Size(211, 20);
            this.txtEditBirthdate.TabIndex = 12;
            this.txtEditBirthdate.Value = new System.DateTime(2018, 5, 15, 14, 35, 6, 0);
            this.txtEditBirthdate.Validating += new System.ComponentModel.CancelEventHandler(this.txtEditBirthdate_Validating);
            this.txtEditBirthdate.Validated += new System.EventHandler(this.txtEditBirthdate_Validated);
            // 
            // txtEditFirstName
            // 
            this.txtEditFirstName.Location = new System.Drawing.Point(69, 10);
            this.txtEditFirstName.Name = "txtEditFirstName";
            this.txtEditFirstName.Size = new System.Drawing.Size(211, 20);
            this.txtEditFirstName.TabIndex = 8;
            this.txtEditFirstName.Validating += new System.ComponentModel.CancelEventHandler(this.txtEditFirstName_Validating);
            this.txtEditFirstName.Validated += new System.EventHandler(this.txtEditFirstName_Validated);
            // 
            // txtEditLastName
            // 
            this.txtEditLastName.Location = new System.Drawing.Point(69, 35);
            this.txtEditLastName.Name = "txtEditLastName";
            this.txtEditLastName.Size = new System.Drawing.Size(211, 20);
            this.txtEditLastName.TabIndex = 10;
            this.txtEditLastName.Validating += new System.ComponentModel.CancelEventHandler(this.txtEditLastName_Validating);
            this.txtEditLastName.Validated += new System.EventHandler(this.txtEditLastName_Validated);
            // 
            // lblEditBirthdate
            // 
            this.lblEditBirthdate.AutoSize = true;
            this.lblEditBirthdate.Location = new System.Drawing.Point(6, 67);
            this.lblEditBirthdate.Name = "lblEditBirthdate";
            this.lblEditBirthdate.Size = new System.Drawing.Size(49, 13);
            this.lblEditBirthdate.TabIndex = 11;
            this.lblEditBirthdate.Text = "Birthdate";
            // 
            // lblEditLastName
            // 
            this.lblEditLastName.AutoSize = true;
            this.lblEditLastName.Location = new System.Drawing.Point(5, 35);
            this.lblEditLastName.Name = "lblEditLastName";
            this.lblEditLastName.Size = new System.Drawing.Size(58, 13);
            this.lblEditLastName.TabIndex = 9;
            this.lblEditLastName.Text = "Last Name";
            // 
            // lblEditFirstName
            // 
            this.lblEditFirstName.AutoSize = true;
            this.lblEditFirstName.Location = new System.Drawing.Point(6, 10);
            this.lblEditFirstName.Name = "lblEditFirstName";
            this.lblEditFirstName.Size = new System.Drawing.Size(57, 13);
            this.lblEditFirstName.TabIndex = 7;
            this.lblEditFirstName.Text = "First Name";
            // 
            // errorProviderEditUser
            // 
            this.errorProviderEditUser.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderEditUser.ContainerControl = this;
            // 
            // EditUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(310, 253);
            this.Controls.Add(this.checkedEditListRewards);
            this.Controls.Add(this.btnEditCancel);
            this.Controls.Add(this.btnEditOk);
            this.Controls.Add(this.txtEditBirthdate);
            this.Controls.Add(this.txtEditFirstName);
            this.Controls.Add(this.txtEditLastName);
            this.Controls.Add(this.lblEditBirthdate);
            this.Controls.Add(this.lblEditLastName);
            this.Controls.Add(this.lblEditFirstName);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditUser";
            this.Text = "Edit User";
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderEditUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedEditListRewards;
        private System.Windows.Forms.Button btnEditCancel;
        private System.Windows.Forms.Button btnEditOk;
        private System.Windows.Forms.DateTimePicker txtEditBirthdate;
        private System.Windows.Forms.TextBox txtEditFirstName;
        private System.Windows.Forms.TextBox txtEditLastName;
        private System.Windows.Forms.Label lblEditBirthdate;
        private System.Windows.Forms.Label lblEditLastName;
        private System.Windows.Forms.Label lblEditFirstName;
        private System.Windows.Forms.ErrorProvider errorProviderEditUser;
    }
}