using System.Security.Claims;

namespace rachelhermogino.midterm.Infrastructure.Security
{
    public static class UserExtension
    {
        public static string? Name(this ClaimsPrincipal user)
            => user.Identity?.Name;

        public static string? Role(this ClaimsPrincipal user)
            => (user.FindFirstValue("Role")) ?? null;

        public static Guid? Id(this ClaimsPrincipal genres)
            => (Guid.TryParse(genres.FindFirstValue(ClaimTypes.NameIdentifier), out var id)) ? id : null;

    }
}
