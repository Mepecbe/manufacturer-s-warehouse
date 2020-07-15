namespace BDiSUBD.Forms
{
    partial class ConnectionSetting
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
            this.SaveBtn = new MetroFramework.Controls.MetroButton();
            this.Password = new MetroFramework.Controls.MetroTextBox();
            this.Username = new MetroFramework.Controls.MetroTextBox();
            this.DataBase = new MetroFramework.Controls.MetroTextBox();
            this.ServerAddress = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(162, 244);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(75, 23);
            this.SaveBtn.TabIndex = 17;
            this.SaveBtn.Text = "Сохранить";
            this.SaveBtn.UseSelectable = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // Password
            // 
            // 
            // 
            // 
            this.Password.CustomButton.Image = null;
            this.Password.CustomButton.Location = new System.Drawing.Point(118, 1);
            this.Password.CustomButton.Name = "";
            this.Password.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Password.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Password.CustomButton.TabIndex = 1;
            this.Password.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Password.CustomButton.UseSelectable = true;
            this.Password.CustomButton.Visible = false;
            this.Password.Lines = new string[0];
            this.Password.Location = new System.Drawing.Point(199, 194);
            this.Password.MaxLength = 32767;
            this.Password.Name = "Password";
            this.Password.PasswordChar = '\0';
            this.Password.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Password.SelectedText = "";
            this.Password.SelectionLength = 0;
            this.Password.SelectionStart = 0;
            this.Password.ShortcutsEnabled = true;
            this.Password.Size = new System.Drawing.Size(140, 23);
            this.Password.TabIndex = 16;
            this.Password.UseSelectable = true;
            this.Password.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Password.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Username
            // 
            // 
            // 
            // 
            this.Username.CustomButton.Image = null;
            this.Username.CustomButton.Location = new System.Drawing.Point(118, 1);
            this.Username.CustomButton.Name = "";
            this.Username.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Username.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Username.CustomButton.TabIndex = 1;
            this.Username.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Username.CustomButton.UseSelectable = true;
            this.Username.CustomButton.Visible = false;
            this.Username.Lines = new string[0];
            this.Username.Location = new System.Drawing.Point(199, 154);
            this.Username.MaxLength = 32767;
            this.Username.Name = "Username";
            this.Username.PasswordChar = '\0';
            this.Username.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Username.SelectedText = "";
            this.Username.SelectionLength = 0;
            this.Username.SelectionStart = 0;
            this.Username.ShortcutsEnabled = true;
            this.Username.Size = new System.Drawing.Size(140, 23);
            this.Username.TabIndex = 15;
            this.Username.UseSelectable = true;
            this.Username.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Username.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // DataBase
            // 
            // 
            // 
            // 
            this.DataBase.CustomButton.Image = null;
            this.DataBase.CustomButton.Location = new System.Drawing.Point(118, 1);
            this.DataBase.CustomButton.Name = "";
            this.DataBase.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.DataBase.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.DataBase.CustomButton.TabIndex = 1;
            this.DataBase.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.DataBase.CustomButton.UseSelectable = true;
            this.DataBase.CustomButton.Visible = false;
            this.DataBase.Lines = new string[0];
            this.DataBase.Location = new System.Drawing.Point(199, 115);
            this.DataBase.MaxLength = 32767;
            this.DataBase.Name = "DataBase";
            this.DataBase.PasswordChar = '\0';
            this.DataBase.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.DataBase.SelectedText = "";
            this.DataBase.SelectionLength = 0;
            this.DataBase.SelectionStart = 0;
            this.DataBase.ShortcutsEnabled = true;
            this.DataBase.Size = new System.Drawing.Size(140, 23);
            this.DataBase.TabIndex = 14;
            this.DataBase.UseSelectable = true;
            this.DataBase.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.DataBase.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // ServerAddress
            // 
            // 
            // 
            // 
            this.ServerAddress.CustomButton.Image = null;
            this.ServerAddress.CustomButton.Location = new System.Drawing.Point(118, 1);
            this.ServerAddress.CustomButton.Name = "";
            this.ServerAddress.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.ServerAddress.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.ServerAddress.CustomButton.TabIndex = 1;
            this.ServerAddress.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ServerAddress.CustomButton.UseSelectable = true;
            this.ServerAddress.CustomButton.Visible = false;
            this.ServerAddress.Lines = new string[0];
            this.ServerAddress.Location = new System.Drawing.Point(199, 76);
            this.ServerAddress.MaxLength = 32767;
            this.ServerAddress.Name = "ServerAddress";
            this.ServerAddress.PasswordChar = '\0';
            this.ServerAddress.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ServerAddress.SelectedText = "";
            this.ServerAddress.SelectionLength = 0;
            this.ServerAddress.SelectionStart = 0;
            this.ServerAddress.ShortcutsEnabled = true;
            this.ServerAddress.Size = new System.Drawing.Size(140, 23);
            this.ServerAddress.TabIndex = 13;
            this.ServerAddress.UseSelectable = true;
            this.ServerAddress.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ServerAddress.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(74, 115);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(86, 19);
            this.metroLabel4.TabIndex = 12;
            this.metroLabel4.Text = "База данных";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(74, 194);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(54, 19);
            this.metroLabel3.TabIndex = 11;
            this.metroLabel3.Text = "Пароль";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(74, 154);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(103, 19);
            this.metroLabel2.TabIndex = 10;
            this.metroLabel2.Text = "Учетная запись";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(74, 76);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(100, 19);
            this.metroLabel1.TabIndex = 9;
            this.metroLabel1.Text = "Адрес сервера";
            // 
            // ConnectionSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 303);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.DataBase);
            this.Controls.Add(this.ServerAddress);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Name = "ConnectionSetting";
            this.Text = "Настройки подключения";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton SaveBtn;
        private MetroFramework.Controls.MetroTextBox Password;
        private MetroFramework.Controls.MetroTextBox Username;
        private MetroFramework.Controls.MetroTextBox DataBase;
        private MetroFramework.Controls.MetroTextBox ServerAddress;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}