using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volokhina.ASP.NET.Entities
{
    public class ListOfWorkers
    {
        public int IDEmployee { get; set; }
        public int IDPosition { get; set; }
        public ListOfWorkers()
        { }

        public ListOfWorkers(int idemployee, int idposition)
        {
            IDEmployee = idemployee;
            IDPosition = idposition;
        }
        public override string ToString()
        {
            return $"{IDEmployee} {IDPosition}";
        }
    }
}
