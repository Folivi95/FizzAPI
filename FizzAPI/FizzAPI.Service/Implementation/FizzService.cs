using FizzAPI.Service.Contract;
using System;
using System.Collections.Generic;
using System.Text;

namespace FizzAPI.Service.Implementation
{
    public class FizzService : IFizzService
    {
        public bool MulitpleOfThreeAndFive(int number)
        {
            if (number % 3 == 0 && number % 5 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool MultipleOfFive(int number)
        {
            if (number % 5 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool MultipleOfThree(int number)
        {
            if (number % 3 == 0)
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
