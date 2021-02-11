using System;
using System.Collections.Generic;
using System.Text;

namespace FizzAPI.Service.Contract
{
    public interface IFizzService
    {
        bool MulitpleOfThreeAndFive(int number);
        bool MultipleOfThree(int number);
        bool MultipleOfFive(int number);
    }
}
