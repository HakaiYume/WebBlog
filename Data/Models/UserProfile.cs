using System;

namespace WebBlog.Data.Models
{
    public partial class UserProfile
    {
        public int UserId { get; set; }
        public string? Bio { get; set; }
        public string? ProfileImageUrl { get; set; }
    }
}
