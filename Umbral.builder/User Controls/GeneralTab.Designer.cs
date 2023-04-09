﻿namespace Umbral.builder.User_Controls
{
    partial class GeneralTab
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.webhookLabel = new System.Windows.Forms.TextBox();
            this.WebhookCheckButton = new System.Windows.Forms.Button();
            this.PingCheckBox = new System.Windows.Forms.CheckBox();
            this.VmProtectCheckBox = new System.Windows.Forms.CheckBox();
            this.StartupCheckBox = new System.Windows.Forms.CheckBox();
            this.StealTokensCheckBox = new System.Windows.Forms.CheckBox();
            this.StealPasswordsCheckBox = new System.Windows.Forms.CheckBox();
            this.StealCookiesCheckBox = new System.Windows.Forms.CheckBox();
            this.StealRobloxCookiesCheckBox = new System.Windows.Forms.CheckBox();
            this.StealMinecraftSessionCheckBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // webhookLabel
            // 
            this.webhookLabel.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.webhookLabel.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.webhookLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(54)))), ((int)(((byte)(56)))));
            this.webhookLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.webhookLabel.ForeColor = System.Drawing.Color.Silver;
            this.webhookLabel.Location = new System.Drawing.Point(24, 74);
            this.webhookLabel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.webhookLabel.MaxLength = 150;
            this.webhookLabel.Name = "webhookLabel";
            this.webhookLabel.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.webhookLabel.Size = new System.Drawing.Size(604, 24);
            this.webhookLabel.TabIndex = 0;
            this.webhookLabel.TextChanged += new System.EventHandler(this.webhookLabel_TextChanged);
            this.webhookLabel.Enter += new System.EventHandler(this.webhookLabel_Enter);
            this.webhookLabel.Leave += new System.EventHandler(this.webhookLabel_Leave);
            // 
            // WebhookCheckButton
            // 
            this.WebhookCheckButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.WebhookCheckButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WebhookCheckButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WebhookCheckButton.ForeColor = System.Drawing.Color.White;
            this.WebhookCheckButton.Location = new System.Drawing.Point(512, 105);
            this.WebhookCheckButton.Name = "WebhookCheckButton";
            this.WebhookCheckButton.Size = new System.Drawing.Size(116, 31);
            this.WebhookCheckButton.TabIndex = 1;
            this.WebhookCheckButton.Text = "Check Webhook";
            this.WebhookCheckButton.UseVisualStyleBackColor = true;
            this.WebhookCheckButton.Click += new System.EventHandler(this.WebhookCheckButton_Click);
            // 
            // PingCheckBox
            // 
            this.PingCheckBox.AutoSize = true;
            this.PingCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PingCheckBox.ForeColor = System.Drawing.SystemColors.Control;
            this.PingCheckBox.Location = new System.Drawing.Point(24, 223);
            this.PingCheckBox.Name = "PingCheckBox";
            this.PingCheckBox.Size = new System.Drawing.Size(56, 22);
            this.PingCheckBox.TabIndex = 2;
            this.PingCheckBox.Text = "Ping";
            this.PingCheckBox.UseVisualStyleBackColor = true;
            this.PingCheckBox.CheckedChanged += new System.EventHandler(this.CheckBox_CheckChanged);
            // 
            // VmProtectCheckBox
            // 
            this.VmProtectCheckBox.AutoSize = true;
            this.VmProtectCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VmProtectCheckBox.ForeColor = System.Drawing.SystemColors.Control;
            this.VmProtectCheckBox.Location = new System.Drawing.Point(24, 291);
            this.VmProtectCheckBox.Name = "VmProtectCheckBox";
            this.VmProtectCheckBox.Size = new System.Drawing.Size(77, 22);
            this.VmProtectCheckBox.TabIndex = 3;
            this.VmProtectCheckBox.Text = "Anti VM";
            this.VmProtectCheckBox.UseVisualStyleBackColor = true;
            this.VmProtectCheckBox.CheckedChanged += new System.EventHandler(this.CheckBox_CheckChanged);
            // 
            // StartupCheckBox
            // 
            this.StartupCheckBox.AutoSize = true;
            this.StartupCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartupCheckBox.ForeColor = System.Drawing.SystemColors.Control;
            this.StartupCheckBox.Location = new System.Drawing.Point(24, 359);
            this.StartupCheckBox.Name = "StartupCheckBox";
            this.StartupCheckBox.Size = new System.Drawing.Size(74, 22);
            this.StartupCheckBox.TabIndex = 4;
            this.StartupCheckBox.Text = "Startup";
            this.StartupCheckBox.UseVisualStyleBackColor = true;
            this.StartupCheckBox.CheckedChanged += new System.EventHandler(this.CheckBox_CheckChanged);
            // 
            // StealTokensCheckBox
            // 
            this.StealTokensCheckBox.AutoSize = true;
            this.StealTokensCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StealTokensCheckBox.ForeColor = System.Drawing.SystemColors.Control;
            this.StealTokensCheckBox.Location = new System.Drawing.Point(140, 223);
            this.StealTokensCheckBox.Name = "StealTokensCheckBox";
            this.StealTokensCheckBox.Size = new System.Drawing.Size(114, 22);
            this.StealTokensCheckBox.TabIndex = 5;
            this.StealTokensCheckBox.Text = "Steal Tokens";
            this.StealTokensCheckBox.UseVisualStyleBackColor = true;
            this.StealTokensCheckBox.CheckedChanged += new System.EventHandler(this.CheckBox_CheckChanged);
            // 
            // StealPasswordsCheckBox
            // 
            this.StealPasswordsCheckBox.AutoSize = true;
            this.StealPasswordsCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StealPasswordsCheckBox.ForeColor = System.Drawing.SystemColors.Control;
            this.StealPasswordsCheckBox.Location = new System.Drawing.Point(140, 291);
            this.StealPasswordsCheckBox.Name = "StealPasswordsCheckBox";
            this.StealPasswordsCheckBox.Size = new System.Drawing.Size(139, 22);
            this.StealPasswordsCheckBox.TabIndex = 6;
            this.StealPasswordsCheckBox.Text = "Steal Passwords";
            this.StealPasswordsCheckBox.UseVisualStyleBackColor = true;
            this.StealPasswordsCheckBox.CheckedChanged += new System.EventHandler(this.CheckBox_CheckChanged);
            // 
            // StealCookiesCheckBox
            // 
            this.StealCookiesCheckBox.AutoSize = true;
            this.StealCookiesCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StealCookiesCheckBox.ForeColor = System.Drawing.SystemColors.Control;
            this.StealCookiesCheckBox.Location = new System.Drawing.Point(140, 359);
            this.StealCookiesCheckBox.Name = "StealCookiesCheckBox";
            this.StealCookiesCheckBox.Size = new System.Drawing.Size(120, 22);
            this.StealCookiesCheckBox.TabIndex = 7;
            this.StealCookiesCheckBox.Text = "Steal Cookies";
            this.StealCookiesCheckBox.UseVisualStyleBackColor = true;
            this.StealCookiesCheckBox.CheckedChanged += new System.EventHandler(this.CheckBox_CheckChanged);
            // 
            // StealRobloxCookiesCheckBox
            // 
            this.StealRobloxCookiesCheckBox.AutoSize = true;
            this.StealRobloxCookiesCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StealRobloxCookiesCheckBox.ForeColor = System.Drawing.SystemColors.Control;
            this.StealRobloxCookiesCheckBox.Location = new System.Drawing.Point(307, 223);
            this.StealRobloxCookiesCheckBox.Name = "StealRobloxCookiesCheckBox";
            this.StealRobloxCookiesCheckBox.Size = new System.Drawing.Size(171, 22);
            this.StealRobloxCookiesCheckBox.TabIndex = 8;
            this.StealRobloxCookiesCheckBox.Text = "Steal Roblox Cookies";
            this.StealRobloxCookiesCheckBox.UseVisualStyleBackColor = true;
            this.StealRobloxCookiesCheckBox.CheckedChanged += new System.EventHandler(this.CheckBox_CheckChanged);
            // 
            // StealMinecraftSessionCheckBox
            // 
            this.StealMinecraftSessionCheckBox.AutoSize = true;
            this.StealMinecraftSessionCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StealMinecraftSessionCheckBox.ForeColor = System.Drawing.SystemColors.Control;
            this.StealMinecraftSessionCheckBox.Location = new System.Drawing.Point(307, 291);
            this.StealMinecraftSessionCheckBox.Name = "StealMinecraftSessionCheckBox";
            this.StealMinecraftSessionCheckBox.Size = new System.Drawing.Size(183, 22);
            this.StealMinecraftSessionCheckBox.TabIndex = 9;
            this.StealMinecraftSessionCheckBox.Text = "Steal Minecraft Session";
            this.StealMinecraftSessionCheckBox.UseVisualStyleBackColor = true;
            this.StealMinecraftSessionCheckBox.CheckedChanged += new System.EventHandler(this.CheckBox_CheckChanged);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(107, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1, 225);
            this.label1.TabIndex = 10;
            // 
            // GeneralTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StealMinecraftSessionCheckBox);
            this.Controls.Add(this.StealRobloxCookiesCheckBox);
            this.Controls.Add(this.StealCookiesCheckBox);
            this.Controls.Add(this.StealPasswordsCheckBox);
            this.Controls.Add(this.StealTokensCheckBox);
            this.Controls.Add(this.StartupCheckBox);
            this.Controls.Add(this.VmProtectCheckBox);
            this.Controls.Add(this.PingCheckBox);
            this.Controls.Add(this.WebhookCheckButton);
            this.Controls.Add(this.webhookLabel);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "GeneralTab";
            this.Size = new System.Drawing.Size(668, 477);
            this.Load += new System.EventHandler(this.GeneralTab_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox webhookLabel;
        private System.Windows.Forms.Button WebhookCheckButton;
        private System.Windows.Forms.CheckBox VmProtectCheckBox;
        private System.Windows.Forms.CheckBox StartupCheckBox;
        private System.Windows.Forms.CheckBox StealTokensCheckBox;
        private System.Windows.Forms.CheckBox StealPasswordsCheckBox;
        private System.Windows.Forms.CheckBox StealCookiesCheckBox;
        private System.Windows.Forms.CheckBox StealRobloxCookiesCheckBox;
        private System.Windows.Forms.CheckBox StealMinecraftSessionCheckBox;
        private System.Windows.Forms.CheckBox PingCheckBox;
        private System.Windows.Forms.Label label1;
    }
}