using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

    //а) Добавить в программу «Удвоитель» подсчет количества отданных команд.
    //б) Добавить меню и команду «Играть». При нажатии появляется сообщение, какое число должен получить игрок. Игрок должен постараться получить это число за минимальное количество ходов.
    //в) *Добавить кнопку «Отменить», которая отменяет последние ходы.
    //Матвеев Никита

namespace Task1
{
    public partial class Form1 : Form
    {
        Doubler doubler;
        public Form1()
        {
            InitializeComponent();
            doubler = new Doubler();
            btnCommand1.Text = "+1";
            btnCommand2.Text = "x2";
            btnReset.Text = "Reset";
            this.Text = "Doubler";
            lblCounter.Text = "0";
            lblGoal.Visible = false;
            lblGoalText.Visible = false;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
        public void Update()
        {
            lblCounter.Text = doubler.Value.ToString();
            lblActionText.Text = doubler.Steps.ToString();
            if (lblGoal.Visible)
                if (doubler.Check())
                {
                    MessageBox.Show($"Поздравляем, вы достигли заданного числа за {doubler.Steps} ходов");
                    lblGoal.Visible = false;
                    lblGoalText.Visible = false;
                    doubler.Reset();
                }
        }

        private void btnCommand1_Click(object sender, EventArgs e)
        {
            doubler.Increment();
            Update();
        }

        private void btnCommand2_Click(object sender, EventArgs e)
        {
            doubler.Double();
            Update();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            doubler.Reset();
            Update();
        }

        private void playToolStripMenuItem_Click(object sender, EventArgs e)
        {
            doubler.GetGoal();
            MessageBox.Show($"Необходимо получить число {doubler.Goal}");
            lblGoal.Visible = true;
            lblGoalText.Visible = true;
            lblGoalText.Text = doubler.Goal.ToString();
            doubler.Reset();
            Update();
        }

        private void menuStop_Click(object sender, EventArgs e)
        {
            lblGoal.Visible = false;
            lblGoalText.Visible = false;
            doubler.Reset();
            Update();
        }

        private void menuCancel_Click(object sender, EventArgs e)
        {
            doubler.LastStep();

            Update();
        }
    }
}
