using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebAPIDemo.Models
{
    [Table("Styless")]
    public class Styless
    {
        [Key()]
        public string Id { get; set; }
        public bool Index1 { get; set; }
        public bool us { get; set; }
        public bool news { get; set; }
        public bool resources { get; set; }
    }
}