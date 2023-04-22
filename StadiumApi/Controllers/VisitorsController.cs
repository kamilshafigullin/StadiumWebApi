using System;
using Microsoft.AspNetCore.Mvc;
using StadiumApi.Models;
using StadiumApi.Services.VisitorService;

namespace StadiumApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VisitorsController : ControllerBase
    {
        #region Fields

        IVisitorService visitorService;

        #endregion

        #region ctor

        public VisitorsController(IVisitorService visitorService)
        {
            this.visitorService = visitorService;
        }

        #endregion

        [HttpGet]
        public async Task<ActionResult<List<Visitor>>> GetVisitors()
        {
            var result = await visitorService.GetVisitors();

            return Ok(result);
        }

        //[HttpGet(Name = "Search")]
        //public async Task<ActionResult<List<Visitor>>> SearchVisitor(string name = null, int? fromAge = null, int? toAge = null)
        //{
        //    var result = await visitorService.SearchVisitor(name, fromAge,  toAge);

        //    return Ok(result);
        //}

        [HttpPost]
        public async Task<ActionResult<string>> AddVisitor(Visitor visitor)
        {
            var result = await visitorService.AddVisitor(visitor);

            return Ok(result);
        }

        [HttpPut]
        public async Task<ActionResult<Visitor>> UpdateVisitor(int id, Visitor visitor)
        {
            if (visitor == null)
                return BadRequest();

            var result = await visitorService.AddVisitor(visitor);

            return Ok(result);
        }

        [HttpDelete]
        public async Task<ActionResult<string>> DeleteVisitor(int id)
        {
            var result = await visitorService.DeleteVisitor(id);
            if (result == null)
                return NotFound("Doesn't exist");

            return Ok(result);
        }

        [HttpGet]
        public async Task<ActionResult<Ticket>> GetTicket()
        {

        }
    }
}