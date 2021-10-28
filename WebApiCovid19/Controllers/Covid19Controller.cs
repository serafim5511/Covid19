using Domain.Interfaces.InterfaceUsuario;
using Entities;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiCovid19.Controllers
{
    public class Covid19Controller : Controller
    {
        private readonly ICache _ICache;

        public Covid19Controller(ICache ICache)
        {
            _ICache = ICache;
        }

        [HttpGet("/api/Get")]
        public async Task<Object> Get()
        {
            try
            {
                var recente = await _ICache.Recente();

                if (String.IsNullOrEmpty(recente?.JsonResult) || recente?.JsonResult == "false")
                {
                    var client = new RestClient("https://covid-api.mmediagroup.fr/");
                    var request = new RestRequest("v1/cases", Method.GET);
                    var queryResult = client.Execute(request);
                    var result = JsonConvert.DeserializeObject<Object>(queryResult.Content);
                    var cache = new Cache()
                    {
                        JsonResult = result.ToString(),
                        Date = DateTime.Now
                    };
                    await _ICache.Add(cache);
                    return result;
                }

                return recente.JsonResult;
            }
            catch (Exception ex)
            {
                return 500;
            }
        }
    }
}
