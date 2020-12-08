using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Volokhina.ASP.NET.Models
{
    public class ListOfWorkersModel
    {
        public int IDEmployee { get; set; }

        public int IDPosition { get; set; }
        public ListOfWorkersModel(int iDEmployee, int iDPosition)
        {
            IDEmployee = iDEmployee;
            IDPosition = iDPosition;
        }
    }
}