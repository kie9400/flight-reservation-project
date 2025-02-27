using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace prototype1
{
    //테스트용이라고 작성되어있는 행은 최종적으로 주석처리 할 것
    public partial class main : Form
    {
        string flightsql;
        string departure;
        string arrival;
        string dept_date;
        string arv_date;
        string seat_num;
        public static string fi_num;
        string ac_num;
        DataRow currRow;


        DBClass dbc = new DBClass();  //*****DBClass 객체 생성
        public main()
        {
            InitializeComponent();
            dbc.DB_ObjCreate(); //*****
            dbc.DB_Open();//*****
            dbc.DB_Access();//***
        }

        public void sql_execute(String sqlstr, DataSet dsstr)    //사용자 함수 정의
        {
            dbc.DCom.CommandText = sqlstr;
            dbc.DA.SelectCommand = dbc.DCom;
            dbc.DA.Fill(dsstr, "flight");
            dsstr.Tables["flight"].Clear();
            dbc.DA.Fill(dsstr, "flight");
            dataGridView1.DataSource = dsstr.Tables["flight"].DefaultView;
            flight_header();     //함수 호출 

        }
        public void flight_header()
        {
            dataGridView1.Columns[0].HeaderText = "비행편 번호";
            dataGridView1.Columns[1].HeaderText = "항공사명";
            dataGridView1.Columns[2].HeaderText = "출발공항";
            dataGridView1.Columns[3].HeaderText = "도착공항";
            dataGridView1.Columns[4].HeaderText = "출발날짜";
            dataGridView1.Columns[5].HeaderText = "도착날짜";
            dataGridView1.Columns[6].HeaderText = "운임";

            dataGridView1.Columns[0].Width = 100;
            dataGridView1.Columns[1].Width = 100;
            dataGridView1.Columns[2].Width = 60;
            dataGridView1.Columns[3].Width = 60;
            dataGridView1.Columns[4].Width = 100;
            dataGridView1.Columns[5].Width = 100;
            dataGridView1.Columns[6].Width = 100;
        }

        public void list_search()  // 콤보박스와 데이트피커에서 선택된 내용을 바탕으로 조회
        {
            //날짜 부분 수정하기
            flightsql = "Select * From flight_inform Where dept_ap = '" + departure + "' and arv_ap = '" + arrival + "'";
            sql_execute(flightsql, dbc.DS);
        }
        private void main_Load(object sender, EventArgs e)
        {
            list_search();  //*
            this.Left = 0;
            this.Top = 0;
        }

        public void sql_execute2(String sqlstr, DataSet dsstr)    //사용자 함수 정의
        {

            dbc.DCom.CommandText = sqlstr;
            dbc.DA.SelectCommand = dbc.DCom;
            dbc.DA.Fill(dsstr, "flight_select");

            //테스트용 데이터뷰에 띄우기
            dataGridView2.DataSource = dsstr.Tables["flight_select"].DefaultView;
            flight_header2();

            currRow = dbc.DS.Tables["flight_select"].Rows[0];
            ac_num = currRow[1].ToString();
            test2.Text = ac_num; //항공기 번호 조회            
        }

        public void flight_header2()
        {
            dataGridView2.Columns[0].HeaderText = "비행편 번호";
            dataGridView2.Columns[1].HeaderText = "항공기 번호";

            dataGridView1.Columns[0].Width = 30;
            dataGridView1.Columns[1].Width = 30;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            departure = comboBox1.SelectedItem.ToString();
            if (departure == "ICN")
                departure = "10";
            if (departure == "GMP")
                departure = "11";
            if (departure == "JFK")
                departure = "20";
            if (departure == "LAX")
                departure = "21";
            if (departure == "NRT")
                departure = "30";
            if (departure == "KIX")
                departure = "31";
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            arrival = comboBox2.SelectedItem.ToString();
            if (arrival == "ICN")
                arrival = "10";
            if (arrival == "GMP")
                arrival = "11";
            if (arrival == "JFK")
                arrival = "20";
            if (arrival == "LAX")
                arrival = "21";
            if (arrival == "NRT")
                arrival = "30";
            if (arrival == "KIX")
                arrival = "31";
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dept_date = dateTimePicker1.Value.ToString("yy/MM/dd");
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            arv_date = dateTimePicker2.Value.ToString("yy/MM/dd");
        }

        private void btn_Resserve_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("선택하신 정보로 예약을 진행할까요?", "예약 진행", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                //예약번호 db에 데이터 추가 후 폼6 띄움 예약번호, 비행편번호, 항공기번호
                //flightsql = "Select * From flight_schedule Where fi_num Like 'KE1020'";

                flightsql = "Select rv_num From reservation"; //예약번호 생성
                rsv_num(flightsql, dbc.DS);

                inform_Check inform_check = new inform_Check();
                inform_check.ShowDialog();


            }
        }
        public void rsv_num(String sqlstr, DataSet dsstr)
        {
            dbc.DCom.CommandText = sqlstr;
            dbc.DA.SelectCommand = dbc.DCom;
            dbc.DA.Fill(dsstr, "flight_select");

            int count = dbc.DS.Tables["flight_select"].Rows.Count;
            string rsv_num = "AA" + (count).ToString("000");

            MessageBox.Show(rsv_num + ", " + fi_num + ", " + ac_num); //테스트용

            String userid = Login_Form.userid;
            string flightsql = "Insert Into reservation values('" + rsv_num + "', '" + fi_num + "', '" + ac_num + "', null, '" + userid + "')";
            dbc.DCom.CommandText = flightsql;
            dbc.DCom.ExecuteNonQuery();
            MessageBox.Show("예약 넘버 테이블에 데이터 추가 성공!"); //테스트용
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            list_search();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            fi_num = "";
            fi_num = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            testField.Text = fi_num;

            flightsql = "Select * From flight_schedule Where fi_num ='" + fi_num + "'"; //항공기 번호를 조회
            sql_execute2(flightsql, dbc.DS);
        }
    }
}
