using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace readTextFileAndDatabase
{
    public class SQLConn
    {

        /*
         Title: Demonstrating coding program using c#; 
         Purposed: oop database connection
         Created by: Liston Sitorus
         Created Date: 01 October 2018

             */

        private static string ConnStrVal;
         
        public void getConnStrVal(string ConnStrServer,string ConnStrDb,string ConnStrUserId, string ConnStrPswd)
        {
            ConnStrVal= "server=" + ConnStrServer + "; database=" + ConnStrDb + "; user=" + ConnStrUserId + "; pwd=" + ConnStrPswd +" ;";
        } 

        private static SqlConnection DbCon = new SqlConnection(ConnStrVal); 
        private static SqlCommand DBCmd;

        //DB Data
        public SqlDataAdapter DBDA;
        public DataTable DBDT = new DataTable();

        //Parameter passing
        public List<SqlParameter> Params = new List<SqlParameter>();

        // Query Statitistic
        public int RecordCount;
        public string ExceptionErr;

        public SQLConn() { }

        //Allow Connection String Override
        public SQLConn(string connectionString)
        {
            DbCon = new SqlConnection(connectionString);
        }

        //Execute query sum
        public void ExecuteQuery(String Query)
        {
            //Reset Query Stats
            RecordCount = 0;
            ExceptionErr = "";
            try
            {
                // redefined Sql Connection 
                DbCon = new SqlConnection(ConnStrVal);
                DbCon.Open();

                //Create DB Command
                DBCmd = new SqlCommand(Query, DbCon);

                //check and get parameter
                Params.ForEach(p => DBCmd.Parameters.Add(p));
                //Clear Parameter list
                Params.Clear();

                //execute command and fill dataset into data table
                DBDT = new DataTable();
                DBDA = new SqlDataAdapter(DBCmd);
                RecordCount = DBDA.Fill(DBDT);

            }
            catch (Exception er)
            {
                ExceptionErr = "ExecQuery Error: " + Environment.NewLine + er.Message;
            }
            finally
            {
                //Close conection                              
                if (DbCon.State == ConnectionState.Open) DbCon.Close();

            }
        }

        public string getExceptionErr
        {
            get { return ExceptionErr; }
            set { ExceptionErr = value; }
        }

        //add params
        public void AddParam(string name, Object value)
        {
            SqlParameter NewParam = new SqlParameter(name, value);
            Params.Add(NewParam);
        }

        // Error checking
        public Boolean HasException(bool Report = false)
        {
            Boolean check = true;
            if (string.IsNullOrEmpty(ExceptionErr)) check = false;
            return check;
        }
    }
}
