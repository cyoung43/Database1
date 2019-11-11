using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Database1.Models
{
    [Table("Player")]
    public class Player
    {
        [Key]
        public int playerID { get; set; }
        public string playerLastName { get; set; }
        public string playerFirstName { get; set; }
        public string positionCode { get; set; }
        public string teamID { get; set; }
    }
}