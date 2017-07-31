using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Class2
    {
        private int[] stored;
        #region constructor
        public Class2(int[] _intArr)
        {
            stored = _intArr;
            Array.Sort(stored, new Comparison<int>((i1, i2) => i2.CompareTo(i1)) );
        }

        public Class2():this(new int[] { 3,48,43,21,23,2})
        {
        }
        #endregion

        /// <summary>
        /// 
        /// </summary>
        /// <param name="_th">start from 1 to n</param>
        /// <returns></returns>
        public int FindTheThLargest(int _th)
        {
            int index = _th - 1;

            if (index < 0 || index >= stored.Length)
                return -1;

            return stored[index];
        }
    }
}
