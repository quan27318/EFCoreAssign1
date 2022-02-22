using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace EFCore.Models
{
    [Table("Student")]
    public class Student
    {
        [Key]
        public int StudentID {get; set;}
        
        [Column("FirstName", TypeName ="ntext")]
        [MaxLength(30)]
        public string FirstName{get; set;}

        [Column("LastName", TypeName ="ntext")]
        [MaxLength(50)]
        public string LastName{ get; set;}

        [Column("City", TypeName ="ntext")]
        [MaxLength(150)]
        public string City{ get; set;}

        [Column("State", TypeName ="ntext")]
        [MaxLength(150)]
        public string State{get; set;}
    }
}