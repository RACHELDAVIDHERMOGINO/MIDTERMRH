using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace rachelhermogino.midterm_.Infrastracture.domain.model
{
    public class Books
    {
        public Guid? Id { get; set; }
        public Guid? UserId { get; set; }
        public string? Type { get; set; } //paperbound, softbound, ebook
        public string? Key { get; set; }
        public string? Value { get; set; }
    }

}
