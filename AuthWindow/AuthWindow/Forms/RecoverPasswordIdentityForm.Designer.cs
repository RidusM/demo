namespace AuthWindow.Forms
{
    partial class RecoverPasswordIdentityForm
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
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.buttonEnterToSystem = new System.Windows.Forms.Button();
            this.labelLogin = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.buttonPasswordMask = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Location = new System.Drawing.Point(71, 25);
            this.textBoxLogin.Multiline = true;
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(179, 51);
            this.textBoxLogin.TabIndex = 0;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(71, 82);
            this.textBoxPassword.Multiline = true;
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(179, 51);
            this.textBoxPassword.TabIndex = 1;
            // 
            // buttonEnterToSystem
            // 
            this.buttonEnterToSystem.Location = new System.Drawing.Point(12, 139);
            this.buttonEnterToSystem.Name = "buttonEnterToSystem";
            this.buttonEnterToSystem.Size = new System.Drawing.Size(238, 49);
            this.buttonEnterToSystem.TabIndex = 2;
            this.buttonEnterToSystem.Text = "button1";
            this.buttonEnterToSystem.UseVisualStyleBackColor = true;
            this.buttonEnterToSystem.Click += new System.EventHandler(this.buttonEnterToSystem_Click);
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Location = new System.Drawing.Point(9, 28);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(38, 13);
            this.labelLogin.TabIndex = 3;
            this.labelLogin.Text = "Логин";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(9, 85);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(45, 13);
            this.labelPassword.TabIndex = 4;
            this.labelPassword.Text = "Пароль";
            // 
            // buttonPasswordMask
            // 
            this.buttonPasswordMask.Location = new System.Drawing.Point(211, 82);
            this.buttonPasswordMask.Name = "buttonPasswordMask";
            this.buttonPasswordMask.Size = new System.Drawing.Size(39, 51);
            this.buttonPasswordMask.TabIndex = 5;
            this.buttonPasswordMask.Text = "X";
            this.buttonPasswordMask.UseVisualStyleBackColor = true;
            this.buttonPasswordMask.Click += new System.EventHandler(this.buttonPasswordMask_Click);
            // 
            // RecoverPasswordIdentityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 195);
            this.Controls.Add(this.buttonPasswordMask);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.buttonEnterToSystem);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxLogin);
            this.Name = "RecoverPasswordIdentityForm";
            this.Text = "RecoverPasswordIdentityForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Button buttonEnterToSystem;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Button buttonPasswordMask;
    }
}