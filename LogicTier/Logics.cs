
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MTdbFramework;
using System.Data.SqlClient;
using DataEntityTier;

namespace LogicTier
{

    public static class Logics
    {
        public static int[,] sequenceArray = new int[5, 5];
        public static int[,] scheduleArray = new int[5, 5];
        public static int[] resultArray = new int[5];
        public static Stack<string> stk_FCFS = new Stack<string>();
        public static Stack<string> stk_EDD = new Stack<string>();
        public static Stack<string> stk_SPT = new Stack<string>();
        public static Stack<string> stk_SPO = new Stack<string>();
        public static Stack<string> stk_CR = new Stack<string>();
        public static int[,] calc_fcfs = new int[5, 4];
        public static int[,] calc_edd = new int[5, 4];
        public static int[,] calc_spt = new int[5, 4];
        public static int[,] calc_spo = new int[5, 4];
        public static double AFT_fcfs = new double();
        public static double AFT_edd = new double();
        public static double AFT_spt = new double();
        public static double AFT_spo = new double();
        public static double AT_fcfs = new double();
        public static double AT_edd = new double();
        public static double AT_spt = new double();
        public static double AT_spo = new double();
        public static double ANJ_fcfs = new double();
        public static double ANJ_edd = new double();
        public static double ANJ_spt = new double();
        public static double ANJ_spo = new double();

        public static void FindSequencing_FCFS()
        {
            for(int a=0;a<5;a++)
            {
                for(int b=0;b<4;b++)
                {
                    Logics.calc_fcfs[a,b] = 0;
                }
            }
            DataAccessTier.managementToolsDataContext db = new DataAccessTier.managementToolsDataContext();
            var FCFS = from s in db.Sequences
                       select s.TaskName;
            var calc = from s in db.Sequences
                       select new { s.ProceessingTime, s.DueDate };
            int i = 0;
            foreach (var a in calc)
            {
                calc_fcfs[i, 0] = a.ProceessingTime;
                calc_fcfs[i, 1] = a.DueDate;
                if (i == 0) calc_fcfs[i, 2] = calc_fcfs[i, 2] + calc_fcfs[i, 0];
                else calc_fcfs[i, 2] = calc_fcfs[i - 1, 2] + calc_fcfs[i, 0];
                calc_fcfs[i, 3] = ((calc_fcfs[i, 2] - calc_fcfs[i, 1]) < 0) ? 0 : (calc_fcfs[i, 2] - calc_fcfs[i, 1]);
                i++;
            }
            foreach (var a in FCFS)
            {
                stk_FCFS.Push(a.ToString());
            }
            stk_FCFS.Reverse();
        }

        public static void FindSequencing_EDD()
        {
            for (int a = 0; a < 5; a++)
            {
                for (int b = 0; b < 4; b++)
                {
                    Logics.calc_edd[a, b] = 0;
                }
            }
            DataAccessTier.managementToolsDataContext db = new DataAccessTier.managementToolsDataContext();
            var EDD = from s in db.Sequences
                      orderby s.DueDate
                      select s.TaskName;
            var calc = from s in db.Sequences
                       orderby s.DueDate
                       select new { s.ProceessingTime, s.DueDate };
            int i = 0;
            foreach (var a in calc)
            {
                calc_edd[i, 0] = a.ProceessingTime;
                calc_edd[i, 1] = a.DueDate;
                if (i == 0) calc_edd[i, 2] = calc_edd[i, 2] + calc_edd[i, 0];
                else calc_edd[i, 2] = calc_edd[i - 1, 2] + calc_edd[i, 0];
                calc_edd[i, 3] = ((calc_edd[i, 2] - calc_edd[i, 1]) < 0) ? 0 : (calc_edd[i, 2] - calc_edd[i, 1]);
                i++;
            }
            foreach (var a in EDD)
            {
                stk_EDD.Push(a.ToString());
            }
            stk_EDD.Reverse();
        }

        public static void FindSequencing_SPT()
        {
            for (int a = 0; a < 5; a++)
            {
                for (int b = 0; b < 4; b++)
                {
                    Logics.calc_spt[a, b] = 0;
                }
            }
            DataAccessTier.managementToolsDataContext db = new DataAccessTier.managementToolsDataContext();
            var SPT = from s in db.Sequences
                      orderby s.ProceessingTime
                      select s.TaskName;
            var calc = from s in db.Sequences
                       orderby s.ProceessingTime
                       select new { s.ProceessingTime, s.DueDate };
            int i = 0;
            foreach (var a in calc)
            {
                calc_spt[i, 0] = a.ProceessingTime;
                calc_spt[i, 1] = a.DueDate;
                if (i == 0) calc_spt[i, 2] = calc_spt[i, 2] + calc_spt[i, 0];
                else calc_spt[i, 2] = calc_spt[i - 1, 2] + calc_spt[i, 0];
                calc_spt[i, 3] = ((calc_spt[i, 2] - calc_spt[i, 1]) < 0) ? 0 : (calc_spt[i, 2] - calc_spt[i, 1]);
                i++;
            }
            foreach (var a in SPT)
            {
                stk_SPT.Push(a.ToString());
            }
        }

