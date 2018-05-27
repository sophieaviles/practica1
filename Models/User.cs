using System;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class User

   
    {

        [Key]
         
        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
}
