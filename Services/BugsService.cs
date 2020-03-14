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
      return _repo.GetAllBugs();
    }

    internal Bug GetBugById(int id)
    {
      Bug exists = _repo.GetBugById(id);
      if (exists == null)
      {
        throw new Exception("Invalid ID");
      }
      return exists;
    }

    internal Bug CreateBug(Bug newBug)
    {
      return _repo.CreateBug(newBug);
    }
  }
}