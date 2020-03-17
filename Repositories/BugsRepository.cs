using System;
using System.Collections.Generic;
using System.Data;
using BugLoggerC.Models;
using Dapper;

namespace BugLoggerC.Repositories
{

  public class BugsRepository
  {

    private readonly IDbConnection _db;

    public BugsRepository(IDbConnection db)
    {
      _db = db;
    }
    internal IEnumerable<Bug> GetAllBugs()
    {
      string sql = "SELECT * FROM bugs";
      return _db.Query<Bug>(sql);
    }

    internal Bug GetBugById(int id)
    {
      string sql = "SELECT * FROM bugs WHERE id = @id";
      return _db.QueryFirstOrDefault<Bug>(sql, new { id });
    }

    internal Bug CreateBug(Bug newBug)
    {
      throw new NotImplementedException();
    }

    internal void EditBug(Bug update)
    {
      throw new NotImplementedException();
    }

    internal void DeleteBug(int id)
    {
      throw new NotImplementedException();
    }
  }
}