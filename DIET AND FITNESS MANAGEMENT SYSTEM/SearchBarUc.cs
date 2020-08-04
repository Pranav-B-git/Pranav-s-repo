using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DIET_AND_FITNESS_MANAGEMENT_SYSTEM
{
    public partial class SearchBarUc : UserControl
    {
        public String connectionString = "Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename=C:\\Users\\prana\\source\\repos\\DIET AND FITNESS MANAGEMENT SYSTEM\\Database1.mdf;Integrated Security = True";
        public static int y;

        private static SearchBarUc instance1;
        public static SearchBarUc Instance1
        {
            get
            {
                if (instance1 == null)
                {
                    instance1 = new SearchBarUc();
                }
                return instance1;
            }
        }
        public SearchBarUc()
        {
            InitializeComponent();
        }

  

        public int ToInt(String s)
        {
            int z = s.Length;
            int c = z;
            int val = 0;
            char[] x = s.ToCharArray();
            int num = 0;
            if (x[0] == '1' || x[0] == '2' || x[0] == '3' || x[0] == '4' || x[0] == '5' || x[0] == '6' || x[0] == '7' || x[0] == '8' || x[0] == '9')
            {
               for (int i = 0; i < z; i++)

                {
                   // labelfib.Text = (s.Length).ToString();
                    if (x[i]=='0'||x[i] == '1' || x[i] == '2' || x[i] == '3' || x[i] == '4' || x[i] == '5' || x[i] == '6' || x[i] == '7' || x[i] == '8' || x[i] == '9')
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
            }
            return val;
        }

        private String Calories()
        {
            String Food_Name = Search_Bar.Text;
            //SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=C: \\USERS\\PRANA\\SOURCE\\REPOS\\DIET AND FITNESS MANAGEMENT SYSTEM\\DATABASE1.MDF;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            SqlConnection con = new SqlConnection(connectionString);
            String syntax = "SELECT Calories From Nutrition where Food_Name='" + Food_Name + "'";
            SqlCommand cmd1 = new SqlCommand(syntax, con);
            SqlDataReader dr;
            //  cmd1 = new SqlCommand(syntax, con);
            con.Open();
            try
            {
                dr = cmd1.ExecuteReader();
                dr.Read();
                labelcal.Text = dr[0].ToString();
                String temp = dr[0].ToString();
                char[] x = temp.ToCharArray();
                int try1 = ToInt(temp);
                return temp;
                //label2.Text = try1.ToString();

              
              
            }
            catch(System.InvalidOperationException ex)
            {
                MessageBox.Show("Incorrect Entry");
            }
            return "thank you";
        
            
            con.Close();
            // Type.GetType(dr[0]);


            // String temp = dr[0].ToString();
            // char[] x = temp.ToCharArray();
            //int try1= ToInt(temp);
            //label2.Text = try1.ToString();



        }
        private String Fiber()
        {
            String Food_Name = Search_Bar.Text;
            //SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=C: \\USERS\\PRANA\\SOURCE\\REPOS\\DIET AND FITNESS MANAGEMENT SYSTEM\\DATABASE1.MDF;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            SqlConnection con = new SqlConnection(connectionString);
            String syntax = "SELECT Fiber From Nutrition where Food_Name='" + Food_Name + "'";
            SqlCommand cmd1 = new SqlCommand(syntax, con);
            SqlDataReader dr;
            //  cmd1 = new SqlCommand(syntax, con);
            con.Open();
            dr = cmd1.ExecuteReader();
            dr.Read();
            // Type.GetType(dr[0]);
            labelfib.Text = dr[0].ToString();

            String temp = dr[0].ToString();
            char[] x = temp.ToCharArray();
            int try1 = ToInt(temp);
            //label2.Text = try1.ToString();

            con.Close();
            return temp;

        }
        private String Vitamin()
        {
            String Food_Name = Search_Bar.Text;
            //SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=C: \\USERS\\PRANA\\SOURCE\\REPOS\\DIET AND FITNESS MANAGEMENT SYSTEM\\DATABASE1.MDF;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            SqlConnection con = new SqlConnection(connectionString);
            String syntax = "SELECT Vitamins From Nutrition where Food_Name='" + Food_Name + "'";
            SqlCommand cmd1 = new SqlCommand(syntax, con);
            SqlDataReader dr;
            //  cmd1 = new SqlCommand(syntax, con);
            con.Open();
            dr = cmd1.ExecuteReader();
            dr.Read();
            // Type.GetType(dr[0]);
            labelvit.Text = dr[0].ToString();

            String temp = dr[0].ToString();
            char[] x = temp.ToCharArray();
            int try1 = ToInt(temp);
            //label2.Text = try1.ToString();

            con.Close();
            return temp;

        }
        private String Protein()
        {
            String Food_Name = Search_Bar.Text;
            //SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=C: \\USERS\\PRANA\\SOURCE\\REPOS\\DIET AND FITNESS MANAGEMENT SYSTEM\\DATABASE1.MDF;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            SqlConnection con = new SqlConnection(connectionString);
            String syntax = "SELECT Protein From Nutrition where Food_Name='" + Food_Name + "'";
            SqlCommand cmd1 = new SqlCommand(syntax, con);
            SqlDataReader dr;
            //  cmd1 = new SqlCommand(syntax, con);
            con.Open();
            dr = cmd1.ExecuteReader();
            dr.Read();
            // Type.GetType(dr[0]);
            labelpro.Text = dr[0].ToString();

            String temp = dr[0].ToString();
            char[] x = temp.ToCharArray();
            int try1 = ToInt(temp);
            //label2.Text = try1.ToString();

            con.Close();
            return temp;

        }
        private String Fat()
        {
            String Food_Name = Search_Bar.Text;
            //SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=C: \\USERS\\PRANA\\SOURCE\\REPOS\\DIET AND FITNESS MANAGEMENT SYSTEM\\DATABASE1.MDF;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            SqlConnection con = new SqlConnection(connectionString);
            String syntax = "SELECT Fat From Nutrition where Food_Name='" + Food_Name + "'";
            SqlCommand cmd1 = new SqlCommand(syntax, con);
            SqlDataReader dr;
            //  cmd1 = new SqlCommand(syntax, con);
            con.Open();
            dr = cmd1.ExecuteReader();
            dr.Read();
            // Type.GetType(dr[0]);
            labelfat.Text = dr[0].ToString();
            

            String temp = dr[0].ToString();
            char[] x = temp.ToCharArray();
            int try1 = ToInt(temp);
            //label2.Text = try1.ToString();

            con.Close();
            return temp;

        }






        public void display2()
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                String ExerciseName = Search_Bar.Text;

                // String querry = "Select * From Nutrition";
                SqlDataAdapter sqlDA = new SqlDataAdapter("Select * From Exercise where Exercise_Name='" + ExerciseName + "'", sqlCon);
                DataTable dtb1 = new DataTable();
                sqlDA.Fill(dtb1);
                dataGridView1.DataSource = dtb1;
                
                dataGridView1.Show();


            }
        }

        internal static bool ControlsContains(SearchBarUc instance1)
        {
            throw new NotImplementedException();
        }

       /* public void display2()
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                String FoodName = Search_Bar.Text;

                // String querry = "Select * From Nutrition";
                // SqlDataAdapter sqlDA = new SqlDataAdapter("Select * From Nutrition where Food_Name='" + FoodName + "'", sqlCon);
                SqlDataAdapter sqlDA = new SqlDataAdapter("Select * From USER_DETAILS", sqlCon);
                DataTable dtb1 = new DataTable();
                sqlDA.Fill(dtb1);
                dataGridView1.DataSource = dtb1;


            }
        } */











        int rad;
private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (WOradioButton1.Checked)
            {
                rad = 1;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (NUradioButton2.Checked)
            {
                rad = 2;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rad == 2)
            {
                labelfood.Text = Search_Bar.Text;
                labelfood.Show();

                label5.Show();
                label6.Show();
                label1.Show();
                label2.Show();
                label3.Show();
                label4.Show();
                labelfood.Show();
                labelfib.Show();
                labelcal.Show();
                labelvit.Show();
                labelfat.Show();
                labelpro.Show();



                //display1();
                Calories();
                Vitamin();
                Protein();
                Fat();
                Fiber();



            }
            else if (rad == 1)
            {
                display2();

            }
            else MessageBox.Show("Please select Nutrition or workout");
        }

      

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }

        private void Search_Bar_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void labelcal_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_2(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }
    }
}
