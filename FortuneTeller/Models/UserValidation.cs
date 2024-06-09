using FortuneTeller.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FortuneTeller.Models
{
    internal static class UserValidation
    {
        public static string ValidateFirstName(string firstName)
        {
            string errorMessage;
            if (string.IsNullOrEmpty(firstName))
            {
                errorMessage = "First Name can not be Null or empty";
            }
            else if (firstName.Length > 50)
            {
                errorMessage = "First Name can not be greater then 50 characters";
            }
            else
            {
                return firstName;
            }
            throw new ValidateException(errorMessage);
        }
        public static string ValidateLastName(string lastName)
        {
            string errorMessage;
            if (string.IsNullOrEmpty(lastName))
            {
                errorMessage = "Last Name can not be Null or empty";
            }
            else if (lastName.Length > 50)
            {
                errorMessage = "Last Name can not be greater then 50 characters";
            }
            else
            {
                return lastName;
            }
            throw new ValidateException(errorMessage);
        }
    }
}
