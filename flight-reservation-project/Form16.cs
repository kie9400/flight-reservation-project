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
    public partial class Form16 : Form
    {
        DBClass db = new DBClass();
        public static string password;
        public static string name;
        public static string phone;
        public static string country;
        
        public Form16()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
 
            textBox1.Text = Login_Form.name;
            textBox2.Text = Login_Form.country;
            textBox3.Text = Login_Form.userid;
            textBox4.Text = Login_Form.password;
            textBox5.Text = Login_Form.phone;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text.Length == 0 || textBox2.Text.Length ==0 || textBox4.Text.Length ==0)
                {
                    MessageBox.Show("빈칸을 채워주세요");
                    return;
                }
                else
                {
                    if (MessageBox.Show(" 수정시 재로그인 해야합니다. 정말 하시겠습니까?","수정", MessageBoxButtons.YesNo)== DialogResult.No)
                    {
                        return;
                    }
                    string ConStr = "User Id=hong1; Password=1111; Data Source=(DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521)) (CONNECT_DATA = (SERVER = DEDICATED) (SERVICE_NAME =xe) ) );";
                    OracleConnection conn = new OracleConnection(ConStr);
                    conn.Open();
                    string sql = "update users set name = '" + textBox1.Text + "', password = '"+textBox4.Text+ "', country = '" + textBox2.Text + "', phone = '" + textBox5.Text + "'  where userid='" + textBox3.Text + "'";
                    OracleCommand comm = new OracleCommand(sql, conn);
                    comm.CommandText = sql;
                    comm.ExecuteNonQuery();
                                       
                    Close();
                    MessageBox.Show("수정이 완료되었습니다. 재로그인 해주십시오");
                    conn.Close();
                    Application.Exit();


                    
                }
            }
            catch (DataException DE)
            {
                MessageBox.Show(DE.Message);
            }
            catch (Exception DE)
            {
                MessageBox.Show(DE.Message);
            }
            
        }

    }
}
