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
    public partial class user : Form
    {
        public user()
        {
            InitializeComponent();
        }

        private void user_Load(object sender, EventArgs e)
        {
            combosort.Items.AddRange(new string[] { "По номеру поезда", "По пункту назначения", "По дате отправления", "По времени отправления", "По времени прибытия", "По цене билета", "По оставшимся билетам", "По проданным билетам" });
            combopoisk.Items.AddRange(new string[] { "По номеру поезда", "По пункту назначения", "По дате отправления", "По времени отправления", "По времени прибытия", "По цене билета", "По оставшимся билетам", "По проданным билетам" });
            this.MinimumSize = new Size(1917, 410);
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
                listView1.Items.Add(item1);

            }
            reader.Close();
        }

        private void сортироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            combosort.ForeColor = System.Drawing.Color.Gray;
            combosort.Text = "Параметр сортировки";
        }

        private void сортироватьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView1.Items)
            {
                listView1.Items.Remove(item);
            }
            var list = new List<Database.TrainData>(Database.rase);
            IOrderedEnumerable<Database.TrainData> result;
            switch (combosort.SelectedIndex)
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
                listView1.Items.Add(it);
            }
        }

        private void toolStripComboBox1_DropDown(object sender, EventArgs e)
        {
            combosort.ForeColor = System.Drawing.Color.Black;
            combosort.Text = "";
        }

        private void toolStripComboBox1_DropDownClosed(object sender, EventArgs e)
        {
            combosort.ForeColor = System.Drawing.Color.Gray;
            combosort.Text = "Параметр сортировки";
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            avtorization o = new avtorization();
            o.Show();
        }

        private void поискToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            combopoisk.ForeColor = System.Drawing.Color.Gray;
            combopoisk.Text = "Параметр поиска";
            textpoisk.ForeColor = System.Drawing.Color.Gray;
            textpoisk.Text = "Вводите здесь";
        }

        private void toolStripComboBox2_DropDown(object sender, EventArgs e)
        {
            combopoisk.ForeColor = System.Drawing.Color.Black;
            combopoisk.Text = "";
        }

        private void toolStripComboBox2_DropDownClosed(object sender, EventArgs e)
        {
            combopoisk.ForeColor = System.Drawing.Color.Gray;
            combopoisk.Text = "Параметр поиска";
        }

        private void toolStripTextBox2_Click(object sender, EventArgs e)
        {
            textpoisk.ForeColor = System.Drawing.Color.Black;
            textpoisk.Text = "";
        }

        private void poisk_Click(object sender, EventArgs e)
        {
            List<Database.TrainData> fitems = new List<Database.TrainData>();
            var list = new List<Database.TrainData>(Database.rase);
            foreach (ListViewItem item in listView1.Items)
            {
                listView1.Items.Remove(item);
            }
            switch (combopoisk.SelectedIndex)
            {
                case 0:
                    fitems = list.FindAll(x => x.number.ToLower().StartsWith(textpoisk.Text));
                    break;
                case 1:
                    fitems = list.FindAll(x => x.pn.ToString().StartsWith(textpoisk.Text));
                    break;
                case 2:
                    fitems = list.FindAll(x => x.data.ToString().StartsWith(textpoisk.Text));
                    break;
                case 3:
                    fitems = list.FindAll(x => x.to.ToLower().StartsWith(textpoisk.Text));
                    break;
                case 4:
                    fitems = list.FindAll(x => x.tp.ToString().StartsWith(textpoisk.Text));
                    break;
                case 5:
                    fitems = list.FindAll(x => x.s.ToString().StartsWith(textpoisk.Text));
                    break;
                case 6:
                    fitems = list.FindAll(x => x.ob.ToString().StartsWith(textpoisk.Text));
                    break;
                case 7:
                    fitems = list.FindAll(x => x.pb.ToString().StartsWith(textpoisk.Text));
                    break;
            }
            if (fitems.Count == 0)
            {
                MessageBox.Show("Ничего не найдено!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                сбросПоискаToolStripMenuItem.PerformClick();
                return;
            }
            foreach (Database.TrainData item in fitems)
            {
                string[] fit = { item.number, item.pn, item.data, item.to, item.tp, item.s, item.ob, item.pb };
                ListViewItem it = new ListViewItem(fit);
                listView1.Items.Add(it);
            }
        }

        private void сбросПоискаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView1.Items)
            {
                listView1.Items.Remove(item);
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
                    listView1.Items.Add(item1);

                }
                reader.Close();
            }
            this.Close();
            user l = new user();
            l.Show();

        }

        private void помощьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Для использования сортировки, сначала выберите пункт, по которому вы хотите сортировать, а потом жмите кнопку <Сортировать>.\nДля использования поиска, сначала выберите пункт, по которому вы хотите совершать поиск, а потом жмите кнопку <Поиск>.", "Помощь", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }



        private void buy_Click(object sender, EventArgs e)
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
            }
            reader.Close();
            if (kolvo.Text == "" || numbertrain.Text == "")
            {
                MessageBox.Show("Введите данные!", "Ошибка", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
            else
            {
                string kolichestvo = kolvo.Text;
                string nomer = numbertrain.Text;
                if (f == false)
                {
                    for (int i = 0; i < Database.rase.Length; i++)
                    {
                        if (nomer == Database.rase[i].number)
                        {
                            if (Convert.ToByte(kolichestvo) <= Convert.ToByte(Database.rase[i].ob))
                            {

                                int ostb = Convert.ToByte(Database.rase[i].ob);
                                int prodb = Convert.ToByte(Database.rase[i].pb);
                                int kol = Convert.ToByte(kolvo.Text);
                                prodb = prodb + kol;
                                ostb = ostb - kol;
                                Database.rase[i].ob = Convert.ToString(ostb);
                                Database.rase[i].pb = Convert.ToString(prodb);


                            }
                            else
                            {
                                MessageBox.Show("Таким количеством на данный рейс жд не обладает!", "Ошибка", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                            }
                        }
                    }
                    StreamWriter wr = new StreamWriter("train.txt", false);
                    for (int i = 0; i < Database.rase.Length; i++)
                    {
                        wr.WriteLine(Database.rase[i].number + ";" + Database.rase[i].pn + ";" + Database.rase[i].data + ";" + Database.rase[i].to + ";" + Database.rase[i].tp + ";" + Database.rase[i].s + ";" + Database.rase[i].ob + ";" + Database.rase[i].pb);

                    }
                    wr.Close();
                }
              

            }
            this.Close();
            user u = new user();
            u.Show();


        }

        private void Find_Click(object sender, EventArgs e)
        {if (t1.Text == "" || t2.Text == "" || town.Text == "")
            {
                MessageBox.Show("Введите данные!", "Ошибка", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
               
            }
        else
            {
                List<Database.TrainData> fitems = new List<Database.TrainData>();
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
                Database.TrainData tr;
                StreamReader reader = new StreamReader("train.txt", true);
                for (int i = 0; ; i++)
                {
                    str = reader.ReadLine();
                    if (str == "" || str == null)
                        break;
                    string[] dataacc = str.Split(';');

                    tr.number = dataacc[0];
                    tr.pn = dataacc[1];
                    tr.data = dataacc[2];
                    tr.to = dataacc[3];
                    tr.tp = dataacc[4];
                    tr.s = dataacc[5];
                    tr.ob = dataacc[6];
                    tr.pb = dataacc[7];
                    fitems.Add(tr);
                }
                reader.Close();
                string[] hh11 = new string[] { };
                string hh1 = t1.Text;
                hh11 = hh1.Split(':');
                int sumTimeGr1 = Convert.ToInt32(hh11[0]) * 60 + Convert.ToInt32(hh11[1]);
                string[] hh22 = new string[] { };
                string hh2 = t2.Text;
                hh22 = hh2.Split(':');
                int sumTimeGr2 = Convert.ToInt32(hh22[0]) * 60 + Convert.ToInt32(hh22[1]);
                bool check = false;
                listView1.Items.Clear();
                listView1.Columns.RemoveAt(1);
                listView1.Columns.RemoveAt(1);
                listView1.Columns.RemoveAt(2);
                listView1.Columns.RemoveAt(2);
                listView1.Columns.RemoveAt(3);
                for (int i = 0; i < fitems.Count; i++)
                {
                    string[] hh33 = new string[] { };
                    hh33 = fitems[i].to.Split(':');
                    int sumTimeTable = Convert.ToInt32(hh33[0]) * 60 + Convert.ToInt32(hh33[1]);

                    if (sumTimeTable >= sumTimeGr1 && sumTimeTable <= sumTimeGr2 && fitems[i].pn == town.Text)
                    {
                        string strr = fitems[i].number + ";" + fitems[i].to + ";" + fitems[i].ob;
                        string[] dataacc1 = strr.Split(';');


                        ListViewItem item1 = new ListViewItem(dataacc1);
                        listView1.Items.Add(item1);
                        check = true;
                    }
                }
                if (check == false)
                {
                    MessageBox.Show("Рейсов по вашему запросу не найдено");
                }
            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            user n = new user();
            n.Show();
        }

        private void kolvo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void numbertrain_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void town_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            e.Handled = !((c >= 'а' && c <= 'я') || (c >= 'А' && c <= 'Я') || c == 'Ё' || c == 'ё' || c == 8 || c == 45);
        }
    }


    } 

