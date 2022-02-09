using System;
using System.Collections.Generic;
using ThePerfectNumber.Domain.Entities;
using ThePerfectNumber.Domain.Interface;

namespace ThePerfectNumber.Calculator
{
    public class Calculate : IBaseCalculateNumbers
    {

        public List<long> CalculateNumbers(int startingNumber, int endingNumber)
        {

            Numbers numbers = new()
            {
                StartingNumber = startingNumber,
                EndingNumber = endingNumber,
                ResultNumbers = new List<long>()
            };

            for (long i = numbers.StartingNumber; i <= numbers.EndingNumber; i++)
            {
                decimal soma = 0;
                for (long j = 1; j < i; j++)
                {
                    if (i % j == 0)
                        soma += j;
                }
                if (soma == i)
                   numbers.ResultNumbers.Add(+i);
            }
            return numbers.ResultNumbers;
        }
    }
}
