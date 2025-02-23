using System.ComponentModel.DataAnnotations;

namespace Core.Models.DTOs
{
    public class CourseCreateDTO
    {
        [Required(ErrorMessage = "Nome é obrigatório.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Descrição é obrigatório.")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Dificuldade é obrigatório.")]
        public int Difficulty { get; set; }

        [Required(ErrorMessage = "Ministrante é obrigatório.")]
        public string Instructor { get; set; }

        [Required(ErrorMessage = "Duração é obrigatório.")]
        public DateTime Timing { get; set; }

        [Required(ErrorMessage = "Thumbnail é obrigatório.")]
        public string Thumbnail { get; set; }

        [Required(ErrorMessage = "Categoria é obrigatório.")]
        public int CategoryId { get; set; }
    }
}
