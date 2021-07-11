using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace MovieApiV2Web1.Models
{
    public class LoginViewModel
    {
        public string Email { get; set; }
       [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
