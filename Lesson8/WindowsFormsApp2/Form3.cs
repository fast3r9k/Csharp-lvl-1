using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WpfApp1;
using System.IO;

//б) Изменить интерфейс программы, увеличив шрифт, поменяв цвет элементов и добавив другие «косметические» улучшения на свое усмотрение.
//в) Добавить в приложение меню «О программе» с информацией о программе(автор, версия, авторские права и др.).
//г) Добавить в приложение сообщение с предупреждением при попытке удалить вопрос.
//д) Добавить пункт меню Save As, в котором можно выбрать имя для сохранения базы данных(элемент SaveFileDialog).

//Матвеев Никита

namespace WindowsFormsApp2
{
    public partial class Form3 : Form
    {

        void ViewData(ListBox list, List<FORECAST> data)
        {
            foreach (var item in data)
            {
                list.Items.Add(item);
            }
        }

        public Form3()
        {
            InitializeComponent();
            DataWeather r = new DataWeather();
            ViewData(listBox1,r.Data);

        }

        private void btnSaveAS_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(saveFileDialog.FileName);
                foreach (var obj in listBox1.Items)
                    sw.WriteLine(obj.ToString());
                sw.Close();
            }
            }

        private void btnAbout_Click(object sender, EventArgs e)
        { 
            MessageBox.Show($"Вас приветствует программа парсинга сайта погоды..\nАвтор: Матвеев Никита" , "О программе");
        }

        private void menuClose_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
            "Вы уверены, что хотите выйти?",
            "Предупреждение",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Information,
            MessageBoxDefaultButton.Button1,
            MessageBoxOptions.DefaultDesktopOnly);
            if (result == DialogResult.Yes )
            {
                Close();
            }
            

        }
    }
    }

