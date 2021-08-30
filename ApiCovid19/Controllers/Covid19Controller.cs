using Domain.Interfaces.InterfaceUsuario;
using Entities;
using Infra.Configuration;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCovid19.Controllers
{
    //[Authorize]
/*    [EnableCors("Cors")]
*/
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
                /*var client = new RestClient("https://covid-api.mmediagroup.fr/");
                var request = new RestRequest("v1/cases", Method.GET);
                var queryResult = client.Execute(request);
                var result = JsonConvert.DeserializeObject<Object>(queryResult.Content);
                var cache = new Cache()
                {
                    JsonResult = result.ToString(),
                    Date = DateTime.Now
                };
                await _ICache.Add(cache);*/
                var result =await _ICache.GetEntityById(1);
                return result.JsonResult;

            }
            catch (Exception ex)
            {

                throw;
            }
        }

        [HttpGet("/api/ListaCache")]
        public async Task<JsonResult> ListaCache()
        {
            return Json(await _ICache.List());
        }


        [HttpPost("/api/AdicionarCache")]
        public async Task AdicionarCache([FromBody] Cache Cache)
        {
            await Task.FromResult(_ICache.Add(Cache));
        }


    }
}
