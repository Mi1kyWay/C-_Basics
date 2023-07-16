using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingClasses3
{
    /// <summary>
    /// Объявление класса Сотрудник
    /// </summary>
    internal class Employee
    {
            /// <summary>
            /// Объявление поле класса. Имя, возраст, должность
            /// </summary>
            private string _name;
            private int _age;
            private string _position;
            /// <summary>
            /// Объявление аксессера зарплата, так как его значение понадобится нам в Program для подсчета суммы зарплат всех сотрудников
            /// </summary>         
            public int _salary { get; set; }

            /// <summary>
            /// Объявление конструктора с параметрами
            /// </summary>
            public Employee(string name, int age, string position, int salary)
            {
                this._name = name;
                this._age = age;
                this._position = position;
                this._salary = salary;
            }
            /// <summary>
            /// Объявление конструктора без параметров
            /// </summary>
            public Employee() 
            { 
            }
            /// <summary>
            /// Объявление метода ТоString, для преобразования объекта в строковое представление. Для красивого вывода объявлена переменная info
            /// </summary>
            /// <returns> переопределённая строка info с информацией о сотруднике</returns>
            public override string ToString()
            {
                var info = $"Имя сотрудника: {_name} {Environment.NewLine}Возраст сотрудника: {_age} {Environment.NewLine}Позиция сотрудника: {_position} {Environment.NewLine}Зарплата сотрудника: {_salary}";
                return info;
            }
    }
}
