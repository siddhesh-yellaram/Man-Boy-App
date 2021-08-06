using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ManBoyApp.Model;

namespace ManBoyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Man x;
            x = new Boy();
            x.Play();
            x.Read();
            Console.ReadLine();
        }
    }
}
