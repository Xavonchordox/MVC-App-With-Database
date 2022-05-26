using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Lab4.Models
{
    public class Friend
    {
        [Required(ErrorMessage = "Please enter ID")]
        [Range(0, 200)]
        [DisplayName("ID:")]
        public int Index { get; set; }

        [Required(ErrorMessage = "Please enter name")]
        [DisplayName("Name:")]
        public string Ime { get; set; }

        [DisplayName("Place:")]
        public string MestoZiveenje { get; set; }

        [Key]
        public int Id { get; set; }
    }
}