using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPI.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public HttpResponseMessage Get()
        {
            DataTable dt = new DataTable();
            string query = @"fetch_data";
            using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["HELPDB"].ConnectionString))
            using (var cmd = new SqlCommand(query, con))
            using (var da = new SqlDataAdapter(cmd))
            {
                cmd.CommandType = CommandType.Text;
                da.Fill(dt);
            }
                return Request.CreateResponse(HttpStatusCode.OK, dt);
        }

        // GET api/values/5

        public HttpResponseMessage Get(int id)
        {
            DataTable dt = new DataTable();
            string query = @"FetchDataByID @ID="+id+"";
            using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["HELPDB"].ConnectionString))
            using (var cmd = new SqlCommand(query, con))
            using (var da = new SqlDataAdapter(cmd))
            {
                cmd.CommandType = CommandType.Text;
                da.Fill(dt);
            }
            return Request.CreateResponse(HttpStatusCode.OK, dt);
        }

       
    }
}
