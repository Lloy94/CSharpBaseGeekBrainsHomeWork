using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_Udvoitel
{
    public partial class Form1 : Form
    {
        private int i;
        private Stack<int> Stack = new();
        public Form1()
        {
            InitializeComponent();
            btnCommand1.Text = "+1";
            btnCommand2.Text = "x2";
            btnReset.Text = "Сброс";
            lblNumber.Text = "0";
            Text = "Удвоитель";
            labelCount.Text = $"Комманд отдано: {i}";

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Stack.Push(1);
            lblNumber.Text = "1";
            i++;
            labelCount.Text = $"Комманд отдано: {i}";
        }

        private void btnCommand2_Click(object sender, EventArgs e)
        {
            Stack.Push(int.Parse(lblNumber.Text) * 2);
            lblNumber.Text = (int.Parse(lblNumber.Text) * 2).ToString();
            i++;
            labelCount.Text = $"Комманд отдано: {i}";
        }

        private void btnCommand1_Click(object sender, EventArgs e)
        {
            Stack.Push(int.Parse(lblNumber.Text) + 1);
            lblNumber.Text = (int.Parse(lblNumber.Text) + 1).ToString();          
            i++;
            labelCount.Text = $"Комманд отдано: {i}";
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {           
            if (lblNumber.Text == "25") MessageBox.Show(" Вы  получили нужное число ");
            else MessageBox.Show("Вы должны получить число - 25");
            i++;
            labelCount.Text = $"Комманд отдано: {i}";

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            try
            { lblNumber.Text = Stack.Pop().ToString(); }
            catch (Exception) 
            { MessageBox.Show(" Нет ходов для отмены"); }
        }
    }
}