        public static void FindSequencing_SPO()
        {
            for (int a = 0; a < 5; a++)
            {
                for (int b = 0; b < 4; b++)
                {
                    Logics.calc_spo[a, b] = 0;
                }
            }
            DataAccessTier.managementToolsDataContext db = new DataAccessTier.managementToolsDataContext();
            var SPO = from s in db.Sequences
                      orderby ((Convert.ToDouble(s.DueDate) - Convert.ToDouble(s.ProceessingTime)) / Convert.ToDouble(s.NoOfOperation))
                      select s.TaskName;
            var calc = from s in db.Sequences
                       orderby ((Convert.ToDouble(s.DueDate) - Convert.ToDouble(s.ProceessingTime)) / Convert.ToDouble(s.NoOfOperation))
                       select new { s.ProceessingTime, s.DueDate };
            int i = 0;
            foreach (var a in calc)
            {
                calc_spo[i, 0] = a.ProceessingTime;
                calc_spo[i, 1] = a.DueDate;
                if (i == 0) calc_spo[i, 2] = calc_spo[i, 2] + calc_spo[i, 0];
                else calc_spo[i, 2] = calc_spo[i - 1, 2] + calc_spo[i, 0];
                calc_spo[i, 3] = ((calc_spo[i, 2] - calc_spo[i, 1]) < 0) ? 0 : (calc_spo[i, 2] - calc_spo[i, 1]);
                i++;
            }
            foreach (var a in SPO)
            {
                stk_SPO.Push(a.ToString());
            }
            stk_SPO.Reverse();
        }



        public static int[] FindAssignments(this int[,] costs)
        {
            if (costs == null)
                throw new ArgumentNullException("costs");

            var h = costs.GetLength(0);
            var w = costs.GetLength(1);

            for (int i = 0; i < h; i++)
            {
                var min = int.MaxValue;
                for (int j = 0; j < w; j++)
                    min = Math.Min(min, costs[i, j]);
                for (int j = 0; j < w; j++)
                    costs[i, j] -= min;
            }

            var masks = new byte[h, w];
            var rowsCovered = new bool[h];
            var colsCovered = new bool[w];
            for (int i = 0; i < h; i++)
            {
                for (int j = 0; j < w; j++)
                {
                    if (costs[i, j] == 0 && !rowsCovered[i] && !colsCovered[j])
                    {
                        masks[i, j] = 1;
                        rowsCovered[i] = true;
                        colsCovered[j] = true;
                    }
                }
            }
            ClearCovers(rowsCovered, colsCovered, w, h);

            var path = new Location[w * h];
            Location pathStart = default(Location);
            var step = 1;
            while (step != -1)
            {
                switch (step)
                {
                    case 1:
                        step = RunStep1(costs, masks, rowsCovered, colsCovered, w, h);
                        break;
                    case 2:
                        step = RunStep2(costs, masks, rowsCovered, colsCovered, w, h, ref pathStart);
                        break;
                    case 3:
                        step = RunStep3(costs, masks, rowsCovered, colsCovered, w, h, path, pathStart);
                        break;
                    case 4:
                        step = RunStep4(costs, masks, rowsCovered, colsCovered, w, h);
                        break;
                }
            }

            var agentsTasks = new int[h];
            for (int i = 0; i < h; i++)
            {
                for (int j = 0; j < w; j++)
                {
                    if (masks[i, j] == 1)
                    {
                        agentsTasks[i] = j;
                        break;
                    }
                }
            }
            return agentsTasks;
        }

        private static int RunStep1(int[,] costs, byte[,] masks, bool[] rowsCovered, bool[] colsCovered, int w, int h)
        {
            for (int i = 0; i < h; i++)
            {
                for (int j = 0; j < w; j++)
                {
                    if (masks[i, j] == 1)
                        colsCovered[j] = true;
                }
            }
            var colsCoveredCount = 0;
            for (int j = 0; j < w; j++)
            {
                if (colsCovered[j])
                    colsCoveredCount++;
            }
            if (colsCoveredCount == h)
                return -1;
            else
                return 2;
        }

        private static int RunStep2(int[,] costs, byte[,] masks, bool[] rowsCovered, bool[] colsCovered, int w, int h,
            ref Location pathStart)
        {
            Location loc;
            while (true)
            {
                loc = FindZero(costs, masks, rowsCovered, colsCovered, w, h);
                if (loc.Row == -1)
                {
                    return 4;
                }
                else
                {
                    masks[loc.Row, loc.Column] = 2;
                    var starCol = FindStarInRow(masks, w, loc.Row);
                    if (starCol != -1)
                    {
                        rowsCovered[loc.Row] = true;
                        colsCovered[starCol] = false;
                    }
                    else
                    {
                        pathStart = loc;
                        return 3;
                    }
                }
            }
        }

