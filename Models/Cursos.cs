﻿namespace Matriculas.Models
{
    public class Cursos
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string  Descripcion { get; set; }
        public List<Asistencia> Asistencias { get;set; }
    }
}
