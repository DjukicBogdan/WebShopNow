using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebShopClient.Models;

namespace WebShopClient.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PorudzbenicaController : ControllerBase
    {
        private readonly WebshopdbContext db;

        public PorudzbenicaController(WebshopdbContext _db)
        {
            db = _db;
        }
        [HttpGet]
        public IEnumerable<Porucbenica> VratiPorudzbenicu()
        {
            return db.Porucbenicas;
        }
    }
}