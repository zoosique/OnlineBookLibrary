﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineLibrary.Models
{
    public enum BookStatus
    {
        Available,
        Rented
    }

    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public int Year { get; set; }
        public BookStatus Status { get; set; }

        public ICollection<Tag> Tags { get; set; }
        public Book()
        {
            Tags = new List<Tag>();
        }
    }
}