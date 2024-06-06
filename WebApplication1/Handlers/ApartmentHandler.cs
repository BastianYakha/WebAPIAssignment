using Microsoft.Data.SqlClient;
using WebApplication1.Models;

namespace WebApplication1
{
    public class ApartmentHandler
    {
        public string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Complaints;Integrated Security=True;";

        public async Task<string> createApartment(Models.Apartment ap)
        {
            SqlConnection conn = new SqlConnection(connectionString);

            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("INSERT_Apartment", conn);

                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("ApartmentName", ap.Apartmentname);
                cmd.Parameters.AddWithValue("Building", ap.building);
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

        public async Task<List<Apartment>> getAllApartments()
        {
            List<Apartment> apList = new List<Apartment>();
            SqlConnection conn = new SqlConnection(connectionString);

            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("GET_allApartments", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                SqlDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    Apartment newAP = new Apartment();

                    newAP.Id = rd.GetValue(0).ToString();
                    newAP.Apartmentname = rd.GetValue(1).ToString();
                    newAP.building = rd.GetValue(2).ToString();

                    apList.Add(newAP);
                }

                conn.Close();

                return apList;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return apList;
            }
        }
    }
}
