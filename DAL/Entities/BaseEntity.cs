using System.ComponentModel.DataAnnotations;

namespace DAL.Entities;
public abstract class BaseEntity
{
    [Key]
    public Guid Id { get; set; }
}
