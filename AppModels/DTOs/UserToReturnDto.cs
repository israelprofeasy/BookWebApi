﻿using BookWebApi.AppModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookWebApi.AppModels.DTOs
{
    public class UserToReturnDto
    {
        public string Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Email { get; set; }
        public AddressDto Address { get; set; }
    }
}
