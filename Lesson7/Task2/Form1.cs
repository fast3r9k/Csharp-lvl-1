using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

    //Используя Windows Forms, разработать игру «Угадай число». 
    //Компьютер загадывает число от 1 до 100, а человек пытается его угадать за минимальное число попыток.
    //Для ввода данных от человека используется элемент TextBox.

    //Матвеев Никита

namespace Task2
{
    public partial class Form1 : Form
    {
        Randomiser rand;
        public Form1()
        {
            InitializeComponent();
            Random r = new Random();
            int max = r.Next(0,100);
            rand = new Randomiser(max);
            this.Text = "Угадай число";
            lblAttempts.Text = "0";
            lblRules.Visible = false;
            lblAttempts.Visible = false;
            btnCheck.Visible = false;
            lblRules.Text = $"Введите число от 0 до {max}";
            MessageBox.Show("Нажмите кнопку 'Играть' в меню, чтобы начать.");

        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            bool check;
            int answer;
            if (int.TryParse(tboxAnswer.Text, out answer))
            {
                MessageBox.Show(rand.Check(out check, answer));
            }
            else MessageBox.Show("Введите числовое значение!");
            lblAttempts.Text = rand.Steps.ToString();
            lblAttempts.Refresh();
        }

        private void menuBegin_Click(object sender, EventArgs e)
        {
            lblAttempts.Visible = true;
            btnCheck.Visible = true;
            lblRules.Visible = true;
        }

        private void menuReset_Click(object sender, EventArgs e)
        {
            rand.Reset();
            lblAttempts.Text = "0";
            lblAttempts.Refresh();
        }
    }
}
