using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vega.Models
{
    public class Model
    {
        /// <summary>
        /// Unique id of the Make.
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        /// <summary>
        /// Name of the make of the vehicle.
        /// </summary>
        [Required]
        [Column(TypeName = "varchar(20)")]
        public string Name { get; set; }
    }
}