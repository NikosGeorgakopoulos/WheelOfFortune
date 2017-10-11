using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WheelOfFortune_Stoiximan_1.Models
{
    public class User
    {
        public int Id { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "User Name limit is 50 characters.")]
        public string UserName { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }
        public bool Gender { get; set; }

        [Required]
        public DateTime BirthDate { get; set; }
        public string PhotoUrl { get; set; }
        public virtual ICollection<Transaction> transacions { get; set; }

    }
}
