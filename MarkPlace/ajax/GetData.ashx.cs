
namespace MarkPlace.ajax
{


    /// <summary>
    /// Zusammenfassungsbeschreibung für GetData
    /// </summary>
    public class GetData : System.Web.IHttpHandler
    {

        public void ProcessRequest(System.Web.HttpContext context)
        {
            context.Response.ContentType = "application/json";
            
            Newtonsoft.Json.JsonTextWriter jsonWriter = new Newtonsoft.Json.JsonTextWriter(context.Response.Output);
            Newtonsoft.Json.JsonSerializer ser = new Newtonsoft.Json.JsonSerializer();

            using (System.Data.DataTable dt = Basic_SQL.SQL.GetDataTable("SELECT COL_Hex FROM T_SYS_ApertureColorToHex ORDER BY COL_Aperture"))
            {
                jsonWriter.Formatting = Newtonsoft.Json.Formatting.Indented;
                ser.Serialize(jsonWriter, dt);
                jsonWriter.Flush();
            } // End Using dt 

        } // End Sub ProcessRequest 


        public bool IsReusable
        {
            get
            {
                return false;
            }
        } // End Property IsReusable 


    } // End Class GetData 


} // End Namespace MarkPlace.ajax 
