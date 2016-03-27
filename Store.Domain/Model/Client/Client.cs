﻿using System;

namespace Store.Domain.Model.Client
{
    public class Client // Entity
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Address Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
    }
}
