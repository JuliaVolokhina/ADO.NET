using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Volokhina.ASP.NET.Models
{
    public class PositionsModel
    {
        public int IDPosition { get; set; }

        public string NameOfPosition { get; set; }
        public PositionsModel(int iDPosition, string nameOfPosition)
        {
            IDPosition = iDPosition;
            NameOfPosition = nameOfPosition;
        }
    }
}