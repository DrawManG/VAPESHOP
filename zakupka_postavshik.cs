using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VAPESHOP
{
    public partial class zakupka_postavshik : Form
    {
        public zakupka_postavshik()
        {
            InitializeComponent();
        }
        //при загрузке скрывается веб браузер
        private void zakupka_postavshik_Load(object sender, EventArgs e)
        {
            webBrowser1.Visible = false;
        }
        //при нажатии кнопки открывается сайт вардекс
        private void button1_Click(object sender, EventArgs e)
        {
            webBrowser1.Visible = true;
            webBrowser1.Navigate(@"https://vardex.ru/e-juice.html");
        }
        //при нажатии кнопки открывается сайт смокершоп
        private void button2_Click(object sender, EventArgs e)
        {
            webBrowser1.Visible = true;
            webBrowser1.Navigate(@"https://www.smokershop.ru/zhidkosti-standart/");
        }
        //при нажатии кнопки открывается сайт Вейп
        private void button3_Click(object sender, EventArgs e)
        {
            webBrowser1.Visible = true;
            webBrowser1.Navigate(@"https://vape.ru/catalog/zhidkost/segment/byudzhetnyj/");
        }
        //при нажатии кнопки открывается сайт Смокепак
        private void button4_Click(object sender, EventArgs e)
        {
            webBrowser1.Visible = true;
            webBrowser1.Navigate(@"https://smokepack.ru/zhidkosti-dlja-elektronnyh-sigaret/osnova//");
        }

        private void richTextBox1_KeyPress(object sender, KeyPressEventArgs e) { }
        //При закрытии формы у нас открывается меню и скрывается текущее
        private void zakupka_postavshik_FormClosed(object sender, FormClosedEventArgs e)
        {
            MenuForm2121 otkrit = new MenuForm2121();
            otkrit.Show();
            this.Hide();
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(button1,"Переход на сайт производителя");
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(button2, "Переход на сайт производителя");
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(button3, "Переход на сайт производителя");
        }

        private void button4_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(button4, "Переход на сайт производителя");
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }
    }
}
