﻿namespace CRM_Sample.Model
{
    public class Roles
    {
        public int Id { get; set; }
        public string RoleName { get; set; }
        public List<Users> users { get; set; }
    }
}
