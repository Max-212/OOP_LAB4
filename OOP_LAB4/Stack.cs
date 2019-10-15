using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_LAB4
{

    public class Owner
    {
        private string ID;
        private string name;

        public Owner(string ID, string name)
        {
            this.ID = ID;
            this.name = name;
        }
    }

    public class Stack<T> : ICloneable
    {

        public object Clone()
        {
            T[] arr = new T[this.items.Length];
            for(int i = 0; i < arr.Length; i++)
                arr[i] = items[i];
            

            return new Stack<T> { count = this.count, owner = this.owner, data = this.data, items = arr };
        }

        private T[] items; // элементы стека
        private int count;  // количество элементов
        private const int n = 10;   // количество элементов в массиве по умолчанию
        // конструкторы +375333874633
        public Stack()
        {
            items = new T[n];
        }
        public Stack(int length)
        {
            items = new T[length];
        }

        // размер стека
        public int Count
        {
            get { return count; }
        }


        // не пуст ли стек?
        public static bool operator true(Stack<T> stack)
        {
            return stack.Count == 0;
        }
        public static bool operator false(Stack<T> stack)
        {
            return stack.Count != 0;
        }

        // добаление элемента
        public static Stack<T> operator +(Stack<T> stack, T item)
        {
            // если стек заполнен, выбрасываем исключение
            if (stack.count == stack.items.Length)
                throw new InvalidOperationException("Переполнение стека");
            stack.items[stack.count++] = item;
            return stack;
        }

        // извлечь элемент из стека
        public static Stack<T> operator --(Stack<T> stack)
        {
            // если стек пуст, выбрасываем исключение
            if (stack)
                throw new InvalidOperationException("Стек пуст");
            T item = stack.items[--stack.count];
            stack.items[stack.count] = default(T); // сбрасываем ссылку
            return stack;
        }

        // сложить два стека
        public static Stack<T> operator <(Stack<T> stack1, Stack<T> stack2)
        {
            Stack<T> stack = (Stack<T>)stack2.Clone();
            T[] arr = new T[stack2.Count];

            for (int i = 0; i < stack.Count; i++)
            {
                arr[i] = stack.Top();
                stack--;
            }
            Array.Sort(arr);
            for (int i = 0; i < arr.Length; i++)
            {
                stack1 = stack1 + arr[i];
            }
            return stack1;
        }
        public static Stack<T> operator >(Stack<T> stack1, Stack<T> stack2)
        {
            Stack<T> stack = (Stack<T>)stack2.Clone();
            T[] arr = new T[stack2.Count];

            for (int i = 0; i < stack.Count; i++)
            {
                arr[i] = stack.Top();
                stack--;
            }
            Array.Sort(arr);
            for (int i = 0; i < arr.Length; i++)
            {
                stack1 = stack1 + arr[i];
            }
            return stack1;
        }

        // возвращаем элемент из верхушки стека
        public T Top()
        {
            return items[count - 1];
        }

        // владелец
        public Owner owner = new Owner("753951", "Trifonov Maxim");

        // дата
        public class Date
        {
            private readonly DateTime data;
            public Date()
            {
                data = DateTime.Now;
            }
        }
        private Date data = new Date();
        public Date Data
        {
            get
            {
                return data;
            }
        }

    }

}

