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
    public partial class SequenceWindow : Form
    {
        SqlConnection con;
        SqlDataAdapter adap;
        DataSet ds;
        SqlCommandBuilder sqbdl;
        public SequenceWindow()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void SequenceWindow_Load(object sender, EventArgs e)
        {

            try
            {
                con = new SqlConnection();
                con.ConnectionString = ("Data Source=(LocalDB)\\v11.0;AttachDbFilename=F:\\C#\\tawhid\\ManagementTools.mdf;Integrated Security=True;Connect Timeout=30");
                con.Open();

                adap = new SqlDataAdapter("SELECT * FROM Sequence", con);
                ds = new System.Data.DataSet();
                adap.Fill(ds, "Sequence");
                dataGridView2.DataSource = ds.Tables[0];

                con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error!\n" + ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
     
        }

        private void Update_btn_Click(object sender, EventArgs e)
        {
            try
            {
                sqbdl = new SqlCommandBuilder(adap);
                adap.Update(ds, "Sequence");
                MessageBox.Show("Information Updated :)\n", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }



            catch (Exception ex)
            {
                MessageBox.Show("Error!\n" + ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SequenceCalc_btn_Click(object sender, EventArgs e)
        {
            SequenceResult sr = new SequenceResult();
            sr.Show();
        }
    }
}
