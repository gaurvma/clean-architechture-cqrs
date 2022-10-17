
using System;

namespace  CleanArch.Domain.Entities;

public class Article{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string ArticleBody { get; set; }
    public int CategoryId { get; set; }
    public int CreatedBy { get; set; }
    public DateTime CreatedOn { get; set; }

    public virtual Category Category { get; set; }
}