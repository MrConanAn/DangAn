using System;
using System.ComponentModel.DataAnnotations;

namespace RazorPagesMovie.Models
{
    public class Person
    {
        public int ID { get; set; }
        public string Name { get; set; }

        [DataType(DataType.Date)]
        public DateTime Dateofbirth { get; set; }

    }
}