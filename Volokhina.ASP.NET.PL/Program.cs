using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volokhina.ASP.NET.PL
{
    class Program
    {
        static void Main(string[] args)
        {
            bool A = true;
            while (A)
            {
                Console.WriteLine("1 - добавить работника");
                Console.WriteLine("2 - удалить работника");
                Console.WriteLine("3 - вывести список работников");
                Console.WriteLine("4 - добавить должность сотруднику");
                Console.WriteLine("5 - удалить должность сотруднику");
                Console.WriteLine("6 - вывести список сотрудников по должностям");
                Console.WriteLine("7 - добавить зарплату сотруднику");
                Console.WriteLine("8 - удалить зарплату сотруднику");
                Console.WriteLine("9 - вывести список зарплат сотрудников");
                Console.WriteLine("10 - добавить должность");
                Console.WriteLine("11 - удалить должность");
                Console.WriteLine("12 - вывести список должностей");
                Console.WriteLine("13 - добавить задачу работнику");
                Console.WriteLine("14 - удалить задачу работнику");
                Console.WriteLine("15 - вывести список задач работников");
                Console.WriteLine("16 - добавить зарплату");
                Console.WriteLine("17 - удалить зарплату");
                Console.WriteLine("18 - вывести список зарплат");
                Console.WriteLine("19 - добавить задачу");
                Console.WriteLine("20 - удалить задачу");
                Console.WriteLine("21 - вывести список задач");
                Console.WriteLine();
                Console.WriteLine("Введите действие:");
                var action = Console.ReadLine();

                switch (action)
                {
                    case "1":
                        LogicPL.AddEmployee();
                        break;
                    case "2":
                        LogicPL.DeleteEmployee();
                        break;
                    case "3":
                        LogicPL.GetAllEmployees();
                        break;
                    case "4":
                        LogicPL.AddListOfWorkers();
                        break;
                    case "5":
                        LogicPL.DeleteListOfWorkers();
                        break;
                    case "6":
                        LogicPL.GetAllListOfWorkers();
                        break;
                    case "7":
                        LogicPL.AddPayrollForm();
                        break;
                    case "8":
                        LogicPL.DeletePayrollForm();
                        break;
                    case "9":
                        LogicPL.GetAllPayrollForms();
                        break;
                    case "10":
                        LogicPL.AddPosition();
                        break;
                    case "11":
                        LogicPL.DeletePosition();
                        break;
                    case "12":
                        LogicPL.GetAllPositions();
                        break;
                    case "13":
                        LogicPL.AddResponsibility();
                        break;
                    case "14":
                        LogicPL.DeleteResponsibility();
                        break;
                    case "15":
                        LogicPL.GetAllResponsibilities();
                        break;
                    case "16":
                        LogicPL.AddSalary();
                        break;
                    case "17":
                        LogicPL.DeleteSalary();
                        break;
                    case "18":
                        LogicPL.GetAllSalaries();
                        break;
                    case "19":
                        LogicPL.AddTask();
                        break;
                    case "20":
                        LogicPL.DeleteTask();
                        break;
                    case "21":
                        LogicPL.GetAllTasks();
                        break;
                    default:
                        A = false;
                        break;
                }
            }
        }
    }
}