        private static int RunStep3(int[,] costs, byte[,] masks, bool[] rowsCovered, bool[] colsCovered, int w, int h,
            Location[] path, Location pathStart)
        {
            var pathIndex = 0;
            path[0] = pathStart;
            while (true)
            {
                var row = FindStarInColumn(masks, h, path[pathIndex].Column);
                if (row == -1)
                    break;
                pathIndex++;
                path[pathIndex] = new Location(row, path[pathIndex - 1].Column);
                var col = FindPrimeInRow(masks, w, path[pathIndex].Row);
                pathIndex++;
                path[pathIndex] = new Location(path[pathIndex - 1].Row, col);
            }
            ConvertPath(masks, path, pathIndex + 1);
            ClearCovers(rowsCovered, colsCovered, w, h);
            ClearPrimes(masks, w, h);
            return 1;
        }

        private static int RunStep4(int[,] costs, byte[,] masks, bool[] rowsCovered, bool[] colsCovered, int w, int h)
        {
            var minValue = FindMinimum(costs, rowsCovered, colsCovered, w, h);
            for (int i = 0; i < h; i++)
            {
                for (int j = 0; j < w; j++)
                {
                    if (rowsCovered[i])
                        costs[i, j] += minValue;
                    if (!colsCovered[j])
                        costs[i, j] -= minValue;
                }
            }
            return 2;
        }

        private static void ConvertPath(byte[,] masks, Location[] path, int pathLength)
        {
            for (int i = 0; i < pathLength; i++)
            {
                if (masks[path[i].Row, path[i].Column] == 1)
                    masks[path[i].Row, path[i].Column] = 0;
                else if (masks[path[i].Row, path[i].Column] == 2)
                    masks[path[i].Row, path[i].Column] = 1;
            }
        }

        private static Location FindZero(int[,] costs, byte[,] masks, bool[] rowsCovered, bool[] colsCovered,
            int w, int h)
        {
            for (int i = 0; i < h; i++)
            {
                for (int j = 0; j < w; j++)
                {
                    if (costs[i, j] == 0 && !rowsCovered[i] && !colsCovered[j])
                        return new Location(i, j);
                }
            }
            return new Location(-1, -1);
        }

        private static int FindMinimum(int[,] costs, bool[] rowsCovered, bool[] colsCovered, int w, int h)
        {
            var minValue = int.MaxValue;
            for (int i = 0; i < h; i++)
            {
                for (int j = 0; j < w; j++)
                {
                    if (!rowsCovered[i] && !colsCovered[j])
                        minValue = Math.Min(minValue, costs[i, j]);
                }
            }
            return minValue;
        }

        private static int FindStarInRow(byte[,] masks, int w, int row)
        {
            for (int j = 0; j < w; j++)
            {
                if (masks[row, j] == 1)
                    return j;
            }
            return -1;
        }

        private static int FindStarInColumn(byte[,] masks, int h, int col)
        {
            for (int i = 0; i < h; i++)
            {
                if (masks[i, col] == 1)
                    return i;
            }
            return -1;
        }

        private static int FindPrimeInRow(byte[,] masks, int w, int row)
        {
            for (int j = 0; j < w; j++)
            {
                if (masks[row, j] == 2)
                    return j;
            }
            return -1;
        }

        private static void ClearCovers(bool[] rowsCovered, bool[] colsCovered, int w, int h)
        {
            for (int i = 0; i < h; i++)
                rowsCovered[i] = false;
            for (int j = 0; j < w; j++)
                colsCovered[j] = false;
        }

        private static void ClearPrimes(byte[,] masks, int w, int h)
        {
            for (int i = 0; i < h; i++)
            {
                for (int j = 0; j < w; j++)
                {
                    if (masks[i, j] == 2)
                        masks[i, j] = 0;
                }
            }
        }

        public static void scheduleArrayAssign()
        {
            MTAccess mA = new MTAccess();
            SqlCommand cmd = mA.GetCommand("SELECT * FROM Schedule");
            cmd.Connection.Open();

            SqlDataReader reader = cmd.ExecuteReader();
           
            int i = 0;
            int x = 0;
            using (reader)
            {
                while (reader.Read())
                {
                    scheduleArray[i, 0] = reader.GetInt32(1);
                    scheduleArray[i, 1] = reader.GetInt32(2);
                    scheduleArray[i, 2] = reader.GetInt32(3);
                    scheduleArray[i, 3] = reader.GetInt32(4);
                    scheduleArray[i, 4] = reader.GetInt32(5);
                    i++;
                }

            }

            var result = scheduleArray.FindAssignments();
            for (; x < result.Length; x++)
            {
                resultArray[x] = result[x];
            }

            cmd.Connection.Close();
        }

        private struct Location
        {
            public int Row;
            public int Column;

            public Location(int row, int col)
            {
                this.Row = row;
                this.Column = col;
            }
        }
    }



}
