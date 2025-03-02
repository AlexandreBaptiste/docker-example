using Microsoft.EntityFrameworkCore;

namespace Docker.Dummy.Api.Infrastructure;

[Keyless]
public class Users
{
    public string? LastName { get; set; }
    public string? FirstName { get; set; }
}
