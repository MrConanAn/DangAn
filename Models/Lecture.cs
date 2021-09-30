using System;
using System.ComponentModel.DataAnnotations;

namespace RazorPagesMovie.Models
{
    public class Lecture
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }       
    }
}