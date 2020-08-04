using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DIET_AND_FITNESS_MANAGEMENT_SYSTEM
{
    public partial class Form6 : Form
    {
        public String userid;
       // public String today = (dateTimePicker1.Value).ToString();
        public Form6()
        {
            InitializeComponent();
        }
        public Form6(String pass)
        {
            InitializeComponent();
            userid = pass;
           
        }

        SqlConnection con = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\prana\\source\\repos\\DIET AND FITNESS MANAGEMENT SYSTEM\\Database1.mdf;Integrated Security = True");
        SqlCommand cmd;
        SqlDataReader dr;

        private String Calories()
        {
            //String userid = useridbox.Text;
            con.Open();
            String syntax = "SELECT Ceiling(Sum(Cal_Consumed)) From Diet_Log where User_Id='" + userid + "'";
            cmd = new SqlCommand(syntax, con);
            dr = cmd.ExecuteReader();
            dr.Read();
            String temp = dr[0].ToString();
            con.Close();
            return temp;

        }

        public void Display_data()
        {
            using (SqlConnection sqlCon = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\prana\source\repos\DIET AND FITNESS MANAGEMENT SYSTEM\Database1.mdf;Integrated Security = True"))
            {
                sqlCon.Open();
                //String FoodName = Food_Name.Text;

                // String querry = "Select * From Nutrition";
                SqlDataAdapter sqlDA = new SqlDataAdapter("Select * From Diet_Log where User_Id='"+userid+"'", sqlCon);

                DataTable dtb1 = new DataTable();
                sqlDA.Fill(dtb1);
                dataGridView1.DataSource = dtb1;
                sqlCon.Close();
            }
        }

        private String Calories_B()
        {
            //String userid = useridbox.Text;
            con.Open();
            String syntax = "SELECT Ceiling(Sum(Cal_Burned)) From Exercise_Log where User_Id='" + userid + "'";
            cmd = new SqlCommand(syntax, con);
            dr = cmd.ExecuteReader();
            dr.Read();
            String temp = dr[0].ToString();
            con.Close();
            return temp;

        }


        public int ToInt(String s)
        {
            int z = s.Length;
            int c = z;
            int val = 0;
            char[] x = s.ToCharArray();
            int num = 0;
            if (x[0] == '0' || x[0] == '1' || x[0] == '2' || x[0] == '3' || x[0] == '4' || x[0] == '5' || x[0] == '6' || x[0] == '7' || x[0] == '8' || x[0] == '9')
            {
                for (int i = 0; i < z; i++)

                {
                    // textBox2.Text = (s.Length).ToString();
                    // if (x[i]=='0'||x[i] == '1' || x[i] == '2' || x[i] == '3' || x[i] == '4' || x[i] == '5' || x[i] == '6' || x[i] == '7' || x[i] == '8' || x[i] == '9')

                    switch (x[i])
                    {
                        case '1':
                            num = 1;
                            break;
                        case '2':
                            num = 2;
                            break;
                        case '3':
                            num = 3;
                            break;
                        case '4':
                            num = 3;
                            break;
                        case '5':
                            num = 5;
                            break;
                        case '6':
                            num = 6;
                            break;
                        case '7':
                            num = 7;
                            break;
                        case '8':
                            num = 8;
                            break;
                        case '9':
                            num = 9;
                            break;
                        case '0':
                            num = 0;
                            break;

                    }

                    for (int j = c - 1; j >= 1; j--)
                    {
                        num = num * 10;
                    }
                    c--;
                    val = val + num;

                }
            }
            return val;
        }
        /*public void Display_data()
        {
            using (SqlConnection sqlCon = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\prana\source\repos\DIET AND FITNESS MANAGEMENT SYSTEM\Database1.mdf;Integrated Security = True"))
            {
                sqlCon.Open();
                //String FoodName = Food_Name.Text;

                // String querry = "Select * From Nutrition";
                SqlDataAdapter sqlDA = new SqlDataAdapter("Select WO_Log_Data From Diet_Log where User_Id='"+userid, sqlCon);

                DataTable dtb1 = new DataTable();
                sqlDA.Fill(dtb1);
                dataGridView1.DataSource = dtb1;
                sqlCon.Close();
            }
        } */






        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Display_data();
            
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2(userid);
            this.Hide();
            form.Show();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
