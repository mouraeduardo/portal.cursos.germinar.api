namespace Core.Models;

public class Course : BaseModel
{
    public string Name { get; set; }
    public string Description { get; set; }
    public int Difficulty { get; set; }
    public string Instructor { get; set; }
    public DateTime Timing { get; set; }
    public string Thumbnail { get; set; }
    public int CategoryId { get; set; }
    public Category Category { get; set; }
    public List<Module> ModuleList { get; set; }
}
