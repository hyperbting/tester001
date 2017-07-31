using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{

    public abstract class AgeHandler
    {
        protected int min = 1;
        protected int max = 17;
        protected AgeHandler nextHandler = null;

        public AgeHandler(AgeHandler _next)
        {
            nextHandler = _next;
        }

        public virtual void HandleRequest(int _age)
        {
            if (nextHandler != null)
                nextHandler.HandleRequest(_age);
        }
    }

    public class Class6
    {
        public void DoCOR(int _age)
        {
            AgeHandler ageHandler = new YoungAgeHandler(null);
            AgeHandler ageHandler2 = new MiddleAgeHandler(ageHandler);
            AgeHandler ageHandler3 = new ElderAgeHandler(ageHandler2);

            ageHandler3.HandleRequest(_age);
        }
    }

    public class YoungAgeHandler: AgeHandler
    {
        new int min = 1;
        new int max = 17;

        public YoungAgeHandler(AgeHandler _aH):base(_aH)
        {
        }

        public override void HandleRequest(int _age)
        {
            if (_age >= min && _age <= max)
            {
                //TODO:依序詢問身高、體重、居住地
            }
            else
                base.HandleRequest(_age);
        }
    }

    public class MiddleAgeHandler : AgeHandler
    {
        new int min = 18;
        new int max = 40;

        public MiddleAgeHandler(AgeHandler _aH) : base(_aH)
        {
        }

        public override void HandleRequest(int _age)
        {
            if (_age >= min && _age <= max)
            {
                //TODO:依序詢問身高、體重、居住地、婚姻狀況
            }
            else
                base.HandleRequest(_age);
        }
    }

    public class ElderAgeHandler : AgeHandler
    {
        new int min = 41;
        new int max = 999;

        public ElderAgeHandler(AgeHandler _aH) : base(_aH)
        {
        }

        public override void HandleRequest(int _age)
        {
            if (_age >= min && _age <= max)
            {
                //TODO:依序詢問居住地、婚姻狀況、兒女數量
            }
            else
                base.HandleRequest(_age);
        }
    }
}
