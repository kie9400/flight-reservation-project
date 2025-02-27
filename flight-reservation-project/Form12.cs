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
    public partial class Form12 : Form
    {
        DBClass db = new DBClass();

        private void ClearTextBoxes()
        {
            txtID.Clear();
            txtname.Clear();
            txtphone.Clear();
            txtpw.Clear();
        }

        public bool isContaionNumber(string s)
        {
            bool isNumber = s.All(char.IsDigit);
            if (isNumber == true)
            {
                return false; //숫자인경우 false를 반환
            }
            else
            {
                return true;
            }
        }

        public Form12()
        {
            InitializeComponent();
            db.DB_Open();
            db.DB_ObjCreate();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            ClearTextBoxes();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtname.Text.Trim() == "")
            {
                MessageBox.Show("이름을 입력하세요");
                txtname.Focus();
            }
            else if (txtID.Text.Trim() == "")
            {
                MessageBox.Show(" 아이디를 입력하세요");
                txtID.Focus();
            }
            else if (txtphone.Text.Trim() == "")
            {
                MessageBox.Show(" 전화번호를 입력하세요 ");
                txtphone.Focus();
            }
            else if (txtphone.Text.Length != 11 || isContaionNumber(txtphone.Text))
            {
                MessageBox.Show(" 전화번호를 제대로 입력해주세요 (숫자로 11자 입력하세요)");
                txtphone.Focus();
            }
            else if (txtpw.Text.Trim() == "")
            {
                MessageBox.Show("비밀번호를 입력하세요");
                txtpw.Focus();
            }
            else if (comboBox1.Text.Trim() == "")
            {
                MessageBox.Show(" 국가를 정해주세요 ");
                comboBox1.Focus();
            }
            else if (txtpw.Text.Length < 4)
            {
                MessageBox.Show("비밀번호를 네 자리 이상 입력해주십시오.");
                txtpw.Focus();
            }
            else
            {
                try
                {
                    db.DS.Clear();
                    db.DA.Fill(db.DS, "Users");
                    db.UserTable = db.DS.Tables["Users"];//*
                    DataRow newRow = db.UserTable.NewRow();

                    newRow["userid"] = txtID.Text;
                    newRow["password"] = txtpw.Text;
                    newRow["name"] = txtname.Text;
                    newRow["Phone"] = txtphone.Text;
                    newRow["country"] = comboBox1.Text;
                    db.UserTable.Rows.Add(newRow);
                    db.DA.Update(db.DS, "users");
                    db.DS.AcceptChanges();//*
                    ClearTextBoxes();
                    MessageBox.Show("회원가입이 완료되었습니다.");
                    this.Close();
                }
                catch (DataException DE)
                {
                    MessageBox.Show(DE.Message);
                }


            }
        }
    }
}

