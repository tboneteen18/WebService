using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebService.Models
{
    public class WeatherModel
    {
        [Required (ErrorMessage = "Please enter your zipcode")]
        public string ZipCode { get; set; }
    }
}