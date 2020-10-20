using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursovoy_proekt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void menu_Click(object sender, EventArgs e)
        {                             
            avtorization f2 = new avtorization();
            f2.Show();
            this.Hide();
 
        }

        private void close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Выйти из программы?", "Выход", MessageBoxButtons.YesNo) ==
                DialogResult.No)
                e.Cancel = true;
            else
                Application.ExitThread();

        }
    }
}
