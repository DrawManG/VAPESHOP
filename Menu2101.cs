using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VAPESHOP
{

    public partial class MenuForm2121 : Form
    {
        public MenuForm2121()
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
            panel_zakaz_jidkosti.Visible = false;
            panel_create_jidkosti.Visible = false;
            panel_prodaja.Visible = false;
            panel_prodaja_tovara.Visible = false;
            panel_prodavci.Visible = false;
            panel_sklad.Visible = false;
            panel_prodaja_tovara.Visible = true;
            timer2.Enabled = true;

        }
        //При нажатии на кнопку открывается : Продажа товара
        private void button2_Click(object sender, EventArgs e)
        {
            panel_zakaz_jidkosti.Visible = false;
            panel_create_jidkosti.Visible = false;
            panel_prodaja.Visible = true;
            
            panel_prodavci.Visible = false;
            panel_sklad.Visible = false;
            panel_prodaja_tovara.Visible = false;
            timer2.Enabled = true;
        }
        //При нажатии на кнопку открывается : Учёт на складе
        private void button3_Click(object sender, EventArgs e)
        {
            panel_zakaz_jidkosti.Visible = false;
            panel_create_jidkosti.Visible = false;
            panel_prodaja.Visible = false;
            panel_prodaja_tovara.Visible = false;
            panel_prodavci.Visible = false;
            panel_sklad.Visible = true;
            panel_prodaja_tovara.Visible = false;
            timer2.Enabled = true;
        }
        //по времени открывается панель меню
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = 1;
            panel1.Width += 10;
            if(panel1.Width == 210)
            {
                timer1.Enabled = false;
            }
            if (timer2.Enabled == true)
            {
                timer1.Interval = 10000;
                timer1.Enabled = false;
            }
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
            timer1.Interval = 1;
                timer1.Enabled = true;
            

        }
        //задвигается обратно меню
        private void button5_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            timer1.Interval = 100000;
            timer2.Enabled = true;
        }
        //По времени закрытие
        private void timer2_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            panel1.Width -= 10;
            if(panel1.Width == 0)
            {
                timer1.Enabled = false;
                timer2.Enabled = false;
            }
        }
        //При нажатии на кнопку открывается : Настройки
        private void button11_Click(object sender, EventArgs e)
        {
            this.Width = 1237;
        }
        //При нажатии на кнопку открывается : Создание жидкости
        private void button4_Click(object sender, EventArgs e)
        {
           
            panel_zakaz_jidkosti.Visible = false;
            panel_create_jidkosti.Visible = true;
            panel_prodaja.Visible = false;
            panel_prodaja_tovara.Visible = false;
            panel_prodavci.Visible = false;
            panel_sklad.Visible = false;
            panel_prodaja_tovara.Visible = false;
            timer2.Enabled = true;
        }
        //открытие чата по времени
        private void timer3_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            timer2.Enabled = false;
            timer3.Enabled = true;
            panel3.Left -= 4;
            if(panel3.Left == 404)
            {
                timer3.Enabled = false;
            }
        }
        //при нажатии на кнопку открывается чат
        private void button12_Click(object sender, EventArgs e)
        {
            panel3.Left += 680;
           
            panel3.Left -= 4;
            if (panel3.Left == 404)
            {
                timer3.Enabled = false;
            }
        }

        private void label2_Click(object sender, EventArgs e) { }
        //при нажатии на кнопку закрывается чат
        private void button13_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            timer2.Enabled = false;
            timer3.Enabled = false;
            timer4.Enabled = true;
            if(panel3.Left <= 500)
            {
                timer4.Enabled = false;
                panel3.Left = 680;
            }
            if(panel3.Left <= 0)
            {
                panel3.Left = 680;
            }
        }
        //Чат закрывается по времени
        private void timer4_Tick(object sender, EventArgs e)
        {
            panel3.Left += 5;
        }
        //При нажатии на кнопку открывается : Маркетинг
        private void button7_Click(object sender, EventArgs e)
        {
            
        }
        //При нажатии на кнопку открывается : Заказ жидкости
        private void button8_Click(object sender, EventArgs e)
        {
            
            panel_zakaz_jidkosti.Visible = false;
            panel_create_jidkosti.Visible = false;
            panel_prodaja.Visible = false;
            panel_prodaja_tovara.Visible = false;
            panel_prodavci.Visible = true;
            panel_sklad.Visible = false;
            panel_prodaja_tovara.Visible = false;
            timer2.Enabled = true;
        }

        private void button12_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(button12, "Чат с консультантом");
            toolTip1.SetToolTip(button13, "Скрыть чат");
        }

        private void button10_Click(object sender, EventArgs e)
        {
        
            panel_zakaz_jidkosti.Visible = false;
            panel_create_jidkosti.Visible = false;
            panel_prodaja.Visible = true;
            panel_prodaja_tovara.Visible = false;
            panel_prodavci.Visible = false;
            panel_sklad.Visible = false;
            timer2.Enabled = true;

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button7_Click_1(object sender, EventArgs e)
        {
           
            panel_zakaz_jidkosti.Visible = true;
            panel_create_jidkosti.Visible = false;
            panel_prodaja.Visible = false;
            panel_prodaja_tovara.Visible = false;
            panel_prodavci.Visible = false;
            panel_sklad.Visible = false;
            panel_prodaja_tovara.Visible = false;
            timer2.Enabled = true;
        }

        private void button6_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left&&e.Alt)
            {
                timer1.Interval = 1;
                timer1.Enabled = true;
            }
            
                timer1.Interval = 1;
                timer1.Enabled = true;
            
        }

        private void MenuForm_KeyPress(object sender, KeyPressEventArgs e)
        {
         
        }

        private void button1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void button1_KeyDown(object sender, KeyEventArgs e)
        {
           /* if (e.KeyCode == Keys.F1)
            {
                timer1.Interval = 1;
                timer1.Enabled = true;
            }
            if (e.KeyCode == Keys.F2)
            {
                timer1.Enabled = false;
                timer1.Interval = 100000;
                timer2.Enabled = true;
            }
            if (e.KeyCode == Keys.F3)
            {
                timer4.Enabled = false;
                panel3.Left = 680;
                timer3.Enabled = true;
                panel3.Left -= 4;
                if (panel3.Left == 404)
                {
                    timer3.Enabled = false;
                }
            }
            if (e.KeyCode == Keys.F4)
            {
                timer4.Enabled = true;
                if (panel3.Left <= 500)
                {
                    timer4.Enabled = false;
                    panel3.Left = 680;
                }
                if (panel3.Left <= 0)
                {
                    panel3.Left = 680;
                }
               
            }*/
            }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(button1, "Выбор поставщика");
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(button2, "Заказ товара");
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(button3, "Просмотр товара хранящегося на складе");
        }

        private void button4_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(button4, "Конструктор жидкости");
        }

        private void button8_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(button8, "Информация о заказе жидкости");
        }

        private void button10_MouseHover(object sender, EventArgs e)
        {

        }

        private void button7_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(button7, "Информация о поставщиках");
        }

        private void button5_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(button5, "Cкрыть меню");
        }

        private void button6_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(button6, "Открыть меню");
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void zakupka_postavshik_Load(object sender, EventArgs e)
        {
            webBrowser1.Visible = false;
        }
        //при нажатии кнопки открывается сайт вардекс
        private void button9_Click_1(object sender, EventArgs e)
        {
            webBrowser1.Visible = true;
            webBrowser1.Navigate(@"https://vardex.ru/e-juice.html");
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

        private void webBrowser1_DocumentCompleted_1(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer5_Tick(object sender, EventArgs e)
        {

        }

        private void toolTip4_Popup(object sender, PopupEventArgs e)
        {

        }

        private void richTextBox5_TextChanged(object sender, EventArgs e)
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
            richTextBox1.Text = label2.Text + comboBox1.Text + "  ; " + label3.Text + " " + comboBox2.Text + " + " + comboBox5.Text + " + " + comboBox6.Text + ";" + label4.Text + " " + comboBox4.Text + ";" + label5.Text + " " + comboBox3.Text + ".";

        }

        private void panel_prodavci_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel_zakaz_jidkosti_Paint(object sender, PaintEventArgs e)
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
            if (textBox_log.Text == "ADMIN" && textBox8_pas.Text == "ADMIN")
            {
                button3.Visible = true;
                button1.Visible = true;
                button7.Visible = true;
                button2.Visible = true;
            }



                if (comboBox_theme.Text == "FixedSingle")
                {
                    FormBorderStyle = FormBorderStyle.FixedSingle;
                    this.Width = 600;
                }
                if (comboBox_theme.Text == "Fixed3D")
                {
                    FormBorderStyle = FormBorderStyle.Fixed3D;
                    this.Width = 600;
                }
                if (comboBox_theme.Text == "FixedDialog")
                {
                    FormBorderStyle = FormBorderStyle.FixedDialog;
                    this.Width = 600;
                }
                if (comboBox_theme.Text == "FixedToolWindow")
                {
                    FormBorderStyle = FormBorderStyle.FixedToolWindow;
                    this.Width = 600;
                }
                if (comboBox_theme.Text == "Sizable")
                {
                    FormBorderStyle = FormBorderStyle.Sizable;
                    this.Width = 600;
                   
                }
               
               
                //Обычный
                //Чёрно - Белый
                if (comboBox_color.Text == "Чёрно - Белый")
                {
                    panel1.BackColor = Color.Gray;
                    panel2.BackColor = Color.Gray;
                    panel3.BackColor = Color.Gray;
                    panel5.BackColor = Color.Gray;
                    panel6.BackColor = Color.Gray;
                    panel7.BackColor = Color.Gray;
                    panel_create_jid.BackColor = Color.Gray;
                    panel_create_jidkosti.BackColor = Color.Gray;
                    panel_prodaja.BackColor = Color.Gray;
                    panel_prodaja_tovara.BackColor = Color.Gray;
                    panel_prodavci.BackColor = Color.Gray;
                    panel_sklad.BackColor = Color.Gray;
                    panel_zakaz_jidkosti.BackColor = Color.Gray;
                    
                    this.Width = 600;
                this.Opacity = Convert.ToInt16(100);
            }
           
        }

        private void textBoxop_KeyPress(object sender, KeyPressEventArgs e)
        {
          
            char rus = e.KeyChar;
            if (rus < '0' || rus > '9')
                e.Handled = true;
           
            
        }

        private void textBoxop_TextChanged(object sender, EventArgs e)
        {

        }

        private void button25_Click(object sender, EventArgs e)
        {
            Руководство_пользователя ok = new Руководство_пользователя();
            ok.Show();
            
        }
    }
}
