namespace UserApi.Entities;

public class User
{
    public Guid Id { get; set; }
    public string LastName { get; set; }
    public string FirstName { get; set; }
    public int Age { get; set; }
}