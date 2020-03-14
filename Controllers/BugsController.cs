using Microsoft.AspNetCore.Mvc;
using BugLoggerC.Services;
using BugLoggerC.Models;
using System.Collections.Generic;
using System;

namespace BugLoggerC.Controlelrs
{
  [ApiController]
  [Route("api/[controller]")]
  public class BugsController : ControllerBase
  {
    private readonly BugsService _bs;
    public BugsController(BugsService bs)
    {
      _bs = bs;
    }
    [HttpGet]
    public ActionResult<IEnumerable<Bug>> GetAllBugs()
    {
      try
      {
        return Ok(_bs.Get());
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }
    [HttpGet("{id}")]
    public ActionResult<Bug> GetBugById(int id)
    {
      try
      {
        return Ok(_bs.GetBugById(id));
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }
    [HttpPost]
    public ActionResult<Bug> CreateBug([FromBody] Bug newBug)
    {
      try
      {
        return Ok(_bs.CreateBug(newBug));
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }
    [HttpPut("{id}")]
    public ActionResult<Bug> EditBug([FromBody] Bug BugData)
    {
      try
      {
        return Ok(_bs.EditBug(BugData));
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }
  }
}