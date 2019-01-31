using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;



namespace VAPESHOP
{
    public partial class prodaja_tovara : Form
    {
        public prodaja_tovara()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e) { }

        private void textBox3_TextChanged(object sender, EventArgs e) { }
        // Блокировка ввода кроме русских букв
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char rus = e.KeyChar;
            if (rus < 'А' || rus > 'я')
                e.Handled = true;
        }
        // ввод только цифр и до 11 чисел
        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }
        //При нажатии на кнопку открывается : Меню и отправляется запрос
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Отправлен запрос, вам позвонят в течении 30 мин");
            MenuForm2121 otkrit = new MenuForm2121();
            otkrit.Show();
            this.Hide();

        }
        //При нажатии на кнопку открывается :меню форм и закрывается текущее окно
        private void prodaja_tovara_FormClosed(object sender, FormClosedEventArgs e)
        {
            MenuForm2121 otkrit = new MenuForm2121();
            otkrit.Show();
            this.Hide();
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
       //блокировка букв кроме русских больших и маленьких букв
        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            char rus = e.KeyChar;
            if (rus < 'А' || rus > 'я')
                e.Handled = true;
        }
        //блокировка букв кроме русских больших и маленьких букв
        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            char rus = e.KeyChar;
            if (rus < 'А' || rus > 'я')
                e.Handled = true;
        }


        //Подсказка к фамилии
        private void textBox1_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(textBox1,"Введите Фамилию");
        }
        //Подсказка к имени
        private void textBox6_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(textBox6, "Введите Имя");
        }
        //Подсказка к отчество
        private void textBox5_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(textBox5, "Введите Отчество");
        }
        //Подсказка к адресу проживания
        private void textBox2_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(textBox2, "Введите адрес проживания");
        }
        //Подсказка к номеру телефона
        private void maskedTextBox1_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(maskedTextBox1, "Введите свой номер телефона");
        }
        //подсказка чека на печать
        private void button2_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(button2,"Вывести чек на печать");
        }
        // подсказка покупка товара
        private void button1_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(button1, "Покупка товара");
        }
    }
        

    }
  

   

