using Microsoft.Data.SqlClient;
using System.Data;

namespace HomeApp.Models
{
    public class adomethods
    {


        public int SaveHouseDetails(HouseModel houseObj)
        {
            SqlConnection con = new SqlConnection("Server=DESKTOP-MMJ6AKP;Initial Catalog=Demo;Persist Security Info=False;User ID=sa;Password=sa123;TrustServerCertificate=True;");
            //con.Open();

            using (SqlCommand command = new SqlCommand("usp_createhousedetails", con))
            {
                command.CommandType = CommandType.StoredProcedure;

                // Add parameters
                //command.Parameters.AddWithValue("@houseid", houseObj.FirstName);
                command.Parameters.AddWithValue("@HouseNo", houseObj.HouseNo);
                command.Parameters.AddWithValue("@Location", houseObj.Location);
                command.Parameters.AddWithValue("@HouseType", houseObj.HouseType);
                command.Parameters.AddWithValue("@muncipality", houseObj.muncipality);
                command.Parameters.AddWithValue("@city", houseObj.city);
                command.Parameters.AddWithValue("@pincode", houseObj.Pincode);
                command.Parameters.AddWithValue("@stateid", houseObj.Stateid);
                command.Parameters.AddWithValue("@districtid", houseObj.Districtid);
                command.Parameters.AddWithValue("@villageid", houseObj.villageid);

                con.Open();
                command.ExecuteNonQuery();
            }

            return 1;

        }
    }
}
