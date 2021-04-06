using System;

namespace SavingInterface
{
    class TodoList : IDisplayable, IRestable
    {
        //Fields

        //Properties
        public string[] Todos
        { get; private set; }

        private int nextOpenIndex;

        //Constructors
        public TodoList()
        {
            Todos = new string[5];
            nextOpenIndex = 0;
        }

        //Methods
        public void Add(string todo)
        {
            if (nextOpenIndex >= Todos.Length)
            {
                Console.WriteLine("**Error**");
                Console.WriteLine("You can only have 5 item on your list");
                nextOpenIndex--;
            }
            else
            {
                Todos[nextOpenIndex] = todo;
                nextOpenIndex++;
            }
        }

        //Interface
        public void Display()
        {
            
            Console.WriteLine("");
            foreach (string todos in Todos)
            {
                if (String.IsNullOrEmpty(todos))
                {
                    Console.WriteLine("[]");
                }
                else
                {
                    Console.WriteLine(todos);
                }

            }
        }
        public void Reset()
        {
            Todos = new string[5];
            nextOpenIndex = 0;
        }
    }
}