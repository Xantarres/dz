namespace ConsoleApp36
{
    public interface IContainer<T>
    {
        void AddItem(T item);
        T GetItem();
    }

    public class Storage<T> : IContainer<T>
    {
        private T item; 

        
        public void AddItem(T item)
        {
            this.item = item; 
        }

       
        public T GetItem()
        {
            return item; 
        }
    }

    class Program
    {
        static void Main()
        {
           
            IContainer<string> stringStorage = new Storage<string>();
            stringStorage.AddItem("Hello, World!");
            string retrievedItem = stringStorage.GetItem();

            Console.WriteLine($"извлечено из storage: {retrievedItem}"); 
        }
    }
}