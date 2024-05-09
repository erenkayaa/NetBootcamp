﻿namespace NetBootcamp.API.Users
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; } = default!;

        public string Email { get; set; } = default!;

        public DateTime Created { get; set; } = new();

    }
}