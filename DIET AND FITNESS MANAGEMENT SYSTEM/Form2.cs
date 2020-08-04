using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DIET_AND_FITNESS_MANAGEMENT_SYSTEM
{
    public partial class Form2 : Form
    {
        public String userid;
        public Form2()
        {
            InitializeComponent();
            //this.Value = value;
        }

        public Form2(String Value)
        {
            InitializeComponent();
             userid = Value;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            Form4 form4 = new Form4(userid);
            form4.Show();
            this.Hide();
            /*
                 if (!Content_Panel.Controls.Contains(Diet_LogUC.Instance1))
             {
                 Content_Panel.Controls.Add(Diet_LogUC.Instance1);
                 Diet_LogUC.Instance1.Dock = DockStyle.Fill;
                 Diet_LogUC.Instance1.BringToFront();
             }
             else Diet_LogUC.Instance1.BringToFront();

             MessageBox.Show(userid); */

        }
        
        private void Form2_Load(object sender, EventArgs e)
        {

        }

       

       

        private void button2_Click(object sender, EventArgs e)
        {

            Form5 form5 = new Form5(userid);
            form5.Show();
            this.Hide();

           /* if (!Content_Panel.Controls.Contains(WorkoutUC.Instance1))
            {
                Content_Panel.Controls.Add(WorkoutUC.Instance1);
                WorkoutUC.Instance1.Dock = DockStyle.Fill;
                WorkoutUC.Instance1.BringToFront();
            }
            else WorkoutUC.Instance1.BringToFront(); */
        }

        private void button4_Click(object sender, EventArgs e)
        {

            //if (!SearchBarUc.Controls.Contains(SearchBarUc.Instance1))
           // {
                Content_Panel.Controls.Add(SearchBarUc.Instance1);
                SearchBarUc.Instance1.Dock = DockStyle.Fill;
                SearchBarUc.Instance1.BringToFront();
           // }
          //  else SearchBarUc.Instance1.BringToFront();

        }

        private void button3_Click(object sender, EventArgs e)//logout

        {
            Form1 obj = new Form1();
            this.Hide();
            obj.Show();

        }

        private void Content_Panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }
    }
}
