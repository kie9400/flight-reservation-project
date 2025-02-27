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
    public partial class Login_Form : Form
    {

        public static string userid;
        public static string password;
        public static string name;
        public static string phone;
        public static string country;
        DBClass dbc = new DBClass();
  
        public Login_Form()
        {
            InitializeComponent();
            dbc.DB_Open();
            dbc.DB_ObjCreate();
        }
        private Form12 reg = new Form12();
        private Form13 main = new Form13();
        private void btn_register_Click(object sender, EventArgs e)
        {
            reg.ShowDialog();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {

            if(txt_id.Text == "" || txt_pw.Text == "")
            {
                MessageBox.Show(" 아이디  또는 비밀번호를 입력하세요 ");
                return;
            }
            else
            {
                string ConStr = "User Id=hong1; Password=1111; Data Source=(DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521)) (CONNECT_DATA = (SERVER = DEDICATED) (SERVICE_NAME =xe) ) );";
                OracleConnection conn = new OracleConnection(ConStr);
                conn.Open();
                string sql = "select * from users where userid= "+"'" + txt_id.Text + "'";
                OracleCommand comm = new OracleCommand(sql, conn);
                comm.CommandText = sql; 
                OracleDataReader sr = comm.ExecuteReader();
                if(sr.Read())
                    {
                    if(txt_pw.Text != sr["password"].ToString())
                    {
                        MessageBox.Show(" 비밀번호가 틀렸습니다.");
                        return;                     
                    }
                    else 
                    {
                        userid = sr["userid"].ToString();
                        password = sr["password"].ToString();
                        country = sr["country"].ToString();
                        name = sr["name"].ToString();
                        phone = sr["phone"].ToString();
                        this.Visible = false;
                        main.ShowDialog();
                        main.Owner = this;
                        main.Dispose();
                        Close();
                        conn.Close();
                    }

                }
               
            }
        }

        private void txt_pw_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_login_Click(sender, e);
            }
        }

        private void txt_id_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_login_Click(sender, e);
            }
        }

        private void label_ID_Click(object sender, EventArgs e)
        {

        }
    }
}
