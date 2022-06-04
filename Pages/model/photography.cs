using System;
using System.ComponentModel.DataAnnotations;

namespace WEB315_Summer22_Assignments.Models
{
    public class Photography
    {
        public int ID { get; set; }
        public string Title { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }
        public decimal Price { get; set; }
    }
}