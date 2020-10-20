namespace Kursovoy_proekt
{
    partial class avtorization
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.help = new System.Windows.Forms.ToolStripMenuItem();
            this.exit = new System.Windows.Forms.ToolStripMenuItem();
            this.avto = new System.Windows.Forms.Button();
            this.login = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.logintext = new System.Windows.Forms.TextBox();
            this.passwordtext = new System.Windows.Forms.TextBox();
            this.back = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.help,
            this.exit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // help
            // 
            this.help.Name = "help";
            this.help.Size = new System.Drawing.Size(83, 24);
            this.help.Text = "Помощь";
            this.help.Click += new System.EventHandler(this.помощьToolStripMenuItem_Click);
            // 
            // exit
            // 
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(14, 24);
            // 
            // avto
            // 
            this.avto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.avto.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.avto.Location = new System.Drawing.Point(64, 283);
            this.avto.Name = "avto";
            this.avto.Size = new System.Drawing.Size(268, 58);
            this.avto.TabIndex = 1;
            this.avto.Text = "Авторизоваться";
            this.avto.UseVisualStyleBackColor = true;
            this.avto.Click += new System.EventHandler(this.avto_Click);
            // 
            // login
            // 
            this.login.AutoSize = true;
            this.login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.login.Location = new System.Drawing.Point(274, 77);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(68, 25);
            this.login.TabIndex = 2;
            this.login.Text = "Логин";
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.password.Location = new System.Drawing.Point(276, 149);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(80, 25);
            this.password.TabIndex = 3;
            this.password.Text = "Пароль";
            // 
            // logintext
            // 
            this.logintext.Location = new System.Drawing.Point(279, 105);
            this.logintext.Multiline = true;
            this.logintext.Name = "logintext";
            this.logintext.Size = new System.Drawing.Size(205, 30);
            this.logintext.TabIndex = 4;
            // 
            // passwordtext
            // 
            this.passwordtext.Location = new System.Drawing.Point(279, 177);
            this.passwordtext.Multiline = true;
            this.passwordtext.Name = "passwordtext";
            this.passwordtext.PasswordChar = '•';
            this.passwordtext.Size = new System.Drawing.Size(205, 29);
            this.passwordtext.TabIndex = 5;
            // 
            // back
            // 
            this.back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.back.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.back.Location = new System.Drawing.Point(458, 283);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(268, 58);
            this.back.TabIndex = 6;
            this.back.Text = "Назад";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // avtorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.back);
            this.Controls.Add(this.passwordtext);
            this.Controls.Add(this.logintext);
            this.Controls.Add(this.password);
            this.Controls.Add(this.login);
            this.Controls.Add(this.avto);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "avtorization";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.avtorization_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem help;
        private System.Windows.Forms.ToolStripMenuItem exit;
        private System.Windows.Forms.Button avto;
        private System.Windows.Forms.Label login;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.TextBox logintext;
        private System.Windows.Forms.TextBox passwordtext;
        private System.Windows.Forms.Button back;
    }
}