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
    public partial class create_jidk : Form
    {
        public create_jidk()
        {
            InitializeComponent();
        }
        // добавляем информацию в комбобокс
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
        private void timer2_Tick(object sender, EventArgs e)
        {
            richTextBox1.Text = label2.Text + comboBox1.Text + "  ; " + label3.Text + " " + comboBox2.Text + " + " + comboBox5.Text + " + " + comboBox6.Text + ";" + label4.Text + " " + comboBox4.Text + ";" + label5.Text + " " + comboBox3.Text + "." ;
           
           
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e) { }
        // добавляем информацию в комбобокс
        private void comboBox4_Click(object sender, EventArgs e)
        {
            comboBox6.Items.Add("С пипеткой");
            comboBox6.Items.Add("С колпачком");
            comboBox6.Items.Add("С вытянутым колпачком");
            }
        // если поле не заполнено, то покупка не идет
        private void button1_Click(object sender, EventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {
            chart1.Visible = true;
            chart1.Series[0].Points.AddXY(0,comboBox1.Text);
           
        }

        private void create_jidk_Load(object sender, EventArgs e)
        {
            //Button but = new Button();
            //but.Dock = t;
            //    but.Width = 100;
            //but.Height = 400;
            // //   but.MinimumSize.Width = 100;
            //but.Visible = true;
            //but.Text = "Обновить Инфографику";
            //chart1.Visible = true;
            //chart1.Series[0].Points.AddXY(0, comboBox1.Text);
        }

    }
}
