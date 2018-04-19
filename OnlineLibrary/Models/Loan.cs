﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OnlineLibrary.Models
{
    public enum Status
    {
        NowRenting,
        Rented,
        Violated
    }

    public class Loan
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public DateTime DueDate { get; set; }

        [Required]
        public DateTime BorrowDate { get; set; }

        public DateTime? ReturnedDate { get; set; }

        [Required]
        public Status Status { get; set; }

        [Required]
        public int BookID { get; set; }     
        public Book Book { get; set; }

        [Required]
        public int UserID { get; set; }
        public TestUser User { get; set; }

        #region Constructors
        public Loan() { }
        #endregion
    }
}