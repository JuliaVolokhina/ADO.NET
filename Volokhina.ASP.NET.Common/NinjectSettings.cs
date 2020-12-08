using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject.Modules;
using Volokhina.ASP.NET.BLL;
using Volokhina.ASP.NET.DAL;
using Volokhina.ASP.NET.DAL.Interface;
using Volokhina.ASP.NET.BLL.Interface;
using AutoMapper;
using Ninject;

namespace Volokhina.ASP.NET.Common
{
    public class NinjectSettings : NinjectModule
    {
        public override void Load()
        {
            Bind<IEmployeeDao>().To<EmployeeDao>();
            Bind<IPositionDao>().To<PositionDao>();
            Bind<IListOfWorkersDao>().To<ListOfWorkersDao>();
            Bind<IEmployeeLogic>().To<EmployeeLogic>();
            Bind<IPositionLogic>().To<PositionLogic>();
            Bind<IListOfWorkersLogic>().To<ListOfWorkersLogic>();

            var profiles = GetType().Assembly.GetTypes().Where(t => typeof(Profile).IsAssignableFrom(t)).Select(t => (Profile)Activator.CreateInstance(t));

            var config = new MapperConfiguration(cfg =>
            {
                foreach (var profile in profiles)
                {
                    cfg.AddProfile(profile);
                }
                cfg.ForAllMaps((map, expresion) => expresion.ForAllMembers(options => options.Condition((source, destination, member) => member != null)));
            });
            var mapper = config.CreateMapper();
            Bind<MapperConfiguration>().ToConstant(config).InSingletonScope();
            Bind<IMapper>().ToConstant(mapper).InSingletonScope();
        }
    }
}