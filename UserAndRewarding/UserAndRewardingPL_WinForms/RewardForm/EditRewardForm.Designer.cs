
namespace UsersAndRewardingPL_WinForms
{
    partial class EditRewardForm
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
            this.btnEditCancelReward = new System.Windows.Forms.Button();
            this.btnEditOkReward = new System.Windows.Forms.Button();
            this.txtEditNameReward = new System.Windows.Forms.TextBox();
            this.txtEditDescription = new System.Windows.Forms.TextBox();
            this.lblEditDescription = new System.Windows.Forms.Label();
            this.lblEditNameReward = new System.Windows.Forms.Label();
            this.errorEditRewardProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorEditRewardProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEditCancelReward
            // 
            this.btnEditCancelReward.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditCancelReward.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnEditCancelReward.Location = new System.Drawing.Point(312, 65);
            this.btnEditCancelReward.Name = "btnEditCancelReward";
            this.btnEditCancelReward.Size = new System.Drawing.Size(98, 28);
            this.btnEditCancelReward.TabIndex = 4;
            this.btnEditCancelReward.Text = "Cancel";
            this.btnEditCancelReward.UseVisualStyleBackColor = true;
            // 
            // btnEditOkReward
            // 
            this.btnEditOkReward.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditOkReward.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnEditOkReward.Location = new System.Drawing.Point(216, 63);
            this.btnEditOkReward.Name = "btnEditOkReward";
            this.btnEditOkReward.Size = new System.Drawing.Size(97, 29);
            this.btnEditOkReward.TabIndex = 3;
            this.btnEditOkReward.Text = "Ok";
            this.btnEditOkReward.UseVisualStyleBackColor = true;
            // 
            // txtEditNameReward
            // 
            this.txtEditNameReward.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEditNameReward.Location = new System.Drawing.Point(116, 13);
            this.txtEditNameReward.Name = "txtEditNameReward";
            this.txtEditNameReward.Size = new System.Drawing.Size(295, 20);
            this.txtEditNameReward.TabIndex = 1;
            this.txtEditNameReward.Validating += new System.ComponentModel.CancelEventHandler(this.txtNameReward_Validating);
            this.txtEditNameReward.Validated += new System.EventHandler(this.txtNameReward_Validated);
            // 
            // txtEditDescription
            // 
            this.txtEditDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEditDescription.Location = new System.Drawing.Point(116, 38);
            this.txtEditDescription.Name = "txtEditDescription";
            this.txtEditDescription.Size = new System.Drawing.Size(295, 20);
            this.txtEditDescription.TabIndex = 2;
            this.txtEditDescription.Validating += new System.ComponentModel.CancelEventHandler(this.txtDescription_Validating);
            this.txtEditDescription.Validated += new System.EventHandler(this.txtDescription_Validated);
            // 
            // lblEditDescription
            // 
            this.lblEditDescription.AutoSize = true;
            this.lblEditDescription.Location = new System.Drawing.Point(12, 38);
            this.lblEditDescription.Name = "lblEditDescription";
            this.lblEditDescription.Size = new System.Drawing.Size(60, 13);
            this.lblEditDescription.TabIndex = 7;
            this.lblEditDescription.Text = "Description";
            // 
            // lblEditNameReward
            // 
            this.lblEditNameReward.AutoSize = true;
            this.lblEditNameReward.Location = new System.Drawing.Point(12, 16);
            this.lblEditNameReward.Name = "lblEditNameReward";
            this.lblEditNameReward.Size = new System.Drawing.Size(75, 13);
            this.lblEditNameReward.TabIndex = 5;
            this.lblEditNameReward.Text = "Name Reward";
            // 
            // errorEditRewardProvider
            // 
            this.errorEditRewardProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorEditRewardProvider.ContainerControl = this;
            // 
            // EditRewardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 105);
            this.Controls.Add(this.btnEditCancelReward);
            this.Controls.Add(this.btnEditOkReward);
            this.Controls.Add(this.txtEditNameReward);
            this.Controls.Add(this.txtEditDescription);
            this.Controls.Add(this.lblEditDescription);
            this.Controls.Add(this.lblEditNameReward);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditRewardForm";
            this.Text = "Edit Reward";
            ((System.ComponentModel.ISupportInitialize)(this.errorEditRewardProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEditCancelReward;
        private System.Windows.Forms.Button btnEditOkReward;
        private System.Windows.Forms.TextBox txtEditNameReward;
        private System.Windows.Forms.TextBox txtEditDescription;
        private System.Windows.Forms.Label lblEditDescription;
        private System.Windows.Forms.Label lblEditNameReward;
        private System.Windows.Forms.ErrorProvider errorEditRewardProvider;
    }
}