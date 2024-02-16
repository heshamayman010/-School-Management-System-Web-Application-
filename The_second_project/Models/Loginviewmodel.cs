using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace The_second_project.Models
{
    public class Loginviewmodel

    {
        [Required]
        public string username { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string pasaword { get; set; }
        [Required]
        public bool rememberme { get; set; }


    }
}
