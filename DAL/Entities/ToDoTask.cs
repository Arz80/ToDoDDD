using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DAL.Entities;

public class ToDoTask : BaseEntity
{
    [Display(Name = "Наименование задачи")]
    [Required]
    public string? Name { get; set; }
    [Display(Name = "Описание задачи")]
    [Required]
    [DataType(DataType.MultilineText)]
    public string? Description { get; set; }

    [Required]
    [Display(Name = "Статус")]
    public Guid StatusId { get; set; }
    [Display(Name = "Статус")]
    public virtual Status? Status { get; set; }
    [Required]
    [Display(Name = "Приоритет")]
    public Guid PriorityId { get; set; }
    [Display(Name = "Приоритет")]
    public virtual Priority? Priority { get; set; }
}
