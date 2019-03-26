using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime now = DateTime.Now;
            string dt = now.ToString("yyyy-MM-dd");
            Console.WriteLine(dt);
            dynamic ex;
            ex = "Test";
            //exam = "Test";
            var test = "ABC";
            Console.WriteLine(test);
            test = "DEF";
            Console.WriteLine(test);
            object testing =10;
            Console.WriteLine(testing);
            testing = "ABC";
            Console.WriteLine(testing);
            dynamic testdyn = "ABC";
            Console.WriteLine(testdyn);
            testdyn = 10;
            Console.WriteLine(testdyn);
            A obj = new B();
            obj.Test();
            A obj1 = new C();
            obj1.Test();
            //B diff = new C();
            //diff.Test();
            //C n = new B();
            Console.ReadLine();            

            D objD = new D();
            objD.TestNew();
            D objE = new E();
            objE.TestNew();
            D objF = new F();
            objF.TestNew();
            Console.ReadLine();

            //TestPrivateCstor tst = new TestPrivateCstor();
            var singleton=singletonIns.Instance;
            Console.WriteLine(singleton.Count());
            var singleton2=singletonIns.Instance;
            Console.WriteLine(singleton2.Count());
            Console.ReadLine();
        }
    }

    //public class SingleDerived:singletonIns
    //{

    //}

    public class singletonIns
    {
        private singletonIns()
        {

        }

        int count;

        private static singletonIns _getInstance = null;

        public static singletonIns Instance
        {
            get
            {
                if (_getInstance == null)
                {
                    _getInstance = new singletonIns();
                }
                return _getInstance;
            }
        }

        public int Count()
        {
            return count++;
        }
        


    }

    public class A
    {
        //private A()
        //{ 
        //}
        public virtual void Test()
        {
            Console.WriteLine("Base Test");
        }

        //public virtual int Test()
        //{
        //    return 1;
        //}
    }

    public class B : A
    {
        public override void Test()
        {
            Console.WriteLine("Derived B Test");
        }
    }

    public class C : B
    {
        public override void Test()
        {
            Console.WriteLine("Derived C Test");
        }
    }

    public interface TestA
    {
        void Check();
    }

    public interface TestB
    {
        void Check();
    }

    public class interfaceTest : TestA, TestB
    {
        public void Check()
        {
            try
            {
                Console.WriteLine("Implementation");
            }
            catch (DivideByZeroException ex)
            {

            }
            catch (Exception ex)
            {

            }

        }

    }

    public class D
    {
        public virtual void TestNew()
        {
            Console.WriteLine("D New Test");
        }

        public void test(int A)
        {

        }

        public int test(int A, int B)
        {
            return 1;
        }
    }

    public class E : D
    {
        public new void TestNew()
        {
            Console.WriteLine("E New Test");
        }
    }

    public class F : E
    {
        public new void TestNew()
        {
            Console.WriteLine("F New Test");
        }
    }

    public class TestPrivateCstor
    {
        private TestPrivateCstor() { }
        //public TestPrivateCstor(int Test)
        //{

        //}
    }
}
