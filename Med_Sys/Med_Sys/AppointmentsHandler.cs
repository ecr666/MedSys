using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Med_Sys.DataAccess;

namespace Med_Sys
{
    class AppointmentsHandler
    {
        //import the whole grid
        private Connection con;

        public AppointmentsHandler()
        {
            con = new Connection();
        }

        public DataSet refreshDB()
        {
            //SqlConnection connection = dataConnection.conOpen();
            con.conOpen();
            //SqlDataAdapter sda = new SqlDataAdapter("select * from Appointments", connection);
            SqlDataAdapter sda = con.getSqlDataAdapter("select * from Appointments");
            DataSet DS = new DataSet();
            sda.Fill(DS);
            //dataGridView1.DataSource = DS.Tables[0];
            return DS;
        }


    }
}
