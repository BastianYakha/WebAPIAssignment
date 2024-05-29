using Microsoft.Data.SqlClient;
using WebApplication1.Models;

namespace WebApplication1
{
    public class DatabaseHandler
    {
        /*
        public string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Complaints;Integrated Security=True;";

        public string InsertTenant(Tenant newTenant)
        {
            SqlConnection conn = new SqlConnection(connectionString);

            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("INSERT_Tenant", conn);

                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("Name", newTenant.Name);
                cmd.Parameters.AddWithValue("Surname", newTenant.Surname);

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

        public async Task<Tenant> GetTenant(Tenant NewTenant)
        {
            SqlConnection conn = new SqlConnection(connectionString);

            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("GET_Tenant", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("Name", NewTenant.Name);
                cmd.Parameters.AddWithValue("Surname", NewTenant.Surname);

                SqlDataReader rd = cmd.ExecuteReader();

                if (!rd.HasRows)
                {
                    Console.WriteLine("NO ROWS");
                    return null;
                }

                while (rd.Read())
                {
                    return (new Tenant { Id = rd.GetValue(0).ToString(), Name = NewTenant.Name, Surname = NewTenant.Surname });
                }
                conn.Close();
                return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }*/

        public string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Complaints;Integrated Security=True;";
        public enum stauses
        {
            pending,
            inWork,
            closed
        }

        public enum categories
        {
            animals,
            plumbing,
            electricity,
            music,
            rent,
            water
        }

        public async Task<string> InsertComplaint(Complaint comp)
        {
            SqlConnection conn = new SqlConnection(connectionString);

            if(Enum.IsDefined(typeof(stauses), comp.status))
            {
                comp.currentStatus = Enum.GetName(typeof(stauses), comp.status);
            }

            if (Enum.IsDefined(typeof(categories), comp.categoryID))
            {
                comp.Category = Enum.GetName(typeof(categories), comp.categoryID);
            }

            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("INSERT_Complaint", conn);

                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("ComplainerLocation", comp.Location.Id);
                cmd.Parameters.AddWithValue("Location", comp.Location.Id);
                cmd.Parameters.AddWithValue("Description", comp.Description);
                cmd.Parameters.AddWithValue("Category", comp.Category);
                cmd.Parameters.AddWithValue("status", comp.currentStatus);

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

        public async Task<string> UpdateComplaint(Complaint comp)
        {
            SqlConnection conn = new SqlConnection(connectionString);

            if (Enum.IsDefined(typeof(stauses), comp.status))
            {
                comp.currentStatus = Enum.GetName(typeof(stauses), comp.status);
            }

            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("UPDATE_Complaint", conn);

                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("Id", comp.Id);
                cmd.Parameters.AddWithValue("Description", comp.Description);
                cmd.Parameters.AddWithValue("status", comp.currentStatus);

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

