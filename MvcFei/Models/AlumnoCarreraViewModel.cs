using Microsoft.AspNetCore.Mvc.Rendering;

namespace MvcFei.Models
{
    public class AlumnoCarreraViewModel
    {
        // Lista de alumnos
        public List<Alumno> Alumnos { get; set; }   

        // Lista de carreras para seleccionar
        public SelectList Carreras { get; set; }

        // Carrerar seleccionada
        public string? AlumnoCarrera { get; set; }

        // Texto que los usuarios escriben en ele cuadro de texto de busqueda
        public string? SearchString { get; set; }
    }
}
