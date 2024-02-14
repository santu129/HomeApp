using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace practice.Models
{
    [Table("villages")]
    public class Villages
    {
      
        public int DistrictID { get; set; }
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int VillageID { get; set; }
        public string VillageName
        {
            get; set;
        }
    }
}
