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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            Text = "Введите число от 0 до 100";
        }

        public int userAnswer
        {
            get { return int.Parse(textBox1.Text); }
        }
    }
}
