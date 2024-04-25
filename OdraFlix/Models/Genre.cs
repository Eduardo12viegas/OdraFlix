using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OdraFlix.Models;

[Table("Genre")]
public class Genre
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public byte id { get; set; }

    [Display(Name = "Nome")]
    public string Name { get; set;}
}

