using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Win32;

namespace VAPESHOP
{
    public partial class zakaz_jidkosti : Form
    {
        public zakaz_jidkosti()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
                if (dataGridView1[1, i].FormattedValue.ToString().
                Contains(textBox1.Text.Trim()))
                {
                    dataGridView1.CurrentCell = dataGridView1[0, i];
                    return;
                }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void zakaz_jidkosti_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "vapeShopDataSet.Zaiavlenie_o_pokupke". При необходимости она может быть перемещена или удалена.
      //      this.zaiavlenie_o_pokupkeTableAdapter.Fill(this.vapeShopDataSet.Zaiavlenie_o_pokupke);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "vapeShopDataSet.KLients". При необходимости она может быть перемещена или удалена.
       //     this.kLientsTableAdapter.Fill(this.vapeShopDataSet.KLients);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "vapeShopDataSet.VaрeShop". При необходимости она может быть перемещена или удалена.
         //   this.vaрeShopTableAdapter.Fill(this.vapeShopDataSet.VaрeShop);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "vapeShopDataSet.Zakaz_probi". При необходимости она может быть перемещена или удалена.
         //   this.zakaz_probiTableAdapter.Fill(this.vapeShopDataSet.Zakaz_probi);

        }
        //При закрытии открывается : Меню и скрывается текущее меню
        private void zakaz_jidkosti_FormClosed(object sender, FormClosedEventArgs e)
        {
            MenuForm2121 menu = new MenuForm2121();
            menu.Show();
            this.Hide();
        }

       

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_3(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
