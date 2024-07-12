    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;
namespace GeoAutoRunner
{
    public class Db
    {
        MySqlConnection con = null;
        MySqlCommand cmd = null;

        public Db()
        {
            con = new MySqlConnection("server=sg2nlmysql35plsk.secureserver.net;port=3306;database=ph12562338564_be90;user id=usrmilitary;pwd=Bc68@8ru");
            con.Open();
            cmd = new MySqlCommand();
            cmd.Connection = con;
        }

        public bool isExists(string  name)
        {
            cmd.CommandText = string.Format("select count(*) from soldiers where pname = '{0}'", name);
            return int.Parse(cmd.ExecuteScalar().ToString()) != 0 ? true : false;
        }


        public DataTable getPatient(string name)
        {
            MySqlDataAdapter adap = new MySqlDataAdapter(cmd);
            adap.SelectCommand.CommandText = string.Format("select * from soldiers where pname = '{0}'", name);
            DataTable buffer = new DataTable();
            adap.Fill(buffer);
            return buffer;
        }

        public DataTable getRecords(string tablename)
        {
            MySqlDataAdapter adap = new MySqlDataAdapter(cmd);
            adap.SelectCommand.CommandText = string.Format("select * from " + tablename);
            DataTable buffer = new DataTable();
            adap.Fill(buffer);
            return buffer;
        }


        public void delrec(string name)
        {
            string sql = string.Format("DELETE FROM soldiers WHERE pname = '{0}'", name);
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
        }

        public void delfcm(string slno)
        {
            string sql = string.Format("DELETE FROM fcm WHERE slno = {0}", slno);
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
        }
 
        public bool saveRecord(string name, string dist, string origin)
        {
            bool status = false;
            try
            {
                string sql = string.Format("insert into soldiers( pname ,geodistance, origin ) values('{0}', '{1}', '{2}')", name, dist, origin);
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                status = true;
            }
            catch (Exception e)
            {

            }
            return status;
        }

    }
}
