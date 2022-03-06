using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using phuchunghome.com.Service;
using System.Data.SqlClient;

namespace phuchunghome.com.Service
{
    public class DatabaseConnection
    {
        private static DatabaseConnection instance;
        public static DatabaseConnection Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new DatabaseConnection();
                }
                return instance;
            }
        }

        public DatabaseConnection() { }

        public DataTable ExcuteTest()
        {
            DataTable list = new DataTable();
            using (SqlConnection con = new SqlConnection(Constant.connectionString))
            {
                con.Open();
                SqlCommand command = new SqlCommand("proctest", con);
                command.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(list);
                con.Close();
                return list;

            }
        }

        public List<Dictionary<string, object>> GetTableRows(DataTable dtData)
        {
            List<Dictionary<string, object>>
            lstRows = new List<Dictionary<string, object>>();
            Dictionary<string, object> dictRow = null;

            foreach (DataRow dr in dtData.Rows)
            {
                dictRow = new Dictionary<string, object>();
                foreach (DataColumn col in dtData.Columns)
                {
                    dictRow.Add(col.ColumnName, dr[col]);
                }
                lstRows.Add(dictRow);
            }
            return lstRows;
        }

        
    }
}