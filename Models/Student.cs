using Swashbuckle.AspNetCore.Annotations;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lab6_1_.Models
{
    public class Student
    {
        [Column("ID")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [SwaggerSchema(ReadOnly = true)]
        public Guid Id { get; set; }

        [Required]
        [StringLength(50)]
        [Column("FirstName")]
        [Display(Name = "First Name")]
        public String FirstName { get; set; }

        [Required]
        [StringLength(50)]
        [Column("LastName")]
        [Display(Name = "Last Name")]
        public String LastName { get; set; }

        [Required]
        [StringLength(50)]
        [Column("Program")]
        [Display(Name = "Program")]
        public String Program { get; set; }

    }
}
