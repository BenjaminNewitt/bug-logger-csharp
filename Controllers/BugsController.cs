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
    public ActionResult<IEnumerable<Bug>> Get()
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
  }
}