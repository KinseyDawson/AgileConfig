﻿namespace AgileConfig.Server.Apisite.Models
{
    public class ChangePasswordVM
    {
        public string password { get; set; }

        public string confirmPassword { get; set; }

        public string oldPassword { get; set; }
    }
}
