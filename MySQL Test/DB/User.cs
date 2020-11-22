using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MySQL_Test.DB
{
    [Table("user")]
    public partial class user
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(15)]
        public string username { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(40)]
        public string email { get; set; }

        [ForeignKey("PhoneIdUser")]
        [Column(Order = 3)]
        public int phone_id { get; set; }
    }
}