namespace TMGbe.Models;

public class Commit
{
    public string Id { get; set; }
    public string Message { get; set; }
    public DateTime AuthorDate { get; set; }
    public DateTime CommitterDate { get; set; }
    public List<Commit> Children { get; set; }
    public List<Change> Changes { get; set; }
}