using System;

namespace BugLoggerC.Models
{
  public class Bug
  {
    public int Id { get; set; }
    public bool IsClosed { get; set; }
    public string Description { get; set; }
    public string Title { get; set; }
    public string ReportedBy { get; set; }
    public DateTime closedDate { get; set; }
  }
}