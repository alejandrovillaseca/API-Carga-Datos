using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CampañasFront.Models;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Net;
using System.IO;
using RestSharp;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace CampañasFront.Controllers
{
    public class HomeController : Controller
    {
        private string API = "http://localhost/CRM_APICampa%C3%B1as";
        public IActionResult Index()
        {
            //var DV = "K";
            //var RutSinDV = "52004146";
            //var TIP_CAMPANA = "5";
            //var TIP_PRODUCTO = "CP";
            //var TipodeFuncional = "EMPRESA";
            //var ID_WCM_WEB = "IOL_DAP_FORZADA_CAMPANA";

            //var client = new RestClient("http://localhost/CRM_APICampa%C3%B1as/api/origen");
            //var request = new RestRequest(Method.POST);
            //request.AddHeader("Postman-Token", "b5d8a1ea-2bfa-453c-aba1-8e99c74c73c0");
            //request.AddHeader("cache-control", "no-cache");
            //request.AddHeader("Content-Type", "application/json");
            //request.AddHeader("content-type", "multipart/form-data; boundary=----WebKitFormBoundary7MA4YWxkTrZu0gW");
            //request.AddParameter("multipart/form-data; boundary=----WebKitFormBoundary7MA4YWxkTrZu0gW", "------WebKitFormBoundary7MA4YWxkTrZu0gW\r\nContent-Disposition: form-data; name=\"DV\"\r\n\r\n" + DV + "\r\n------WebKitFormBoundary7MA4YWxkTrZu0gW\r\nContent-Disposition: form-data; name=\"RutSinDV\"\r\n\r\n" + RutSinDV + "\r\n------WebKitFormBoundary7MA4YWxkTrZu0gW\r\nContent-Disposition: form-data; name=\"TIP_CAMPANA\"\r\n\r\n" + TIP_CAMPANA + "\r\n------WebKitFormBoundary7MA4YWxkTrZu0gW\r\nContent-Disposition: form-data; name=\"TIP_PRODUCTO\"\r\n\r\n" + TIP_PRODUCTO + "\r\n------WebKitFormBoundary7MA4YWxkTrZu0gW\r\nContent-Disposition: form-data; name=\"TipodeFuncional\"\r\n\r\n" + TipodeFuncional + "\r\n------WebKitFormBoundary7MA4YWxkTrZu0gW\r\nContent-Disposition: form-data; name=\"ID_WCM_WEB\"\r\n\r\n" + ID_WCM_WEB + "\r\n------WebKitFormBoundary7MA4YWxkTrZu0gW--", ParameterType.RequestBody);
            //IRestResponse response = client.Execute(request);
            //var obj2 = JObject.Parse(response.Content);


            //ViewData["rut"] = obj2.SelectToken("origen").SelectToken("rut").ToString();


            return View(new Origen());
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }



        // recursively yield all children of json
        private static IEnumerable<JToken> AllChildren(JToken json)
        {
            foreach (var c in json.Children())
            {
                yield return c;
                foreach (var cc in AllChildren(c))
                {
                    yield return cc;
                }
            }
        }
        [HttpPost]
        public ActionResult GetOrigen(string RutSinDV, string DV, string IdCampañaCRM)
        {
            var _obj = new Origen();
            var listData = LlenaData();
            

            _obj.RutSinDV = RutSinDV;
            _obj.DV = DV;
            _obj.IdCampaña = IdCampañaCRM;

            var a = Origen(_obj);
            _obj.Observación = a;
            return View("Index", _obj);
        }

        public string Origen(Origen origen)
        {
            var client = new RestClient(API + "/api/origen");
            var request = new RestRequest(Method.POST);
            request.AddHeader("Postman-Token", "d2285174-f6b0-4a18-ac80-1bbc2f8903e8");
            request.AddHeader("cache-control", "no-cache");
            request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
            request.AddHeader("content-type", "multipart/form-data; boundary=----WebKitFormBoundary7MA4YWxkTrZu0gW");
            request.AddParameter("multipart/form-data; boundary=----WebKitFormBoundary7MA4YWxkTrZu0gW", "------WebKitFormBoundary7MA4YWxkTrZu0gW\r\nContent-Disposition: form-data; name=\"RutSinDV\"\r\n\r\n"+origen.RutSinDV+"\r\n------WebKitFormBoundary7MA4YWxkTrZu0gW\r\nContent-Disposition: form-data; name=\"DV\"\r\n\r\n"+origen.DV+"\r\n------WebKitFormBoundary7MA4YWxkTrZu0gW\r\nContent-Disposition: form-data; name=\"IdCampaña\"\r\n\r\n"+origen.IdCampaña+"\r\n------WebKitFormBoundary7MA4YWxkTrZu0gW--", ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);

            var obj2 = JObject.Parse(response.Content);

            var correcto = obj2.SelectToken("header").SelectToken("correcto").ToString();
            var obs = obj2.SelectToken("header").SelectToken("observación").ToString();


            return obs;
        }

        private List<Request> LlenaData()
        {
            var _obj = new List<Request>();
            _obj.Add(new Models.Request()
            {
                IdCampaña = "",
                RutConDV = ""
            });

            return _obj;
        }
    }
}
