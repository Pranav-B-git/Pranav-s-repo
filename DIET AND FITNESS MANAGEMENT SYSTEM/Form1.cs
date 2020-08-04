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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public String Value;
           
        SqlConnection con = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\prana\\source\\repos\\DIET AND FITNESS MANAGEMENT SYSTEM\\Database1.mdf;Integrated Security = True");
        SqlCommand cmd;
        SqlDataReader dr;
 
      private String getUserID()
        {
            String userid = useridbox.Text;
            con.Open();
            String syntax = "SELECT User_Name From LOGIN where User_Id='"+userid+"'";
            cmd = new SqlCommand(syntax, con);
            dr = cmd.ExecuteReader();
            dr.Read();
            String temp = dr[0].ToString();
            con.Close();
            return temp;

        } 

        private String getPass()
        {
            con.Open();
            String syntax1;
            String userid = useridbox.Text;
            cmd = new SqlCommand("SELECT Password FROM LOGIN WHERE User_Id='"+userid+"'",con);
            dr = cmd.ExecuteReader();
            dr.Read();
            String temp = dr[0].ToString();
            con.Close();
            return temp;

        } 

        private void button2_Click(object sender, EventArgs e)
        {

            String U_name=getUserID(), Pass=getPass(), name, password;

             
             name = textBox2.Text;
              String send = name;
            
             password = textBox1.Text;
            
            

           if (name.Equals(U_name) && password.Equals(Pass))
             {
                 textBox3.Hide();
                String xyz = useridbox.Text;
                Form2 obj = new Form2(xyz);
               /// obj.Value = useridbox.Text;
                this.Hide();
                obj.Show();
                

               // obj.ShowDialog();

             }
             else
             {
                 textBox3.Show();
             }
           
            

        }

        private void USER_ID_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void PASSWORD_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 obj3 = new Form3();
            this.Hide();
            obj3.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
