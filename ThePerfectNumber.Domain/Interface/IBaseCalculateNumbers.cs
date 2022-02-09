using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThePerfectNumber.Domain.Entities;

namespace ThePerfectNumber.Domain.Interface
{
    public interface IBaseCalculateNumbers
    {
        List<long> CalculateNumbers(int startingNumber, int endingNumber);
    }
}
