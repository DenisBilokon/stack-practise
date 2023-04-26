using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace stac.Model
{
    public class ArrayStack<T> //На основе массива
    {
            T[] items;
        private int current = -1;
        private readonly int size = 10;

        public int Count => items.Length;
        
        public ArrayStack(int size = 10) //Присваивамые переменные ставяться ВКОНЦЕ (особенность компилятора)
            
        {
            items = new T[size];
            this.size = size;
        }

        public ArrayStack(T data, int size = 10) : this(size)
        {
            items[0] = data;
            current = 1;
        }

        public void Push(T data)
        {
            if(current < size - 1)
            {
                current++;
                items[current] = data;
            }
        else
            {
                throw new StackOverflowException("Стек переполнен");
            }
        }
        public T Pop()
        { 
            if (current >= 0)
            {
                var item = items[current];
                current--;
                return item;
            }
            else
            {
                throw new NullReferenceException("стек пуст");
            }
        }
        public T Peek()
        {
            if (current >= 0)
            {
                return items[current];
            }
            else
            {
                throw new NullReferenceException("стек пуст");
            }
        }
    }
}
