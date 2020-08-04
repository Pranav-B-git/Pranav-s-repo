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
    public partial class Form4 : Form
    {
        String userid;
        public Form4()
        {
            InitializeComponent();
        }

        public Form4(String passed)
        {
            InitializeComponent();
            userid = passed;
        }

        

        public void Display_data()
        {
            using (SqlConnection sqlCon = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\prana\source\repos\DIET AND FITNESS MANAGEMENT SYSTEM\Database1.mdf;Integrated Security = True"))
            {
                sqlCon.Open();
                //String FoodName = Food_Name.Text;

                // String querry = "Select * From Nutrition";
                SqlDataAdapter sqlDA = new SqlDataAdapter("Select * From Nutrition where Food_Name='" + textBox1.Text + "'", sqlCon);

                DataTable dtb1 = new DataTable();
                sqlDA.Fill(dtb1);
                dataGridView1.DataSource = dtb1;
                sqlCon.Close();
            }
        }

        public int ToInt(String s)
        {
            int z = s.Length;
            int c = z;
            int val = 0;
            char[] x = s.ToCharArray();
            int num = 0;
            if (x[0]=='0'||x[0] == '1' || x[0] == '2' || x[0] == '3' || x[0] == '4' || x[0] == '5' || x[0] == '6' || x[0] == '7' || x[0] == '8' || x[0] == '9')
            {
                for (int i = 0; i < z; i++)

                {
                    //textBox2.Text = (s.Length).ToString();
                  //  if (x[i] == '1' || x[i] == '2' || x[i] == '3' || x[i] == '4' || x[i] == '5' || x[i] == '6' || x[i] == '7' || x[i] == '8' || x[i] == '9')
                    {
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
                                num = 4;
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
            }
            return val;
        }

        public SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C: \\Users\\prana\\source\\repos\\DIET AND FITNESS MANAGEMENT SYSTEM\\Database1.mdf;Integrated Security=True");

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlCon = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\prana\source\repos\DIET AND FITNESS MANAGEMENT SYSTEM\Database1.mdf;Integrated Security = True");
        SqlCommand cmd1 = new SqlCommand("Add_Food1", sqlCon);
            cmd1.CommandType = CommandType.StoredProcedure;
          //  cmd.CommandType = CommandType.StoredProcedure;
            cmd1.Parameters.AddWithValue("@User_Id", userid);
            cmd1.Parameters.AddWithValue("@Food_Name",textBox1.Text);
            cmd1.Parameters.AddWithValue("@Amount",float.Parse(textBox2.Text));

            sqlCon.Open();

            try
            {
                cmd1.ExecuteNonQuery();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Invalid"+ex);
            }
            sqlCon.Close();

            Display_data();
            dataGridView1.Show();


           

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            using (SqlConnection sqlCon = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\prana\source\repos\DIET AND FITNESS MANAGEMENT SYSTEM\Database1.mdf;Integrated Security = True"))
            {
                sqlCon.Open();
                //String FoodName = Food_Name.Text;

                // String querry = "Select * From Nutrition";
                SqlDataAdapter sqlDA = new SqlDataAdapter("Select Log_Data From Diet_Log where User_Id='"+userid+"'", sqlCon);

                DataTable dtb1 = new DataTable();
                sqlDA.Fill(dtb1);
                dataGridView2.DataSource = dtb1;
                dataGridView2.Show();
                sqlCon.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(userid);
            this.Hide();
            form2.Show();


        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form6 form = new Form6(userid);
            this.Hide();
            form.Show();
        }
    }
}
