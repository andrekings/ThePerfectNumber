using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ThePerfectNumber.Domain.Entities
{
    public class Numbers
    {
        [Range(1,10,ErrorMessage = "Parâmetro inicial deve ter valor maior que 1 e menor que 10")]
        public int StartingNumber { get; set; }

        [Range(1, 10000, ErrorMessage = "Parâmetro final deve ser limitado a 10000")]
        public int EndingNumber { get; set; }

        public List<long> ResultNumbers { get; set; }

    }
}
