using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Volokhina.ASP.NET.Models
{
    public class ResponsibilitiesModel
    {
        public int IDPosition { get; set; }

        public int IDTask { get; set; }
        public ResponsibilitiesModel(int iDPosition, int iDTask)
        {
            IDPosition = iDPosition;
            IDTask = iDTask;
        }
    }
}