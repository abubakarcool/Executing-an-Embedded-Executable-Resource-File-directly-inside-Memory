using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte[] resourceBuffer = null;
            Assembly aa= Assembly.GetExecutingAssembly();
            const string hhh = "ConsoleApp2.Resources.fsafsafsa";
            using(Stream resFilestream = aa.GetManifestResourceStream(hhh))
            {
                if(resFilestream == null)
                {
                    Console.WriteLine("empty");
                }
                else
                {
                    //Read from resourceStream to byte[]
                    resourceBuffer = new byte[resFilestream.Length];
                    resFilestream.Read(resourceBuffer, 0, resourceBuffer.Length);

                    
                }
            }
            //Load byte[] and execute the application from EntryPoint 
            Assembly.Load(resourceBuffer).EntryPoint.Invoke(null, new object[] { new string[] { "Form1"} });
        }
    }
}
