using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volokhina.ASP.NET.Entities
{
    public class Position
    {
        public int IDPosition { get; set; }
        public string NameOfPosition { get; set; }

        public Position()
        { }

        public Position(int idPosition, string nameOfPosition)
        {
            IDPosition = idPosition;
            NameOfPosition = nameOfPosition;
        }
        public override string ToString()
        {
            return $"{IDPosition} {NameOfPosition}";
        }
    }
}
