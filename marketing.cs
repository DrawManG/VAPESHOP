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
    public partial class marketing : Form
    {
        public marketing()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
      //      int chet_all = Int32.Parse.Text;
            
        }
        //при закрытии формы, открывается форма Меню
        private void marketing_FormClosed(object sender, FormClosedEventArgs e)
        {
            MenuForm2121 ne = new MenuForm2121();
            ne.Show();
            this.Hide();
        }
    }
}
