using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Fragment.NetSlum.Persistence.Entities;

public class BbsThread
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    public ushort CategoryId { get; set; }
    public BbsCategory Category { get; set; } = default!;

    public required string Title { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}
