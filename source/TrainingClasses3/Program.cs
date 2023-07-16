using System;
using System.Collections.Generic;


namespace TrainingClasses3
{
    internal class Program
    {     
        static void Main(string[] args)
        {
            var list = new List<Employee>();
            MenuEnum menuOption = MenuEnum.None;
            var sumSalary = 0;
            while (menuOption != MenuEnum.CloseApp)
            {
                Console.Clear();
                Console.WriteLine("1. Добавить нового сотрудника");
                Console.WriteLine("2. Вывести информацию о всех сотрудниках");
                Console.WriteLine("3. Вычислить общую сумму зарплат");
                Console.WriteLine("4. Выход");
                Console.WriteLine($"{Environment.NewLine}Выберите опцию");

                /// <summary>
                /// Читаем строку -> переводим в инт -> приводим к типу MenuEnum -> присваиваем в MenuOption
                /// </summary>
                menuOption = (MenuEnum)Convert.ToInt32(Console.ReadLine());
                switch (menuOption)
                {
                    case MenuEnum.AddEmployee:
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

                    case MenuEnum.ShowEmployee:
                        Console.Clear();
                        foreach (var addedEmployee in list)
                            Console.WriteLine(addedEmployee.ToString());
                        Console.ReadKey();
                        break;
                    case MenuEnum.ShowSumSalary:
                        foreach (var addedEmployee in list)
                            sumSalary += addedEmployee._salary;
                        Console.WriteLine("Сумма зарплат всех сотрудников: {0}", sumSalary);
                        Console.ReadKey();
                        break;
                    case MenuEnum.CloseApp:
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


