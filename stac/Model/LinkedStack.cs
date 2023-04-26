using System;

namespace stac.Model
{
    public class LinkedStack<T> //ТУт мы имеес доступ только к верхнему элементув в отлчии от Linked Liist
    {
        public Item<T> Root { get; set; }

        public Item<T> Head { get; set; }
        public int Count { get; set; }
        public LinkedStack() 
        {
       
            Root = null;
            Head = null;
            Count = 0;

        }
        public  LinkedStack(T data)
        {
            Head = new Item<T>(data);
            Count = 1;
        }

        public void Push(T data)
        {
            var item = new Item<T>(data);
            item.Previous = Head;
            Head = item;
            Count++;
        }

        public T Pop()
        {
            var item = Head;
            Head = Head.Previous;
            Count--;
            return item.Data;
        }

        public T Peek()
        {
            return Head.Data;
        }

    }
}
