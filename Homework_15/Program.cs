using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArithProgression progr = new ArithProgression();
            progr.setStart(10);
            Console.WriteLine(progr.getNext());
            Console.WriteLine(progr.getNext());
            Console.ReadKey();
            
        }
    }
    interface ISeries
    {
        int X { get; set; }
        void setStart(int x);
        int getNext();
        void reset();
    }
    class ArithProgression : ISeries
    {
        public int X { get; set; }
        public int X1 { get; set; }


        public void setStart(int x)
        {
            X = x;
            X1 = x;
        }

        public int getNext()
        {
            X1 = X1 + X;
            return X1;
        }

        public void reset()
        {
            X1 = X;
        }

    }
}
