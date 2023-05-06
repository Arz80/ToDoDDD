using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DAL.Entities;

[DisplayColumn("Приоритет задачи")]
public class Priority : BaseEntity
{
    [Display(Name = "Прриоритет задачи")]
    [Required]
    public string? Name { get; set; } 
}
