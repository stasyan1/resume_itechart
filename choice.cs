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
    public partial class choice : Form
    {
       
        public choice()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            admin f3 = new admin();
            this.Hide();
            f3.Show();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tickets f6 = new tickets();
            this.Hide();
            f6.Show();
        }

        private void back_Click(object sender, EventArgs e)
        {
            avtorization f2 = new avtorization();
            this.Hide();
            f2.Show();
        }

        private void choice_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Выйти из программы?", "Выход", MessageBoxButtons.YesNo) ==
                DialogResult.No)
                e.Cancel = true;
            else
                Application.ExitThread();
        }
    }
}
