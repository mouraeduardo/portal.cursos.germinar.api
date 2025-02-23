namespace Core.Models;

public class Class : BaseModel
{
    public string Name { get; set; }
    public string Description { get; set; }
    public int ModuleId { get; set; }
    public Module Module { get; set; }
}
