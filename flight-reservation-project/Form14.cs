using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;

namespace prototype1
{
    public partial class Form14 : Form
    {
        Form16 update = new Form16();

        public Form14()
        {
            InitializeComponent();
        }
private void Form4_Load(object sender, EventArgs e)
        {
            textBox1.Text  = Login_Form.name;
            textBox2.Text = Login_Form.country;
            textBox3.Text = Login_Form.userid;
            textBox4.Text = Login_Form.password;
            textBox5.Text = Login_Form.phone;
            textBox4.UseSystemPasswordChar = true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (Login_Form.userid == "system")
            {
                MessageBox.Show("관리자는 수정할 수 없습니다.");
            }
            else
            {
                update.ShowDialog();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void joinname(string data)
        {
            textBox1.Text = data;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                textBox4.UseSystemPasswordChar = false;
            }
            else
            {
                textBox4.UseSystemPasswordChar = true;
            }
        }
    }
}
