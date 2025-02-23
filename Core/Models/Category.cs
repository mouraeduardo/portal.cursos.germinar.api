﻿namespace Core.Models;

public class Category : BaseModel
{
    public string Name { get; set; }
    public string Description { get; set; }
    public List<Course> CourseList { get; set; }
}
