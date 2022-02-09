using System.Collections.Generic;

namespace ThePerfectNumber.Domain.Interface
{
    public interface IServiceBase<T>
    {
        List<long> CalculateThePerfecNumber(int startingNumber, int endingNumber);
    }
}
