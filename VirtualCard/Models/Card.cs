using System;
using System.ComponentModel.DataAnnotations;

namespace VirtualCard.Models
{
    public class Card
    {
        [Key]
        public int Id { get; set; }
        public int Number { get; set; }
        public DateTime CreationDate { get; set; }

    }
}
