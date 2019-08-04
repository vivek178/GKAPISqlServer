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
    public class NotesController : ControllerBase
    {

        // create a refrence of service Interface and initialize it.
        private readonly IKeepNoteService keepNoteService;
        public NotesController(IKeepNoteService noteService)
        {
            keepNoteService = noteService;
        }


        // GET: api/Notes
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(keepNoteService.GetAllNotes());
            }
            catch (Exception exp)
            {

                return NotFound(exp.Message);
            }
        }



        // GET: api/Notes/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            try
            {
                return Ok(keepNoteService.GetNotesByID(id));
            }
            catch (Exception exp)
            {
                return NotFound(exp.Message);
                
            }
        }

        // POST: api/Notes
        [HttpPost]
        public IActionResult Post([FromBody] Notes notes)
        {
            try
            {
                return Created("api/Notes",keepNoteService.CreateNote(notes));
            }
            catch (Exception exp)
            {

                return NotFound(exp.Message);
            }
        }

        // PUT: api/Notes/5
        [HttpPut("{id}")]
        public IActionResult Put([FromBody] Notes notes)
        {
            try
            {
                return Ok(keepNoteService.UpdateNote(notes));
            }
            catch (Exception exp)
            {
                return NotFound(exp.Message);
            }
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                return Ok(keepNoteService.RemoveNote(id));
            }
            catch (Exception exp)
            {
                return NotFound(exp.Message);
            }
        }
    }
}
