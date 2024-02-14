using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace HomeApp.Models
{
    [Table("tbl_houses")]
    public class HouseModel
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int houseid { get; set; }
        public string HouseNo { get; set; }
        public string Location { get; set; }
        public string HouseType { get; set; }
        public string muncipality { get; set; }
        public string city { get; set; }
        public int Pincode { get; set; }
        public int Stateid { get; set; }
        public int Districtid { get; set; }
        public int villageid { get; set; }

    }
}
