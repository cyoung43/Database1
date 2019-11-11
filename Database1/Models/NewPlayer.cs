using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Database1.Models
{
    public class NewPlayer
    {
        [Key]
        public int playerID { get; set; }
        public string playerLastName { get; set; }
        public string playerFirstName { get; set; }
        public string positionCode { get; set; }
        public string positionDesc { get; set; }
        public string teamID { get; set; }
        public string teamName { get; set; }
    }
}