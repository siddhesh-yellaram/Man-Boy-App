using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManBoyApp.Model
{
    class Man
    {
        public virtual void Play()
        {
            Console.WriteLine("Man Plays...");
        }

        public void Read()
        {
            Console.WriteLine("Man Reads");
        }
    }
}
