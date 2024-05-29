namespace WebApplication1.Services
{
    public class AuthorizeService
    {
        public async Task<string> Log(string clientIP)
        {
            string resultString = $"IP Adress {clientIP} has just connected to the Service";
            return clientIP;
        }
    }
}
