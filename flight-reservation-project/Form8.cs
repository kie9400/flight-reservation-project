using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace prototype1
{
    public partial class Seat_Select : Form
    {
        string seat_num;
        string rsv_num;
        DataRow currRow;
        DBClass dbc = new DBClass();

        public Seat_Select()
        {
            InitializeComponent();
            dbc.DB_ObjCreate(); 
            dbc.DB_Open();
            dbc.DB_Access();
        }

        private void continue_Btn_Click(object sender, EventArgs e)
        {
            
            
            String flightsql = "Select * From reservation";
            sql_execute(flightsql, dbc.DS);

            //reservation_num -> st_num information update
            flightsql = "Update reservation Set st_num = '" + seat_num + "' Where rv_num = '" + rsv_num + "'"; 
            dbc.DCom.CommandText = flightsql;
            dbc.DCom.ExecuteNonQuery();
            MessageBox.Show("예약 넘버 테이블에 좌석번호 데이터 추가 성공!"); //테스트용
            //결제 구현은 아직 미구현

            Payment payment = new Payment();
            payment.ShowDialog();
        }

        public void sql_execute(String sqlstr, DataSet dsstr)
        {
            dbc.DCom.CommandText = sqlstr;
            dbc.DA.SelectCommand = dbc.DCom;
            dbc.DA.Fill(dsstr, "reservation");

            int i = dsstr.Tables["reservation"].Rows.Count;
            DataRow currRow = dsstr.Tables["reservation"].Rows[i-1];
            rsv_num = (string)currRow[0];
        }
        private void button1_Click(object sender, EventArgs e)
        {
            seat_num = "1";
            textBox1.Text = seat_num;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            seat_num = "2";
            textBox1.Text = seat_num;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            seat_num = "3";
            textBox1.Text = seat_num;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            seat_num = "4";
            textBox1.Text = seat_num;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            seat_num = "5";
            textBox1.Text = seat_num;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            seat_num = "6";
            textBox1.Text = seat_num;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            seat_num = "7";
            textBox1.Text = seat_num;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            seat_num = "8";
            textBox1.Text = seat_num;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            seat_num = "9";
            textBox1.Text = seat_num;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            seat_num = "10";
            textBox1.Text = seat_num;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            seat_num = "11";
            textBox1.Text = seat_num;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            seat_num = "12";
            textBox1.Text = seat_num;
        }

        private void button24_Click(object sender, EventArgs e)
        {
            seat_num = "13";
            textBox1.Text = seat_num;
        }

        private void button23_Click(object sender, EventArgs e)
        {
            seat_num = "14";
            textBox1.Text = seat_num;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            seat_num = "15";
            textBox1.Text = seat_num;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            seat_num = "16";
            textBox1.Text = seat_num;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            seat_num = "17";
            textBox1.Text = seat_num;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            seat_num = "18";
            textBox1.Text = seat_num;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            seat_num = "19";
            textBox1.Text = seat_num;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            seat_num = "20";
            textBox1.Text = seat_num;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            seat_num = "21";
            textBox1.Text = seat_num;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            seat_num = "22";
            textBox1.Text = seat_num;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            seat_num = "23";
            textBox1.Text = seat_num;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            seat_num = "24";
            textBox1.Text = seat_num;
        }

        private void button48_Click(object sender, EventArgs e)
        {
            seat_num = "25";
            textBox1.Text = seat_num;
        }

        private void button47_Click(object sender, EventArgs e)
        {
            seat_num = "26";
            textBox1.Text = seat_num;
        }

        private void button46_Click(object sender, EventArgs e)
        {
            seat_num = "27";
            textBox1.Text = seat_num;
        }

        private void button45_Click(object sender, EventArgs e)
        {
            seat_num = "28";
            textBox1.Text = seat_num;
        }

        private void button44_Click(object sender, EventArgs e)
        {
            seat_num = "29";
            textBox1.Text = seat_num;
        }

        private void button43_Click(object sender, EventArgs e)
        {
            seat_num = "30";
            textBox1.Text = seat_num;
        }

        private void button42_Click(object sender, EventArgs e)
        {
            seat_num = "31";
            textBox1.Text = seat_num;
        }

        private void button41_Click(object sender, EventArgs e)
        {
            seat_num = "32";
            textBox1.Text = seat_num;
        }

        private void button40_Click(object sender, EventArgs e)
        {
            seat_num = "33";
            textBox1.Text = seat_num;
        }

        private void button39_Click(object sender, EventArgs e)
        {
            seat_num = "34";
            textBox1.Text = seat_num;
        }

        private void button38_Click(object sender, EventArgs e)
        {
            seat_num = "35";
            textBox1.Text = seat_num;
        }

        private void button37_Click(object sender, EventArgs e)
        {
            seat_num = "36";
            textBox1.Text = seat_num;
        }

        private void button36_Click(object sender, EventArgs e)
        {
            seat_num = "37";
            textBox1.Text = seat_num;
        }

        private void button35_Click(object sender, EventArgs e)
        {
            seat_num = "38";
            textBox1.Text = seat_num;
        }

        private void button34_Click(object sender, EventArgs e)
        {
            seat_num = "39";
            textBox1.Text = seat_num;
        }

        private void button33_Click(object sender, EventArgs e)
        {
            seat_num = "40";
            textBox1.Text = seat_num;
        }

        private void button32_Click(object sender, EventArgs e)
        {
            seat_num = "41";
            textBox1.Text = seat_num;
        }

        private void button31_Click(object sender, EventArgs e)
        {
            seat_num = "42";
            textBox1.Text = seat_num;
        }

        private void button30_Click(object sender, EventArgs e)
        {
            seat_num = "43";
            textBox1.Text = seat_num;
        }

        private void button29_Click(object sender, EventArgs e)
        {
            seat_num = "44";
            textBox1.Text = seat_num;
        }

        private void button28_Click(object sender, EventArgs e)
        {
            seat_num = "45";
            textBox1.Text = seat_num;
        }

        private void button27_Click(object sender, EventArgs e)
        {
            seat_num = "46";
            textBox1.Text = seat_num;
        }

        private void button26_Click(object sender, EventArgs e)
        {
            seat_num = "47";
            textBox1.Text = seat_num;
        }

        private void button25_Click(object sender, EventArgs e)
        {
            seat_num = "48";
            textBox1.Text = seat_num;
        }

        private void button60_Click(object sender, EventArgs e)
        {
            seat_num = "49";
            textBox1.Text = seat_num;
        }

        private void button59_Click(object sender, EventArgs e)
        {
            seat_num = "50";
            textBox1.Text = seat_num;
        }

        private void button58_Click(object sender, EventArgs e)
        {
            seat_num = "51";
            textBox1.Text = seat_num;
        }

        private void button57_Click(object sender, EventArgs e)
        {
            seat_num = "52";
            textBox1.Text = seat_num;
        }

        private void button56_Click(object sender, EventArgs e)
        {
            seat_num = "53";
            textBox1.Text = seat_num;
        }

        private void button55_Click(object sender, EventArgs e)
        {
            seat_num = "54";
            textBox1.Text = seat_num;
        }

        private void button54_Click(object sender, EventArgs e)
        {
            seat_num = "55";
            textBox1.Text = seat_num;
        }

        private void button53_Click(object sender, EventArgs e)
        {
            seat_num = "56";
            textBox1.Text = seat_num;
        }

        private void button52_Click(object sender, EventArgs e)
        {
            seat_num = "57";
            textBox1.Text = seat_num;
        }

        private void button51_Click(object sender, EventArgs e)
        {
            seat_num = "58";
            textBox1.Text = seat_num;
        }

        private void button50_Click(object sender, EventArgs e)
        {
            seat_num = "59";
            textBox1.Text = seat_num;
        }

        private void button49_Click(object sender, EventArgs e)
        {
            seat_num = "60";
            textBox1.Text = seat_num;
        }
    }
}
