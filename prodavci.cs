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
    public partial class prodavci : Form
    {
        public prodavci()
        {
            InitializeComponent();
        }

        private void prodavci_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "vapeShopDataSet.Prodavci". При необходимости она может быть перемещена или удалена.
            //this.prodavciTableAdapter.Fill(this.vapeShopDataSet.Prodavci);

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
