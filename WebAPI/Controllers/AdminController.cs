using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAPI.Models;
using System.Net.Http;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace WebAPI.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
           string id = Request.QueryString["id"];

            IEnumerable<Class1> ec = null;  
            HttpClient hc = new HttpClient();
            hc.BaseAddress = new Uri("https://localhost:44388/api/");

            var consumedata = hc.GetAsync("Values/"+id+"");
            consumedata.Wait();

            var dataread = consumedata.Result;
            if (dataread.IsSuccessStatusCode)
            {
                var results = dataread.Content.ReadAsAsync<IList<Class1>>();
                results.Wait();
                ec = results.Result;
            }
            return View(ec);
        }
        public ActionResult Edit(int id )
        {
            IEnumerable<Class1> ec = null;
            HttpClient hc = new HttpClient();
            hc.BaseAddress = new Uri("https://localhost:44388/api/");

            var consumedata = hc.GetAsync("Values/"+id+"");
            consumedata.Wait();

            var dataread = consumedata.Result;
            if (dataread.IsSuccessStatusCode)
            {
                var results = dataread.Content.ReadAsAsync<IList<Class1>>();
                results.Wait();
                ec = results.Result;
            }
            return View(ec);
        }
        [HttpPost]
        public ActionResult Edit(Class1 data)
        {
            int ID = data.ID;
            int PageID = data.PageID;
            int ProjectID = data.ProjectID;
            string HelpTitle = data.HelpTitle;
            string HelpBody = data.HelpBody;
            DataTable dt = new DataTable();
            string query = @"execute update_data @PageID=" + PageID + ",@ProjectID=" + ProjectID + ",@HelpTitle='" + HelpTitle + "',@HelpBody='" + HelpBody + "',@ID=" + ID + "";
            using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["HELPDB"].ConnectionString))

            using (var cmd = new SqlCommand(query, con))
            using (var da = new SqlDataAdapter(cmd))
            {
                cmd.CommandType = CommandType.Text;
                da.Fill(dt);
            }

            return Redirect("/admin/index");
        }
        public ActionResult Delete(int id)
        {
            DataTable dt = new DataTable();
            string query = @"Delete_data @ID="+id+"";
            using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["HELPDB"].ConnectionString))
            using (var cmd = new SqlCommand(query, con))
            using (var da = new SqlDataAdapter(cmd))
            {
                cmd.CommandType = CommandType.Text;
                da.Fill(dt);
            }

            return Redirect("/admin/index");
        }


        


    }
}