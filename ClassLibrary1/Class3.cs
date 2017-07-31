using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Class3
    {
        public static RomanNumberSet rns;
        public Class3()
        {
            rns = new RomanNumberSet("I", "V");
            rns.nextSet = new RomanNumberSet("X", "L");
            rns.nextSet.nextSet = new RomanNumberSet("C", "D");
            rns.nextSet.nextSet.nextSet = new RomanNumberSet("M", "Z");
        }

        public string ShowRomanNumber(int _integer)
        {
            if (_integer <= 0)
                return "cannot recognize ZERO or Negative";

            RomanNumberSet current = Class3.rns;

            //string[] numbers = _integer.ToString().Split();
            int[] numbers = NumberToReversedIntArr(_integer);

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < numbers.Length; i++)
            {
                sb.Insert(0, current.ToNumber(numbers[i]) );
                current = current.nextSet;
            }
            return sb.ToString();
        }

        public int[] NumberToReversedIntArr(int _integer)
        {
            //return Array.ConvertAll(_integer.ToString().ToArray(), x=>(int)x);
            List<int> result = new List<int>();
            while (_integer != 0)
            {
                result.Add(_integer % 10);
                _integer /= 10;
            }
            return result.ToArray<int>();
        }
    }

    public class RomanNumberSet
    {
        public string one;
        public string five;
        public RomanNumberSet nextSet = null;

        public RomanNumberSet(string _one, string _five)
        {
            one = _one;
            five = _five;
        }

        public string ToNumber(int _singleNum)
        {

            string result = "";

            switch (_singleNum)
            {
                case 0:
                    return "";
                case 1:
                case 2:
                case 3:
                    for (int i = 0; i < _singleNum; i++)
                        result += one;
                    return result;
                case 4:
                    return one + five;
                case 5:
                case 6:
                case 7:
                case 8:
                    for (int i = 0; i < _singleNum-5; i++)
                        result += one;
                    return five + result;
                case 9:
                    if(nextSet == null)
                        return "nextSet is null";

                    return one + nextSet.one;
                default:
                    return _singleNum + " cannot be reconized";
            }
        }
    }
}
