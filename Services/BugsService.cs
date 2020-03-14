using System;
using System.Collections.Generic;
using BugLoggerC.Models;
using BugLoggerC.Repositories;

namespace BugLoggerC.Services
{
  public class BugsService
  {
    private readonly BugsRepository _repo;
    public BugsService(BugsRepository repo)
    {
      _repo = repo;
    }
    internal IEnumerable<Bug> Get()
    {
      return _repo.Get();
    }
  }
}