using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using TMGbe.Models;

namespace TMGbe.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TableController : ControllerBase
    {
        //setting the feature traceability table
         //Table<Component>feature_traceability_table = new Table<Component>("Traceability",null);
        // Table<Component>components_overview_table = new Table<Component>("Components Overview",null);
         Table<Component>table = new Table<Component>("Test",null);

         [HttpGet(Name = "GetTableData")]
        public IActionResult Get()
        {
            Response.Headers.Add("Access-Control-Allow-Origin", "*");
            Response.Headers.Add("Access-Control-Allow-Methods", "GET, POST, PUT, DELETE");
            Response.Headers.Add("Access-Control-Allow-Headers", "Content-Type, Authorization");
            
            string jsonResult = table.GenerateJsonFromTable(table);
            return Ok(jsonResult);
        }
    }
}