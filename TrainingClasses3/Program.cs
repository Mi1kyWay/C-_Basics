using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingClasses3
{
    internal class Program
    {
        class Employee
        {
            string name;
            int age;
            string position;
            public int salary;

            public Employee(string name, int age, string position, int salary)
            {
                this.name = name;
                this.age = age;
                this.position = position;
                this.salary = salary;
            }

            public string EmployeeInfo()
            {
                string infoName = Convert.ToString(name);
                string infoAge = Convert.ToString(age);
                string infoSalary = Convert.ToString(salary);
                string infoPosition = Convert.ToString(position);

                string info = $"Имя сотрудника: {infoName} \nВозраст сотрудника: {infoAge} \nПозиция сотрудника: {infoPosition} \nЗарплата сотрудника: {infoSalary}";
                return info;
            }
        }
        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>();
            string userInput = " ";
            while (userInput != "4")
            {
                Console.Clear();
                Console.WriteLine("1. Добавить нового сотрудника");
                Console.WriteLine("2. Вывести информацию о всех сотрудниках");
                Console.WriteLine("3. Вычислить общую сумму зарплат");
                Console.WriteLine("4. Выход");
                Console.WriteLine("\nВыберите опцию");

                userInput = Convert.ToString(Console.ReadLine());
                int sumSalary = 0;
                switch (userInput)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("Введите данные нового сотрудника.");
                        Console.Write("Имя: ");
                        string name = Console.ReadLine();
                        Console.Write("Возраст: ");
                        int age = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Должность: ");
                        string position = Console.ReadLine();
                        Console.Write("Зарплата: ");
                        int salary = Convert.ToInt32(Console.ReadLine());
                        Employee employee = new Employee(name, age, position, salary);
                        list.Add(employee);
                        Console.Clear();
                        break;

                    case "2":
                        Console.Clear();
                        foreach (var addedEmployee in list)
                            Console.WriteLine(addedEmployee.EmployeeInfo());
                        Console.ReadKey();
                        break;
                    case "3":
                        foreach (var addedEmployee in list)
                            sumSalary += addedEmployee.salary;
                        Console.WriteLine("Сумма зарплат всех сотрудников: {0}", sumSalary);
                        Console.ReadKey();
                        break;
                    case "4":
                    return;
                    default:
                        Console.Clear();
                        Console.WriteLine("Некорректный ввод");
                        Console.ReadKey();
                        break;
                }
            }
        }
        }
}


