﻿using System.ComponentModel.DataAnnotations;


namespace Intrastructure.Entities
{

    public class CategoryEntity
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; } = null!;



    }
}
