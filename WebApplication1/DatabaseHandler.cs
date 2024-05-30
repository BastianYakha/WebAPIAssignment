using Microsoft.Data.SqlClient;
using System.Data;
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
                cmd.Parameters.AddWithValue("Name", comp.Name);

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

        public async Task<string> ComplaintActive(string id)
        {
            SqlConnection conn = new SqlConnection(connectionString);

            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("UPDATE_ComplaintStatus", conn);

                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("Id", id);
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

        public async Task<string> closedComplaint(string id)
        {
            SqlConnection conn = new SqlConnection(connectionString);

            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("UPDATE_ComplaintStatus", conn);

                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("Id", id);
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

        public async Task<List<Complaint>> selectComplaintByName(string name)
        {
            List<Complaint> compList = new List<Complaint>();
            SqlConnection conn = new SqlConnection(connectionString);

            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("GET_ComplaintByName", conn);

                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("Name", name);

                SqlDataReader rd = cmd.ExecuteReader();

                while(rd.Read())
                {
                    Complaint newComp = new Complaint();

                    Building newB = new Building();
                    newB.Id = rd.GetValue(1).ToString();

                    Building newB1 = new Building();
                    newB1.Id = rd.GetValue(2).ToString();

                    newComp.Id = rd.GetValue(0).ToString();
                    newComp.Name = rd.GetValue(7).ToString();
                    newComp.ComplainerLocation = newB;
                    newComp.Location = newB1;
                    newComp.Description = rd.GetValue(3).ToString();
                    newComp.Category = rd.GetInt32(4);
                    newComp.status = rd.GetInt32(5);
                    newComp.created = rd.GetDateTime(6);

                    compList.Add(newComp);
                }

                conn.Close();

                return compList;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return compList;
            }
        }

        public async Task<List<Complaint>> selectComplaintByDate(DateTime date)
        {
            List<Complaint> compList = new List<Complaint>();
            SqlConnection conn = new SqlConnection(connectionString);

            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("GET_ComplaintByDate", conn);

                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("created", date);

                SqlDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    Complaint newComp = new Complaint();

                    Building newB = new Building();
                    newB.Id = rd.GetValue(1).ToString();

                    Building newB1 = new Building();
                    newB1.Id = rd.GetValue(2).ToString();

                    newComp.Id = rd.GetValue(0).ToString();
                    newComp.Name = rd.GetValue(7).ToString();
                    newComp.ComplainerLocation = newB;
                    newComp.Location = newB1;
                    newComp.Description = rd.GetValue(3).ToString();
                    newComp.Category = rd.GetInt32(4);
                    newComp.status = rd.GetInt32(5);
                    newComp.created = rd.GetDateTime(6);

                    compList.Add(newComp);
                }

                conn.Close();

                return compList;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return compList;
            }
        }
    }
}

