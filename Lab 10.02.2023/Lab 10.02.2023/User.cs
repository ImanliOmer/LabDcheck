using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_10._02._2023
{
    class User
    {
        private string _password;

        public string Password
        {

            get { return _password; }


            set
            {
                if (String.IsNullOrEmpty(value) == false && value.Length >= 8 == true && DifferentCase(value) == true)
                {
                    _password = value;
                    return;
                }
                Console.WriteLine("pasword invalid try again: \n");
                return;

            }
        }

        public bool DifferentCase(string pass)
        {
            char[] arr = pass.ToCharArray();
            bool result = false;
            bool result1 = false;
            bool result2 = false;

            for (int i = 0; i < arr.Length; i++)
            {
                if (result1 != char.IsUpper(arr[i]))
                {
                    result = true;
                }
                if (result1 != char.IsLower(arr[i]))
                {
                    result = true;
                }
                if (result2 != char.IsNumber(arr[i]))
                {
                    result = true;
                }
                if (result1 == true && result2 == true)
                {
                    result = true;
                }
            }
            return result;
        }
    }
}
