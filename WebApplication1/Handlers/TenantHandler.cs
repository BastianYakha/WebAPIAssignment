using Microsoft.Data.SqlClient;
using WebApplication1.Models;

namespace WebApplication1
{
    public class TenantHandler
    {
        public string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Complaints;Integrated Security=True;";

        public async Task<string> insertTenant(Tenant ten)
        {
            SqlConnection conn = new SqlConnection(connectionString);

            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("INSERT_Tenant", conn);

                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("Name", ten.Name);
                cmd.Parameters.AddWithValue("Surname", ten.Surname);

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

        public async Task<List<Models.Tenant>> getAllTenants()
        {
            List<Models.Tenant> tenList = new List<Models.Tenant>();
            SqlConnection conn = new SqlConnection(connectionString);

            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("GET_allTenant", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                SqlDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    Models.Tenant newTen = new Models.Tenant();

                    newTen.Id = rd.GetValue(0).ToString();
                    newTen.Name = rd.GetValue(1).ToString();
                    newTen.Surname = rd.GetValue(2).ToString();
                    newTen.Apartment = rd.GetValue(3).ToString();

                    tenList.Add(newTen);
                }

                conn.Close();

                return tenList;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return tenList;
            }
        }

        public async Task<string> updateAPTenant(Tenant tenant)
        {
            SqlConnection conn = new SqlConnection(connectionString);

            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("UPDATE_Tenant", conn);

                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("Id", tenant.Id);
                cmd.Parameters.AddWithValue("apartment", tenant.Apartment);

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
    }
}
