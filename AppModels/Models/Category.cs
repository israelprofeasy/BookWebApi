﻿using BookWebApi.AppModels.Models;
using System.Collections.Generic;

namespace BookWebApi.AppModels.Models
{
    public class Category : BaseEntity
    {
        public string Name { get; set; }
        public List<Book>  Books {get; set;} = new List<Book>();

    }
}
