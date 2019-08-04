using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entities;
using GKBusinessLayer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GKWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LabelController : ControllerBase
    {

        // create a refrence of IkeepService and initialize it.
        private readonly IKeepLabelService ikeepLabelService;

        public LabelController(IKeepLabelService keep)
        {
            ikeepLabelService = keep;
        }



        // GET: api/Label
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(ikeepLabelService.GetLabels());
        }


        // GET: api/Label/5
        //[HttpGet("{id}")]
        //public IActionResult Get(int id)
        //{
        //    return 
        //}


        // POST: api/Label
        [HttpPost]
        public IActionResult Post([FromBody] Label label)
        {
            return Created("api/Label",ikeepLabelService.CreateLabel(label));
        }



        // PUT: api/Label/5
        [HttpPut]
        public IActionResult Put([FromBody] Label label)
        {
            return Ok(ikeepLabelService.UpdateLabel(label));
        }



        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok(ikeepLabelService.RemoveLabel(id));
        }
    }
}
