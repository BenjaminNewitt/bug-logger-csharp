namespace BugLoggerC.Models
{
  public class Note
  {
    public string Content { get; set; }
    public int BugId { get; set; }
    public string ReportedBy { get; set; }
  }
}