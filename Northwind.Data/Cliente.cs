using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Northwind.Data
{
  [Table("Cliente")]
  public class Cliente
  {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid Id { get; set; }

    [Required]
    [MaxLength(50)]
    public string Nome { get; set; }

    [Required]
    [MaxLength(50)]
    public string Sobrenome { get; set; }
  }
}
