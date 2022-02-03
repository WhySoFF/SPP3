using System;

namespace AssemblyBrowser
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\\Users\\mrsti\\VisualProjects\\Tracer\\ConsoleApp\\bin\\Debug\\TracerLib.dll";
            ReaderLibrary reader = new ReaderLibrary();
            reader.GetResult(path);
            Console.WriteLine(reader.ToString());
        }
    }
}

//@"C:\\Users\\mrsti\\VisualProjects\\Tracer\\ConsoleApp\\bin\\Debug\\TracerLib.dll";
//@"C:\Users\mrsti\VisualProjects\SPP3\TestClass\bin\Debug\net5.0\TestClass.dll";