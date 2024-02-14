using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace practice.Models
{
    [Table("District")]
    public class Districts
    {
        public int StateID { get; set; }
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int DistrictID { get; set; }
        public string DistrictName
        {
            get; set;
        }
    }
}
