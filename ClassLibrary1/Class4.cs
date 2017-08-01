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
        public void Remove(T _target)
        {
            MockUpListElement<T> curr = firstElement;
            if (curr.value.ToString() == _target.ToString())
            {
                if (curr.nextElement != null)
                {
                    firstElement = curr.nextElement;
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
