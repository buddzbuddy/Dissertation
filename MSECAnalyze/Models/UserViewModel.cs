using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MSECAnalyze.Models
{
    public class UserViewModel
    {
        public UserProfile UserProfile { get; set; }
        public Person Person { get; set; }
    }
}