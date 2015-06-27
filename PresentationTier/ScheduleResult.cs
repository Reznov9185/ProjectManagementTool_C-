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
using DataAccessTier;

namespace PresentationTier
{
    public partial class ScheduleResult : Form
    {
        int cost = 0;
        public ScheduleResult()
        {
            InitializeComponent();
        }

        private void ScheduleResult_Load(object sender, EventArgs e)
        {
           managementToolsDataContext db=new managementToolsDataContext();
           db.GetChangeSet();
           
           for(int i=0;i<5;i++)
           {
               if(i==0)
               {
                   if (Logics.resultArray[i] == 0)
                   {
                       m1_lbl.Text = "MACHINE 1";
                       var label = from s in db.Schedules
                                   where s.Job == 1
                                   select s.Machine1;
                       foreach (var q in label)
                       {
                           this.cost += Convert.ToInt32(q);
                           c1_lbl.Text = q.ToString();
                       }
                   }
                   else if (Logics.resultArray[i] == 1)
                   {
                       m1_lbl.Text = "MACHINE 2";
                       var label = from s in db.Schedules
                                   where s.Job == 1
                                   select s.Machine2;
                       foreach (var q in label)
                       {
                           this.cost += Convert.ToInt32(q);
                           c1_lbl.Text = q.ToString();
                       }
                   }
                   else if (Logics.resultArray[i] == 2)
                   {
                       m1_lbl.Text = "MACHINE 3";
                       var label = from s in db.Schedules
                                   where s.Job == 1
                                   select s.Machine3;
                       foreach (var q in label)
                       {
                           this.cost += Convert.ToInt32(q);
                           c1_lbl.Text = q.ToString();
                       }
                   }
                   else if (Logics.resultArray[i] == 3)
                   {
                       m1_lbl.Text = "MACHINE 4";
                       var label = from s in db.Schedules
                                   where s.Job == 1
                                   select s.Machine4;
                       foreach (var q in label)
                       {
                           this.cost += Convert.ToInt32(q);
                           c1_lbl.Text = q.ToString();
                       }
                   }
                   else if (Logics.resultArray[i] == 4)
                   {
                       m1_lbl.Text = "MACHINE 5";
                       var label = from s in db.Schedules
                                   where s.Job == 1
                                   select s.Machine5;
                       foreach (var q in label)
                       {
                           this.cost += Convert.ToInt32(q);
                           c1_lbl.Text = q.ToString();
                       }
                   }
               }
               else if (i == 1)
               {
                   if (Logics.resultArray[i] == 0)
                   {
                       m2_lbl.Text = "MACHINE 1";
                       var label = from s in db.Schedules
                                   where s.Job == 2
                                   select s.Machine1;
                       foreach (var q in label)
                       {
                           this.cost += Convert.ToInt32(q);
                           c2_lbl.Text = q.ToString();
                       }
                   }
                   else if (Logics.resultArray[i] == 1)
                   {
                       m2_lbl.Text = "MACHINE 2";
                       var label = from s in db.Schedules
                                   where s.Job == 2
                                   select s.Machine2;
                       foreach (var q in label)
                       {
                           this.cost += Convert.ToInt32(q);
                           c2_lbl.Text = q.ToString();
                       }
                   }
                   else if (Logics.resultArray[i] == 2)
                   {
                       m2_lbl.Text = "MACHINE 3";
                       var label = from s in db.Schedules
                                   where s.Job == 2
                                   select s.Machine3;
                       foreach (var q in label)
                       {
                           this.cost += Convert.ToInt32(q);
                           c2_lbl.Text = q.ToString();
                       }
                   }
                   else if (Logics.resultArray[i] == 3)
                   {
                       m2_lbl.Text = "MACHINE 4";
                       var label = from s in db.Schedules
                                   where s.Job == 2
                                   select s.Machine4;
                       foreach (var q in label)
                       {
                           this.cost += Convert.ToInt32(q);
                           c2_lbl.Text = q.ToString();
                       }
                   }
                   else if (Logics.resultArray[i] == 4)
                   {
                       m2_lbl.Text = "MACHINE 5";
                       var label = from s in db.Schedules
                                   where s.Job == 2
                                   select s.Machine5;
                       foreach (var q in label)
                       {
                           this.cost += Convert.ToInt32(q);
                           c2_lbl.Text = q.ToString();
                       }
                   }
               }
               else if (i == 2)
               {
                   if (Logics.resultArray[i] == 0)
                   {
                       m3_lbl.Text = "MACHINE 1";
                       var label = from s in db.Schedules
                                   where s.Job == 3
                                   select s.Machine1;
                       foreach (var q in label)
                       {
                           this.cost += Convert.ToInt32(q);
                           c3_lbl.Text = q.ToString();
                       }
                   }
                   else if (Logics.resultArray[i] == 1)
                   {
                       m3_lbl.Text = "MACHINE 2";
                       var label = from s in db.Schedules
                                   where s.Job == 3
                                   select s.Machine2;
                       foreach (var q in label)
                       {
                           this.cost += Convert.ToInt32(q);
                           c3_lbl.Text = q.ToString();
                       }
                   }
                   else if (Logics.resultArray[i] == 2)
                   {
                       m3_lbl.Text = "MACHINE 3";
                       var label = from s in db.Schedules
                                   where s.Job == 3
                                   select s.Machine3;
                       foreach (var q in label)
                       {
                           this.cost += Convert.ToInt32(q);
                           c3_lbl.Text = q.ToString();
                       }
                   }
                   else if (Logics.resultArray[i] == 3)
                   {
                       m3_lbl.Text = "MACHINE 4";
                       var label = from s in db.Schedules
                                   where s.Job == 3
                                   select s.Machine4;
                       foreach (var q in label)
                       {
                           this.cost += Convert.ToInt32(q);
                           c3_lbl.Text = q.ToString();
                       }
                   }
                   else if (Logics.resultArray[i] == 4)
                   {
                       m3_lbl.Text = "MACHINE 5";
                       var label = from s in db.Schedules
                                   where s.Job == 3
                                   select s.Machine5;
                       foreach (var q in label)
                       {
                           this.cost += Convert.ToInt32(q);
                           c3_lbl.Text = q.ToString();
                       }
                   }
               }
               else if (i == 3)
               {
                   if (Logics.resultArray[i] == 0)
                   {
                       m4_lbl.Text = "MACHINE 1";
                       var label = from s in db.Schedules
                                   where s.Job == 4
                                   select s.Machine1;
                       foreach (var q in label)
                       {
                           this.cost += Convert.ToInt32(q);
                           c4_lbl.Text = q.ToString();
                       }
                   }
                   else if (Logics.resultArray[i] == 1)
                   {
                       m4_lbl.Text = "MACHINE 2";
                       var label = from s in db.Schedules
                                   where s.Job == 4
                                   select s.Machine2;
                       foreach (var q in label)
                       {
                           this.cost += Convert.ToInt32(q);
                           c4_lbl.Text = q.ToString();
                       }
                   }
                   else if (Logics.resultArray[i] == 2)
                   {
                       m4_lbl.Text = "MACHINE 3";
                       var label = from s in db.Schedules
                                   where s.Job == 4
                                   select s.Machine3;
                       foreach (var q in label)
                       {
                           this.cost += Convert.ToInt32(q);
                           c4_lbl.Text = q.ToString();
                       }
                   }
                   else if (Logics.resultArray[i] == 3)
                   {
                       m4_lbl.Text = "MACHINE 4";
                       var label = from s in db.Schedules
                                   where s.Job == 4
                                   select s.Machine4;
                       foreach (var q in label)
                       {
                           this.cost += Convert.ToInt32(q);
                           c4_lbl.Text = q.ToString();
                       }
                   }
                   else if (Logics.resultArray[i] == 4)
                   {
                       m4_lbl.Text = "MACHINE 5";
                       var label = from s in db.Schedules
                                   where s.Job == 4
                                   select s.Machine5;
                       foreach (var q in label)
                       {
                           this.cost += Convert.ToInt32(q);
                           c4_lbl.Text = q.ToString();
                       }
                   }
               }
               else if (i == 4)
               {
                   if (Logics.resultArray[i] == 0)
                   {
                       m5_lbl.Text = "MACHINE 1";
                       var label = from s in db.Schedules
                                   where s.Job == 5
                                   select s.Machine1;
                       foreach (var q in label)
                       {
                           this.cost += Convert.ToInt32(q);
                           c5_lbl.Text = q.ToString();
                       }
                   }
                   else if (Logics.resultArray[i] == 1)
                   {
                       m5_lbl.Text = "MACHINE 2";
                       var label = from s in db.Schedules
                                   where s.Job == 5
                                   select s.Machine2;
                       foreach (var q in label)
                       {
                           this.cost += Convert.ToInt32(q);
                           c5_lbl.Text = q.ToString();
                       }
                   }
                   else if (Logics.resultArray[i] == 2)
                   {
                       m5_lbl.Text = "MACHINE 3";
                       var label = from s in db.Schedules
                                   where s.Job == 5
                                   select s.Machine3;
                       foreach (var q in label)
                       {
                           this.cost += Convert.ToInt32(q);
                           c5_lbl.Text = q.ToString();
                       }
                   }
                   else if (Logics.resultArray[i] == 3)
                   {
                       m5_lbl.Text = "MACHINE 4";
                       var label = from s in db.Schedules
                                   where s.Job == 5
                                   select s.Machine4;
                       foreach (var q in label)
                       {
                           this.cost += Convert.ToInt32(q);
                           c5_lbl.Text = q.ToString();
                       }
                   }
                   else if (Logics.resultArray[i] == 4)
                   {
                       m5_lbl.Text = "MACHINE 5";
                       var label = from s in db.Schedules
                                   where s.Job == 5
                                   select s.Machine5;
                       foreach (var q in label)
                       {
                           this.cost += Convert.ToInt32(q);
                           c5_lbl.Text = q.ToString();
                       }
                   }
               }
              
               totalCost_lbl.Text = this.cost.ToString();
               Logics.AFT_fcfs = 0;
               Logics.AFT_edd = 0;
               Logics.AFT_spo = 0;
               Logics.AFT_spt = 0;
               Logics.AT_fcfs = 0;
               Logics.AT_edd = 0;
               Logics.AT_spo = 0;
               Logics.AT_spt = 0;
               Logics.ANJ_fcfs = 0;
               Logics.ANJ_edd = 0;
               Logics.ANJ_spo = 0;
               Logics.ANJ_spt = 0;

           }
        }
        


    }
}
