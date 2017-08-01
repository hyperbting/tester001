using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Class4<T>
    {
        MockUpListElement<T> firstElement;

        public Class4(T _firstvalue)
        {
            firstElement = new MockUpListElement<T>(_firstvalue);
        }

        public void Add(T _element)
        {
            MockUpListElement<T> curr = firstElement;

            while (curr.nextElement != null)
                curr = curr.nextElement;

            curr.nextElement = new MockUpListElement<T>(_element);
        }

        //public void Insert(int _index, T _element)
        //{
        //    if (_index == 0)
        //    {
        //        MockUpListElement<T> newHead = new MockUpListElement<T>(_element);
        //        MockUpListElement<T> sec = firstElement;

        //        firstElement = newHead;
        //        firstElement.nextElement = sec;
        //        return;
        //    }

        //    //goto index then insert
        //}

        /// <summary>
        /// 
        /// </summary>
        /// <param name="_index">index of the list, start from 0</param>
        /// <returns>value extracted</returns>
        public T RemoveAt(int _index)
        {
            if (firstElement == null)
                return default(T);

            T tmpVal;
            MockUpListElement<T> curr = firstElement;
            MockUpListElement<T> previous = firstElement;

            if (_index == 0)
            {
                tmpVal = firstElement.value;

                if (firstElement.nextElement == null)
                    firstElement = null;
                else
                    firstElement = firstElement.nextElement;

                return tmpVal;
            }

            while (_index >= 0)
            {
                if (_index < 0)
                    return default(T);

                if (_index == 0)
                {
                    tmpVal = curr.value;
                    if (curr.nextElement == null)
                        previous.nextElement = null;//curr = null;
                    else
                        previous.nextElement = curr.nextElement; //curr = curr.nextElement;

                    return tmpVal;
                }

                _index--;
                previous = curr;
                if (curr.nextElement == null)
                    return default(T);
                else
                    curr = curr.nextElement;
            }

            return default(T);
        }

        public void Remove(T _target)
        {
            MockUpListElement<T> curr = firstElement;
            if (firstElement.value.ToString() == _target.ToString())
            {
                if (curr.nextElement != null)
                {
                    firstElement = firstElement.nextElement;
                    return;
                }
                else
                    firstElement = null;
            }

            while (curr.nextElement != null)
            {
                curr = curr.nextElement;

                if (curr.value.ToString() == _target.ToString())
                {
                    if (curr.nextElement != null)
                    {
                        curr.nextElement = curr.nextElement.nextElement;
                        return;
                    }
                    else
                        curr.nextElement = null;
                }
            }
        }

        public int Count()
        {
            MockUpListElement<T> curr = firstElement;
            int cou = 1;

            while (curr.nextElement != null)
            {
                cou++;
                curr = curr.nextElement;
            }

            return cou;
        }

        public override string ToString()
        {
            if (firstElement != null)
                return firstElement.ToString();
            else
                return "";
        }
    }

    public class MockUpListElement<T>
    {

        public T value;
        public MockUpListElement<T> nextElement = null;

        public MockUpListElement(T _val)
        {
            value = _val;
        }

        public override string ToString()
        {
            if(nextElement == null)
                return value.ToString();
            else
                return value.ToString() + " " + nextElement.ToString();
        }
    }
}
