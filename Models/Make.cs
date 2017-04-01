using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vega.Models
{
    /// <summary>
    /// Model class for the make of the vehicle.
    /// </summary>
    public class Make
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

        public virtual List<Model> Models { get; set; }
    }
}