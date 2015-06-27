using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTdbFramework
{
    public class MTAccess
    {
        const string ConnStr = "Data Source=(LocalDB)\\v11.0;AttachDbFilename=F:\\C#\\tawhid\\ManagementTools.mdf;Integrated Security=True;Connect Timeout=30";
        public SqlCommand GetCommand(string query)
        {
            var connection= new SqlConnection(ConnStr);
            SqlCommand cmd =new SqlCommand(query);
            cmd.Connection =connection;
            return cmd;
        }
    }
}