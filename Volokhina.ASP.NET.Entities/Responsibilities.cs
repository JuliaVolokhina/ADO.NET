using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volokhina.ASP.NET.Entities
{
    public class Responsibilities
    {
        public int IDPosition { get; set; }
        public int IDTask { get; set; }

        public Responsibilities()
        { }

        public Responsibilities(int idPosition, int idTask)
        {
            IDPosition = idPosition;
            IDTask = idTask;
        }
        public override string ToString()
        {
            return $"{IDPosition} {IDTask}";
        }
    }
}
