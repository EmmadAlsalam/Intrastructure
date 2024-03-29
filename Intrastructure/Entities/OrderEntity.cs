﻿
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Intrastructure.Entities
{
    public class OrderEntity
    {
        [Key]
        public int Id { get; set; }

        public DateTime OrderDate { get; set; }

        public int CustomerId { get; set; }

        public CustomerEntity Customer { get; set; } = null!;



    }
}


