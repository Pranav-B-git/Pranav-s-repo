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
    public partial class WorkoutUC : UserControl
    {

       public String connectionString= "Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename=C:\\Users\\prana\\source\\repos\\DIET AND FITNESS MANAGEMENT SYSTEM\\Database1.mdf;Integrated Security = True";
        public WorkoutUC()
        {
            InitializeComponent();
        }


        private static WorkoutUC instance1;
        public static WorkoutUC Instance1
        {
            get
            {
                if (instance1 == null)
                {
                    instance1 = new WorkoutUC();
                }
                return instance1;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void WorkoutUC_Load(object sender, EventArgs e)
        {

        }

        private void add_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                String ExerciseName = Exercise_Name.Text;

                // String querry = "Select * From Nutrition";
                SqlDataAdapter sqlDA = new SqlDataAdapter("Select * From Exercise where Exercise_Name='" + ExerciseName + "'", sqlCon);
                DataTable dtb1 = new DataTable();
                sqlDA.Fill(dtb1);
                dataGridView1.DataSource = dtb1;


            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Exercise_Name_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
