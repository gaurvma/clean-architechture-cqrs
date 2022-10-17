namespace CleanArch.Domain.Entities;
public class AuthRole
{
    public int Id { get; set; }
    public string Name { get; set; }

    public virtual ICollection<AuthUser> Users { get; set; }
}