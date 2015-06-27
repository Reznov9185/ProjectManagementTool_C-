using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationTier
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            //this.WindowState = FormWindowState.Maximized;
        }

        public void Schedule_btn_Click(object sender, EventArgs e)
        {
            ScheduleWindow sc = new ScheduleWindow();
            sc.Show();
        }

        private void Sequence_btn_Click(object sender, EventArgs e)
        {
            SequenceWindow s = new SequenceWindow();
            s.Show();
        }

        

        
    }
}
