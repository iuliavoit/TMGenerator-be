using Microsoft.AspNetCore.Mvc;
using TMGbe.Models;

namespace TMGbe.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TableController : ControllerBase
    {
        
         static  Table<Component> table = new Table<Component>("Test",null);
         string jsonResult = table.GenerateJsonFromTable(table);
         [HttpGet(Name = "GetTableData")]
        public IActionResult Get()
        {
            Response.Headers.Add("Access-Control-Allow-Origin", "*");
            Response.Headers.Add("Access-Control-Allow-Methods", "GET, POST, PUT, DELETE");
            Response.Headers.Add("Access-Control-Allow-Headers", "Content-Type, Authorization");
            
            
            return Ok(jsonResult);
        }
    }
}