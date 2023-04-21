using System;
using Microsoft.AspNetCore.Mvc;
using StadiumApi.Models;
using StadiumApi.Services.VisitorService;

namespace StadiumApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VisitorsController
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

            return result;
        }
    }
}