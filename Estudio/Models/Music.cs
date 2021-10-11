using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Estudio.Models
{
        public class Music
    {
        [Key]
        public int MusicId { get; set; }
        
        
        
        [Required(ErrorMessage = "el nombre de la cancion es requerido")]
        [StringLength(60, MinimumLength = 5, ErrorMessage = "el nombre de la cancion debe estar entre 5 y 60 caracteres")]
        [Display (Name = "nombre de la cancion")]
        public string Nombre { get; set; }
       
        
     
        [Required(ErrorMessage = "el nombre del autor es requerido")]
        [StringLength(60, MinimumLength = 5, ErrorMessage = "el nombre del autor debe estar entre 5 y 60 caracteres")]
        [Display(Name = "nombre del autor")]
        public string Autor { get; set; }


        [Required(ErrorMessage = "letra de la cancion")]
        [StringLength(60, MinimumLength = 5, ErrorMessage = "letra de la cancion")]
        [Display(Name = "link de la letra  de la cancion")]
        public string Letra { get; set; }
    }
}
