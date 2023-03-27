﻿namespace C_sharf_4_Ass_1.Models
{
    public class User
    {
        public Guid UserId { get; set; }
        public string Username { get; set; }
        public Guid RoleId { get; set; }
        public string Password { get; set; }
        public int Status { get; set; }
        public virtual Role Role { get; set; }
        public virtual Cart Cart { get; set; }
        public virtual List<Bill> Bills { get; set; }

    }
}
