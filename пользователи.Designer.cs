namespace Kursovoy_proekt
{
    partial class admin
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
            this.helpp = new System.Windows.Forms.ToolStripMenuItem();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Login = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Password = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Role = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.b = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.Updatee = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.logtxt = new System.Windows.Forms.TextBox();
            this.passtxt = new System.Windows.Forms.TextBox();
            this.roletxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpp});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // helpp
            // 
            this.helpp.Name = "helpp";
            this.helpp.Size = new System.Drawing.Size(83, 24);
            this.helpp.Text = "Помощь";
            this.helpp.Click += new System.EventHandler(this.помощьToolStripMenuItem_Click);
            // 
            // listView1
            // 
            this.listView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Login,
            this.Password,
            this.Role});
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 28);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(477, 409);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseClick);
            // 
            // Login
            // 
            this.Login.Text = "логин";
            this.Login.Width = 134;
            // 
            // Password
            // 
            this.Password.Text = "пароль";
            this.Password.Width = 100;
            // 
            // Role
            // 
            this.Role.Text = "роль";
            this.Role.Width = 301;
            // 
            // b
            // 
            this.b.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.b.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b.Location = new System.Drawing.Point(624, 386);
            this.b.Name = "b";
            this.b.Size = new System.Drawing.Size(143, 51);
            this.b.TabIndex = 2;
            this.b.Text = "Назад";
            this.b.UseVisualStyleBackColor = true;
            this.b.Click += new System.EventHandler(this.b_Click);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(514, 216);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(99, 38);
            this.add.TabIndex = 3;
            this.add.Text = "Добавить";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // Updatee
            // 
            this.Updatee.Location = new System.Drawing.Point(645, 216);
            this.Updatee.Name = "Updatee";
            this.Updatee.Size = new System.Drawing.Size(122, 38);
            this.Updatee.TabIndex = 4;
            this.Updatee.Text = "Редактировать";
            this.Updatee.UseVisualStyleBackColor = true;
            this.Updatee.Click += new System.EventHandler(this.Update_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(514, 275);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(99, 38);
            this.Delete.TabIndex = 6;
            this.Delete.Text = "Удалить";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // logtxt
            // 
            this.logtxt.Location = new System.Drawing.Point(574, 54);
            this.logtxt.Name = "logtxt";
            this.logtxt.Size = new System.Drawing.Size(100, 22);
            this.logtxt.TabIndex = 7;
            // 
            // passtxt
            // 
            this.passtxt.Location = new System.Drawing.Point(574, 83);
            this.passtxt.Name = "passtxt";
            this.passtxt.Size = new System.Drawing.Size(100, 22);
            this.passtxt.TabIndex = 8;
            // 
            // roletxt
            // 
            this.roletxt.Location = new System.Drawing.Point(574, 112);
            this.roletxt.Name = "roletxt";
            this.roletxt.Size = new System.Drawing.Size(100, 22);
            this.roletxt.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(520, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Логин";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(511, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Пароль";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(522, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Роль";
            // 
            // admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 460);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.roletxt);
            this.Controls.Add(this.passtxt);
            this.Controls.Add(this.logtxt);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Updatee);
            this.Controls.Add(this.add);
            this.Controls.Add(this.b);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "admin";
            this.Load += new System.EventHandler(this.admin_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button b;
        public System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Login;
        private System.Windows.Forms.ColumnHeader Password;
        private System.Windows.Forms.ColumnHeader Role;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button Updatee;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.TextBox logtxt;
        private System.Windows.Forms.TextBox passtxt;
        private System.Windows.Forms.TextBox roletxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem helpp;
    }
}