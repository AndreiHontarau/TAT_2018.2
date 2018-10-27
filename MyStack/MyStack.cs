using System;

namespace MyStack
{
    /// <summary>
    /// Represents a simple last-in-first-out (LIFO) collection of objects
    /// </summary>
    class MyStack <T>
    {
        private int capacity;
        private int size;
        private int head;
        private T[] stack;

        /// <summary>
        /// Initializes a new instance of the MyStack class that is empty and has the default initial capacity
        /// </summary>
        public MyStack()
        {
            capacity = 0;
            size = 0;
            head = -1;
        }

        /// <summary>
        /// Initializes a new instance of the Stack class that is empty and has the specified initial capacity
        /// </summary>
        /// <param name="InitialCapacity">Initial Capacity</param>
        public MyStack(int InitialCapacity)
        {
            capacity = InitialCapacity;
            size = InitialCapacity;
            stack = new T[InitialCapacity];
            head = -1;
        }

        /// <summary>
        /// Resizes stack to new capacity with loses if new capacity less than actual
        /// </summary>
        /// <param name="NewCpacity">New capacity</param>
        void Resize(int NewCpacity)
        {
            capacity = NewCpacity;
            size = NewCpacity;

            Array.Resize(ref stack, NewCpacity);
        }

        /// <summary>
        /// Inserts an element at the top of the stack if capacity is not reached
        /// </summary>
        /// <param name="NewElement">Object to insert</param>
        void Push(T NewElement)
        {
            if (size == capacity)
            {
                Console.WriteLine("Can't push an element: Maximum capacity reached.");
            }
            else
            {
                head++;
                stack[head] = NewElement;
                size++;
            }
        }

        /// <summary>
        /// Removes and returns the element at the top of the stack
        /// or null if stack is empty
        /// </summary>
        /// <returns>Removed element from the top of the stack</returns>
        T Pop()
        {
            T element;

            if (size == 0)
            {
                Console.WriteLine("Stack is empty");
                return default(T);
            }
            element = stack[head];
            head--;
            size--;
            return element;
        }

        /// <summary>
        /// Returns the element at the top of the stack without removing it
        /// or null if stack is empty
        /// </summary>
        /// <returns>The element at the top of the stack</returns>
        T GetHead()
        {
            if (size == 0)
            {
                Console.WriteLine("Stack is empty");
                return default(T);
            }
            else
            {
                return stack[head];
            }
        }
    }
}