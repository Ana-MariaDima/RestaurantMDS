using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProiectMDS.ProiectMDS.DTO
{
    public class ComandaMancareDTO
    {
        public int NrPortii { get; set; }
        public List<Mancare> Mancare { get; set; }
    }
}
