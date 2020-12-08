using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volokhina.ASP.NET.DAL;
using Volokhina.ASP.NET.DAL.Interface;
using Volokhina.ASP.NET.BLL;
using Volokhina.ASP.NET.BLL.Interface;
using Ninject;
using Volokhina.ASP.NET.Common;

namespace Volokhina.ASP.NET.Common
{
    public static class DependencyResolver
    {
        private static NinjectSettings settings = new NinjectSettings();
        public static StandardKernel kernel = new StandardKernel(settings);
    }
}
