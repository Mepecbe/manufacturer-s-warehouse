namespace BDiSUBD
{
    partial class Form1
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
            this.LoginTextBox = new MetroFramework.Controls.MetroTextBox();
            this.PasswordTextBox = new MetroFramework.Controls.MetroTextBox();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.Storehouse = new MetroFramework.Controls.MetroComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // LoginTextBox
            // 
            // 
            // 
            // 
            this.LoginTextBox.CustomButton.Image = null;
            this.LoginTextBox.CustomButton.Location = new System.Drawing.Point(123, 1);
            this.LoginTextBox.CustomButton.Name = "";
            this.LoginTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.LoginTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.LoginTextBox.CustomButton.TabIndex = 1;
            this.LoginTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.LoginTextBox.CustomButton.UseSelectable = true;
            this.LoginTextBox.CustomButton.Visible = false;
            this.LoginTextBox.Lines = new string[] {
        "val0dko99@mail.ru"};
            this.LoginTextBox.Location = new System.Drawing.Point(132, 63);
            this.LoginTextBox.MaxLength = 32767;
            this.LoginTextBox.Name = "LoginTextBox";
            this.LoginTextBox.PasswordChar = '\0';
            this.LoginTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.LoginTextBox.SelectedText = "";
            this.LoginTextBox.SelectionLength = 0;
            this.LoginTextBox.SelectionStart = 0;
            this.LoginTextBox.ShortcutsEnabled = true;
            this.LoginTextBox.Size = new System.Drawing.Size(145, 23);
            this.LoginTextBox.TabIndex = 0;
            this.LoginTextBox.Text = "val0dko99@mail.ru";
            this.LoginTextBox.UseSelectable = true;
            this.LoginTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.LoginTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // PasswordTextBox
            // 
            // 
            // 
            // 
            this.PasswordTextBox.CustomButton.Image = null;
            this.PasswordTextBox.CustomButton.Location = new System.Drawing.Point(123, 1);
            this.PasswordTextBox.CustomButton.Name = "";
            this.PasswordTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.PasswordTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.PasswordTextBox.CustomButton.TabIndex = 1;
            this.PasswordTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.PasswordTextBox.CustomButton.UseSelectable = true;
            this.PasswordTextBox.CustomButton.Visible = false;
            this.PasswordTextBox.Lines = new string[] {
        "1234"};
            this.PasswordTextBox.Location = new System.Drawing.Point(132, 109);
            this.PasswordTextBox.MaxLength = 32767;
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '\0';
            this.PasswordTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.PasswordTextBox.SelectedText = "";
            this.PasswordTextBox.SelectionLength = 0;
            this.PasswordTextBox.SelectionStart = 0;
            this.PasswordTextBox.ShortcutsEnabled = true;
            this.PasswordTextBox.Size = new System.Drawing.Size(145, 23);
            this.PasswordTextBox.TabIndex = 1;
            this.PasswordTextBox.Text = "1234";
            this.PasswordTextBox.UseSelectable = true;
            this.PasswordTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.PasswordTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = this;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(43, 63);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(47, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Логин";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(43, 109);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(54, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Пароль";
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(96, 193);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(106, 41);
            this.metroButton1.TabIndex = 4;
            this.metroButton1.Text = "Авторизация";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click_1);
            // 
            // Storehouse
            // 
            this.Storehouse.FormattingEnabled = true;
            this.Storehouse.ItemHeight = 23;
            this.Storehouse.Location = new System.Drawing.Point(43, 147);
            this.Storehouse.Name = "Storehouse";
            this.Storehouse.Size = new System.Drawing.Size(234, 29);
            this.Storehouse.TabIndex = 5;
            this.Storehouse.UseSelectable = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 247);
            this.Controls.Add(this.Storehouse);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.LoginTextBox);
            this.Name = "Form1";
            this.Text = "Авторизация";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox LoginTextBox;
        private MetroFramework.Controls.MetroTextBox PasswordTextBox;
        public MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox Storehouse;
    }
}

