namespace ConsoleApp34
{
    class Stack<T>
    {
        private List<T> items; 

        public Stack()
        {
            items = new List<T>();
        }

        
        public void Push(T item)
        {
            items.Add(item);
        }

        
        public T Pop()
        {
            if (items.Count == 0)
            {
                throw new InvalidOperationException("стек пуст, невозможно извлечь.");
            }
            T item = items[items.Count - 1]; 
            items.RemoveAt(items.Count - 1); 
            return item;
        }

        
        public bool IsEmpty()
        {
            return items.Count == 0;
        }

        
        public int Count()
        {
            return items.Count;
        }
    }

    class Program
    {
        static void Main()
        {
            
            Stack<int> intStack = new Stack<int>();
            intStack.Push(1);
            intStack.Push(2);
            intStack.Push(3);
            Console.WriteLine($"извлечённый из стека int: {intStack.Pop()}"); 
            Console.WriteLine($"текущее количество в стеке int: {intStack.Count()}"); 

            
            Stack<string> stringStack = new Stack<string>();
            stringStack.Push("Hello");
            stringStack.Push("World");
            Console.WriteLine($"извлечённый из стека string: {stringStack.Pop()}"); 
            Console.WriteLine($"текущее количество в стеке string: {stringStack.Count()}"); 
        }
    }
}