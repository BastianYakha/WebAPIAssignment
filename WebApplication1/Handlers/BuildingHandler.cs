using Microsoft.Data.SqlClient;
using WebApplication1.Models;

namespace WebApplication1
{
    public class BuildingHandler
    {
        public string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Complaints;Integrated Security=True;";

        public async Task<string> createBuilding(Models.Building bd)
        {
            SqlConnection conn = new SqlConnection(connectionString);

            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("INSERT_Building", conn);

                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("Street", bd.Street);
                cmd.Parameters.AddWithValue("StreetNumber", bd.StreetNumber);
                int result = cmd.ExecuteNonQuery();

                conn.Close();

                return "seccuess";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return ex.ToString();
            }
        }

        public async Task<List<Building>> getAllBuildings()
        {
            List<Building> bdList = new List<Building>();
            SqlConnection conn = new SqlConnection(connectionString);

            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("GET_AllBuildings", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                SqlDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    Building newBD = new Building();
                    newBD.Id = rd.GetValue(0).ToString();
                    newBD.Street = rd.GetValue(1).ToString();
                    newBD.StreetNumber = Convert.ToInt32(rd.GetValue(2));

                    bdList.Add(newBD);
                }

                conn.Close();

                return bdList;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return bdList;
            }
        }
    }
}
