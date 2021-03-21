using DepremWebServisi.Depo;
using DepremWebServisi.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace DepremWebServisi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DepremController : ControllerBase
    {


        private readonly IDepremDepo _depremdepo;

        public DepremController(IDepremDepo depo)
        {
            
            _depremdepo = depo;
        }
    


        public IEnumerable<Deprem> GetAll()
        {
            var result = _depremdepo.GetAll();

                return result;
        }

        [HttpGet("{eventId}")]
        public Deprem GetById(long eventId)
        {
            
            return _depremdepo.GetWithEventID(eventId);
        }

        [Route("{Add}")]
        [HttpPost]
        public OkObjectResult AddNew(Deprem Deprem)
        {

            _depremdepo.Add(Deprem);
            _depremdepo.SaveChanges();

            return Ok(Deprem);
        }


    }
}
