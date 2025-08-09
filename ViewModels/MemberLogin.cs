using AMWP.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace AMWP.ViewModels
{
    public class MemberLogin
    {
        [DisplayName("Username")]
        [Required(ErrorMessage = "Please enter email account")]
        [EmailAddress(ErrorMessage = "Invalid email account")]
        [DataType(DataType.EmailAddress)]
        public string Account { get; set; }

        string password;
        [DisplayName("Password")]
        [Required(ErrorMessage = "Please enter password")]
        [DataType(DataType.Password)]
        public string Password
        {
            get
            {
                return password;
            }
            set
            {
                password = BusinessRules.getHashPassword(value);
            }
        }
    }
}