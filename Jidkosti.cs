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
    public partial class Jidkosti : Form
    {
        public Jidkosti()
        {
            InitializeComponent();
        }

        private void Jidkosti_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "vapeShopDataSet.Pokupka_sostavlaushei_Jidkosti". При необходимости она может быть перемещена или удалена.
            this.pokupka_sostavlaushei_JidkostiTableAdapter.Fill(this.vapeShopDataSet.Pokupka_sostavlaushei_Jidkosti);

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
    }
}
