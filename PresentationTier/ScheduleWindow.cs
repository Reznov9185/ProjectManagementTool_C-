using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccessTier;
using System.Data.Linq;
using MTdbFramework;
using System.Data.SqlClient;
using LogicTier;


namespace PresentationTier
{
    public partial class ScheduleWindow : Form
    {
         SqlConnection con;
         SqlDataAdapter adap;
         DataSet ds;
         SqlCommandBuilder sqbdl;


        public ScheduleWindow()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;

        }

        private void ScheduleWindow_Load(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection();
                con.ConnectionString = ("Data Source=(LocalDB)\\v11.0;AttachDbFilename=F:\\C#\\tawhid\\ManagementTools.mdf;Integrated Security=True;Connect Timeout=30");
                con.Open();
                adap = new SqlDataAdapter("SELECT * FROM Schedule", con);
                ds = new System.Data.DataSet();
                adap.Fill(ds, "Schedule");
                dataGridView1.DataSource = ds.Tables[0];

                con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error!\n" + ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        

        }

        
       

        private void Update_btn_Click_1(object sender, EventArgs e)
        {
            try
            {
                sqbdl = new SqlCommandBuilder(adap);
                adap.Update(ds, "Schedule");
                MessageBox.Show("Information Updated :)\n", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);


                //MTAccess mA = new MTAccess();
                //SqlCommand cmd = mA.GetCommand("SELECT * FROM Schedule");
                //cmd.Connection.Open();



                //SqlDataReader reader = cmd.ExecuteReader();
                //string str = " ";

                //using (reader)
                //{
                //    while (reader.Read())
                //    {
                //        str += ", " + reader.GetInt32(1);
                //        str += ", " + reader.GetInt32(2);
                //        str += ", " + reader.GetInt32(3);
                //        str += ", " + reader.GetInt32(4);
                //        str += ", " + reader.GetInt32(5);
                //    }
                //    MessageBox.Show(str);
                //}





            }



            catch (Exception ex)
            {
                MessageBox.Show("Error!\n" + ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void ScheduleCalc_btn_Click_1(object sender, EventArgs e)
        {
            Logics.scheduleArrayAssign();
            // MessageBox.Show(Logics.scheduleArray[0, 0] + " " + Logics.scheduleArray[1, 0] + " " + Logics.scheduleArray[2, 0]);
            ///// string str= Logics.scheduleArray[0][0].ToString();
            // //MessageBox.Show()

            //string str = " ";

            //for (int i = 0; i < 5; i++)
            //{
            //    for (int j = 0; j < 5; j++)
            //    {
            //        str += " " + Logics.scheduleArray[i, j];
            //    }
            //    str += "\n";
            //}

            //MessageBox.Show(str);

            ScheduleResult s = new ScheduleResult();
            s.Show();

        }
    }
}
