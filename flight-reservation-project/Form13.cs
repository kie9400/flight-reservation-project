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
    public partial class Form13 : Form
    {
        DBClass db = new DBClass();
        private Form14 join = new Form14();
        private main main2 = new main();
        public Form13()
        {
            InitializeComponent();
            db.DB_Open();
            db.DB_ObjCreate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            join.ShowDialog();
        }


        private void Form3_Load(object sender, EventArgs e)
        {
            label3.Text = "환영합니다 " + Login_Form.name + " 고객님 ";         
        }

        private void button4_Click(object sender, EventArgs e)            
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            main2.ShowDialog();
            main2.Owner = this;
            main2.Dispose();
            Close();
        }
    }
}
