using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    public abstract class StackADT
    {
        public int Size=0;

        protected int[] array;
        public abstract int Pop();
        public abstract int Push(int value);
        protected abstract bool isEmpty();
        public abstract string DisplayStack();
    }
}
