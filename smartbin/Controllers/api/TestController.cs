using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using smartbin.Data;
using smartbin.Data.Models;
using Newtonsoft.Json;

namespace smartbin.Controllers.api
{
    [Produces("application/json")]
    [Route("api/Test")]
    public class TestController : Controller
    {
        private readonly ApplicationDbContext _db;
        public TestController(ApplicationDbContext db)
        {
            _db = db;
        }
        // GET: api/Test
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Test/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }
        
        // POST: api/Test
        [HttpPost]
        public void Post([FromBody]BinDetail value)
        {
            _db.bindetail_tbl.Add(value);
            _db.SaveChanges();
        }
        // POST: api/Test/get
        [HttpPost("get")]
        public IActionResult getBins([FromBody]TempResponse value)
        {
            try
            {
                List<BinDetail> dbObject = _db.bindetail_tbl.Where(x => x.binID == value.binID).ToList();
                return Content(JsonConvert.SerializeObject(dbObject, Formatting.Indented), "application/json");
            }
            catch(Exception e)
            {
                BinDetail dbObject = _db.bindetail_tbl.Where(x => x.binID == value.binID).First();
                return Content(JsonConvert.SerializeObject(dbObject.areaID, Formatting.Indented), "application/json");
            }
           
        }
        // PUT: api/Test/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }
        
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
    public class TempResponse
    {
        public string binID { get; set; }
        public string areaID { get; set; }
    }
}
