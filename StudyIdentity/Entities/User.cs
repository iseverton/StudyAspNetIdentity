namespace StudyIdentity.Entities;

public class User
{
    public int Id { get; set; }
    private string Name { get; set; }
    private string Email { get; set; }
    private string Password { get; set; }
    private DateTime CreateAt { get; set; }
    private DateTime UpdateAt { get; set; }
    private RolesEnum Role { get; set; }
}
