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
    public partial class inform_Check : Form
    {
        DBClass dbc = new DBClass();
        public inform_Check()
        {
            InitializeComponent();
            dbc.DB_ObjCreate(); //*****
            dbc.DB_Open();//*****
            dbc.DB_Access();//***
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Seat_Select seat_select = new Seat_Select();
            seat_select.ShowDialog();
        }

        private void inform_Check_Load(object sender, EventArgs e)
        {
            string flight_num = main.fi_num;
            string sqlstr = "select * from FLIGHT_INFORM where FI_NUM = '"+ flight_num +"'"; 
            dbc.DCom.CommandText = sqlstr; 
            dbc.DA.SelectCommand = dbc.DCom;
            dbc.DA.Fill(dbc.DS, "flight_inform");
            OracleDataReader sr = dbc.DCom.ExecuteReader();
            sr.Read();

            textBox5.Text = sr["dept_ap"].ToString();
            textBox7.Text = sr["arv_ap"].ToString();
            textBox6.Text = sr["dept_date"].ToString();
            textBox8.Text = sr["arv_date"].ToString();
            textBox1.Text = sr["fee"].ToString();
                

        }
    }
}
