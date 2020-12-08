using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volokhina.ASP.NET.Entities;
using Volokhina.ASP.NET.BLL;
using Volokhina.ASP.NET.BLL.Interface;

namespace Volokhina.ASP.NET.PL
{
    public static class LogicPL
    {
        private static IEmployeeLogic employeeLogic = new EmployeeLogic();
        private static IListOfWorkersLogic listOfWorkersLogic = new ListOfWorkersLogic();
        private static IPayrollFormsLogic payrollFormsLogic = new PayrollFormsLogic();
        private static IPositionLogic positionLogic = new PositionLogic();
        private static IResponsibilitiesLogic responsibilitiesLogic = new ResponsibilitiesLogic();
        private static ISalaryLogic salaryLogic = new SalaryLogic();
        private static ITaskLogic taskLogic = new TaskLogic();

        public static void AddEmployee()
        {
            Console.WriteLine("Введите ID");
            var idEmployee = Console.ReadLine();

            Console.WriteLine("Введите имя");
            var fullName = Console.ReadLine();

            Console.WriteLine("Введите возраст");
            var age = Console.ReadLine();

            Console.WriteLine("Введите номер телефона");
            var phoneNumber = Console.ReadLine();

            Console.WriteLine("Введите адрес электронной почты");
            var email = Console.ReadLine();

            Console.WriteLine("Введите адрес");
            var address = Console.ReadLine();

            var currentEmployee = new Employee()
            {
                IDEmployee = Int32.Parse(idEmployee),
                FullName = fullName,
                Age = Int32.Parse(age),
                PhoneNumber = phoneNumber,
                Email = email,
                Address = address
            };

            employeeLogic.AddEmployee(currentEmployee);
        }

        public static void AddListOfWorkers()
        {
            Console.WriteLine("Введите ID работника");
            var idEmployee = Console.ReadLine();

            Console.WriteLine("Введите ID должности");
            var idPosition = Console.ReadLine();

            var currentinfo = new ListOfWorkers()
            {
                IDEmployee = Int32.Parse(idEmployee),
                IDPosition = Int32.Parse(idPosition)
            };

            listOfWorkersLogic.AddListOfWorkers(currentinfo);
        }

        public static void AddPayrollForm()
        {
            Console.WriteLine("Введите ID зарплаты");
            var idSalary = Console.ReadLine();

            Console.WriteLine("Введите ID сотрудника");
            var idEmployee = Console.ReadLine();

            var currentinfo = new PayrollForms()
            {
                IDEmployee = Int32.Parse(idEmployee),
                IDSalary = Int32.Parse(idSalary)
            };

            payrollFormsLogic.AddPayrollForm(currentinfo);
        }

        public static void AddPosition()
        {
            Console.WriteLine("Введите ID должности");
            var idPosition = Console.ReadLine();

            Console.WriteLine("Введите название должности");
            var nameOfPosition = Console.ReadLine();

            var currentinfo = new Position()
            {
                IDPosition = Int32.Parse(idPosition),
                NameOfPosition = nameOfPosition
            };

            positionLogic.AddPosition(currentinfo);
        }

        public static void AddResponsibility()
        {
            Console.WriteLine("Введите ID должности");
            var idPosition = Console.ReadLine();

            Console.WriteLine("Введите ID задачи");
            var idTask = Console.ReadLine();

            var currentinfo = new Responsibilities()
            {
                IDPosition = Int32.Parse(idPosition),
                IDTask = Int32.Parse(idTask)
            };

            responsibilitiesLogic.AddResponsibility(currentinfo);
        }

        public static void AddSalary()
        {
            Console.WriteLine("Введите ID зарплаты");
            var idSalary = Console.ReadLine();

            Console.WriteLine("Введите дату выплаты");
            var dateOfPayment = Console.ReadLine();

            Console.WriteLine("Введите сумму");
            var amount = Console.ReadLine();

            var currentinfo = new Salary()
            {
                IDSalary = Int32.Parse(idSalary),
                DateOfPayment = DateTime.Parse(dateOfPayment),
                Amount = Int32.Parse(amount)
            };

            salaryLogic.AddSalary(currentinfo);
        }

        public static void AddTask()
        {
            Console.WriteLine("Введите ID задачи");
            var idTask = Console.ReadLine();

            Console.WriteLine("Введите задачу");
            var nameOfTask = Console.ReadLine();

            var currentinfo = new Entities.Task()
            {
                IDTask = Int32.Parse(idTask),
                NameOfTask = nameOfTask
            };

            taskLogic.AddTask(currentinfo);
        }

        public static void DeleteEmployee()
        {
            Console.WriteLine("Введите ID работника для удаления:");
            int value = int.Parse(Console.ReadLine());

            employeeLogic.DeleteEmployee(value);
        }

        public static void DeleteListOfWorkers()
        {
            Console.WriteLine("Введите ID работника для удаления:");
            int value = int.Parse(Console.ReadLine());

            listOfWorkersLogic.DeleteListOfWorkers(value);
        }

        public static void DeletePayrollForm()
        {
            Console.WriteLine("Введите ID работника для удаления:");
            int value = int.Parse(Console.ReadLine());

            payrollFormsLogic.DeletePayrollForm(value);
        }

        public static void DeletePosition()
        {
            Console.WriteLine("Введите ID должности для удаления:");
            int value = int.Parse(Console.ReadLine());

            positionLogic.DeletePosition(value);
        }

        public static void DeleteResponsibility()
        {
            Console.WriteLine("Введите ID должности для удаления:");
            int value = int.Parse(Console.ReadLine());

            responsibilitiesLogic.DeleteResponsibility(value);
        }

        public static void DeleteSalary()
        {
            Console.WriteLine("Введите ID зарплаты для удаления:");
            int value = int.Parse(Console.ReadLine());

            salaryLogic.DeleteSalary(value);
        }

        public static void DeleteTask()
        {
            Console.WriteLine("Введите ID задачи:");
            int value = int.Parse(Console.ReadLine());

            taskLogic.DeleteTask(value);
        }

        public static void GetAllEmployees()
        {
            var collection = employeeLogic.GetAllEmployees();
            foreach (var item in employeeLogic.GetAllEmployees())
            {
                Console.WriteLine(item);
            }
        }

        public static void GetAllListOfWorkers()
        {
            var collection = listOfWorkersLogic.GetAllListOfWorkers();
            foreach (var item in listOfWorkersLogic.GetAllListOfWorkers())
            {
                Console.WriteLine(item);
            }
        }

        public static void GetAllPayrollForms()
        {
            var collection = payrollFormsLogic.GetAllPayrollForms();
            foreach (var item in payrollFormsLogic.GetAllPayrollForms())
            {
                Console.WriteLine(item);
            }
        }

        public static void GetAllPositions()
        {
            var collection = positionLogic.GetAllPositions();
            foreach (var item in positionLogic.GetAllPositions())
            {
                Console.WriteLine(item);
            }
        }

        public static void GetAllResponsibilities()
        {
            var collection = responsibilitiesLogic.GetAllResponsibilities();
            foreach (var item in responsibilitiesLogic.GetAllResponsibilities())
            {
                Console.WriteLine(item);
            }
        }

        public static void GetAllSalaries()
        {
            var collection = salaryLogic.GetAllSalaries();
            foreach (var item in salaryLogic.GetAllSalaries())
            {
                Console.WriteLine(item);
            }
        }

        public static void GetAllTasks()
        {
            var collection = taskLogic.GetAllTasks();
            foreach (var item in taskLogic.GetAllTasks())
            {
                Console.WriteLine(item);
            }
        }
    }
}
