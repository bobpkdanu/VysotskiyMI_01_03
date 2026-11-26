using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VysotskiyMI_01_03
{
    class MobileOperatorP:MobileOperator //Класс наследник, от MobileOperator
    {
        public double Qp;

        public double QPFunc(bool p)//Функция для вычисления Qp
        {
            if (p == true)
            {
                Qp = Qfunc(operName, operMinute, operPlosh) * 0.5;
            }
            else
            {
                Qp = Qfunc(operName, operMinute, operPlosh) * 2.5;
            }
            return Qp;
        }
    }
}
