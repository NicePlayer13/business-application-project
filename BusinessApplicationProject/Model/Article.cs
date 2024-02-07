﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BusinessApplicationProject.Model
{
    public class Article
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public required string ArticleNumber { get; set; }
        public required string Name { get; set; }
        public required double Price { get; set; }
        public required ArticleGroup Group { get; set; }
    }
}
