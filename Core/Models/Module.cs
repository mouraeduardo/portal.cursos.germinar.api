namespace Core.Models;

public class Module : BaseModel
{
    public string Nome { get; set; }
    public string Description { get; set; }
    public int CourseId { get; set; }
    public Course Course { get; set; }
    public List<Class> ClassList { get; set; }
} 
