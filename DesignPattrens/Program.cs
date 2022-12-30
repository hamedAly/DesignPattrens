using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattrens
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  Singleton.Instance.printName("Hamed");
            Console.WriteLine("Starting Main");
            // Invoke a static method on Test
            Test.EchoAndReturn("Echo!");
            Console.WriteLine("After echo");
            // Reference a static field in Test
            string y = Test.x;
            // Use the value just to avoid compiler cleverness
            if (y != null)
            {
                Console.WriteLine("After field access");
            }


            Console.ReadLine();
        }
    }
    public class BoilerControler
    {
        public bool IsEmpty { get; set; } = true;
        public bool Boiled { get; set; } = false;
        private static readonly object _object= new object();
        private readonly static Lazy<BoilerControler> lazy = new Lazy<BoilerControler>(() => new BoilerControler());

        private static BoilerControler instance = null;
        
        // using siple thread lock
        public static BoilerControler _Instance
        {
            get
            {
                lock (_object)
                {
                    if (instance == null)
                        instance = new BoilerControler();
                }
                return 
                    instance;
            }
        }

        // using siple thread lock and double check for un used unnessasery lock
        public static BoilerControler __Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (_object)
                    {
                        if (instance == null)
                            instance = new BoilerControler();
                    }
                }
                return
                    instance;
            }
        }
        
        // using lazy type in dot net 4 and higher

        private BoilerControler()
        {
        }
        public void printName()
        {
            Console.WriteLine("hamed");
        }
        public void fill()
        {
            if (IsEmpty)
            {
                // file 
                IsEmpty = false;
            }
        }
        public void boil()
        {
            if (!IsEmpty && !Boiled)
            {
                // boil 
                Boiled = true;
            }
        }
        public void drain()
        {
            if (!IsEmpty && Boiled)
            {
                // drain 
                IsEmpty = true;
                Boiled = false;
            }
        }
    }

    public class Singleton
    {
        private static readonly Singleton instance= new Singleton();
        public static Singleton Instance { get { return instance; } }
        static Singleton()
        {
        }
        private Singleton()
        {
        }

        public void printName(string name)
        {
            Console.WriteLine($"My Name : {name}");
        }
    }


    //public class BoilerControler
    //{
    //    public bool IsEmpty { get; set; } = true;
    //    public bool Boiled { get; set; } = false;
    //    private static readonly object lookObject = new object();
    //    private BoilerControler()
    //    {
    //    }

    //    // in case multi threading request the sampe option you can make the proptery with value EAGERLY LOADING  
    //    // private static BoilerControler UniqueBoilerControlerObj = new BoilerControler();

    //    private static BoilerControler UniqueBoilerControlerObj = null;


    //    // in case of multithread use the double check locking      
    //    //https://stackoverflow.com/questions/5950418/double-check-locking-in-singleton-pattern

    //    public static BoilerControler GetInstance()
    //    {
    //        if (UniqueBoilerControlerObj == null)
    //        {
    //            lock (lookObject)
    //            {
    //                if (UniqueBoilerControlerObj == null)
    //                    UniqueBoilerControlerObj = new BoilerControler();
    //            }
    //        }
    //        return UniqueBoilerControlerObj;
    //    }
    //    public void fill()
    //    {
    //        if (IsEmpty)
    //        {
    //            // file 
    //            IsEmpty = false;
    //        }
    //    }
    //    public void boil()
    //    {
    //        if (!IsEmpty && !Boiled)
    //        {
    //            // boil 
    //            Boiled = true;
    //        }
    //    }
    //    public void drain()
    //    {
    //        if (!IsEmpty && Boiled)
    //        {
    //            // drain 
    //            IsEmpty = true;
    //            Boiled = false;
    //        }
    //    }
    //}

    //public sealed class Singleton2
    //{
    //    private Singleton2()
    //    {
    //    }

    //    public static Singleton Instance { get { return Nested.instance; } }

    //    private class Nested
    //    {
    //        // Explicit static constructor to tell C# compiler
    //        // not to mark type as beforefieldinit
    //        static Nested()
    //        {
    //        }

    //        internal static readonly Singleton instance = new Singleton2();
    //    }
    //}


    class Test
    {
        static Test()
        {

        }
        public static string x = EchoAndReturn("In type initializer");
        public static string EchoAndReturn(string s)
        {
            Console.WriteLine(s);
            return s;
        }

    }

    class Driver
    {
        
    }
}
