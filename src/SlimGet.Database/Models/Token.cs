using System;

namespace SlimGet.Data.Database
{
    public sealed class Token
    {
        public string UserId { get; set; }
        public DateTime? IssuedAt { get; set; }
        public Guid Guid { get; set; }

        public User User { get; set; }
    }
}
