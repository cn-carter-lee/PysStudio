using System;
using System.Data;
using System.Configuration;
using System.Data.OleDb;
using System.Collections.Generic;
using System.Web;

/// <summary>
/// DB 的摘要说明
/// </summary>

namespace Pys.Data
{
    public class PysDataBase
    {
        public static OleDbConnection GetConn()
        {
            OleDbConnection conn = new OleDbConnection();
            System.IO.DirectoryInfo directoryInfo = new System.IO.DirectoryInfo(HttpContext.Current.Server.MapPath(@"~\"));
            string strDatabaseFilePath = directoryInfo.Parent.FullName + @"\Pys.Studio.Web\App_Data\mysite.mdb";
            conn.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data source=" + strDatabaseFilePath;
            return conn;
        }

        public static OleDbDataReader GetDataReader(string cmdstr)
        {
            OleDbConnection conn = GetConn();
            conn.Open();
            OleDbCommand comm = new OleDbCommand(cmdstr, conn);
            OleDbDataReader dr = comm.ExecuteReader(CommandBehavior.CloseConnection);
            return dr;
        }

        public static int ExecuteOleDb(string strOleDb)
        {
            OleDbConnection conn = GetConn();
            try
            {
                conn.Open();
                OleDbCommand comm = new OleDbCommand(strOleDb, conn);
                return comm.ExecuteNonQuery();
            }
            finally
            {
                conn.Close();
            }
        }

        public static int GetResults(string strOleDb)
        {
            OleDbConnection conn = GetConn();
            try
            {
                conn.Open();
                OleDbCommand comm = new OleDbCommand(strOleDb, conn);
                return Convert.ToInt32(comm.ExecuteScalar());
            }
            finally
            {
                conn.Close();
            }
        }

        public static string GetSingleResult(string strOleDb)
        {
            string strResult = "";
            OleDbConnection conn = GetConn();
            try
            {
                conn.Open();
                OleDbCommand comm = new OleDbCommand(strOleDb, conn);
                strResult = comm.ExecuteScalar().ToString();
                return strResult;
            }
            finally
            {
                conn.Close();
            }
        }

        public static DataSet GetDataSet(string strOleDb)
        {
            DataSet ds = new DataSet();
            OleDbConnection conn = GetConn();
            try
            {
                OleDbDataAdapter adp = new OleDbDataAdapter(strOleDb, conn);
                adp.Fill(ds);
                return ds;
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                    conn.Dispose();
                }
            }
        }

        public static DataTable GetDataTable(string strOleDb)
        {
            DataTable dt = new DataTable();
            OleDbConnection conn = GetConn();
            try
            {
                OleDbDataAdapter adp = new OleDbDataAdapter(strOleDb, conn);
                adp.Fill(dt);
                return dt;
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                    conn.Dispose();
                }
            }
        }

        public static string SGetSingle(string strsql, string para, string paravalue)
        {
            OleDbConnection conn = GetConn();
            try
            {
                conn.Open();
                OleDbCommand comm = new OleDbCommand(strsql, conn);
                comm.Parameters.AddWithValue(para, paravalue);
                string result = comm.ExecuteScalar().ToString();
                return result;
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                    conn.Dispose();
                }
            }
        }

        /// <summary>
        /// 获取网站内容信息
        /// </summary>
        /// <param name="name">每个页对应参数</param>
        /// <returns></returns>
        public static string GetSiteInfo(string name)
        {
            OleDbConnection conn = GetConn();
            try
            {
                conn.Open();
                OleDbCommand comm = new OleDbCommand("select content from sitecontent where name=@name", conn);
                comm.Parameters.AddWithValue("@name", name);
                string result = comm.ExecuteScalar().ToString();
                return result;
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                    conn.Dispose();
                }
            }
        }

        public static int Execute(string commandString, OleDbParameter[] parameters)
        {
            int result = 0;
            OleDbConnection conn = GetConn();
            conn.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = conn;
            command.CommandText = commandString;
            if (parameters != null)
            {
                foreach (OleDbParameter param in parameters)
                {
                    command.Parameters.Add(param);
                }
            }
            result = command.ExecuteNonQuery();
            if (conn != null)
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                    conn.Dispose();
                }
            }
            return result;
        }

        public static int ExecuteOleDB(string strOleDb, List<PysDatabaseParameter> parameters)
        {
            int i = 0;
            OleDbConnection conn = GetConn();
            try
            {
                conn.Open();
                OleDbCommand comm = new OleDbCommand(strOleDb, conn);
                comm.Connection = conn;
                comm.CommandText = strOleDb;
                foreach (PysDatabaseParameter p in parameters)
                {
                    comm.Parameters.AddWithValue("@" + p.Name, p.Value);
                }
                i = comm.ExecuteNonQuery();
            }
            catch
            {
                i = 0;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                    conn.Dispose();
                }
            }
            return i;
        }
    }
}