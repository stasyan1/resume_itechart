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
    public partial class admin : Form
    {


        public admin()
        {
            InitializeComponent();
        }




        private void admin_Load(object sender, EventArgs e)
        {
            StreamReader strcount = new StreamReader("users.txt", true);
            string str;
            int n = 0;
            while (true)
            {
                str = strcount.ReadLine();
                if (str == "" || str == null)
                    break;
                n++;
            }
            Database.n = n;
            strcount.Close();
            Database.User = new Database.AccountsData[Database.n];

            StreamReader reader = new StreamReader("users.txt", true);
            for (int i = 0; ; i++)
            {
                str = reader.ReadLine();
                if (str == "" || str == null)
                    break;
                string[] dataacc = str.Split(';');

                Database.User[i].Login = dataacc[0];
                Database.User[i].Password = dataacc[1];
                Database.User[i].Role = dataacc[2];

                if (dataacc[2] == "1")
                    dataacc[2] = "Администратор";
                else
                    dataacc[2] = "Пользователь";
                ListViewItem item1 = new ListViewItem(dataacc);
                listView1.Items.Add(item1);


            }
            reader.Close();

        }

        private void b_Click(object sender, EventArgs e)
        {
            choice f5 = new choice();
            f5.Show();
            this.Hide();


        }

       

        private void addd(string login, string password, string role)
        {
            string[] row = { login, password, role };

            bool chek = true;
            string log = logtxt.Text;
            string pas = passtxt.Text;
            string rol = roletxt.Text;
            StreamReader str = new StreamReader("users.txt");
            string text;
            while ((text = str.ReadLine()) != null)
            {
                string[] mystring = text.Split(';');
                if (mystring[0] == log )
                {


                    chek = false;
                    break;
                }

            }

            str.Close();

            if (chek == false)
            {
                MessageBox.Show("Пользователь с таким логином уже существует");
            }
            else
            { if (log == "" || pas == "" || rol == "")
                {
                    MessageBox.Show("Введите данные!", "Ошибка", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);


                }

                else
                { if (rol == "0" || rol == "1")
                    {

                        StreamWriter sw = new StreamWriter("users.txt", true);
                        sw.WriteLine(login + ";" + password + ";" + rol);

                       
                        sw.Close();
                        ListViewItem item = new ListViewItem(row);
                        listView1.Items.Add(item);
                        this.Close();
                        admin ths = new admin();
                        ths.Show();
                        MessageBox.Show("Пользователь добавлен");
                    }
                    else
                    {
                        MessageBox.Show("Неправильная роль!", "Ошибка", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    }
                }
            }
           
           
        }

        private void add_Click(object sender, EventArgs e)
        {
            addd(logtxt.Text, passtxt.Text, roletxt.Text);

            logtxt.Text = "";
            passtxt.Text = "";
            roletxt.Text = "";
           
        }

        private void update()
        {
            int z = 0;
            for (int i = 0; i < Database.User.Length; i++)
            {
                if (Database.User[i].Role == "1")
                {

                    z++;
                }
            }
            if (z == 1 && roletxt.Text == "0")
            {
                MessageBox.Show("Нельзя переквалифицировать единственного администратора в пользователя!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                bool f = false;
                StreamReader reader = new StreamReader("users.txt");
                while (true)
                {
                    string strin = reader.ReadLine();
                    if (strin == null)
                        break;
                    string[] accdata = new string[2];
                    accdata = strin.Split(":;.".ToCharArray());

                    if (logtxt.Text == accdata[0] && accdata[0] != listView1.FocusedItem.SubItems[0].Text)
                    {
                        f = true;
                        break;
                    }
                }
                reader.Close();
                if (f == true)
                {
                    MessageBox.Show("Пользователь с таким логинои уже существует");
                }
                else {
                    string log = logtxt.Text;
                    string pas = passtxt.Text;
                    string rol = roletxt.Text;
                    StreamReader str = new StreamReader("users.txt");
                    string text;
                    while ((text = str.ReadLine()) != null)
                    {
                        string[] mystring = text.Split(';');
                    }
                    str.Close();
                    if (log == "" || pas == "" || rol == "")
                    {
                        MessageBox.Show("Введите данные!", "Ошибка", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        if (rol == "0" || rol == "1")
                        {

                            //listView1.SelectedItems[0].SubItems[0].Text = logtxt.Text;
                            //listView1.SelectedItems[0].SubItems[1].Text = passtxt.Text;
                            //listView1.SelectedItems[0].SubItems[2].Text = roletxt.Text;
                            for (int i = 0; i < Database.User.Length; i++)
                            {
                                if (Database.User[i].Login == listView1.FocusedItem.SubItems[0].Text)
                                {
                                    Database.User[i].Login = logtxt.Text;
                                    Database.User[i].Password = passtxt.Text;
                                    Database.User[i].Role = roletxt.Text;
                                }
                            }
                            StreamWriter wr = new StreamWriter("users.txt", false);

                            for (int i = 0; i < Database.User.Length; i++)
                            {
                                wr.WriteLine(Database.User[i].Login + ";" + Database.User[i].Password + ";" + Database.User[i].Role);
                            }
                            wr.Close();
                            
                        }
                        else
                        {
                            MessageBox.Show("Неправильная роль!", "Ошибка", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
                logtxt.Text = "";
                passtxt.Text = "";
                roletxt.Text = "";

            
        }
        private void Update_Click(object sender, EventArgs e)
        {
            update();
            this.Close();
            admin ths = new admin();
            ths.Show();
            MessageBox.Show("Пользователь изменен", "", MessageBoxButtons.OK);
        }
        private void delete()
        {
            int z = 0;
            for (int i = 0; i < Database.User.Length; i++)
            {
                if (Database.User[i].Role == "1")
                {
                   
                    z++;
                }
            }
            if (z == 1 && roletxt.Text=="1")
            {
                MessageBox.Show("Нельзя удалить единственного администратора!");

            }

            else
            {
                if (MessageBox.Show("Вы уверены что хотите удалить этого пользователя?", "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    int k = 0;
                    Database.AccountsData[] copy = new Database.AccountsData[Database.User.Length - 1];
                    for (int i = 0; i < Database.User.Length; i++)
                    {
                        if (Database.User[i].Login == logtxt.Text)
                        {
                            k = i;
                            break;
                        }
                        copy[i] = Database.User[i];
                    }
                    for (int i = k, j = k + 1; j < Database.User.Length; i++, j++)
                    {
                        copy[i] = Database.User[j];
                    }
                    Database.n--;
                    Database.User = new Database.AccountsData[Database.n];
                    Database.User = copy;
                    StreamWriter wr = new StreamWriter("users.txt", false);
                    for (int i = 0; i < Database.User.Length; i++)
                    {
                        wr.WriteLine(Database.User[i].Login + ";" + Database.User[i].Password + ";" + Database.User[i].Role);
                    }
                    wr.Close();
                    this.Close();
                    admin ths = new admin();
                    ths.Show();
                    MessageBox.Show("Пользователь удален", "", MessageBoxButtons.OK);
                }

                logtxt.Text = "";
                passtxt.Text = "";
                roletxt.Text = "";


            }
               

        }
        private void Delete_Click(object sender, EventArgs e)
        {
            delete();
           

        }

       
        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            logtxt.Text=listView1.SelectedItems[0].SubItems[0].Text;
            passtxt.Text = listView1.SelectedItems[0].SubItems[1].Text;
            roletxt.Text = listView1.SelectedItems[0].SubItems[2].Text;
            if (listView1.SelectedItems[0].SubItems[2].Text=="Пользователь")
            {
                roletxt.Text = "0";
            }
            if(listView1.SelectedItems[0].SubItems[2].Text == "Администратор")
            {
                roletxt.Text = "1";
            }
        }

       
        private void помощьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("При вводе 1, пользователю будет дана должность администратора.\nПри вводе 0 пользователь остается пользователем.","Помощь", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

      
    }
        }
    

