namespace Prog5_clase1_2025.Models
{
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

        public class Estudiante
        {
            [Required]
            public int Id { get; set; }
            [DisplayName("Nombre completo")]
            public string Nombre { get; set; }
            public int Nota { get; set; }

            public Estudiante(int id, string nombre, int nota)
            {
                Id = id;
                Nombre = nombre;
                Nota = nota;
            }
        }
    }
