using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Kursovoy_proekt
{
    public partial class tickets : Form
    {
        public tickets()
        {
            InitializeComponent();

            cb.Items.AddRange(new string[] { "Шклов", "Орша", "Горки", "Осиповичи" });
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.Left = 0;
            this.Top = 0;

        }

        private void tickets_Load(object sender, EventArgs e)
        {
            cbs.Items.AddRange(new string[] { "По номеру поезда", "По пункту назначения", "По дате отправления", "По времени отправления", "По времени прибытия", "По цене билета", "По оставшимся билетам", "По проданным билетам" });
            cbp.Items.AddRange(new string[] { "По номеру поезда", "По пункту назначения", "По дате отправления", "По времени отправления", "По времени прибытия", "По цене билета", "По оставшимся билетам", "По проданным билетам" });
            this.MinimumSize = new Size(1917, 430);
            StreamReader strcount = new StreamReader("train.txt", true);
            string str;
            int n = 0;
            while (true)
            {
                str = strcount.ReadLine();
                if (str == "" || str == null)
                    break;
                n++;
            }
            Database.m = n;
            strcount.Close();
            Database.rase = new Database.TrainData[Database.m];

            StreamReader reader = new StreamReader("train.txt", true);
            for (int i = 0; ; i++)
            {
                str = reader.ReadLine();
                if (str == "" || str == null)
                    break;
                string[] dataacc = str.Split(';');

                Database.rase[i].number = dataacc[0];
                Database.rase[i].pn = dataacc[1];
                Database.rase[i].data = dataacc[2];
                Database.rase[i].to = dataacc[3];
                Database.rase[i].tp = dataacc[4];
                Database.rase[i].s = dataacc[5];
                Database.rase[i].ob = dataacc[6];
                Database.rase[i].pb = dataacc[7];
                ListViewItem item1 = new ListViewItem(dataacc);
                listView2.Items.Add(item1);

            }
            reader.Close();
        }
        private void adddd(string number, string pn, string data, string to, string tp, string s, string ob, string pb)
        {
            string[] row = { number, pn, data, to, tp, s, ob, pb };

            bool chek = true;
            string numberr = numbertxt.Text;
            string pnn = cb.Text;
            string dataa = datatxt.Text;
            string too = maskedTextBox1.Text;
            string tpp = tptxt.Text;
            string ss = stxt.Text;
            string obb = obtxt.Text;
            string pbb = pbtxt.Text;

            StreamReader str = new StreamReader("train.txt");
            string text;
            while ((text = str.ReadLine()) != null)
            {
                string[] mystring = text.Split(';');
                if (mystring[0] == number)
                {


                    chek = false;
                    break;
                }

            }

            str.Close();

            if (chek == false)
            {
                MessageBox.Show("Поезд с таким номером уже существует");
            }
            else
            {
                if (numberr == "" || pnn == "" || dataa == "" || too == "" || tpp == "" || ss == "" || obb == "" || pbb == "")
                {
                    MessageBox.Show("Введите данные!", "Ошибка", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                }



                else
                {
                    if (Convert.ToInt32(numberr) > 0)
                    {
                        StreamWriter sw = new StreamWriter("train.txt", true);
                        sw.WriteLine(numberr + ";" + pnn + ";" + dataa + ";" + too + ";" + tpp + ";" + ss + ";" + obb + ";" + pbb);
                        MessageBox.Show("Рейс добавлен");
                        sw.Close();
                        ListViewItem item = new ListViewItem(row);
                        listView2.Items.Add(item);
                    }


                }
            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            adddd(numbertxt.Text, cb.Text, datatxt.Text, maskedTextBox1.Text, tptxt.Text, stxt.Text, obtxt.Text, pbtxt.Text);

            numbertxt.Text = "";
            cb.Text = "";
            datatxt.Text = "";
            maskedTextBox1.Text = "";
            tptxt.Text = "";
            stxt.Text = "";
            obtxt.Text = "";
            pbtxt.Text = "";


        }

        private void backkk_Click(object sender, EventArgs e)
        {
            choice f5 = new choice();
            this.Hide();
            f5.Show();
        }
        private void Uupdate()
        {

            if (numbertxt.Text == "" || maskedTextBox1.Text == "" || cb.Text == "" || datatxt.Text == "" || obtxt.Text == "" || stxt.Text == "" || pbtxt.Text == "" || tptxt.Text == "")
            {      
              MessageBox.Show("Введите данные!", "Ошибка", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);                                        
            }
            else
            {
                bool f = false;
                StreamReader reader = new StreamReader("train.txt");
                while (true)
                {
                    string strin = reader.ReadLine();
                    if (strin == null)
                        break;
                    string[] accdata = new string[Database.rase.Length];
                    accdata = strin.Split(';');

                    if (numbertxt.Text == accdata[0] && accdata[0] != listView2.FocusedItem.SubItems[0].Text)
                    {
                        f = true;
                        break;
                    }
                }
                reader.Close();
                if (f == true)
                {
                    MessageBox.Show("Поезд с таким номером уже существует");
                }
                else
                {
                    string numberr = numbertxt.Text;
                    string pnn = cb.Text;
                    string dataa = datatxt.Text;
                    string too = maskedTextBox1.Text;
                    string tpp = tptxt.Text;
                    string ss = stxt.Text;
                    string obb = obtxt.Text;
                    string pbb = pbtxt.Text;
                    StreamReader str = new StreamReader("train.txt");
                    string text;
                    while ((text = str.ReadLine()) != null)
                    {
                        string[] mystring = text.Split(';');

                    }

                    str.Close();



                    for (int i = 0; i < Database.rase.Length; i++)
                    {


                        if (Database.rase[i].number == listView2.FocusedItem.SubItems[0].Text)
                        {
                            Database.rase[i].number = numbertxt.Text;
                            Database.rase[i].pn = cb.Text;
                            Database.rase[i].data = datatxt.Text;
                            Database.rase[i].to = maskedTextBox1.Text;
                            Database.rase[i].tp = tptxt.Text;
                            Database.rase[i].s = stxt.Text;
                            Database.rase[i].ob = obtxt.Text;
                            Database.rase[i].pb = pbtxt.Text;
                        }
                    }
                    StreamWriter wr = new StreamWriter("train.txt", false);

                    for (int i = 0; i < Database.rase.Length; i++)
                    {
                        wr.WriteLine(Database.rase[i].number + ";" + Database.rase[i].pn + ";" + Database.rase[i].data + ";" + Database.rase[i].to + ";" + Database.rase[i].tp + ";" + Database.rase[i].s + ";" + Database.rase[i].ob + ";" + Database.rase[i].pb);
                    }
                    wr.Close();
                    this.Close();
                    tickets p = new tickets();
                    p.Show();
                    MessageBox.Show("Рейс изменен.");
                }
                numbertxt.Text = "";
                cb.Text = "";
                datatxt.Text = "";
                maskedTextBox1.Text = "";
                tptxt.Text = "";
                stxt.Text = "";
                obtxt.Text = "";
                pbtxt.Text = "";



            }
        }

        private void listView2_MouseClick(object sender, MouseEventArgs e)
        {
            numbertxt.Text = listView2.SelectedItems[0].SubItems[0].Text;
            cb.Text = listView2.SelectedItems[0].SubItems[1].Text;
            datatxt.Text = listView2.SelectedItems[0].SubItems[2].Text;
            maskedTextBox1.Text = listView2.SelectedItems[0].SubItems[3].Text;
            tptxt.Text = listView2.SelectedItems[0].SubItems[4].Text;
            stxt.Text = listView2.SelectedItems[0].SubItems[5].Text;
            obtxt.Text = listView2.SelectedItems[0].SubItems[6].Text;
            pbtxt.Text = listView2.SelectedItems[0].SubItems[7].Text;
        }

        private void change_Click(object sender, EventArgs e)
        {
            Uupdate();
           
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            datatxt.Text = monthCalendar1.SelectionStart.ToString();
        }

        private void pbtxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void obtxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == '.') || (e.KeyChar == ','))
            {
                TextBox txt = (TextBox)sender;
                if (txt.Text.Contains(".") || txt.Text.Contains(","))
                {
                    e.Handled = true;
                }
                return;
            }

            if (!(Char.IsDigit(e.KeyChar)))
            {
                if ((e.KeyChar != (char)Keys.Back))
                {
                    e.Handled = true;
                }
            }
        }
        private void delete()
        {
            if (MessageBox.Show("Вы уверены что хотите удалить этот рейс?", "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                int k = 0;
                Database.TrainData[] copy = new Database.TrainData[Database.rase.Length - 1];
                for (int i = 0; i < Database.rase.Length; i++)
                {
                    if (Database.rase[i].number == numbertxt.Text)
                    {
                        k = i;
                        break;
                    }
                    copy[i] = Database.rase[i];
                }
                for (int i = k, j = k + 1; j < Database.rase.Length; i++, j++)
                {
                    copy[i] = Database.rase[j];
                }
                Database.m--;
                Database.rase = new Database.TrainData[Database.m];
                Database.rase = copy;
                StreamWriter wr = new StreamWriter("train.txt", false);
                for (int i = 0; i < Database.rase.Length; i++)
                {
                    wr.WriteLine(Database.rase[i].number + ";" + Database.rase[i].pn + ";" + Database.rase[i].data + ";" + Database.rase[i].to + ";" + Database.rase[i].tp + ";" + Database.rase[i].s + ";" + Database.rase[i].ob + ";" + Database.rase[i].pb);
                }
                wr.Close();
                this.Close();
                tickets t = new tickets();
                t.Show();
                MessageBox.Show("Рейс удален", "", MessageBoxButtons.OK);

            }
            numbertxt.Text = "";
            cb.Text = "";
            datatxt.Text = "";
            maskedTextBox1.Text = "";
            tptxt.Text = "";
            stxt.Text = "";
            obtxt.Text = "";
            pbtxt.Text = "";
        }
        

        private void button1_Click(object sender, EventArgs e)
        {

            delete();
            

        }

        
        private void Clear_Click(object sender, EventArgs e)
        {
            numbertxt.Text = "";
            cb.Text = "";
            datatxt.Text = "";
            maskedTextBox1.Text = "";
            tptxt.Text = "";
            stxt.Text = "";
            obtxt.Text = "";
            pbtxt.Text = "";
           
        }

        private void помощьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Для того что бы редактировать рейс, нажмите на номер поезда, и измение что вам нужно", "Помощь", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void сортировкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cbs.ForeColor = System.Drawing.Color.Gray;
            cbs.Text = "Параметр сортировки";
        }

        private void sort_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView2.Items)
            {
                listView2.Items.Remove(item);
            }
            var list = new List<Database.TrainData>(Database.rase);
            IOrderedEnumerable<Database.TrainData> result;
            switch (cbs.SelectedIndex)
            {
                case 0:
                    result = from item in list
                             orderby item.number
                             select item;
                    break;
                case 1:
                    result = from item in list
                             orderby item.pn ascending
                             select item;
                    break;
                case 2:
                    result = from item in list
                             orderby item.data ascending
                             select item;
                    break;
                case 3:
                    result = from item in list
                             orderby item.to ascending
                             select item;
                    break;
                case 4:
                    result = from item in list
                             orderby item.tp ascending
                             select item;
                    break;
                case 5:
                    result = from item in list
                             orderby item.s ascending
                             select item;
                    break;
                case 6:
                    result = from item in list
                             orderby item.ob ascending
                             select item;
                    break;
                case 7:
                    result = from item in list
                             orderby item.ob ascending
                             select item;
                    break;

                default:
                    result = from item in list
                             orderby item.number ascending
                             select item;
                    break;
            }
            foreach (Database.TrainData item in result)
            {
                string[] fit = { item.number, item.pn, item.data, item.to, item.tp, item.s, item.ob, item.pb };
                ListViewItem it = new ListViewItem(fit);
                listView2.Items.Add(it);
            }
        }

        private void cbs_DropDown(object sender, EventArgs e)
        {
            cbs.ForeColor = System.Drawing.Color.Black;
            cbs.Text = "";
        }

        private void cbs_DropDownClosed(object sender, EventArgs e)
        {
            cbs.ForeColor = System.Drawing.Color.Gray;
            cbs.Text = "Параметр сортировки";
        }

        private void поискToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cbp.ForeColor = System.Drawing.Color.Gray;
            cbp.Text = "Параметр поиска";
            tbp.ForeColor = System.Drawing.Color.Gray;
            tbp.Text = "Вводите здесь";
        }

        private void cbp_DropDown(object sender, EventArgs e)
        {
            cbp.ForeColor = System.Drawing.Color.Black;
            cbp.Text = "";
        }

        private void cbp_DropDownClosed(object sender, EventArgs e)
        {
            cbp.ForeColor = System.Drawing.Color.Gray;
            cbp.Text = "Параметр поиска";
        }

        private void tbp_Click(object sender, EventArgs e)
        {
            tbp.ForeColor = System.Drawing.Color.Black;
            tbp.Text = "";
        }

        private void search_Click(object sender, EventArgs e)
        {
            List<Database.TrainData> fitems = new List<Database.TrainData>();
            var list = new List<Database.TrainData>(Database.rase);
            foreach (ListViewItem item in listView2.Items)
            {
                listView2.Items.Remove(item);
            }
            switch (cbp.SelectedIndex)
            {
                case 0:
                    fitems = list.FindAll(x => x.number.ToLower().StartsWith(tbp.Text));
                    break;
                case 1:
                    fitems = list.FindAll(x => x.pn.ToString().StartsWith(tbp.Text));
                    break;
                case 2:
                    fitems = list.FindAll(x => x.data.ToString().StartsWith(tbp.Text));
                    break;
                case 3:
                    fitems = list.FindAll(x => x.to.ToLower().StartsWith(tbp.Text));
                    break;
                case 4:
                    fitems = list.FindAll(x => x.tp.ToString().StartsWith(tbp.Text));
                    break;
                case 5:
                    fitems = list.FindAll(x => x.s.ToString().StartsWith(tbp.Text));
                    break;
                case 6:
                    fitems = list.FindAll(x => x.ob.ToString().StartsWith(tbp.Text));
                    break;
                case 7:
                    fitems = list.FindAll(x => x.pb.ToString().StartsWith(tbp.Text));
                    break;
            }
            if (fitems.Count == 0)
            {
                MessageBox.Show("Ничего не найдено!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sbrossearch.PerformClick();
                return;
            }
            foreach (Database.TrainData item in fitems)
            {
                string[] fit = { item.number, item.pn, item.data, item.to, item.tp, item.s, item.ob, item.pb };
                ListViewItem it = new ListViewItem(fit);
                listView2.Items.Add(it);
            }
        }

        private void sbrossearch_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView2.Items)
            {
                listView2.Items.Remove(item);
                StreamReader strcount = new StreamReader("train.txt", true);
                string str;
                int n = 0;
                while (true)
                {
                    str = strcount.ReadLine();
                    if (str == "" || str == null)
                        break;
                    n++;
                }
                Database.m = n;
                strcount.Close();
                Database.rase = new Database.TrainData[Database.m];

                StreamReader reader = new StreamReader("train.txt", true);
                for (int i = 0; ; i++)
                {
                    str = reader.ReadLine();
                    if (str == "" || str == null)
                        break;
                    string[] dataacc = str.Split(';');

                    Database.rase[i].number = dataacc[0];
                    Database.rase[i].pn = dataacc[1];
                    Database.rase[i].data = dataacc[2];
                    Database.rase[i].to = dataacc[3];
                    Database.rase[i].tp = dataacc[4];
                    Database.rase[i].s = dataacc[5];
                    Database.rase[i].ob = dataacc[6];
                    Database.rase[i].pb = dataacc[7];
                    ListViewItem item1 = new ListViewItem(dataacc);
                    listView2.Items.Add(item1);

                }
                reader.Close();
            }
            this.Close();
            user l = new user();
            l.Show();
        }
    }
}

