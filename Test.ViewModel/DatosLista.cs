using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.ViewModel
{
    public class DatosLista
    {
        public int Id { get; set;}
        public string Traceability { get; set; }

        public DatosLista(int id, string traceability)
        {
            this.Id = id;
            this.Traceability = traceability;
        }
    }
}
