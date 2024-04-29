using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc;

namespace OdraFlix.Models;

[Table("Movie")]
public class Movie 
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)] 
    public int Id { get; set; }

    [Display(Name = "Título Original")]
    [Required(ErrorMessage = "Por favor, infórme o título Original")]  
    [StringLength(100, ErrorMessage = "O título orinal deve possuir no maximo 100 caracteres")]  
    public string OriginalTitle { get; set; }

    [Display(Name = "title")]
    [Required(ErrorMessage = "Por favor, infórme o título Original")]  
    [StringLength(100, ErrorMessage = "O título deve possuir no maximo 100 caracteres")]  
    public string Title { get; set; }

    [Display(Name = "Sinopse")]
    [StringLength(8000, ErrorMessage = "A sinopse deve possuir no maximo 8000 caracteres")]  
    public string Synopsis { get; set; }

    [Column(TypeName = "Year")]
    [Display(Name = "Ano de Estreia")]
    [Required(ErrorMessage = "Por favor, informe o ano de estreia")]

    public Int16 MovieYear {get; set; }
}