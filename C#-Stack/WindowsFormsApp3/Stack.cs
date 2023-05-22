using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    class Stack : StackADT
    {
        public Stack(int maxSize)
        {
            this.maxSize = maxSize;
            array = new int[maxSize];
        }
        public override string DisplayStack()
        {
            int[] temporary = array;
            string data = "";
            for(int i =0;i<Size;i++)
                data += temporary[Size - i-1];
            return data;
        }

        public override int Pop()
        {
            Size--;
            array[Size] = 0;
            Top = array[Size-1];
            return array[Size];
        }

        public override int Push(int value)
        {
            if (Size == maxSize)
                throw new NullReferenceException();
            array[Size] = value;
            Top = array[Size];
            Size++;
            return array[maxSize - 1];
        }

        protected override bool isEmpty()
        {
            if (Size == 0)
                return true;
            return false;
        }
    }
}
