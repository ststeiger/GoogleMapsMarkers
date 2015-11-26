
namespace Basic_SQL
{


    public class SQL
    {

        public static System.Data.DataTable GetDataTable(string strSQL)
        {
            System.Data.DataTable dt = new System.Data.DataTable();
            System.Data.SqlClient.SqlConnectionStringBuilder csb = new System.Data.SqlClient.SqlConnectionStringBuilder();

            csb.DataSource = System.Environment.MachineName;
            csb.DataSource = @"VMSTZHDB08\SZH_DBH_1";
            csb.InitialCatalog = "HBD_CAFM_V3";

            csb.IntegratedSecurity = true;


            using (System.Data.Common.DbDataAdapter da = new System.Data.SqlClient.SqlDataAdapter(strSQL, csb.ConnectionString))
            {
                da.Fill(dt);
            }

            return dt;
        }



        public static void Log(System.Exception ex)
        {
            System.Console.WriteLine(ex);
        } // End Sub Log 


    }


}
