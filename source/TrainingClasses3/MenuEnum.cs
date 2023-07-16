using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingClasses3
{
    internal enum MenuEnum
    {
        /// <summary>
        /// Неопределённое значение
        /// </summary>
        None = 0,
        /// <summary>
        /// Пункт с добавлением сотрудника
        /// </summary>
        AddEmployee = 1,
        /// <summary>
        /// Пункт с вывода информации по всем сотрудникам
        /// </summary>
        ShowEmployee = 2,
        /// <summary>
        /// Пункт вывода суммы зарплат всех сотрудников
        /// </summary>
        ShowSumSalary =3,
        /// <summary>
        /// Закрыть приложение
        /// </summary>
        CloseApp = 4,
    }
}
