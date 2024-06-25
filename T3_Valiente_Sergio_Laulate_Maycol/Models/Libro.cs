using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Contracts;
namespace T3_Valiente_Sergio_Laulate_Maycol.Models
{
    public class Libro
    {
            [Key]
            public int Id { get; set; }

            [Required(ErrorMessage = "El Titulo es obligatorio.")]
            public string Titulo { get; set; }

            [Required(ErrorMessage = "El Autor es obligatorio.")]
            public string Autor { get; set; }

            [Required(ErrorMessage = "El Tema es obligatorio.")]
            public string Tema { get; set; }

            [Required(ErrorMessage = "La Editorial es obligatoria.")]
            public string Editorial { get; set; }

            [Required(ErrorMessage = "El Año de Publicación es obligatorio.")]
            [Range(1900, 3000, ErrorMessage = "El Año de Publicación debe estar entre 1900 y 3000.")]
            public int AnioPublicacion { get; set; }

            [Required(ErrorMessage = "El número de páginas es obligatorio.")]
            [Range(10, 1000, ErrorMessage = "El número de páginas debe estar entre 10 y 1000.")]
            public int Paginas { get; set; }
            }
        }