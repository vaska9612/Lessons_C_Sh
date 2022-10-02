using System;
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
        }

        public int getNext(out X1)
        {
            X1 = X1 + X;
            retern X1;
        }

        public void reset()
        {
            throw new NotImplementedException();
        }

    }
}
