namespace Kursovoy_proekt
{
    partial class user
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
            this.сортироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.combosort = new System.Windows.Forms.ToolStripComboBox();
            this.сортироватьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.поискToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.combopoisk = new System.Windows.Forms.ToolStripComboBox();
            this.textpoisk = new System.Windows.Forms.ToolStripTextBox();
            this.poisk = new System.Windows.Forms.ToolStripMenuItem();
            this.сбросПоискаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listView1 = new System.Windows.Forms.ListView();
            this.number = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.data = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.to = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.s = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ob = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pb = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Back = new System.Windows.Forms.Button();
            this.buy = new System.Windows.Forms.Button();
            this.kolvo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numbertrain = new System.Windows.Forms.TextBox();
            this.Find = new System.Windows.Forms.Button();
            this.t1 = new System.Windows.Forms.MaskedTextBox();
            this.t2 = new System.Windows.Forms.MaskedTextBox();
            this.town = new System.Windows.Forms.TextBox();
            this.sbros = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpp,
            this.сортироватьToolStripMenuItem,
            this.поискToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1899, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // helpp
            // 
            this.helpp.Name = "helpp";
            this.helpp.Size = new System.Drawing.Size(83, 24);
            this.helpp.Text = "Помощь";
            this.helpp.Click += new System.EventHandler(this.помощьToolStripMenuItem_Click);
            // 
            // сортироватьToolStripMenuItem
            // 
            this.сортироватьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.combosort,
            this.сортироватьToolStripMenuItem1});
            this.сортироватьToolStripMenuItem.Name = "сортироватьToolStripMenuItem";
            this.сортироватьToolStripMenuItem.Size = new System.Drawing.Size(113, 24);
            this.сортироватьToolStripMenuItem.Text = "Сортировать";
            this.сортироватьToolStripMenuItem.Click += new System.EventHandler(this.сортироватьToolStripMenuItem_Click);
            // 
            // combosort
            // 
            this.combosort.Name = "combosort";
            this.combosort.Size = new System.Drawing.Size(121, 28);
            this.combosort.DropDown += new System.EventHandler(this.toolStripComboBox1_DropDown);
            this.combosort.DropDownClosed += new System.EventHandler(this.toolStripComboBox1_DropDownClosed);
            // 
            // сортироватьToolStripMenuItem1
            // 
            this.сортироватьToolStripMenuItem1.Name = "сортироватьToolStripMenuItem1";
            this.сортироватьToolStripMenuItem1.Size = new System.Drawing.Size(195, 26);
            this.сортироватьToolStripMenuItem1.Text = "Сортировать";
            this.сортироватьToolStripMenuItem1.Click += new System.EventHandler(this.сортироватьToolStripMenuItem1_Click);
            // 
            // поискToolStripMenuItem1
            // 
            this.поискToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.combopoisk,
            this.textpoisk,
            this.poisk,
            this.сбросПоискаToolStripMenuItem});
            this.поискToolStripMenuItem1.Name = "поискToolStripMenuItem1";
            this.поискToolStripMenuItem1.Size = new System.Drawing.Size(66, 24);
            this.поискToolStripMenuItem1.Text = "Поиск";
            this.поискToolStripMenuItem1.Click += new System.EventHandler(this.поискToolStripMenuItem1_Click);
            // 
            // combopoisk
            // 
            this.combopoisk.Name = "combopoisk";
            this.combopoisk.Size = new System.Drawing.Size(121, 28);
            this.combopoisk.DropDown += new System.EventHandler(this.toolStripComboBox2_DropDown);
            this.combopoisk.DropDownClosed += new System.EventHandler(this.toolStripComboBox2_DropDownClosed);
            // 
            // textpoisk
            // 
            this.textpoisk.Name = "textpoisk";
            this.textpoisk.Size = new System.Drawing.Size(100, 27);
            this.textpoisk.Click += new System.EventHandler(this.toolStripTextBox2_Click);
            // 
            // poisk
            // 
            this.poisk.Name = "poisk";
            this.poisk.Size = new System.Drawing.Size(195, 26);
            this.poisk.Text = "Поиск";
            this.poisk.Click += new System.EventHandler(this.poisk_Click);
            // 
            // сбросПоискаToolStripMenuItem
            // 
            this.сбросПоискаToolStripMenuItem.Name = "сбросПоискаToolStripMenuItem";
            this.сбросПоискаToolStripMenuItem.Size = new System.Drawing.Size(195, 26);
            this.сбросПоискаToolStripMenuItem.Text = "Сброс поиска";
            this.сбросПоискаToolStripMenuItem.Click += new System.EventHandler(this.сбросПоискаToolStripMenuItem_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.number,
            this.pn,
            this.data,
            this.to,
            this.tp,
            this.s,
            this.ob,
            this.pb});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 31);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1361, 432);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // number
            // 
            this.number.Text = "Номер поезда";
            this.number.Width = 106;
            // 
            // pn
            // 
            this.pn.Text = "Пункт назначения";
            this.pn.Width = 135;
            // 
            // data
            // 
            this.data.Text = "Дата отправления";
            this.data.Width = 133;
            // 
            // to
            // 
            this.to.Text = "Время отправления";
            this.to.Width = 142;
            // 
            // tp
            // 
            this.tp.Text = "Время прибытия";
            this.tp.Width = 120;
            // 
            // s
            // 
            this.s.Text = "Цена билета";
            this.s.Width = 99;
            // 
            // ob
            // 
            this.ob.Text = "Оставшиеся билеты";
            this.ob.Width = 144;
            // 
            // pb
            // 
            this.pb.Text = "Проданные билеты";
            this.pb.Width = 141;
            // 
            // Back
            // 
            this.Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Back.Location = new System.Drawing.Point(1622, 376);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(173, 56);
            this.Back.TabIndex = 3;
            this.Back.Text = "Назад";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // buy
            // 
            this.buy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buy.Location = new System.Drawing.Point(1407, 376);
            this.buy.Name = "buy";
            this.buy.Size = new System.Drawing.Size(173, 56);
            this.buy.TabIndex = 4;
            this.buy.Text = "Купить";
            this.buy.UseVisualStyleBackColor = true;
            this.buy.Click += new System.EventHandler(this.buy_Click);
            // 
            // kolvo
            // 
            this.kolvo.Location = new System.Drawing.Point(1680, 84);
            this.kolvo.Name = "kolvo";
            this.kolvo.Size = new System.Drawing.Size(100, 22);
            this.kolvo.TabIndex = 8;
            this.kolvo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.kolvo_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(1378, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 32);
            this.label1.TabIndex = 6;
            this.label1.Text = "Количество билетов";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(1378, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 32);
            this.label2.TabIndex = 7;
            this.label2.Text = "Номер поезда";
            // 
            // numbertrain
            // 
            this.numbertrain.Location = new System.Drawing.Point(1588, 136);
            this.numbertrain.Name = "numbertrain";
            this.numbertrain.Size = new System.Drawing.Size(100, 22);
            this.numbertrain.TabIndex = 0;
            this.numbertrain.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numbertrain_KeyPress);
            // 
            // Find
            // 
            this.Find.Location = new System.Drawing.Point(1641, 238);
            this.Find.Name = "Find";
            this.Find.Size = new System.Drawing.Size(75, 23);
            this.Find.TabIndex = 9;
            this.Find.Text = "Найти";
            this.Find.UseVisualStyleBackColor = true;
            this.Find.Click += new System.EventHandler(this.Find_Click);
            // 
            // t1
            // 
            this.t1.Location = new System.Drawing.Point(1503, 211);
            this.t1.Mask = "00:00";
            this.t1.Name = "t1";
            this.t1.Size = new System.Drawing.Size(100, 22);
            this.t1.TabIndex = 10;
            this.t1.ValidatingType = typeof(System.DateTime);
            // 
            // t2
            // 
            this.t2.Location = new System.Drawing.Point(1503, 239);
            this.t2.Mask = "00:00";
            this.t2.Name = "t2";
            this.t2.Size = new System.Drawing.Size(100, 22);
            this.t2.TabIndex = 11;
            this.t2.ValidatingType = typeof(System.DateTime);
            // 
            // town
            // 
            this.town.Location = new System.Drawing.Point(1503, 267);
            this.town.Name = "town";
            this.town.Size = new System.Drawing.Size(100, 22);
            this.town.TabIndex = 12;
            this.town.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.town_KeyPress);
            // 
            // sbros
            // 
            this.sbros.Location = new System.Drawing.Point(1741, 238);
            this.sbros.Name = "sbros";
            this.sbros.Size = new System.Drawing.Size(75, 23);
            this.sbros.TabIndex = 13;
            this.sbros.Text = "Сброс";
            this.sbros.UseVisualStyleBackColor = true;
            this.sbros.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1367, 270);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Пункт назначения";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1367, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Время отправления";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1474, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "от";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1473, 242);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "до";
            // 
            // user
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1899, 475);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.sbros);
            this.Controls.Add(this.town);
            this.Controls.Add(this.t2);
            this.Controls.Add(this.t1);
            this.Controls.Add(this.Find);
            this.Controls.Add(this.numbertrain);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.kolvo);
            this.Controls.Add(this.buy);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "user";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Продажа железнодорожных билетов";
            this.Load += new System.EventHandler(this.user_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem helpp;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader number;
        private System.Windows.Forms.ColumnHeader pn;
        private System.Windows.Forms.ColumnHeader data;
        private System.Windows.Forms.ColumnHeader to;
        private System.Windows.Forms.ColumnHeader tp;
        private System.Windows.Forms.ColumnHeader s;
        private System.Windows.Forms.ColumnHeader ob;
        private System.Windows.Forms.ColumnHeader pb;
        private System.Windows.Forms.ToolStripMenuItem сортироватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox combosort;
        private System.Windows.Forms.ToolStripMenuItem сортироватьToolStripMenuItem1;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.ToolStripMenuItem поискToolStripMenuItem1;
        private System.Windows.Forms.ToolStripComboBox combopoisk;
        private System.Windows.Forms.ToolStripTextBox textpoisk;
        private System.Windows.Forms.ToolStripMenuItem poisk;
        private System.Windows.Forms.ToolStripMenuItem сбросПоискаToolStripMenuItem;
        private System.Windows.Forms.Button buy;
        private System.Windows.Forms.TextBox kolvo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox numbertrain;
        private System.Windows.Forms.Button Find;
        private System.Windows.Forms.MaskedTextBox t1;
        private System.Windows.Forms.MaskedTextBox t2;
        private System.Windows.Forms.TextBox town;
        private System.Windows.Forms.Button sbros;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}