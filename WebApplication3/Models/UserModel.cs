namespace WebApplication3.Models;

public class UserModel
{
    public string Username { get; set; }
    public int Age { get; set; }
    public List<HobbyModel> Hobbies { get; set; } = new List<HobbyModel>();
    public List<String> HobbyNames { get; set; } = new List<String>();
}

public class HobbyModel
{
    public string Name { get; set; }
    public bool IsSelected { get; set; }
}