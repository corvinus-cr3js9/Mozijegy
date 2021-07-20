using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alkalmazas
{
    class JegyVasarlas
    {
        public int JEGY_PK { get; set; }
        public int VETITES_FK { get; set; }
        public string CIM { get; set; }
        public TimeSpan IDOPONTOK { get; set; }
        public string VENDEG_NEV { get; set; }
        public string KATEGORIA_NEV { get; set; }
        public int AR { get; set; }

    }
}
