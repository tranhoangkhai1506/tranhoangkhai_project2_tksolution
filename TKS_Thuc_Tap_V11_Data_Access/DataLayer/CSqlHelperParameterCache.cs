using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Configuration;
using TKS_Thuc_Tap_V11_Data_Access.Utility;

namespace TKS_Thuc_Tap_V11_Data_Access.DataLayer
{
    public class CSqlHelperParameterCache
    {
        //*********************************************************************
        //
        // Since this class provides only static methods, make the default constructor private to prevent 
        // instances from being created with "new SqlHelperParameterCache()".
        //
        //*********************************************************************

        private CSqlHelperParameterCache() { }

        private static Hashtable paramCache = Hashtable.Synchronized(new Hashtable());

        //*********************************************************************
        //
        // resolve at run time the appropriate set of SqlParameters for a stored procedure
        // 
        // param name="connectionString" a valid connection string for a SqlConnection 
        // param name="spName" the name of the stored procedure 
        // param name="includeReturnValueParameter" whether or not to include their return value parameter 
        //
        //*********************************************************************

        private static SqlParameter[] DiscoverSpParameterSet(string connectionString, string spName, bool includeReturnValueParameter)
        {
            SqlConnection cn = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(spName, cn);
            SqlParameter[] discoveredParameters;

            try
            {
                cn.Open();
                cmd.CommandType = CommandType.StoredProcedure;

                SqlCommandBuilder.DeriveParameters(cmd);

                if (!includeReturnValueParameter)
                {
                    cmd.Parameters.RemoveAt(0);
                }

                discoveredParameters = new SqlParameter[cmd.Parameters.Count]; ;

                cmd.Parameters.CopyTo(discoveredParameters, 0);
            }

            catch (Exception)
            {
                throw;
            }

            finally
            {
                cn.Close();
                cmd.Dispose();
            }

            return discoveredParameters;
        }

        private static SqlParameter[] CloneParameters(SqlParameter[] originalParameters)
        {
            //deep copy of cached SqlParameter array
            SqlParameter[] clonedParameters = new SqlParameter[originalParameters.Length];

            for (int i = 0, j = originalParameters.Length; i < j; i++)
            {
                clonedParameters[i] = (SqlParameter)((ICloneable)originalParameters[i]).Clone();
            }

            return clonedParameters;
        }

        //*********************************************************************
        //
        // add parameter array to the cache
        //
        // param name="connectionString" a valid connection string for a SqlConnection 
        // param name="commandText" the stored procedure name or T-SQL command 
        // param name="commandParameters" an array of SqlParamters to be cached 
        //
        //*********************************************************************

        public static void CacheParameterSet(string connectionString, string commandText, params SqlParameter[] commandParameters)
        {
            string hashKey = connectionString + ":" + commandText;

            paramCache[hashKey] = commandParameters;
        }

        //*********************************************************************
        //
        // Retrieve a parameter array from the cache
        // 
        // param name="connectionString" a valid connection string for a SqlConnection 
        // param name="commandText" the stored procedure name or T-SQL command 
        // returns an array of SqlParamters
        //
        //*********************************************************************

        public static SqlParameter[] GetCachedParameterSet(string connectionString, string commandText)
        {
            string hashKey = connectionString + ":" + commandText;

            SqlParameter[] cachedParameters = (SqlParameter[])paramCache[hashKey];

            if (cachedParameters == null)
            {
                return null;
            }
            else
            {
                return CloneParameters(cachedParameters);
            }
        }

        //*********************************************************************
        //
        // Retrieves the set of SqlParameters appropriate for the stored procedure
        // 
        // This method will query the database for this information, and then store it in a cache for future requests.
        // 
        // param name="connectionString" a valid connection string for a SqlConnection 
        // param name="spName" the name of the stored procedure 
        // returns an array of SqlParameters
        //
        //*********************************************************************

        public static SqlParameter[] GetSpParameterSet(string connectionString, string spName)
        {
            return GetSpParameterSet(connectionString, spName, false);
        }

        //*********************************************************************
        //
        // Retrieves the set of SqlParameters appropriate for the stored procedure
        // 
        // This method will query the database for this information, and then store it in a cache for future requests.
        // 
        // param name="connectionString" a valid connection string for a SqlConnection 
        // param name="spName" the name of the stored procedure 
        // param name="includeReturnValueParameter" a bool value indicating whether the return value parameter should be included in the results 
        // returns an array of SqlParameters
        //
        //*********************************************************************

        public static SqlParameter[] GetSpParameterSet(string connectionString, string spName, bool includeReturnValueParameter)
        {
            string hashKey = connectionString + ":" + spName + (includeReturnValueParameter ? ":include ReturnValue Parameter" : "");

            SqlParameter[] cachedParameters;

            cachedParameters = (SqlParameter[])paramCache[hashKey];

            if (cachedParameters == null)
            {
                cachedParameters = (SqlParameter[])(paramCache[hashKey] = DiscoverSpParameterSet(connectionString, spName, includeReturnValueParameter));
            }

            return CloneParameters(cachedParameters);
        }
    }
}
