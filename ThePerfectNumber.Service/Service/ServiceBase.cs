using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThePerfectNumber.Domain.Entities;
using ThePerfectNumber.Domain.Interface;

namespace ThePerfectNumber.Service.Service
{
    public class ServiceBase<T> : IServiceBase<T>
    {
        private readonly IBaseCalculateNumbers _basebaseCalculateNumbers;

        public ServiceBase(IBaseCalculateNumbers baseCalculateNumbers)
        {
            _basebaseCalculateNumbers = baseCalculateNumbers;
        }


        public List<long> CalculateThePerfecNumber(int startingNumber, int endingNumber) => 
            _basebaseCalculateNumbers.CalculateNumbers(startingNumber, endingNumber);
       
    }
}
