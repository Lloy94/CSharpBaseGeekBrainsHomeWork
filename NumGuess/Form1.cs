using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumGuess
{
    public partial class Form1 : Form
    {
        private int i;
        Form2 f2;
        static Random rnd = new Random();
        private int rand = rnd.Next(0, 100);
        public Form1()
        {
            InitializeComponent();
            tryCount.Text = $"попытка номер {i}";
            buttonPlay.Text = "Играть";
            Text = "Угадайте число";
            f2 = new Form2();
            f2.Show();
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            if (f2.userAnswer == rand) MessageBox.Show("вы угадали число");
            else if (f2.userAnswer > 100 || f2.userAnswer<0)
            {
                MessageBox.Show("неверное число, введите число от одного до 100");
                i++;
                tryCount.Text = $"попытка номер {i}";
            }
            else if (f2.userAnswer > rand)
            {
                MessageBox.Show("число больше загаданного");
                i++;
                tryCount.Text = $"попытка номер {i}";
            }
            else
            {
                MessageBox.Show("число меньше загаданного ");
                i++;
                tryCount.Text = $"попытка номер {i}";
            }



        }
    }
}
