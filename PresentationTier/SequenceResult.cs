using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicTier;
namespace PresentationTier
{
    public partial class SequenceResult : Form
    {
        public SequenceResult()
        {
            InitializeComponent();
        }

        private void SequenceResult_Load(object sender, EventArgs e)
        {
            double sum = new double();
            double sum1 = new double();
            double sum2 = new double();

            Logics.FindSequencing_FCFS();
            string str = "";
            string str1;
            for (int i = 0; i < 5; i++)
            {
                str1 = Logics.stk_FCFS.Pop();
                str = str1 + "------>" + str;
            }
            fcfslbl.Text = str;


            Logics.FindSequencing_EDD();
            str1 = null;
            str = null;
            for (int i = 0; i < 5; i++)
            {
                str1 = Logics.stk_EDD.Pop();
                str = str1 + "------>" + str;
            }
            eddlbl.Text = str;



            Logics.FindSequencing_SPT();
            str1 = null;
            str = null;
            for (int i = 0; i < 5; i++)
            {
                str1 = Logics.stk_SPT.Pop();
                str = str1 + "------>" + str;
            }
            sptlbl.Text = str;

            Logics.FindSequencing_SPO();
            str1 = null;
            str = null;
            for (int i = 0; i < 5; i++)
            {
                str1 = Logics.stk_SPO.Pop();
                str = str1 + "------>" + str;
            }
            spolbl.Text = str;

            for (int i = 0; i < 5; i++)
            {
                sum += Logics.calc_fcfs[i, 2];
                sum1 += Logics.calc_fcfs[i, 3];
                sum2 += Logics.calc_fcfs[i, 0];

            }
            fcfsaft.Text = (sum / 5).ToString();
            fcfsat.Text = (sum1 / 5).ToString();
            fcfsanj.Text = (sum / sum2).ToString();
            sum = 0.0;
            sum1 = 0.0;
            sum2 = 0.0;

            for (int i = 0; i < 5; i++)
            {
                sum += Logics.calc_edd[i, 2];
                sum1 += Logics.calc_edd[i, 3];
                sum2 += Logics.calc_edd[i, 0];
            }
            eddaft.Text = (sum / 5).ToString();
            eddat.Text = (sum1 / 5).ToString();
            eddanj.Text = (sum / sum2).ToString();
            sum = 0.0;
            sum1 = 0.0;
            sum2 = 0.0;

            for (int i = 0; i < 5; i++)
            {
                sum += Logics.calc_spt[i, 2];
                sum1 += Logics.calc_spt[i, 3];
                sum2 += Logics.calc_spt[i, 0];
            }
            sptaft.Text = (sum / 5).ToString();
            sptat.Text = (sum1 / 5).ToString();
            sptanj.Text = (sum / sum2).ToString();
            sum = 0.0;
            sum1 = 0.0;
            sum2 = 0.0;

            for (int i = 0; i < 5; i++)
            {
                sum += Logics.calc_spo[i, 2];
                sum1 += Logics.calc_spo[i, 3];
                sum2 += Logics.calc_spo[i, 0];
            }
            spoaft.Text = (sum / 5).ToString();
            spoat.Text = (sum1 / 5).ToString();
            spoanj.Text = (sum / sum2).ToString();
            sum = 0.0;
            sum1 = 0.0;
            sum2 = 0.0;


            
            List<double> cmpaft = new List<double>();
            cmpaft.Add(Convert.ToDouble(fcfsaft.Text));
            cmpaft.Add(Convert.ToDouble(eddaft.Text));
            cmpaft.Add(Convert.ToDouble(sptaft.Text));
            cmpaft.Add(Convert.ToDouble(spoaft.Text));

            double min = cmpaft.Min();
            if(Convert.ToDouble(fcfsaft.Text)==min)
            {
                fcfsaft.BackColor = Color.Lime;
            }
            else if (Convert.ToDouble(eddaft.Text) == min)
            {
                eddaft.BackColor = Color.Lime;
            }
            else if (Convert.ToDouble(sptaft.Text)==min)
            {
                sptaft.BackColor = Color.Lime;
            }
            else
            {
                spoaft.BackColor = Color.Lime;
            }

            List<double> cmpat = new List<double>();
            cmpat.Add(Convert.ToDouble(fcfsat.Text));
            cmpat.Add(Convert.ToDouble(eddat.Text));
            cmpat.Add(Convert.ToDouble(sptat.Text));
            cmpat.Add(Convert.ToDouble(spoat.Text));

            double min1 = cmpat.Min();
            if (Convert.ToDouble(fcfsat.Text) == min1)
            {
                fcfsat.BackColor = Color.Lime;
            }
            else if (Convert.ToDouble(eddat.Text) == min1)
            {
                eddat.BackColor = Color.Lime;
            }
            else if (Convert.ToDouble(sptat.Text) == min1)
            {
                sptat.BackColor = Color.Lime;
            }
            else
            {
                spoat.BackColor = Color.Lime;
            }

            List<double> cmpanj= new List<double>();
            cmpanj.Add(Convert.ToDouble(fcfsanj.Text));
            cmpanj.Add(Convert.ToDouble(eddanj.Text));
            cmpanj.Add(Convert.ToDouble(sptanj.Text));
            cmpanj.Add(Convert.ToDouble(spoanj.Text));

            double min2 = cmpanj.Min();
            if (Convert.ToDouble(fcfsanj.Text) == min2)
            {
                fcfsanj.BackColor = Color.Lime;
            }
            else if (Convert.ToDouble(eddanj.Text) == min2)
            {
                eddanj.BackColor = Color.Lime;
            }
            else if (Convert.ToDouble(sptanj.Text) == min2)
            {
                sptanj.BackColor = Color.Lime;
            }
            else
            {
                spoanj.BackColor = Color.Lime;
            }


            
        }

        private void calcdecButton_Click(object sender, EventArgs e)
        {
            switch (flexibilityListBox.Text)
            {
                case "Flexible Deadline":
                    decisionTextBox.Text = "Use Critical Ratio(CR) Sequence";
                    break;
                case "Crucial Deadline":
                    decisionTextBox.Text = "Use Earliest Due Date(EDD) Sequence";
                    break;
                case "As many job as you can":
                    decisionTextBox.Text = "Use Shortest Processing Time(SPT) Sequence";
                    break;
                case "First come first priority":
                    decisionTextBox.Text = "Use First Come First Serve(FCFS) Sequence";
                    break;
                default:
                    break;
            }
        }
    }
}


