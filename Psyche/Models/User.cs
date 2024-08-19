namespace Psyche.Models;

public partial class User
{
    public long Id { get; set; }

    public string Name { get; set; }

    public string Platoon { get; set; }

    public User(string name, string platoon)
    {
        Name = name;
        Platoon = platoon;
    }
}