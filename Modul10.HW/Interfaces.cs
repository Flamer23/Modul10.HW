using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul10.HW
{
    public interface ICalculator
    {
        void Calc(int a, int b);
    }

    public interface ILogger
    {
        void Log(string message);
    }
}
