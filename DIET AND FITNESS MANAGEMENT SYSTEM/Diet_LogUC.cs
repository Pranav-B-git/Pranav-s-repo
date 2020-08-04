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


    public partial class Diet_LogUC : UserControl
    {

        public String connectionString = "Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename=C:\\Users\\prana\\source\\repos\\DIET AND FITNESS MANAGEMENT SYSTEM\\Database1.mdf;Integrated Security = True";

        private static Diet_LogUC instance1;
        public static Diet_LogUC Instance1
        {
            get
            {
                if (instance1 == null)
                {
                    instance1 = new Diet_LogUC();
                }
                return instance1;
            }
        }
        public void Display_data()
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                String FoodName = Food_Name.Text;

                // String querry = "Select * From Nutrition";
                SqlDataAdapter sqlDA = new SqlDataAdapter("Select * From Nutrition where Food_Name='" + Food_Name.Text + "'", sqlCon);

                DataTable dtb1 = new DataTable();
                sqlDA.Fill(dtb1);
                dataGridView1.DataSource = dtb1;
                sqlCon.Close();
            }
        }
        



        public Diet_LogUC()
        {
            InitializeComponent();
        }

        public Diet_LogUC(String userid)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=C: \USERS\PRANA\SOURCE\REPOS\DIET AND FITNESS MANAGEMENT SYSTEM\DATABASE1.MDF;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        private void UserControl1_Load(object sender, EventArgs e)
        {
           // refresh_DataGridView();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Food_Name_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        /*  public void refresh_DataGridView()
          {
              try
              {


                  SqlCommand cmd = new SqlCommand("Select * From LOGIN", con);
                  cmd.CommandType = CommandType.StoredProcedure;
                  SqlDataAdapter da = new SqlDataAdapter(cmd);
                  DataSet Ds = new DataSet();
                  con.Open();
                  try
                  {
                      cmd.ExecuteNonQuery();

                  }
                  catch (Exception ex)
                  {
                      MessageBox.Show("            <<<Invalid sql operation\n  ");

                  }
                  con.Close();
                  dataGridView1.DataSource = Ds.Tables[0];
              }


              catch (Exception ex)
              {
                  MessageBox.Show("Invalid");
              }
          }
         */




        private void add_Click(object sender, EventArgs e)
        {
            /*SqlCommand cmd1 = new SqlCommand("Add_Food1", con);
            cmd1.CommandType = CommandType.StoredProcedure;
            //cmd.CommandType = CommandType.StoredProcedure;
            //cmd.Parameters.AddWithValue("@User_Id", userid);


          */
        }
             
    }
}
  



