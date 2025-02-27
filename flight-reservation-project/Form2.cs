using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace prototype1
{
    public partial class RSV_Search : Form
    {
        DBClass dbc = new DBClass();  //*****DBClass 객체 생성
        String flightsql;
        String userid = "hong1"; //테스트용 아이디 삽입함
            //Login_Form.userid;
        public RSV_Search()
        {
            InitializeComponent();
            dbc.DB_ObjCreate(); //*****
            dbc.DB_Open();//*****
            dbc.DB_Access();//***
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String flightsql = "Select * From reservation Where user_id like '" + userid + "' and rv_num like '" + textBox2.ToString() + "'";
            sql_execute(flightsql, dbc.DS);
        }

        public void sql_execute(String sqlstr, DataSet dsstr)  //회원번호, 비행편번호 먼저
        {
            dbc.DCom.CommandText = sqlstr;
            dbc.DA.SelectCommand = dbc.DCom;
            dbc.DA.Fill(dsstr, "reservation");

            OracleDataReader rsv = dbc.DCom.ExecuteReader();
            rsv.Read();

            textBox3.Text = userid;
            textBox4.Text = rsv["fi_num"].ToString();
            String ac_num = rsv["ac_num"].ToString();
            String fi_num = rsv["fi_num"].ToString();

            flightsql = "Select ac_type From aircraft Where ac_num like '" + ac_num + "'";
            dbc.DCom.CommandText = flightsql;
            dbc.DA.SelectCommand = dbc.DCom;
            dbc.DA.Fill(dsstr, "flight");

            OracleDataReader flight = dbc.DCom.ExecuteReader();
            flight.Read();

            textBox5.Text = flight["ac_type"].ToString();

            flightsql = "Select * From flight_inform Where fi_num like '" + fi_num + "'"; //항공기 기종
            dbc.DCom.CommandText = flightsql;
            dbc.DA.SelectCommand = dbc.DCom;
            dbc.DA.Fill(dsstr, "flight2");

            OracleDataReader flight2 = dbc.DCom.ExecuteReader();
            flight2.Read();

            String dept_ap = flight2["dept_ap"].ToString(); //출발공항
            textBox8.Text = flight2["dept_date"].ToString(); //출발시간
            String arv_ap = flight2["arv_ap"].ToString(); //도착공항
            textBox10.Text = flight2["arv_date"].ToString(); //도착시간

            if  (dept_ap == "10" || arv_ap == "10")
            {
                if (dept_ap == "10")
                    textBox7.Text = "ICN";
                if (arv_ap == "10")
                    textBox9.Text = "ICN";
            }
            if (dept_ap == "11" || arv_ap == "11")
            {
                if (dept_ap == "11")
                    textBox7.Text = "GMP";
                if (arv_ap == "11")
                    textBox9.Text = "GMP";
            }
            if (dept_ap == "20" || arv_ap == "20")
            {
                if (dept_ap == "20")
                    textBox7.Text = "JFK";
                if (arv_ap == "20")
                    textBox9.Text = "JFK";
            }
            if (dept_ap == "21" || arv_ap == "21")
            {
                if (dept_ap == "21")
                    textBox7.Text = "LAX";
                if (arv_ap == "21")
                    textBox9.Text = "LAX";
            }
            if (dept_ap == "30" || arv_ap == "30")
            {
                if (dept_ap == "30")
                    textBox7.Text = "NRT";
                if (arv_ap == "30")
                    textBox9.Text = "NRT";
            }
            if (dept_ap == "31" || arv_ap == "31")
            {
                if (dept_ap == "31")
                    textBox7.Text = "KIX";
                if (arv_ap == "31")
                    textBox9.Text = "KIX";
            }

        }

        private void RSV_Search_Load(object sender, EventArgs e)
        {
            textBox1.Text = userid;
        }
    }
}
