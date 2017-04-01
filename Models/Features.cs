using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vega.Models
{
    /// <summary>
    /// Model class for the features of the vehicles.
    /// </summary>
    public class Feature
    {
        /// <summary>
        /// Unique Id for the feature
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        /// <summary>
        /// Name of the feature.
        /// </summary>
        [Required]
        [Column(TypeName = "varchar(20)")]
        public string Name { get; set; }
    }
}