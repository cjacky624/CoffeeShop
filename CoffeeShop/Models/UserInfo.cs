using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace CoffeeShop.Models
{
    public class UserInfo
    {
        [Required] 
        [RegularExpression("^[A-Z]+[A-z]{1,30}$")]
        public string FirstName { get; set; }

        [Required]
        [RegularExpression("^[a-zA-Z]{2,}$")]
        public string LastName { get; set; }


        public string Email { get; set; }

        public DateTime Birthday { get; set; }

        public UserInfo()
        {
            FirstName = "";
            LastName = "";
        }
        public UserInfo(string firstName, string lastName, DateTime bDay, string eMail)
        {
            FirstName = firstName;
            LastName = lastName;
            Birthday = bDay;
            Email = eMail;
        }

    }
}