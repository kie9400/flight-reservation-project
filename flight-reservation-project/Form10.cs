using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prototype1
{
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }
        main main;
        RSV_Search res_search;
        Sd_Manage sd_manage;
        private void Form10_Load(object sender, EventArgs e)
        {
            main = new main();
            main.MdiParent = this;
            main.Show();
        }

        private void Search_Menubar_Click(object sender, EventArgs e)
        {
            if (main == null || main.IsDisposed)  //Form1
            {
                main = new main();
                main.MdiParent = this;
                main.Show();
            }
        }

        private void Reservation_MenuBar_Click(object sender, EventArgs e)
        {
            if (res_search == null || res_search.IsDisposed)  //Form2
            {
                res_search = new RSV_Search();
                res_search.MdiParent = this;
                res_search.Show();
            }
        }

        private void Sd_Manage_MenuBar_Click(object sender, EventArgs e)
        {
            if (sd_manage == null || sd_manage.IsDisposed)  //Form9
            {
                sd_manage = new Sd_Manage();
                sd_manage.MdiParent = this;
                sd_manage.Show();
            }
        }

        private void Exit_MenuBar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
