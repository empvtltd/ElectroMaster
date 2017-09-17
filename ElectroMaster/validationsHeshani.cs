using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace validations
{
    public class validations
    {
        //check the validation of the email
        public bool validateEmail(String email)
        {
            bool Isvalid = false;
            Regex r = new Regex("^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$");
            if (r.IsMatch(email))
            {
                Isvalid = true;

            }
            else
            {
                Isvalid = false;
            }

            return Isvalid;

        }
        //check whether the string passed is a number
        public bool isANumber(String num)
        {
            //if (!char.IsControl(num) && !char.IsLetter(num)
            {
                return true;

            }
        }
        //checking the valid phone number 
        public bool isPhoneNum(String number)
        {

            //if (number > 10)
            {
                return true;
            }
        }

        //check text box empty 
        public bool isEmpty(string value)
        {
            if (value == " ")
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
    }
}
