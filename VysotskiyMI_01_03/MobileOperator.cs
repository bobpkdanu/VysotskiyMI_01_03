using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VysotskiyMI_01_03
{
    class MobileOperator
    {
        public string operName;
        public double operMinute;
        public double operPlosh;
        public double operQ;

        public double Qfunc(string name, double minute, double plosh)//Функция для вычисления Q оператора
        {
            operName = name;
            operMinute = minute;
            operPlosh = plosh;
            operQ = 100 * plosh / minute;
            return operQ;
        }

    }
}
