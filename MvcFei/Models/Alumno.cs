﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcFei.Models
{
    public class Alumno
    {
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [Display(Name = "Matricula")]
        public string AlumnoId { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "El campo {0} debe ser una cadena con un minimo de {1} y un máximo de {2} caracteres.")]
        public string Nombre { get; set; }

        [Display(Name = "Fecha de Ingreso")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [DataType(DataType.Date, ErrorMessage = "El campo {0} de be ser una fecha")] //Solo para mostrar la fecha sin la hora
        public DateTime FechaIngreso { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [StringLength(8, ErrorMessage = "El campo {0} debe ser una cadena con un máximo de {1} y caracteres.")]
        public string Carrera { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [Range(1, 10, ErrorMessage ="El campo {0} debe ser un número con un mínimo de {1} y un máximo de {2}.")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Promedio { get; set; }


    }
}
