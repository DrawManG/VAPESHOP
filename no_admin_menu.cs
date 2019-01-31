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
    public partial class no_admin_menu : Form
    {
        public no_admin_menu()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }

        //публичное объявление переменной 
        Setting ne = new Setting();
        //при закрытии формы, убивается процесс в системе
        private void Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
        }
        //При нажатии на кнопку открывается : Закупка поставщика

        private void button1_Click(object sender, EventArgs e)
        {

        }
        //При нажатии на кнопку открывается : Продажа товара
        private void button2_Click(object sender, EventArgs e)
        {

        }
        //При нажатии на кнопку открывается : Учёт на складе
        private void button3_Click(object sender, EventArgs e)
        {

        }
        //по времени открывается панель меню
        private void timer1_Tick(object sender, EventArgs e)
        {

        }
        //при загрузки формы, панель с миню в ширину = 0 
        public void Menu_Load(object sender, EventArgs e)
        {

            this.Width = 500;
            panel_zakaz_jidkosti.Visible = false;
            panel_create_jidkosti.Visible = false;
            panel_prodaja.Visible = false;
            panel_prodaja_tovara.Visible = false;
            panel_prodavci.Visible = false;
            panel_sklad.Visible = false;
            panel_prodaja_tovara.Visible = false;

            panel1.Width = 300;//0
            panel1.Height = 5000;
            //  this.FormBorderStyle = ne.FormBorderStyle;
            System.Drawing.Drawing2D.GraphicsPath button_path = new System.Drawing.Drawing2D.GraphicsPath();
            button_path.AddEllipse(0, 0, this.button1.Width, this.button1.Height);
            Region button_region = new Region(button_path);
            this.button1.Region = button_region;

            System.Drawing.Drawing2D.GraphicsPath button_path1 = new System.Drawing.Drawing2D.GraphicsPath();
            button_path1.AddEllipse(0, 0, this.button2.Width, this.button2.Height);
            Region button_region1 = new Region(button_path1);
            this.button2.Region = button_region1;

            System.Drawing.Drawing2D.GraphicsPath button_path2 = new System.Drawing.Drawing2D.GraphicsPath();
            button_path2.AddEllipse(0, 0, this.button3.Width, this.button3.Height);
            Region button_region2 = new Region(button_path2);
            this.button3.Region = button_region2;

            System.Drawing.Drawing2D.GraphicsPath button_path3 = new System.Drawing.Drawing2D.GraphicsPath();
            button_path3.AddEllipse(0, 0, this.button4.Width, this.button4.Height);
            Region button_region3 = new Region(button_path3);
            this.button4.Region = button_region3;

            System.Drawing.Drawing2D.GraphicsPath button_path4 = new System.Drawing.Drawing2D.GraphicsPath();
            button_path4.AddEllipse(0, 0, this.button7.Width, this.button7.Height);
            Region button_region4 = new Region(button_path4);
            this.button7.Region = button_region4;

            System.Drawing.Drawing2D.GraphicsPath button_path5 = new System.Drawing.Drawing2D.GraphicsPath();
            button_path5.AddEllipse(0, 0, this.button8.Width, this.button8.Height);
            Region button_region5 = new Region(button_path5);
            this.button8.Region = button_region5;

            System.Drawing.Drawing2D.GraphicsPath button_path6 = new System.Drawing.Drawing2D.GraphicsPath();
            button_path6.AddEllipse(0, 0, this.button10.Width, this.button10.Height);
            Region button_region6 = new Region(button_path6);
            this.button10.Region = button_region6;
        }
        // при нажатии на кнопку выдвегается меню
        private void button6_Click(object sender, EventArgs e)
        {

        }
        //задвигается обратно меню
        private void button5_Click(object sender, EventArgs e)
        {

        }
        //По времени закрытие
        private void timer2_Tick(object sender, EventArgs e)
        {

        }
        //При нажатии на кнопку открывается : Настройки
        private void button11_Click(object sender, EventArgs e)
        {
            this.Width = 1237;
        }
        //При нажатии на кнопку открывается : Создание жидкости
        private void button4_Click(object sender, EventArgs e)
        {

        }
        //открытие чата по времени
        private void timer3_Tick(object sender, EventArgs e)
        {

        }
        //при нажатии на кнопку открывается чат
        private void button12_Click(object sender, EventArgs e)
        {

        }
        //при нажатии на кнопку закрывается чат
        private void button13_Click(object sender, EventArgs e)
        {

        }
        //Чат закрывается по времени
        private void timer4_Tick(object sender, EventArgs e)
        {

        }
        //При нажатии на кнопку открывается : Маркетинг
        private void button7_Click(object sender, EventArgs e)
        {

        }
        //При нажатии на кнопку открывается : Заказ жидкости
        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button12_MouseHover(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click_1(object sender, EventArgs e)
        {

        }

        private void button6_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void MenuForm_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void button1_MouseHover(object sender, EventArgs e)
        {

        }

        private void button2_MouseHover(object sender, EventArgs e)
        {

        }

        private void button3_MouseHover(object sender, EventArgs e)
        {

        }

        private void button4_MouseHover(object sender, EventArgs e)
        {

        }

        private void button8_MouseHover(object sender, EventArgs e)
        {

        }

        private void button7_MouseHover(object sender, EventArgs e)
        {

        }

        private void button5_MouseHover(object sender, EventArgs e)
        {

        }

        private void button6_MouseHover(object sender, EventArgs e)
        {

        }
        private void zakupka_postavshik_Load(object sender, EventArgs e)
        {
            webBrowser1.Visible = false;
        }
        //при нажатии кнопки открывается сайт вардекс
        private void button9_Click_1(object sender, EventArgs e)
        {

        }
        //при нажатии кнопки открывается сайт смокершоп
        private void button16_Click(object sender, EventArgs e)
        {
            webBrowser1.Visible = true;
            webBrowser1.Navigate(@"https://www.smokershop.ru/zhidkosti-standart/");
        }
        //при нажатии кнопки открывается сайт Вейп
        private void button15_Click(object sender, EventArgs e)
        {
            webBrowser1.Visible = true;
            webBrowser1.Navigate(@"https://vape.ru/catalog/zhidkost/segment/byudzhetnyj/");
        }
        //при нажатии кнопки открывается сайт Смокепак
        private void button14_Click(object sender, EventArgs e)
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

        private void button9_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(button1, "Переход на сайт производителя");
        }

        private void button16_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(button2, "Переход на сайт производителя");
        }

        private void button15_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(button3, "Переход на сайт производителя");
        }

        private void button14_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(button4, "Переход на сайт производителя");
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }
        private void comboBox1_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add("0.0");
            comboBox1.Items.Add("0.3");
            comboBox1.Items.Add("0.6");
            comboBox1.Items.Add("0.12");

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e) { }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e) { }
        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e) { }
        private void richTextBox1_TextChanged(object sender, EventArgs e) { }

        // добавляем информацию в комбобокс
        private void comboBox2_Click(object sender, EventArgs e)
        {
            comboBox2.Items.Add("Шоколад");
            comboBox2.Items.Add("Жевательная резина");
            comboBox2.Items.Add("Яблоко");
            comboBox2.Items.Add("Мороженое");
            comboBox2.Items.Add("Молочный когтель");
            comboBox2.Items.Add("Банан");
            comboBox2.Items.Add("Лесный ягоды");
            comboBox2.Items.Add("Абсент");

        }
        // добавляем информацию в комбобокс
        private void comboBox5_Click(object sender, EventArgs e)
        {
            comboBox5.Items.Add("Шоколад");
            comboBox5.Items.Add("Жевательная резина");
            comboBox5.Items.Add("Яблоко");
            comboBox5.Items.Add("Мороженое");
            comboBox5.Items.Add("Молочный когтель");
            comboBox5.Items.Add("Банан");
            comboBox5.Items.Add("Лесный ягоды");
            comboBox5.Items.Add("Абсент");

        }
        // добавляем информацию в комбобокс
        private void comboBox6_Click(object sender, EventArgs e)
        {
            comboBox6.Items.Add("Шоколад");
            comboBox6.Items.Add("Жевательная резина");
            comboBox6.Items.Add("Яблоко");
            comboBox6.Items.Add("Мороженое");
            comboBox6.Items.Add("Молочный когтель");
            comboBox6.Items.Add("Банан");
            comboBox6.Items.Add("Лесный ягоды");
            comboBox6.Items.Add("Абсент");

        }
        //Информация в рич едит об выбраном товаре


        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e) { }
        // добавляем информацию в комбобокс
        private void comboBox4_Click(object sender, EventArgs e)
        {
            comboBox6.Items.Add("С пипеткой");
            comboBox6.Items.Add("С колпачком");
            comboBox6.Items.Add("С вытянутым колпачком");
        }
        // если поле не заполнено, то покупка не идет
        private void button21_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == null || comboBox2.Text == null || comboBox3.Text == null || comboBox4.Text == null || comboBox5.Text == null)
            {
                MessageBox.Show("Вы не заполнили поля!");
            }

            else
            {
                MessageBox.Show("Ваш заказ отправлен в корзину");
                MenuForm2121 open = new MenuForm2121();
                open.Show();
                this.Hide();
            }

        }
        // при закрытии формы открывалось формы
        private void create_jidk_FormClosed(object sender, FormClosedEventArgs e)
        {
            MenuForm2121 d = new MenuForm2121();
            d.Show();
            this.Hide();
        }

        private void comboBox1_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(comboBox1, "Выберите нужное содержание никотина");
        }

        private void comboBox4_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(comboBox4, "Выберите вид крышки (Пипетка, носик и др.)");
        }

        private void comboBox3_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(comboBox3, "Выберите необходимый объем жидкости");
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void button20_Click(object sender, EventArgs e)
        {
            chart1.Visible = true;
            chart1.Series[0].Points.AddXY(0, comboBox1.Text);

        }

        private void timer6_Tick(object sender, EventArgs e)
        {

        }

        private void button24_Click(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.Fixed3D;
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button24_Click_1(object sender, EventArgs e)
        {

        }

        private void textBoxop_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
