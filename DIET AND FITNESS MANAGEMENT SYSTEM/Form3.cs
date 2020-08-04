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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        SqlConnection scon1 = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\prana\source\repos\DIET AND FITNESS MANAGEMENT SYSTEM\database1.mdf;Integrated Security = True; Connect Timeout = 30");
        // SqlConnection scon2 = new SqlConnection(@"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = C:\USERS\PRANA\SOURCE\REPOS\DIET AND FITNESS MANAGEMENT SYSTEM\DATABASE1.MDF; Integrated Security = True; Connect Timeout = 30; Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        SqlConnection scon = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\prana\\source\\repos\\DIET AND FITNESS MANAGEMENT SYSTEM\\Database1.mdf;Integrated Security = True");

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

           SqlCommand cmd = new SqlCommand("AddUserDetails", scon1);
            SqlCommand cmd1 = new SqlCommand("ADDVAL",scon);
            cmd1.CommandType = CommandType.StoredProcedure;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@User_Id", useridbox.Text);
            cmd1.Parameters.AddWithValue("@User_Id", useridbox.Text);
            cmd.Parameters.AddWithValue("@User_Name", usernamebox.Text);
            cmd1.Parameters.AddWithValue("@User_Name", usernamebox.Text);
           cmd.Parameters.AddWithValue("@Password", passwordbox.Text);
            cmd1.Parameters.AddWithValue("@Password", passwordbox.Text);
            cmd.Parameters.AddWithValue("@Weight", weightbox.Text);
          cmd.Parameters.AddWithValue("@Height", heightbox.Text);
            cmd.Parameters.AddWithValue("@Age", textBox4.Text);


            scon.Open();

            try
            {
               cmd1.ExecuteNonQuery();
            }

            catch(Exception ex)
            {
                MessageBox.Show("Add Successful");
            }
            scon.Close();


            scon1.Open();

            try
            {
                cmd.ExecuteNonQuery();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Add Successful");
            }
            scon1.Close();



        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           


        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }
    }
}
