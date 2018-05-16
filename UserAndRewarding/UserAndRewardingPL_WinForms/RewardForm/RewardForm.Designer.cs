namespace UsersAndRewardingPL_WinForms
{
    partial class RewardForm
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
            this.lblNameReward = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtNameReward = new System.Windows.Forms.TextBox();
            this.btnOkReward = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.ctlErrorRewardProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ctlErrorRewardProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNameReward
            // 
            this.lblNameReward.AutoSize = true;
            this.lblNameReward.Location = new System.Drawing.Point(12, 19);
            this.lblNameReward.Name = "lblNameReward";
            this.lblNameReward.Size = new System.Drawing.Size(75, 13);
            this.lblNameReward.TabIndex = 0;
            this.lblNameReward.Text = "Name Reward";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(12, 41);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(60, 13);
            this.lblDescription.TabIndex = 1;
            this.lblDescription.Text = "Description";
            // 
            // txtDescription
            // 
            this.txtDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescription.Location = new System.Drawing.Point(109, 41);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(288, 20);
            this.txtDescription.TabIndex = 2;
            this.txtDescription.Validating += new System.ComponentModel.CancelEventHandler(this.txtDescription_Validating);
            this.txtDescription.Validated += new System.EventHandler(this.txtDescription_Validated);
            // 
            // txtNameReward
            // 
            this.txtNameReward.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNameReward.Location = new System.Drawing.Point(109, 16);
            this.txtNameReward.Name = "txtNameReward";
            this.txtNameReward.Size = new System.Drawing.Size(288, 20);
            this.txtNameReward.TabIndex = 1;
            this.txtNameReward.Validating += new System.ComponentModel.CancelEventHandler(this.txtNameReward_Validating);
            this.txtNameReward.Validated += new System.EventHandler(this.txtNameReward_Validated);
            // 
            // btnOkReward
            // 
            this.btnOkReward.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOkReward.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOkReward.Location = new System.Drawing.Point(209, 66);
            this.btnOkReward.Name = "btnOkReward";
            this.btnOkReward.Size = new System.Drawing.Size(90, 28);
            this.btnOkReward.TabIndex = 3;
            this.btnOkReward.Text = "Ok";
            this.btnOkReward.UseVisualStyleBackColor = true;
            this.btnOkReward.Click += new System.EventHandler(this.btnOkReward_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(299, 67);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(91, 27);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // ctlErrorRewardProvider
            // 
            this.ctlErrorRewardProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.ctlErrorRewardProvider.ContainerControl = this;
            // 
            // RewardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(422, 118);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOkReward);
            this.Controls.Add(this.txtNameReward);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblNameReward);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RewardForm";
            this.Text = "Add reward";
            ((System.ComponentModel.ISupportInitialize)(this.ctlErrorRewardProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNameReward;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtNameReward;
        private System.Windows.Forms.Button btnOkReward;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ErrorProvider ctlErrorRewardProvider;
    }
}