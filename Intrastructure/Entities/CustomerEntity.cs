﻿
using System.ComponentModel.DataAnnotations;


namespace Intrastructure.Entities
{
    public class CustomerEntity
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public string Email { get; set; } = null!;

        public string PhoneNumber { get; set; } = null!;

        public DateTime RegistrationDate { get; set; } 



    }
}
