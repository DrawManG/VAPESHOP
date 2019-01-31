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

    public partial class Setting : Form
    {

        public Setting()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Setting s = new Setting();
            MenuForm2121 mf = new MenuForm2121();
            aftorizat af = new aftorizat();

            //     s.FormBorderStyle = FormBorderStyle.Fixed3D;
            //   mf.FormBorderStyle = FormBorderStyle.Fixed3D;
            // af.FormBorderStyle = FormBorderStyle.Fixed3D;
            //  mf.Width = 100;
            this.FormBorderStyle = FormBorderStyle.Fixed3D;
            


        }
        //При закрытии открывается : Меню и закрывается текущее окно
        public void Setting_FormClosed(object sender, FormClosedEventArgs e)
        {
            MenuForm2121 n = new VAPESHOP.MenuForm2121();
            n.Show();
            this.Hide();
            this.FormBorderStyle = n.FormBorderStyle;
         //   <string> FormBorderStyle.Fixed3D = Properties.Settings.Default.project_style;
        }

        private void button1_MouseUp(object sender, MouseEventArgs e) { }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
