using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MySQL_Test.DB
{
    [Table("phone")]
    public partial class phone 
    {

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        [Required]
        [Column(Order = 1)]
        [StringLength(15)]
        public string PhoneName { get; set; }

    }
}
