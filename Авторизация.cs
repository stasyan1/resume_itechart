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
    public partial class avtorization : Form
    {
     
        
        user f4 = new user();
        choice f5 = new choice();

        public avtorization()
        {
            InitializeComponent();
           
        }

        private void ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void помощьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Пройдите авторизацию.","Помощь", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void avto_Click(object sender, EventArgs e)
        {



            string text;
            string loginuser = logintext.Text;
            string passuser = passwordtext.Text;
            bool check = false;
            StreamReader str = new StreamReader("users.txt");
            while ((text = str.ReadLine()) != null)
            {
                string[] mystring = text.Split(';');

                if (mystring[0] == loginuser && mystring[1] == passuser)
                {
                    check = true;
                    if (mystring[2] == "0")
                    {
                       
                        this.Hide();
                        f4.Show();
                                                                     
                    }

                    else
                    {
                       
                        this.Hide();
                        f5.Show();
                       
                    }
                }


            }
            if (check == false)
            {
                MessageBox.Show("Неправильно введен логин или пароль");
                return;
            }
            str.Close();

        }

        private void back_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void avtorization_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Выйти из программы?", "Выход", MessageBoxButtons.YesNo) ==
                DialogResult.No)
                e.Cancel = true;
            else
                Application.ExitThread();
        }
    }
}
