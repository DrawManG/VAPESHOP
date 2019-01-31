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
    public partial class Uchet_na_cklade : Form
    {
        public Uchet_na_cklade()
        {
            InitializeComponent();
        }
        //При закрытии открывается : Меню и скрывается текущее меню
        private void Uchet_na_cklade_FormClosed(object sender, FormClosedEventArgs e)
        {
            MenuForm2121 men = new MenuForm2121();
            men.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Uchet_na_cklade_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "vapeShopDataSet.Tovar". При необходимости она может быть перемещена или удалена.
            this.tovarTableAdapter.Fill(this.vapeShopDataSet.Tovar);

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
                if (dataGridView1[1, i].FormattedValue.ToString().
                Contains(textBox1.Text.Trim()))
                {
                    dataGridView1.CurrentCell = dataGridView1[0, i];
                    return;
                }
        }
    }
}

