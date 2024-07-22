namespace Psyche.Models
{
    public class Config
    {
        public string TestsFilepath { get; set; }
        public ConnectionStrings ConnectionStrings { get; set; }
    }

    public class ConnectionStrings
    {
        public string UsersDB { get; set; }
    }
}
