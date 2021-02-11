using FizzAPI.Domain.Common;
using FizzAPI.Service.Contract;
using FizzAPI.Service.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace FizzAPI.Service.Implementation
{
    public class FizzService : IFizzService
    {
        public Response<string> DetermineFizz(int number)
        {
            if (!(number > 0 && number <= 100))
            {
                throw new ApiException($"{number} is not within 1 and 100 constraint.");
            }

            if (MulitpleOfThreeAndFive(number))
            {
                return new Response<string>(number.ToString(), message: "FizzBuzz");
            }
            else if (MultipleOfFive(number))
            {
                return new Response<string>(number.ToString(), message: "Buzz");
            }
            else if (MultipleOfThree(number))
            {
                return new Response<string>(number.ToString(), message: "Fizz");
            }
            else
            {
                return new Response<string>(number.ToString(), message: $"{number}");
            }
        }

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
