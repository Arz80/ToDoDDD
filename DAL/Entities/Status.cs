using System.ComponentModel.DataAnnotations;

namespace DAL.Entities;

[DisplayColumn("Статус")]
public class Status : BaseEntity
{
    [Display(Name = "Статус задачи")]
    [Required]
    public string? Name { get; set; }
}
