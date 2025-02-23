using System.ComponentModel.DataAnnotations;

namespace Matriculas.Models
{
    public class Asistencia
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public DateTime FechaAsistencia { get; set; }

        [Required]
        [MaxLength(25)]
        public string Estado { get; set; }


        public int EstudianteId { get; set; }
        public Estudiantes Estudiante { get; set; }
        public int CursoId { get; set; }
        public Cursos Curso { get; set; }

    }
}
