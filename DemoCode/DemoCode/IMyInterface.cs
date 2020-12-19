using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoCode
{
    public interface IMyInterface
    {
        string results { get; set; }
        void Dosomething(int value);
    }

    public class Myclass : IMyInterface
    {
        public string results { get; set; }

        public void Dosomething(int value)
        {
            results = $"Did something with value: {value}";
        }
    }

    public class MyClassImplementsMyInterface
    {

        public IMyInterface _myClass;

        public MyClassImplementsMyInterface(IMyInterface myclass)
        {
            _myClass = myclass;
        }

        public string DoSomething(int value)
        {
            _myClass.Dosomething(value);
            return _myClass.results;
        }
    }
}
