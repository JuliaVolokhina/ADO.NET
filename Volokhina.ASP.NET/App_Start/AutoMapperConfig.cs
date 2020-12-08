using AutoMapper;
using Volokhina.ASP.NET.Entities;
using Volokhina.ASP.NET.Models;

namespace Volokhina.ASP.NET.App_Start
{
    public class AutoMapperConfig
    {
        public class EmployeeToEmployeeModel : Profile
        {
            public EmployeeToEmployeeModel()
            {
                CreateMap<Employee, EmployeeModel>()
                    .ForMember(dest => dest.IDEmployee, opt => opt.MapFrom(src => src.IDEmployee))
                    .ForMember(dest => dest.FullName, opt => opt.MapFrom(src => src.FullName))
                    .ForMember(dest => dest.Age, opt => opt.MapFrom(src => src.Age))
                    .ForMember(dest => dest.PhoneNumber, opt => opt.MapFrom(src => src.PhoneNumber))
                    .ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.Email))
                    .ForMember(dest => dest.Address, opt => opt.MapFrom(src => src.Address));
            }
        }
        public class EmployeeModelToEmployee : Profile
        {
            public EmployeeModelToEmployee()
            {
                CreateMap<EmployeeModel, Employee>()
                    .ForMember(dest => dest.IDEmployee, opt => opt.MapFrom(src => src.IDEmployee))
                    .ForMember(dest => dest.FullName, opt => opt.MapFrom(src => src.FullName))
                    .ForMember(dest => dest.Age, opt => opt.MapFrom(src => src.Age))
                    .ForMember(dest => dest.PhoneNumber, opt => opt.MapFrom(src => src.PhoneNumber))
                    .ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.Email))
                    .ForMember(dest => dest.Address, opt => opt.MapFrom(src => src.Address));
            }
        }

        public class ListOfWorkersToListOfWorkersModel : Profile
        {
            public ListOfWorkersToListOfWorkersModel()
            {
                CreateMap<ListOfWorkers, ListOfWorkersModel>()
                    .ForMember(dest => dest.IDEmployee, opt => opt.MapFrom(src => src.IDEmployee))
                    .ForMember(dest => dest.IDPosition, opt => opt.MapFrom(src => src.IDPosition));
            }
        }
        public class ListOfWorkersModelToListOfWorkers : Profile
        {
            public ListOfWorkersModelToListOfWorkers()
            {
                CreateMap<ListOfWorkersModel, ListOfWorkers>()
                    .ForMember(dest => dest.IDEmployee, opt => opt.MapFrom(src => src.IDEmployee))
                    .ForMember(dest => dest.IDPosition, opt => opt.MapFrom(src => src.IDPosition));
            }
        }

        public class PayrollFormsToPayrollFormsModel : Profile
        {
            public PayrollFormsToPayrollFormsModel()
            {
                CreateMap<PayrollForms, PayrollFormsModel>()
                    .ForMember(dest => dest.IDEmployee, opt => opt.MapFrom(src => src.IDEmployee))
                    .ForMember(dest => dest.IDSalary, opt => opt.MapFrom(src => src.IDSalary));
            }
        }
        public class PayrollFormsModelToPayrollForms : Profile
        {
            public PayrollFormsModelToPayrollForms()
            {
                CreateMap<PayrollFormsModel, PayrollForms>()
                    .ForMember(dest => dest.IDEmployee, opt => opt.MapFrom(src => src.IDEmployee))
                    .ForMember(dest => dest.IDSalary, opt => opt.MapFrom(src => src.IDSalary));
            }
        }

        public class PositionToPositionsModel : Profile
        {
            public PositionToPositionsModel()
            {
                CreateMap<Position, PositionsModel>()
                    .ForMember(copy => copy.IDPosition, opt => opt.MapFrom(src => src.IDPosition))
                    .ForMember(copy => copy.NameOfPosition, opt => opt.MapFrom(src => src.NameOfPosition));
            }
        }
        public class PositionsModelToPosition : Profile
        {
            public PositionsModelToPosition()
            {
                CreateMap<PositionsModel, Position>()
                    .ForMember(copy => copy.IDPosition, opt => opt.MapFrom(src => src.IDPosition))
                    .ForMember(copy => copy.NameOfPosition, opt => opt.MapFrom(src => src.NameOfPosition));
            }
        }

        public class ResponsibilitiesToResponsibilitiesModel : Profile
        {
            public ResponsibilitiesToResponsibilitiesModel()
            {
                CreateMap<Responsibilities, ResponsibilitiesModel>()
                    .ForMember(dest => dest.IDPosition, opt => opt.MapFrom(src => src.IDPosition))
                    .ForMember(dest => dest.IDTask, opt => opt.MapFrom(src => src.IDTask));
            }
        }
        public class ResponsibilitiesModelToResponsibilities : Profile
        {
            public ResponsibilitiesModelToResponsibilities()
            {
                CreateMap<ResponsibilitiesModel, Responsibilities>()
                    .ForMember(dest => dest.IDPosition, opt => opt.MapFrom(src => src.IDPosition))
                    .ForMember(dest => dest.IDTask, opt => opt.MapFrom(src => src.IDTask));
            }
        }

        public class SalaryToSalaryModel : Profile
        {
            public SalaryToSalaryModel()
            {
                CreateMap<Salary, SalaryModel>()
                    .ForMember(dest => dest.IDSalary, opt => opt.MapFrom(src => src.IDSalary))
                    .ForMember(dest => dest.Amount, opt => opt.MapFrom(src => src.Amount))
                    .ForMember(dest => dest.DateOfPayment, opt => opt.MapFrom(src => src.DateOfPayment));
            }
        }
        public class SalaryModelToSalary : Profile
        {
            public SalaryModelToSalary()
            {
                CreateMap<SalaryModel, Salary>()
                    .ForMember(dest => dest.IDSalary, opt => opt.MapFrom(src => src.IDSalary))
                    .ForMember(dest => dest.Amount, opt => opt.MapFrom(src => src.Amount))
                    .ForMember(dest => dest.DateOfPayment, opt => opt.MapFrom(src => src.DateOfPayment));
            }
        }


        public class TaskToTaskModel : Profile
        {
            public TaskToTaskModel()
            {
                CreateMap<Task, TaskModel>()
                    .ForMember(dest => dest.IDTask, opt => opt.MapFrom(src => src.IDTask))
                    .ForMember(dest => dest.NameOfTask, opt => opt.MapFrom(src => src.NameOfTask));
            }
        }
        public class TaskModelToTask : Profile
        {
            public TaskModelToTask()
            {
                CreateMap<TaskModel, Task>()
                    .ForMember(dest => dest.IDTask, opt => opt.MapFrom(src => src.IDTask))
                    .ForMember(dest => dest.NameOfTask, opt => opt.MapFrom(src => src.NameOfTask));
            }
        }
    }
}