using System.ComponentModel.DataAnnotations;

namespace DAL.Entities;

//[DisplayColumn("Приоритет задачи")]
public class Priority : BaseEntity
{
    //[Display(Name = "Прриоритет задачи")]
    //[Required]
    public string? Name { get; set; } 
}
