namespace Kursovoy_proekt
{
    partial class tickets
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
            this.listView2 = new System.Windows.Forms.ListView();
            this.number = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.data = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.to = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.s = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ob = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pb = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.numbertxt = new System.Windows.Forms.TextBox();
            this.obtxt = new System.Windows.Forms.TextBox();
            this.pbtxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.add = new System.Windows.Forms.Button();
            this.change = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.backkk = new System.Windows.Forms.Button();
            this.cb = new System.Windows.Forms.ComboBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.datatxt = new System.Windows.Forms.MaskedTextBox();
            this.tptxt = new System.Windows.Forms.MaskedTextBox();
            this.stxt = new System.Windows.Forms.TextBox();
            this.del = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.помощьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поискToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cbp = new System.Windows.Forms.ToolStripComboBox();
            this.tbp = new System.Windows.Forms.ToolStripTextBox();
            this.search = new System.Windows.Forms.ToolStripMenuItem();
            this.sbrossearch = new System.Windows.Forms.ToolStripMenuItem();
            this.сортировкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cbs = new System.Windows.Forms.ToolStripComboBox();
            this.sort = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.number,
            this.pn,
            this.data,
            this.to,
            this.tp,
            this.s,
            this.ob,
            this.pb});
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(0, 27);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(1381, 446);
            this.listView2.TabIndex = 0;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            this.listView2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView2_MouseClick);
            // 
            // number
            // 
            this.number.Text = "Номер поезда";
            this.number.Width = 107;
            // 
            // pn
            // 
            this.pn.Text = "Пункт назначения";
            this.pn.Width = 135;
            // 
            // data
            // 
            this.data.Text = "Дата отправления";
            this.data.Width = 134;
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
            this.s.Text = "Стоимость одного билета, руб";
            this.s.Width = 212;
            // 
            // ob
            // 
            this.ob.Text = "Оставшиеся для продажи билеты";
            this.ob.Width = 241;
            // 
            // pb
            // 
            this.pb.Text = "Количество проданных билетов";
            this.pb.Width = 227;
            // 
            // numbertxt
            // 
            this.numbertxt.Location = new System.Drawing.Point(1526, 52);
            this.numbertxt.Name = "numbertxt";
            this.numbertxt.Size = new System.Drawing.Size(73, 22);
            this.numbertxt.TabIndex = 1;
            // 
            // obtxt
            // 
            this.obtxt.Location = new System.Drawing.Point(1719, 253);
            this.obtxt.Name = "obtxt";
            this.obtxt.Size = new System.Drawing.Size(100, 22);
            this.obtxt.TabIndex = 7;
            this.obtxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.obtxt_KeyPress);
            // 
            // pbtxt
            // 
            this.pbtxt.Location = new System.Drawing.Point(1616, 287);
            this.pbtxt.Name = "pbtxt";
            this.pbtxt.Size = new System.Drawing.Size(100, 22);
            this.pbtxt.TabIndex = 8;
            this.pbtxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pbtxt_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1390, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Пункт назначения";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1388, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Дата отправления";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1388, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Время отправления";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1388, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(249, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Время прибытия на конечный пункт";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1390, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(178, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Стоимость одного билета";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1390, 253);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(314, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "Количество оставшихся для продажи билетов";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1390, 287);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(220, 17);
            this.label8.TabIndex = 16;
            this.label8.Text = "Количество проданных билетов";
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(1403, 404);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(89, 48);
            this.add.TabIndex = 17;
            this.add.Text = "Добавить";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // change
            // 
            this.change.Location = new System.Drawing.Point(1596, 404);
            this.change.Name = "change";
            this.change.Size = new System.Drawing.Size(89, 48);
            this.change.TabIndex = 18;
            this.change.Text = "Изменить";
            this.change.UseVisualStyleBackColor = true;
            this.change.Click += new System.EventHandler(this.change_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1390, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Номер поезда";
            // 
            // backkk
            // 
            this.backkk.Location = new System.Drawing.Point(1786, 404);
            this.backkk.Name = "backkk";
            this.backkk.Size = new System.Drawing.Size(89, 48);
            this.backkk.TabIndex = 20;
            this.backkk.Text = "Назад";
            this.backkk.UseVisualStyleBackColor = true;
            this.backkk.Click += new System.EventHandler(this.backkk_Click);
            // 
            // cb
            // 
            this.cb.FormattingEnabled = true;
            this.cb.Location = new System.Drawing.Point(1527, 175);
            this.cb.Name = "cb";
            this.cb.Size = new System.Drawing.Size(121, 24);
            this.cb.TabIndex = 21;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(1534, 108);
            this.maskedTextBox1.Mask = "00:00";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(41, 22);
            this.maskedTextBox1.TabIndex = 22;
            this.maskedTextBox1.ValidatingType = typeof(System.DateTime);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(1707, 27);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 23;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // datatxt
            // 
            this.datatxt.Location = new System.Drawing.Point(1527, 80);
            this.datatxt.Mask = "00/00/0000";
            this.datatxt.Name = "datatxt";
            this.datatxt.Size = new System.Drawing.Size(83, 22);
            this.datatxt.TabIndex = 24;
            this.datatxt.ValidatingType = typeof(System.DateTime);
            // 
            // tptxt
            // 
            this.tptxt.Location = new System.Drawing.Point(1643, 142);
            this.tptxt.Mask = "00:00";
            this.tptxt.Name = "tptxt";
            this.tptxt.Size = new System.Drawing.Size(42, 22);
            this.tptxt.TabIndex = 25;
            this.tptxt.ValidatingType = typeof(System.DateTime);
            // 
            // stxt
            // 
            this.stxt.Location = new System.Drawing.Point(1574, 220);
            this.stxt.Name = "stxt";
            this.stxt.Size = new System.Drawing.Size(100, 22);
            this.stxt.TabIndex = 26;
            this.stxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // del
            // 
            this.del.Location = new System.Drawing.Point(1498, 404);
            this.del.Name = "del";
            this.del.Size = new System.Drawing.Size(89, 48);
            this.del.TabIndex = 27;
            this.del.Text = "Удалить";
            this.del.UseVisualStyleBackColor = true;
            this.del.Click += new System.EventHandler(this.button1_Click);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(1691, 404);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(89, 48);
            this.Clear.TabIndex = 28;
            this.Clear.Text = "Очистить";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.помощьToolStripMenuItem,
            this.поискToolStripMenuItem,
            this.сортировкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1899, 30);
            this.menuStrip1.TabIndex = 29;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // помощьToolStripMenuItem
            // 
            this.помощьToolStripMenuItem.Name = "помощьToolStripMenuItem";
            this.помощьToolStripMenuItem.Size = new System.Drawing.Size(83, 26);
            this.помощьToolStripMenuItem.Text = "Помощь";
            this.помощьToolStripMenuItem.Click += new System.EventHandler(this.помощьToolStripMenuItem_Click);
            // 
            // поискToolStripMenuItem
            // 
            this.поискToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cbp,
            this.tbp,
            this.search,
            this.sbrossearch});
            this.поискToolStripMenuItem.Name = "поискToolStripMenuItem";
            this.поискToolStripMenuItem.Size = new System.Drawing.Size(66, 26);
            this.поискToolStripMenuItem.Text = "Поиск";
            this.поискToolStripMenuItem.Click += new System.EventHandler(this.поискToolStripMenuItem_Click);
            // 
            // cbp
            // 
            this.cbp.Name = "cbp";
            this.cbp.Size = new System.Drawing.Size(121, 28);
            this.cbp.DropDown += new System.EventHandler(this.cbp_DropDown);
            this.cbp.DropDownClosed += new System.EventHandler(this.cbp_DropDownClosed);
            // 
            // tbp
            // 
            this.tbp.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbp.Name = "tbp";
            this.tbp.Size = new System.Drawing.Size(100, 27);
            this.tbp.Click += new System.EventHandler(this.tbp_Click);
            // 
            // search
            // 
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(195, 26);
            this.search.Text = "Поиск";
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // sbrossearch
            // 
            this.sbrossearch.Name = "sbrossearch";
            this.sbrossearch.Size = new System.Drawing.Size(195, 26);
            this.sbrossearch.Text = "Сброс поиска";
            this.sbrossearch.Click += new System.EventHandler(this.sbrossearch_Click);
            // 
            // сортировкаToolStripMenuItem
            // 
            this.сортировкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cbs,
            this.sort});
            this.сортировкаToolStripMenuItem.Name = "сортировкаToolStripMenuItem";
            this.сортировкаToolStripMenuItem.Size = new System.Drawing.Size(113, 26);
            this.сортировкаToolStripMenuItem.Text = "Сортировать";
            this.сортировкаToolStripMenuItem.Click += new System.EventHandler(this.сортировкаToolStripMenuItem_Click);
            // 
            // cbs
            // 
            this.cbs.Name = "cbs";
            this.cbs.Size = new System.Drawing.Size(121, 28);
            this.cbs.DropDown += new System.EventHandler(this.cbs_DropDown);
            this.cbs.DropDownClosed += new System.EventHandler(this.cbs_DropDownClosed);
            // 
            // sort
            // 
            this.sort.Name = "sort";
            this.sort.Size = new System.Drawing.Size(195, 26);
            this.sort.Text = "Cортировать";
            this.sort.Click += new System.EventHandler(this.sort_Click);
            // 
            // tickets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1899, 414);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.del);
            this.Controls.Add(this.stxt);
            this.Controls.Add(this.tptxt);
            this.Controls.Add(this.datatxt);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.cb);
            this.Controls.Add(this.backkk);
            this.Controls.Add(this.change);
            this.Controls.Add(this.add);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbtxt);
            this.Controls.Add(this.obtxt);
            this.Controls.Add(this.numbertxt);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "tickets";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "tickets";
            this.Load += new System.EventHandler(this.tickets_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader number;
        private System.Windows.Forms.ColumnHeader pn;
        private System.Windows.Forms.ColumnHeader data;
        private System.Windows.Forms.ColumnHeader to;
        private System.Windows.Forms.ColumnHeader tp;
        private System.Windows.Forms.ColumnHeader s;
        private System.Windows.Forms.ColumnHeader ob;
        private System.Windows.Forms.ColumnHeader pb;
        private System.Windows.Forms.TextBox numbertxt;
        private System.Windows.Forms.TextBox obtxt;
        private System.Windows.Forms.TextBox pbtxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button change;
     
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button backkk;
        private System.Windows.Forms.ComboBox cb;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.MaskedTextBox datatxt;
        private System.Windows.Forms.MaskedTextBox tptxt;
        private System.Windows.Forms.TextBox stxt;
        private System.Windows.Forms.Button del;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem помощьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поискToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сортировкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox cbs;
        private System.Windows.Forms.ToolStripComboBox cbp;
        private System.Windows.Forms.ToolStripTextBox tbp;
        private System.Windows.Forms.ToolStripMenuItem search;
        private System.Windows.Forms.ToolStripMenuItem sbrossearch;
        private System.Windows.Forms.ToolStripMenuItem sort;
    }
}