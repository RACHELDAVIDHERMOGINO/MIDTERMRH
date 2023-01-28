using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;

namespace rachelhermogino.midterm_.Infrastracture.domain.model
{
    public class Books
    {
        public Guid? Id { get; set; }
        public string? Name { get; set; }
        public string? EmailAddress { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public Type? Type { get; set; }
        public Guid? RoleId { get; set; }

      
        public string? Books { get; set; }
    }

    public enum Type
    {
        paperback = 1,
        softbound = 2,
        ebook = 3,
    }

}