﻿namespace Sada.Presintation.WebAPI.Auth
{
    public class AuthResponse
    {
        public string UserId { get; set; }
        public string Username { get; set; }
        public string Token { get; set; }
        public string? ProfileImage { get; set; }
    }
}
