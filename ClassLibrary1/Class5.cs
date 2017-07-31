using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    interface IArithmetic<T>
    {
        T ArithmeticMethod(T val1, T val2);
        //T Add(T val1, T val2);
        //T Minus(T val1, T val2);
        //T Multiply(T val1, T val2);
        //T DivideBy(T val1, T val2);
    }

    public class Class5
    {
        public string UseAllClasses(int _v1, int _v2)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(new Add().ArithmeticMethod(_v1, _v2));
            sb.Append(" ");

            sb.Append(new Minus().ArithmeticMethod(_v1, _v2));
            sb.Append(" ");

            sb.Append(new Multiply().ArithmeticMethod(_v1, _v2));
            sb.Append(" ");

            sb.Append(new DivideBy().ArithmeticMethod(_v1, _v2));

            return sb.ToString();
        }
    }

    public class Add : IArithmetic<int>
    {
        public int ArithmeticMethod(int _v1, int _v2)
        {
            return _v1 + _v2;
        }
    }

    public class Minus : IArithmetic<int>
    {
        public int ArithmeticMethod(int _v1, int _v2)
        {
            return _v1 - _v2;
        }
    }

    public class Multiply : IArithmetic<int>
    {
        public int ArithmeticMethod(int _v1, int _v2)
        {
            return _v1 * _v2;
        }
    }

    public class DivideBy : IArithmetic<int>
    {
        public int ArithmeticMethod(int _v1, int _v2)
        {
            return _v1 / _v2;
        }
    }
}
