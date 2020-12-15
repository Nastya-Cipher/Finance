namespace Finance
{
    partial class CreateAkk
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
            this.Create = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.textLogin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textRepeatPassword = new System.Windows.Forms.TextBox();
            this.Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Create
            // 
            this.Create.ForeColor = System.Drawing.Color.Black;
            this.Create.Location = new System.Drawing.Point(113, 297);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(167, 29);
            this.Create.TabIndex = 3;
            this.Create.Text = "Создать аккаунт";
            this.Create.UseVisualStyleBackColor = true;
            this.Create.Click += new System.EventHandler(this.Create_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(114, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Пароль";
            // 
            // textPassword
            // 
            this.textPassword.Location = new System.Drawing.Point(114, 199);
            this.textPassword.Name = "textPassword";
            this.textPassword.Size = new System.Drawing.Size(167, 22);
            this.textPassword.TabIndex = 7;
            // 
            // textLogin
            // 
            this.textLogin.Location = new System.Drawing.Point(114, 148);
            this.textLogin.Name = "textLogin";
            this.textLogin.Size = new System.Drawing.Size(167, 22);
            this.textLogin.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(114, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Логин";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(112, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Повтор пароля";
            // 
            // textRepeatPassword
            // 
            this.textRepeatPassword.Location = new System.Drawing.Point(114, 252);
            this.textRepeatPassword.Name = "textRepeatPassword";
            this.textRepeatPassword.Size = new System.Drawing.Size(167, 22);
            this.textRepeatPassword.TabIndex = 12;
            // 
            // Cancel
            // 
            this.Cancel.ForeColor = System.Drawing.Color.Black;
            this.Cancel.Location = new System.Drawing.Point(113, 332);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(167, 29);
            this.Cancel.TabIndex = 14;
            this.Cancel.Text = "Отмена";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // CreateAkk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(415, 450);
            this.ControlBox = false;
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textRepeatPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textLogin);
            this.Controls.Add(this.textPassword);
            this.Controls.Add(this.Create);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "CreateAkk";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Регистрация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Create;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textPassword;
        private System.Windows.Forms.TextBox textLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textRepeatPassword;
        private System.Windows.Forms.Button Cancel;
    }
}