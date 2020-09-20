using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteFortes
{
    class Nota {
        public string idNota { get; set; }
        public string fkPrestador { get; set; }
        public string fkTomador { get; set; }
        public string dataLancamento { get; set; }
        public string valor { get; set; }
        public List<Item> Itens { get; set; }
        public Nota()
        {
            Itens = new List<Item>();
        }
    }
}
