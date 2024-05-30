using Microsoft.Data.SqlClient;
using WebApplication1.Models;

namespace WebApplication1
{
    public class DatabaseHandler
    {
        public string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Complaints;Integrated Security=True;";
        public enum stauses
        {
            pending,
            active,
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

            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("INSERT_Complaint", conn);

                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("ComplainerLocation", comp.Location.Id);
                cmd.Parameters.AddWithValue("Location", comp.Location.Id);
                cmd.Parameters.AddWithValue("Description", comp.Description);
                cmd.Parameters.AddWithValue("Category", comp.Category);
                cmd.Parameters.AddWithValue("status", 0);

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


            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("UPDATE_Complaint", conn);

                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("Id", comp.Id);
                cmd.Parameters.AddWithValue("Description", comp.Description);
                cmd.Parameters.AddWithValue("status", comp.status);

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

        public async Task<string> ComplaintActive(Complaint comp)
        {
            SqlConnection conn = new SqlConnection(connectionString);

            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("UPDATE_ComplaintStatus", conn);

                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("Id", comp.Id);
                cmd.Parameters.AddWithValue("status", 1);

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

        public async Task<string> closedComplaint(Complaint comp)
        {
            SqlConnection conn = new SqlConnection(connectionString);

            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("UPDATE_ComplaintStatus", conn);

                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("Id", comp.Id);
                cmd.Parameters.AddWithValue("status", 2);

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

