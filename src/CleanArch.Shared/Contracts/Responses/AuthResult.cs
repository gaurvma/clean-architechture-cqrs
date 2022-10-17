namespace  CleanArch.Shared.Contracts.Requests;

public class AuthResult{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }
    public int RoleId { get; set; }
    public string RoleName { get; set; }
    public string token { get; set; }
}